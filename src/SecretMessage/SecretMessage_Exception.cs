using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class SecretMessage_Exception : Exception
    {
        public SecretMessage_Exception(string? message) : base(message)
        {
        }
    }
}
