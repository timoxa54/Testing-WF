﻿
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.top = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(12, 12);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(105, 72);
            this.top.TabIndex = 3;
            this.top.Text = "Hello";
            this.top.UseVisualStyleBackColor = true;
            this.top.Click += new System.EventHandler(this.top_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(12, 90);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(144, 22);
            this.TB1.TabIndex = 4;
            this.TB1.TextChanged += new System.EventHandler(this.TB1_TextChanged);
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(12, 118);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(144, 22);
            this.TB2.TabIndex = 5;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(12, 146);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(143, 22);
            this.TB3.TabIndex = 6;
            this.TB3.Click += new System.EventHandler(this.TB3_Click);
            this.TB3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB3_KeyDown);
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(12, 189);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(95, 22);
            this.tbValue.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 306);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.top);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button top;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox tbValue;
    }
}

