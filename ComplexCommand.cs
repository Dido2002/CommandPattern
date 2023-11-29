using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStructure
{
    public class ComplexCommand: ICommand //ConcreteCommand2
    {
        private Receiver _receiver;


        //Контекстни данни нужни за стартиране методите на получателя
        private string _a;
        private string _b;

        public ComplexCommand(Receiver receiver, string a, string b)
        {
            _receiver = receiver;
            _a = a;
            _b = b;
        }

        public void Execute() 
        {
            Console.WriteLine("ComplexCommand: Complex stuff should " + $"be done by a receiver object");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);

        }
    }
}
