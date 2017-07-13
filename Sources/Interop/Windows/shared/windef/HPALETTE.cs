// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\windef.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    unsafe public /* blittable */ struct HPALETTE : IEquatable<HPALETTE>, IFormattable
    {
        #region Fields
        internal HANDLE _value;
        #endregion

        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="HPALETTE" /> struct.</summary>
        /// <param name="value">The <see cref="HANDLE" /> used to initialize the instance.</param>
        public HPALETTE(HANDLE value)
        {
            _value = value;
        }
        #endregion

        #region Comparison Operators
        /// <summary>Compares two <see cref="HPALETTE" /> instances to determine equality.</summary>
        /// <param name="left">The <see cref="HPALETTE" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="HPALETTE" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(HPALETTE left, HPALETTE right)
        {
            return (left._value == right._value);
        }

        /// <summary>Compares two <see cref="HPALETTE" /> instances to determine inequality.</summary>
        /// <param name="left">The <see cref="HPALETTE" /> to compare with <paramref name="right" />.</param>
        /// <param name="right">The <see cref="HPALETTE" /> to compare with <paramref name="left" />.</param>
        /// <returns><c>true</c> if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, <c>false</c>.</returns>
        public static bool operator !=(HPALETTE left, HPALETTE right)
        {
            return (left._value != right._value);
        }
        #endregion

        #region Cast Operators
        /// <summary>Explicitly converts a <see cref="HPALETTE" /> value to a <see cref="uint" /> value.</summary>
        /// <param name="value">The <see cref="HPALETTE" /> value to convert.</param>
        public static explicit operator uint(HPALETTE value)
        {
            return (uint)(value._value);
        }

        /// <summary>Implicitly converts a <see cref="HPALETTE" /> value to a <see cref="void" />* value.</summary>
        /// <param name="value">The <see cref="HPALETTE" /> value to convert.</param>
        public static implicit operator void* (HPALETTE value)
        {
            return value._value;
        }

        /// <summary>Implicitly converts a <see cref="HPALETTE" /> value to a <see cref="HANDLE" /> value.</summary>
        /// <param name="value">The <see cref="HPALETTE" /> value to convert.</param>
        public static implicit operator HANDLE(HPALETTE value)
        {
            return value._value;
        }

        /// <summary>Explicitly converts a <see cref="uint" /> value to a <see cref="HPALETTE" /> value.</summary>
        /// <param name="value">The <see cref="uint" /> value to convert.</param>
        public static explicit operator HPALETTE(uint value)
        {
            return new HPALETTE((HANDLE)(value));
        }

        /// <summary>Implicitly converts a <see cref="void" />* value to a <see cref="HPALETTE" /> value.</summary>
        /// <param name="value">The <see cref="void" />* value to convert.</param>
        public static implicit operator HPALETTE(void* value)
        {
            return new HPALETTE(value);
        }

        /// <summary>Implicitly converts a <see cref="HANDLE" /> value to a <see cref="HPALETTE" /> value.</summary>
        /// <param name="value">The <see cref="HANDLE" /> value to convert.</param>
        public static implicit operator HPALETTE(HANDLE value)
        {
            return new HPALETTE(value);
        }
        #endregion

        #region System.IEquatable<HPALETTE> Methods
        /// <summary>Compares a <see cref="HPALETTE" /> with the current instance to determine equality.</summary>
        /// <param name="other">The <see cref="HPALETTE" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="other" /> is equal to the current instance; otherwise, <c>false</c>.</returns>
        public bool Equals(HPALETTE other)
        {
            var otherValue = other._value;
            return _value.Equals(otherValue);
        }
        #endregion

        #region System.IFormattable Methods
        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <param name="format">The format to use or <c>null</c> to use the default format.</param>
        /// <param name="formatProvider">The provider to use when formatting the current instance or <c>null</c> to use the default provider.</param>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return _value.ToString(format, formatProvider);
        }
        #endregion

        #region System.Object Methods
        /// <summary>Compares a <see cref="object" /> with the current instance to determine equality.</summary>
        /// <param name="obj">The <see cref="object" /> to compare with the current instance.</param>
        /// <returns><c>true</c> if <paramref name="obj" /> is an instance of <see cref="HPALETTE" /> and is equal to the current instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return (obj is HPALETTE other)
                && Equals(other);
        }

        /// <summary>Gets a hash code for the current instance.</summary>
        /// <returns>A hash code for the current instance.</returns>
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        /// <summary>Converts the current instance to an equivalent <see cref="string" /> value.</summary>
        /// <returns>An equivalent <see cref="string" /> value for the current instance.</returns>
        public override string ToString()
        {
            return _value.ToString();
        }
        #endregion
    }
}
