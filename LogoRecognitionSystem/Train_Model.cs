using Newtonsoft.Json;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Tensorflow.Keras.Engine;
using Tensorflow.NumPy;
using static Tensorflow.KerasApi;
using Microsoft.VisualBasic;

namespace LogoRecognitionSystem
{
    public partial class Train_Model : Form
    {

        #region class info 

        public Model Model { get; set; }

        public List<TrainingSet> TrainingSetList = new List<TrainingSet>();

        public int outputCount = 0;

        public IDictionary<String, int> identity2neuron = new Dictionary<String, int>();

        public IDictionary<int, String> neuron2identity = new Dictionary<int, String>();

        int los_NextPointIndex = 0;

        int acc_NextPointIndex = 0;

        int train_values_max => (int)Epoches_numericUpDown.Value + 1;

        double[] los_train_values { get; set; }

        double[] acc_train_values { get; set; }

        ScottPlot.Plottable.SignalPlot los_SignalPlot;

        ScottPlot.Plottable.SignalPlot acc_SignalPlot;
        #endregion

        #region Constructor
        public Train_Model()
        {
            InitializeComponent();
            Central_Static_Value.Train_Model = this;
            // Console.SetOut(new ControlWriter(log_textBox,this.label3));
            inti_negative_value();

        }
        #endregion

        #region Events
        private void Learn_bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            init_loss_Plot(10);
            init_Accuracy_Plot(10);


            try

            {
                lock (Tensorflow.Util.Locks.ProcessWide)
                {

                    if (this.TrainingSetList.Count > 0)
                    {

                        NDArray x_train = ImageHelper.ImagesToNDArray(this.TrainingSetList, 32, 32);

                       
                        NDArray y_train = ImageHelper.IdelaValuesToNDArray(this.TrainingSetList, this.outputCount);

                        x_train = x_train.astype(np.float32);

                        x_train /= 255;

                        Model = new CNN(outputCount).Build("LogoDetector");

                        var opt = new Tensorflow.Keras.Optimizers.Adam(learning_rate: 0.001f);
                        //   Model.summary();

                        Model.compile(optimizer: opt,
                                      loss: keras.losses.CategoricalCrossentropy(),
                                      metrics: new[] { "acc" });
                        for (int i = 0; i < (int)Epoches_numericUpDown.Value; i++)
                        {

                            Tensorflow.Keras.Callbacks.History history = Model.fit(x_train, y_train);
                            SafeInvoke(progressBar1, new Action(() =>
                            {
                                progressBar1.Value = ((((i) * 100) / (int)Epoches_numericUpDown.Value));
                            }));

                            SafeInvoke(log_textBox, new Action(() =>
                            {
                                log_textBox.AppendText("Epoch =" + i.ToString() + " ,");
                                log_textBox.AppendText("accuracy =" + history.history["accuracy"][0].ToString() + " ,");
                                log_textBox.AppendText("loss =" + history.history["loss"][0].ToString() + Environment.NewLine);
                                
                            }));
                            SafeInvoke(acc_formsPlot, new Action(() =>
                            {

                                update_Accuracy_Plot(history.history["accuracy"][0]);
                                update_loss_Plot(history.history["loss"][0]);
                            }));



                        }



                        SafeInvoke(Export_Model_button, new Action(() => { this.Export_Model_button.Enabled = true; }));
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void Add_image_btn_Click(object sender, EventArgs e)
        {
            DialogResult res = CustomMsgbox.InputBox.ShowDialog("represent the  Image a new Dataset  ?", "Question",
               CustomMsgbox.InputBox.Icon.Question,
               CustomMsgbox.InputBox.Buttons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                res = CustomMsgbox.InputBox.ShowDialog("Please Enter the Ideal set value !!", "Ideal set",
               CustomMsgbox.InputBox.Icon.Question,
              CustomMsgbox.InputBox.Buttons.OkCancel,
              CustomMsgbox.InputBox.Type.TextBox,
              new string[] { "Ideal set new Value" });

                if (res == System.Windows.Forms.DialogResult.OK)
                {

                    OpenFileDialog getImag = new OpenFileDialog();

                    getImag.Filter = "JPG,PNG|*.png;*.jpg";

                    DialogResult result = getImag.ShowDialog();

                    string InputBox_ResultValue = CustomMsgbox.InputBox.ResultValue;

                    if (result == DialogResult.OK)
                    {

                        Bitmap image = new Bitmap(Image.FromFile(getImag.FileName));

                        switch (Central_Static_Value.Settings.Filter)
                        {

                            case "Colored": image = ImageHelper.BGRFiler(image); break;
                            case "Gray": image = ImageHelper.GrayFilter(image); break;
                            case "BlackWeight": image = ImageHelper.BlackWhiteFilter(image); break;
                            default: image = ImageHelper.BGRFiler(image); break;


                        }

                        int match = AssignIdentity(InputBox_ResultValue);

                        string imageName = "image" + to_Train_Images_dataGridView.Rows.Count.ToString();

                        to_Train_Images_dataGridView.Rows.Add(imageName, InputBox_ResultValue, ImageHelper.ResizeImage(32, 32, image));

                        TrainingSet trainingSet = new TrainingSet(imageName, match, ImageHelper.ResizeImage(32, 32, image), true);

                        Central_Static_Value.Train_Model.TrainingSetList.Add(trainingSet);
                    }

                }

            }
            else
            {

                res = CustomMsgbox.InputBox.ShowDialog("Please choose the Ideal set value !!", "Ideal set",
                CustomMsgbox.InputBox.Icon.Question,
                CustomMsgbox.InputBox.Buttons.OkCancel,
                CustomMsgbox.InputBox.Type.ComboBox,
                neuron2identity.Select(x => x.Value).ToArray());
                if (res == DialogResult.OK)
                {
                    string result = CustomMsgbox.InputBox.ResultValue;
                    OpenFileDialog getImag = new OpenFileDialog();

                    getImag.Filter = "JPG,PNG|*.png;*.jpg";

                    DialogResult Imagresult = getImag.ShowDialog();

                    if (Imagresult == DialogResult.OK)
                    {

                        Bitmap image = new Bitmap(Image.FromFile(getImag.FileName));

                        string imageName = "image" + to_Train_Images_dataGridView.Rows.Count.ToString();

                        int match = AssignIdentity(result);

                        switch (Central_Static_Value.Settings.Filter)
                        {

                            case "Colored": image = ImageHelper.BGRFiler(image); break;
                            case "Gray": image = ImageHelper.GrayFilter(image); break;
                            case "BlackWeight": image = ImageHelper.BlackWhiteFilter(image); break;
                            default: image = ImageHelper.BGRFiler(image); break;


                        }

                        to_Train_Images_dataGridView.Rows.Add(imageName, result, ImageHelper.ResizeImage(32, 32, image));

                        TrainingSet trainingSet = new TrainingSet(imageName, match, ImageHelper.ResizeImage(32, 32, image), false);

                        TrainingSetList.Add(trainingSet);
                    }
                }

            }
        }
        private void d_tex_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (d_tex_rb.Checked)
            {
                this.tabControl1.SelectTab(0);
            }

        }

        private void d_lo_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (d_lo_rb.Checked)
            {
                this.tabControl1.SelectTab(1);

            }

        }

        private void d_acc_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (d_acc_rb.Checked)
            {
                this.tabControl1.SelectTab(2);

            }
        }
        private void add_image_button_Click(object sender, EventArgs e)
        {

            Snip_Images snipImage = new Snip_Images();
            snipImage.ShowDialog();

        }

        private void start_learning_button_Click(object sender, EventArgs e)
        {

            if (!this.Learn_bgw.IsBusy)
            {
                this.Learn_bgw.RunWorkerAsync();

            }
            

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
        int AssignIdentity(String identity)
        {

            if (identity2neuron.ContainsKey(identity.ToLower()))
            {
                return identity2neuron[identity.ToLower()];
            }

            int result = outputCount;

            identity2neuron[identity.ToLower()] = result;

            neuron2identity[result] = identity.ToLower();

            outputCount++;

            return result;

        }
        #endregion

        #region Methods

        void init_loss_Plot(int prcentXmaxVal)
        {
            los_train_values = new double[train_values_max];
            los_SignalPlot = loss_formsPlot.Plot.AddSignal(los_train_values, label: "Loss Train");
            loss_formsPlot.Plot.SetAxisLimits(0, ((int)this.Epoches_numericUpDown.Value * prcentXmaxVal) / 100, 0, 2);
            loss_formsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);


        }
        void init_Accuracy_Plot(int prcentXmaxVal)
        {
            acc_train_values = new double[train_values_max];
            acc_SignalPlot = acc_formsPlot.Plot.AddSignal(acc_train_values, label: "Accuracy Train");
            acc_formsPlot.Plot.SetAxisLimits(0, ((int)this.Epoches_numericUpDown.Value * prcentXmaxVal) / 100, 0, 1);
            acc_formsPlot.Plot.Legend(location: ScottPlot.Alignment.UpperRight);


        }
        void update_Accuracy_Plot(double newVal)
        {
            double currentRightEdge = acc_formsPlot.Plot.GetAxisLimits().XMax;
            if (acc_NextPointIndex > currentRightEdge)
                acc_formsPlot.Plot.SetAxisLimits(xMax: currentRightEdge + ((int)this.Epoches_numericUpDown.Value * 10) / 100);
            acc_train_values[acc_NextPointIndex] = newVal;
            acc_SignalPlot.MaxRenderIndex = acc_NextPointIndex;
            acc_NextPointIndex += 1;
            acc_formsPlot.Refresh();

        }

        void update_loss_Plot(double newVal)
        {
            double currentRightEdge = loss_formsPlot.Plot.GetAxisLimits().XMax;
            if (los_NextPointIndex > currentRightEdge)
                loss_formsPlot.Plot.SetAxisLimits(xMax: currentRightEdge + ((int)this.Epoches_numericUpDown.Value * 10) / 100);

            los_train_values[los_NextPointIndex] = newVal;
            los_SignalPlot.MaxRenderIndex = los_NextPointIndex;
            los_NextPointIndex += 1;
            loss_formsPlot.Refresh();

        }
        void inti_negative_value()
        {

            int result = outputCount;

            identity2neuron["Negative".ToLower()] = result;

            neuron2identity[result] = "Negative".ToLower();

            outputCount++;

        }

        private void to_Train_Images_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
              e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 2)
                {

                }

                if (e.ColumnIndex == 3)
                {

                    this.TrainingSetList.RemoveAt(e.RowIndex);
                    this.to_Train_Images_dataGridView.Rows.Clear();
                    foreach (TrainingSet trainingSet in this.TrainingSetList)
                        this.to_Train_Images_dataGridView.Rows.Add(trainingSet.ImageName, trainingSet.Match, trainingSet.Image);
                    this.to_Train_Images_dataGridView.Refresh();


                }


            }

        }

        private void to_Train_Images_dataGridView_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
              e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 3)
                {

                    to_Train_Images_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;

                }



            }
        }

        private void to_Train_Images_dataGridView_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
              e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 3)
                {

                    to_Train_Images_dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;

                }



            }

        }

        private void Save_Train_Data_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileStream stream = new FileStream(folderDlg.SelectedPath + "/TrainingSetList.logosorterdataset", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, TrainingSetList);
                stream.Close();
            }


        }

        private void Load_Train_Data_Click(object sender, EventArgs e)
        {

            OpenFileDialog getdataset = new OpenFileDialog();

            getdataset.Filter = "logosorterdataset|*.logosorterdataset;";

            DialogResult result = getdataset.ShowDialog();

            if (result == DialogResult.OK)
            {

                FileStream stream = new FileStream(getdataset.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                IFormatter formatter = new BinaryFormatter();
                List<TrainingSet> TrainingSets = (List<TrainingSet>)formatter.Deserialize(stream);
                this.TrainingSetList = TrainingSets;
                this.to_Train_Images_dataGridView.Rows.Clear();
                outputCount = 0;
                identity2neuron.Clear();
                neuron2identity.Clear();
                inti_negative_value();
                foreach (TrainingSet trainingSet in this.TrainingSetList)
                {

                    this.to_Train_Images_dataGridView.Rows.Add(trainingSet.ImageName, trainingSet.Match, trainingSet.Image);
                    if (trainingSet.isLogo)
                    {

                        AssignIdentity(trainingSet.ImageName);

                    }

                }
                this.to_Train_Images_dataGridView.Refresh();


                stream.Close();
            }

        }
        private void Export_Model_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Model_name_textBox.Text) && this.Model != null)
            {

                if (!Directory.Exists("./Models"))
                {
                    Directory.CreateDirectory("./Models");
                    if (Model_name_textBox.Text.Contains('[') || Model_name_textBox.Text.Contains(']'))
                    {
                        MessageBox.Show(this, "Please choose other name that doesn´t contain one of the folowing charackters '[,]'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Model.save_weights("./Models/" + Model_name_textBox.Text + "[" + outputCount.ToString() + "].h5");
                        string json = JsonConvert.SerializeObject(neuron2identity);
                        File.WriteAllText("./Models/" + Model_name_textBox.Text + "[" + outputCount.ToString() + "].json", json);


                    }

                }
                else
                {
                    if (Model_name_textBox.Text.Contains('[') || Model_name_textBox.Text.Contains(']'))
                    {
                        MessageBox.Show(this, "Please choose other name that doesn´t contain one of the folowing charackters '[,]'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Model.save_weights("./Models/" + Model_name_textBox.Text + "[" + outputCount.ToString() + "].h5");
                        string json = JsonConvert.SerializeObject(neuron2identity);
                        File.WriteAllText("./Models/" + Model_name_textBox.Text + "[" + outputCount.ToString() + "].json", json);

                    }
                }



            }
        }


        #endregion

     
    }
    
}
