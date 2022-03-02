namespace FavoriteIntegral
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
            this.btCount = new System.Windows.Forms.Button();
            this.UpBorder = new System.Windows.Forms.TextBox();
            this.LowBorder = new System.Windows.Forms.TextBox();
            this.countN = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Func = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCount
            // 
            this.btCount.Location = new System.Drawing.Point(648, 162);
            this.btCount.Name = "btCount";
            this.btCount.Size = new System.Drawing.Size(106, 37);
            this.btCount.TabIndex = 0;
            this.btCount.Text = "Рассчитать";
            this.btCount.UseVisualStyleBackColor = true;
            this.btCount.Click += new System.EventHandler(this.btCount_Click);
            // 
            // UpBorder
            // 
            this.UpBorder.Location = new System.Drawing.Point(173, 122);
            this.UpBorder.Name = "UpBorder";
            this.UpBorder.Size = new System.Drawing.Size(100, 22);
            this.UpBorder.TabIndex = 1;
            // 
            // LowBorder
            // 
            this.LowBorder.Location = new System.Drawing.Point(173, 223);
            this.LowBorder.Name = "LowBorder";
            this.LowBorder.Size = new System.Drawing.Size(100, 22);
            this.LowBorder.TabIndex = 2;
            // 
            // countN
            // 
            this.countN.Location = new System.Drawing.Point(173, 338);
            this.countN.Name = "countN";
            this.countN.Size = new System.Drawing.Size(100, 22);
            this.countN.TabIndex = 3;
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(884, 162);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(100, 22);
            this.Result.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите границы интегрирования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Верхняя граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Нижняя граница";
            // 
            // Func
            // 
            this.Func.Location = new System.Drawing.Point(390, 163);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(100, 22);
            this.Func.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите подынтегральную функцию";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите количество разбиений";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Результат вычислений";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 593);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Func);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.countN);
            this.Controls.Add(this.LowBorder);
            this.Controls.Add(this.UpBorder);
            this.Controls.Add(this.btCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCount;
        private System.Windows.Forms.TextBox UpBorder;
        private System.Windows.Forms.TextBox LowBorder;
        private System.Windows.Forms.TextBox countN;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Func;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

