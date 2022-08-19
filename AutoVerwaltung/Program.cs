/*
 * 
 * Aufgabe ist es eine Software zu erstellen die es erlaubt die Fahrzeuge eines Fuhrparks zu verwalten
 * Die Aufgabe teilt sich in 3 Blöcke:
 * 
 * 1. Block
 * 
 * Daten Modell 
 * 
 * Fahrzeuge werden nach Typen verwaltet 
 * a: Auto
 * b: LKW
 * c: Motorad 
 * 
 * Jeder type soll seine spezifischen Eigenschaten im Daten Type mitbringen 
 * 
 * Methoden:
 * Fahren -> Stecke / max Geschwindigkeit
 */

/*
 * 
 * Brain Storming
 * 
 * Frage: Welches Progammier technisch konstrukt benutzen wir um die Typen der Fahr zeuge auszudrücken?
 * Vaterklasse Fahrzeug vererbt an die Kindklassen Auto, LKW, Motorad
 * 
 * Attribute:
 * Name des Typs
 * Hersteller
 * geschwindigkeit
 * sitzplätze 
 * zuladung
 */

using AutoVerwaltung;


Auto a1 = new Auto("VW", 160, 850);
Console.WriteLine("der VW fahrt 100km in" + a1.fahren(100) + " Stunden");
Console.WriteLine(a1.toString());

/*
 * Block 2:
 * 
 * Ziel wir woll alle Type von Fahrzeugen an einerstelle im Programm verwalten.
 * 1. Welche Datenstucktur kann hier sinnvoll sein?
 * 2. Wie kann man die Methoden addFahrzeug und deleteFahrzeug implementieren?
 * 
 */

List<Fahrzeug> flist = new List<Fahrzeug>();
try
{
    flist.Add(a1);
    flist.Add(new LKW("Mercedes", 85, 2, 7500));
    flist.Add(new LKW("FIAT", 85, 4, 3500));
    flist.Add(new Motorrad("BMW", 230));
}
catch (Exception e) {
    Console.WriteLine(e.Message);
}
foreach (Fahrzeug f in flist) {
    Console.WriteLine(f.toString() + "  :: " + f.ToString() + "  ::  " + f.GetType());
}

Buchung buchung = new Buchung();
int b1 =  buchung.ausleihe("Peter", flist[0]);

int b2 = buchung.ausleihe("Ute Guttes", flist[1]);
buchung.dumpStatus();
buchung.rueckgabe(b2);




