using System;
using System.Collections.Generic;

// Habimana Sebatware Joseph
public class Gymn
{
    
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public int Capacite { get; set; }
    public List<string> Membres { get; set; }

    
    public Gymn(string nom, string adresse, int capacite)
    {
        Nom = nom;
        Adresse = adresse;
        Capacite = capacite;
        Membres = new List<string>();
    }
}
