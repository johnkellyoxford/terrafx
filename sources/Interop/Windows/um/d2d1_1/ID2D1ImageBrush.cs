// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Provides a brush that can take any effect, command list or bitmap and use it to fill a 2D shape.</summary>
    [Guid("FE9E984D-3F95-407C-B5DB-CB94D4E8F87C")]
    public /* unmanaged */ unsafe struct ID2D1ImageBrush
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1ImageBrush* This,
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1ImageBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1ImageBrush* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1ImageBrush* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Brush Delegates
        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetOpacity(
            [In] ID2D1ImageBrush* This,
            [In, ComAliasName("FLOAT")] float opacity
        );

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1ImageBrush* This,
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: ComAliasName("FLOAT")]
        public /* static */ delegate float _GetOpacity(
            [In] ID2D1ImageBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1ImageBrush* This,
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetImage(
            [In] ID2D1ImageBrush* This,
            [In] ID2D1Image* image = null
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetExtendModeX(
            [In] ID2D1ImageBrush* This,
            [In] D2D1_EXTEND_MODE extendModeX
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetExtendModeY(
            [In] ID2D1ImageBrush* This,
            [In] D2D1_EXTEND_MODE extendModeY
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetInterpolationMode(
            [In] ID2D1ImageBrush* This,
            [In] D2D1_INTERPOLATION_MODE interpolationMode
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetSourceRectangle(
            [In] ID2D1ImageBrush* This,
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetImage(
            [In] ID2D1ImageBrush* This,
            [Out] ID2D1Image** image
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeX(
            [In] ID2D1ImageBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_EXTEND_MODE _GetExtendModeY(
            [In] ID2D1ImageBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D2D1_INTERPOLATION_MODE _GetInterpolationMode(
            [In] ID2D1ImageBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetSourceRectangle(
            [In] ID2D1ImageBrush* This,
            [Out, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        );
        #endregion

        #region IUnknown Methods
        [return: ComAliasName("HRESULT")]
        public int QueryInterface(
            [In, ComAliasName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: ComAliasName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1ImageBrush* This = &this)
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
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_GetFactory>(lpVtbl->GetFactory)(
                    This,
                    factory
                );
            }
        }
        #endregion

        #region ID2D1Brush Methods
        public void SetOpacity(
            [In, ComAliasName("FLOAT")] float opacity
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetOpacity>(lpVtbl->SetOpacity)(
                    This,
                    opacity
                );
            }
        }

        public void SetTransform(
            [In, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: ComAliasName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return MarshalFunction<_GetOpacity>(lpVtbl->GetOpacity)(
                    This
                );
            }
        }

        public void GetTransform(
            [Out, ComAliasName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }
        #endregion

        #region Methods
        public void SetImage(
            [In] ID2D1Image* image = null
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetImage>(lpVtbl->SetImage)(
                    This,
                    image
                );
            }
        }

        public void SetExtendModeX(
            [In] D2D1_EXTEND_MODE extendModeX
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetExtendModeX>(lpVtbl->SetExtendModeX)(
                    This,
                    extendModeX
                );
            }
        }

        public void SetExtendModeY(
            [In] D2D1_EXTEND_MODE extendModeY
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetExtendModeY>(lpVtbl->SetExtendModeY)(
                    This,
                    extendModeY
                );
            }
        }

        public void SetInterpolationMode(
            [In] D2D1_INTERPOLATION_MODE interpolationMode
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetInterpolationMode>(lpVtbl->SetInterpolationMode)(
                    This,
                    interpolationMode
                );
            }
        }

        public void SetSourceRectangle(
            [In, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_SetSourceRectangle>(lpVtbl->SetSourceRectangle)(
                    This,
                    sourceRectangle
                );
            }
        }

        public void GetImage(
            [Out] ID2D1Image** image
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_GetImage>(lpVtbl->GetImage)(
                    This,
                    image
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeX()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return MarshalFunction<_GetExtendModeX>(lpVtbl->GetExtendModeX)(
                    This
                );
            }
        }

        public D2D1_EXTEND_MODE GetExtendModeY()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return MarshalFunction<_GetExtendModeY>(lpVtbl->GetExtendModeY)(
                    This
                );
            }
        }

        public D2D1_INTERPOLATION_MODE GetInterpolationMode()
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                return MarshalFunction<_GetInterpolationMode>(lpVtbl->GetInterpolationMode)(
                    This
                );
            }
        }

        public void GetSourceRectangle(
            [Out, ComAliasName("D2D1_RECT_F")] D2D_RECT_F* sourceRectangle
        )
        {
            fixed (ID2D1ImageBrush* This = &this)
            {
                MarshalFunction<_GetSourceRectangle>(lpVtbl->GetSourceRectangle)(
                    This,
                    sourceRectangle
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

            #region ID2D1Brush Fields
            public IntPtr SetOpacity;

            public IntPtr SetTransform;

            public IntPtr GetOpacity;

            public IntPtr GetTransform;
            #endregion

            #region Fields
            public IntPtr SetImage;

            public IntPtr SetExtendModeX;

            public IntPtr SetExtendModeY;

            public IntPtr SetInterpolationMode;

            public IntPtr SetSourceRectangle;

            public IntPtr GetImage;

            public IntPtr GetExtendModeX;

            public IntPtr GetExtendModeY;

            public IntPtr GetInterpolationMode;

            public IntPtr GetSourceRectangle;
            #endregion
        }
        #endregion
    }
}
