using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2ExamenP1_VisualStudio
{
    internal class SmallTower : Tower
    {
        public SmallTower(string nombre = "Torre Pequeña") : base(nombre, vida: 100, daño: 15)
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
                Console.WriteLine($"{nombreTorre} dispara una flecha rápida causando {daño} de daño");
                enemigo.RecibirDaño(daño);
            }
        }
    }
}
