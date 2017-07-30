// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CLIPFORMAT" /> struct.</summary>
    public static class CLIPFORMATTests
    {
        /// <summary>Validates that the layout of the <see cref="CLIPFORMAT" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CLIPFORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="CLIPFORMAT" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<CLIPFORMAT>(), Is.EqualTo(2));
        }
    }
}