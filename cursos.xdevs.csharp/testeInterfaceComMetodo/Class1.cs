using System;

namespace testeInterfaceComMetodo
{
    public class Class1 : ICachorroMau
    {

    }

    public class Class2 : ICachorroMau, ICachorroManso
    {
        public Class2()
        {
            
        }
    }

    public class Cachorro
    {

    }

    interface ICachorroMau
    {
        void Morde()
        {
            //escrever dentro deles
        }
    }

    interface ICachorroManso
    {
        void AbanaORabo() 
        { 
            //escrever dentro deles
        }
    }
}
