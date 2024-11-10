using System;
using System.Windows.Forms;

namespace GraphsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set custom data for the pie chart
            pieChartControl1.PieData = new System.Collections.Generic.List<int> { 50, 30, 20 };  // Custom data (50, 30, 20)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
