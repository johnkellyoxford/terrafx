// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ unsafe struct VkImageViewCreateInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        [ComAliasName("VkImageViewCreateFlags")]
        public uint flags;

        [ComAliasName("VkImage")]
        public ulong image;

        public VkImageViewType viewType;

        public VkFormat format;

        public VkComponentMapping components;

        public VkImageSubresourceRange subresourceRange;
        #endregion
    }
}