using System;
using FamiliasPokemons;

namespace EXM2_UF1_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            PokemonAgua MiPokemon1 = new PokemonAgua();
            PokemonAguaDulce MiPokemon2 = new PokemonAguaDulce();

            MiPokemon1.EjecutarAtaque();
            MiPokemon2.EjecutarAtaque();
            MiPokemon2.Atacar();

        }
    }
}
