using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Ballon
{
    // USHINDI BATEYE JORDAN

    public string Couleur { get; set; }
    public double Taille { get; set; } // diamètre en cm
    public bool EstGonfle { get; private set; }


    public Ballon(string couleur, double taille)
    {
        Couleur = couleur;
        Taille = taille;
        EstGonfle = false;
    }

}