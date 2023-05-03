using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileMannager
{
    public partial class RenameForm : Form
    {
        public RenameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Rename.path;
            MessageBox.Show(a);
            string b = Rename.path;
            while (a[a.Length - 1] != '\\')
            {
                a = a.Remove(a.Length - 1, 1);
            }
            MessageBox.Show(a);
            a += textBox1.Text;
            File.Copy(b, a, true);
            File.Delete(b);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
