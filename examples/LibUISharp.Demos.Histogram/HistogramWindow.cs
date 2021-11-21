using System;
using System.Collections.Generic;
using LibUISharp.Drawing;

namespace LibUISharp.Demos.Histogram
{
    public class HistogramWindow : Window
    {
        private StackContainer hPanel = new StackContainer(Orientation.Horizontal) { IsPadded = true };
        private StackContainer vPanel = new StackContainer(Orientation.Vertical) { IsPadded = true };
        private List<SpinBox> spinBoxList = new List<SpinBox>();
        private ColorPicker colorPicker = new ColorPicker() { Color = Colors.Blue };
        private Surface histogramSurface;

        public HistogramWindow() : base("LibUISharp Histogram Demo", 640, 480, true) => InitializeComponent();

        protected override void InitializeComponent()
        {
            IsMargined = true;
            Child = hPanel;
            
            hPanel.Items.Add(vPanel);
            
            for (int i = 0; i < 10; i++)
            {
                SpinBox spinBox = new SpinBox(0, 100) { Value = new Random(DateTime.Now.Millisecond).Next(0, 101) };
                spinBox.ValueChanged += SpinBoxOnValueChanged;
                vPanel.Items.Add(spinBox);
                spinBoxList.Add(spinBox);
            }
            
            colorPicker.ColorChanged += (sender, args) => { histogramSurface.QueueRedrawAll(); };

            vPanel.Items.Add(colorPicker);

            histogramSurface = new Surface(new SurfaceHandler(colorPicker, spinBoxList));
            hPanel.Items.Add(histogramSurface, true);
        }

        private void SpinBoxOnValueChanged(object sender, EventArgs eventArgs) => histogramSurface.QueueRedrawAll();
    }
}