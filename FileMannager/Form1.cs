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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.Net.Http.Headers;
using System.Management.Instrumentation;

namespace FileMannager
{
    public partial class Form1 : Form
    {
        int selectedlistbox = 1;
        public void Refresh()
        {
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo dirInfo in dirs)
            {
                listBox1.Items.Add(dirInfo);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);
            }
            listBox2.Items.Clear();
            DirectoryInfo qwe = new DirectoryInfo(textBox2.Text);
            DirectoryInfo[] qwes = dir.GetDirectories();
            foreach (DirectoryInfo dirInfo in qwes)
            {
                listBox2.Items.Add(dirInfo);
            }
            FileInfo[] files2 = qwe.GetFiles();
            foreach (FileInfo file in files2)
            {
                listBox2.Items.Add(file);
            }

        }
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo("C:\\Users\\") ;
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo dirInfo in dirs)
            {
                listBox1.Items.Add(dirInfo);
            }
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                listBox1.Items.Add(file);
            }
            foreach (DirectoryInfo dirInfo in dirs)
            {
                listBox2.Items.Add(dirInfo);
            }
            foreach (FileInfo file in files)
            {
                listBox2.Items.Add(file);
            }
            textBox1.Text = "C:\\Users\\";
            textBox2.Text = "C:\\Users\\";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Path.GetExtension(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString())) == "")
                {
                    textBox1.Text = Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString());
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox1.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);
                    }
                }
                else
                {
                    Process.Start(Path.Combine(textBox1.Text, listBox1.SelectedItem.ToString()));
                }
            }
            catch { }
            selectedlistbox = 1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox1.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);
                    }
                }
                catch { }

            }
            selectedlistbox = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (Path.GetExtension(Path.Combine(textBox2.Text, listBox2.SelectedItem.ToString())) == "")
                {
                    textBox2.Text = Path.Combine(textBox2.Text, listBox2.SelectedItem.ToString());
                    listBox2.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox2.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox2.Items.Add(file);
                    }
                }
                else
                {
                    Process.Start(Path.Combine(textBox2.Text, listBox1.SelectedItem.ToString()));
                }
            }
            catch { }
            selectedlistbox = 2;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    listBox2.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox2.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox2.Items.Add(file);
                    }
                }
                catch { }

            }
            selectedlistbox = 2;
        }

        ///Кнопки
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                try
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    }
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox1.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);
                    }
                }
                catch { }
            }
            else if (selectedlistbox == 2)
            {
                try
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                    while (textBox2.Text[textBox2.Text.Length - 1] != '\\')
                    {
                        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                    }
                    listBox2.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox2.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox2.Items.Add(file);
                    }
                }
                catch { }
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }


        private void скопироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void переименоватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                try
                {
                    string path = textBox1.Text + "\\" + listBox1.SelectedItem.ToString();
                    System.IO.File.Delete(path);
                    MessageBox.Show($"Файл ${listBox1.SelectedItem.ToString()} удален.");
                }
                catch
                {
                    MessageBox.Show("Не надо это удалять.");
                }
            }
            else
            {
                try
                {
                    string path = textBox2.Text + "\\" + listBox2.SelectedItem.ToString();
                    System.IO.File.Delete(path);
                    MessageBox.Show($"Файл ${listBox2.SelectedItem.ToString()} удален.");
                }
                catch
                {
                    MessageBox.Show("Не надо это удалять.");
                }
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void listBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                string path = textBox1.Text;
                Create.path = path;
                CreateForm cf = new CreateForm();
                cf.Show();
                Refresh();
            }
            else
            {
                string path = textBox2.Text;
                Create.path = path;
                CreateForm cf = new CreateForm();
                cf.Show();
                Refresh();
            }
            Refresh();
        }


        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                try
                {
                    string path = textBox1.Text + "\\" + listBox1.SelectedItem.ToString();
                    Delete.path = path;
                    DeleteForm df = new DeleteForm();
                    df.Show();
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox1.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);
                    }

                }
                catch
                {
                    MessageBox.Show("Сначала выберите объект.");
                }
            }
            else
            {
                try
                {
                    string path = textBox2.Text + "\\" + listBox2.SelectedItem.ToString();
                    Delete.path = path;
                    DeleteForm df = new DeleteForm();
                    df.Show();
                    listBox2.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox2.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox2.Items.Add(file);
                    }

                }
                catch
                {
                    MessageBox.Show("Сначала выберите объект.");
                }
            }

        }

        private void переименоватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                string path = textBox1 + listBox1.SelectedItem.ToString();
                Rename.path = path;
                RenameForm rf = new RenameForm();
                rf.Show();
                listBox1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo dirInfo in dirs)
                {
                    listBox1.Items.Add(dirInfo);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
            else
            {
                string path = textBox2 + listBox2.SelectedItem.ToString();
                Rename.path = path;
                RenameForm rf = new RenameForm();
                rf.Show();
                listBox2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo dirInfo in dirs)
                {
                    listBox2.Items.Add(dirInfo);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox2.Items.Add(file);
                }
            }

        }

        private void скопироватьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                string path = textBox1.Text + "\\" + listBox1.SelectedItem.ToString();
                System.IO.File.Copy(path, textBox1.Text + "\\" + "копия_" + listBox1.SelectedItem.ToString());
                listBox1.Items.Clear();
                listBox1.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo dirInfo in dirs)
                {
                    listBox1.Items.Add(dirInfo);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add(file);
                }
            }
            else
            {
                string path = textBox2.Text + "\\" + listBox1.SelectedItem.ToString();
                System.IO.File.Copy(path, textBox1.Text + "\\" + "копия_" + listBox1.SelectedItem.ToString());
                listBox2.Items.Clear();
                listBox2.Items.Clear();
                DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                DirectoryInfo[] dirs = dir.GetDirectories();
                foreach (DirectoryInfo dirInfo in dirs)
                {
                    listBox2.Items.Add(dirInfo);
                }
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    listBox2.Items.Add(file);
                }
            }
        }

        private void свойстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                string path = textBox1.Text + '\\' + listBox1.SelectedItem.ToString();
                MessageBox.Show($"{path}");
            }
            else
            {
                string path = textBox2.Text + '\\' + listBox2.SelectedItem.ToString();
                MessageBox.Show($"{path}");
            }
        }

        private void отменитьВыделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                listBox1.ClearSelected();
            }
            else if (selectedlistbox == 2)
            {
                listBox2.ClearSelected();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void цветоваяСхемаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedlistbox == 1)
            {
                try
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    while (textBox1.Text[textBox1.Text.Length - 1] != '\\')
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                    }
                    listBox1.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox1.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox1.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox1.Items.Add(file);
                    }
                }
                catch { }
            }
            else if (selectedlistbox == 2)
            {
                try
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                    while (textBox2.Text[textBox2.Text.Length - 1] != '\\')
                    {
                        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1, 1);
                    }
                    listBox2.Items.Clear();
                    DirectoryInfo dir = new DirectoryInfo(textBox2.Text);
                    DirectoryInfo[] dirs = dir.GetDirectories();
                    foreach (DirectoryInfo dirInfo in dirs)
                    {
                        listBox2.Items.Add(dirInfo);
                    }
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        listBox2.Items.Add(file);
                    }
                }
                catch { }
            }
        }

        private void светлаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.Control;
            listBox1.BackColor = SystemColors.Window;
            listBox2.BackColor = SystemColors.Window;
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            menuStrip1.BackColor = SystemColors.Control;
            инструментыToolStripMenuItem.DropDown.BackColor = SystemColors.Control;
            натсройкиToolStripMenuItem.DropDown.BackColor = SystemColors.Control;
            темаToolStripMenuItem.DropDown.BackColor = SystemColors.Control;
            button1.BackColor = SystemColors.Control;
            contextMenuStrip1.BackColor = SystemColors.Window;
            this.ForeColor = Color.Black;
            listBox1.ForeColor = Color.Black;
            listBox2.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            menuStrip1.ForeColor = Color.Black;
            инструментыToolStripMenuItem.DropDown.ForeColor = Color.Black;
            натсройкиToolStripMenuItem.DropDown.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            темаToolStripMenuItem.DropDown.ForeColor = Color.Black;
            contextMenuStrip1.ForeColor = Color.Black;

        }

        private void темнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            listBox1.BackColor = Color.Black;
            listBox2.BackColor = Color.Black;
            textBox1.BackColor = Color.Black;
            textBox2.BackColor = Color.Black;
            menuStrip1.BackColor = Color.Black;
            инструментыToolStripMenuItem.DropDown.BackColor = Color.Black;
            натсройкиToolStripMenuItem.DropDown.BackColor = Color.Black;
            темаToolStripMenuItem.DropDown.BackColor = Color.Black;
            button1.BackColor = Color.Black;
            contextMenuStrip1.BackColor = Color.Black;
            this.ForeColor = Color.White;
            listBox1.ForeColor = Color.White;
            listBox2.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
            textBox2.ForeColor = Color.White;
            menuStrip1.ForeColor = Color.White;
            инструментыToolStripMenuItem .DropDown.ForeColor = Color.White;
            натсройкиToolStripMenuItem .DropDown.ForeColor = Color.White;
            button1.ForeColor = Color.White;
            темаToolStripMenuItem .DropDown.ForeColor = Color.White;
            contextMenuStrip1.ForeColor = Color.White;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void натсройкиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {
            selectedlistbox = 1;
        }

        private void listBox2_MouseEnter(object sender, EventArgs e)
        {
            selectedlistbox = 2;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            this.Font = fontDialog1.Font;
            listBox1.Font = fontDialog1.Font;
            listBox2.Font = fontDialog1.Font;
            textBox1.Font = fontDialog1.Font;
            textBox2.Font = fontDialog1.Font;
            menuStrip1.Font = fontDialog1.Font;
            contextMenuStrip1.Font = fontDialog1.Font;
            button1.Font = fontDialog1.Font;
        }

        private void директорияПоУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DefaultDirectoryForm ddf = new DefaultDirectoryForm();
            ddf.Show();
        }

        private void инструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileMannager.Классы_для_интрументов.Inst.function = 1;
            Формы_для_инструментов.Intsrument inf = new Формы_для_инструментов.Intsrument();
            inf.Show();
        }

        private void создатьДиректориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileMannager.Классы_для_интрументов.Inst.function = 2;
            Формы_для_инструментов.Intsrument inf = new Формы_для_инструментов.Intsrument();
            inf.Show();
        }

        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FileMannager.Классы_для_интрументов.Inst.function = 3;
            Формы_для_инструментов.Intsrument inf = new Формы_для_инструментов.Intsrument();
            inf.Show();
        }

        private void скопироватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FileMannager.Классы_для_интрументов.Inst.function = 4;
            Формы_для_инструментов.Intsrument inf = new Формы_для_инструментов.Intsrument();
            inf.Show();
        }

        private void пероеименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileMannager.Классы_для_интрументов.Inst.function = 5;
            Формы_для_инструментов.Intsrument inf = new Формы_для_инструментов.Intsrument();
            inf.Show();
        }
    }
}
