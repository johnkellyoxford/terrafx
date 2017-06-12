// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.DXGI.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_RGB" /> struct.</summary>
    public static class DXGI_RGBTests
    {
        /// <summary>Validates that the layout of the <see cref="DXGI_RGB" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_RGB).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DXGI_RGB" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_RGB>(), Is.EqualTo(12));
        }
    }
}