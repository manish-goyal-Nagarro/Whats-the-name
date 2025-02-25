﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace WhatsTheNameAPI.AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Properties")]
    public partial class MovieFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Properties.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Properties", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add property")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("London, Essex", "250.000", "Court House", "New Development", "201", "1", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Essex, Romford", "200.000", "New House", "House", "201", "2", new string[0])]
        [NUnit.Framework.TestCaseAttribute("London, Soho", "300.000", "Court House", "New Development", "201", "3", new string[0])]
        [NUnit.Framework.TestCaseAttribute("London, Wanstead", "350.000", "New House", "House", "201", "4", new string[0])]
        [NUnit.Framework.TestCaseAttribute("London, Stratford", "370.000", "Court House", "New Development", "201", "5", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Essex, Liverpool St", "500.000", "New House", "House", "201", "6", new string[0])]
        public virtual void AddProperty(string address, string price, string name, string propertyDescription, string statusCode, string id, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add property", @__tags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
 testRunner.Given(string.Format("I create a new property ({0},{1},{2},{3},{4})", address, price, name, propertyDescription, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
    testRunner.And("ModelState is correct", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 7
 testRunner.Then(string.Format("the system should return {0}", statusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get Properties")]
        [NUnit.Framework.TestCaseAttribute("1", "3", "None", "250.000", "370.000", "0", new string[0])]
        public virtual void GetProperties(string page, string pageSize, string address, string priceMin, string priceMax, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get Properties", exampleTags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 20
 testRunner.Given(string.Format("I request to view properties with pagination ({0},{1},{2},{3},{4},{5})", page, pageSize, address, priceMin, priceMax, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.Then("system should return Pagination Headers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Properties")]
        [NUnit.Framework.TestCaseAttribute("1", "1", "London  Essex", "250.000", "Court House", "New Development", "250.000", "370.000", "8", new string[0])]
        public virtual void DeleteProperties(string page, string pageSize, string address, string price, string name, string propertyDescription, string priceMin, string priceMax, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Properties", exampleTags);
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given(string.Format("I create a new property ({0},{1},{2},{3},{4})", address, price, name, propertyDescription, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
    testRunner.When("I delete a property", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And(string.Format("I request to view properties with pagination ({0},{1},{2},{3},{4},{5})", page, pageSize, address, priceMin, priceMax, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("the system should not return any results", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Properties")]
        [NUnit.Framework.TestCaseAttribute("Essex, Liverpool St", "500.000", "New House", "House", "London Liverpool St", "550.000", "1", new string[0])]
        public virtual void UpdateProperties(string address, string price, string name, string propertyDescription, string newAddress, string newPrice, string id, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Properties", exampleTags);
#line 37
this.ScenarioSetup(scenarioInfo);
#line 38
 testRunner.Given(string.Format("I create a new property ({0},{1},{2},{3},{4})", address, price, name, propertyDescription, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When(string.Format("I update an existing property ({0},{1})", newAddress, newPrice), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And(string.Format("I request to view properties with pagination (<page>,<pageSize>,<address>,<priceM" +
                        "in>,<priceMax>,{0})", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("the updated property should be included in the list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ETag Flow")]
        [NUnit.Framework.TestCaseAttribute("Essex  Liverpool St", "500.000", "New House", "House", "1", "1", "11", "200", "304", new string[0])]
        public virtual void ETagFlow(string address, string price, string name, string propertyDescription, string id, string nMin, string nMax, string successStatusCode, string notModifedStatusCode, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ETag Flow", exampleTags);
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given(string.Format("I create a new property ({0},{1},{2},{3},{4})", address, price, name, propertyDescription, id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.When(string.Format("I request to view properties with pagination (<page>,<pageSize>,<address>,<priceM" +
                        "in>,<priceMax>,{0})", id), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("the server should assign an Etag to the response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.And(string.Format("the system should return {0}", successStatusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("I request to view properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then(string.Format("the system should return {0}", notModifedStatusCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
