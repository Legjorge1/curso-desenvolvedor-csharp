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

namespace ExemploBinaryStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void escreverArquivo()
        {
            using (SaveFileDialog save = new SaveFileDialog()) {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string fileName = save.FileName;
                    using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
                    {
                        writer.Write(2.5);
                        writer.Write("este é um string");
                        writer.Write(true);
                    }
                }
            }
        }

        void LerArquivo()
        {
            using (OpenFileDialog opens = new OpenFileDialog())
            {
                if (opens.ShowDialog() == DialogResult.OK)
                {
                    using (BinaryReader b = new BinaryReader(File.Open(opens.FileName, FileMode.Open)))
                    {
                        richTextBox1.Clear();

                        int pos = 0;
                        int length = (int)b.BaseStream.Length;
                        while (pos < length)
                        {
                            var v = b.ReadBytes(pos);
                            richTextBox1.Text += string.Join("", v.ToList());
                            pos += sizeof(int);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LerArquivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            escreverArquivo();
        }
    }
}
