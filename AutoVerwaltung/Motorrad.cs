using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung
{
    internal class Motorrad : Fahrzeug
    {
        
        public Motorrad(string hersteller, double geschwindigkeit) : base(hersteller, geschwindigkeit, 2, 0, new LoggerFactory())
        {
           
           this.type = "Motorrad";
        }
    }
}
