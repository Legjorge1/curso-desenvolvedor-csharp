using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploIEnumerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Pessoa[] pessoasArray = new[] { new Pessoa("Diogo", "contato@diogocosta.dev"), new Pessoa("Costa", "diogo@codigocentral.com.br"), 
                new Pessoa("Santos", "diogo@icloud.com") };

            Pessoas pessoasNaLista = new Pessoas(pessoasArray);
           
            foreach (Pessoa p in pessoasNaLista)
                textBox1.Text += (p.Nome + " " + p.Email) + Environment.NewLine;
        }
    }


    

        public class Pessoa
        {
            public Pessoa(string _nome, string _email)
            {
                this.Nome = _nome;
                this.Email = _email;
            }

            public string Nome;
            public string Email;
        }

        public class Pessoas : IEnumerable
        {
            private Pessoa[] _pessoas;

            public Pessoas(Pessoa[] pArray)
            {
                _pessoas = new Pessoa[pArray.Length - 1 + 1];

                int i;
                for (i = 0; i <= pArray.Length - 1; i++)
                    _pessoas[i] = pArray[i];
            }

            public IEnumerator GetEnumerator()
            {
                return new PessoasEnum(_pessoas);
            }
        }

        public class PessoasEnum : IEnumerator
        {
            public Pessoa[] _pessoas;

            // Enumeradores são posicionados antes do primeiro elemento
            // ate que o m´metodo MoveNext() seja chamado
            private int posicao = -1;
            public PessoasEnum(Pessoa[] lista)
            {
                _pessoas = lista;
            }
            public bool MoveNext()
            {
                posicao = posicao + 1;
                return (posicao < _pessoas.Length);
            }
            public void Reset()
            {
                posicao = -1;
            }
            public object Current
            {
                get
                {
                    try
                    {
                        return _pessoas[posicao];
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }
    }


