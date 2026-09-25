using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class BuffTower : Tower
    {
        public BuffTower(string nombre = "Torre Fuerte") : base(nombre, vida: 300, daño: 50)
        {
            Console.WriteLine($"{nombreTorre} --- (Vida: {VidaActual}, Daño: {daño}");
        }

        public override void Atacar(Entities enemigo)
        {
            if (VidaActual <= 0)
            {
                return;
            }

            if (enemigo != null)
            {
                Console.WriteLine($"{nombreTorre} lanza una bomba que causa {daño} de daño masivo");
                enemigo.RecibirDaño(daño);
            }
        }
    }
}
