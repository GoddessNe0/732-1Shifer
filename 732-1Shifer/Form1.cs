using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _732_1Shifer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Auth auth_form = new Auth();
            auth_form.ShowDialog();
        }

        private void MakeSort_Click(object sender, EventArgs e)
        {
            string input = Input.Text;

            // �������������� ����� � ������ �����
            string[] numbers = input.Split(' ');

            foreach (string number in numbers)
            {
                if (int.TryParse(number, out int n))
                {
                    // ��������� ����������� �� 65536
                    if (n < 2 || n > 65536)
                    {
                        richTextBox1.Text = "������: ������� ����� �� 2 �� 65536.";
                        return;
                    }

                    GenerateSieve(n);
                }
                else
                {
                    richTextBox1.Text = $"������: {number} �� �������� ����� ������.";
                    return;
                }
            }
        }

        void GenerateSieve(int n)
        {
            int nNew = (n - 2) / 2;
            bool[] marked = new bool[nNew + 1];

            for (int i = 1; i <= nNew; i++)
            {
                int j = i;
                while ((i + j + 2 * i * j) <= nNew)
                {
                    marked[i + j + 2 * i * j] = true;
                    j++;
                }
            }

            // ������������ ������ � �������� �������
            string result = $"������� ����� �� {n}: ";

            if (n > 2)
                result += "2 ";

            for (int i = 1; i <= nNew; i++)
            {
                if (marked[i] == false)
                    result += (2 * i + 1) + " ";
            }

            // ����� ���������� � richTextBox1
            richTextBox1.Text = result;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SavePicture1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Image Files (*.png, *.jpg, *.bmp)|*.png;*.jpg;*.bmp|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Result As Image";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // ������� ����� ����������� � ������ ���������
                Bitmap bitmap = new Bitmap(richTextBox1.Width, richTextBox1.Height);
                richTextBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, richTextBox1.Width, richTextBox1.Height));

                // ��������� �����������
                bitmap.Save(saveFileDialog.FileName);
                MessageBox.Show("����������� ��������� �������.", "����������", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
