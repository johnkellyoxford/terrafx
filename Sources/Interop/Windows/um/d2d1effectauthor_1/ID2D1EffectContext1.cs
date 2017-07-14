// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    /// <summary>The internal context handed to effect authors to create transforms from effects and any other operation tied to context which is not useful to the application facing API.</summary>
    [Guid("84AB595A-FC81-4546-BACD-E8EF4D8ABE7A")]
    unsafe public /* blittable */ struct ID2D1EffectContext1
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        /// <summary>Creates a 3D lookup table for mapping a 3-channel input to a 3-channel output. The table data must be provided in 4-channel format.</summary>
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateLookupTable3D(
            [In] ID2D1EffectContext1* This,
            [In] D2D1_BUFFER_PRECISION precision,
            [In] /* readonly */ UINT32 *extents,
            [In]  /* readonly */ BYTE* data,
            [In] UINT32 dataCount,
            [In] /* readonly */ UINT32* strides,
            [Out] ID2D1LookupTable3D** lookupTable 
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public ID2D1EffectContext.Vtbl BaseVtbl;

            public CreateLookupTable3D CreateLookupTable3D;
            #endregion
        }
        #endregion
    }
}