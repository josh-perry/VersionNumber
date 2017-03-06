using System;

namespace VersionNumber.Models
{
    public class Version
    {
        public int Major { get; set; }
        public int Minor { get; set; }

        public void Parse(string version)
        {
            var split = version.Split('.');
            
            // How many numbers are there?
            if (split.Length - 1 < 3)
            {
                throw new Exception($"Not enough parts in version number: '{version}'!");
            }
            
            // If there are 4 parts
            Major = int.Parse(split[2]);
            Minor = int.Parse(split[3]);
        }

        public void IncrementMinor()
        {
            Minor += 1;
        }

        public void IncrementMajor()
        {
            Major += 1;
            Minor = 0;
        }

        public override string ToString()
        {
            return $"0.0.{Major}.{Minor}";
        }
    }
}
