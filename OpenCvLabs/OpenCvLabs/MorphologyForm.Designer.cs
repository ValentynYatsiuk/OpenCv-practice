
namespace OpenCvLabs
{
    partial class MorphologyForm
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.morphologyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 79);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(679, 867);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // morphologyLabel
            // 
            this.morphologyLabel.AutoSize = true;
            this.morphologyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.morphologyLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.morphologyLabel.Location = new System.Drawing.Point(192, 37);
            this.morphologyLabel.Name = "morphologyLabel";
            this.morphologyLabel.Size = new System.Drawing.Size(369, 39);
            this.morphologyLabel.TabIndex = 3;
            this.morphologyLabel.Text = "Morphology operations";
            // 
            // MorphologyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 953);
            this.Controls.Add(this.morphologyLabel);
            this.Controls.Add(this.imageBox1);
            this.Name = "MorphologyForm";
            this.Text = "MorphologyForm";
            this.Load += new System.EventHandler(this.MorphologyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label morphologyLabel;
    }
}