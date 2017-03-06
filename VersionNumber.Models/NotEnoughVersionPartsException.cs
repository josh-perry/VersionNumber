using System;

namespace VersionNumber.Models
{
    public class NotEnoughVersionPartsException : Exception
    {
        public override string ToString()
        {
            return "Not enough parts in version number!";
        }
    }
}
