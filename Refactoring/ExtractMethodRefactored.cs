using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring
{
    class ExtractMethodRefactored
    {
        public string ComposeAddressRefactored(string name, string address, string state, string city, string zip, int workPhone, int homePhone)
        {
            var builder = new StringBuilder();

            builder.AppendLine(name);
            builder.AppendLine(address);
            builder.Append(city).Append(", ");
            builder.Append(state).Append(", ");
            builder.AppendLine(zip);

            string workNumber = formatPhoneNumber(workPhone);
            string homeNumber = formatPhoneNumber(homePhone);

            builder.Append("Work Phone: ").AppendLine(workNumber);
            builder.Append("Home Phone: ").AppendLine(homeNumber);

            return builder.ToString();
        }

        private static string formatPhoneNumber(int phoneNumber)
        {
            var asString = phoneNumber.ToString();
            var countryCode = asString.Substring(0, 1);
            var areaCode = asString.Substring(1, 3);
            var prefix = asString.Substring(4, 3);
            var lineNumber = asString.Substring(7, 4);
            string phoneString = string.Join('-', new[] { countryCode, areaCode, prefix, lineNumber });

            return phoneString;
        }
    }
}
