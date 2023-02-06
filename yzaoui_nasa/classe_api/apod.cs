using System.Net.Http.Headers;
namespace yzaoui_nasa
{
    class NasaAPOD
    {
        private readonly string key;
        private readonly string path;
        private string? copyright;
        private string date;
        private string explanation;
        private string hdurl;
        private string media_type;
        private string service_version;
        private string title;
        private string url;
        

        private async Task<string[]> colecteData(string path)
        {
            List<string> l = new List<string>();
            using (var client = new HttpClient())//je cree une client qui se connectera a l'api
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));//nous attendons un forma json 
                HttpResponseMessage response = await client.GetAsync(path);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var data = System.Text.Json.JsonDocument.Parse(json);
                    System.Text.Json.JsonElement copyright;
                    if (data.RootElement.TryGetProperty("copyright", out copyright))
                        l.Add(copyright.ToString());
                    else
                        l.Add("");
                    l.Add(data.RootElement.GetProperty("date").ToString());
                    l.Add(data.RootElement.GetProperty("explanation").ToString());
                    l.Add(data.RootElement.GetProperty("hdurl").ToString());
                    l.Add(data.RootElement.GetProperty("media_type").ToString());
                    l.Add(data.RootElement.GetProperty("service_version").ToString());
                    l.Add(data.RootElement.GetProperty("title").ToString());
                    l.Add(data.RootElement.GetProperty("url").ToString());
                }
            }
            return l.ToArray();
        }
        public NasaAPOD(string key)
        {
            this.key = key;
            this.path = "https://api.nasa.gov/planetary/apod?api_key=" + key;
            string[] tab = this.colecteData(this.path).Result;
            int i = 0;
            this.copyright = tab[i++];
            if (this.copyright == "")
                this.copyright = null;
            this.date = tab[i++];
            this.explanation = tab[i++];
            this.hdurl = tab[i++];
            this.media_type = tab[i++];
            this.service_version = tab[i++];
            this.title = tab[i++];
            this.url = tab[i++];
        }

        public void affichage()
        {
            Console.WriteLine("key = "+this.key + "\n\n");
            Console.WriteLine("path = "+this.path + "\n\n");
            Console.WriteLine("copyright = "+this.copyright + "\n\n");
            Console.WriteLine("date = "+this.date + "\n\n");
            Console.WriteLine("explanation = "+this. explanation + "\n\n");
            Console.WriteLine("hdurl = "+this.hdurl + "\n\n");
            Console.WriteLine("media_type = "+this.media_type + "\n\n");
            Console.WriteLine("service_version = "+this.service_version + "\n\n");
            Console.WriteLine("title = "+this.title + "\n\n");
            Console.WriteLine("url = "+this.url + "\n\n");
        }

        public string getPath() => this.path;
        public string? getCopyright() => this.copyright;
        public void setCopyright(string arg)
        {
            this.copyright = arg;
        }
        public string getDate() => this.date;
        public void setDate(string arg)
        {
            this.date = arg;
        }
        public string getExplanation() => this.explanation;
        public void setExplanation(string arg)
        {
            this.explanation = arg;
        }
        public string getHdurl() => this.hdurl;
        public void setHdurl(string arg)
        {
            this.hdurl = arg;
        }
        public string getMediaType() => this.media_type;
        public void setMediaType(string arg)
        {
            this.media_type = arg;
        }
        public string getServiceVersion() => this.service_version;
        public void setServiceVersion(string arg)
        {
            this.service_version = arg;
        }
        public string getTitle() => this.title;
        public void setTitle(string arg)
        {
            this.title = arg;
        }
        public string getUrl() => this.url;
        public void setUrl(string arg)
        {
            this.url = arg;
        }
    }
}