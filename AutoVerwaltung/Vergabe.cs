using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoVerwaltung
{
    internal class Vergabe
    {
        public String fahrer { get; }
        public Fahrzeug fahrzeuge { get; }
        public DateTime datum { get; }
        public int id { get; }
        public Vergabe(int id,string fahrer, Fahrzeug fahrzeuge)
        {
            this.id = id;
            this.fahrer = fahrer;
            this.fahrzeuge = fahrzeuge;
            this.datum = DateTime.Now;
        }   
    }
}

/*
 * Block 3
 * 
 * Vergabe von Fahrzeugen soll verwaltete werden 
 * 
 * Die Klasse Buchung enthält eine Liste der Vergaben 
 * und die Methoden 
 * Ausleihe
 * Rückgabe 
 * 
 * Wichtig: Rückgabe soll in sine Datei Schreiben 
 * 
 */