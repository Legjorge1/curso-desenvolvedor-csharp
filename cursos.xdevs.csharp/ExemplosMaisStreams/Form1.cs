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

namespace ExemplosMaisStreams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textReader
            using (OpenFileDialog save = new OpenFileDialog())
            {
                richTextBox1.Clear();

                if (save.ShowDialog() == DialogResult.OK)
                {
                    TextReader tr = new StreamReader(save.FileName);
                    richTextBox1.Text += tr.ReadToEnd();
                    tr.Close();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            using (SaveFileDialog save = new SaveFileDialog())
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    TextWriter tw = new StreamWriter(save.FileName);
                    tw.Write(richTextBox1.Text);
                    tw.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            //stringReader
            StringBuilder text = new StringBuilder(@"Este é um texto 
                            Para ser lido pelo
                            StringReader");

            StringWriter sw = new StringWriter(text);
            sw.WriteLine("mai um texto");

            StringReader sr = new StringReader(text.ToString());
            richTextBox1.Text =  sr.ReadLine();
            sr.Close();

            
            using (StringReader reader = new StringReader(text.ToString()))
            {
                int count = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    count++;
                    richTextBox1.Text += string.Format("Linhas {0}: {1}", count, line);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            using (OpenFileDialog save = new OpenFileDialog())
            {
                richTextBox1.Clear();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    byte[] file = File.ReadAllBytes(save.FileName);

                    using (MemoryStream memory = new MemoryStream(file))
                    {
                        using (BinaryReader reader = new BinaryReader(memory))
                        {
                            for (int i = 0; i < file.Length; i++)
                            {
                                byte result = reader.ReadByte();
                                richTextBox1.Text += (result);
                            }
                        }
                    }
                }
            }
        }
    }
}
