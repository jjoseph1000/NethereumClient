﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Nethereum.Hex.HexTypes;
using Xunit;
using Nethereum;
using Nethereum.Web3;
using Nethereum.RPC.Eth;
using Nethereum.Hex.HexConvertors.Extensions;

namespace NethereumClient
{
    public class TestClass
    {
        [Fact]
        public async Task ShouldBeAbleToDeployContract()
        {
            try
            {


                var byteCode =
                    "";

                var multiplier = 7;


                //var transactionHash =
                //    await web3.Eth.DeployContract.SendRequestAsync(abi, byteCode, senderAddress, multiplier);

                //var mineResult = await web3.Miner.Start.SendRequestAsync(6);

                //Assert.True(mineResult);

                //var receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);

                //while (receipt == null)
                //{
                //    Thread.Sleep(5000);
                //    receipt = await web3.Eth.Transactions.GetTransactionReceipt.SendRequestAsync(transactionHash);
                //}
                //string test = await castVote();
                string tokenName = await getQuestions();

                //Console.Write(result.ToString());
            }
            catch (Exception ex)
            {

            }
        }



        public async Task<string> getTokenName()
        {
            var web3 = new Web3("https://kovan.infura.io/");

            var contractTokenAddress = "0xec513c1430ee7b41a1bdca26abe7741cad123ef2";
            var abiToken = "[{\"constant\":true,\"inputs\":[],\"name\":\"name\",\"outputs\":[{\"name\":\"\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"_spender\",\"type\":\"address\"},{\"name\":\"_value\",\"type\":\"uint256\"}],\"name\":\"approve\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[],\"name\":\"decimals\",\"outputs\":[{\"name\":\"\",\"type\":\"uint8\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[],\"name\":\"_totalSupply\",\"outputs\":[{\"name\":\"\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"_from\",\"type\":\"address\"},{\"name\":\"_to\",\"type\":\"address\"},{\"name\":\"_value\",\"type\":\"uint256\"}],\"name\":\"transferfrom\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[{\"name\":\"_owner\",\"type\":\"address\"}],\"name\":\"balanceOf\",\"outputs\":[{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[],\"name\":\"symbol\",\"outputs\":[{\"name\":\"\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"_to\",\"type\":\"address\"},{\"name\":\"_value\",\"type\":\"uint256\"}],\"name\":\"transfer\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[{\"name\":\"_owner\",\"type\":\"address\"},{\"name\":\"_spender\",\"type\":\"address\"}],\"name\":\"allowance\",\"outputs\":[{\"name\":\"remaining\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"inputs\":[],\"payable\":false,\"type\":\"constructor\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"name\":\"_from\",\"type\":\"address\"},{\"indexed\":true,\"name\":\"_to\",\"type\":\"address\"},{\"indexed\":false,\"name\":\"_value\",\"type\":\"uint256\"}],\"name\":\"Transfer\",\"type\":\"event\"},{\"anonymous\":false,\"inputs\":[{\"indexed\":true,\"name\":\"_owner\",\"type\":\"address\"},{\"indexed\":true,\"name\":\"_spender\",\"type\":\"address\"},{\"indexed\":false,\"name\":\"_value\",\"type\":\"uint256\"}],\"name\":\"Approval\",\"type\":\"event\"}]";
            var contractToken = web3.Eth.GetContract(abiToken, contractTokenAddress);

            var multiplyFunction = contractToken.GetFunction("name");
            var result = await multiplyFunction.CallAsync<string>();

            return result;
        }

        public async Task<string> getQuestions()
        {
            var web3 = new Web3("https://kovan.infura.io/");


            var abi = "[{\"constant\":false,\"inputs\":[{\"name\":\"voteToken\",\"type\":\"address\"}],\"name\":\"setVoteTokenAddress\",\"outputs\":[{\"name\":\"setTokenId\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"votedAddress\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"transactionId\",\"type\":\"string\"}],\"name\":\"setVoteTransactionId\",\"outputs\":[{\"name\":\"Result\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"indexVoter\",\"type\":\"uint256\"},{\"name\":\"voterAddress\",\"type\":\"address\"}],\"name\":\"getVoteAnswersByAddress\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"voterIndex\",\"type\":\"uint256\"}],\"name\":\"getVoteAnswersByIndex\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"totalVoters\",\"outputs\":[{\"name\":\"totalVoters\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getLastVoteSessionId\",\"outputs\":[{\"name\":\"voteSessionId1\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getVoteAnswers\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionIndex\",\"type\":\"uint256\"}],\"name\":\"getQuestionByIndex\",\"outputs\":[{\"name\":\"questionIndex1\",\"type\":\"uint256\"},{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRows\",\"type\":\"uint256\"},{\"name\":\"boardRecommendation\",\"type\":\"string\"},{\"name\":\"isActive\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRows\",\"type\":\"uint256\"},{\"name\":\"questionText\",\"type\":\"bytes32\"},{\"name\":\"boardRecommendation\",\"type\":\"string\"},{\"name\":\"isActive\",\"type\":\"uint256\"}],\"name\":\"insertUpdateQuestion\",\"outputs\":[{\"name\":\"insertupdate\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[{\"name\":\"x\",\"type\":\"bytes32\"}],\"name\":\"bytes32ToString\",\"outputs\":[{\"name\":\"\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRow\",\"type\":\"uint256\"}],\"name\":\"getQuestionTextByRow\",\"outputs\":[{\"name\":\"questionid\",\"type\":\"string\"},{\"name\":\"row\",\"type\":\"uint256\"},{\"name\":\"textLine\",\"type\":\"bytes32\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRow\",\"type\":\"uint256\"},{\"name\":\"questionText\",\"type\":\"bytes32\"}],\"name\":\"addQuestionTextRow\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"totalQuestions\",\"outputs\":[{\"name\":\"totalQuestions\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"source\",\"type\":\"string\"}],\"name\":\"stringToBytes32\",\"outputs\":[{\"name\":\"result\",\"type\":\"bytes32\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getVoteTokenAddress\",\"outputs\":[{\"name\":\"VoteToken\",\"type\":\"address\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"selectedAnswers\",\"type\":\"string\"}],\"name\":\"vote\",\"outputs\":[{\"name\":\"Result\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"inputs\":[],\"payable\":false,\"type\":\"constructor\"}]";
            var contractAddress = "0xD63b2c39F9b3a6E68B6fec69B1FeC886ceF49c2A";
            var contract = web3.Eth.GetContract(abi, contractAddress);
            var function = contract.GetFunction("getQuestionTextByRow");
            object[] param = new object[2];
            param[0] = "2";
            param[1] = 0;


            QuestionText  result = await function.CallDeserializingToObjectAsync<QuestionText>(param);
            string s = HexStringUTF8ConvertorExtensions.HexToUTF8String(result.textLine.ToHexCompact());
            return "";
        }

        public async Task<string> addQuestions()
        {
            var web3 = new Web3();

            var accountPublicAddress = "0x7627dfa744bdb52bf1f54ae6c8db5320857b20ad";
            var accountPrivateKey = "427b04084f07ee5cbce6fe8110cb556dda2be5df95c79980dea8a05a1e3effb2";
            var txCount = await web3.Eth.Transactions.GetTransactionCount.SendRequestAsync(accountPublicAddress).ConfigureAwait(false);
            Console.Write(txCount.Value);
            var abi = "[{\"constant\":false,\"inputs\":[{\"name\":\"indexVoter\",\"type\":\"uint256\"},{\"name\":\"voterAddress\",\"type\":\"address\"}],\"name\":\"getVoteAnswersByAddress\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"voterIndex\",\"type\":\"uint256\"}],\"name\":\"getVoteAnswersByIndex\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"totalVoters\",\"outputs\":[{\"name\":\"totalVoters\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getLastVoteSessionId\",\"outputs\":[{\"name\":\"voteSessionId1\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getVoteAnswers\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionIndex\",\"type\":\"uint256\"}],\"name\":\"getQuestionByIndex\",\"outputs\":[{\"name\":\"questionIndex1\",\"type\":\"uint256\"},{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRows\",\"type\":\"uint256\"},{\"name\":\"boardRecommendation\",\"type\":\"string\"},{\"name\":\"isActive\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[{\"name\":\"x\",\"type\":\"bytes32\"}],\"name\":\"bytes32ToString\",\"outputs\":[{\"name\":\"\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"selectedAnswers\",\"type\":\"string\"},{\"name\":\"voteShares\",\"type\":\"uint256\"}],\"name\":\"vote\",\"outputs\":[{\"name\":\"Result\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRow\",\"type\":\"uint256\"}],\"name\":\"getQuestionTextByRow\",\"outputs\":[{\"name\":\"questionid\",\"type\":\"string\"},{\"name\":\"row\",\"type\":\"uint256\"},{\"name\":\"textLine\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"totalQuestions\",\"outputs\":[{\"name\":\"totalQuestions\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRow\",\"type\":\"uint256\"},{\"name\":\"questionText\",\"type\":\"string\"}],\"name\":\"addQuestionTextRow\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRows\",\"type\":\"uint256\"},{\"name\":\"questionText\",\"type\":\"string\"},{\"name\":\"boardRecommendation\",\"type\":\"string\"},{\"name\":\"isActive\",\"type\":\"uint256\"}],\"name\":\"insertUpdateQuestion\",\"outputs\":[{\"name\":\"insertupdate\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"source\",\"type\":\"string\"}],\"name\":\"stringToBytes32\",\"outputs\":[{\"name\":\"result\",\"type\":\"bytes32\"}],\"payable\":false,\"type\":\"function\"},{\"inputs\":[],\"payable\":false,\"type\":\"constructor\"}]";
            var contractAddress = "0xfb47C0a488E01Ba3096D5f12751e6824BB11B351";
            var contract = web3.Eth.GetContract(abi, contractAddress);
            var function = contract.GetFunction("insertUpdateQuestion");
            object[] param = new object[5];
            param[0] = "1";
            param[1] = 1;
            param[2] = "Test Question";
            param[3] = "For";
            param[4] = 1;
            var data = function.GetData(param);
            var encoded = web3.OfflineTransactionSigning.SignTransaction(accountPrivateKey, contractAddress, 0,
              txCount.Value, 1000000000000L, 900000, data);

            string returnText = await web3.Eth.Transactions.SendRawTransaction.SendRequestAsync(encoded).ConfigureAwait(false);
            return returnText;
        }

        public async Task<string> castVote()
        {
            var web3 = new Web3("https://kovan.infura.io/");

            var accountPublicAddress = "0x4c3b38F3085A17c1fC8396A3b4B3015ABbC6A2CD";
            var accountPrivateKey = "0d0c308303065f2e42bedec3211fab3cb22449cba989b51e22705a575ad12599";
            var txCount = await web3.Eth.Transactions.GetTransactionCount.SendRequestAsync(accountPublicAddress).ConfigureAwait(false);
            Console.Write(txCount.Value);
            var abi = "[{\"constant\":false,\"inputs\":[{\"name\":\"voteToken\",\"type\":\"address\"}],\"name\":\"setVoteTokenAddress\",\"outputs\":[{\"name\":\"setTokenId\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"votedAddress\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"transactionId\",\"type\":\"string\"}],\"name\":\"setVoteTransactionId\",\"outputs\":[{\"name\":\"Result\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"indexVoter\",\"type\":\"uint256\"},{\"name\":\"voterAddress\",\"type\":\"address\"}],\"name\":\"getVoteAnswersByAddress\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"voterIndex\",\"type\":\"uint256\"}],\"name\":\"getVoteAnswersByIndex\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"totalVoters\",\"outputs\":[{\"name\":\"totalVoters\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getLastVoteSessionId\",\"outputs\":[{\"name\":\"voteSessionId1\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getVoteAnswers\",\"outputs\":[{\"name\":\"indexVoter1\",\"type\":\"uint256\"},{\"name\":\"voter\",\"type\":\"address\"},{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"voteAnswers\",\"type\":\"string\"},{\"name\":\"blockNumber\",\"type\":\"uint256\"},{\"name\":\"balance\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionIndex\",\"type\":\"uint256\"}],\"name\":\"getQuestionByIndex\",\"outputs\":[{\"name\":\"questionIndex1\",\"type\":\"uint256\"},{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRows\",\"type\":\"uint256\"},{\"name\":\"boardRecommendation\",\"type\":\"string\"},{\"name\":\"isActive\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRows\",\"type\":\"uint256\"},{\"name\":\"questionText\",\"type\":\"bytes32\"},{\"name\":\"boardRecommendation\",\"type\":\"string\"},{\"name\":\"isActive\",\"type\":\"uint256\"}],\"name\":\"insertUpdateQuestion\",\"outputs\":[{\"name\":\"insertupdate\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":true,\"inputs\":[{\"name\":\"x\",\"type\":\"bytes32\"}],\"name\":\"bytes32ToString\",\"outputs\":[{\"name\":\"\",\"type\":\"string\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRow\",\"type\":\"uint256\"}],\"name\":\"getQuestionTextByRow\",\"outputs\":[{\"name\":\"questionid\",\"type\":\"string\"},{\"name\":\"row\",\"type\":\"uint256\"},{\"name\":\"textLine\",\"type\":\"bytes32\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"questionId\",\"type\":\"string\"},{\"name\":\"questionTextRow\",\"type\":\"uint256\"},{\"name\":\"questionText\",\"type\":\"bytes32\"}],\"name\":\"addQuestionTextRow\",\"outputs\":[{\"name\":\"success\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"totalQuestions\",\"outputs\":[{\"name\":\"totalQuestions\",\"type\":\"uint256\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"source\",\"type\":\"string\"}],\"name\":\"stringToBytes32\",\"outputs\":[{\"name\":\"result\",\"type\":\"bytes32\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[],\"name\":\"getVoteTokenAddress\",\"outputs\":[{\"name\":\"VoteToken\",\"type\":\"address\"}],\"payable\":false,\"type\":\"function\"},{\"constant\":false,\"inputs\":[{\"name\":\"voteSessionId\",\"type\":\"string\"},{\"name\":\"selectedAnswers\",\"type\":\"string\"}],\"name\":\"vote\",\"outputs\":[{\"name\":\"Result\",\"type\":\"bool\"}],\"payable\":false,\"type\":\"function\"},{\"inputs\":[],\"payable\":false,\"type\":\"constructor\"}]";
            var contractAddress = "0xD63b2c39F9b3a6E68B6fec69B1FeC886ceF49c2A";
            var contract = web3.Eth.GetContract(abi, contractAddress);
            var function = contract.GetFunction("vote");
            object[] param = new object[3];
            param[1] = "asdf";
            param[2] = "BBBAAAZZZ";
            var data = function.GetData(param);
            var encoded = web3.OfflineTransactionSigning.SignTransaction(accountPrivateKey, contractAddress, 0,
              txCount.Value, 1000000000000L, 900000, data);

            string returnText = await web3.Eth.Transactions.SendRawTransaction.SendRequestAsync(encoded).ConfigureAwait(false);
            return returnText;
        }

    }
}
