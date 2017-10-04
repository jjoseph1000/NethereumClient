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
            CheckVoteRequests checkVoteRequests = new CheckVoteRequests();
            bool continueRunning = true;
            while (continueRunning)
            {
                checkVoteRequests.ProcessVote().Wait();

                Task.Delay(60000).Wait();
            }
        }
    }
}
