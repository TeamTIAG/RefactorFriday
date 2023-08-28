using System;
using System.Collections.Generic;
using System.Text;

namespace ExtractVariable
{
    class ExtractVariableRefactored
    {
        public string RefactoredPhoneNumber(string phoneNumber)
        {
            string countryCode = phoneNumber.Substring(0, 1);
            string areaCode = phoneNumber.Substring(1, 3);
            string prefix = phoneNumber.Substring(4, 3);
            string lineNumber = phoneNumber.Substring(7, 4);
            string phoneString = string.Join('-',
                new[] { countryCode, areaCode, prefix, lineNumber });

            return phoneString;
        }
    }
}
