using Tensorflow.Keras.Engine;
using Tensorflow.NumPy;
using Tensorflow.Keras.Layers;
using static Tensorflow.Binding;
using static Tensorflow.KerasApi;
using Tensorflow;
using Tensorflow.Keras.Utils;
using System.Text;
using Newtonsoft.Json;

namespace LogoRecognitionSystem
{
    public partial class LogoDetector : Form
    {

        #region Class Info
        Image orginal_Image { get; set; }
        int CurrentImageIndex { get; set; }

        Model Model { get; set; }

        List<DetectedLogo> DetectedLogos = new List<DetectedLogo>();

        #endregion

        #region Constructor
        public LogoDetector()
        {
            InitializeComponent();
            Central_Static_Value.LogoDetector = this;
            init_Models_toolStripComboBox();
            init_setting();
        }
        #endregion

        #region Methods

        /// <summary>
        /// initialize the Program Settings
        /// </summary>
        void init_setting()
        {

            try
            {

                string content = File.ReadAllText(Central_Static_Value.settings_path);
                Central_Static_Value.Settings = JsonConvert.DeserializeObject<SettingsClass>(content);
            }
            catch (Exception ex)
            {
                SettingsClass sc = new SettingsClass();
                sc.base_k_ = 5000;
                sc.Increment_k = 100;
                sc.Img_Minimal_Width = 30;
                sc.Img_Minimal_Height = 30;
                sc.Img_Maximal_Width = 500;
                sc.Img_Maximal_Height = 500;
                sc.Filter = "Colored";
                Central_Static_Value.Settings = sc;
            }

        }

        void init_Models_toolStripComboBox()
        {

            if (Directory.Exists("./Models"))
            {

                this.Models_toolStripComboBox.Items.Clear();

                List<string> files = Directory.GetFiles("./Models/", "*.*", SearchOption.AllDirectories).ToList();

                var ext = new List<string> { "h5" };

                files = files.Where(s => ext.Contains(Path.GetExtension(s).TrimStart('.').ToLowerInvariant())).ToList();

                foreach (string file in files)
                {

                    this.Models_toolStripComboBox.Items.Add(Path.GetFileNameWithoutExtension(file));

                }

            }

        }


        Winner getWinnerNeuron(NDArray nDarray)
        {
            lock (Tensorflow.Util.Locks.ProcessWide)
            {

                Tensorflow.Tensor tensor = Model.predict(x: nDarray);

                List<float> valueslist = tensor[0].ToArray<float>().ToList();

                var winnervalue = valueslist[0];

                int index = 0;

                for (int i = 0; i < (valueslist.Count); i++)
                {

                    if (valueslist[i] > winnervalue)
                    {
                        winnervalue = valueslist[i];
                        index = i;

                    }

                }
                if (winnervalue > 0.6)
                {
                    return new Winner(index, winnervalue);
                }
                else
                {
                    return new Winner(0, 0);
                }

            }



        }
        int extract_num(string strPart)
        {

            StringBuilder sb = new StringBuilder();

            int index = strPart.IndexOf('[') + 1;

            for (int i = index; i < strPart.Length; i++)
            {
                if (strPart[i].Equals(']'))
                {
                    break;
                }
                else
                {
                    sb.Append(strPart[i]);
                }

            }

            string str = sb.ToString();

            int num = Convert.ToInt16(str);

            return num;

        }

        public void SafeInvoke(Control uiElement, Action updater)
        {

            if (uiElement == null)
            {
                throw new ArgumentNullException("Control was null");
            }

            if (uiElement.InvokeRequired)
            {


                uiElement.BeginInvoke((Action)delegate { SafeInvoke(uiElement, updater); });

            }
            else
            {
                if (uiElement.IsDisposed)
                {
                    throw new ObjectDisposedException("Control is already disposed.");
                }

                updater();
            }

        }
        #endregion

        #region Events 

        private void Models_toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                ToolStripComboBox toolStripComboBox = (ToolStripComboBox)sender;
                string h5 = "./Models/" + toolStripComboBox.SelectedItem.ToString() + ".h5";
                string json = "./Models/" + toolStripComboBox.SelectedItem.ToString() + ".json";
                int outputecount = extract_num(toolStripComboBox.SelectedItem.ToString());
                keras.backend.clear_session();
                this.Model = new CNN(outputecount).Build(toolStripComboBox.SelectedItem.ToString());
                this.Model.load_weights(h5);
                string content = File.ReadAllText(json);
                Central_Static_Value.Train_Model.neuron2identity = JsonConvert.DeserializeObject<Dictionary<int, String>>(content);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void reload_tsb_Click(object sender, EventArgs e)
        {

            init_Models_toolStripComboBox();

        }
        private void next_button_Click(object sender, EventArgs e)
        {
            if (DetectedLogos.Any())
            {
                if (CurrentImageIndex != 0)
                {
                    CurrentImageIndex -= 1;
                    snipd_img.Image = DetectedLogos[CurrentImageIndex].Image;
                    this.current_selected_image.Text = (DetectedLogos.Count - CurrentImageIndex).ToString() + @"\" + (DetectedLogos.Count).ToString();
                    this.prdict_tb.Text = DetectedLogos[CurrentImageIndex].Predict;
                    this.prdict_value_tb.Text = DetectedLogos[CurrentImageIndex].PredictValue;


                }
                else
                {

                    CurrentImageIndex = DetectedLogos.Count - 1;
                    snipd_img.Image = DetectedLogos[CurrentImageIndex].Image;
                    this.current_selected_image.Text = (DetectedLogos.Count - CurrentImageIndex).ToString() + @"\" + (DetectedLogos.Count).ToString();
                    this.prdict_tb.Text = DetectedLogos[CurrentImageIndex].Predict;
                    this.prdict_value_tb.Text = DetectedLogos[CurrentImageIndex].PredictValue;

                }

            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            if (DetectedLogos.Any())
            {
                if (CurrentImageIndex != (DetectedLogos.Count - 1))
                {
                    CurrentImageIndex += 1;
                    snipd_img.Image = DetectedLogos[CurrentImageIndex].Image;
                    this.current_selected_image.Text = (DetectedLogos.Count - CurrentImageIndex).ToString() + @"\" + (DetectedLogos.Count).ToString();
                    this.prdict_tb.Text = DetectedLogos[CurrentImageIndex].Predict;
                    this.prdict_value_tb.Text = DetectedLogos[CurrentImageIndex].PredictValue;



                }
                else
                {

                    CurrentImageIndex = 0;
                    snipd_img.Image = DetectedLogos[CurrentImageIndex].Image;
                    this.current_selected_image.Text = (DetectedLogos.Count - CurrentImageIndex).ToString() + @"\" + (DetectedLogos.Count).ToString();
                    this.prdict_tb.Text = DetectedLogos[CurrentImageIndex].Predict;
                    this.prdict_value_tb.Text = DetectedLogos[CurrentImageIndex].PredictValue;


                }
            }
        }
        private void Predict_btn_Click(object sender, EventArgs e)
        {
            if (!Predict_bgw.IsBusy)
                Predict_bgw.RunWorkerAsync();
        }
        private void Train_new_model_Button_Click(object sender, EventArgs e)
        {
            Train_Model train_Model = new Train_Model();

            train_Model.ShowDialog();
        }
      
        private void Open_image_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImag = new OpenFileDialog();

            getImag.Filter = "JPG,PNG|*.png;*.jpg";

            DialogResult result = getImag.ShowDialog();

            if (result == DialogResult.OK)
            {

                docu_pb.Image = ImageHelper.ResizeImage(docu_pb.Width, docu_pb.Height,new Bitmap(Image.FromFile(getImag.FileName)));

                orginal_Image = docu_pb.Image;

            }

        }


        private void Predict_bgw_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (orginal_Image != null && Model != null)
            {


                this.DetectedLogos.Clear();

                SafeInvoke(loading_btn, new Action(() => { loading_btn.Visible = true; }));

                Bitmap image = new Bitmap(orginal_Image);

                List<BLob> selectedBlobs = ImageHelper.ExtractBlobsFromImage(image);

                bool logo_allready_found = false;

                try
                {
                    for (int i = 0; i < selectedBlobs.Count; i++)
                    {

                        using (var graphics = Graphics.FromImage(orginal_Image))
                        {

                            using (Font arialFont = new Font("Arial", 9))
                            {

                                var bitmap = ImageHelper.ResizeImage(32, 32, selectedBlobs[i].Image);

                                NDArray nDarray = ImageHelper.ImageToNDArray(bitmap);

                                nDarray = nDarray.astype(np.float32);

                                nDarray /= 255;

                                Winner win = getWinnerNeuron(nDarray);

                                string result = Central_Static_Value.Train_Model.neuron2identity[win.Neuron];

                                if (result != "negative")
                                {
                                    if (!logo_allready_found)
                                    {
                                        logo_allready_found = true;
                                        graphics.DrawRectangle(Pens.Black, selectedBlobs[i].Location);

                                        graphics.DrawString(result + " , " + i.ToString(), arialFont, Brushes.Red, selectedBlobs[i].Location.X, selectedBlobs[i].Location.Y);

                                        DetectedLogo dl = new DetectedLogo();
                                        dl.Image = selectedBlobs[i].Image;
                                        dl.Predict = result;
                                        dl.PredictValue = win.Value.ToString();
                                        DetectedLogos.add(dl);
                                    }
                                    else
                                    {
                                        graphics.DrawRectangle(Pens.Black, selectedBlobs[i].Location);
                                        DetectedLogo dl = new DetectedLogo();
                                        dl.Image = selectedBlobs[i].Image;
                                        dl.Predict = result;
                                        dl.PredictValue = win.Value.ToString();
                                        DetectedLogos.add(dl);

                                    }
                                }



                            }
                        }
                    }

                    SafeInvoke(docu_pb, new Action(() => { docu_pb.Image = orginal_Image; }));
                    CurrentImageIndex = DetectedLogos.Count - 1;
                    if (CurrentImageIndex != -1)
                    {
                        SafeInvoke(snipd_img, new Action(() => { snipd_img.Image = DetectedLogos[CurrentImageIndex].Image; }));
                        var bmp = ImageHelper.ResizeImage(32, 32, DetectedLogos[CurrentImageIndex].Image);
                        NDArray nDa = ImageHelper.ImageToNDArray(new Bitmap(bmp));
                        nDa = nDa.astype(np.float32);
                        nDa /= 255;
                        Winner winner = getWinnerNeuron(nDa);
                        string rslt = Central_Static_Value.Train_Model.neuron2identity[winner.Neuron];
                        SafeInvoke(prdict_tb, new Action(() => { this.prdict_tb.Text = rslt; }));
                        SafeInvoke(prdict_value_tb, new Action(() => { this.prdict_value_tb.Text = winner.Value.ToString(); }));
                        SafeInvoke(current_selected_image, new Action(() => { this.current_selected_image.Text = (DetectedLogos.Count - CurrentImageIndex).ToString() + @"\" + (DetectedLogos.Count).ToString(); }));

                    }
                    SafeInvoke(loading_btn, new Action(() => { loading_btn.Visible = false; }));


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    SafeInvoke(loading_btn, new Action(() => { loading_btn.Visible = false; }));

                }

            }
        }

        private void settings_tsb_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }
        #endregion



    }
}