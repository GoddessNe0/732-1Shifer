namespace _732_1Shifer
{
    partial class Auth
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
            Login = new TextBox();
            AuthPwd = new TextBox();
            MakeAuth = new Button();
            GoReg = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(63, 60);
            Login.Margin = new Padding(3, 4, 3, 4);
            Login.Name = "Login";
            Login.Size = new Size(475, 27);
            Login.TabIndex = 0;
            Login.TextChanged += Login_TextChanged;
            // 
            // AuthPwd
            // 
            AuthPwd.Location = new Point(63, 145);
            AuthPwd.Margin = new Padding(3, 4, 3, 4);
            AuthPwd.Name = "AuthPwd";
            AuthPwd.PasswordChar = '*';
            AuthPwd.Size = new Size(475, 27);
            AuthPwd.TabIndex = 1;
            AuthPwd.TextChanged += AuthPwd_TextChanged;
            // 
            // MakeAuth
            // 
            MakeAuth.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MakeAuth.Location = new Point(223, 197);
            MakeAuth.Margin = new Padding(3, 4, 3, 4);
            MakeAuth.Name = "MakeAuth";
            MakeAuth.Size = new Size(157, 55);
            MakeAuth.TabIndex = 2;
            MakeAuth.Text = "Войти";
            MakeAuth.UseVisualStyleBackColor = true;
            MakeAuth.Click += MakeAuth_Click;
            // 
            // GoReg
            // 
            GoReg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            GoReg.Location = new Point(410, 293);
            GoReg.Margin = new Padding(3, 4, 3, 4);
            GoReg.Name = "GoReg";
            GoReg.Size = new Size(199, 44);
            GoReg.TabIndex = 3;
            GoReg.Text = "Зарегистрироваться";
            GoReg.UseVisualStyleBackColor = true;
            GoReg.Click += GoReg_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 36);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 4;
            label1.Text = "Логин";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 108);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(438, 269);
            label3.Name = "label3";
            label3.Size = new Size(154, 20);
            label3.TabIndex = 6;
            label3.Text = "Нет учетной записи?";
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 351);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GoReg);
            Controls.Add(MakeAuth);
            Controls.Add(AuthPwd);
            Controls.Add(Login);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Auth";
            Text = "Auth";
            FormClosed += Auth_FormClosed;
            Load += Auth_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Login;
        private TextBox AuthPwd;
        private Button MakeAuth;
        private Button GoReg;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}