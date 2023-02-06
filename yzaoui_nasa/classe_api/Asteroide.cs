namespace yzaoui_nasa
{
    public class Asteroide
    {
        private Link link;
        private string id;
        private string neo_reference_id;
        private string name;
        private string nasa_jpl_url;
        private string absolute_magnitude_h;
        private Estimed_diametres estimed_diametre;
        private bool is_potentially_hazardous_asteroid;
        private Close_approach_data[] close_approach_datas;
        private bool is_sentry_object;

        public Asteroide(Link link, string id, string neo_reference_id, string name, string nasa_jpl_url, string absolute_magnitude_h, Estimed_diametres estimed_diametre, bool is_potentially_hazardous_asteroid, Close_approach_data[] close_approach_datas, bool is_sentry_object)
        {
            this.link = link;
            this.id = id;
            this.neo_reference_id = neo_reference_id;
            this.name = name;
            this.nasa_jpl_url = nasa_jpl_url;
            this.absolute_magnitude_h = absolute_magnitude_h;
            this.estimed_diametre = estimed_diametre;
            this.is_potentially_hazardous_asteroid = is_potentially_hazardous_asteroid;
            this.close_approach_datas = close_approach_datas;
            this.is_sentry_object = is_sentry_object;
        }

        public Link GetLink() => this.link;
        public string GetId() => this.id;
        public string GetNeoReferenceId() => this.neo_reference_id;
        public string GetName() => this.name;
        public string GetNasaJplUrl() => this.nasa_jpl_url;
        public string GetAbsoluteMagnitudeH() => this.absolute_magnitude_h;
        public Estimed_diametres GetEstimedDiametre() => this.estimed_diametre;
        public bool GetIsPotentiallyHazardousAsteroid() => this.is_potentially_hazardous_asteroid;
        public Close_approach_data[] GetCloseApproachDatas() => this.close_approach_datas;
        public bool GetIsSentryObject() => this.is_sentry_object;
    }
}