using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung
{
    internal class LKW : Fahrzeug
    {
        public LKW(string hersteller, double geschwindigkeit, int sitze, double zuladung) : base(hersteller, geschwindigkeit, sitze, zuladung, new LoggerFactory())
        {
            if (zuladung < 3000) {
                throw new Exception("Zuladung ist fü eine LKW zu klein");
            }
            this.type = "LKW";
        }
    }
}
