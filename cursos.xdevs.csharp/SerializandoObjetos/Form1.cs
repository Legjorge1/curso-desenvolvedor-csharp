using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace SerializandoObjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerializarBin_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.SetId(1);
            pessoa.PrimeiroNome = txtNome.Text;
            pessoa.UltimoNome = txtSobrenome.Text;

            //Colocar em stream
            Stream stream = new FileStream("Pessoa.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            //serializar
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, pessoa);

            //fechar stream
            stream.Close();


        }

        private void btnDesBin_Click(object sender, EventArgs e)
        {
            //Colocar em stream
            Stream stream = new FileStream("Pessoa.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            //serializar
            IFormatter formatter = new BinaryFormatter();
            Pessoa pessoa = (Pessoa)formatter.Deserialize(stream);

            //fechar stream
            stream.Close();

            //Veja o ID

            txtnomeDesbin.Text = pessoa.PrimeiroNome;
            txtsobrenomebin.Text = pessoa.UltimoNome;


        }

        private void btnSerializarXML_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();

            pessoa.SetId(1);
            pessoa.PrimeiroNome = txtnomeserializarxml.Text;
            pessoa.UltimoNome = txtsobrenomeserializarxml.Text;

            //Colocar em stream
            StreamWriter stream = new StreamWriter("Pessoa.xml");

            //serializar
            XmlSerializer formatter = new XmlSerializer(typeof(Pessoa));
            formatter.Serialize(stream, pessoa);

            stream.Close();
        }

        private void btnDeserializarXML_Click(object sender, EventArgs e)
        {
            //Colocar em stream
            FileStream stream = new FileStream("Pessoa.xml", FileMode.Open);

            //serializar
            XmlSerializer formatter = new XmlSerializer(typeof(Pessoa));
            Pessoa pessoa = (Pessoa)formatter.Deserialize(stream);

            //fechar stream
            stream.Close();

            txtnomedeserializarxml.Text = pessoa.PrimeiroNome;
            txtsobrenomeserializarxml.Text = pessoa.UltimoNome;
        }

        private void btnSerializaJson_Click(object sender, EventArgs e)
        {
            Pessoa2 pessoa = new Pessoa2();

            pessoa.SetId(1);
            pessoa.PrimeiroNome = txtNomejsonserialize.Text;
            pessoa.UltimoNome = txtsobreNomejsonserialize.Text;

            //Colocar em stream
            Stream stream = new FileStream("Pessoa.json", FileMode.Create);

            //serializar
            DataContractSerializer formatter = new DataContractSerializer(typeof(Pessoa2));
            formatter.WriteObject(stream, pessoa);

            stream.Close();
        }

        private void btnDesSerializaJson_Click(object sender, EventArgs e)
        {
            //Colocar em stream
            FileStream stream = new FileStream("Pessoa.json", FileMode.Open);

            //serializar
            DataContractSerializer formatter = new DataContractSerializer(typeof(Pessoa2));
            Pessoa2 pessoa = (Pessoa2)formatter.ReadObject(stream);

            //fechar stream
            stream.Close();

            txtNomejsonDesserialize.Text = pessoa.PrimeiroNome;
            txtsobreNomejsonDeserialize.Text = pessoa.UltimoNome;
        }

        void SerializarComInterface() {
            Pessoa3 pessoa = new Pessoa3();

            pessoa.SetId(1);
            pessoa.PrimeiroNome = "xdiadev";
            pessoa.UltimoNome = "twitch";

            //Colocar em stream
            Stream stream = new FileStream("Pessoa3.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            //serializar
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, pessoa);

            //fechar stream
            stream.Close();
        }
        void DeserializarComInterface() {
            //Colocar em stream
            Stream stream = new FileStream("Pessoa3.bin", FileMode.Open, FileAccess.Read, FileShare.Read);

            //serializar
            IFormatter formatter = new BinaryFormatter();
            Pessoa3 pessoa = (Pessoa3)formatter.Deserialize(stream);

            //fechar stream
            stream.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerializarComInterface();
            DeserializarComInterface();
        }
    }


    [Serializable]
    public class Pessoa
    {
        //[NonSerialized]  //binario
        private int _id;

        //[XmlIgnore] //xml
        public string PrimeiroNome;
        public string UltimoNome;

        public void SetId(int id)
        {
            _id = id;
        }


        //[OnSerializing()]
        //internal void estouSerializando(StreamingContext context)
        //{
        //    MessageBox.Show("estou serializado");
        //}


        //[OnSerialized()]
        //internal void jaSerializei(StreamingContext context)
        //{
        //    MessageBox.Show("serializei");
        //}

        //[OnDeserializing()]
        //internal void estouDesSerializando(StreamingContext context)
        //{
        //    MessageBox.Show("estou desserializado");
        //}


        //[OnDeserialized()]
        //internal void jaDesSerializei(StreamingContext context)
        //{
        //    MessageBox.Show("Deserializei");
        //}
    }

    [DataContract]
    public class Pessoa2
    {
        [DataMember]
        private int _id;
        [DataMember]
        public string PrimeiroNome;
        [DataMember]
        public string UltimoNome;

        public void SetId(int id)
        {
            _id = id;
        }
    }

    [Serializable]
    public class Pessoa3 : ISerializable
    {
        private int _id;
        public string PrimeiroNome;
        public string UltimoNome;

        public void SetId(int id)
        {
            _id = id;
        }

        public Pessoa3() { }
        public Pessoa3(SerializationInfo info, StreamingContext contexto)
        {
            PrimeiroNome = info.GetString("Campo customizado 1");
            UltimoNome = info.GetString("Campo customizado 2");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Campo customizado 1", PrimeiroNome);
            info.AddValue("Campo customizado 2", UltimoNome);
        }
    }
}
