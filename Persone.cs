using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Persone
{
    public string Name { get; set; }         // Властивість Ім'я
    public int Stag_Rob { get; set; }        // Властивість Стаж Роботи

    public Persone(string name, int stag_rob)
    {
        Name = name;
        Stag_Rob = stag_rob;
    }
}
