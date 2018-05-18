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

namespace SudokuGUI
{
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        public void showButtonReplacement() {
            using (StreamReader sr = File.OpenText("E:\\output.txt"))
            {
                string s = String.Empty;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] temp = s.Split(' ');
                    Dictionary<string, TextBox> list = GetTextBoxes();
                    TextBox t = list[temp[0]];
                    t.Text = temp[1];

                }
            }
        }


        public Dictionary<string, TextBox> GetTextBoxes()
        {
            var textBoxes = new Dictionary<string,TextBox>();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    textBoxes.Add(c.Name, (TextBox)c);
                }
            }
            return textBoxes;
        }


        public void runScript(string input) {

            // Use ProcessStartInfo class
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;

            startInfo.FileName = "C:\\python34\\python.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //   startInfo.Arguments = "E:\\test.py" + " " + s;

            startInfo.Arguments = string.Format("{0} {1}", "E:\\Sudoku.py", input);
            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void parseToPython() {

            Dictionary<string, string> dict = getInputs();

            List<string> li = new List<string>();

            foreach (char c in "ABCDEFGHI")
            {
                foreach (char d in "123456789")
                {
                    li.Add(c + ""+d );
                    
                }
            }

            string parse = "";
            foreach (string s in li) {
                if (dict[s] == "")
                    parse = parse + ".";
                else
                    parse = parse + dict[s];
            }

            changeColor();

             runScript(parse);

            using (StreamWriter writetext = new StreamWriter("E:\\input.txt"))
            {
                writetext.WriteLine(parse);
            }


        }

        public void changeColor() {
            foreach (Control c in Controls)
            {

                if (c is TextBox)
                {
                    if (c.Text != "")
                    {
                        c.BackColor = System.Drawing.Color.Crimson;
                        c.ForeColor = System.Drawing.Color.White;

                    }
                    else {
                        c.BackColor = System.Drawing.Color.Aquamarine;
                        c.ForeColor = System.Drawing.Color.Black;
                    }
                  
                }
            }
        }

        public Dictionary<string, string> getInputs()
        {
            var inputs = new Dictionary<string, string>();
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    inputs.Add(c.Name, c.Text);
                }
            }
            return inputs;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            parseToPython();
            showButtonReplacement();
        }

        private void btnClrGrid_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls) {

                if (c is TextBox) {
                    c.Text = "";
                    c.BackColor = Color.White;
                    c.ForeColor = Color.Black;
                } 
            }

        }

        private void A7_TextChanged(object sender, EventArgs e)
        {

        }

        private void I8_TextChanged(object sender, EventArgs e)
        {

        }

        private void I7_TextChanged(object sender, EventArgs e)
        {

        }

        private void H9_TextChanged(object sender, EventArgs e)
        {

        }

        private void H8_TextChanged(object sender, EventArgs e)
        {

        }

        private void H7_TextChanged(object sender, EventArgs e)
        {

        }

        private void G9_TextChanged(object sender, EventArgs e)
        {

        }

        private void G8_TextChanged(object sender, EventArgs e)
        {

        }

        private void G7_TextChanged(object sender, EventArgs e)
        {

        }

        private void I6_TextChanged(object sender, EventArgs e)
        {

        }

        private void I5_TextChanged(object sender, EventArgs e)
        {

        }

        private void I4_TextChanged(object sender, EventArgs e)
        {

        }

        private void H6_TextChanged(object sender, EventArgs e)
        {

        }

        private void H5_TextChanged(object sender, EventArgs e)
        {

        }

        private void H4_TextChanged(object sender, EventArgs e)
        {

        }

        private void G6_TextChanged(object sender, EventArgs e)
        {

        }

        private void G5_TextChanged(object sender, EventArgs e)
        {

        }

        private void G4_TextChanged(object sender, EventArgs e)
        {

        }

        private void I3_TextChanged(object sender, EventArgs e)
        {

        }

        private void I2_TextChanged(object sender, EventArgs e)
        {

        }

        private void I1_TextChanged(object sender, EventArgs e)
        {

        }

        private void H3_TextChanged(object sender, EventArgs e)
        {

        }

        private void H2_TextChanged(object sender, EventArgs e)
        {

        }

        private void H1_TextChanged(object sender, EventArgs e)
        {

        }

        private void G3_TextChanged(object sender, EventArgs e)
        {

        }

        private void G2_TextChanged(object sender, EventArgs e)
        {

        }

        private void G1_TextChanged(object sender, EventArgs e)
        {

        }

        private void F9_TextChanged(object sender, EventArgs e)
        {

        }

        private void F8_TextChanged(object sender, EventArgs e)
        {

        }

        private void F7_TextChanged(object sender, EventArgs e)
        {

        }

        private void E9_TextChanged(object sender, EventArgs e)
        {

        }

        private void E8_TextChanged(object sender, EventArgs e)
        {

        }

        private void E7_TextChanged(object sender, EventArgs e)
        {

        }

        private void D9_TextChanged(object sender, EventArgs e)
        {

        }

        private void D8_TextChanged(object sender, EventArgs e)
        {

        }

        private void D7_TextChanged(object sender, EventArgs e)
        {

        }

        private void F6_TextChanged(object sender, EventArgs e)
        {

        }

        private void F5_TextChanged(object sender, EventArgs e)
        {

        }

        private void F4_TextChanged(object sender, EventArgs e)
        {

        }

        private void E6_TextChanged(object sender, EventArgs e)
        {

        }

        private void E5_TextChanged(object sender, EventArgs e)
        {

        }

        private void E4_TextChanged(object sender, EventArgs e)
        {

        }

        private void D6_TextChanged(object sender, EventArgs e)
        {

        }

        private void D5_TextChanged(object sender, EventArgs e)
        {

        }

        private void D4_TextChanged(object sender, EventArgs e)
        {

        }

        private void F3_TextChanged(object sender, EventArgs e)
        {

        }

        private void F2_TextChanged(object sender, EventArgs e)
        {

        }

        private void F1_TextChanged(object sender, EventArgs e)
        {

        }

        private void E3_TextChanged(object sender, EventArgs e)
        {

        }

        private void E2_TextChanged(object sender, EventArgs e)
        {

        }

        private void E1_TextChanged(object sender, EventArgs e)
        {

        }

        private void D3_TextChanged(object sender, EventArgs e)
        {

        }

        private void D2_TextChanged(object sender, EventArgs e)
        {

        }

        private void D1_TextChanged(object sender, EventArgs e)
        {

        }

        private void C9_TextChanged(object sender, EventArgs e)
        {

        }

        private void C8_TextChanged(object sender, EventArgs e)
        {

        }

        private void C7_TextChanged(object sender, EventArgs e)
        {

        }

        private void B9_TextChanged(object sender, EventArgs e)
        {

        }

        private void B8_TextChanged(object sender, EventArgs e)
        {

        }

        private void B7_TextChanged(object sender, EventArgs e)
        {

        }

        private void A9_TextChanged(object sender, EventArgs e)
        {

        }

        private void A8_TextChanged(object sender, EventArgs e)
        {

        }

        private void I9_TextChanged(object sender, EventArgs e)
        {

        }

        private void C6_TextChanged(object sender, EventArgs e)
        {

        }

        private void C5_TextChanged(object sender, EventArgs e)
        {

        }

        private void C4_TextChanged(object sender, EventArgs e)
        {

        }

        private void B6_TextChanged(object sender, EventArgs e)
        {

        }

        private void B5_TextChanged(object sender, EventArgs e)
        {

        }

        private void B4_TextChanged(object sender, EventArgs e)
        {

        }

        private void A6_TextChanged(object sender, EventArgs e)
        {

        }

        private void A5_TextChanged(object sender, EventArgs e)
        {

        }

        private void A4_TextChanged(object sender, EventArgs e)
        {

        }

        private void C3_TextChanged(object sender, EventArgs e)
        {

        }

        private void C2_TextChanged(object sender, EventArgs e)
        {

        }

        private void C1_TextChanged(object sender, EventArgs e)
        {

        }

        private void B3_TextChanged(object sender, EventArgs e)
        {

        }

        private void B2_TextChanged(object sender, EventArgs e)
        {

        }

        private void B1_TextChanged(object sender, EventArgs e)
        {

        }

        private void A3_TextChanged(object sender, EventArgs e)
        {

        }

        private void A2_TextChanged(object sender, EventArgs e)
        {

        }

        private void A1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sudoku_Load(object sender, EventArgs e)
        {

        }
    }
}
