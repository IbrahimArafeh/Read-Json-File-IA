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

            //Fill SQLScripts Grid
            FillSqlScriptsGrid(jsonObj["SQLScripts"]);

            //Fill SQLJobs Grid
            FillSqlJobsGrid(jsonObj["SQLJobs"]);

            //Fill SQLJobs Grid
            FillDbCompareDataGrid(jsonObj["DBCompareData"]);   
            
            //Fill File Compare Grid
            FillFileCompareGrid(jsonObj["FilesCompare"]);
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

        #region Fill Grids
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

        private void FillSqlScriptsGrid(dynamic SqlScriptsFromJson)
        {
            List<SQLScript> sqlScript = new List<SQLScript>();

            foreach (var item in SqlScriptsFromJson)
            {
                SQLScript sqlscript = new SQLScript();

                sqlscript.Name = (string)item["Name"];
                sqlscript.Path = (string)item["Path"];

                sqlScript.Add(sqlscript);
            }

            gridSqlScripts.DataSource = sqlScript;
            gridSqlScripts.Columns[0].Width = 300;
            gridSqlScripts.Columns[1].Width = 300;
        }

        private void FillSqlJobsGrid(dynamic SqlJobsFromJson)
        {
            List<SQLJob> scheduleTasks = new List<SQLJob>();

            foreach (var item in SqlJobsFromJson)
            {
                SQLJob sqlJob1 = new SQLJob();
                List<string> excludeSitesList = new List<string>();
                sqlJob1.JobName = (string)item["JobName"];
                sqlJob1.Location = (string)item["Location"];
                sqlJob1.Enabled = (bool)item["Enabled"];
                if (item["ExcludeSites"] == null)
                    sqlJob1.ExcludeSites = null;
                else
                {
                    int listCount = item["ExcludeSites"].Count;
                    foreach (string items in item["ExcludeSites"])
                    {
                        if (listCount == 1)
                            sqlJob1.ExcludeSites += items;
                        else
                        {
                            sqlJob1.ExcludeSites += items + ",";
                            listCount--;
                        }
                    }
                }
                scheduleTasks.Add(sqlJob1);
            }

            gridSQLJobs.DataSource = scheduleTasks;
            gridSQLJobs.Columns[3].Width = 300;
            gridSQLJobs.Columns[0].Width = 150;
        }

        private void FillDbCompareDataGrid(dynamic ServicesFromJson)
        {
            List<DBCompareData> services = new List<DBCompareData>();

            foreach (var item in ServicesFromJson)
            {
                DBCompareData service = new DBCompareData();
                List<string> excludeSitesList = new List<string>();
                service.Location = (string)item["Location"];
                service.DB = (string)item["DB"];
                //service.Location = (string)item["Location"];
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
                if (item["IgnoreObjects"] == null)
                    service.IgnoreObjects = null;
                else
                {
                    int listCount2 = item["IgnoreObjects"].Count;
                    foreach (string items in item["IgnoreObjects"])
                    {
                        if (listCount2 == 1)
                            service.IgnoreObjects += items;
                        else
                        {
                            service.IgnoreObjects += items + ",";
                            listCount2--;
                        }
                    }

                }
                services.Add(service);
            }

            gridDbCompareData.DataSource = services;
            gridDbCompareData.Columns[2].Width = 250;
            gridDbCompareData.Columns[4].Width = 100;
        }
        private void FillFileCompareGrid(dynamic ServicesFromJson)
        {
            List<FilesCompare> services = new List<FilesCompare>();

            foreach (var item in ServicesFromJson)
            {
                FilesCompare service = new FilesCompare();
                List<string> excludeSitesList = new List<string>();

                service.Location = (string)item["Location"];
                service.Type = (string)item["Type"];
                service.Path = (string)item["Path"];
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
                if (item["Extensions"] == null)
                    service.Extensions = null;
                else
                {
                    int listCount2 = item["Extensions"].Count;
                    foreach (string items in item["Extensions"])
                    {
                        if (listCount2 == 1)
                            service.Extensions += items;
                        else
                        {
                            service.Extensions += items + ",";
                            listCount2--;
                        }
                    }

                }
                services.Add(service);
            }

            gridFilesCompare.DataSource = services;
            gridFilesCompare.Columns[2].Width = 250;
            gridFilesCompare.Columns[3].Width = 75;
        }
        #endregion
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

        private void gridSqlScripts_SelectionChanged_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in gridSqlScripts.SelectedRows)
            {
                txtSqlScriptsName.Text = row.Cells[0].Value.ToString();
                txtSqlScriptsPath.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnAddSqlScripts_Click_1(object sender, EventArgs e)
        {
            JArray jArray = new JArray();

            var newCompanyMember = "{ 'Name': '" + txtSqlScriptsName.Text + "','Path': '" + txtSqlScriptsPath.Text + "'}";
            try
            {
                var experienceArrary = jsonObj.GetValue("SQLScripts") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);

                jsonObj["SQLScripts"] = experienceArrary;
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

        private void btnUpdateSqlScripts_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridSqlScripts.SelectedRows)
            {
                jsonObj["SQLScripts"][gridSqlScripts.CurrentCell.RowIndex]["Name"] = txtSqlScriptsName.Text;
                jsonObj["SQLScripts"][gridSqlScripts.CurrentCell.RowIndex]["Path"] = txtSqlScriptsPath.Text;


                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                LoadJsonFile();
            }
        }

        private void btnDeleteSqlScripts_Click_1(object sender, EventArgs e)
        {
            try
            {
                JArray experiencesArrary = (JArray)jsonObj["SQLScripts"];
                var companyId = txtSqlScriptsName.Text;

                if (companyId != null)
                {
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["Name"].Value<string>() == companyId);

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

        private void gridSQLJobs_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridSQLJobs.SelectedRows)
            {
                txtSqlJobJobName.Text = row.Cells[0].Value.ToString();
                txtSqlJobocation.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "True")
                    chkSqlJobsEnable.Checked = true;
                else
                    chkSqlJobsEnable.Checked = false;
                if (row.Cells[3].Value == null)
                    txtSqlJobExcludeSites.Text = "";
                else
                    txtSqlJobExcludeSites.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnAddSqlJob_Click(object sender, EventArgs e)
        {
            string[] authorInfo = txtSqlJobExcludeSites.Text.Split(',');

            JArray jArray = new JArray();

            for (int i = 0; i < authorInfo.Length; i++)
            {
                jArray.Add(authorInfo[i]);
            }

            var newCompanyMember = "{ 'JobName': '" + txtSqlJobJobName.Text + "','Location': '" + txtSqlJobocation.Text + "','Enabled': " + JsonConvert.SerializeObject(chkSqlJobsEnable.Checked) + ",'ExcludeSites': " + jArray + "}";
            try
            {
                var experienceArrary = jsonObj.GetValue("SQLJobs") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);

                jsonObj["SQLJobs"] = experienceArrary;
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

        private void btnUpdateSqlJob_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridSQLJobs.SelectedRows)
            {
                string taskNameSelected = row.Cells[0].Value.ToString();

                jsonObj["SQLJobs"][gridSQLJobs.CurrentCell.RowIndex]["JobName"] = txtSqlJobJobName.Text;
                jsonObj["SQLJobs"][gridSQLJobs.CurrentCell.RowIndex]["Location"] = txtSqlJobocation.Text;
                jsonObj["SQLJobs"][gridSQLJobs.CurrentCell.RowIndex]["Enabled"] = chkSqlJobsEnable.Checked;
                jsonObj["SQLJobs"][gridSQLJobs.CurrentCell.RowIndex]["ExcludeSites"] = txtSqlJobExcludeSites.Text;

                string[] authorInfo = txtSqlJobExcludeSites.Text.Split(',');

                jsonObj["SQLJobs"][gridSQLJobs.CurrentCell.RowIndex]["ExcludeSites"] = JArray.Parse("[]".ToString());


                for (int i = 0; i < authorInfo.Length; i++)
                {
                    jsonObj["SQLJobs"][gridSQLJobs.CurrentCell.RowIndex]["ExcludeSites"].Add(authorInfo[i]);
                }

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                LoadJsonFile();
            }
        }

        private void btnDeleteSqlJob_Click(object sender, EventArgs e)
        {
            try
            {
                JArray experiencesArrary = (JArray)jsonObj["SQLJobs"];

                var companyId = txtSqlJobJobName.Text;

                if (companyId != null)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["JobName"].Value<string>() == companyId);

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

        private void gridDbCompareData_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridDbCompareData.SelectedRows)
            {
                txtDBCompateDataLocation.Text = row.Cells[0].Value.ToString();
                txtDbCompateDataDB.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value == null)
                    txtDbCompateDataIgnoreObjects.Text = "";
                else
                    txtDbCompateDataIgnoreObjects.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString() == "True")
                    chkDbCompareDataEnable.Checked = true;
                else
                    chkDbCompareDataEnable.Checked = false;
                if (row.Cells[4].Value == null)
                    txtDbCompareDataExcludeSites.Text = "";
                else
                    txtDbCompareDataExcludeSites.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnAddDbCompareData_Click(object sender, EventArgs e)
        {
            string[] authorInfo = txtDbCompateDataIgnoreObjects.Text.Split(',');
            string[] authorInfo2 = txtDbCompareDataExcludeSites.Text.Split(',');

            JArray jArray = new JArray();
            JArray jArray2 = new JArray();

            for (int i = 0; i < authorInfo.Length; i++)
            {
                jArray.Add(authorInfo[i]);
            }

            for (int i = 0; i < authorInfo2.Length; i++)
            {
                jArray2.Add(authorInfo2[i]);
            }

            var newCompanyMember = "{ 'Location': '" + txtDBCompateDataLocation.Text + "','DB': '" + txtDbCompateDataDB.Text + "','IgnoreObjects': " + jArray + ",'Enabled': " + JsonConvert.SerializeObject(chkDbCompareDataEnable.Checked) + ",'ExcludeSites': " + jArray2 + "}";
            ;
            try
            {
                var experienceArrary = jsonObj.GetValue("DBCompareData") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);

                jsonObj["DBCompareData"] = experienceArrary;
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

        private void btnUpdateDbCompareData_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridDbCompareData.SelectedRows)
            {
                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["Location"] = txtDBCompateDataLocation.Text;
                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["DB"] = txtDbCompateDataDB.Text;
                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["IgnoreObjects"] = txtDbCompateDataIgnoreObjects.Text;
                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["Enabled"] = chkDbCompareDataEnable.Checked;
                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["ExcludeSites"] = txtDbCompareDataExcludeSites.Text;

                string[] authorInfo = txtDbCompateDataIgnoreObjects.Text.Split(',');
                string[] authorInfo2 = txtDbCompareDataExcludeSites.Text.Split(',');

                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["IgnoreObjects"] = JArray.Parse("[]".ToString());
                jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["ExcludeSites"] = JArray.Parse("[]".ToString());


                for (int i = 0; i < authorInfo.Length; i++)
                {
                    jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["IgnoreObjects"].Add(authorInfo[i]);
                }

                for (int i = 0; i < authorInfo2.Length; i++)
                {
                    jsonObj["DBCompareData"][gridDbCompareData.CurrentCell.RowIndex]["ExcludeSites"].Add(authorInfo2[i]);
                }

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                LoadJsonFile();
            }
        }

        private void btnDeleteDbCompareData_Click(object sender, EventArgs e)
        {
            try
            {
                JArray experiencesArrary = (JArray)jsonObj["DBCompareData"];
                var companyId = txtDbCompateDataDB.Text;

                if (companyId != null)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["DB"].Value<string>() == companyId);

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

        private void gridFilesCompare_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridFilesCompare.SelectedRows)
            {
                txtFilesCompareLocation.Text = row.Cells[0].Value.ToString();
                txtFilesCompareType.Text = row.Cells[1].Value.ToString();
                txtFileComparePath.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value == null)
                    txtFileCompareExtensions.Text = "";
                else
                    txtFileCompareExtensions.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "True")
                    chkFilesCompareEnable.Checked = true;
                else
                    chkFilesCompareEnable.Checked = false;
                if (row.Cells[5].Value == null)
                    txtFileCompareExcludeSites.Text = "";
                else
                    txtFileCompareExcludeSites.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnAddFileCompare_Click(object sender, EventArgs e)
        {
            string[] authorInfo = txtFileCompareExtensions.Text.Split(',');
            string[] authorInfo2 = txtFileCompareExcludeSites.Text.Split(',');

            JArray jArray = new JArray();
            JArray jArray2 = new JArray();

            for (int i = 0; i < authorInfo.Length; i++)
            {
                jArray.Add(authorInfo[i]);
            }

            for (int i = 0; i < authorInfo2.Length; i++)
            {
                jArray2.Add(authorInfo2[i]);
            }

            var newCompanyMember = "{ 'Location': '" + txtFilesCompareLocation.Text + "','Type': '" + txtFilesCompareType.Text + "','Path': '" + txtFileComparePath.Text + "','Extensions': " + jArray + ",'Enabled': " + JsonConvert.SerializeObject(chkFilesCompareEnable.Checked) + ",'ExcludeSites': " + jArray2 + "}";
            ;
            try
            {
                var experienceArrary = jsonObj.GetValue("FilesCompare") as JArray;
                var newCompany = JObject.Parse(newCompanyMember);
                experienceArrary.Add(newCompany);

                jsonObj["FilesCompare"] = experienceArrary;
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

        private void btnUpdateFileCompare_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in gridFilesCompare.SelectedRows)
            {
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Location"] = txtFilesCompareLocation.Text;
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Type"] = txtFilesCompareType.Text;
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Path"] = txtFileComparePath.Text;
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Extensions"] = txtFileCompareExtensions.Text;
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Enabled"] = chkFilesCompareEnable.Checked;
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["ExcludeSites"] = txtFileCompareExcludeSites.Text;

                string[] authorInfo = txtFileCompareExtensions.Text.Split(',');
                string[] authorInfo2 = txtFileCompareExcludeSites.Text.Split(',');

                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Extensions"] = JArray.Parse("[]".ToString());
                jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["ExcludeSites"] = JArray.Parse("[]".ToString());


                for (int i = 0; i < authorInfo.Length; i++)
                {
                    jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["Extensions"].Add(authorInfo[i]);
                }

                for (int i = 0; i < authorInfo2.Length; i++)
                {
                    jsonObj["FilesCompare"][gridFilesCompare.CurrentCell.RowIndex]["ExcludeSites"].Add(authorInfo2[i]);
                }

                string output = Newtonsoft.Json.JsonConvert.SerializeObject(jsonObj, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("appsettings.json", output);

                LoadJsonFile();
            }
        }

        private void btnDeleteFileCompare_Click(object sender, EventArgs e)
        {
            try
            {
                JArray experiencesArrary = (JArray)jsonObj["FilesCompare"];
                var companyId = txtFileComparePath.Text;

                if (companyId != null)
                {
                    var companyName = string.Empty;
                    var companyToDeleted = experiencesArrary.FirstOrDefault(obj => obj["Path"].Value<string>() == companyId);

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
