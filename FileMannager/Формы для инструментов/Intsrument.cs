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

namespace FileMannager.Формы_для_инструментов
{
    public partial class Intsrument : Form
    {
        public Intsrument()
        {
            InitializeComponent();
            if (FileMannager.Классы_для_интрументов.Inst.function == 1)
            {
                button1.Text = "Создать файл";
            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 2)
            {
                button1.Text = "Создать директорию";
            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 3)
            {
                button1.Text = "Удалить";
            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 4)
            {
                button1.Text = "Скопировать";
            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 5)
            {
                label2.Show();
                textBox2.Show();
                button1.Text = "Переименовать";
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FileMannager.Классы_для_интрументов.Inst.function == 1)
            {
                try
                {
                    System.IO.File.Create(textBox1.Text);

                }
                catch
                {
                    MessageBox.Show("Напраильнно написан путь или нет разрешения действовать в этой папке");
                }
            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 2)
            {
                try
                {
                    System.IO.Directory.CreateDirectory(textBox1.Text);

                }
                catch
                {
                    MessageBox.Show("Напраильнно написан путь или нет разрешения действовать в этой папке");
                }
            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 3)
            {
                try
                {
                    if (Path.GetExtension(textBox1.Text) == "")
                    {
                        System.IO.Directory.Delete(textBox1.Text);
                    }
                    else
                    {
                        System.IO.File.Delete(textBox1.Text);
                    }
                }
                catch
                {
                    MessageBox.Show("Напраильнно написан путь или нет разрешения действовать в этой папке");
                }

            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 4)
            {
                try
                {
                    if (Path.GetExtension(textBox1.Text) == "")
                    {
                        System.IO.File.Copy(textBox1.Text, textBox1.Text + "_копия");

                    }
                    else
                    {
                        string b = "";
                        string a = "";
                        string path = textBox1.Text;
                        while (path[path.Length - 1] != '.')
                        {
                            a += path[path.Length - 1];
                            path = path.Remove(path.Length - 1, 1);
                        }
                        path = path.Remove(path.Length - 1, 1);
                        for (int i = 0; i < a.Length; i++)
                        {
                            b += a[a.Length - (i + 1)];
                        }
                        path = path + "_копия" + "." + b;
                        System.IO.File.Copy(textBox1.Text, b);
                        MessageBox.Show("Новый файл" + b);
                    }
                }
                catch
                {
                    MessageBox.Show("Напраильнно написан путь или нет разрешения действовать в этой папке");
                }

            }
            else if (FileMannager.Классы_для_интрументов.Inst.function == 5)
            {
                try
                {
                    if (Path.GetExtension(textBox1.Text) == "")
                    {
                        MessageBox.Show("Папки нельзя копировать");
                    }
                    else
                    {
                        if (textBox1.Text != textBox2.Text)
                        {
                            System.IO.File.Delete(textBox1.Text);

                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Напраильнно написан путь или нет разрешения действовать в этой папке");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
