namespace RoundButton
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roundControl1 = new RoundControl();
            roundButton1 = new RoundButton();
            SuspendLayout();
            // 
            // roundControl1
            // 
            roundControl1.BackgroundColor = SystemColors.ActiveCaption;
            roundControl1.BorderColor = SystemColors.Control;
            roundControl1.BorderWidth = 1F;
            roundControl1.Location = new Point(313, 65);
            roundControl1.Name = "roundControl1";
            roundControl1.Radius = 20;
            roundControl1.Size = new Size(375, 375);
            roundControl1.TabIndex = 0;
            // 
            // roundButton1
            // 
            roundButton1.BackgroundColor = Color.FromArgb(255, 192, 128);
            roundButton1.BorderColor = Color.Black;
            roundButton1.BorderWidth = 5F;
            roundButton1.Location = new Point(838, 225);
            roundButton1.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            roundButton1.Name = "roundButton1";
            roundButton1.Radius = 20;
            roundButton1.Size = new Size(263, 89);
            roundButton1.TabIndex = 1;
            roundButton1.UseMouseOverBackColor = true;
            roundButton1.Click += roundButton1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1645, 495);
            Controls.Add(roundButton1);
            Controls.Add(roundControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RoundControl roundControl1;
        private RoundButton roundButton1;
    }
}
