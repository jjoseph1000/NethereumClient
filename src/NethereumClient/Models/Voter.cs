﻿using MongoDB.Bson.Serialization.Attributes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NethereumClient.Models
{
    [FunctionOutput]
    public class Voter
    {
        [Parameter("uint256", 1)]
        public long index { get; set; }

        [Parameter("string", 2)]
        public string senderAddress { get; set; }

        public string voterId { get; set; }

        [Parameter("string", 3)]
        public string sessionId { get; set; }

        [Parameter("string", 4)]
        public string voteSelections { get; set; }

        [Parameter("uint", 5)]
        public int blockNumber { get; set; }

        [Parameter("uint256", 6)]
        public long balance { get; set; }

        [BsonIgnoreIfNull]
        public string transactionId { get; set; }
    }
}
