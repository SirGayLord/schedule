namespace schedule
{
    partial class Login
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
            this.логинBox = new System.Windows.Forms.TextBox();
            this.парольBox = new System.Windows.Forms.TextBox();
            this.войти = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // логинBox
            // 
            this.логинBox.Location = new System.Drawing.Point(440, 272);
            this.логинBox.Name = "логинBox";
            this.логинBox.Size = new System.Drawing.Size(190, 20);
            this.логинBox.TabIndex = 0;
            // 
            // парольBox
            // 
            this.парольBox.Location = new System.Drawing.Point(440, 346);
            this.парольBox.Name = "парольBox";
            this.парольBox.Size = new System.Drawing.Size(190, 20);
            this.парольBox.TabIndex = 1;
            // 
            // войти
            // 
            this.войти.Location = new System.Drawing.Point(503, 428);
            this.войти.Name = "войти";
            this.войти.Size = new System.Drawing.Size(75, 23);
            this.войти.TabIndex = 2;
            this.войти.Text = "Войти";
            this.войти.UseVisualStyleBackColor = true;
            this.войти.Click += new System.EventHandler(this.войти_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(437, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 658);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.войти);
            this.Controls.Add(this.парольBox);
            this.Controls.Add(this.логинBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox логинBox;
        private System.Windows.Forms.TextBox парольBox;
        private System.Windows.Forms.Button войти;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

