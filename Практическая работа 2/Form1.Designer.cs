namespace Практическая_работа_2
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
            btnStart = new Button();
            btnStop = new Button();
            cmbNumbers = new ComboBox();
            cmbLetters = new ComboBox();
            cmbSymbols = new ComboBox();
            textBoxOutput = new TextBox();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(330, 59);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(170, 51);
            btnStart.TabIndex = 0;
            btnStart.Text = "старт";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(330, 126);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(170, 51);
            btnStop.TabIndex = 1;
            btnStop.Text = "завершение";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // cmbNumbers
            // 
            cmbNumbers.FormattingEnabled = true;
            cmbNumbers.Location = new Point(330, 199);
            cmbNumbers.Name = "cmbNumbers";
            cmbNumbers.Size = new Size(121, 23);
            cmbNumbers.TabIndex = 2;
            // 
            // cmbLetters
            // 
            cmbLetters.FormattingEnabled = true;
            cmbLetters.Location = new Point(330, 241);
            cmbLetters.Name = "cmbLetters";
            cmbLetters.Size = new Size(121, 23);
            cmbLetters.TabIndex = 3;
            // 
            // cmbSymbols
            // 
            cmbSymbols.FormattingEnabled = true;
            cmbSymbols.Location = new Point(330, 287);
            cmbSymbols.Name = "cmbSymbols";
            cmbSymbols.Size = new Size(121, 23);
            cmbSymbols.TabIndex = 4;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(330, 336);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(100, 23);
            textBoxOutput.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxOutput);
            Controls.Add(cmbSymbols);
            Controls.Add(cmbLetters);
            Controls.Add(cmbNumbers);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private Button btnStop;
        private ComboBox cmbNumbers;
        private ComboBox cmbLetters;
        private ComboBox cmbSymbols;
        private TextBox textBoxOutput;
    }
}
