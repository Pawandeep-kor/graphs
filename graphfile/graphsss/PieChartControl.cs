using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GraphsApp
{
    public partial class PieChartControl : UserControl
    {
        // Data for the pie chart
        public List<int> PieData { get; set; }
        public List<Color> PieColors { get; set; }

        public PieChartControl()
        {
            InitializeComponent();
            this.PieData = new List<int> { 50, 30, 20 }; // Sample data
            this.PieColors = new List<Color> { Color.Red, Color.Green, Color.Blue }; // Colors
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (PieData == null || PieData.Count == 0 || PieColors == null || PieColors.Count != PieData.Count)
                return;

            Graphics g = e.Graphics;

            // Define the rectangle for the pie chart
            Rectangle pieRect = new Rectangle(10, 10, this.Width - 20, this.Height - 20);

            // Calculate the total sum of data
            int total = PieData.Sum();

            // Set font and brush for drawing text
            Font font = new Font("Arial", 10);
            Brush textBrush = Brushes.Black;

            // Draw each slice
            float startAngle = 0;

            for (int i = 0; i < PieData.Count; i++)
            {
                float sweepAngle = (float)PieData[i] / total * 360;

                // Draw the pie slice
                g.FillPie(new SolidBrush(PieColors[i]), pieRect, startAngle, sweepAngle);

                // Calculate the angle to place text in the middle of each slice
                float midAngle = startAngle + sweepAngle / 2;

                // Calculate position for the text based on the middle of the slice
                PointF textPosition = new PointF(
                    pieRect.X + pieRect.Width / 2 + (float)(Math.Cos(midAngle * Math.PI / 180) * pieRect.Width / 3),
                    pieRect.Y + pieRect.Height / 2 + (float)(Math.Sin(midAngle * Math.PI / 180) * pieRect.Height / 3)
                );

                // Draw the text (percentage or value)
                string label = $"{(PieData[i] * 100 / total)}%";
                g.DrawString(label, font, textBrush, textPosition);

                startAngle += sweepAngle;
            }

            // Draw a legend to the right of the pie chart
            int legendX = pieRect.Right + 20;  // Positioning legend to the right of the pie
            int legendY = pieRect.Top;

            for (int i = 0; i < PieData.Count; i++)
            {
                // Draw colored rectangle for legend
                g.FillRectangle(new SolidBrush(PieColors[i]), legendX, legendY + i * 20, 15, 15);

                // Draw label next to the color block
                g.DrawString($"{PieData[i]}", font, textBrush, legendX + 20, legendY + i * 20);
            }
        }
    }
}
