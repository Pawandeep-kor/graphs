using System.Windows.Forms;

namespace GraphsApp
{
    public partial class PieChartControl : UserControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // PieChartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PieChartControl";
            this.Size = new System.Drawing.Size(300, 300);
            this.ResumeLayout(false);
        }

        #endregion
    }
}
