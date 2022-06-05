using System;

namespace Bridge
{
    internal class Program
    {
        class Client
        {
            public void ClientCode(Abstraction abstraction)
            {
                Console.Write(abstraction.Operation());
            }
        }
        static void Main(string[] args)
        {
            Client client = new Client();

            Abstraction abstraction;
            abstraction = new Abstraction(new ConcreteImpA());
            client.ClientCode(abstraction);

            Console.WriteLine();

            abstraction = new ExtendedAbstraction(new ConcreteImpB());
            client.ClientCode(abstraction);
        }
    }
}
