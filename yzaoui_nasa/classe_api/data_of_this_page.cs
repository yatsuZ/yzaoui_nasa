namespace yzaoui_nasa
{
    public class Data_this_page
    {
        private Link links;
        private int element_count;
        private Dictionnaire<Asteroide[]>? date_of_all_analyse;

        public Data_this_page(Link links, int element_count, Dictionnaire<Asteroide[]>? date_of_all_analyse)
        {
            this.links = links;
            this.element_count = element_count;
            this.date_of_all_analyse = date_of_all_analyse;
        }

        public Link? GetLink() => this.links;
        public int GetElementCount() => this.element_count;
        public Dictionnaire<Asteroide[]>? GetDateOfAllAnalyse() => this.date_of_all_analyse;

        private void Affichage_Link()
        {
            Console.WriteLine("---------------------\n"+"Link : ");
            Console.WriteLine("\tnext = "+this.links.GetAllLink().Obtenir("next"));
            Console.WriteLine("\tprevious = "+this.links.GetAllLink().Obtenir("previous"));
            Console.WriteLine("\tself = "+this.links.GetAllLink().Obtenir("self"));
        }
        private void Affichage_des_dictionaires()
        {
            Console.WriteLine("---------------------\n"+"date_of_all_analyse : ");
            Console.WriteLine("voila toute les key");
            if (this.date_of_all_analyse == null)
            {
                Console.WriteLine("---------------------\n"+"Error dictionainre VIDE!!!");
                return;
            }
            foreach (string s in this.date_of_all_analyse.ObtenirCle())
                Console.WriteLine("\tKey : "+s);
        }
        public void Affichage_des_infos(int show_inside)
        {
            string affichage_debut = "affichage des infos de Data_this_page.";
            if (show_inside > 0)
                affichage_debut += " Et de son contenue";
            Console.WriteLine(affichage_debut);
            this.Affichage_Link();
            Console.WriteLine("---------------------\nelement_count = "+this.element_count.ToString());
            if (this.date_of_all_analyse == null)
            {
                Console.WriteLine("---------------------\n"+"2Error dictionainre VIDE!!!");
                return;
            }
            if (show_inside > 0)
                this.Affichage_des_dictionaires();
            else
                Console.WriteLine("---------------------\n"+this.date_of_all_analyse.GetNbrOfElement());
        }
    }
}