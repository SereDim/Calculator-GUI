using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_GUI
{
    class Count
    {
        public void Tier1(List<string> u)
        {
            for (int y = 0; y < u.Count; y++)
            {
                try
                {
                    try
                    {
                        if (u[y + 1] == "*")
                        {
                            double Result = Convert.ToDouble(u[y]) * Convert.ToDouble(u[y + 2]);
                            u.RemoveRange(y, 3);
                            u.Insert(y, Convert.ToString(Result));
                            y = y - 1;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (u[y + 1] == "/")
                        {
                            double Result = Convert.ToDouble(u[y]) / Convert.ToDouble(u[y + 2]);
                            u.RemoveRange(y, 3);
                            u.Insert(y, Convert.ToString(Result));
                            y = y - 1;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (u[y + 1] == "^")
                        {
                            double Result = Math.Pow(Convert.ToDouble(u[y]), (Convert.ToDouble(u[y + 2])));
                            u.RemoveRange(y, 3);
                            u.Insert(y, Convert.ToString(Result));
                            y = y - 1;
                        }
                    }
                    catch
                    {

                    }
                }
                catch
                {

                }
            }
        }
        public void Tier2(List<string> u)
        {
            for (int y = 0; y < u.Count; y++)
            {
                try
                {

                    try
                    {
                        if (u[y + 1] == "+")
                        {
                            double Result = Convert.ToDouble(u[y]) + Convert.ToDouble(u[y + 2]);
                            u.RemoveRange(y, 3);
                            u.Insert(y, Convert.ToString(Result));
                            y = y - 1;
                        }
                    }
                    catch
                    {

                    }
                    try
                    {
                        if (u[y + 1] == "-")
                        {
                            double Result = Convert.ToDouble(u[y]) - Convert.ToDouble(u[y + 2]);
                            u.RemoveRange(y, 3);
                            u.Insert(y, Convert.ToString(Result));
                            y = y - 1;
                        }
                    }

                    catch
                    {

                    }
                }
                catch
                {

                }
            }
        }
        public static void Factorial(TextBox TextFactorial, TextBox textBox1)
        {
            try
            {
                int b = Convert.ToInt32(TextFactorial.Text);
                if (b < 13)
                {
                    int c = b;
                    b = 1;
                    for (int i = 2; i <= c; i++)
                    {
                        b = b * i;
                    }
                    textBox1.Text = textBox1.Text + b;
                }
                else
                {
                    TextFactorial.Text = " < 13";
                }
            }
            catch { }
        }
        public static void Sqrt(TextBox TextRoot, TextBox textBox1)
        {
            try
            {
                double b = Math.Sqrt(Convert.ToInt32(TextRoot.Text));
                textBox1.Text = textBox1.Text + Convert.ToString(b);
            }
            catch { }
        }
    }
    class Parameters
    {
        public string StartInput;
        public string[] StartArray;
    }
    class Render : Count
    {
        public void Fill(string[] Array, List<string> list)
        {
            foreach (var i in Array)
            {
                list.Add(i);
            }
        }
        public void Sort(List<string> list)
        {
            int Open = 0;
            int Close = 0;
            int CountTemp = 0;
            var TempList = new List<string>();
            for (int o = 0; o < list.Count; o++)
            {
                if (list[o] == ")")
                {


                    if (list.LastIndexOf("(") < o)
                    {

                        Open = list.LastIndexOf("(");
                        Close = o;
                        o = 0;
                        list.RemoveAt(Close);
                        list.RemoveAt(Open);
                        for (int p = Open; p <= Close - 2; p++)
                        {
                            TempList.Add(list[p]);
                        }
                        CountTemp = TempList.Count();
                        Tier1(TempList);
                        Tier2(TempList);
                        list.RemoveRange(Open, CountTemp);
                        list.Insert(Open, TempList[0]);
                        TempList.Clear();
                    }
                }
            }
        }
    }
    class Limits
    {
        public static void ButtonLimit(string i, CheckBox checkText, CheckBox checkFact,
            CheckBox checkRoot, TextBox textBox1, TextBox TextFactorial, TextBox TextRoot)
        {
            if (checkText.Checked == true)
            {
                textBox1.Select();
            }
            if (checkFact.Checked == true)
            {
                TextFactorial.Select();
            }
            if (checkRoot.Checked == true)
            {
                TextRoot.Select();
            }
            SendKeys.Send(i);
        }
        public static void CheckLimit(CheckBox checkText, bool cText, CheckBox checkFact, bool cFact,
            CheckBox checkRoot, bool cRoot)
        {
            checkText.Checked = cText;
            checkFact.Checked = cFact;
            checkRoot.Checked = cRoot;
        }
        public static void TextLimit(KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public static void TextLimitMain(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 32 && number != 94)
            {
                e.Handled = true;
            }

        }
    }

    static class Program
    {


        [STAThread]
        static void Main(string[] args)
        {




            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
