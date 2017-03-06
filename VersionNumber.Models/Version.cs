using System;

namespace VersionNumber.Models
{
    public class Version
    {
        /// <summary>
        /// Major version number
        ///     0.0.1.2
        ///         ^ This one
        /// </summary>
        public int Major { get; set; }

        /// <summary>
        /// Minor version number
        ///     0.0.1.2
        ///           ^ This one
        /// </summary>
        public int Minor { get; set; }

        /// <summary>
        /// Parse the specified string and set the major/minor versions appropriately
        /// </summary>
        /// <param name="version">The string to parse</param>
        public void Parse(string version)
        {
            var split = version.Split('.');
            
            // How many numbers are there?
            if (split.Length - 1 < 3)
            {
                throw new NotEnoughVersionPartsException();
            }
            
            // If there are 4 parts
            Major = int.Parse(split[2]);
            Minor = int.Parse(split[3]);
        }

        /// <summary>
        /// Add 1 to the minor version number
        /// </summary>
        public void IncrementMinor()
        {
            Minor += 1;
        }

        /// <summary>
        /// Add 1 to the major version, reset the minor version
        /// </summary>
        public void IncrementMajor()
        {
            Major += 1;
            Minor = 0;
        }
        
        /// <summary>
        /// Get a string representation of the version.
        /// Used to write it to file.
        /// </summary>
        /// <returns>The version in format: 0.0.1.2</returns>
        public override string ToString()
        {
            return $"0.0.{Major}.{Minor}";
        }
    }
}
