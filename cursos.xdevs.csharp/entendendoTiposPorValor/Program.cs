using System;

namespace entendendoTiposPorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            //==> Struct, vem da biblioteca System
            bool variavelBool = true;
            System.Boolean variavelBool2 = true;

            int iMaximo = 2147483647;
            System.Int32 iMinimo = int.MinValue;

            #region "Explicação 1"
            // Declaração de variável
            int meuInteiro;
            // adicionando valor
            meuInteiro = 3;
            // delcarando e adiocionando valor em uma instrução
            int meuSegundoInteiro = 50;
            #endregion

            #region "Explicação 2"
            // Value Type é "tipo por valor"
            // atribuindo valor um "value type" para outra
            int meuInt;
            int meuSegundoInt;
            // meuInt irá atribuir o valor 2
            meuInt = 2;
            // meuSegundoInt irá conter o valor 2 depois de executar essa instrução
            meuSegundoInt = meuInt;
            // veja os resultados das variáveis.
            Console.WriteLine(meuInt);
            Console.WriteLine(meuSegundoInt);
            Console.WriteLine();

            meuInt = 5;
            Console.WriteLine("Valor meuInt ==>" + meuInt);
            Console.WriteLine("Valor meuSegundoInt ==>" + meuSegundoInt);

            #endregion

            /*
             *  Importante a entender sobre os tipos de valor está na maneira como os valores são gerenciados.
                O .NET Framework armazena tipos de valor na "Stack", e não na Heap (memória do computador). 
                O resultado desses tipos armazenando o valor diretamente e sendo armazenado na pilha é que, se você
                atribuir um tipo de valor a outro, ele copiará o valor do primeiro para o segundo. Tipos de referência
                copiam uma referência (endereço de memória) diferentes dos tipos de valores, discutiremos mais adiante.
             * */

            capacidadeEBits();
        }

        static void capacidadeEBits()
        {
            // declarando alguns tipos numéricos
            int meuInt;
            double meuDouble;
            byte meuByte;
            char meuChar;
            decimal meuDecimal;
            float meuFloat;
            long meuLong;
            short meuShort;
            bool meuBool;
            // adicionanda valores as variaveis
            // printando no console
            // também usando o operador sizeOf para determinar
            // o número de bytes que cada uma leva
            meuInt = 5000;
            Console.WriteLine("Integer");
            Console.WriteLine(meuInt);
            Console.WriteLine(meuInt.GetType());
            Console.WriteLine(sizeof(int));
            Console.WriteLine();
            meuDouble = 5000.0;
            Console.WriteLine("Double");
            Console.WriteLine(meuDouble);
            Console.WriteLine(meuDouble.GetType());
            Console.WriteLine(sizeof(double));
            Console.WriteLine();
            meuByte = 254;
            Console.WriteLine("Byte");
            Console.WriteLine(meuByte);
            Console.WriteLine(meuByte.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            meuChar = 'r';
            Console.WriteLine("Char");
            Console.WriteLine(meuChar);
            Console.WriteLine(meuChar.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            meuDecimal = 20987.89756M;
            Console.WriteLine("Decimal");
            Console.WriteLine(meuDecimal);
            Console.WriteLine(meuDecimal.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            meuFloat = 254.09F;
            Console.WriteLine("Float");
            Console.WriteLine(meuFloat);
            Console.WriteLine(meuFloat.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            meuLong = 2544567538754;
            Console.WriteLine("Long");
            Console.WriteLine(meuLong);
            Console.WriteLine(meuLong.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            meuShort = 3276;
            Console.WriteLine("Short");
            Console.WriteLine(meuShort);
            Console.WriteLine(meuShort.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();
            meuBool = true;
            Console.WriteLine("Boolean");
            Console.WriteLine(meuBool);
            Console.WriteLine(meuBool.GetType());
            Console.WriteLine(sizeof(byte));
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
