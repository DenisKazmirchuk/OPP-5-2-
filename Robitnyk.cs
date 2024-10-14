using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Robitnyk : Persone, IZarplata, IRole
{
    private double _hourlyRate;

    public Robitnyk(string name, int stag_rob, double hourlyRate)
        : base(name, stag_rob)
    {
        _hourlyRate = hourlyRate;
    }

    // Реалізація методу Zarplata з інтерфейсу IZarplata
    public double Zarplata()
    {
        return _hourlyRate * 160;  // Припустимо, що 160 годин на місяць
    }

    // Реалізація методу Role з інтерфейсу IRole
    public string Role()
    {
        return "Робітник";
    }
}
