using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    using System;

    [AttributeUsage(AttributeTargets.Property)]
    public class ExibirAttribute : Attribute
    {
    }

}
