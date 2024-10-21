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
            TxtContent = new TextBox();
            NumNumber = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumNumber).BeginInit();
            SuspendLayout();
            // 
            // LblOutput
            // 
            LblOutput.AutoSize = true;
            LblOutput.Location = new Point(143, 65);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(27, 32);
            LblOutput.TabIndex = 0;
            LblOutput.Text = "0";
            LblOutput.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnPlus
            // 
            BtnPlus.Location = new Point(57, 124);
            BtnPlus.Name = "BtnPlus";
            BtnPlus.Size = new Size(82, 46);
            BtnPlus.TabIndex = 1;
            BtnPlus.Text = "+";
            BtnPlus.UseVisualStyleBackColor = true;
            BtnPlus.Click += BtnPlus_Click;
            // 
            // BtnMinus
            // 
            BtnMinus.Location = new Point(173, 124);
            BtnMinus.Name = "BtnMinus";
            BtnMinus.Size = new Size(82, 46);
            BtnMinus.TabIndex = 2;
            BtnMinus.Text = "-";
            BtnMinus.UseVisualStyleBackColor = true;
            BtnMinus.Click += BtnMinus_Click;
            // 
            // TxtContent
            // 
            TxtContent.Location = new Point(321, 65);
            TxtContent.Multiline = true;
            TxtContent.Name = "TxtContent";
            TxtContent.Size = new Size(354, 214);
            TxtContent.TabIndex = 3;
            TxtContent.TextChanged += TxtContent_TextChanged;
            // 
            // NumNumber
            // 
            NumNumber.Location = new Point(321, 316);
            NumNumber.Name = "NumNumber";
            NumNumber.Size = new Size(354, 39);
            NumNumber.TabIndex = 4;
            // 
            // Exercise01
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NumNumber);
            Controls.Add(TxtContent);
            Controls.Add(BtnMinus);
            Controls.Add(BtnPlus);
            Controls.Add(LblOutput);
            Name = "Exercise01";
            Text = "Exercise01";
            ((System.ComponentModel.ISupportInitialize)NumNumber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblOutput;
        private Button BtnPlus;
        private Button BtnMinus;
        private TextBox TxtContent;
        private NumericUpDown NumNumber;
    }
}