using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung
{
    internal class Buchung
    {
        List<Vergabe> vergabeList = new List<Vergabe>();
        int id = 0;
        StreamWriter sw;
        public Buchung() {
            string path = @"d:\daten\Fahrzeug.log";
            if (!File.Exists(path))
            {
                sw = File.CreateText(path); // erstellen der neuen Datei 
            }
            else {
                sw = File.AppendText(path); // Open der bestehende Datei
            }
            
        }
        public int ausleihe(string nutzer, Fahrzeug fahrzeug) {
            id++;
            vergabeList.Add(new Vergabe(id,nutzer, fahrzeug));
            return id;
        }

        public void rueckgabe(int id) {
            String log = "";
            for (int index = 0; index < vergabeList.Count; index++){
                if (vergabeList[index].id == id) {
                    log = String.Format("Datum der Rückgabe {0} Nutzer: {1} vergeben am {2} fahrzeug {3} ", DateTime.Now.ToString("f"), vergabeList[index].fahrer, vergabeList[index].datum.ToString("F"), vergabeList[index].fahrzeuge.toString() );
                    sw.WriteLine(log);
                    sw.Flush();
                }
            }
        }
        public void dumpStatus() {
            foreach (Vergabe v in vergabeList) {
                /*
                 * Das gibt mir den status der verleihe aus.
                 */
                Console.WriteLine(String.Format("Nutzer: {0} Fahrzeug: {1}", v.fahrer, v.fahrzeuge.toString()));
            }
        
        }
    }
}
