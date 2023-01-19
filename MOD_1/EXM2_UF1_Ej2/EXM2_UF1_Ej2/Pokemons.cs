using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamiliasPokemons
{
    class Pokemon   
    {
    }

    class PokemonAgua : Pokemon
    {
        private string AtaqueBasico;

        public void EjecutarAtaque() {

            Console.WriteLine("Ataque Agua Lanzado");
        }
    }

    class PokemonAguaDulce : PokemonAgua
    {
        private string AtaqueBasico;

        public new void EjecutarAtaque()
        {

            Console.WriteLine("Ataque Agua Dulce Lanzado");
        }

        public void Atacar()
        {
            base.EjecutarAtaque();
            EjecutarAtaque();
        }
    }
}
