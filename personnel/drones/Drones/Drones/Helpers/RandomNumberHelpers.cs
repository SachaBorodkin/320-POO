using Drones.Helpers;
using Drones;
namespace Drones.Helpers
{
    // Outils pour écrire du texte dans un environnement graphique
    public static class RandomNumberHelper
    {
        private static readonly Random _random = new Random();
        public static int Get(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }

}