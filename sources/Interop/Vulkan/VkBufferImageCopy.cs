// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ struct VkBufferImageCopy
    {
        #region Fields
        [ComAliasName("VkDeviceSize")]
        public ulong bufferOffset;

        public uint bufferRowLength;

        public uint bufferImageHeight;

        public VkImageSubresourceLayers imageSubresource;

        public VkOffset3D imageOffset;

        public VkExtent3D imageExtent;
        #endregion
    }
}