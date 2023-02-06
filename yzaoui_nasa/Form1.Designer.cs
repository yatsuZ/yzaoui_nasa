namespace yzaoui_nasa
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.date_apod = new System.Windows.Forms.TextBox();
            this.explication_apod = new System.Windows.Forms.TextBox();
            this.titre_apod = new System.Windows.Forms.TextBox();
            this.copyright = new System.Windows.Forms.TextBox();
            this.day_of_analyse = new System.Windows.Forms.ComboBox();
            this.link_asteroide = new System.Windows.Forms.TextBox();
            this.id_api = new System.Windows.Forms.TextBox();
            this.neo_reference_id_api = new System.Windows.Forms.TextBox();
            this.name_api = new System.Windows.Forms.TextBox();
            this.magnitude_absolu_api = new System.Windows.Forms.TextBox();
            this.is_potentially_hazardous_asteroid_api = new System.Windows.Forms.TextBox();
            this.min_diametre_api = new System.Windows.Forms.TextBox();
            this.close_approach_data_api = new System.Windows.Forms.ComboBox();
            this.close_approach_date_api = new System.Windows.Forms.TextBox();
            this.close_approach_date_full_api = new System.Windows.Forms.TextBox();
            this.epoch_date_close_approach_api = new System.Windows.Forms.TextBox();
            this.orbiting_body_api = new System.Windows.Forms.TextBox();
            this.distance_le_plus_proche = new System.Windows.Forms.TextBox();
            this.vitesse_api = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.max_diametre_api = new System.Windows.Forms.TextBox();
            this.is_sentry_object_api = new System.Windows.Forms.TextBox();
            this.relative_velocity_api = new System.Windows.Forms.ComboBox();
            this.miss_distance_api = new System.Windows.Forms.ComboBox();
            this.all_asteroide = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // date_apod
            // 
            this.date_apod.Location = new System.Drawing.Point(12, 37);
            this.date_apod.Multiline = true;
            this.date_apod.Name = "date_apod";
            this.date_apod.Size = new System.Drawing.Size(217, 23);
            this.date_apod.TabIndex = 1;
            this.date_apod.Text = "Date";
            this.date_apod.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // explication_apod
            // 
            this.explication_apod.Location = new System.Drawing.Point(12, 66);
            this.explication_apod.MinimumSize = new System.Drawing.Size(217, 111);
            this.explication_apod.Multiline = true;
            this.explication_apod.Name = "explication_apod";
            this.explication_apod.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.explication_apod.Size = new System.Drawing.Size(217, 111);
            this.explication_apod.TabIndex = 2;
            this.explication_apod.Text = "Explication";
            this.explication_apod.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // titre_apod
            // 
            this.titre_apod.Location = new System.Drawing.Point(268, 8);
            this.titre_apod.Name = "titre_apod";
            this.titre_apod.ReadOnly = true;
            this.titre_apod.Size = new System.Drawing.Size(312, 23);
            this.titre_apod.TabIndex = 3;
            this.titre_apod.Text = "TITRE";
            // 
            // copyright
            // 
            this.copyright.Location = new System.Drawing.Point(12, 8);
            this.copyright.Multiline = true;
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(217, 23);
            this.copyright.TabIndex = 4;
            this.copyright.Text = "copyright";
            this.copyright.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // day_of_analyse
            // 
            this.day_of_analyse.FormattingEnabled = true;
            this.day_of_analyse.Location = new System.Drawing.Point(624, 37);
            this.day_of_analyse.Name = "day_of_analyse";
            this.day_of_analyse.Size = new System.Drawing.Size(218, 23);
            this.day_of_analyse.TabIndex = 5;
            this.day_of_analyse.Text = "select day";
            this.day_of_analyse.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // link_asteroide
            // 
            this.link_asteroide.Location = new System.Drawing.Point(268, 37);
            this.link_asteroide.Name = "link_asteroide";
            this.link_asteroide.Size = new System.Drawing.Size(312, 23);
            this.link_asteroide.TabIndex = 6;
            this.link_asteroide.Text = "link";
            // 
            // id_api
            // 
            this.id_api.Location = new System.Drawing.Point(268, 66);
            this.id_api.Name = "id_api";
            this.id_api.Size = new System.Drawing.Size(312, 23);
            this.id_api.TabIndex = 7;
            this.id_api.Text = "id";
            // 
            // neo_reference_id_api
            // 
            this.neo_reference_id_api.Location = new System.Drawing.Point(268, 95);
            this.neo_reference_id_api.Name = "neo_reference_id_api";
            this.neo_reference_id_api.Size = new System.Drawing.Size(312, 23);
            this.neo_reference_id_api.TabIndex = 8;
            this.neo_reference_id_api.Text = "neo_reference_id";
            this.neo_reference_id_api.TextChanged += new System.EventHandler(this.neo_reference_id_api_TextChanged);
            // 
            // name_api
            // 
            this.name_api.Location = new System.Drawing.Point(268, 124);
            this.name_api.Name = "name_api";
            this.name_api.Size = new System.Drawing.Size(312, 23);
            this.name_api.TabIndex = 9;
            this.name_api.Text = "name";
            // 
            // magnitude_absolu_api
            // 
            this.magnitude_absolu_api.Location = new System.Drawing.Point(268, 153);
            this.magnitude_absolu_api.Name = "magnitude_absolu_api";
            this.magnitude_absolu_api.Size = new System.Drawing.Size(312, 23);
            this.magnitude_absolu_api.TabIndex = 10;
            this.magnitude_absolu_api.Text = "absolute_magnitude_h";
            // 
            // is_potentially_hazardous_asteroid_api
            // 
            this.is_potentially_hazardous_asteroid_api.Location = new System.Drawing.Point(12, 480);
            this.is_potentially_hazardous_asteroid_api.Name = "is_potentially_hazardous_asteroid_api";
            this.is_potentially_hazardous_asteroid_api.Size = new System.Drawing.Size(217, 23);
            this.is_potentially_hazardous_asteroid_api.TabIndex = 12;
            this.is_potentially_hazardous_asteroid_api.Text = "is_potentially_hazardous_asteroid";
            // 
            // min_diametre_api
            // 
            this.min_diametre_api.Location = new System.Drawing.Point(268, 183);
            this.min_diametre_api.Name = "min_diametre_api";
            this.min_diametre_api.Size = new System.Drawing.Size(160, 23);
            this.min_diametre_api.TabIndex = 18;
            this.min_diametre_api.Text = "min_d";
            // 
            // close_approach_data_api
            // 
            this.close_approach_data_api.FormattingEnabled = true;
            this.close_approach_data_api.Location = new System.Drawing.Point(624, 95);
            this.close_approach_data_api.Name = "close_approach_data_api";
            this.close_approach_data_api.Size = new System.Drawing.Size(218, 23);
            this.close_approach_data_api.TabIndex = 28;
            this.close_approach_data_api.Text = "close approach data";
            this.close_approach_data_api.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // close_approach_date_api
            // 
            this.close_approach_date_api.Location = new System.Drawing.Point(624, 124);
            this.close_approach_date_api.Name = "close_approach_date_api";
            this.close_approach_date_api.Size = new System.Drawing.Size(218, 23);
            this.close_approach_date_api.TabIndex = 29;
            this.close_approach_date_api.Text = "close_approach_date";
            // 
            // close_approach_date_full_api
            // 
            this.close_approach_date_full_api.Location = new System.Drawing.Point(624, 153);
            this.close_approach_date_full_api.Name = "close_approach_date_full_api";
            this.close_approach_date_full_api.Size = new System.Drawing.Size(218, 23);
            this.close_approach_date_full_api.TabIndex = 30;
            this.close_approach_date_full_api.Text = "close_approach_date_full";
            this.close_approach_date_full_api.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // epoch_date_close_approach_api
            // 
            this.epoch_date_close_approach_api.Location = new System.Drawing.Point(624, 182);
            this.epoch_date_close_approach_api.Name = "epoch_date_close_approach_api";
            this.epoch_date_close_approach_api.Size = new System.Drawing.Size(218, 23);
            this.epoch_date_close_approach_api.TabIndex = 31;
            this.epoch_date_close_approach_api.Text = "epoch_date_close_approach";
            this.epoch_date_close_approach_api.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // orbiting_body_api
            // 
            this.orbiting_body_api.Location = new System.Drawing.Point(624, 211);
            this.orbiting_body_api.Name = "orbiting_body_api";
            this.orbiting_body_api.Size = new System.Drawing.Size(218, 23);
            this.orbiting_body_api.TabIndex = 32;
            this.orbiting_body_api.Text = "orbiting_body";
            // 
            // distance_le_plus_proche
            // 
            this.distance_le_plus_proche.Location = new System.Drawing.Point(268, 241);
            this.distance_le_plus_proche.Name = "distance_le_plus_proche";
            this.distance_le_plus_proche.Size = new System.Drawing.Size(312, 23);
            this.distance_le_plus_proche.TabIndex = 34;
            this.distance_le_plus_proche.Text = "distance_le_plus_proche";
            // 
            // vitesse_api
            // 
            this.vitesse_api.Location = new System.Drawing.Point(268, 212);
            this.vitesse_api.Name = "vitesse_api";
            this.vitesse_api.Size = new System.Drawing.Size(312, 23);
            this.vitesse_api.TabIndex = 33;
            this.vitesse_api.Text = "vitesse";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "kilometers",
            "meters",
            "miles",
            "feet"});
            this.comboBox3.Location = new System.Drawing.Point(12, 183);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(218, 23);
            this.comboBox3.TabIndex = 35;
            this.comboBox3.Text = "diametre estimer";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // max_diametre_api
            // 
            this.max_diametre_api.Location = new System.Drawing.Point(434, 183);
            this.max_diametre_api.Name = "max_diametre_api";
            this.max_diametre_api.Size = new System.Drawing.Size(146, 23);
            this.max_diametre_api.TabIndex = 36;
            this.max_diametre_api.Text = "max_d";
            // 
            // is_sentry_object_api
            // 
            this.is_sentry_object_api.Location = new System.Drawing.Point(624, 480);
            this.is_sentry_object_api.Name = "is_sentry_object_api";
            this.is_sentry_object_api.Size = new System.Drawing.Size(218, 23);
            this.is_sentry_object_api.TabIndex = 37;
            this.is_sentry_object_api.Text = "is_sentry_object";
            // 
            // relative_velocity_api
            // 
            this.relative_velocity_api.FormattingEnabled = true;
            this.relative_velocity_api.Items.AddRange(new object[] {
            "kilometers_per_second",
            "kilometers_per_hour",
            "miles_per_hour"});
            this.relative_velocity_api.Location = new System.Drawing.Point(13, 212);
            this.relative_velocity_api.Name = "relative_velocity_api";
            this.relative_velocity_api.Size = new System.Drawing.Size(218, 23);
            this.relative_velocity_api.TabIndex = 38;
            this.relative_velocity_api.Text = "relative_velocity";
            this.relative_velocity_api.SelectedIndexChanged += new System.EventHandler(this.relative_velocity_api_SelectedIndexChanged);
            // 
            // miss_distance_api
            // 
            this.miss_distance_api.FormattingEnabled = true;
            this.miss_distance_api.Items.AddRange(new object[] {
            "astronomical",
            "lunar",
            "kilometers",
            "miles"});
            this.miss_distance_api.Location = new System.Drawing.Point(13, 241);
            this.miss_distance_api.Name = "miss_distance_api";
            this.miss_distance_api.Size = new System.Drawing.Size(218, 23);
            this.miss_distance_api.TabIndex = 39;
            this.miss_distance_api.Text = "miss_distance";
            this.miss_distance_api.SelectedIndexChanged += new System.EventHandler(this.miss_distance_api_SelectedIndexChanged);
            // 
            // all_asteroide
            // 
            this.all_asteroide.FormattingEnabled = true;
            this.all_asteroide.Location = new System.Drawing.Point(624, 66);
            this.all_asteroide.Name = "all_asteroide";
            this.all_asteroide.Size = new System.Drawing.Size(218, 23);
            this.all_asteroide.TabIndex = 43;
            this.all_asteroide.Text = "Asteroide info";
            this.all_asteroide.SelectedIndexChanged += new System.EventHandler(this.all_asteroide_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(870, 554);
            this.Controls.Add(this.all_asteroide);
            this.Controls.Add(this.miss_distance_api);
            this.Controls.Add(this.relative_velocity_api);
            this.Controls.Add(this.is_sentry_object_api);
            this.Controls.Add(this.max_diametre_api);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.distance_le_plus_proche);
            this.Controls.Add(this.vitesse_api);
            this.Controls.Add(this.orbiting_body_api);
            this.Controls.Add(this.epoch_date_close_approach_api);
            this.Controls.Add(this.close_approach_date_full_api);
            this.Controls.Add(this.close_approach_date_api);
            this.Controls.Add(this.close_approach_data_api);
            this.Controls.Add(this.min_diametre_api);
            this.Controls.Add(this.is_potentially_hazardous_asteroid_api);
            this.Controls.Add(this.magnitude_absolu_api);
            this.Controls.Add(this.name_api);
            this.Controls.Add(this.neo_reference_id_api);
            this.Controls.Add(this.id_api);
            this.Controls.Add(this.link_asteroide);
            this.Controls.Add(this.day_of_analyse);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.titre_apod);
            this.Controls.Add(this.explication_apod);
            this.Controls.Add(this.date_apod);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(870, 554);
            this.MinimumSize = new System.Drawing.Size(870, 554);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public TextBox date_apod;
        public TextBox getDateApod() { return date_apod; }
        public TextBox explication_apod;
        public TextBox getExplicationApod() { return explication_apod; }
        public TextBox titre_apod;
        public TextBox getTitreApod() { return titre_apod; }
        public TextBox copyright;
        public TextBox getCopyright() { return copyright; }

        public ComboBox day_of_analyse;
        public TextBox link_asteroide;
        public TextBox id_api;
        public TextBox neo_reference_id_api;
        public TextBox name_api;
        public TextBox magnitude_absolu_api;
        public TextBox is_potentially_hazardous_asteroid_api;
        public TextBox min_diametre_api;
        public ComboBox close_approach_data_api;
        public TextBox close_approach_date_api;
        public TextBox close_approach_date_full_api;
        public TextBox epoch_date_close_approach_api;
        public TextBox orbiting_body_api;
        public TextBox distance_le_plus_proche;
        public TextBox vitesse_api;
        public ComboBox comboBox3;
        public TextBox max_diametre_api;
        public TextBox is_sentry_object_api;
        public ComboBox relative_velocity_api;
        public ComboBox miss_distance_api;
        public ComboBox all_asteroide;
    }
}