﻿using System;
using LibUISharp.Internal;

namespace LibUISharp
{
    /// <summary>
    /// Represents a control that is used to separate user-interface (UI) content.
    /// </summary>
    [NativeType("uiSeparator")]
    public class Separator : Control
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Separator"/> class with the specified orientation.
        /// </summary>
        /// <param name="orientation">The specified orientation.</param>
        public Separator(Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.Horizontal:
                    Handle = NativeCalls.NewHorizontalSeparator();
                    break;
                case Orientation.Vertical:
                    Handle = NativeCalls.NewVerticalSeparator();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(orientation));
            }
            Orientation = orientation;
        }

        /// <summary>
        /// Gets this <see cref="Separator"/> object's orientation.
        /// </summary>
        public Orientation Orientation { get; }
    }
}