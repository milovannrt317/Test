using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private const char separator = ';';
        private const string pathFile = "testResults.txt";
        private const string solutionName = "Test";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSort_Click(object sender, EventArgs e)
        {
            if(Regex.Match(txtNum.Text, "([a-zA-Z])+").Success)
            {
                MessageBox.Show("Must contain only numbers with separator between!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!chkFile.Checked && !chkUI.Checked)
            {
                MessageBox.Show("One type of display mode must be checked!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string order = gbOrder.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            string results = NumbersUtil.sortNumbers(txtNum.Text, order, separator);

            if (chkFile.Checked)
            {
                printResultsInFile(results);
            }
            if (chkUI.Checked)
            {
                printResultsOnUI(results);
            }
            
        }

        private void printResultsOnUI(string results) {
            lstResults.Items.Insert(0, results);
        }
        private void printResultsInFile(string results)
        {
            
            string startPath = getSolutionPath(Environment.CurrentDirectory);
            string path = Path.Combine(startPath, pathFile);
            
            StreamWriter sw = File.AppendText(path);
            sw.WriteLine(results);
            sw.Close();
        }

        private string getSolutionPath(string path)
        {
            var dir = System.IO.Directory.GetParent(path);

            if (dir.Name.Equals(solutionName))
            {
                return dir.FullName;
            }
            else if (!(dir.Root.Name.Equals(dir.Name)))
                return getSolutionPath(dir.FullName);
            else
                return Environment.CurrentDirectory;
        }
        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != separator))
            {
                e.Handled = true;
            }

            TextBox tb = sender as TextBox;
            int tbLength = tb.Text.Length;

            if (tbLength == 0 && (e.KeyChar == separator))
            {
                e.Handled = true;
            }

            if (tbLength>0 && (e.KeyChar == separator) && (tb.Text.ToCharArray()[tbLength-1]== separator))
            {
                e.Handled = true;
            }
        }
    }
}
