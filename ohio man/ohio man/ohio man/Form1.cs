using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using EasyExploits;
using System.IO;

namespace ohio_man
{
    public partial class Form1 : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://meatspin.com/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int A = rand.Next(0, 255);
            int R = rand.Next(0, 255);
            int G = rand.Next(0, 255);
            int B = rand.Next(0, 255); button1.ForeColor = Color.FromArgb(A, R, G, B);
        }

        private void formSkin1_Click(object sender, EventArgs e)
        {

        }

        private void flatButton9_Click(object sender, EventArgs e)
        {
            TopMost = true;
        }

        private void flatButton1_Click(object sender, EventArgs e)
        {
            module.ExecuteScript(fastColoredTextBox1.Text);
        }

        private void flatButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void flatButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void flatButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream s = sfd.OpenFile();
                StreamWriter sw = new StreamWriter(s);
                sw.Write(fastColoredTextBox1.Text);
                sw.Close();
            }
        }

        private void flatButton5_Click(object sender, EventArgs e)
        {
            module.LaunchExploit();
        }

        private void flatButton8_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.MediumPurple);
        }

        private void flatButton7_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.Yellow);
        }

        private void flatButton6_Click(object sender, EventArgs e)
        {
            formSkin1.FlatColor = (Color.LightPink);
        }
    }
}
