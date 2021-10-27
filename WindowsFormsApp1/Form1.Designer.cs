
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
            this.SB_A = new System.Windows.Forms.HScrollBar();
            this.TBscroll_A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TBscroll_B = new System.Windows.Forms.TextBox();
            this.SB_B = new System.Windows.Forms.HScrollBar();
            this.TB_del = new System.Windows.Forms.TextBox();
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
            // SB_A
            // 
            this.SB_A.LargeChange = 1;
            this.SB_A.Location = new System.Drawing.Point(259, 275);
            this.SB_A.Maximum = 1000;
            this.SB_A.Name = "SB_A";
            this.SB_A.Size = new System.Drawing.Size(177, 33);
            this.SB_A.TabIndex = 1;
            this.SB_A.ValueChanged += new System.EventHandler(this.ScrollBar1_ValueChanged);
            // 
            // TBscroll_A
            // 
            this.TBscroll_A.Location = new System.Drawing.Point(259, 324);
            this.TBscroll_A.Name = "TBscroll_A";
            this.TBscroll_A.Size = new System.Drawing.Size(62, 22);
            this.TBscroll_A.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Делимое";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Делитель";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TBscroll_B
            // 
            this.TBscroll_B.Location = new System.Drawing.Point(485, 324);
            this.TBscroll_B.Name = "TBscroll_B";
            this.TBscroll_B.Size = new System.Drawing.Size(62, 22);
            this.TBscroll_B.TabIndex = 12;
            this.TBscroll_B.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SB_B
            // 
            this.SB_B.LargeChange = 1;
            this.SB_B.Location = new System.Drawing.Point(485, 275);
            this.SB_B.Name = "SB_B";
            this.SB_B.Size = new System.Drawing.Size(177, 33);
            this.SB_B.TabIndex = 11;
            this.SB_B.ValueChanged += new System.EventHandler(this.SB_B_ValueChanged);
            // 
            // TB_del
            // 
            this.TB_del.Location = new System.Drawing.Point(374, 378);
            this.TB_del.Name = "TB_del";
            this.TB_del.Size = new System.Drawing.Size(149, 22);
            this.TB_del.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 427);
            this.Controls.Add(this.TB_del);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBscroll_B);
            this.Controls.Add(this.SB_B);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBscroll_A);
            this.Controls.Add(this.SB_A);
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
        private System.Windows.Forms.HScrollBar SB_A;
        private System.Windows.Forms.TextBox TBscroll_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBscroll_B;
        private System.Windows.Forms.HScrollBar SB_B;
        private System.Windows.Forms.TextBox TB_del;
    }
}

