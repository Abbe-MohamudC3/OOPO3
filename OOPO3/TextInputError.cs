using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only feild. this fired an error";
        }
    }
}
