// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Composition;
using System.Runtime.InteropServices;
using TerraFX.Interop;
using TerraFX.UI;
using TerraFX.Utilities;
using static TerraFX.Interop.X11;
using static TerraFX.Utilities.AssertionUtilities;
using static TerraFX.Utilities.ExceptionUtilities;
using static TerraFX.Utilities.State;

namespace TerraFX.Provider.X11.UI
{
    /// <summary>Provides access to an X11 based window subsystem.</summary>
    [Export(typeof(IWindowProvider))]
    [Export(typeof(WindowProvider))]
    [Shared]
    public sealed unsafe class WindowProvider : IDisposable, IWindowProvider
    {
        private const int False = 0;
        private const int Success = 0;

        #region Fields
        /// <summary>The <see cref="DispatchProvider" /> for the instance.</summary>
        private readonly Lazy<DispatchProvider> _dispatchProvider;

        /// <summary>A map of <c>Window</c> to <see cref="Window" /> objects created for the instance.</summary>
        private readonly ConcurrentDictionary<IntPtr, Window> _windows;

        /// <summary>The <see cref="State" /> of the instance.</summary>
        private State _state;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="WindowProvider" /> class.</summary>
        [ImportingConstructor]
        public WindowProvider(
            [Import] Lazy<DispatchProvider> dispatchProvider
        )
        {
            _dispatchProvider = dispatchProvider;
            _windows = new ConcurrentDictionary<IntPtr, Window>();
            _state.Transition(to: Initialized);
        }
        #endregion

        #region Destructors
        /// <summary>Finalizes an instance of the <see cref="WindowProvider" /> class.</summary>
        ~WindowProvider()
        {
            Dispose(isDisposing: false);
        }
        #endregion

        #region Properties
        /// <summary>Gets the <see cref="DispatchProvider" /> for the instance.</summary>
        public DispatchProvider DispatchProvider
        {
            get
            {
                _state.ThrowIfDisposedOrDisposing();
                return _dispatchProvider.Value;
            }
        }
        #endregion

        #region TerraFX.UI.IWindowProvider Properties
        /// <summary>Gets the <see cref="IWindow" /> objects created by the instance.</summary>
        public IEnumerable<IWindow> Windows
        {
            get
            {
                return _state.IsNotDisposedOrDisposing ? (IEnumerable<IWindow>)_windows : Array.Empty<IWindow>();
            }
        }
        #endregion

        #region Static Methods
        /// <summary>Forwards native window messages to the appropriate <see cref="Window" /> instance for processing.</summary>
        /// <param name="windowProviderProperty">The property used to get the <see cref="WindowProvider" /> associated with the event.</param>
        /// <param name="xevent">The event to be processed.</param>
        /// <exception cref="ExternalException">The call to <see cref="XGetWindowProperty(XDisplay*, UIntPtr, UIntPtr, IntPtr, IntPtr, int, UIntPtr, UIntPtr*, int*, UIntPtr*, UIntPtr*, byte**)" /> failed.</exception>
        internal static void ForwardWindowEvent(UIntPtr windowProviderProperty, in XEvent xevent)
        {
            byte* prop;

            var result = XGetWindowProperty(
                xevent.xany.display,
                xevent.xany.window,
                windowProviderProperty,
                IntPtr.Zero,
                (IntPtr)(IntPtr.Size >> 2),
                False,
                (UIntPtr)32,
                null,
                null,
                null,
                null,
                &prop
            );

            if (result != Success)
            {
                ThrowExternalException(nameof(XGetWindowProperty), result);
            }

            var windowProvider = (WindowProvider)GCHandle.FromIntPtr((IntPtr)prop).Target;

            if (windowProvider._windows.TryGetValue((IntPtr)(void*)xevent.xany.window, out var window))
            {
                window.ProcessWindowEvent(in xevent);
            }
        }
        #endregion

        #region Methods
        /// <summary>Disposes of any unmanaged resources associated with the instance.</summary>
        /// <param name="isDisposing"><c>true</c> if called from <see cref="Dispose()" />; otherwise, <c>false</c>.</param>
        private void Dispose(bool isDisposing)
        {
            var priorState = _state.BeginDispose();

            if (priorState < Disposing)
            {
                DisposeWindows(isDisposing);
            }

            _state.EndDispose();
        }

        /// <summary>Disposes of all <see cref="Window" /> objects that were created by the instance.</summary>
        /// <param name="isDisposing"><c>true</c> if called from <see cref="Dispose()" />; otherwise, <c>false</c>.</param>
        private void DisposeWindows(bool isDisposing)
        {
            _state.AssertDisposing();

            if (isDisposing)
            {
                foreach (var windowHandle in _windows.Keys)
                {
                    if (_windows.TryRemove(windowHandle, out var createdWindow))
                    {
                        createdWindow.Dispose();
                    }
                }
            }
            else
            {
                _windows.Clear();
            }

            Assert(_windows.IsEmpty, Resources.ArgumentOutOfRangeExceptionMessage, nameof(_windows.IsEmpty), _windows.IsEmpty);
        }
        #endregion

        #region System.IDisposable Methods
        /// <summary>Disposes of any unmanaged resources tracked by the instance.</summary>
        public void Dispose()
        {
            Dispose(isDisposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region TerraFX.UI.IWindowProvider Methods
        /// <summary>Create a new <see cref="IWindow"/> instance.</summary>
        /// <returns>A new <see cref="IWindow" /> instance</returns>
        /// <exception cref="ObjectDisposedException">The instance has already been disposed.</exception>
        public IWindow CreateWindow()
        {
            _state.ThrowIfDisposedOrDisposing();

            var window = new Window(this);
            _windows.TryAdd(window.Handle, window);

            return window;
        }
        #endregion
    }
}
