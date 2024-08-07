using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Калькулятор1
{
    public partial class Form1 : Form
    {

        double FirstValue;
        string arithmetic;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Minimum = 0;
            trackBar1.Maximum = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "-";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            arithmetic = "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double SecondValue;
            double outcome;


            SecondValue = Convert.ToDouble(textBox1.Text);
            if (arithmetic == "+")
            {
                outcome = (FirstValue + SecondValue);
                textBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "-")
            {
                outcome = (FirstValue - SecondValue);
                textBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "*")
            {
                outcome = (FirstValue * SecondValue);
                textBox1.Text = Convert.ToString(outcome);
                FirstValue = outcome;
            }
            if (arithmetic == "/")
            {
                if (SecondValue == 0)
                {
                    textBox1.Text = "ОШИБКА!";
                }
                else
                {
                    outcome = FirstValue / SecondValue;
                    textBox1.Text = Convert.ToString(outcome);
                    FirstValue = outcome;
                }
            }

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            switch (trackBar1.Value)
            {
                case 0: n1.BackColor = Color.Lavender; break;
                case 1: n1.BackColor = Color.Cyan; break;
                case 2: n1.BackColor = Color.Magenta; break;
                case 3: n1.BackColor = Color.Yellow; break;
                case 4: n1.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            { 
                case 0: n2.BackColor = Color.Lavender; break;
                case 1: n2.BackColor = Color.Cyan; break;
                case 2: n2.BackColor = Color.Magenta; break;
                case 3: n2.BackColor = Color.Yellow; break;
                case 4: n2.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n3.BackColor = Color.Lavender; break;
                case 1: n3.BackColor = Color.Cyan; break;
                case 2: n3.BackColor = Color.Magenta; break;
                case 3: n3.BackColor = Color.Yellow; break;
                case 4: n3.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n4.BackColor = Color.Lavender; break;
                case 1: n4.BackColor = Color.Cyan; break;
                case 2: n4.BackColor = Color.Magenta; break;
                case 3: n4.BackColor = Color.Yellow; break;
                case 4: n4.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n5.BackColor = Color.Lavender; break;
                case 1: n5.BackColor = Color.Cyan; break;
                case 2: n5.BackColor = Color.Magenta; break;
                case 3: n5.BackColor = Color.Yellow; break;
                case 4: n5.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n0.BackColor = Color.Lavender; break;
                case 1: n0.BackColor = Color.Cyan; break;
                case 2: n0.BackColor = Color.Magenta; break;
                case 3: n0.BackColor = Color.Yellow; break;
                case 4: n0.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n6.BackColor = Color.Lavender; break;
                case 1: n6.BackColor = Color.Cyan; break;
                case 2: n6.BackColor = Color.Magenta; break;
                case 3: n6.BackColor = Color.Yellow; break;
                case 4: n6.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n7.BackColor = Color.Lavender; break;
                case 1: n7.BackColor = Color.Cyan; break;
                case 2: n7.BackColor = Color.Magenta; break;
                case 3: n7.BackColor = Color.Yellow; break;
                case 4: n7.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n8.BackColor = Color.Lavender; break;
                case 1: n8.BackColor = Color.Cyan; break;
                case 2: n8.BackColor = Color.Magenta; break;
                case 3: n8.BackColor = Color.Yellow; break;
                case 4: n8.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: n9.BackColor = Color.Lavender; break;
                case 1: n9.BackColor = Color.Cyan; break;
                case 2: n9.BackColor = Color.Magenta; break;
                case 3: n9.BackColor = Color.Yellow; break;
                case 4: n9.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: add.BackColor = Color.Lavender; break;
                case 1: add.BackColor = Color.Cyan; break;
                case 2: add.BackColor = Color.Magenta; break;
                case 3: add.BackColor = Color.Yellow; break;
                case 4: add.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: sub.BackColor = Color.Lavender; break;
                case 1: sub.BackColor = Color.Cyan; break;
                case 2: sub.BackColor = Color.Magenta; break;
                case 3: sub.BackColor = Color.Yellow; break;
                case 4: sub.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: clear.BackColor = Color.Lavender; break;
                case 1: clear.BackColor = Color.Cyan; break;
                case 2: clear.BackColor = Color.Magenta; break;
                case 3: clear.BackColor = Color.Yellow; break;
                case 4: clear.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: mult.BackColor = Color.Lavender; break;
                case 1: mult.BackColor = Color.Cyan; break;
                case 2: mult.BackColor = Color.Magenta; break;
                case 3: mult.BackColor = Color.Yellow; break;
                case 4: mult.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: div.BackColor = Color.Lavender; break;
                case 1: div.BackColor = Color.Cyan; break;
                case 2: div.BackColor = Color.Magenta; break;
                case 3: div.BackColor = Color.Yellow; break;
                case 4: div.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: equal.BackColor = Color.Lavender; break;
                case 1: equal.BackColor = Color.Cyan; break;
                case 2: equal.BackColor = Color.Magenta; break;
                case 3: equal.BackColor = Color.Yellow; break;
                case 4: equal.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: dot.BackColor = Color.Lavender; break;
                case 1: dot.BackColor = Color.Cyan; break;
                case 2: dot.BackColor = Color.Magenta; break;
                case 3: dot.BackColor = Color.Yellow; break;
                case 4: dot.BackColor = Color.Black; break;
            }
            switch (trackBar1.Value)
            {
                case 0: textBox1.BackColor = Color.Lavender; break;
                case 1: textBox1.BackColor = Color.Cyan; break;
                case 2: textBox1.BackColor = Color.Magenta; break;
                case 3: textBox1.BackColor = Color.Yellow; break;
                case 4: textBox1.BackColor = Color.Black; break;
            }
        }

    }
}
        
    

