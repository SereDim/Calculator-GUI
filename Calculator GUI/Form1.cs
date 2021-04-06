using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator_GUI
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }//form

        private void textBox1_KeyDown(object sender, KeyEventArgs e)//Count text
        {
            
            Count CountUser = new Count();
            Parameters ParametersUser = new Parameters();
            Render RenderUser = new Render();
            if (e.KeyCode == Keys.Enter)
            {
                ParametersUser.StartInput = textBox1.Text;
                ParametersUser.StartArray = ParametersUser.StartInput.Split(' ');
                var List = new List<string>();
                RenderUser.Fill(ParametersUser.StartArray, List);
                RenderUser.Sort(List);
                CountUser.Tier1(List);
                CountUser.Tier2(List);
                Result.Text = List[0];
                if ( List.Count > 1)
                {
                    Result.Text = "Error";
                }
            }
        }

        //Limits

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//limits for text
        {
            Limits.TextLimitMain(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)//text factorial
        {
            Limits.TextLimit(e);
        }

        private void Root_KeyPress_1(object sender, KeyPressEventArgs e)//text root
        {
            Limits.TextLimit(e);
        }

        //Mathods
        private void Factorial_MouseDown(object sender, MouseEventArgs e)//button factorial
        {
            Count.Factorial(TextFactorial, textBox1);
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)//button root
        {
            try 
            {
                Count.Sqrt(TextRoot, textBox1);
            }
            catch { }
        }


        //check boxes
        private void textBox1_Leave(object sender, EventArgs e)
        {
            Limits.CheckLimit(checkText, true, checkFact, false, checkRoot, false);

        }

        private void TextFactorial_Leave(object sender, EventArgs e)
        {
            Limits.CheckLimit(checkText, false, checkFact, true, checkRoot, false);
        }

        private void TextRoot_Leave(object sender, EventArgs e)
        {
            Limits.CheckLimit(checkText, false, checkFact, false, checkRoot, true);
        }


        //buttons
        private void butt1_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(1)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(2)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt3_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(3)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt4_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(4)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt5_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(5)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt6_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(6)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt7_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(7)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt8_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(8)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt0_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(0)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttminus_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({-})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttplus_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({+})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttmult_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({*})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttdiv_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({/})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttpow_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({^})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttres_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(~)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void butt9_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(9)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttclear_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({BS})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);
        }        

        private void open_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({(})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void close_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("({)})", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void space_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("( )", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }

        private void buttcomma_Click(object sender, EventArgs e)
        {
            Limits.ButtonLimit("(,)", checkText, checkFact, checkRoot, textBox1, TextFactorial, TextRoot);

        }
    }
}
