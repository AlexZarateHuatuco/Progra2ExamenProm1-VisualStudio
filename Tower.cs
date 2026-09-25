using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class Tower : Entities
    {
        protected string nombreTorre;

        public Tower(string nombre, int vida, int daño) : base(vida, daño)
        {
            this.nombreTorre = nombre;
        }

        public virtual void Atacar(Entities enemigo)
        {
            if (VidaActual <= 0)
            {
                Console.WriteLine($"{nombreTorre} está destruida y no puede atacar a un enemigo causando {daño} de daño");
                enemigo.RecibirDaño(daño);
            }
        }

        public override void RecibirDaño(int cantidad)
        {
            if (cantidad <= 0)
            {
                return;
            }

            VidaActual -= cantidad;

            if (VidaActual <= 0)
            {
                VidaActual = 0;
                Console.WriteLine($"{nombreTorre} ha sido destruida");
            }
            else
            {
                Console.WriteLine($"{nombreTorre} recibió {cantidad} de daño. Vida restante: {VidaActual} || {VidaMaxima}");
            }
        }
    }
}
