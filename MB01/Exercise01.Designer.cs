namespace MB01
{
    partial class Exercise01
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
            LblOutput = new Label();
            BtnPlus = new Button();
            BtnMinus = new Button();
            SuspendLayout();
            // 
            // LblOutput
            // 
            LblOutput.AutoSize = true;
            LblOutput.Location = new Point(351, 64);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(0, 32);
            LblOutput.TabIndex = 0;
            // 
            // BtnPlus
            // 
            BtnPlus.Location = new Point(187, 166);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(150, 46);
            BtnPlus.TabIndex = 1;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.Location = new Point(387, 166);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(150, 46);
            BtnMinus.TabIndex = 2;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += BtnMinus_Click;
            // 
            // Exercise01
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMinus);
            Controls.Add(BtnPlus);
            Controls.Add(LblOutput);
            Name = "Exercise01";
            Text = "Exercise01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblOutput;
        private Button BtnPlus;
        private Button BtnMinus;
    }
}