using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Steel : Material
    {
        internal override string MaterialConstructionFirstStep()
        {
            return "Start building structure";
        }
    }
}
