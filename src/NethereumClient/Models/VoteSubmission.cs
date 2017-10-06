using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NethereumClient.Models
{
    public class VoteSubmission
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonIgnoreIfNull]
        public int UserId { get; set; }

        [BsonIgnoreIfNull]
        public string ControlNumber { get; set; }

        [BsonIgnoreIfNull]
        public string MeetingId { get; set; }

        [BsonIgnoreIfNull]
        public DateTime dateSubmitted { get; set; }

        [BsonIgnoreIfNull]
        public int currentQuestionBeingProcessedNumber { get; set; }

        [BsonIgnoreIfNull]
        public string currentQuestionBeingProcessedQuid { get; set; }

        [BsonIgnoreIfNull]
        public string blockChainProcessingMessage { get; set; }

        [BsonIgnoreIfNull]
        public string blockChainStatus { get; set; }

        [BsonIgnoreIfNull]
        public string voteString { get; internal set; }

        [BsonIgnoreIfNull]
        public int completePercentage { get; set; }
    }
}
