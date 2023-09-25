using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPO3
{
    internal class DistanceInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried miles instead of kilometres";
        }
    }
}
