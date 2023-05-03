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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FileMannager
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            label1.Text = "Точнро ли вы хотите удалить этот элемент?";
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Path.GetExtension(Delete.path) == "")
                {
                    Directory.Delete(Delete.path);
                    this.Close();
                    MessageBox.Show($"Папка {Delete.path} удален");

                }
                else
                {
                    File.Delete(Delete.path);
                    this.Close();
                    MessageBox.Show($"Файл {Delete.path} удален");
                }
            }
            catch
            {
                MessageBox.Show("Несколько объектор удалить нельзя");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
