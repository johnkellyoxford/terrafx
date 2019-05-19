// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;
using TerraFX.Utilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    /// <summary>Paints an area with a radial gradient.</summary>
    [Guid("2CD906AC-12E2-11DC-9FED-001143A055F9")]
    [Unmanaged]
    public unsafe struct ID2D1RadialGradientBrush
    {
        #region Fields
        public readonly Vtbl* lpVtbl;
        #endregion

        #region IUnknown Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("HRESULT")]
        public /* static */ delegate int _QueryInterface(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _AddRef(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("ULONG")]
        public /* static */ delegate uint _Release(
            [In] ID2D1RadialGradientBrush* This
        );
        #endregion

        #region ID2D1Resource Delegates
        /// <summary>Retrieve the factory associated with this resource.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetFactory(
            [In] ID2D1RadialGradientBrush* This,
            [Out] ID2D1Factory** factory
        );
        #endregion

        #region ID2D1Brush Delegates
        /// <summary>Sets the opacity for when the brush is drawn over the entire fill of the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetOpacity(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("FLOAT")] float opacity
        );

        /// <summary>Sets the transform that applies to everything drawn by the brush.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetTransform(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetOpacity(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetTransform(
            [In] ID2D1RadialGradientBrush* This,
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        );
        #endregion

        #region Delegates
        /// <summary>Sets the center of the radial gradient. This will be in local coordinates and will not depend on the geometry being filled.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetCenter(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center
        );

        /// <summary>Sets offset of the origin relative to the radial gradient center.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetGradientOriginOffset(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetRadiusX(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("FLOAT")] float radiusX
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _SetRadiusY(
            [In] ID2D1RadialGradientBrush* This,
            [In, NativeTypeName("FLOAT")] float radiusY
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public /* static */ delegate D2D_POINT_2F* _GetCenter(
            [In] ID2D1RadialGradientBrush* This,
            [Out] D2D_POINT_2F* _result
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("D2D1_POINT_2F")]
        public /* static */ delegate D2D_POINT_2F* _GetGradientOriginOffset(
            [In] ID2D1RadialGradientBrush* This,
            [Out] D2D_POINT_2F* _result
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetRadiusX(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public /* static */ delegate float _GetRadiusY(
            [In] ID2D1RadialGradientBrush* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.StdCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void _GetGradientStopCollection(
            [In] ID2D1RadialGradientBrush* This,
            [Out] ID2D1GradientStopCollection** gradientStopCollection
        );
        #endregion

        #region IUnknown Methods
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface(
            [In, NativeTypeName("REFIID")] Guid* riid,
            [Out] void** ppvObject
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return MarshalFunction<_QueryInterface>(lpVtbl->QueryInterface)(
                    This,
                    riid,
                    ppvObject
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return MarshalFunction<_AddRef>(lpVtbl->AddRef)(
                    This
                );
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
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
            fixed (ID2D1RadialGradientBrush* This = &this)
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
            [In, NativeTypeName("FLOAT")] float opacity
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_SetOpacity>(lpVtbl->SetOpacity)(
                    This,
                    opacity
                );
            }
        }

        public void SetTransform(
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_SetTransform>(lpVtbl->SetTransform)(
                    This,
                    transform
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetOpacity()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return MarshalFunction<_GetOpacity>(lpVtbl->GetOpacity)(
                    This
                );
            }
        }

        public void GetTransform(
            [Out, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* transform
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_GetTransform>(lpVtbl->GetTransform)(
                    This,
                    transform
                );
            }
        }
        #endregion

        #region Methods
        public void SetCenter(
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_SetCenter>(lpVtbl->SetCenter)(
                    This,
                    center
                );
            }
        }

        public void SetGradientOriginOffset(
            [In, NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F gradientOriginOffset
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_SetGradientOriginOffset>(lpVtbl->SetGradientOriginOffset)(
                    This,
                    gradientOriginOffset
                );
            }
        }

        public void SetRadiusX(
            [In, NativeTypeName("FLOAT")] float radiusX
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_SetRadiusX>(lpVtbl->SetRadiusX)(
                    This,
                    radiusX
                );
            }
        }

        public void SetRadiusY(
            [In, NativeTypeName("FLOAT")] float radiusY
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_SetRadiusY>(lpVtbl->SetRadiusY)(
                    This,
                    radiusY
                );
            }
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetCenter()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                D2D_POINT_2F result;
                return *MarshalFunction<_GetCenter>(lpVtbl->GetCenter)(
                    This,
                    &result
                );
            }
        }

        [return: NativeTypeName("D2D1_POINT_2F")]
        public D2D_POINT_2F GetGradientOriginOffset()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                D2D_POINT_2F result;
                return *MarshalFunction<_GetGradientOriginOffset>(lpVtbl->GetGradientOriginOffset)(
                    This,
                    &result
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetRadiusX()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return MarshalFunction<_GetRadiusX>(lpVtbl->GetRadiusX)(
                    This
                );
            }
        }

        [return: NativeTypeName("FLOAT")]
        public float GetRadiusY()
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                return MarshalFunction<_GetRadiusY>(lpVtbl->GetRadiusY)(
                    This
                );
            }
        }

        public void GetGradientStopCollection(
            [Out] ID2D1GradientStopCollection** gradientStopCollection
        )
        {
            fixed (ID2D1RadialGradientBrush* This = &this)
            {
                MarshalFunction<_GetGradientStopCollection>(lpVtbl->GetGradientStopCollection)(
                    This,
                    gradientStopCollection
                );
            }
        }
        #endregion

        #region Structs
        [Unmanaged]
        public struct Vtbl
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
            public IntPtr SetCenter;

            public IntPtr SetGradientOriginOffset;

            public IntPtr SetRadiusX;

            public IntPtr SetRadiusY;

            public IntPtr GetCenter;

            public IntPtr GetGradientOriginOffset;

            public IntPtr GetRadiusX;

            public IntPtr GetRadiusY;

            public IntPtr GetGradientStopCollection;
            #endregion
        }
        #endregion
    }
}
