using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personal_Project
{
    public class GlobalTask
    {
        public static List<GlobalTask> BUFFER = new List<GlobalTask>();

        public GlobalTask()
        {

        }

        public GlobalTask(bool std)
        {
            SubjectToDeletion = std;
        }

        public GlobalTask(string name, DateTime time)
        {
            Entry = name;
            RemindAt = time;
        }

        private string TN;
        private DateTime TT;
        private DateTime deletionIssued;
        private bool str;

        public string Entry
        {
            set
            {
                TN = value;
            }
            get
            {
                return TN;
            }
        }

        public DateTime RemindAt
        {
            set
            {
                TT = value;
            }
            get
            {
                return TT;
            }
        }

        public bool SubjectToDeletion
        {
            set
            {
                str = value;
            }
            get { return str; }
        }

        public DateTime DeletionIssued
        {
            set
            {
                deletionIssued= value;
            }
            get { return deletionIssued; }
        }
        
    }
}
