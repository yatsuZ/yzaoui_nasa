using System.Collections.Generic;
namespace yzaoui_nasa
{
    public class Dictionnaire<T>
    {
        private int nbr_of_element = 0;
        public Dictionary<string, T> dict = new Dictionary<string, T>();

        public void Ajouter(string cle, T valeur)
        {
            nbr_of_element++;
            dict[cle] = valeur;
        }

        public T? Obtenir(string cle)
        {
            T? valeur;
            bool r = dict.TryGetValue(cle, out valeur);
            if (!r)
                Console.WriteLine("Error cette cle n existe pas.");
            return valeur;
        }

        public Dictionary<string, T> GetDict() 
        {
            return (dict);
        }
        public List<string> ObtenirCle()
        {
            return new List<string>(dict.Keys);
        }
        public int GetNbrOfElement() => this.nbr_of_element;
    }
}