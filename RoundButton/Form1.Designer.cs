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
            roundButton1 = new RoundButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // roundButton1
            // 
            roundButton1.BackgroundColor = Color.FromArgb(11, 205, 255);
            roundButton1.BorderColor = Color.White;
            roundButton1.BorderWidth = 7F;
            roundButton1.ButtonText = "Say Hi";
            roundButton1.Location = new Point(78, 67);
            roundButton1.MouseOverBackColor = SystemColors.Control;
            roundButton1.Name = "roundButton1";
            roundButton1.Radius = 20;
            roundButton1.Size = new Size(263, 89);
            roundButton1.TabIndex = 1;
            roundButton1.UseMouseOverBackColor = true;
            roundButton1.Click += roundButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(388, 77);
            label1.Name = "label1";
            label1.Size = new Size(0, 62);
            label1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 37, 41);
            ClientSize = new Size(1015, 493);
            Controls.Add(label1);
            Controls.Add(roundButton1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RoundButton roundButton1;
        private Label label1;
    }
}
