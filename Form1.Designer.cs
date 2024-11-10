namespace GraphsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PieChartControl pieChartControl1;  // Declare pieChartControl1 here

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Pie Chart Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }
    }
}
