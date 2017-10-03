using Nethereum.ABI.FunctionEncoding.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NethereumClient.Models
{
    [FunctionOutput]
    public class Question
    {
        [Parameter("uint",1)]
        public int questionIndex1 { get; set; }

        [Parameter("string", 2)]
        public string questionId { get; set; }

        [Parameter("uint", 3)]
        public int questionTextRows { get; set; }

        [Parameter("string",4)]
        public string boardRecommendation { get; set; }

        [Parameter("uint",5)]
        public int isActive { get; set; }

        public string questionText { get; set; }

    }
}
