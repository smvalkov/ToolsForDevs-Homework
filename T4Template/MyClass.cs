using System;
using log4net;
using log4net.Config;

namespace T4TemplateDemo
{
    class MyClass
    {
        // Log4Net logging section
        // check the log4net log file in 2.T4Template\T4Template\bin\Debug\Log.txt
        private static readonly ILog logger = LogManager.GetLogger(typeof(MyClass));

        static void Main(string[] args)
        {
            BasicConfigurator.Configure();

            logger.Debug("Here is a debug log.");
            logger.Info("... and an Info log.");
            logger.Warn("... and a warning.");
            logger.Error("... and an error.");
            logger.Fatal("... and a fatal error.");
            logger.Info("... Program is starting.");
            ConsolePrinter0();
            ConsolePrinter1();
            ConsolePrinter2();

        }
        public static void ConsolePrinter0()
        {
            int number = 0 * 0;
            Console.WriteLine(number);
        }

        public static void ConsolePrinter1()
        {
            int number = 1 * 1;
            Console.WriteLine(number);
        }

        public static void ConsolePrinter2()
        {
            int number = 2 * 2;
            Console.WriteLine(number);
        }


    }
}