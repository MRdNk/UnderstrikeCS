using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Understrike;

namespace UnitTests {
  [TestClass]
  public class PluckTests {

    public HumanTestCase human;

    [TestInitialize]
    public void setup () {
      human = new HumanTestCase ();
    }

    [TestMethod]
    public void pluck1 () {

      String[] pluckList = { "Name", "Age" };
      Dictionary<string, object> dic = _.Pick (human, pluckList);

      Assert.AreEqual (dic["Name"], "Duncan", "Name is included and is correct value");
      Assert.AreEqual (dic["Age"], 32, "Age is included and is correct value");

      Assert.AreEqual (dic.Count, 2, "Length of dictionary is 2");


    }

  }
}