// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_3.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>Produces 2D pixel data that has been sourced from WIC.</summary>
    [Guid("77395441-1C8F-4555-8683-F50DAB0FE792")]
    unsafe public /* blittable */ struct ID2D1ImageSourceFromWic
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT EnsureCached(
            [In] ID2D1ImageSourceFromWic* This,
            [In, Optional] /* readonly */ D2D1_RECT_U* rectangleToFill
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT TrimCache(
            [In] ID2D1ImageSourceFromWic* This,
            [In, Optional] /* readonly */ D2D1_RECT_U* rectangleToPreserve
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void GetSource(
            [In] ID2D1ImageSourceFromWic* This,
            [Out] IWICBitmapSource** wicBitmapSource
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public ID2D1ImageSource.Vtbl BaseVtbl;

            public EnsureCached EnsureCached;

            public TrimCache TrimCache;

            public GetSource GetSource;
            #endregion
        }
        #endregion
    }
}