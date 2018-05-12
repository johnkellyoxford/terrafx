// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Guid("DAAC296F-7AA5-4DBF-8D15-225C5976F891")]
    public /* unmanaged */ unsafe struct IWICProgressiveLevelControl
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] IWICProgressiveLevelControl* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] IWICProgressiveLevelControl* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] IWICProgressiveLevelControl* This
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetLevelCount(
            [In] IWICProgressiveLevelControl* This,
            [Out, ComAliasName("UINT")] uint* pcLevels
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _GetCurrentLevel(
            [In] IWICProgressiveLevelControl* This,
            [Out, ComAliasName("UINT")] uint* pnLevel
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _SetCurrentLevel(
            [In] IWICProgressiveLevelControl* This,
            [In, ComAliasName("UINT")] uint nLevel
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
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
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return MarshalFunction<_Release>(lpVtbl->Release)(
                    This
                );
            }
        }
        #endregion

        #region Methods
        [return: ComAliasName("HRESULT")]
        public int GetLevelCount(
            [Out, ComAliasName("UINT")] uint* pcLevels
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return MarshalFunction<_GetLevelCount>(lpVtbl->GetLevelCount)(
                    This,
                    pcLevels
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int GetCurrentLevel(
            [Out, ComAliasName("UINT")] uint* pnLevel
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return MarshalFunction<_GetCurrentLevel>(lpVtbl->GetCurrentLevel)(
                    This,
                    pnLevel
                );
            }
        }

        [return: ComAliasName("HRESULT")]
        public int SetCurrentLevel(
            [In, ComAliasName("UINT")] uint nLevel
        )
        {
            fixed (IWICProgressiveLevelControl* This = &this)
            {
                return MarshalFunction<_SetCurrentLevel>(lpVtbl->SetCurrentLevel)(
                    This,
                    nLevel
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
            public IntPtr GetLevelCount;

            public IntPtr GetCurrentLevel;

            public IntPtr SetCurrentLevel;
            #endregion
        }
        #endregion
    }
}
