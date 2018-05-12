// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public /* unmanaged */ unsafe struct DXGI_OUTPUT_DESC
    {
        #region Fields
        [ComAliasName("WCHAR[32]")]
        public fixed char DeviceName[32];

        public RECT DesktopCoordinates;

        [ComAliasName("BOOL")]
        public int AttachedToDesktop;

        public DXGI_MODE_ROTATION Rotation;

        [ComAliasName("HMONITOR")]
        public IntPtr Monitor;
        #endregion
    }
}