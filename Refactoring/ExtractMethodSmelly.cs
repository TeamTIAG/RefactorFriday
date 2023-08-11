using System;
using System.Text;

namespace Refactoring
{
    public class ExtractMethodSmelly
    {
        public string ComposeAddress(string name, string address, string state, string city, string zip, int workPhone, int homePhone)
        {
            var builder = new StringBuilder();

            builder.AppendLine(name);
            builder.AppendLine(address);
            builder.Append(city).Append(", ");
            builder.Append(state).Append(", ");
            builder.AppendLine(zip);

            var workString = workPhone.ToString();
            var countryCode = workString.Substring(0, 1);
            var areaCode = workString.Substring(1, 3);
            var prefix = workString.Substring(4, 3);
            var lineNumber = workString.Substring(7, 4);

            var homeString = homePhone.ToString();
            var homeCountryCode = homeString.Substring(0, 1);
            var homeAreaCode = homeString.Substring(1, 3);
            var homePrefix = homeString.Substring(4, 3);
            var homeLineNumber = homeString.Substring(7, 4);

            builder.Append("Work Phone: ").AppendJoin('-', new[] { countryCode, areaCode, prefix, lineNumber });
            builder.Append("Home Phone: ").AppendJoin('-', new[] { homeCountryCode, homeAreaCode, homePrefix, homeLineNumber });

            return builder.ToString();
        }
    }
}
