﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace VersionNumber.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Increment Major Version Number")]
    public partial class IncrementMajorVersionNumberFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "IncrementMajorVersion.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Increment Major Version Number", "    Increment major version number, resetting minor version to 0", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Increment minor version")]
        [NUnit.Framework.TestCaseAttribute("1", "0", "1", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("1", "1", "2", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("2", "2", "3", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("3", "3", "4", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("20", "21", "22", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("120", "121", "122", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("220", "221", "222", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("320", "321", "322", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("420", "421", "422", "0", new string[0])]
        [NUnit.Framework.TestCaseAttribute("520", "521", "522", "0", new string[0])]
        public virtual void IncrementMinorVersion(string currentminor, string currentmajor, string newmajor, string newminor, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Increment minor version", exampleTags);
#line 4
this.ScenarioSetup(scenarioInfo);
#line 5
    testRunner.Given(string.Format("The current minor version is {0}", currentminor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.Given(string.Format("The current major version is {0}", currentmajor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.When("Major version is incremented", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 8
    testRunner.Then(string.Format("The minor version should be {0}", newminor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And(string.Format("The major version should be {0}", newmajor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
