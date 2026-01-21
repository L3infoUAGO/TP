using System;

namespace ProjetASPNET.Models
{
    // Amani Habiyambere Isaac
    public class Localisation
    {

        public int IdPosition { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Timestamp { get; set; }


        public Localisation(int id, double latitude, double longitude, DateTime timestamp)
        {
            IdPosition = id;
            Latitude = latitude;
            Longitude = longitude;
            Timestamp = timestamp;
        }

    }
}
