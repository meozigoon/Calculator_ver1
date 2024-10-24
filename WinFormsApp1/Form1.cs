namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int number = 0;
        int tmp;
        bool check = true;
        calc c = new calc();
        enum calc
        {
            nul,
            plus,
            minus,
            multiple,
            mod,
            division,
            pow
        }

        private int Factorial(int Num)
        {
            if (Num == 0)
            {
                return 0;
            }
            int i = 1;
            int Fac_Value = 1;
            for (i = 1; i <= Num; i++)
            {
                Fac_Value *= i;
            }
            return Fac_Value;
        }

        public Form1()
        {
            InitializeComponent();
            label1.Text = number.ToString();
            label2.Text = "";
        }

        public void delay(int ms)
        {
            DateTime dateTimeNow = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, ms);
            DateTime dateTimeAdd = dateTimeNow.Add(duration);
            while (dateTimeAdd >= dateTimeNow)
            {
                System.Windows.Forms.Application.DoEvents();
                dateTimeNow = DateTime.Now;
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 1;
            label1.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 2;
            label1.Text = number.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 3;
            label1.Text = number.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 4;
            label1.Text = number.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 5;
            label1.Text = number.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 6;
            label1.Text = number.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 7;
            label1.Text = number.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 8;
            label1.Text = number.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10 + 9;
            label1.Text = number.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                check = true;
                number = 0;
            }
            number = number * 10;
            label1.Text = number.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            number = 0;
            c = calc.nul;
            label2.Text = "";
            label1.Text = number.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (c != calc.nul)
            {
                cal();
            }
            tmp = number;
            label2.Text = String.Format("{0} + ", tmp.ToString());
            c = calc.plus;
            check = false;
            label1.Text = number.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c != calc.nul)
            {
                cal();
            }
            tmp = number;
            label2.Text = String.Format("{0} - ", tmp.ToString());
            c = calc.minus;
            check = false;
            label1.Text = number.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (c != calc.nul)
            {
                cal();
            }
            tmp = number;
            label2.Text = String.Format("{0} × ", tmp.ToString());
            c = calc.multiple;
            check = false;
            label1.Text = number.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (c != calc.nul && number != 0)
            {
                cal();
            }
            else if (number == 0) number = tmp;
            tmp = number;
            label2.Text = String.Format("{0} ÷(몫) ", tmp.ToString());
            c = calc.division;
            check = false;
            label1.Text = number.ToString();
        }

        private void cal()
        {
            if (c == calc.plus)
            {
                number += tmp;
            }
            else if (c == calc.minus)
            {
                number = tmp - number;
            }
            else if (c == calc.multiple)
            {
                number = tmp * number;
            }
            else if (c == calc.division)
            {
                number = tmp / number;
            }
            else if(c==calc.mod)
            {
                number = tmp % number;
            }
            else if(c==calc.pow)
            {
                number *= number;
            }
            tmp = 0;
            c = calc.nul;
            label2.Text = "";
            label1.Text = number.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            number *= -1;
            label1.Text = number.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            number = Factorial(number);
            label1.Text = number.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            number = 0;
            label1.Text = number.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if ((c != calc.nul && number != 0) || (number == 0 && c != calc.division))
            {
                cal();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (c != calc.nul && number != 0)
            {
                cal();
            }
            else if (number == 0) number = tmp;
            tmp = number;
            label2.Text = String.Format("{0} % ", tmp.ToString());
            c = calc.mod;
            check = false;
            label1.Text = number.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            c = calc.pow;
            cal();
            check = false;
            label2.Text = String.Format("{0}^2 ", number.ToString());
            label1.Text = number.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tmp = number;
            if(number<0)
            {
                number *= -1;
            }
            check = false;
            label2.Text = String.Format("|{0}| ", tmp.ToString());
            label1.Text = number.ToString();
        }
    }
}