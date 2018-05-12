// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ struct D3D12_FEATURE_DATA_D3D12_OPTIONS1
    {
        #region Fields
        [ComAliasName("BOOL")]
        public int WaveOps;

        [ComAliasName("UINT")]
        public uint WaveLaneCountMin;

        [ComAliasName("UINT")]
        public uint WaveLaneCountMax;

        [ComAliasName("UINT")]
        public uint TotalLaneCount;

        [ComAliasName("BOOL")]
        public int ExpandedComputeResourceStates;

        [ComAliasName("BOOL")]
        public int Int64ShaderOps;
        #endregion
    }
}