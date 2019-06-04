using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDBFirst
{
    public partial class Estudiante
    {
        public override string ToString()
        {
            return $"{Id}, {Nombre}";
        }
    }
}
