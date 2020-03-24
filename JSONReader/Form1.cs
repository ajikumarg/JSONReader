using System;
using System.Data;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using CRES.DataContract;

namespace JSONReader
{
    public partial class frmJSONReader : Form
    {
        private string strLabelOrigText;
        private DataTable dtJSON;
        private NoteDataContract _notedc;

        public frmJSONReader()
        {
            InitializeComponent();
            this.strLabelOrigText = lblFile.Text;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog oDialog = new OpenFileDialog();
            if(oDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string strFileName = oDialog.FileName;
                //MessageBox.Show(strFileName);
                this.lblFile.Text = strFileName;
            }
        }
        private void btnReadJson_Click(object sender, EventArgs e)
        {
            if (lblFile.Text == string.Empty)
            {
                MessageBox.Show("Select a file by clicking on Browse!e");
                return;
            }
            dtJSON = new DataTable("JSON");
            string strJSON = File.ReadAllText(lblFile.Text);

            try
            {
                dtJSON = JsonConvert.DeserializeObject<DataTable>(strJSON);
                this.dgView.DataSource = dtJSON;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private NoteDataContract ReadJSONFile(string strFile)
        {
            //var obj = JsonConvert.DeserializeObject(strFile);
            NoteDataContract _notedc = new NoteDataContract();

            string strJSON = File.ReadAllText(strFile);
            _notedc = JsonConvert.DeserializeObject<NoteDataContract>(strJSON);
 
            return _notedc;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunNoteCalcCtlrCalcAndSave();
        }
        public GenericResult RunNoteCalcCtlrCalcAndSave()
        {
            string Url = "http://localhost:63477/";
            GenericResult _Result = null;
            //string json = File.ReadAllText(@"C:\Temp\9946.json");
            if(_notedc == null)
                _notedc = ReadJSONFile(lblFile.Text);

            if (_notedc != null)
            {
                string apiPath = "api/note/CalculateNoteAndSaveByNoteID";
                //string serializeJSON = JsonConvert.SerializeObject(json);
                using (var client = new HttpClient())
                {
                    //var res = client.PostAsync(Url + apiPath, new StringContent(serializeJSON, Encoding.UTF8, "application/json"));
                    var res = client.PostAsJsonAsync(Url + apiPath, _notedc);
                    try
                    {
                        HttpResponseMessage response1 = res.Result.EnsureSuccessStatusCode();
                        if (response1.IsSuccessStatusCode)
                        {
                            // Add code
                        }
                    }
                    catch (System.Exception e)
                    {
                        _Result = new GenericResult()
                        {
                            Succeeded = false,
                            Message = e.StackTrace

                        };
                        System.Console.WriteLine(e.ToString());
                    }
                }
            }

            return _Result;
        }

        private void btnVSTO_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(lblFile.Text);
            CalcandSaveVSTOJson(json);
        }
        
        public GenericResult CalcandSaveVSTOJson(string json)
        {
            string Url = "http://localhost:23550/";
            GenericResult _Result = null;

            if (json != null)
            {
                string apiPath = "api/VSTO/CalcandSaveVSTOJson";
                string serializeJSON = JsonConvert.SerializeObject(json);
                using (var client = new HttpClient())
                {
                    var res = client.PostAsync(Url + apiPath, new StringContent(serializeJSON, Encoding.UTF8, "application/json"));
                    try
                    {
                        HttpResponseMessage response1 = res.Result.EnsureSuccessStatusCode();
                        if (response1.IsSuccessStatusCode)
                        {
                            _Result = new GenericResult()
                            {
                                Succeeded = true,
                            };
                        }
                    }
                    catch (Exception e)
                    {
                        _Result = new GenericResult()
                        {
                            Succeeded = false,
                            Message = e.StackTrace

                        };
                        Console.WriteLine(e.ToString());
                    }
                }
            }

            return _Result;
        }
    }
}
