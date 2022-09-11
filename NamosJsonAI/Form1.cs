using NamosJsonAI.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NamosJsonAI.Classes.appSettings;

namespace NamosJsonAI
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static string json = File.ReadAllText("appsettings.json");
        public dynamic jsonObj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
        public Form1()
        {
            InitializeComponent();
            LoadJsonFile();

        }

        private void LoadJsonFile()
        {
            txtDailyCheckConnectionString.Text = jsonObj["DailyCheckConnectionString"];
            txtDSSJsonFilePath.Text = jsonObj["DSSJsonFilePath"];
            txtHOConnectionString.Text = jsonObj["HOConnectionString"];
            txtPOSListFilePath.Text = jsonObj["POSListFilePath"];
            txtReplicationArticleCount.Text = jsonObj["ReplicationArticleCount"];
            txtMaxPOSCount.Text = jsonObj["MaxPOSCount"];

            //Fill Schedule Task Grid
            FillScheduleTasksGrid(jsonObj["ScheduleTasks"]);

            txtMaster_BOS_SQLServer.Text = jsonObj["Master_BOS_SQLServer"];
            txtMaster_SCO_SQLServer.Text = jsonObj["Master_SCO_SQLServer"];
            txtMasterFiles_BOSServer.Text = jsonObj["MasterFiles_BOSServer"];
            txtMasterFiles_POSServer.Text = jsonObj["MasterFiles_POSServer"];
            txtMasterFiles_SCOServer.Text = jsonObj["MasterFiles_SCOServer"];
            txtMasterNamosSTN.Text = jsonObj["MasterNamosSTN"];
            txtBOSConnectionString.Text = jsonObj["BOSConnectionString"];
            txtSCOConnectionString.Text = jsonObj["SCOConnectionString"];
            txtPOSConnectionString.Text = jsonObj["POSConnectionString"];

            //Fill Sercices Grid
            FillServicesGrid(jsonObj["Services"]);


        }

        private void gridScheduleTasks_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridScheduleTasks.SelectedRows)
            {
                txtTaskName.Text = row.Cells[0].Value.ToString();
                txtLocation.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "True")
                    chkScheduleTasks.Checked = true;
                else
                    chkScheduleTasks.Checked = false;
                if (row.Cells[3].Value == null)
                    txtExcludeSites.Text = "";
                else
                    txtExcludeSites.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnUpdateScheduleTasks_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridScheduleTasks.SelectedRows)
            {
                string taskNameSelected = row.Cells[0].Value.ToString();

                jsonObj["ScheduleTasks"][gridScheduleTasks.CurrentCell.RowIndex]["TaskName"] = txtTaskName.Text;
                jsonObj["ScheduleTasks"][gridScheduleTasks.CurrentCell.RowIndex]["Location"] = txtLocation.Text;
                jsonObj["ScheduleTasks"][gridScheduleTasks.CurrentCell.RowIndex]["Enabled"] = chkScheduleTasks.Checked;
                jsonObj["ScheduleTasks"][gridScheduleTasks.CurrentCell.RowIndex]["ExcludeSites"] = txtExcludeSites.Text;

                string[] authorInfo = txtExcludeSites.Text.Split(',');

                jsonObj["ScheduleTasks"][gridScheduleTasks.CurrentCell.RowIndex]["ExcludeSites"] = JArray.Parse("[]".ToString());


                for (int i = 0; i < authorInfo.Length; i++)
                {
                    jsonObj["ScheduleTasks"][gridScheduleTasks.CurrentCell.RowIndex]["ExcludeSites"].Add(authorInfo[i]);
                }

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                LoadJsonFile();
            }

        }

        private void btnAddScheduleTasks_Click(object sender, EventArgs e)
        {

            string[] authorInfo = txtExcludeSites.Text.Split(',');

            JArray jArray = new JArray();

            for (int i = 0; i < authorInfo.Length; i++)
            {
                jArray.Add(authorInfo[i]);
            }

            var newCompanyMember = "{ 'TaskName': '" + txtTaskName.Text + "','Location': '" + txtLocation.Text + "','Enabled': " + JsonConvert.SerializeObject(chkScheduleTasks.Checked) + ",'ExcludeSites': " + jArray + "}";
            try
            {
                var experienceArrary = jsonObj.GetValue("ScheduleTasks") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);

                jsonObj["ScheduleTasks"] = experienceArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                       Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", newJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }
            LoadJsonFile();

        }

        private void btnDeleteScheduleTasks_Click(object sender, EventArgs e)
        {
            try
            {
                JArray experiencesArrary = (JArray)jsonObj["ScheduleTasks"];
                Console.Write("Enter Company ID to Delete Company : ");
                var companyId = txtTaskName.Text;

                if (companyId != null)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["TaskName"].Value<string>() == companyId);

                    experiencesArrary.Remove(companyToDeleted);

                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText("appsettings.json", output);

                }
                else
                {
                    Console.Write("Invalid Company ID, Try Again!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            LoadJsonFile();

        }

        private void FillScheduleTasksGrid(dynamic ScheduleTasksFromJson)
        {

            List<ScheduleTask> scheduleTasks = new List<ScheduleTask>();

            foreach (var item in ScheduleTasksFromJson)
            {
                ScheduleTask scheduleTasks1 = new ScheduleTask();
                List<string> excludeSitesList = new List<string>();
                scheduleTasks1.TaskName = (string)item["TaskName"];
                scheduleTasks1.Location = (string)item["Location"];
                scheduleTasks1.Enabled = (bool)item["Enabled"];
                if (item["ExcludeSites"] == null)
                    scheduleTasks1.ExcludeSites = null;
                else
                {
                    int listCount = item["ExcludeSites"].Count;
                    foreach (string items in item["ExcludeSites"])
                    {
                        if (listCount == 1)
                            scheduleTasks1.ExcludeSites += items;
                        else
                        {
                            scheduleTasks1.ExcludeSites += items + ",";
                            listCount--;
                        }
                    }

                }
                scheduleTasks.Add(scheduleTasks1);
            }

            gridScheduleTasks.DataSource = scheduleTasks;
            gridScheduleTasks.Columns[3].Width = 400;
            gridScheduleTasks.Columns[0].Width = 150;
        }

        private void FillServicesGrid(dynamic ServicesFromJson)
        {
            List<Service> services = new List<Service>();

            foreach (var item in ServicesFromJson)
            {
                Service service = new Service();
                List<string> excludeSitesList = new List<string>();
                service.ServiceDisplay = (string)item["ServiceDisplay"];
                service.ServiceName = (string)item["ServiceName"];
                service.Location = (string)item["Location"];
                service.Enabled = (bool)item["Enabled"];
                if (item["ExcludeSites"] == null)
                    service.ExcludeSites = null;
                else
                {
                    int listCount = item["ExcludeSites"].Count;
                    foreach (string items in item["ExcludeSites"])
                    {
                        if (listCount == 1)
                            service.ExcludeSites += items;
                        else
                        {
                            service.ExcludeSites += items + ",";
                            listCount--;
                        }
                    }

                }
                services.Add(service);
            }

            gridServices.DataSource = services;
            gridServices.Columns[0].Width = 200;
            gridServices.Columns[1].Width = 200;
        }


        private void btnUpdateConnection_Click(object sender, EventArgs e)
        {
            jsonObj["ReplicationArticleCount"] = Convert.ToInt32(txtReplicationArticleCount.Text);
            jsonObj["Master_BOS_SQLServer"] = txtMaster_BOS_SQLServer.Text;
            jsonObj["Master_SCO_SQLServer"] = txtMaster_SCO_SQLServer.Text;
            jsonObj["MasterFiles_BOSServer"] = txtMasterFiles_BOSServer.Text;
            jsonObj["MasterFiles_POSServer"] = txtMasterFiles_POSServer.Text;
            jsonObj["MasterFiles_SCOServer"] = txtMasterFiles_SCOServer.Text;
            jsonObj["MasterNamosSTN"] = txtMasterNamosSTN.Text;
            jsonObj["BOSConnectionString"] = txtBOSConnectionString.Text;
            jsonObj["SCOConnectionString"] = txtSCOConnectionString.Text;
            jsonObj["POSConnectionString"] = txtPOSConnectionString.Text;

            string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("appsettings.json", output);

            LoadJsonFile();
        }

        private void gridServices_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridServices.SelectedRows)
            {
                txtServiceDisplay.Text = row.Cells[0].Value.ToString();
                txtServiceName.Text = row.Cells[1].Value.ToString();
                txtServicesLocation.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "True")
                    chkServicesEnable.Checked = true;
                else
                    chkServicesEnable.Checked = false;
                if (row.Cells[4].Value == null)
                    txtServicesExcludeSites.Text = "";
                else
                    txtServicesExcludeSites.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnAddServices_Click(object sender, EventArgs e)
        {
            string[] authorInfo = txtServicesExcludeSites.Text.Split(',');

            JArray jArray = new JArray();

            for (int i = 0; i < authorInfo.Length; i++)
            {
                jArray.Add(authorInfo[i]);
            }

            var newCompanyMember = "{ 'ServiceDisplay': '" + txtServiceDisplay.Text + "','ServiceName': '" + txtServiceName.Text + "','Location': '" + txtServicesLocation.Text + "','Enabled': " + JsonConvert.SerializeObject(chkServicesEnable.Checked) + ",'ExcludeSites': " + jArray + "}";
            try
            {
                var experienceArrary = jsonObj.GetValue("Services") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);

                jsonObj["Services"] = experienceArrary;
                string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj,
                                       Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", newJsonResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Add Error : " + ex.Message.ToString());
            }
            LoadJsonFile();
        }

        private void btnUpdateServices_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridServices.SelectedRows)
            {
                jsonObj["Services"][gridServices.CurrentCell.RowIndex]["ServiceDisplay"] = txtServiceDisplay.Text;
                jsonObj["Services"][gridServices.CurrentCell.RowIndex]["ServiceName"] = txtServiceName.Text;
                jsonObj["Services"][gridServices.CurrentCell.RowIndex]["Location"] = txtServicesLocation.Text;
                jsonObj["Services"][gridServices.CurrentCell.RowIndex]["Enabled"] = chkServicesEnable.Checked;
                jsonObj["Services"][gridServices.CurrentCell.RowIndex]["ExcludeSites"] = txtServicesExcludeSites.Text;

                string[] authorInfo = txtServicesExcludeSites.Text.Split(',');

                jsonObj["Services"][gridServices.CurrentCell.RowIndex]["ExcludeSites"] = JArray.Parse("[]".ToString());


                for (int i = 0; i < authorInfo.Length; i++)
                {
                    jsonObj["Services"][gridServices.CurrentCell.RowIndex]["ExcludeSites"].Add(authorInfo[i]);
                }

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                LoadJsonFile();
            }
        }

        private void btnDeteteServices_Click(object sender, EventArgs e)
        {
            try
            {
                JArray experiencesArrary = (JArray)jsonObj["Services"];
                var companyId = txtServiceName.Text;

                if (companyId != null)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["ServiceName"].Value<string>() == companyId);

                    experiencesArrary.Remove(companyToDeleted);

                    string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText("appsettings.json", output);

                }
                else
                {
                    Console.Write("Invalid Company ID, Try Again!");
                }
            }
            catch (Exception)
            {
                throw;
            }
            LoadJsonFile();
        }
    }
}
