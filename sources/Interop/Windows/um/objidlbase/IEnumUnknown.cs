// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\objidlbase.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("00000100-0000-0000-C000-000000000046")]
    public /* unmanaged */ unsafe struct IEnumUnknown
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IEnumUnknown* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IEnumUnknown* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IEnumUnknown* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Next(
            [In] IEnumUnknown* This,
            [In, ComAliasName("ULONG")] uint celt,
            [Out] IUnknown** rgelt,
            [Out, ComAliasName("ULONG")] uint* pceltFetched = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Skip(
            [In] IEnumUnknown* This,
            [In, ComAliasName("ULONG")] uint celt
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Reset(
            [In] IEnumUnknown* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _Clone(
            [In] IEnumUnknown* This,
            [Out] IEnumUnknown** ppenum = null
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint AddRef()
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int Next(
            [In, ComAliasName("ULONG")] uint celt,
            [Out] IUnknown** rgelt,
            [Out, ComAliasName("ULONG")] uint* pceltFetched = null
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_Next>(lpVtbl->Next)(
                    This,
                    celt,
                    rgelt,
                    pceltFetched
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Skip(
            [In, ComAliasName("ULONG")] uint celt
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_Skip>(lpVtbl->Skip)(
                    This,
                    celt
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Reset()
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_Reset>(lpVtbl->Reset)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int Clone(
            [Out] IEnumUnknown** ppenum = null
        )
        {
            fixed (IEnumUnknown* This = &this)
            {
                return MarshalFunction<_Clone>(lpVtbl->Clone)(
                    This,
                    ppenum
                );
            }
        }
        #endregion

        #region Structs
        public /* unmanaged */ struct Vtbl
        {
            #region IUnknown Fields
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;
            #endregion

            #region Fields
            public IntPtr Next;

            public IntPtr Skip;

            public IntPtr Reset;

            public IntPtr Clone;
            #endregion
        }
        #endregion
    }
}
