using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class SecretMessage
    {
            protected string key;
            protected string secretLine;
            protected string message;

            public SecretMessage(string key, string secretLine, string message)
            {
                Key = key;
                SecretLine = secretLine;
                Message = message;
            }

            public string Key
            {
                get => key;
                set
                {
                    foreach (char c in value)
                    {
                        if (!(c >= 'a' && c <= 'z' || c == ' '))
                        {
                            throw new SecretMessage_Exception("");
                        }
                    }
                    key = value.ToLower();
                }
            }

            public string SecretLine
            {
                get => secretLine;
                set
                {
                    foreach (char c in value)
                    {
                        if (!(c >= 'a' && c <= 'z' || c == ' '))
                        {
                            throw new SecretMessage_Exception("");
                        }
                    }
                    secretLine = value.ToLower();
                }
            }

            public string Message
            {
                get => message;
                set
                {

                    foreach (char c in value)
                    {
                        if (!(c >= 'a' && c <= 'z' || c == ' '))
                        {
                            throw new SecretMessage_Exception("");
                        }
                    }
                    message = value.ToLower();
                }
            }

            public static int CharacterConverter(char a)
            {
                if (a == ' ') return 26;
                else return a - 97;
            }

            public static char IntConverter(int a)
            {
                if (a == 26) return ' ';
                else return Convert.ToChar(a + 97);
            }

    }
}

