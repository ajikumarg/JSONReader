using System;
using System.Data;
using System.Text;
using System.IO;
using System.Linq;
using System.Collections.Generic;
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

        #region EventHandlers
        private void frmJSONReader_Load(object sender, EventArgs e)
        {
            this.txtStatus.Text = "";
        }
        private void chkSaveWithoutCalc_CheckedChanged(object sender, EventArgs e)
        {
            if (_notedc != null)
            {
                switch (this.chkSaveWithoutCalc.Checked)
                {
                    case true:
                        _notedc.SaveWithoutCalc = "Y";
                        break;

                    case false:
                        _notedc.SaveWithoutCalc = "N";
                        break;

                    default:
                        break;
                }
                WriteText("SaveWithoutCalc: " + _notedc.SaveWithoutCalc);
            }
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            string strFileName=string.Empty;
            OpenFileDialog oDialog = new OpenFileDialog();
            if(oDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                strFileName = oDialog.FileName;
                //MessageBox.Show(strFileName);
                this.lblFile.Text = strFileName;
            }

            ReadJSONFile(strFileName);
            WriteFutureFundingSchedule();

            //WriteText("SaveWithoutCalc: " + _notedc.SaveWithoutCalc);
            switch (_notedc.SaveWithoutCalc)
            {
                case "Y":
                    chkSaveWithoutCalc.Checked = true;
                    break;

                case "N":
                    chkSaveWithoutCalc.Checked = false;
                    break;

                default:
                    chkSaveWithoutCalc.Checked = false;
                    break;
            };

            //string Sch = Program.FundingSchedule(_notedc, new DateTime(2019, 11, 30));
            //WriteText(Sch);
                
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            RunNoteCalcCtlrCalcAndSave();
        }
        private void btnVSTO_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(lblFile.Text);
            CalcandSaveVSTOJson(json);
        }

        #endregion EventHandlers

        public GenericResult RunNoteCalcCtlrCalcAndSave()
        {
            string Url = "http://localhost:63477/";
            GenericResult _Result = null;
            //string json = File.ReadAllText(@"C:\Temp\9946.json");
            if (_notedc == null)
                _notedc = ReadJSONFile(lblFile.Text);

            WriteText(_notedc.SaveWithoutCalc);
            _notedc.SaveWithoutCalc = "N";

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
                            WriteText("Completed Successfully!");
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
        
        private NoteDataContract ReadJSONFile(string strFile)
        {
            //var obj = JsonConvert.DeserializeObject(strFile);
            _notedc = new NoteDataContract();

            string strJSON = File.ReadAllText(strFile);
            _notedc = JsonConvert.DeserializeObject<NoteDataContract>(strJSON);

            return _notedc;
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
                        WriteText(e.ToString());
                    }
                }
            }

            return _Result;
        }

        private void WriteFutureFundingSchedule()
        {
            string sffs = string.Empty;
            List<EffectiveDateList> EffList = _notedc.EffectiveDateList.Where(x => x.Type == "FFScheduleTab").ToList();
            
            foreach (EffectiveDateList eff in EffList)
            {
                sffs = Program.FundingSchedule(_notedc, eff.EffectiveDate);
                WriteText("\r\nEffective Date: " + eff.EffectiveDate.ToString());
                WriteText(sffs);
            }
        }

        private void WriteText(string text)
        {
            if(this.txtStatus.Text.Length == 0)
                txtStatus.Text += System.DateTime.Now.ToString() + "- " + text;
            else
                txtStatus.Text += "\r\n" + System.DateTime.Now.ToString("hh:mm:ss") + "- " + text;

        }


    }
}
