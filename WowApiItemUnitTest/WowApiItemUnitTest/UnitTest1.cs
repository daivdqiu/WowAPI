using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WowItemLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace WowApiItemUnitTest
{
    [TestClass]
    public class UnitTest1
    {

        //Test item Set Set of items with Item Set Bonus
        [TestMethod]
        public void TestItemSetAndItem()
        {
            try
            {
                var wowItemSet = JsonConvert.DeserializeObject<WowItemSetLibrary.RootObject>(wowItemSet1060());
                var wowItemObject1 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76749());
                var wowItemObject2 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76750());
                var wowItemObject3 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76751());
                var wowItemObject4 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76752());
                var wowItemObject5 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76753());
                Assert.AreEqual(wowItemSet.items.ToString(), wowItemObject1.itemSet.items.ToString(), "The First item does not have the items that the set has.");
                Assert.AreEqual(wowItemSet.items.ToString(), wowItemObject2.itemSet.items.ToString(), "The Second item does not have the items that the set has.");
                Assert.AreEqual(wowItemSet.items.ToString(), wowItemObject3.itemSet.items.ToString(), "The Third item does not have the items that the set has.");
                Assert.AreEqual(wowItemSet.items.ToString(), wowItemObject4.itemSet.items.ToString(), "The Fourth item does not have the items that the set has.");
                Assert.AreEqual(wowItemSet.items.ToString(), wowItemObject5.itemSet.items.ToString(), "The Fifth item does not have the items that the set has.");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        //Test items for ItemSet is equal to the ItemSet
        [TestMethod]
        public void TestItemSetIDForItem()
        {
            try
            {
                var wowItemSet = JsonConvert.DeserializeObject<WowItemSetLibrary.RootObject>(wowItemSet1060());
                var wowItemObject1 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76749());
                var wowItemObject2 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76750());
                var wowItemObject3 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76751());
                var wowItemObject4 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76752());
                var wowItemObject5 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76753());
                Assert.AreEqual(wowItemSet.id, wowItemObject1.itemSet.id, "The First item does not have the itemsetId that the set has.");
                Assert.AreEqual(wowItemSet.id, wowItemObject2.itemSet.id, "The Second item does not have the itemsetId that the set has.");
                Assert.AreEqual(wowItemSet.id, wowItemObject3.itemSet.id, "The Third item does not have the itemsetId that the set has.");
                Assert.AreEqual(wowItemSet.id, wowItemObject4.itemSet.id, "The Fourth item does not have the itemsetId that the set has.");
                Assert.AreEqual(wowItemSet.id, wowItemObject5.itemSet.id, "The Fifth item does not have the itemsetId that the set has.");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        //Verify that the Threshold required for the Set Bonus is equal to or lower than the total number of Items within the Set
        [TestMethod]
        public void TestVerifyThresholdEqualOrLowerThanSetItemCount()
        {
            try
            {
                var wowItemSet = JsonConvert.DeserializeObject<WowItemSetLibrary.RootObject>(wowItemSet1060());
                var wowItemObject1 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76749());
                var wowItemObject2 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76750());
                var wowItemObject3 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76751());
                var wowItemObject4 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76752());
                var wowItemObject5 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76753());

                for (int i = 0; i < wowItemObject1.itemSet.setBonuses.Count; i++)
			    {
			        Assert.IsTrue(wowItemSet.items.Count >= wowItemObject1.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item1 is greater than the Item Set Item Count");
                    Assert.IsTrue(wowItemSet.items.Count >= wowItemObject2.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item2 is greater than the Item Set Item Count");
                    Assert.IsTrue(wowItemSet.items.Count >= wowItemObject3.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item3 is greater than the Item Set Item Count");
                    Assert.IsTrue(wowItemSet.items.Count >= wowItemObject4.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item4 is greater than the Item Set Item Count");
                    Assert.IsTrue(wowItemSet.items.Count >= wowItemObject5.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item5 is greater than the Item Set Item Count");
            
			    }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        //Verify that the items share the same item set name
        [TestMethod]
        public void TestItemShareItemSetName()
        {
            try
            {
                var wowItemSet = JsonConvert.DeserializeObject<WowItemSetLibrary.RootObject>(wowItemSet1060());
                var wowItemObject1 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76749());
                var wowItemObject2 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76750());
                var wowItemObject3 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76751());
                var wowItemObject4 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76752());
                var wowItemObject5 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76753());

                Assert.AreEqual(wowItemSet.name, wowItemObject1.itemSet.name, "The item set name for item1 and Item set are not the same");
                Assert.AreEqual(wowItemSet.name, wowItemObject2.itemSet.name, "The item set name for item2 and Item set are not the same");
                Assert.AreEqual(wowItemSet.name, wowItemObject3.itemSet.name, "The item set name for item3 and Item set are not the same");
                Assert.AreEqual(wowItemSet.name, wowItemObject4.itemSet.name, "The item set name for item4 and Item set are not the same");
                Assert.AreEqual(wowItemSet.name, wowItemObject5.itemSet.name, "The item set name for item5 and Item set are not the same");
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        //Verify that the Threshold for all the items are the same
        [TestMethod]
        public void TestVerifyThresholdItemsEqual()
        {
            try
            {
                var wowItemObject1 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76749());
                var wowItemObject2 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76750());
                var wowItemObject3 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76751());
                var wowItemObject4 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76752());
                var wowItemObject5 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76753());

                for (int i = 0; i < wowItemObject1.itemSet.setBonuses.Count; i++)
			    {
                    Assert.IsTrue(wowItemObject1.itemSet.setBonuses.ToList()[i].threshold == wowItemObject2.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item1 is not equal to Item2");
                    Assert.IsTrue(wowItemObject2.itemSet.setBonuses.ToList()[i].threshold == wowItemObject3.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item2 is not equal to Item3");
                    Assert.IsTrue(wowItemObject3.itemSet.setBonuses.ToList()[i].threshold == wowItemObject4.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item3 is not equal to Item4");
                    Assert.IsTrue(wowItemObject4.itemSet.setBonuses.ToList()[i].threshold == wowItemObject5.itemSet.setBonuses.ToList()[i].threshold, "The Bonus Threshold for Item4 is not equal to Item5");   
			    }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        //Verify that the items contain the same description
        [TestMethod]
        public void TestVerifyItemsContainSameDescription()
        {
            try
            {
                var wowItemObject1 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76749());
                var wowItemObject2 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76750());
                var wowItemObject3 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76751());
                var wowItemObject4 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76752());
                var wowItemObject5 = JsonConvert.DeserializeObject<WowItemLibrary.RootObject>(wowItem76753());

                for (int i = 0; i < wowItemObject1.itemSet.setBonuses.Count; i++)
                {
                    Assert.AreEqual(wowItemObject1.itemSet.setBonuses.ToList()[i].description.ToString(), wowItemObject2.itemSet.setBonuses.ToList()[i].description.ToString(), "The Bonus Threshold for Item1 is not equal to Item2");
                    Assert.AreEqual(wowItemObject2.itemSet.setBonuses.ToList()[i].description.ToString(), wowItemObject3.itemSet.setBonuses.ToList()[i].description.ToString(), "The Bonus Threshold for Item2 is not equal to Item3");
                    Assert.AreEqual(wowItemObject3.itemSet.setBonuses.ToList()[i].description.ToString(), wowItemObject4.itemSet.setBonuses.ToList()[i].description.ToString(), "The Bonus Threshold for Item3 is not equal to Item4");
                    Assert.AreEqual(wowItemObject4.itemSet.setBonuses.ToList()[i].description.ToString(), wowItemObject5.itemSet.setBonuses.ToList()[i].description.ToString(), "The Bonus Threshold for Item4 is not equal to Item5");
                }
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }

        //Method for accessing the wow item
        public static String wowItem76749()
        {
            Uri uri = new Uri(@"http://us.battle.net/api/wow/item/76749");

            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            return responseData;
        }

        public static String wowItem76750()
        {
            Uri uri = new Uri(@"http://us.battle.net/api/wow/item/76750");

            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            return responseData;
        }

        public static String wowItem76751()
        {
            Uri uri = new Uri(@"http://us.battle.net/api/wow/item/76751");

            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            return responseData;
        }

        public static String wowItem76752()
        {
            Uri uri = new Uri(@"http://us.battle.net/api/wow/item/76752");

            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            return responseData;
        }

        public static String wowItem76753()
        {
            Uri uri = new Uri(@"http://us.battle.net/api/wow/item/76753");

            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            return responseData;
        }

        //Method for accessing the wow item set
        public static String wowItemSet1060()
        {
            Uri uri = new Uri(@"http://us.battle.net/api/wow/item/set/1060");

            WebRequest webRequest = WebRequest.Create(uri);
            WebResponse response = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());
            String responseData = streamReader.ReadToEnd();
            return responseData;
        }
    }
}
