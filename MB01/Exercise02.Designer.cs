namespace MB01
{
    partial class Exercise02
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
            label1 = new Label();
            TxtWordInput = new TextBox();
            NumWordCount = new NumericUpDown();
            BtnShowResult = new Button();
            BtnClearForm = new Button();
            label2 = new Label();
            label3 = new Label();
            LblWordCountOutput = new Label();
            ((System.ComponentModel.ISupportInitialize)NumWordCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 48);
            label1.Name = "label1";
            label1.Size = new Size(134, 32);
            label1.TabIndex = 0;
            label1.Text = "Word input";
            // 
            // TxtWordInput
            // 
            TxtWordInput.Location = new Point(255, 48);
            TxtWordInput.Multiline = true;
            TxtWordInput.Name = "TxtWordInput";
            TxtWordInput.Size = new Size(322, 78);
            TxtWordInput.TabIndex = 1;
            TxtWordInput.TextChanged += TxtWordInput_TextChanged;
            // 
            // NumWordCount
            // 
            NumWordCount.Location = new Point(255, 154);
            NumWordCount.Name = "NumWordCount";
            NumWordCount.ReadOnly = true;
            NumWordCount.Size = new Size(322, 39);
            NumWordCount.TabIndex = 2;
            // 
            // BtnShowResult
            // 
            BtnShowResult.Location = new Point(255, 236);
            BtnShowResult.Name = "BtnShowResult";
            BtnShowResult.Size = new Size(150, 46);
            BtnShowResult.TabIndex = 3;
            BtnShowResult.Text = "Show";
            BtnShowResult.UseVisualStyleBackColor = true;
            BtnShowResult.Click += BtnShowResult_Click;
            // 
            // BtnClearForm
            // 
            BtnClearForm.Location = new Point(427, 236);
            BtnClearForm.Name = "BtnClearForm";
            BtnClearForm.Size = new Size(150, 46);
            BtnClearForm.TabIndex = 4;
            BtnClearForm.Text = "Clear";
            BtnClearForm.UseVisualStyleBackColor = true;
            BtnClearForm.Click += BtnClearForm_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 154);
            label2.Name = "label2";
            label2.Size = new Size(143, 32);
            label2.TabIndex = 5;
            label2.Text = "Word Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 310);
            label3.Name = "label3";
            label3.Size = new Size(144, 32);
            label3.TabIndex = 6;
            label3.Text = "Word count:";
            // 
            // LblWordCountOutput
            // 
            LblWordCountOutput.AutoSize = true;
            LblWordCountOutput.Location = new Point(433, 310);
            LblWordCountOutput.Name = "LblWordCountOutput";
            LblWordCountOutput.Size = new Size(0, 32);
            LblWordCountOutput.TabIndex = 7;
            LblWordCountOutput.Visible = false;
            // 
            // Exercise02
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblWordCountOutput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(BtnClearForm);
            Controls.Add(BtnShowResult);
            Controls.Add(NumWordCount);
            Controls.Add(TxtWordInput);
            Controls.Add(label1);
            Name = "Exercise02";
            Text = "Exercise02";
            ((System.ComponentModel.ISupportInitialize)NumWordCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtWordInput;
        private NumericUpDown NumWordCount;
        private Button BtnShowResult;
        private Button BtnClearForm;
        private Label label2;
        private Label label3;
        private Label LblWordCountOutput;
    }
}