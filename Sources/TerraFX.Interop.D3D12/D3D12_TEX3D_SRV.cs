// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.D3D12
{
    public struct D3D12_TEX3D_SRV
    {
        #region Fields
        public uint MostDetailedMip;

        public uint MipLevels;

        public float ResourceMinLODClamp;
        #endregion
    }
}
