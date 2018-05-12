// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\oaidl.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ struct ELEMDESC
    {
        #region Fields
        public TYPEDESC tdesc;

        public _u_e__Union u;
        #endregion

        #region Structs
        [StructLayout(LayoutKind.Explicit)]
        public /* unmanaged */ struct _u_e__Union
        {
            #region Fields
            [FieldOffset(0)]
            public IDLDESC idldesc;

            [FieldOffset(0)]
            public PARAMDESC paramdesc;
            #endregion
        }
        #endregion
    }
}