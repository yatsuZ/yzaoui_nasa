namespace yzaoui_nasa
{
    public class Link 
    {
        private Dictionnaire<string> all_link;

        public Link(params string[] arguments)
        {
            all_link = new Dictionnaire<string>();
            if (arguments.Length == 3)
            {
                all_link.Ajouter("next", arguments[0]);
                all_link.Ajouter("previous", arguments[1]);
                all_link.Ajouter("self", arguments[2]);
            }
            else if (arguments.Length == 1)
                all_link.Ajouter("self", arguments[0]);
        }

        public Dictionnaire<string> GetAllLink()
        {
            return all_link;
        }
    }
}