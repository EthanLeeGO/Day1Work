using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class MyGroupTests
    {
        [TestMethod()]
        public void GroupSumTest_by_3_group()
        {

            var expected = new MyGroup();
            var costs = new List<int>();
            for (int i = 1; i <= 11; i++)
            {
                costs.Add(i);
           } 
            var group = 3;
            var act = expected.GroupSum(costs, group);
            var ass = new List<int>() { 6, 15, 24, 21 };
            // Assert.AreEqual(ass, act);
            act.ToExpectedObject().ShouldEqual(act);
        }

        [TestMethod()]
        public void GroupSumTest_by_4_group()
        {

            var expected = new MyGroup();
            var costs = new List<int>();
            for (int i = 11; i <= 21; i++)
            {
                costs.Add(i);
            }
            var group = 4;
            var act = expected.GroupSum(costs, group);
            var ass = new List<int>() { 50, 66, 601 };
            // Assert.AreEqual(ass, act);
            act.ToExpectedObject().ShouldEqual(act);
        }
    }
}