using System.Net.Http.Headers;
namespace yzaoui_nasa
{

    //Classe NasaAPI
    //c'est ici ou je crerair tout et manipulerais tout.
    class NasaAPI
    {
        private readonly string apiKey;//api key est une constante

        public NasaAPI(string key)
        {
            this.apiKey = key;
        }
        private Link getLink(System.Text.Json.JsonDocument data)
        {
            var jsonLink = data.RootElement.GetProperty("links");
            string next = jsonLink.GetProperty("next").ToString();
            string previous = jsonLink.GetProperty("previous").ToString();
            string self = jsonLink.GetProperty("self").ToString();
            // Console.WriteLine("NEXT = "+next);
            // Console.WriteLine("PREVIOUS = "+previous);
            // Console.WriteLine("SELF = "+self);
            Link links = new Link(next, previous, self);
            return (links);
        }

        private Estimed_diametres GetEstimed_Diametres(System.Text.Json.JsonElement data)
        {
            string minK = data.GetProperty("kilometers").GetProperty("estimated_diameter_min").ToString();
            string maxK = data.GetProperty("kilometers").GetProperty("estimated_diameter_max").ToString();
            string minM = data.GetProperty("meters").GetProperty("estimated_diameter_min").ToString();
            string maxM = data.GetProperty("meters").GetProperty("estimated_diameter_max").ToString();
            string minMi =data.GetProperty("miles").GetProperty("estimated_diameter_min").ToString();
            string maxMi =data.GetProperty("miles").GetProperty("estimated_diameter_max").ToString();
            string minF = data.GetProperty("feet").GetProperty("estimated_diameter_min").ToString();
            string maxF = data.GetProperty("feet").GetProperty("estimated_diameter_max").ToString();
            Estimed_diametres diametres = new Estimed_diametres(minK, maxK, minM, maxM, minMi, maxMi, minF, maxF);
            return diametres;
        }
        private Close_approach_data GetCloseApproachData(System.Text.Json.JsonElement data)
        {
            string close_approach_date = data.GetProperty("close_approach_date").ToString();
            string close_approach_date_full = data.GetProperty("close_approach_date_full").ToString();
            /////////////////////////////////////////
            long epoch_date_close_approach = Convert.ToInt64(data.GetProperty("epoch_date_close_approach").ToString());
            string kms = data.GetProperty("relative_velocity").GetProperty("kilometers_per_second").ToString();
            string kmh = data.GetProperty("relative_velocity").GetProperty("kilometers_per_hour").ToString();
            string mh = data.GetProperty("relative_velocity").GetProperty("miles_per_hour").ToString();
            Relative_velocity relative_Velocity = new Relative_velocity(kms, kmh, mh);
            /////////////////////////////////////////
            string astronomical = data.GetProperty("miss_distance").GetProperty("astronomical").ToString();
            string lunar = data.GetProperty("miss_distance").GetProperty("lunar").ToString();
            string kilometers = data.GetProperty("miss_distance").GetProperty("kilometers").ToString();
            string miles = data.GetProperty("miss_distance").GetProperty("miles").ToString();
            Miss_distance miss_Distance = new Miss_distance(astronomical, lunar, kilometers, miles);
            /////////////////////////////////////////
            string orbiting_body = data.GetProperty("orbiting_body").ToString();
            Close_approach_data close_Approach_Data = new Close_approach_data(close_approach_date, close_approach_date_full
            , epoch_date_close_approach, relative_Velocity, miss_Distance, orbiting_body);
            return close_Approach_Data;
        }
        private Asteroide getAsteroide(System.Text.Json.JsonElement data)
        {
            Link link = new Link(data.GetProperty("links").GetProperty("self").ToString());
            string id = data.GetProperty("id").ToString();
            string neo_reference_id = data.GetProperty("neo_reference_id").ToString();
            string name = data.GetProperty("name").ToString();
            string nasa_jpl_url = data.GetProperty("nasa_jpl_url").ToString();
            string absolute_magnitude_h = data.GetProperty("absolute_magnitude_h").ToString();
            Estimed_diametres estimed_Diametres = GetEstimed_Diametres(data.GetProperty("estimated_diameter"));
            bool is_potentially_hazardous_asteroid;
            string buff = data.GetProperty("is_potentially_hazardous_asteroid").ToString();
            bool.TryParse(buff, out is_potentially_hazardous_asteroid);
            List<Close_approach_data> tabAproachData = new List<Close_approach_data>();
            foreach (var jsonAproachData in data.GetProperty("close_approach_data").EnumerateArray())
            {
                tabAproachData.Add(this.GetCloseApproachData(jsonAproachData));
            }
            bool is_sentry_object;
            buff = data.GetProperty("is_sentry_object").ToString();
            bool.TryParse(buff, out is_sentry_object);
            Asteroide newAsteroide = new Asteroide(link, id,
            neo_reference_id, name, nasa_jpl_url, absolute_magnitude_h, estimed_Diametres,
            is_potentially_hazardous_asteroid, tabAproachData.ToArray(), is_sentry_object);
            return newAsteroide;
        }

        private Dictionnaire<Asteroide[]>? getDataOfAllAnalyse(System.Text.Json.JsonDocument? data)
        {
            if (data == null)
            {
                Console.WriteLine("data null :(");
                return null;
            }
            Dictionnaire<Asteroide[]> dictionaire_asteriode = new Dictionnaire<Asteroide[]>();
            var near_earth_objects = data.RootElement.GetProperty("near_earth_objects");
            foreach (var date in near_earth_objects.EnumerateObject())
            {
                string dicoKey = date.Name.ToString();
                var json_tab_asteroide = date.Value;
                List<Asteroide> tab_asteroide = new List<Asteroide>();
                foreach (var jsonAsteroide in json_tab_asteroide.EnumerateArray())
                {
                    Asteroide newAsteroide = this.getAsteroide(jsonAsteroide);
                    tab_asteroide.Add(newAsteroide);
                }
                dictionaire_asteriode.Ajouter(dicoKey, tab_asteroide.ToArray());
                if (dictionaire_asteriode == null)
                {
                    Console.WriteLine("-dictionaire_asteriode est vide ERRUEUR");
                    return null;
                }
            }
            return dictionaire_asteriode;
        }

        //cette fonction la recoltera toute la data json et transformera en classe que j'ai pres defini
        public async Task<Data_this_page?> getThisPage()
        {
            Data_this_page? this_page = null;//la classe que je compte return
            using (var client = new HttpClient())//je cree une client qui se connectera a l'api
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//nous attendons un forma json

                HttpResponseMessage response = await client.GetAsync("https://api.nasa.gov/neo/rest/v1/feed?api_key=" + apiKey);
                if (response.IsSuccessStatusCode)//une fois conecter il ne rest plus qu'a recolter les informations
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = System.Text.Json.JsonDocument.Parse(json);
                    var links =  this.getLink(data);//get link
                    int element_count = int.Parse(data.RootElement.GetProperty("element_count").ToString());
                    //Console.WriteLine("element_count = "+ element_count.ToString());
                    Dictionnaire<Asteroide[]>? all_asteroide = this.getDataOfAllAnalyse(data);
                    if (all_asteroide == null)
                    {
                        Console.WriteLine("VIDE ERREUR");
                        return null;
                    }
                    Console.WriteLine("GOOD");
                    this_page = new Data_this_page(links, element_count, all_asteroide);
                }
                else
                    Console.WriteLine("Error");
                return this_page;
            }
        }
    }
}
