using System.Globalization;

namespace bmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = Convert.ToInt32(textBox1.Text);
            double weight = Convert.ToInt32(textBox2.Text);
            double bmi = weight / ((height / 100)* (height / 100));
            string s  = Math.Round(bmi, 2).ToString();
            label4.Text = s.Substring(0, s.Length - 1);

            if (bmi >= 27)
            {
                label5.Text = "�έD";
                label6.Text = "�n�ήɽ���ͨ�U�A���Y�����u���d�魫�޲z�v�o�I";

            }
            else if (bmi >= 24)
            {
                label5.Text = "�魫�L��";
                label6.Text = "�n�p���o�A���֤O��u���d�魫�޲z�v�I";

            }
            else if (bmi >= 18.5)
            {
                label5.Text = "���d�魫";
                label6.Text = "�n�~��O���A�H�������d��z�ڡI";

            }
            else 
            {
                label5.Text = "�魫�L��";
                label6.Text = "�ݭn�h�B�ʡA���Ŷ����A�H�W�[���A�������d�I";

            }










        }
    }
}