// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ struct D3D12_RT_FORMAT_ARRAY
    {
        #region Fields
        [ComAliasName("DXGI_FORMAT[8]")]
        public _RTFormats_e__FixedBuffer RTFormats;

        [ComAliasName("UINT")]
        public uint NumRenderTargets;
        #endregion

        #region Structs
        public /* unmanaged */ unsafe struct _RTFormats_e__FixedBuffer
        {
            #region Fields
            public DXGI_FORMAT e0;

            public DXGI_FORMAT e1;

            public DXGI_FORMAT e2;

            public DXGI_FORMAT e3;

            public DXGI_FORMAT e4;

            public DXGI_FORMAT e5;

            public DXGI_FORMAT e6;

            public DXGI_FORMAT e7;
            #endregion

            #region Properties
            public DXGI_FORMAT this[int index]
            {
                get
                {
                    fixed (DXGI_FORMAT* e = &e0)
                    {
                        return e[index];
                    }
                }

                set
                {
                    fixed (DXGI_FORMAT* e = &e0)
                    {
                        e[index] = value;
                    }
                }
            }
            #endregion
        }
        #endregion
    }
}