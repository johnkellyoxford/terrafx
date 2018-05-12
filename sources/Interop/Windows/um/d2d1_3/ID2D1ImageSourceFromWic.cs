// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Produces 2D pixel data that has been sourced from WIC.</summary>
    [Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
    public /* unmanaged */ unsafe struct ID2D1ImageSourceFromWic
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ImageSourceFromWic* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ImageSourceFromWic* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ImageSourceFromWic* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1ImageSourceFromWic* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1ImageSource Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _OfferResources(
            [In] ID2D1ImageSourceFromWic* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _TryReclaimResources(
            [In] ID2D1ImageSourceFromWic* This,
            [Out, ComAliasName("BOOL")] int* resourcesDiscarded
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _EnsureCached(
            [In] ID2D1ImageSourceFromWic* This,
            [In, ComAliasName("D2D1_RECT_U")] D2D_RECT_U* rectangleToFill = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _TrimCache(
            [In] ID2D1ImageSourceFromWic* This,
            [In, ComAliasName("D2D1_RECT_U")] D2D_RECT_U* rectangleToPreserve = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetSource(
            [In] ID2D1ImageSourceFromWic* This,
            [Out] IWICBitmapSource** wicBitmapSource
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
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
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region ID2D1Resource Methods
        public void GetFactory(
            [Out] ID2D1Factory** factory
        )
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1ImageSource Methods
        [return: ComAliasName("HRESULT")]
        public int OfferResources()
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return MarshalFunction<_OfferResources>(lpVtbl->OfferResources)(
                    This
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int TryReclaimResources(
            [Out, ComAliasName("BOOL")] int* resourcesDiscarded
        )
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return MarshalFunction<_TryReclaimResources>(lpVtbl->TryReclaimResources)(
                    This,
                    resourcesDiscarded
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int EnsureCached(
            [In, ComAliasName("D2D1_RECT_U")] D2D_RECT_U* rectangleToFill = null
        )
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return MarshalFunction<_EnsureCached>(lpVtbl->EnsureCached)(
                    This,
                    rectangleToFill
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int TrimCache(
            [In, ComAliasName("D2D1_RECT_U")] D2D_RECT_U* rectangleToPreserve = null
        )
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                return MarshalFunction<_TrimCache>(lpVtbl->TrimCache)(
                    This,
                    rectangleToPreserve
                );
            }
        }

        public void GetSource(
            [Out] IWICBitmapSource** wicBitmapSource
        )
        {
            fixed (ID2D1ImageSourceFromWic* This = &this)
            {
                MarshalFunction<_GetSource>(lpVtbl->GetSource)(
                    This,
                    wicBitmapSource
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

            #region ID2D1Resource Fields
            public IntPtr GetFactory;
            #endregion

            #region ID2D1ImageSource Fields
            public IntPtr OfferResources;

            public IntPtr TryReclaimResources;
            #endregion

            #region Fields
            public IntPtr EnsureCached;

            public IntPtr TrimCache;

            public IntPtr GetSource;
            #endregion
        }
        #endregion
    }
}
