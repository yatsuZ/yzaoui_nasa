namespace yzaoui_nasa
{
    public partial class Form1 : Form
    {
        private Asteroide current_asteroide;
        private Data_this_page data;
        private Asteroide[] tab_asteroide;
        private Close_approach_data[] close_datas;
        private Close_approach_data current_close;
        public Form1(Data_this_page data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionnaire<Asteroide[]>? date_all_asteroide;
            if (data.GetDateOfAllAnalyse() != null)
                date_all_asteroide = data.GetDateOfAllAnalyse();
            else
                return ;
            this.tab_asteroide = date_all_asteroide.Obtenir(this.day_of_analyse.Text);
            List<string> tab_int = new List<string>();
            for (int i = 0; i < this.tab_asteroide.Length; i++)
                tab_int.Add(i.ToString());
            this.all_asteroide.Items.AddRange(tab_int.ToArray());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.current_close = this.close_datas[int.Parse(close_approach_data_api.Text)];
            //close_approach_date_api
            this.close_approach_date_api.Text = this.current_close.GetCloseApproachDate();
            //close_approach_date_full_api
            this.close_approach_date_full_api.Text = this.current_close.GetCloseApproachDateFull();
            //epoch_date_close_approach_api
            this.epoch_date_close_approach_api.Text = this.current_close.GetEpochDateCloseApproach().ToString();
            //orbiting_body_api
            this.orbiting_body_api.Text = this.current_close.GetOrbitingBody();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void all_asteroide_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.current_asteroide = this.tab_asteroide[int.Parse(this.all_asteroide.Text)];
            //link_asteroide
            this.link_asteroide.Text = this.current_asteroide.GetLink().GetAllLink().Obtenir("self");
            //id_api
            this.id_api.Text = "Id = " + this.current_asteroide.GetId().ToString();
            //neo_reference_id_api
            this.neo_reference_id_api.Text = "neo ID = " + this.current_asteroide.GetNeoReferenceId();
            //name_api
            this.name_api.Text = "Name = " + this.current_asteroide.GetName().ToString();
            //magnitude_absolu_api
            this.magnitude_absolu_api.Text = "Magnitude = " + this.current_asteroide.GetAbsoluteMagnitudeH();
            //is_potentially_hazardous_asteroid_api
            this.is_potentially_hazardous_asteroid_api.Text = "potentiel hazardous = " + this.current_asteroide.GetIsPotentiallyHazardousAsteroid().ToString();
            //is_sentry_object_api
            this.is_sentry_object_api.Text = "sentry object = " + this.current_asteroide.GetIsSentryObject().ToString();
            //close_approach_data_api
            this.close_datas = this.current_asteroide.GetCloseApproachDatas();
            List<string> tab_int = new List<string>();
            for (int i = 0; i < this.close_datas.Length; i++)
                tab_int.Add(i.ToString());
            this.close_approach_data_api.Items.AddRange(tab_int.ToArray());
        }

        private void neo_reference_id_api_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (current_asteroide == null)
                return;
            string valueMin = this.current_asteroide.GetEstimedDiametre().getUnite().Obtenir(comboBox3.Text).Obtenir("estimated_diameter_min");
            string valueMax = this.current_asteroide.GetEstimedDiametre().getUnite().Obtenir(comboBox3.Text).Obtenir("estimated_diameter_max");
            this.min_diametre_api.Text = valueMin;
            this.max_diametre_api.Text = valueMax;

        }

        private void relative_velocity_api_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (close_datas == null)
                return;
            //vitesse_api
            if (this.relative_velocity_api.Text == "miles_per_hour")
                this.vitesse_api.Text = this.current_close.GetRelativeVelocity().Getmiles_per_hour();
            else if (this.relative_velocity_api.Text == "kilometers_per_hour")
                this.vitesse_api.Text = this.current_close.GetRelativeVelocity().GetKilometers_per_hour();
            else if (this.relative_velocity_api.Text == "kilometers_per_second")
                this.vitesse_api.Text = this.current_close.GetRelativeVelocity().GetKilometers_per_second();
        }

        private void miss_distance_api_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (close_datas == null)
                return;
            //vitesse_api
            if (this.miss_distance_api.Text == "miles_per_hour")
                this.distance_le_plus_proche.Text = this.current_close.GetMissDistance().Getlunar();
            else if (this.miss_distance_api.Text == "miles")
                this.distance_le_plus_proche.Text = this.current_close.GetMissDistance().Getmiles();
            else if (this.miss_distance_api.Text == "kilometers")
                this.distance_le_plus_proche.Text = this.current_close.GetMissDistance().Getkilometers();
            else if (this.miss_distance_api.Text == "astronomical")
                this.distance_le_plus_proche.Text = this.current_close.GetMissDistance().Getastronomical();
        }
    }
}