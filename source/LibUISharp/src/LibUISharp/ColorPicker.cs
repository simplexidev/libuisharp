﻿using LibUISharp.Drawing;
using LibUISharp.Internal;
using System;
using static LibUISharp.Internal.Libraries;

namespace LibUISharp
{
    /// <summary>
    /// Represents a common button that allows a user to choose a <see cref="Drawing.Color"/>.
    /// </summary>
    [LibuiType("uiColorButton")]
    public class ColorPicker : Control
    {
        private Color color;

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPicker"/> class.
        /// </summary>
        public ColorPicker()
        {
            Handle = Libui.Call<Libui.uiNewColorButton>()();
            color = Color.Empty;
            InitializeEvents();
        }

        /// <summary>
        /// Occurs when the <see cref="Color"/> property is changed.
        /// </summary>
        public event EventHandler ColorChanged;

        /// <summary>
        /// Gets or sets the color selected by the user.
        /// </summary>
        public Color Color
        {
            get
            {
                Libui.Call<Libui.uiColorButtonColor>()(this, out double red, out double green, out double blue, out double alpha);
                color = new Color(red, green, blue, alpha);
                return color;
            }
            set
            {
                if (color != value)
                {
                    Libui.Call<Libui.uiColorButtonSetColor>()(this, value.R, value.G, value.B, value.A);
                    color = value;
                }
            }
        }

        /// <summary>
        /// Initializes this UI component's events.
        /// </summary>
        protected sealed override void InitializeEvents() => Libui.Call<Libui.uiColorButtonOnChanged>()(this, (button, data) => { OnColorChanged(EventArgs.Empty); }, IntPtr.Zero);

        /// <summary>
        /// Raises the <see cref="ColorChanged"/> event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnColorChanged(EventArgs e) => ColorChanged?.Invoke(this, e);
    }
}