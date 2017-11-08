using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace Personal_Project
{
    // Not using automatic DataBinding is bad.

    // And I should feel bad.
    public class GlobalDispatcher
    { 
        private static DispatcherTimer GlobalTimer = new DispatcherTimer();
        public static void Initialize()
        {
            GlobalTimer.Interval = new TimeSpan(0, 0, 0, 2, 500);
            GlobalTimer.Tick += new EventHandler(GlobalDispatcher_Tick);
            GlobalTimer.IsEnabled = true;
        }

        private static void GlobalDispatcher_Tick(object sender, EventArgs e)
        {
            PurgeDeletable();
            DOOM();
            ((MainWindow)Application.Current.MainWindow).RecreateScene();
        }

        private static void PurgeDeletable()
        {
            foreach (GlobalTask t in IOGlobalHandler.TaskBuffer.ToList())
            {
                if (t.SubjectToDeletion && t.DeletionIssued.AddSeconds(15) < (DateTime.Now))
                {
                    IOGlobalHandler.TaskBuffer.Remove(t);
                }
                
            }
        }

        private static bool CheckCheck()
        {
            bool assumption = true;
            foreach (Task a in ((MainWindow)Application.Current.MainWindow).CurrentTasksBox.Items)
            {
                if (!a.IsChecked)
                {
                    assumption = false;
                    break;
                }
            }
            return assumption;
        }

        private static void DOOM()
        {

            foreach (string j in IOGlobalHandler.AppBlockBuffer)
            {
                Process[] alp = Process.GetProcessesByName(getProcessName(j));
                if (((MainWindow)Application.Current.MainWindow).CurrentTasksBox.Items.Count > 0 && !CheckCheck())
                {
                    foreach (Process p in alp)
                    {
                        try
                        {
                            if (IOGlobalHandler.AppBlockBuffer.Contains(string.Concat(p.Modules[0].FileName)))
                            {
                               p.Kill();
                                string tasks = "";
                                foreach (Task t in ((MainWindow)Application.Current.MainWindow).CurrentTasksBox.Items)
                                {
                                    tasks += "\n - " + t.LinkedTask.Entry;
                                }
                               System.Windows.MessageBox.Show("Please complete the following tasks before proceeding:" + tasks, "Playtime (is over)", MessageBoxButton.OK);
                               
                            }
                        }
                        catch (Exception) { }
                    }
                }
            }
            
            
        }

        private static string getProcessName(string t)
        {
            return Path.GetFileName(t).Replace(".exe", "");
        }


    }
}
