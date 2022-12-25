namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  // ����� ����� �� ������ ������
            Clear();
        }

        public void Clear()
        {
            label7.Text = "";
            label8.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox2.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox2.Text.Contains(",")) && ((ch != '-' || textBox2.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox3.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox3.Text.Contains(",")) && ((ch != '-' || textBox3.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox4.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')  // ��������� ������� � ������ � �����
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox4.Text.Contains(",")) && ((ch != '-' || textBox4.Text.Contains("-")))) // ���� �����, BACKSPACE ������� ��� �����, �� ������
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Clear();
                Complex number1 = new Complex(); // ������ �����
                Complex bumber2 = new Complex(); // ������ �����

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    MessageBox.Show("��������� ��� ����!", "������");
                    return;
                }

                try
                {
                    number1.r = Convert.ToDouble(textBox1.Text); // ����� ����� ������� �����
                    number1.i = Convert.ToDouble(textBox2.Text); // ������ ����� ������� �����

                    bumber2.r = Convert.ToDouble(textBox3.Text); // ����� ����� ������� �����
                    bumber2.i = Convert.ToDouble(textBox4.Text); // ������ ����� ������� �����
                }
                catch
                {
                    MessageBox.Show("������� ��������� ����� �� ��� ����!", "������");
                    return;
                }

                try
                {
                    label7.Text = string.Format("{0} + {1}i", (number1 + bumber2).r, (number1 + bumber2).i); // ��������
                    label8.Text = string.Format("{0} + {1}i", (number1 - bumber2).r, (number1 - bumber2).i); // ���������
                    label11.Text = string.Format("{0} + {1}i", (number1 * bumber2).r, (number1 * bumber2).i); // ���������
                    label12.Text = string.Format("{0} + {1}i", (number1 / bumber2).r, (number1 / bumber2).i); // �������


                    if ((number1 == bumber2) && (number1 == bumber2))
                    {
                        label17.Text = Convert.ToString("��.");
                    }
                    else
                    {
                        label17.Text = Convert.ToString("���.");
                    }

                    if ((number1 != bumber2) && (number1 != bumber2))
                    {
                        label18.Text = Convert.ToString("��.");
                    }
                    else
                    {
                        label18.Text = Convert.ToString("���.");
                    }
                }
                catch
                {
                    MessageBox.Show("�������� � �����-�� ���������!", "������");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}