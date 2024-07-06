namespace qno1_new_
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
            label1 = new Label();
            label2 = new Label();
            number1TextBox = new TextBox();
            number2TextBox = new TextBox();
            compareButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 120);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 0;
            label1.Text = "First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 181);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 1;
            label2.Text = "Second Number";
            // 
            // number1TextBox
            // 
            number1TextBox.Location = new Point(325, 117);
            number1TextBox.Name = "number1TextBox";
            number1TextBox.Size = new Size(182, 27);
            number1TextBox.TabIndex = 2;
            // 
            // number2TextBox
            // 
            number2TextBox.Location = new Point(325, 181);
            number2TextBox.Name = "number2TextBox";
            number2TextBox.Size = new Size(182, 27);
            number2TextBox.TabIndex = 3;
            // 
            // compareButton
            // 
            compareButton.Location = new Point(168, 249);
            compareButton.Name = "compareButton";
            compareButton.Size = new Size(339, 56);
            compareButton.TabIndex = 4;
            compareButton.Text = "Compare Number";
            compareButton.UseVisualStyleBackColor = true;
            compareButton.Click += compareButton_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(compareButton);
            Controls.Add(number2TextBox);
            Controls.Add(number1TextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox number1TextBox;
        private TextBox number2TextBox;
        private Button compareButton;
    }
}
