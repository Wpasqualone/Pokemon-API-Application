using PokeAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_API_Application
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// This is a simple function to capitalize the first letter of a string
        /// </summary>
        /// <param name="words">The string you'd like to have the first letter of capitalized</param>
        /// <returns>A capitalized version of the string</returns>
        public string Capitalize(string words)
        {
            return words.Substring(0, 1).ToUpper() + words.Substring(1);
        }
        float happiness;
        float captureRate;
        string pokemonName;
        string flavorText;
        string habitat;
        string growthRate;
        string eggGroup;
        /// <summary>
        /// Gets a new pokemon species and sets the data to it's specifications
        /// </summary>
        /// <param name="pokedexNumber">Inputs the pokedex number of the desired pokemon</param>
        public async void GetPokemon(int pokedexNumber)
        {
            PokemonSpecies currentPokemon = await DataFetcher.GetApiObject<PokemonSpecies>(pokedexNumber);

            happiness = currentPokemon.BaseHappiness;
            captureRate = currentPokemon.CaptureRate;

            pokemonName = currentPokemon.Name;
            flavorText = currentPokemon.FlavorTexts[0].FlavorText;
            habitat = currentPokemon.Habitat.Name;
            growthRate = currentPokemon.GrowthRate.Name;
            eggGroup = currentPokemon.EggGroups[0].Name;

            pokemonName = Capitalize(pokemonName);
            habitat = Capitalize(habitat);
            eggGroup = Capitalize(eggGroup);
            growthRate = Capitalize(growthRate);    
        }

        /// <summary>
        /// Updates all the labels on the form with the proper Pokemon data
        /// </summary>
        private void UpdateLabels()
        {
            

            labelName.Text = "Name: " + pokemonName;
            labelHappy.Text = "Base happiness: " + happiness;
            labelCapture.Text = "Capture Rate: " + captureRate;
            labelHabitat.Text = "Habitat: " + habitat;
            labelGrowth.Text = "Growth Rate: " + growthRate;
            labelEgg.Text = "Egg Group: " + eggGroup;
            labelFlavor.Text = "Flavour Text: " + flavorText;
        }

        /// <summary>
        /// Updates the labels to have the info of Pokemon 1: Bulbasaur
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            GetPokemon(1);
            UpdateLabels();
        }

        /// <summary>
        /// When the generate pokemon button is clicked, it gets a new pokemon species and updates the labels accordingly. 
        /// </summary>
        private void btnNewPokemon_Click(object sender, EventArgs e)
        {
            GetPokemon(Int32.Parse(inputbox.Text));
            UpdateLabels();
        }
    }
}
