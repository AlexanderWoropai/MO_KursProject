
namespace KursProject
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
            this.variablesTextBox = new System.Windows.Forms.TextBox();
            this.rulesTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resumeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // variablesTextBox
            // 
            this.variablesTextBox.Location = new System.Drawing.Point(263, 12);
            this.variablesTextBox.Name = "variablesTextBox";
            this.variablesTextBox.Size = new System.Drawing.Size(125, 27);
            this.variablesTextBox.TabIndex = 0;
            // 
            // rulesTextBox
            // 
            this.rulesTextBox.Location = new System.Drawing.Point(263, 45);
            this.rulesTextBox.Name = "rulesTextBox";
            this.rulesTextBox.Size = new System.Drawing.Size(125, 27);
            this.rulesTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите количество переменных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите количество ограничений";
            // 
            // resumeButton
            // 
            this.resumeButton.Location = new System.Drawing.Point(394, 10);
            this.resumeButton.Name = "resumeButton";
            this.resumeButton.Size = new System.Drawing.Size(114, 62);
            this.resumeButton.TabIndex = 4;
            this.resumeButton.Text = "Продолжить";
            this.resumeButton.UseVisualStyleBackColor = true;
            this.resumeButton.Click += new System.EventHandler(this.resumeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 86);
            this.Controls.Add(this.resumeButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rulesTextBox);
            this.Controls.Add(this.variablesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Симплекс метод. Задание ограничений";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox variablesTextBox;
        private System.Windows.Forms.TextBox rulesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button resumeButton;
    }
}

