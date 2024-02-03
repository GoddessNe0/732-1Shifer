namespace _732_1Shifer
{
    partial class Reg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegLogin = new TextBox();
            RegPwd = new TextBox();
            MakeReg = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RedgPwdRepit = new TextBox();
            SuspendLayout();
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(28, 22);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(348, 23);
            RegLogin.TabIndex = 0;
            // 
            // RegPwd
            // 
            RegPwd.Location = new Point(28, 63);
            RegPwd.Name = "RegPwd";
            RegPwd.PasswordChar = '*';
            RegPwd.Size = new Size(348, 23);
            RegPwd.TabIndex = 1;
            RegPwd.TextChanged += RegPwd_TextChanged;
            // 
            // MakeReg
            // 
            MakeReg.Location = new Point(84, 144);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(214, 81);
            MakeReg.TabIndex = 3;
            MakeReg.Text = "Зарегистрироваться";
            MakeReg.UseVisualStyleBackColor = true;
            MakeReg.Click += MakeReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 4);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 46);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 89);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 6;
            label3.Text = "Повторите пароль";
            label3.Click += label3_Click;
            // 
            // RedgPwdRepit
            // 
            RedgPwdRepit.Location = new Point(28, 107);
            RedgPwdRepit.Name = "RedgPwdRepit";
            RedgPwdRepit.PasswordChar = '*';
            RedgPwdRepit.Size = new Size(348, 23);
            RedgPwdRepit.TabIndex = 7;
            RedgPwdRepit.TextChanged += RedgPwdRepit_TextChanged;
            // 
            // Reg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 256);
            Controls.Add(RedgPwdRepit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(MakeReg);
            Controls.Add(RegPwd);
            Controls.Add(RegLogin);
            Name = "Reg";
            Text = "Reg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox RegLogin;
        private TextBox RegPwd;
        private Button MakeReg;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox RedgPwdRepit;
    }
}