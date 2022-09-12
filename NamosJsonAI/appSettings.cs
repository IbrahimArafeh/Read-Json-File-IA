using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamosJsonAI.Classes
{
    internal class appSettings
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class DBCompareData
        {
            public string Location { get; set; }
            public string DB { get; set; }
            public string IgnoreObjects { get; set; }
            public bool Enabled { get; set; }
            public string ExcludeSites { get; set; }
        }

        public class DssControl
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Enabled { get; set; }
        }

        public class EpiCheckControl
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Enabled { get; set; }
        }

        public class EPISetting
        {
            public string Table { get; set; }
            public string KeyValueQuery { get; set; }
            public List<string> ExcludeKeys { get; set; }
            public List<object> ExcludeSites { get; set; }
            public bool Enabled { get; set; }
        }

        public class FilesCompare
        {
            public string Location { get; set; }
            public string Type { get; set; }
            public string Path { get; set; }
            public string Extensions { get; set; }
            public bool Enabled { get; set; }
            public string ExcludeSites { get; set; }
        }

        public class MainCheckControl
        {
            public int Id { get; set; }
            public string Description { get; set; }
            public bool Enabled { get; set; }
            public List<object> ExcludeSites { get; set; }
            public bool SaveInDB { get; set; }
        }

        public class NamosCheckControl
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public bool Enabled { get; set; }
        }

        public class Root
        {
            public string DailyCheckConnectionString { get; set; }
            public string DSSJsonFilePath { get; set; }
            public string HOConnectionString { get; set; }
            public string POSListFilePath { get; set; }
            public int ReplicationArticleCount { get; set; }
            public string MaxPOSCount { get; set; }
            public List<ScheduleTask> ScheduleTasks { get; set; }
            public List<Service> Services { get; set; }
            public List<SQLScript> SQLScripts { get; set; }
            public List<SQLJob> SQLJobs { get; set; }
            public List<DBCompareData> DBCompareData { get; set; }
            public List<FilesCompare> FilesCompare { get; set; }
            public string Master_BOS_SQLServer { get; set; }
            public string Master_SCO_SQLServer { get; set; }
            public string MasterFiles_BOSServer { get; set; }
            public string MasterFiles_POSServer { get; set; }
            public string MasterFiles_SCOServer { get; set; }
            public string MasterNamosSTN { get; set; }
            public string BOSConnectionString { get; set; }
            public string SCOConnectionString { get; set; }
            public string POSConnectionString { get; set; }
            public List<MainCheckControl> MainCheckControl { get; set; }
            public List<DssControl> DssControl { get; set; }
            public List<EpiCheckControl> EpiCheckControl { get; set; }
            public List<NamosCheckControl> NamosCheckControl { get; set; }
            public List<string> HOSSyncTablesList { get; set; }
            public List<EPISetting> EPISettings { get; set; }
        }

        public class ScheduleTask
        {
            public string TaskName { get; set; }
            public string Location { get; set; }
            public bool Enabled { get; set; }
            public string ExcludeSites { get; set; }
        }

        public class Service
        {
            public string ServiceDisplay { get; set; }
            public string ServiceName { get; set; }
            public string Location { get; set; }
            public bool Enabled { get; set; }
            public string ExcludeSites { get; set; }
        }

        public class SQLJob
        {
            public string JobName { get; set; }
            public string Location { get; set; }
            public bool Enabled { get; set; }
            public string ExcludeSites { get; set; }
        }

        public class SQLScript
        {
            public string Name { get; set; }
            public string Path { get; set; }
        }
    }
}
