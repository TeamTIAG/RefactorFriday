using System;

namespace ExtractVariable
{
    public class ExtractVariableSmelly
    {
        public string SmellyPhoneNumber(string phoneNumber)
        {
            string phoneString = string.Join('-', 
                new[] { 
                    //Country Code
                    phoneNumber.Substring(0, 1),
                    //Area Code
                    phoneNumber.Substring(1, 3), 
                    //Prefix
                    phoneNumber.Substring(4, 3),  
                    //Line Number
                    phoneNumber.Substring(7, 4) });

            return phoneString;
        }
    }
}
