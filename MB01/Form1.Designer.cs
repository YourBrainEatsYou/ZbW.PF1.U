namespace MB01
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
            LblShow = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // LblShow
            // 
            LblShow.AccessibleName = "";
            LblShow.AutoSize = true;
            LblShow.Location = new Point(43, 54);
            LblShow.Name = "LblShow";
            LblShow.Size = new Size(78, 32);
            LblShow.TabIndex = 0;
            LblShow.Text = "label1";
            // 
            // button1
            // 
            button1.AccessibleName = "BtnHello";
            button1.Location = new Point(43, 126);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 2;
            button1.Text = "Hallo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.AccessibleName = "BtnEnd";
            button2.Location = new Point(219, 126);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 3;
            button2.Text = "End";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LblShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblShow;
        private Button button1;
        private Button button2;
    }
}
