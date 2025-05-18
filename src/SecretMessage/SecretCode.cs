using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class SecretCode : SecretMessage
    {
        public SecretCode(string message, string key) : base(key, "unknown", message)
        {
        }

        public string CreateSecreteMessage()
        {
            string secretString = string.Empty;
            for (int i = 0; i < Message.Length; i++)
            {
                int x = CharacterConverter(Message[i]) + CharacterConverter(Key[i]);
                if (x < 26) { secretString += IntConverter(x); }
                else { secretString += IntConverter(x % 27); }
            }
            return secretString;
        }
    }
}
