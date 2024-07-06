namespace qno2
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
            numberTextBox = new TextBox();
            findFactorsButton = new Button();
            factorsListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(295, 120);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(213, 27);
            numberTextBox.TabIndex = 0;
            // 
            // findFactorsButton
            // 
            findFactorsButton.Location = new Point(323, 170);
            findFactorsButton.Name = "findFactorsButton";
            findFactorsButton.Size = new Size(151, 29);
            findFactorsButton.TabIndex = 1;
            findFactorsButton.Text = "Find Factors";
            findFactorsButton.UseVisualStyleBackColor = true;
            findFactorsButton.Click += findFactorsButton_Click;
            // 
            // factorsListBox
            // 
            factorsListBox.FormattingEnabled = true;
            factorsListBox.Location = new Point(104, 276);
            factorsListBox.Name = "factorsListBox";
            factorsListBox.Size = new Size(619, 124);
            factorsListBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 97);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter your number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(factorsListBox);
            Controls.Add(findFactorsButton);
            Controls.Add(numberTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numberTextBox;
        private Button findFactorsButton;
        private ListBox factorsListBox;
        private Label label1;
    }
}
