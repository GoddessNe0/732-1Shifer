namespace _732_1Shifer
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
            MakeSort = new Button();
            Input = new TextBox();
            label1 = new Label();
            SavePicture1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // MakeSort
            // 
            MakeSort.Location = new Point(12, 492);
            MakeSort.Name = "MakeSort";
            MakeSort.Size = new Size(209, 22);
            MakeSort.TabIndex = 0;
            MakeSort.Text = "Найти";
            MakeSort.UseVisualStyleBackColor = true;
            MakeSort.Click += MakeSort_Click;
            // 
            // Input
            // 
            Input.Location = new Point(12, 37);
            Input.Name = "Input";
            Input.Size = new Size(454, 23);
            Input.TabIndex = 1;
            Input.TextChanged += Input_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 9);
            label1.Name = "label1";
            label1.Size = new Size(203, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите число больше или равно 2";
            label1.Click += label1_Click_1;
            // 
            // SavePicture1
            // 
            SavePicture1.Location = new Point(266, 492);
            SavePicture1.Name = "SavePicture1";
            SavePicture1.Size = new Size(200, 23);
            SavePicture1.TabIndex = 0;
            SavePicture1.Text = "Сохранить результат";
            SavePicture1.Click += SavePicture1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 80);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(454, 387);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 551);
            Controls.Add(richTextBox1);
            Controls.Add(SavePicture1);
            Controls.Add(label1);
            Controls.Add(Input);
            Controls.Add(MakeSort);
            Name = "Form1";
            Text = "Syndarama";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button MakeSort;
        private TextBox Input;
        private Label label1;
        private Button SavePicture1;
        private RichTextBox richTextBox1;
    }
}