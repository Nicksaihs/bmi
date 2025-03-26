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
                label5.Text = "肥胖";
                label6.Text = "要及時請醫生協助，並嚴格執行「健康體重管理」囉！";

            }
            else if (bmi >= 24)
            {
                label5.Text = "體重過重";
                label6.Text = "要小心囉，趕快力行「健康體重管理」！";

            }
            else if (bmi >= 18.5)
            {
                label5.Text = "健康體重";
                label6.Text = "要繼續保持，以維持健康體魄歐！";

            }
            else 
            {
                label5.Text = "體重過輕";
                label6.Text = "需要多運動，均衡飲食，以增加體能，維持健康！";

            }










        }
    }
}