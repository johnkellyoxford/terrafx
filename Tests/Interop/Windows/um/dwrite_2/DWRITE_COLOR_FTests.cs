// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;
using NUnit.Framework;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_COLOR_F" /> struct.</summary>
    public static class DWRITE_COLOR_FTests
    {
        /// <summary>Validates that the layout of the <see cref="DWRITE_COLOR_F" /> struct is <see cref="LayoutKind.Explicit" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(DWRITE_COLOR_F).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="DWRITE_COLOR_F" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_COLOR_F>(), Is.EqualTo(16));
        }
    }
}