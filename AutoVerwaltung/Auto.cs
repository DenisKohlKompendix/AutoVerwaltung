using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AutoVerwaltung
{
    internal class Auto : Fahrzeug
    {
       
        public Auto(string hersteller, double geschwindigkeit,  double zuladung) : base(hersteller, geschwindigkeit, 5, zuladung, new LoggerFactory())
        {
            this.type = "Auto";



        }
    }
}
