﻿namespace WinFormsAppUsingGitHub
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(354, 128);
            label1.TabIndex = 0;
            label1.Text = "GitHub";
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(381, 12);
            button1.Name = "button1";
            button1.Size = new Size(361, 160);
            button1.TabIndex = 1;
            button1.Text = "Button";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}
