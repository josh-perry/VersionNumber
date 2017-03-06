using NUnit.Framework;
using TechTalk.SpecFlow;

namespace VersionNumber.Tests
{
    [Binding, Scope(Feature = "Increment Minor Version Number")]
    public class IncrementMinorVersionNumberSteps
    {
        private readonly Models.Version _version = new Models.Version();
        
        [Given(@"The current minor version is (.*)")]
        public void GivenTheCurrentMinorVersionIs(int minor)
        {
            _version.Minor = minor;
        }
        
        [Given(@"The current major version is (.*)")]
        public void GivenTheCurrentMajorVersionIs(int major)
        {
            _version.Major = major;
        }

        [When(@"Minor version is incremented")]
        public void WhenMinorVersionIsIncremented()
        {
            _version.IncrementMinor();
        }

        [Then(@"The minor version should be (.*)")]
        public void ThenTheMinorVersionShouldBe(int minor)
        {
            Assert.AreEqual(_version.Minor, minor);
        }

        [Then(@"The major version should be (.*)")]
        public void ThenTheMajorVersionShouldBe(int major)
        {
            Assert.AreEqual(_version.Major, major);
        }
    }
}
