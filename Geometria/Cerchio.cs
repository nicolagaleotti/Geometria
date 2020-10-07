using System;
using System.Collections.Generic;
using System.Text;

namespace Geometria
{
    class Cerchio
    {
        public const double PI = 3.14;
        private double raggio;

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }

        public double CalcolaCirconferenza()
        {
            return 2 * PI * raggio;
        }

        public double CalcolaArea()
        {
            return raggio * raggio * PI;
        }

        public void CambiaRaggio(double newRaggio)
        {
            if (newRaggio > 0)
                this.raggio = newRaggio;
            else throw new Exception("Raggio non valido");
        }

        public double DammiRaggio()
        {
            return raggio;
        }
    }
}
