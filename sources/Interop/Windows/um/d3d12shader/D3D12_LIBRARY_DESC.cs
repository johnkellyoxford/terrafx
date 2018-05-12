// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ unsafe struct D3D12_LIBRARY_DESC
    {
        #region Fields
        [ComAliasName("LPCSTR")]
        public sbyte* Creator;

        [ComAliasName("UINT")]
        public uint Flags;

        [ComAliasName("UINT")]
        public uint FunctionCount;
        #endregion
    }
}