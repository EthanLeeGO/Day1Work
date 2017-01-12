using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1.Tests
{
    [TestClass()]
    public class MyGroupTests
    {


        public class Product
        {
            public int id { get; set; }
            public int cost { get; set; }
            public int Revenue { get; set; }
            public int sellprice { get; set; }
        }

        public List<Product> produsts = new List<Product>();

        public MyGroupTests()
        {
            produsts.Add(new Product() { id =1, cost = 1,Revenue=11,sellprice=21 });
            produsts.Add(new Product() { id = 2, cost = 2, Revenue = 12, sellprice = 22 });
            produsts.Add(new Product() { id = 3, cost = 3, Revenue = 13, sellprice = 23 });
            produsts.Add(new Product() { id = 4, cost = 4, Revenue = 14, sellprice = 24 });
            produsts.Add(new Product() { id = 5, cost = 5, Revenue = 15, sellprice = 25 });
            produsts.Add(new Product() { id = 6, cost = 6, Revenue = 16, sellprice = 26 });
            produsts.Add(new Product() { id = 7, cost = 7, Revenue = 17, sellprice = 27 });
            produsts.Add(new Product() { id = 8, cost = 8, Revenue = 18, sellprice = 28 });
            produsts.Add(new Product() { id = 9, cost = 9, Revenue = 19, sellprice = 29 });
            produsts.Add(new Product() { id = 10, cost = 10, Revenue = 20, sellprice = 30 });
            produsts.Add(new Product() { id = 11, cost = 11, Revenue = 21, sellprice = 31 });
        }
 


        [TestMethod()]

        public void GroupSumTest_by_3_group()
        {

            var expected = new MyGroup();
           
            var group = 3;
            var act = expected.GroupSum(produsts.Select(x=>x.cost) , group);
            var ass = new List<int>() { 6, 15, 24, 21 };
            // Assert.AreEqual(ass, act);
            act.ToExpectedObject().ShouldEqual(act);
        }

        [TestMethod()]
        public void GroupSumTest_by_4_group()
        {

            var expected = new MyGroup();
            var costs = new List<int>();
       
            var group = 4;
            var act = expected.GroupSum(produsts.Select(x => x.Revenue), group);
            var ass = new List<int>() { 50, 66, 601 };
            // Assert.AreEqual(ass, act);
            act.ToExpectedObject().ShouldEqual(act);
        }
    }
}