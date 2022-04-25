using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StreamWriter outputFile;
            outputFile = File.AppendText("123.txt");
            outputFile.WriteLine("=======",
                                            FNLabel.Text + " " + FirstNametxtbx.Text);
            outputFile.WriteLine(LNLabel.Text + " " + LastNametxtbx.Text);
            outputFile.WriteLine(AgeLabel.Text + " " + Agetxtbx.Text);
            outputFile.WriteLine(ContactLabel.Text + " " + Contacttxtbx.Text);
            outputFile.WriteLine(EmailLabel.Text + " " + Emailtxtbx.Text);
            outputFile.WriteLine(SALabel.Text + " " + Streettxtbx.Text);
            outputFile.WriteLine(CityLabel.Text + " " + Citytxtbx.Text);
            outputFile.WriteLine(ProvinceLabel.Text + " " + Provincetxtbx.Text);
            outputFile.WriteLine(CountryLabel.Text + " " + Countrytxtbx.Text);
            outputFile.Close();
        }

        private void LoadInfobtn_Click(object sender, EventArgs e)
        {
            LoadInfo LoadInfo = new LoadInfo();
            LoadInfo.Show(); 
        }
    }
}
