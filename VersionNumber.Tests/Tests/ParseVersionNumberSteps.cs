using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using VersionNumber.Models;

namespace VersionNumber.Tests
{
    [Binding, Scope(Feature = "Parse Version Number")]
    public class ParseVersionNumberSteps
    {
        private readonly Models.Version _version = new Models.Version();

        private string _versionToParse = String.Empty;

        [Given(@"Version number to be parsed is ""(.*)""")]
        public void GivenVersionNumberToBeParsedIs(string parseVersion)
        {
            _versionToParse = parseVersion;
        }
        
        [When(@"It is parsed")]
        public void WhenItIsParsed()
        {
            _version.Parse(_versionToParse);
        }
        
        [Then(@"The major version should be (.*)")]
        public void ThenTheMajorVersionShouldBe(int major)
        {
            Assert.AreEqual(_version.Major, major);
        }
        
        [Then(@"The minor version should be (.*)")]
        public void ThenTheMinorVersionShouldBe(int minor)
        {
            Assert.AreEqual(_version.Minor, minor);
        }
    }
}
