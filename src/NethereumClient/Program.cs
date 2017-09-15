using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NethereumClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TestClass test = new TestClass();

            test.ShouldBeAbleToDeployContract().Wait();
        }
    }
}
