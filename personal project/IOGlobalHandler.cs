using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Personal_Project
{
    class IOGlobalHandler
    {
        public static string DataPATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"PlayTime");
        private static string TasksPATH = Path.Combine(DataPATH, "tasks.xml");
        private static string AppsPATH = Path.Combine(DataPATH, "blockedapps.xml");
        public static List<GlobalTask> TaskBuffer = new List<GlobalTask>();
        public static List<string> AppBlockBuffer = new List<string>();
        
        public static void LoadTasks()
        {
            TaskBuffer.Clear();  
            if (File.Exists(TasksPATH))
            {
                using (XmlReader reader = XmlReader.Create(TasksPATH))
                {
                    try
                    {
                        while (reader.Read())
                        {
                            if (reader.IsStartElement() && reader.Name == "task")
                            {

                                GlobalTask t = new GlobalTask();
                                while (reader.MoveToNextAttribute())
                                {
                                    switch (reader.Name)
                                    {
                                        case "entry":
                                            t.Entry = reader.Value;
                                            break;

                                    }
                                }

                                while (reader.Read())
                                {
                                    if (reader.IsStartElement())
                                    {
                                        switch (reader.Name)
                                        {
                                            case "date":
                                                if (reader.Read())
                                                {
                                                    string unparsed = reader.Value;
                                                    string[] sv = unparsed.Split(':');
                                                    DateTime d = new DateTime(Convert.ToInt32(sv[0]), Convert.ToInt32(sv[1]), Convert.ToInt32(sv[2]), Convert.ToInt32(sv[3]), Convert.ToInt32(sv[4]), 0);
                                                    t.RemindAt = d;
                                                }
                                                break;
                                            case "done":
                                                if (reader.Read())
                                                {
                                                    t.SubjectToDeletion = (reader.Value.ToLower() == "true" ? true : false);
                                                }
                                                break;
                                        }
                                    } else if (reader.MoveToContent() == XmlNodeType.EndElement && reader.Name == "task")
                                    {
                                        break;
                                    }
                                }

                                
                                TaskBuffer.Add(t);
                            }
                            
                        }
                    }
                    finally { }
                }
            }
            else
            {
                InitializeForFirstTime();
            }
        }

        private static void InitializeForFirstTime()
        {
            using (XmlWriter writer = XmlWriter.Create(TasksPATH))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("tasks");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
            using (XmlWriter writer = XmlWriter.Create(AppsPATH))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("placeholder");
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }
        
        public static void SaveTasks()
        {
            using (XmlWriter writer = XmlWriter.Create(TasksPATH))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("tasks");
                foreach (GlobalTask t in TaskBuffer)
                {
                    writer.WriteStartElement("task");
                    writer.WriteAttributeString("entry", t.Entry);
                    writer.WriteElementString("date", t.RemindAt.ToString("yyyy:MM:dd:HH:mm"));
                    writer.WriteElementString("done", t.SubjectToDeletion.ToString());
                    writer.WriteEndElement();

                }
                writer.WriteEndDocument();
                writer.Flush();
                writer.Close();
            }
        }
        public static bool FirstTimeIOInitialization()
        { 
            if (!Directory.Exists(DataPATH))
            {
                Directory.CreateDirectory(DataPATH);
                return true;
            } else
            {
                LoadTasks();
                return false;
            }
        }
        public static void PurgeSubjectToDeletion()
        {
            foreach (GlobalTask t in TaskBuffer)
            {
                if (t.SubjectToDeletion == true)
                {
                    TaskBuffer.Remove(t);
                }
            }
        }

        public static void LoadBlockedApps()
        {
            using (XmlReader reader = XmlReader.Create(AppsPATH))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement() && reader.Name == "block")
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            switch (reader.Name)
                            {
                                case "path":
                                    AppBlockBuffer.Add(reader.Value);
                                    break;
                            }
                        }
                    }
                }
            }
        }
        public static void SaveBlockedApps()
        {
            using (XmlWriter writer = XmlWriter.Create(AppsPATH))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("blocked-apps");
                foreach (string ng in AppBlockBuffer)
                {
                    writer.WriteStartElement("block");
                    writer.WriteAttributeString("path", ng);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }

    }
}
