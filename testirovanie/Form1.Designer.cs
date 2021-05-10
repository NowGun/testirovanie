
namespace testirovanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Button();
            this.istudentbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(292, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(329, 163);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(156, 20);
            this.login.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(329, 192);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(156, 20);
            this.password.TabIndex = 4;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(269, 238);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(74, 23);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Войти";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(361, 238);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(124, 23);
            this.registerbutton.TabIndex = 6;
            this.registerbutton.Text = "Зарегистрироваться";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // istudentbutton
            // 
            this.istudentbutton.Location = new System.Drawing.Point(269, 267);
            this.istudentbutton.Name = "istudentbutton";
            this.istudentbutton.Size = new System.Drawing.Size(216, 23);
            this.istudentbutton.TabIndex = 7;
            this.istudentbutton.Text = "Я студент";
            this.istudentbutton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.istudentbutton);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.Button istudentbutton;
        private System.Windows.Forms.Label label4;
    }
}

