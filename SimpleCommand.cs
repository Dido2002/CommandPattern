using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandStructure
{
    class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;
        public SimpleCommand(string payload) 
        {   
            this._payload = payload;
        }
        public void Execute() 
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things" + $"Like printing ({this._payload})");
        }
    }
}
