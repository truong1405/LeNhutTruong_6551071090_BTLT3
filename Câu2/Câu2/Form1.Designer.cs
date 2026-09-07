namespace Câu2
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
            bntClickMe = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bntClickMe
            // 
            bntClickMe.BackColor = SystemColors.ControlLightLight;
            bntClickMe.FlatAppearance.BorderColor = Color.Cyan;
            bntClickMe.FlatAppearance.MouseDownBackColor = Color.Cyan;
            bntClickMe.FlatAppearance.MouseOverBackColor = Color.Cyan;
            bntClickMe.FlatStyle = FlatStyle.Flat;
            bntClickMe.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntClickMe.ForeColor = Color.Red;
            bntClickMe.Location = new Point(178, 98);
            bntClickMe.Margin = new Padding(2, 2, 2, 2);
            bntClickMe.Name = "bntClickMe";
            bntClickMe.Size = new Size(254, 148);
            bntClickMe.TabIndex = 0;
            bntClickMe.Text = "Click Me";
            bntClickMe.UseVisualStyleBackColor = false;
            bntClickMe.Click += bntClickMe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "6551071090";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(label1);
            Controls.Add(bntClickMe);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntClickMe;
        private Label label1;
    }
}
