
namespace OpenCvLabs
{
    partial class HistigramsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.SuspendLayout();
            // 
            // histogramBox1
            // 
            this.histogramBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.histogramBox1.Location = new System.Drawing.Point(13, 13);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(760, 396);
            this.histogramBox1.TabIndex = 0;
            // 
            // histogramBox3
            // 
            this.histogramBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.histogramBox3.Location = new System.Drawing.Point(13, 817);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(760, 396);
            this.histogramBox3.TabIndex = 2;
            // 
            // histogramBox2
            // 
            this.histogramBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.histogramBox2.Location = new System.Drawing.Point(13, 415);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(760, 396);
            this.histogramBox2.TabIndex = 1;
            // 
            // HistigramsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 1225);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Name = "HistigramsForm";
            this.Text = "HistigramsForm";
            this.Load += new System.EventHandler(this.HistigramsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private Emgu.CV.UI.HistogramBox histogramBox2;
    }
}