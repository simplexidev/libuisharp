﻿using System;
using static LibUISharp.Native.NativeMethods;

namespace LibUISharp.Drawing
{
    /// <summary>
    /// Defines a text font.
    /// </summary>
    public class Font : IEquatable<Font>
    {
        internal Libui.uiFontDescriptor Native;

        /// <summary>
        /// Initializes a new instance of the <see cref="Font"/> structure
        /// </summary>
        /// <param name="family">The specified font family name.</param>
        /// <param name="size">The size of the font.</param>
        /// <param name="weight">The font weight.</param>
        /// <param name="style">The style of the font.</param>
        /// <param name="stretch">The width of the font.</param>
        public Font(string family, double size, FontWeight weight = FontWeight.Normal, FontStyle style = FontStyle.Normal, FontStretch stretch = FontStretch.Normal) => Native = new Libui.uiFontDescriptor()
        {
            Family = family,
            Size = size,
            Weight = weight,
            Style = style,
            Stretch = stretch
        };

        /// <summary>
        /// Gets the font family of this <see cref="Font"/>.
        /// </summary>
        public string Family => Native.Family;

        /// <summary>
        /// Gets the size of this <see cref="Font"/>.
        /// </summary>
        public double Size => Native.Size;

        /// <summary>
        /// Gets the weight of this <see cref="Font"/>.
        /// </summary>
        public FontWeight Weight => Native.Weight;

        /// <summary>
        /// Gets the style of this <see cref="Font"/>.
        /// </summary>
        public FontStyle Style => Native.Style;

        /// <summary>
        /// Gets the stretch (width) of this <see cref="Font"/>.
        /// </summary>
        public FontStretch Stretch => Native.Stretch;

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="obj">The object to compare with the current instance.</param>
        /// <returns>true if obj and this instance are the same type and represent the same value; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Font))
                return false;
            return Equals((Font)obj);
        }

        /// <summary>
        /// Indicates whether this instance and a specified object are equal.
        /// </summary>
        /// <param name="font">The font to compare with the current instance.</param>
        /// <returns>true if obj and this instance are the same type and represent the same value; otherwise, false.</returns>
        public bool Equals(Font font) => this == font;

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
        public override int GetHashCode() => unchecked(this.GetHashCode(Family, Size, Weight, Style, Stretch));

        /// <summary>
        /// Converts this font to a human-readable string.
        /// </summary>
        /// <returns>A string that represents this point.</returns>
        public override string ToString() => $"[{Family}: {Size}]";

        /// <summary>
        /// Tests whether two specified <see cref="Font"/> structures are equivalent.
        /// </summary>
        /// <param name="left">The <see cref="Font"/> that is to the left of the equality operator.</param>
        /// <param name="right">The <see cref="Font"/> that is to the right of the equality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Font"/> structures are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Font left, Font right) => left.Family == right.Family && left.Size == right.Size && left.Stretch == right.Stretch && left.Style == right.Style && left.Weight == right.Weight;

        /// <summary>
        /// Tests whether two specified <see cref="Font"/> structures are different.
        /// </summary>
        /// <param name="left">The <see cref="Font"/> that is to the left of the inequality operator.</param>
        /// <param name="right">The <see cref="Font"/> that is to the right of the inequality operator.</param>
        /// <returns><see langword="true"/> if the two <see cref="Font"/> structures are different; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Font left, Font right) => !(left == right);
    }
}