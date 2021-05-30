﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("Contact Tracing Informations.txt");
            outputFile.WriteLine("=======",
                                            FNLabel.Text + " " + FirstNametxtbx.Text);
            outputFile.WriteLine(LNLabel.Text + " " + LastNametxtbx.Text);
            outputFile.WriteLine(AgeLabel.Text + " " + Agetxtbx.Text);
            outputFile.WriteLine(ContactLabel.Text + " " + Contacttxtbx.Text);
            outputFile.WriteLine(EmailLabel.Text + " " + Emailtxtbx.Text);
            outputFile.WriteLine(SALabel.Text + " " + Streettxtbx.Text);
            outputFile.WriteLine(CityLabel.Text + " " + Citytxtbx.Text);
            outputFile.WriteLine(ProvinceLabel.Text + " " + Provincetxtbx.Text);
            outputFile.WriteLine(labelCountry.Text + " " + Countrytxtbx.Text);
            outputFile.Close();
        }
    }
}
