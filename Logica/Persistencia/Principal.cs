using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public sealed class Principal
    {
        private static Principal principal;

        private Principal() { }

        public static Principal Instancia
        {
            get
            {
                //ME PODES EXPLICAR QUE HICISTE ACA? xd
                if (principal == null)
                {
                    principal = new Principal();
                }
                return principal;
            }
        }
    }
}
