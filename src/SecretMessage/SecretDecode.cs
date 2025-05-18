using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class SecretDecode : SecretMessage
    {
        public SecretDecode(string key, string secretLine) : base(key, secretLine, "unknown")
        {
        }

        public string Decode()
        {
            string messageString = string.Empty;
            for (int i = 0; i < SecretLine.Length; i++)
            {
                int num = CharacterConverter(SecretLine[i]) - CharacterConverter(Key[i]);
                if (num < 0)
                {
                    messageString += IntConverter((27 + num));
                }
                else messageString += IntConverter(num);
            }
            return messageString;
        }
    }
}
