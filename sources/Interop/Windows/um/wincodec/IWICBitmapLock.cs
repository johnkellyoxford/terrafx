// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("00000123-A8F2-4877-BA0A-FD2B6645FB94")]
    public /* unmanaged */ unsafe struct IWICBitmapLock
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICBitmapLock* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICBitmapLock* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICBitmapLock* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetSize(
            [In] IWICBitmapLock* This,
            [Out, ComAliasName("UINT")] uint* puiWidth,
            [Out, ComAliasName("UINT")] uint* puiHeight
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetStride(
            [In] IWICBitmapLock* This,
            [Out, ComAliasName("UINT")] uint* pcbStride
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetDataPointer(
            [In] IWICBitmapLock* This,
            [Out, ComAliasName("UINT")] uint* pcbBufferSize,
            [Out, ComAliasName("WICInProcPointer[]")] byte** ppbData = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetPixelFormat(
            [In] IWICBitmapLock* This,
            [Out, ComAliasName("WICPixelFormatGUID")] Guid* pPixelFormat
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICBitmapLock* This = &this)
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
            fixed (IWICBitmapLock* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int GetSize(
            [Out, ComAliasName("UINT")] uint* puiWidth,
            [Out, ComAliasName("UINT")] uint* puiHeight
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return MarshalFunction<_GetSize>(lpVtbl->GetSize)(
                    This,
                    puiWidth,
                    puiHeight
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetStride(
            [Out, ComAliasName("UINT")] uint* pcbStride
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return MarshalFunction<_GetStride>(lpVtbl->GetStride)(
                    This,
                    pcbStride
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetDataPointer(
            [Out, ComAliasName("UINT")] uint* pcbBufferSize,
            [Out, ComAliasName("WICInProcPointer[]")] byte** ppbData = null
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return MarshalFunction<_GetDataPointer>(lpVtbl->GetDataPointer)(
                    This,
                    pcbBufferSize,
                    ppbData
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetPixelFormat(
            [Out, ComAliasName("WICPixelFormatGUID")] Guid* pPixelFormat
        )
        {
            fixed (IWICBitmapLock* This = &this)
            {
                return MarshalFunction<_GetPixelFormat>(lpVtbl->GetPixelFormat)(
                    This,
                    pPixelFormat
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
            public IntPtr GetSize;

            public IntPtr GetStride;

            public IntPtr GetDataPointer;

            public IntPtr GetPixelFormat;
            #endregion
        }
        #endregion
    }
}
