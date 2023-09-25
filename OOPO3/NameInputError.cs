using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class NameInputError : UserError
    {
        public override string UEMessage()
        {
            return "Use a real name wich does not contain numbers and other characters. this fired an error";
        }
    }
}
