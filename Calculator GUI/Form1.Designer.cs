
namespace Calculator_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextFactorial = new System.Windows.Forms.TextBox();
            this.TextRoot = new System.Windows.Forms.TextBox();
            this.ButtorFactorial = new System.Windows.Forms.Button();
            this.ButtonRoot = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.butt1 = new System.Windows.Forms.Button();
            this.butt2 = new System.Windows.Forms.Button();
            this.butt3 = new System.Windows.Forms.Button();
            this.butt4 = new System.Windows.Forms.Button();
            this.butt5 = new System.Windows.Forms.Button();
            this.butt6 = new System.Windows.Forms.Button();
            this.butt7 = new System.Windows.Forms.Button();
            this.butt8 = new System.Windows.Forms.Button();
            this.butt9 = new System.Windows.Forms.Button();
            this.butt0 = new System.Windows.Forms.Button();
            this.buttminus = new System.Windows.Forms.Button();
            this.buttplus = new System.Windows.Forms.Button();
            this.buttmult = new System.Windows.Forms.Button();
            this.buttdiv = new System.Windows.Forms.Button();
            this.buttpow = new System.Windows.Forms.Button();
            this.buttres = new System.Windows.Forms.Button();
            this.checkRoot = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkText = new System.Windows.Forms.CheckBox();
            this.checkFact = new System.Windows.Forms.CheckBox();
            this.buttclear = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.space = new System.Windows.Forms.Button();
            this.buttcomma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.textBox1.HideSelection = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // TextFactorial
            // 
            this.TextFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.TextFactorial, "TextFactorial");
            this.TextFactorial.ForeColor = System.Drawing.Color.White;
            this.TextFactorial.Name = "TextFactorial";
            this.TextFactorial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.TextFactorial.Leave += new System.EventHandler(this.TextFactorial_Leave);
            // 
            // TextRoot
            // 
            this.TextRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            resources.ApplyResources(this.TextRoot, "TextRoot");
            this.TextRoot.ForeColor = System.Drawing.Color.White;
            this.TextRoot.Name = "TextRoot";
            this.TextRoot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Root_KeyPress_1);
            this.TextRoot.Leave += new System.EventHandler(this.TextRoot_Leave);
            // 
            // ButtorFactorial
            // 
            resources.ApplyResources(this.ButtorFactorial, "ButtorFactorial");
            this.ButtorFactorial.Name = "ButtorFactorial";
            this.ButtorFactorial.UseVisualStyleBackColor = true;
            this.ButtorFactorial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Factorial_MouseDown);
            // 
            // ButtonRoot
            // 
            resources.ApplyResources(this.ButtonRoot, "ButtonRoot");
            this.ButtonRoot.Name = "ButtonRoot";
            this.ButtonRoot.UseVisualStyleBackColor = true;
            this.ButtonRoot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(60)))));
            resources.ApplyResources(this.Result, "Result");
            this.Result.ForeColor = System.Drawing.Color.Maroon;
            this.Result.Name = "Result";
            // 
            // butt1
            // 
            resources.ApplyResources(this.butt1, "butt1");
            this.butt1.Name = "butt1";
            this.butt1.UseVisualStyleBackColor = true;
            this.butt1.Click += new System.EventHandler(this.butt1_Click);
            // 
            // butt2
            // 
            this.butt2.CausesValidation = false;
            resources.ApplyResources(this.butt2, "butt2");
            this.butt2.Name = "butt2";
            this.butt2.UseVisualStyleBackColor = true;
            this.butt2.Click += new System.EventHandler(this.butt2_Click);
            // 
            // butt3
            // 
            resources.ApplyResources(this.butt3, "butt3");
            this.butt3.Name = "butt3";
            this.butt3.UseVisualStyleBackColor = true;
            this.butt3.Click += new System.EventHandler(this.butt3_Click);
            // 
            // butt4
            // 
            resources.ApplyResources(this.butt4, "butt4");
            this.butt4.Name = "butt4";
            this.butt4.UseVisualStyleBackColor = true;
            this.butt4.Click += new System.EventHandler(this.butt4_Click);
            // 
            // butt5
            // 
            resources.ApplyResources(this.butt5, "butt5");
            this.butt5.Name = "butt5";
            this.butt5.UseVisualStyleBackColor = true;
            this.butt5.Click += new System.EventHandler(this.butt5_Click);
            // 
            // butt6
            // 
            resources.ApplyResources(this.butt6, "butt6");
            this.butt6.Name = "butt6";
            this.butt6.UseVisualStyleBackColor = true;
            this.butt6.Click += new System.EventHandler(this.butt6_Click);
            // 
            // butt7
            // 
            resources.ApplyResources(this.butt7, "butt7");
            this.butt7.Name = "butt7";
            this.butt7.UseVisualStyleBackColor = true;
            this.butt7.Click += new System.EventHandler(this.butt7_Click);
            // 
            // butt8
            // 
            resources.ApplyResources(this.butt8, "butt8");
            this.butt8.Name = "butt8";
            this.butt8.UseVisualStyleBackColor = true;
            this.butt8.Click += new System.EventHandler(this.butt8_Click);
            // 
            // butt9
            // 
            resources.ApplyResources(this.butt9, "butt9");
            this.butt9.Name = "butt9";
            this.butt9.UseVisualStyleBackColor = true;
            this.butt9.Click += new System.EventHandler(this.butt9_Click);
            // 
            // butt0
            // 
            resources.ApplyResources(this.butt0, "butt0");
            this.butt0.Name = "butt0";
            this.butt0.UseVisualStyleBackColor = true;
            this.butt0.Click += new System.EventHandler(this.butt0_Click);
            // 
            // buttminus
            // 
            resources.ApplyResources(this.buttminus, "buttminus");
            this.buttminus.Name = "buttminus";
            this.buttminus.UseVisualStyleBackColor = true;
            this.buttminus.Click += new System.EventHandler(this.buttminus_Click);
            // 
            // buttplus
            // 
            resources.ApplyResources(this.buttplus, "buttplus");
            this.buttplus.Name = "buttplus";
            this.buttplus.UseVisualStyleBackColor = true;
            this.buttplus.Click += new System.EventHandler(this.buttplus_Click);
            // 
            // buttmult
            // 
            resources.ApplyResources(this.buttmult, "buttmult");
            this.buttmult.Name = "buttmult";
            this.buttmult.UseVisualStyleBackColor = true;
            this.buttmult.Click += new System.EventHandler(this.buttmult_Click);
            // 
            // buttdiv
            // 
            resources.ApplyResources(this.buttdiv, "buttdiv");
            this.buttdiv.Name = "buttdiv";
            this.buttdiv.UseVisualStyleBackColor = true;
            this.buttdiv.Click += new System.EventHandler(this.buttdiv_Click);
            // 
            // buttpow
            // 
            resources.ApplyResources(this.buttpow, "buttpow");
            this.buttpow.Name = "buttpow";
            this.buttpow.UseVisualStyleBackColor = true;
            this.buttpow.Click += new System.EventHandler(this.buttpow_Click);
            // 
            // buttres
            // 
            resources.ApplyResources(this.buttres, "buttres");
            this.buttres.Name = "buttres";
            this.buttres.UseVisualStyleBackColor = true;
            this.buttres.Click += new System.EventHandler(this.buttres_Click);
            // 
            // checkRoot
            // 
            resources.ApplyResources(this.checkRoot, "checkRoot");
            this.checkRoot.Name = "checkRoot";
            this.checkRoot.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkText
            // 
            resources.ApplyResources(this.checkText, "checkText");
            this.checkText.Name = "checkText";
            this.checkText.UseVisualStyleBackColor = true;
            // 
            // checkFact
            // 
            resources.ApplyResources(this.checkFact, "checkFact");
            this.checkFact.Name = "checkFact";
            this.checkFact.UseVisualStyleBackColor = true;
            // 
            // buttclear
            // 
            resources.ApplyResources(this.buttclear, "buttclear");
            this.buttclear.Name = "buttclear";
            this.buttclear.UseVisualStyleBackColor = true;
            this.buttclear.Click += new System.EventHandler(this.buttclear_Click);
            // 
            // open
            // 
            resources.ApplyResources(this.open, "open");
            this.open.Name = "open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // space
            // 
            resources.ApplyResources(this.space, "space");
            this.space.Name = "space";
            this.space.UseVisualStyleBackColor = true;
            this.space.Click += new System.EventHandler(this.space_Click);
            // 
            // buttcomma
            // 
            resources.ApplyResources(this.buttcomma, "buttcomma");
            this.buttcomma.Name = "buttcomma";
            this.buttcomma.UseVisualStyleBackColor = true;
            this.buttcomma.Click += new System.EventHandler(this.buttcomma_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.buttclear);
            this.Controls.Add(this.checkText);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkFact);
            this.Controls.Add(this.checkRoot);
            this.Controls.Add(this.butt0);
            this.Controls.Add(this.butt9);
            this.Controls.Add(this.buttres);
            this.Controls.Add(this.butt8);
            this.Controls.Add(this.buttpow);
            this.Controls.Add(this.butt7);
            this.Controls.Add(this.buttdiv);
            this.Controls.Add(this.butt6);
            this.Controls.Add(this.buttmult);
            this.Controls.Add(this.buttplus);
            this.Controls.Add(this.butt5);
            this.Controls.Add(this.buttminus);
            this.Controls.Add(this.butt4);
            this.Controls.Add(this.butt3);
            this.Controls.Add(this.butt2);
            this.Controls.Add(this.buttcomma);
            this.Controls.Add(this.space);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Controls.Add(this.butt1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ButtonRoot);
            this.Controls.Add(this.ButtorFactorial);
            this.Controls.Add(this.TextRoot);
            this.Controls.Add(this.TextFactorial);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TextFactorial;
        private System.Windows.Forms.TextBox TextRoot;
        private System.Windows.Forms.Button ButtorFactorial;
        private System.Windows.Forms.Button ButtonRoot;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button butt1;
        private System.Windows.Forms.Button butt2;
        private System.Windows.Forms.Button butt3;
        private System.Windows.Forms.Button butt4;
        private System.Windows.Forms.Button butt5;
        private System.Windows.Forms.Button butt6;
        private System.Windows.Forms.Button butt7;
        private System.Windows.Forms.Button butt8;
        private System.Windows.Forms.Button butt9;
        private System.Windows.Forms.Button butt0;
        private System.Windows.Forms.Button buttminus;
        private System.Windows.Forms.Button buttplus;
        private System.Windows.Forms.Button buttmult;
        private System.Windows.Forms.Button buttdiv;
        private System.Windows.Forms.Button buttpow;
        private System.Windows.Forms.Button buttres;
        private System.Windows.Forms.CheckBox checkRoot;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkText;
        private System.Windows.Forms.CheckBox checkFact;
        private System.Windows.Forms.Button buttclear;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button space;
        private System.Windows.Forms.Button buttcomma;
    }
}