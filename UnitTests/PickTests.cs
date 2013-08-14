using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Understrike;

namespace UnitTests {
  [TestClass]
  public class PickTests {

    public HumanTestCase human;

    [TestInitialize]
    public void setup () {
      human = new HumanTestCase ();
    }

    [TestMethod]
    public void pickTest1 () {

      String[] pickList = { "Name", "Age" };
      Dictionary<string, object> dic = _.Pick (human, pickList);

      Assert.AreEqual (dic["Name"], "Duncan", "Name is included and is correct value");
      Assert.AreEqual (dic["Age"], 32, "Age is included and is correct value");

      Assert.AreEqual (dic.Count, 2, "Length of dictionary is 2");

    }

    [TestMethod]
    public void typeTest1 () {

      //String type = (string) _.GetListType (human.GetType()).ToString();

      List<HumanTestCase> humans = new List<HumanTestCase> ();
      humans.Add (human);

      String typeArray = _.GetGenericCollectionItemType (humans.GetType()).ToString();

    }

  }
}