using Newtonsoft.Json;

namespace LogoRecognitionSystem
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            init_CB();
            Init_Settings();
        }

        private void save_sss_btn_Click(object sender, EventArgs e)
        {
            SettingsClass settings = new SettingsClass();
            settings.base_k_ = (int)this.baseK_num.Value;
            settings.Increment_k = (int)this.incrK_num.Value;
            settings.Img_Minimal_Width = (int)this.minWid_num.Value;
            settings.Img_Minimal_Height = (int)this.minHei_num.Value;
            settings.Img_Maximal_Width = (int)this.maxWid_num.Value;
            settings.Img_Maximal_Height = (int)this.maxHei_num.Value;
            settings.Filter = (this.Filter_Cb.SelectedIndex == -1) ? "Colored" : this.Filter_Cb.SelectedItem.ToString();
            try
            {
                string json = JsonConvert.SerializeObject(settings);

                File.WriteAllText(Central_Static_Value.settings_path, json);

                DialogResult result = MessageBox.Show(this, "Successfully changed the Settings !!" + Environment.NewLine + "Would you like to close the window ?", "Info!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                Central_Static_Value.Settings = settings;

                if (result == DialogResult.Yes)
                {
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Faild to Seave the new Settings !!!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        void init_CB()
        {

            this.Filter_Cb.Items.Add("Gray");
            this.Filter_Cb.Items.Add("BlackWeight");
            this.Filter_Cb.Items.Add("Colored");

        }

        void Init_Settings()
        {

            SettingsClass settings = Central_Static_Value.Settings;

            if (settings != null)
            {

                this.baseK_num.Value = settings.base_k_;
                this.incrK_num.Value = settings.Increment_k;
                this.minWid_num.Value = settings.Img_Minimal_Width;
                this.minHei_num.Value = settings.Img_Minimal_Height;
                this.maxWid_num.Value = settings.Img_Maximal_Width;
                this.maxHei_num.Value = settings.Img_Maximal_Height;
                this.Filter_Cb.SelectedIndex = Filter_Cb.FindString(settings.Filter);

            }



        }
    }
}
