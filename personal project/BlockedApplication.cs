using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personal_Project
{
    public class BlockedApplication
    {
        private string fullpath;

        public string Path
        {
            set
            {
                fullpath = value;
            }
            get
            {
                return fullpath;
            }
        }
    }
}
