using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab001
{
    public partial class Form1 : Form
    {
        int Num1, Num2, Num3;
        string op;
        Double result = 0;
        string operation = string.Empty;
        string fstNum,secNum;
        bool enterValue = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void zero_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '0';
            tetDisplay2.Text = tetDisplay2.Text + "";
        }

        private void one_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '1';
        }

        private void two_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '2';
        }

        private void tree_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '3';
        }

        private void four_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '4';
        }

        private void five_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '5';
        }

        private void six_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '6';
        }

        private void seven_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '7';
        }

        private void eigt_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '8';
        }

        private void nine_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '9';

        }

        private void ans_Click(object sender, EventArgs e)
        {
            Num2 = int.Parse(met.Text);
            if (op == "+")
                Num3 = Num1 + Num2;
            met.Text = Num3.ToString();
            //+
            if (op == "-")
                Num3 = Num1 - Num2;
            met.Text = Num3.ToString();
            //-
            if (op == "*")
                Num3 = Num1 * Num2;
            met.Text = Num3.ToString();
            //*
            if (op == "/")
                Num3 = Num1 / Num2;
            met.Text = Num3.ToString();
            ///
           
        }

        private void max_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(met.Text);
            met.Text = "";
            op = "+";

        }

        private void clear_Click(object sender, EventArgs e)
        {

            met.Text = "";
        }

        private void min_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(met.Text);
            met.Text = "";
            op = "-";
        }

        private void mul_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(met.Text);
            met.Text = "";
            op = "*";
        }

        private void div_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(met.Text);
            met.Text = "";
            op = "/";
        }

        private void point_Click(object sender, EventArgs e)
        {
            met.Text = met.Text + '.';
        }

        private void retor_Click(object sender, EventArgs e)
        {

        }

        private void BtnMath(object sender, EventArgs e)
        {
            
        }

        private void total(object sender, EventArgs e)
        {
            
        }

        private void met_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
