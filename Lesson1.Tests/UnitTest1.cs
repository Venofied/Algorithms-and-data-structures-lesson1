using System;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lesson1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            int Number = 5;
            string result = "Не Простое";
            Task_1 task_1 = new Task_1();

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result, task_1.Search(Number));
        }
    }
}
