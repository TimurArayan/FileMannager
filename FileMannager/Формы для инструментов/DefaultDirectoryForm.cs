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
using static System.Net.Mime.MediaTypeNames;

namespace FileMannager
{
    public partial class DefaultDirectoryForm : Form
    {
        public DefaultDirectoryForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBox1.Text))
            {
                DefaultDirectory.path = textBox1.Text;
            }
            else
            {
                MessageBox.Show("Такой директории не существует, введите полный путь.");
            }

        }
    }
}
