using System.Net;
using System.Drawing;

namespace yzaoui_nasa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            void ajouter_apod(Form1 form1, NasaAPOD apod)
            {
                // 
                // date_apod
                // 
                TextBox date_apod = form1.getDateApod();
                date_apod.Location = new System.Drawing.Point(12, 37);
                date_apod.Name = "date_apod";
                date_apod.Size = new System.Drawing.Size(119, 23);
                date_apod.TabIndex = 1;
                date_apod.Text = "Date : " + apod.getDate();
                // 
                // explication_apod
                // 
                TextBox explication_apod = form1.getExplicationApod();
                explication_apod.Location = new System.Drawing.Point(12, 66);
                explication_apod.Name = "explication_apod";
                explication_apod.Size = new System.Drawing.Size(238, 23);
                explication_apod.TabIndex = 2;
                explication_apod.Text = "Explication : \n" + apod.getExplanation();
                explication_apod.ReadOnly = true;
                // 
                // titre_apod
                // 
                TextBox titre_apod = form1.getTitreApod();
                titre_apod.Location = new System.Drawing.Point(352, 8);
                titre_apod.Name = "titre_apod";
                titre_apod.ReadOnly = true;
                titre_apod.Size = new System.Drawing.Size(196, 23);
                titre_apod.TabIndex = 3;
                titre_apod.Text = "Titre : "+ apod.getTitle();
                // 
                // copyright
                // 
                TextBox copyright = form1.getCopyright();
                copyright.Location = new System.Drawing.Point(12, 292);
                copyright.Name = "copyright";
                copyright.Size = new System.Drawing.Size(178, 23);
                copyright.TabIndex = 4;
                if (apod.getCopyright() != null)
                    copyright.Text = apod.getCopyright();
                else
                    copyright.Text = "Il n'a pas de copyrigt";
                copyright.ReadOnly = true;
            }

            void ajout_des_dates(Form1 form1, Data_this_page data)
            {
                // 
                // day_of_analyse
                // 
                if (data.GetDateOfAllAnalyse() == null)
                    return;
                form1.day_of_analyse.Items.AddRange(data.GetDateOfAllAnalyse().ObtenirCle().ToArray());
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string key = "xegfhwLdY6O1L48WNPnLgF4nkeAZXL1mJDp1cBGi";//ma cle pour me recuperer l'api
            NasaAPI api = new NasaAPI(key);//Recolte de la donné api
            Data_this_page? data= api.getThisPage().Result;//recolte des element important
            NasaAPOD apod = new NasaAPOD(key);//recolte de l'apod
            Form1 form1;
            if (data != null)
                form1 = new Form1(data);
            else
                return;
            string url_image = apod.getUrl();
            using (WebClient client = new WebClient())
            {
                byte[] imageBytes = client.DownloadData(url_image);
                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    var image = Image.FromStream(stream);
                    form1.BackgroundImage = new Bitmap(image);
                }
            }
            form1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ajouter_apod(form1, apod);
            ajout_des_dates(form1, data);
            Application.Run(form1);
        }

    }
}