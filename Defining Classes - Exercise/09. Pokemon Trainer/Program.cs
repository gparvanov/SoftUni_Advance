using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Dictionary<string,Trainers> trainers = new Dictionary<string,Trainers>();
            HashSet<string> trainersNames = new HashSet<string>();
            string command = Console.ReadLine();
            while (command != "Tournament")
            {
                string[] commandParts = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                if (commandParts.Length == 4 )
                {
                    string trainerName = commandParts[0];
                    string pokemonName = commandParts[1];
                    string pokemonElement = commandParts[2];
                    int pokemonHealth = int.Parse(commandParts[3]);

                    if (!trainersNames.Contains(trainerName))
                    {
                        List<Pokemon> pokemonList = new List<Pokemon>();
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                        pokemonList.Add(pokemon);
                        Trainers trainer = new Trainers(trainerName, 0, pokemonList);
                        trainers[trainerName] = trainer;
                        trainersNames.Add(trainerName);
                    }
                    else
                    {
                        Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                        trainers[trainerName].Pokemon.Add(pokemon);
                    }
                }
                command = Console.ReadLine();
            }
            command = Console.ReadLine();
            while(command != "End")
            {
                if (command == "Fire" || command == "Water" || command == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        var currentTrainer = trainer.Value;
                        string trainerName = currentTrainer.Name;
                        var PokemonList = currentTrainer.Pokemon;
                        bool found = false;
                        for (int i = 0; i < PokemonList.Count; i++)
                        {
                            var currentPokemon = PokemonList[i];
                            if (currentPokemon.Element == command)
                            {
                                found = true;
                                trainers[trainerName].Badges++;
                                break;
                            }
                        }
                        if (!found)
                        {
                            for (int i = 0; i < PokemonList.Count; i++)
                            {
                                var currentPokemon = PokemonList[i];
                                int health = currentPokemon.Health;
                                if (health - 10 > 0) trainers[trainerName].Pokemon[i].Health -= 10;
                                else trainers[trainerName].Pokemon.RemoveAt(i);                                
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            var result = trainers.OrderByDescending(x => x.Value.Badges);

            foreach (var trainer in result)
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.Badges} {trainer.Value.Pokemon.Count}");
            }
        }
    }
}
