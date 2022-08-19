using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Extensions.Logging;

namespace AutoVerwaltung
{
    internal class Fahrzeug
    {

        public String type{ get; set; }
        string hersteller;
        double geschwindigkeit;
        int sitze;
        double zuladung;
        private ILogger _logger;
        public Fahrzeug(string hersteller, double geschwindigkeit, int sitze, double zuladung, ILogger loggerFactory)
        {
            this.hersteller = hersteller;
            this.geschwindigkeit = geschwindigkeit;
            this.sitze = sitze;
            this.zuladung = zuladung;
            this.type = "Fahrzeug";
            _logger = loggerFactory;
            _logger.LogInformation("Neue Instanz wurde erstellt.");
            _logger.LogError("Test aus Fahrzeug");
        }

        public Fahrzeug(string hersteller, double geschwindigkeit, int v, double zuladung, LoggerFactory loggerFactory)
        {
            this.hersteller = hersteller;
            this.geschwindigkeit = geschwindigkeit;
            this.zuladung = zuladung;
        }

        public double fahren(double strecke) {
            return strecke / geschwindigkeit;
        }

        public string toString() {
            return string.Format("Type: {0} Hersteller: {1} Geschwindikeit: {2} Sitze: {3} Zuladung:  {4}", type, hersteller, geschwindigkeit, sitze, zuladung);
        }
        public String getType() {
            return this.type;
        }

        public String setType(string type)
        {
            return this.type;
        }
    }
}
