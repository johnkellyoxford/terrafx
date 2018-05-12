// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
namespace TerraFX.Interop
{
    public /* unmanaged */ unsafe struct DXGI_MAPPED_RECT
    {
        #region Fields
        [ComAliasName("INT")]
        public int Pitch;

        [ComAliasName("BYTE[]")]
        public byte* pBits;
        #endregion
    }
}