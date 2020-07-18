using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Teste 1"
            ContaBancaria c = new ContaBancaria();
            c.Saldo = 100;

            c.Credito(10);
            c.Debito(100);
            c.Debito(10);
            c.Debito(10); // ==> não tem mais saldo
            c.Debito(10); // ==> não tem mais saldo e o código está errado
            #endregion

            #region "Teste 2"
            ContaBancaria2 d = new ContaBancaria2();
            d.Saldo = 100;

            d.Credito(10);
            d.Debito(100);
            d.Debito(10);
            d.Debito(10); 
            d.Debito(10); // ==> não tem mais saldo
            #endregion

            #region "Teste 3"
            //instrução Microsoft
            ContaBancaria3 e = new ContaBancaria3();
            e.Saldo = 100;
            e.Debito(101);
            #endregion

            #region "Teste 4"
            ContaMonetaria cm = new ContaMonetaria();
            cm.Saldo = 100;
            cm.TaxaDebito(101);

            //Local errado (Subscribe)
            cm.SaldoInsuficiente += Cm_SaldoInsuficiente;
            #endregion

            Console.ReadKey();
        }

        private static void Cm_SaldoInsuficiente(object sender, SaldoInsuficienteEventArgs e)
        {
            Console.WriteLine($"Seu saldo é de {e.SaldoCorrente} a retirada de " +
                $" {e.DebitoMontante.ToString("C")} não pode ser realizada.");
        }

    }

    public class ContaBancaria
    {
        public delegate void SaldoInsuficienteEventHandler();
        public event SaldoInsuficienteEventHandler SaldoInsuficiente;
        // O Saldo da conta.
        public decimal Saldo { get; set; }
        // Adicionando dinheiro na conta.
        public void Credito(decimal montante)
        {
            Saldo += montante;
        }
        // Realizando saques na conta.
        public void Debito(decimal montante)
        {
            // Veja se há tanto dinheiro na conta.
            if (Saldo >= montante)
            {
                // Remove o dinheiro.
                Saldo -= montante;
            }
            else
            {
                // Executar o evento.
                if (SaldoInsuficiente != null) SaldoInsuficiente();
            }
        }
    }

    //Vamos usar o Action
    public class ContaBancaria2
    {
        //Alteração da ContaBancaria para a ContaBancaria2

        //public delegate void SaldoInsuficienteEventHandler();
        //public event SaldoInsuficienteEventHandler SaldoInsuficiente;

        public event Action SaldoInsuficiente;

        // O Saldo da conta.
        public decimal Saldo { get; set; }
        // Adicionando dinheiro na conta.
        public void Credito(decimal montante)
        {
            Saldo += montante;
        }
        // Realizando saques na conta.
        public void Debito(decimal montante)
        {
            // Veja se há tanto dinheiro na conta.
            if (Saldo >= montante)
            {
                // Remove o dinheiro.
                Saldo -= montante;
            }
            else
            {
                // Executar o evento.
                if (SaldoInsuficiente != null) SaldoInsuficiente();
            }
        }
    }

    //Microsoft recomenda utilizar uma Classe
    public class SaldoInsuficienteEventArgs : EventArgs
    {
        public decimal SaldoCorrente, DebitoMontante;
        public SaldoInsuficienteEventArgs(decimal saldoCorrente, decimal debitoMontante)
        {
            SaldoCorrente = saldoCorrente;
            DebitoMontante = debitoMontante;
        }
    }

    public class ContaBancaria3
    {
        //Alteração da ContaBancaria para a ContaBancaria2

        //public delegate void SaldoInsuficienteEventHandler();
        //public event SaldoInsuficienteEventHandler SaldoInsuficiente;

        //public event Action SaldoInsuficiente;

        public event EventHandler<SaldoInsuficienteEventArgs> SaldoInsuficiente;
       

        // O Saldo da conta.
        public decimal Saldo { get; set; }
        // Adicionando dinheiro na conta.
        public void Credito(decimal montante)
        {
            Saldo += montante;
        }
        // Realizando saques na conta.
        public void Debito(decimal montante)
        {
            // Veja se há tanto dinheiro na conta.
            if (Saldo >= montante)
            {
                // Remove o dinheiro.
                Saldo -= montante;
            }
            else
            {
                // Executar o evento.
                if (SaldoInsuficiente != null)
                    SaldoInsuficiente(this, new SaldoInsuficienteEventArgs(Saldo, montante));

                //Agora quando o evento passar, 
                //Nós poderemos enviar as informaçõe, do objeto e a classe com informações
            }
        }
    }

    public class ContaBancaria4
    {
        //Alteração da ContaBancaria para a ContaBancaria2

        //public delegate void SaldoInsuficienteEventHandler();
        //public event SaldoInsuficienteEventHandler SaldoInsuficiente;

        //public event Action SaldoInsuficiente;

        public event EventHandler<SaldoInsuficienteEventArgs> SaldoInsuficiente;

        // Executar nosso evento.
        protected virtual void OnSaldoInsuficiente(SaldoInsuficienteEventArgs args)
        {
            if (SaldoInsuficiente != null) SaldoInsuficiente(this, args);
        }

        // O Saldo da conta.
        public decimal Saldo { get; set; }
        // Adicionando dinheiro na conta.
        public void Credito(decimal montante)
        {
            Saldo += montante;
        }
        // Realizando saques na conta.
        public void Debito(decimal montante)
        {
            // Veja se há tanto dinheiro na conta.
            if (Saldo >= montante)
            {
                // Remove o dinheiro.
                Saldo -= montante;
            }
            else
            {
                // Executar o evento.
                OnSaldoInsuficiente(new SaldoInsuficienteEventArgs(Saldo, montante));

                //Agora quando o evento passar, 
                //Nós poderemos enviar as informaçõe, do objeto e a classe com informações
            }
        }
    }

    public class ContaMonetaria : ContaBancaria4
    {
        public void TaxaDebito(decimal montante)
        {
            // See if there is this much money in the account.
            if (Saldo >= montante)
            {
                // Remove the money.
                Saldo -= montante;
            }
            else
            {
                // Raise the Overdrawn event.
                OnSaldoInsuficiente(new SaldoInsuficienteEventArgs(Saldo, montante));
            }
        }
    }
}
