using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_SingleResponsibliltyPrinciple
{

    public interface ILoggers
    {
        public void log();
    }

    public class FileLogger : ILoggers
    {
        public void log()
        {
            Console.WriteLine("File Loging logger");
        }
    }

    public class DBLogger : ILoggers
    {
        public void log()
        {
            Console.WriteLine("DB Loging logger");
        }
    }


    public class  Test
    {
        private ILoggers _ILoggers;

        public Test(ILoggers ILoggers)
        {
            _ILoggers = ILoggers;
        }

        public void logData() {
            Console.WriteLine($"{this._ILoggers.log}");
        }
    }


    public class Client
    {
        Test test = new Test(new DBLogger());
        
        public void Run() {
        test.logData();
        }
    }
}
