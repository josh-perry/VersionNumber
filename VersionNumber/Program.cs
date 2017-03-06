using System;
using System.IO;
using VersionNumber.Models;

namespace VersionNumber
{
    class Program
    {
        /// <summary>
        /// File path to load and save the version number to
        /// </summary>
        private static string _versionFile = "ProgramInfo.cs";

        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">Arguments passed in</param>
        static void Main(string[] args)
        {
            // If the version file isn't present at all, just return early
            if (!IsVersionFilePresent())
                return;

            // Get version object parsed from file
            var version = GetVersion();
            
            Console.WriteLine("Current version: " + version);

            // Try to increment the version, if it remains the same then just quit
            if (!IncrementVersion(version, args))
                return;

            Console.WriteLine("Updated version: " + version);

            // Write new value to file
            WriteVersionToFile(version);
        }

        /// <summary>
        /// Writes the current version value to file
        /// </summary>
        /// <param name="version">The version object to write</param>
        private static void WriteVersionToFile(Models.Version version)
        {
            File.WriteAllText(_versionFile, version.ToString());
        }

        /// <summary>
        /// Parse the arguments passed in from command line + act on them.
        /// Only operates on the first argument found.
        /// Increments the major version if the arg is 'bug'
        /// Increments the minor version if the arg is 'feature'
        /// </summary>
        /// <param name="version">Version object to operate on</param>
        /// <param name="args">String list of parameters</param>
        /// <returns>True if the version was changed, false otherwise</returns>
        private static bool IncrementVersion(Models.Version version, string[] args)
        {
            // If there aren't any args to begin with, print a nice message and quit
            if (args.Length == 0)
            {
                Console.WriteLine("Provide an incrementation type as a parameter!");
                Console.WriteLine("Acceptable values: bug, feature");
                return false;
            }

            // Iterate arg and work with the first acceptable argument
            foreach (var arg in args)
            {
                if (arg.ToLower() == "feature")
                {
                    version.IncrementMajor();
                    return true;
                }
                if (arg.ToLower() == "bug")
                {
                    version.IncrementMinor();
                    return true;
                }
            }

            // No relevant arguments found, version is unchanged
            return false;
        }

        /// <summary>
        /// Is the version file there?
        /// </summary>
        /// <returns>True if the file is found, false and a message otherwise</returns>
        private static bool IsVersionFilePresent()
        {
            if (File.Exists(_versionFile))
                return true;

            Console.WriteLine($"File doesn't exist: {_versionFile}");
            return false;
        }

        /// <summary>
        /// Gets a version object from file
        /// </summary>
        /// <returns>The version object</returns>
        private static Models.Version GetVersion()
        {
            var ver = new Models.Version();

            try
            {
                // Read all the text and attempt to parse it
                var content = File.ReadAllText(_versionFile);
                ver.Parse(content);
            }
            catch (NotEnoughVersionPartsException ex)
            {
                // Not enough 'parts' in the version string.
                // i.e. 1.1.1 instead of 1.1.1.1
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }
            catch (Exception ex)
            {
                // Other generic exceptions, just quit
                Console.WriteLine(ex.Message);
                Environment.Exit(-1);
            }

            return ver;
        }
    }
}
