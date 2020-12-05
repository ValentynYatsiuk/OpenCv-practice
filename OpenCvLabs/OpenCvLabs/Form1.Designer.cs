
namespace OpenCvLabs
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ErosionButton = new System.Windows.Forms.Button();
            this.DilatateButton = new System.Windows.Forms.Button();
            this.dilatateCoef = new System.Windows.Forms.TextBox();
            this.eroziumCoef = new System.Windows.Forms.TextBox();
            this.DOGaus = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(12, 114);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(679, 867);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOADED IMAGE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Normalize Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(241, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Build Histogram";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(241, 52);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Split To Channels";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Morphology";
            // 
            // ErosionButton
            // 
            this.ErosionButton.Location = new System.Drawing.Point(385, 23);
            this.ErosionButton.Name = "ErosionButton";
            this.ErosionButton.Size = new System.Drawing.Size(75, 23);
            this.ErosionButton.TabIndex = 9;
            this.ErosionButton.Text = "Erosion";
            this.ErosionButton.UseVisualStyleBackColor = true;
            this.ErosionButton.Click += new System.EventHandler(this.ErosionButton_Click);
            // 
            // DilatateButton
            // 
            this.DilatateButton.Location = new System.Drawing.Point(385, 52);
            this.DilatateButton.Name = "DilatateButton";
            this.DilatateButton.Size = new System.Drawing.Size(75, 23);
            this.DilatateButton.TabIndex = 10;
            this.DilatateButton.Text = "Dilatate";
            this.DilatateButton.UseVisualStyleBackColor = true;
            this.DilatateButton.Click += new System.EventHandler(this.DilatateButton_Click);
            // 
            // dilatateCoef
            // 
            this.dilatateCoef.Enabled = false;
            this.dilatateCoef.Location = new System.Drawing.Point(473, 55);
            this.dilatateCoef.Name = "dilatateCoef";
            this.dilatateCoef.Size = new System.Drawing.Size(37, 20);
            this.dilatateCoef.TabIndex = 11;
            this.dilatateCoef.Text = "1";
            this.dilatateCoef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dilatateCoef_KeyPress);
            // 
            // eroziumCoef
            // 
            this.eroziumCoef.Enabled = false;
            this.eroziumCoef.Location = new System.Drawing.Point(473, 23);
            this.eroziumCoef.Name = "eroziumCoef";
            this.eroziumCoef.Size = new System.Drawing.Size(37, 20);
            this.eroziumCoef.TabIndex = 12;
            this.eroziumCoef.Text = "1";
            this.eroziumCoef.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eroziumCoef_KeyPress);
            // 
            // DOGaus
            // 
            this.DOGaus.Enabled = false;
            this.DOGaus.Location = new System.Drawing.Point(25, 53);
            this.DOGaus.Name = "DOGaus";
            this.DOGaus.Size = new System.Drawing.Size(75, 23);
            this.DOGaus.TabIndex = 13;
            this.DOGaus.Text = "Do Gaus";
            this.DOGaus.UseVisualStyleBackColor = true;
            // 
            // imageBox2
            // 
            this.imageBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.imageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(710, 114);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(679, 867);
            this.imageBox2.TabIndex = 14;
            this.imageBox2.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(710, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Find Golf Balls";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(125, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Equalize";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(530, 23);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 17;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(530, 55);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 993);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.DOGaus);
            this.Controls.Add(this.eroziumCoef);
            this.Controls.Add(this.dilatateCoef);
            this.Controls.Add(this.DilatateButton);
            this.Controls.Add(this.ErosionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ErosionButton;
        private System.Windows.Forms.Button DilatateButton;
        private System.Windows.Forms.TextBox dilatateCoef;
        private System.Windows.Forms.TextBox eroziumCoef;
        private System.Windows.Forms.Button DOGaus;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
    }
}

