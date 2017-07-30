// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="LCID" /> struct.</summary>
    public static class LCIDTests
    {
        /// <summary>Validates that the layout of the <see cref="LCID" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(LCID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="LCID" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<LCID>(), Is.EqualTo(4));
        }
    }
}