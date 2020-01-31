using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gpa_and_cgpa_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double cr1 = 0;
        double cr2 = 0;
        double cr3 = 0;
        double cr4 = 0;
        double cr5 = 0;
        double cr6 = 0;
        double cr7 = 0;
        double cr8 = 0;
        double cr9 = 0;

        int ich1 = 0;
        int ich2 = 0;
        int ich3 = 0;
        int ich4 = 0;
        int ich5 = 0;
        int ich6 = 0;
        int ich7 = 0;
        int ich8 = 0;
        int ich9 = 0;

        double iallcr = 0;
        double iallch = 0;
        double igpa = 0;
        double icgpa = 0;

        double othercr = 0;
        double otherch = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("A (4.0)");
            comboBox1.Items.Add("B+ (3.5)");
            comboBox1.Items.Add("B (3.0)");
            comboBox1.Items.Add("C+ (2.5)");
            comboBox1.Items.Add("C (2.0)");
            comboBox1.Items.Add("D (1.5)");
            comboBox1.Items.Add("F (0.0)");

            comboBox2.Items.Add("A (4.0)");
            comboBox2.Items.Add("B+ (3.5)");
            comboBox2.Items.Add("B (3.0)");
            comboBox2.Items.Add("C+ (2.5)");
            comboBox2.Items.Add("C (2.0)");
            comboBox2.Items.Add("D (1.5)");
            comboBox2.Items.Add("F (0.0)");

            comboBox3.Items.Add("A (4.0)");
            comboBox3.Items.Add("B+ (3.5)");
            comboBox3.Items.Add("B (3.0)");
            comboBox3.Items.Add("C+ (2.5)");
            comboBox3.Items.Add("C (2.0)");
            comboBox3.Items.Add("D (1.5)");
            comboBox3.Items.Add("F (0.0)");

            comboBox4.Items.Add("A (4.0)");
            comboBox4.Items.Add("B+ (3.5)");
            comboBox4.Items.Add("B (3.0)");
            comboBox4.Items.Add("C+ (2.5)");
            comboBox4.Items.Add("C (2.0)");
            comboBox4.Items.Add("D (1.5)");
            comboBox4.Items.Add("F (0.0)");

            comboBox5.Items.Add("A (4.0)");
            comboBox5.Items.Add("B+ (3.5)");
            comboBox5.Items.Add("B (3.0)");
            comboBox5.Items.Add("C+ (2.5)");
            comboBox5.Items.Add("C (2.0)");
            comboBox5.Items.Add("D (1.5)");
            comboBox5.Items.Add("F (0.0)");
            
            comboBox6.Items.Add("A (4.0)");
            comboBox6.Items.Add("B+ (3.5)");
            comboBox6.Items.Add("B (3.0)");
            comboBox6.Items.Add("C+ (2.5)");
            comboBox6.Items.Add("C (2.0)");
            comboBox6.Items.Add("D (1.5)");
            comboBox6.Items.Add("F (0.0)");

            comboBox7.Items.Add("A (4.0)");
            comboBox7.Items.Add("B+ (3.5)");
            comboBox7.Items.Add("B (3.0)");
            comboBox7.Items.Add("C+ (2.5)");
            comboBox7.Items.Add("C (2.0)");
            comboBox7.Items.Add("D (1.5)");
            comboBox7.Items.Add("F (0.0)");


            comboBox8.Items.Add("A (4.0)");
            comboBox8.Items.Add("B+ (3.5)");
            comboBox8.Items.Add("B (3.0)");
            comboBox8.Items.Add("C+ (2.5)");
            comboBox8.Items.Add("C (2.0)");
            comboBox8.Items.Add("D (1.5)");
            comboBox8.Items.Add("F (0.0)");

            comboBox9.Items.Add("A (4.0)");
            comboBox9.Items.Add("B+ (3.5)");
            comboBox9.Items.Add("B (3.0)");
            comboBox9.Items.Add("C+ (2.5)");
            comboBox9.Items.Add("C (2.0)");
            comboBox9.Items.Add("D (1.5)");
            comboBox9.Items.Add("F (0.0)");

        }

        public double creditpoints(string s)
        {
            double ch = 0;

            if(s == "A (4.0)")
            {
                ch = 4;
            }
            else if (s == "B+ (3.5)")
            {
                ch = 3.5;
            }
            else if (s == "B (3.0)")
            {
                ch = 3;
            }
            else if (s == "C+ (2.5)")
            {
                ch = 2.5;
            }
            else if (s == "C (2.0)")
            {
                ch = 2;
            }
            else if (s == "D (1.5)")
            {
                ch = 1.5;
            }
            else if (s == "F (0.0)")
            {
                ch = 0;
            }
            return ch;
        }

        private void button1_Click(object sender, EventArgs e)
        { // getting credit points
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    cr1 = creditpoints(comboBox1.SelectedItem.ToString());
                }
                if (comboBox2.SelectedIndex != -1)
                {
                    cr2 = creditpoints(comboBox2.SelectedItem.ToString());
                }
                if (comboBox3.SelectedIndex != -1)
                {
                    cr3 = creditpoints(comboBox3.SelectedItem.ToString());
                }
                if (comboBox4.SelectedIndex != -1)
                {
                    cr4 = creditpoints(comboBox4.SelectedItem.ToString());
                }
                if (comboBox5.SelectedIndex != -1)
                {
                    cr5 = creditpoints(comboBox5.SelectedItem.ToString());
                }
                if (comboBox6.SelectedIndex != -1)
                {
                    cr6 = creditpoints(comboBox6.SelectedItem.ToString());
                }
                if (comboBox7.SelectedIndex != -1)
                {
                    cr7 = creditpoints(comboBox7.SelectedItem.ToString());
                }
                if (comboBox8.SelectedIndex != -1)
                {
                    cr8 = creditpoints(comboBox8.SelectedItem.ToString());
                }
                if (comboBox9.SelectedIndex != -1)
                {
                    cr9 = creditpoints(comboBox9.SelectedItem.ToString());
                }
                if (!(ch1.Text == ""))
                {
                    ich1 = Convert.ToInt32(ch1.Text);
                }
                if (!(ch2.Text == ""))
                {
                    ich2 = Convert.ToInt32(ch2.Text);
                }
                if (!(ch3.Text == ""))
                {
                    ich3 = Convert.ToInt32(ch3.Text);
                }
                if (!(ch4.Text == ""))
                {
                    ich4 = Convert.ToInt32(ch4.Text);
                }
                if (!(ch5.Text == ""))
                {
                    ich5 = Convert.ToInt32(ch5.Text);
                }
                if (!(ch6.Text == ""))
                {
                    ich6 = Convert.ToInt32(ch6.Text);
                }
                if (!(ch7.Text == ""))
                {
                    ich7 = Convert.ToInt32(ch7.Text);
                }
                if (!(ch8.Text == ""))
                {
                    ich8 = Convert.ToInt32(ch8.Text);
                }
                if (!(ch9.Text == ""))
                {
                    ich9 = Convert.ToInt32(ch9.Text);
                }
            }
            catch 
            {
                MessageBox.Show("Wrong Input (Check Again)");
            }
         
            // if nothing is selected on combobox and credit hour is on textbox (count credit hour as 0)
            if(comboBox1.SelectedIndex == -1)
            {
                ich1 = 0;
            }
            if (comboBox2.SelectedIndex == -1)
            {
                ich2 = 0;
            }
            if (comboBox3.SelectedIndex == -1)
            {
                ich3 = 0;
            }
            if (comboBox4.SelectedIndex == -1)
            {
                ich4 = 0;
            }
            if (comboBox5.SelectedIndex == -1)
            {
                ich5 = 0;
            }
            if (comboBox6.SelectedIndex == -1)
            {
                ich6 = 0;
            }
            if (comboBox7.SelectedIndex == -1)
            {
                ich7 = 0;
            }
            if (comboBox8.SelectedIndex == -1)
            {
                ich8 = 0;
            }
            if (comboBox9.SelectedIndex == -1)
            {
                ich9 = 0;
            }

            // * credit points of that course to credit hours
            cr1 *= ich1;
            cr2 *= ich2;
            cr3 *= ich3;
            cr4 *= ich4;
            cr5 *= ich5;
            cr6 *= ich6;
            cr7 *= ich7;
            cr8 *= ich8;
            cr9 *= ich9;

            iallcr = cr1 + cr2 + cr3 + cr4 + cr5 + cr6 + cr7 + cr8 + cr9;
            iallch = ich1 + ich2 + ich3 + ich4 + ich5 + ich6 + ich7 + ich8 + ich9;

            igpa = iallcr / iallch;

            Math.Round(igpa, 2);
            
            gpa.Text = igpa.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!(allcr.Text == ""))
                {
                othercr = Convert.ToDouble(allcr.Text);
            }
            if (!(allcr.Text == ""))
                {
                otherch = Convert.ToInt32(allch.Text);
            }

            icgpa = (iallcr + othercr) / (iallch + otherch);
            cgpa.Text = icgpa.ToString();
        }
    }
}
