using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using TicTacToe;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var expectedPartialString = "Player1: X and Player2: O";
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TicTacToeProgram.Main();

                var result = sw.ToString().Substring(0,25);
                Assert.AreEqual(expectedPartialString, result);
            }
        }
    }
}
