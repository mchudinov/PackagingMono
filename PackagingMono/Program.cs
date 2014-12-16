using System;
using System.Configuration;

namespace PackagingMono
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var MyConfigParameter = ConfigurationManager.AppSettings["MyConfigParameter"];
            Console.WriteLine(MyConfigParameter);
        }
    }
}
