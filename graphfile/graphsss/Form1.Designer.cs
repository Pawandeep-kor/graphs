namespace GraphsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PieChartControl pieChartControl1;  // Declare pieChartControl1 here

        private void InitializeComponent()
        {
            this.pieChartControl1 = new GraphsApp.PieChartControl();  // Initialize pieChartControl1

            // Form settings
            this.SuspendLayout();

            // pieChartControl1 settings
            this.pieChartControl1.Location = new System.Drawing.Point(50, 50); // Position the control on the form
            this.pieChartControl1.Name = "pieChartControl1"; // Name of the control
            this.pieChartControl1.Size = new System.Drawing.Size(300, 300); // Size of the pie chart control

            // Add pieChartControl1 to the form's controls
            this.Controls.Add(this.pieChartControl1);

            // Form settings
            this.ClientSize = new System.Drawing.Size(800, 450);  // Set form size
            this.Name = "Form1";
            this.Text = "Pie Chart Example";
            this.ResumeLayout(false); // End form layout
        }
    }
}
