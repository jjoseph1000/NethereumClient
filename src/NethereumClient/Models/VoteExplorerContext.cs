using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace NethereumClient.Models
{
    public class VoteExplorerContext
    {
        public IMongoDatabase Database;
        public IConfigurationRoot Configuration;
        public VoteExplorerContext()
        {
            try
            {
                var builder2 = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

                Configuration = builder2.Build();

                var connectionString = Configuration["MongoDBConnectionString"];
                var settings = MongoClientSettings.FromUrl(new MongoUrl(connectionString));
                //settings.ClusterConfigurator = builder => builder.Subscribe(new Log4NetMongoEvents());
                var client = new MongoClient(settings);
                Database = client.GetDatabase(Configuration["DatabaseName"]);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IMongoCollection<VoteSubmission> votesubmission => Database.GetCollection<VoteSubmission>("votesubmission");

        public IMongoCollection<BlockchainVoteRequest> blockchainvoterequests => Database.GetCollection<BlockchainVoteRequest>("blockchainvoterequests");


    }
}
