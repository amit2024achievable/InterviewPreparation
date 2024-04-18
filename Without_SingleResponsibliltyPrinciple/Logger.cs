using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_SingleResponsibliltyPrinciple
{
    public interface ILogger
    {
        void Info(string message);
        void Debug(string message);
        void Error(string message, Exception ex);
    }
    public class Logger : ILogger
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }

        public void Debug(string message)
        {
            Console.WriteLine(message);
        }

        public void Error(string message, Exception e) {
            Console.WriteLine(message, e);
        }

    }
}
