using System.Reflection.Metadata.Ecma335;

namespace yzaoui_nasa
{
    public class Estimed_diametres
    {
        private Dictionnaire<Dictionnaire<string>?>? unite;
        
        private Dictionnaire<string>? value(string min, string max)
        {
            Dictionnaire<string> dico = new Dictionnaire<string>();
            dico.Ajouter("estimated_diameter_min", min);
            dico.Ajouter("estimated_diameter_max", max);
            return dico; 
        }
        public Estimed_diametres(string minK, string maxK, string minM, string maxM, string minMi, string maxMi, string minF, string maxF)
        {
            this.unite = new Dictionnaire<Dictionnaire<string>?>();
            this.unite.Ajouter("kilometers", value(minK, maxK));
            this.unite.Ajouter("meters", value(minM, maxM));
            this.unite.Ajouter("miles", value(minMi, maxMi));
            this.unite.Ajouter("feet", value(minF, maxF));
        }
        public Dictionnaire<Dictionnaire<string>?>?  getUnite()
        {
            return this.unite;
        }
    }
}