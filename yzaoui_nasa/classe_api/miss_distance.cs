namespace yzaoui_nasa
{
    public class Miss_distance
    {
        private string astronomical;
        private string lunar;
        private string kilometers;
        private string miles;
        public Miss_distance(string astronomical, string lunar, string kilometers, string miles)
        {
            this.astronomical = astronomical;
            this.lunar = lunar;
            this.kilometers = kilometers;
            this.miles = miles;
        }
        public string Getastronomical() { return astronomical; }
        public string Getlunar() { return lunar; }
        public string Getkilometers() { return kilometers; }
        public string Getmiles() { return miles; }
    }
}