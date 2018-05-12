// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from src\spec\vk.xml in the Vulkan-Docs repository for tag v1.0.51-core
// Original source is Copyright © 2015-2017 The Khronos Group Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public /* unmanaged */ unsafe struct VkBindSparseInfo
    {
        #region Fields
        public VkStructureType sType;

        public void* pNext;

        public uint waitSemaphoreCount;

        [ComAliasName("VkSemaphore[]")]
        public ulong* pWaitSemaphores;

        public uint bufferBindCount;

        [ComAliasName("VkSparseBufferMemoryBindInfo[]")]
        public VkSparseBufferMemoryBindInfo* pBufferBinds;

        public uint imageOpaqueBindCount;

        [ComAliasName("VkSparseImageOpaqueMemoryBindInfo[]")]
        public VkSparseImageOpaqueMemoryBindInfo* pImageOpaqueBinds;

        public uint imageBindCount;

        [ComAliasName("VkSparseImageMemoryBindInfo[]")]
        public VkSparseImageMemoryBindInfo* pImageBinds;

        public uint signalSemaphoreCount;

        [ComAliasName("VkSemaphore[]")]
        public ulong* pSignalSemaphores;
        #endregion
    }
}