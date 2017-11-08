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
using System.Drawing;
using System.Windows.Interop;
using IWshRuntimeLibrary;



namespace Personal_Project
{
	/// <summary>
	/// Interaction logic for Settings.xaml
	/// </summary>
	public partial class Settings : Window
	{
		public Settings()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

        private void drop(object sender, DragEventArgs e)
        {
            string[] FilePaths = e.Data.GetData(DataFormats.FileDrop, true) as string[];
            foreach (string t in FilePaths)
            {
                if (t.EndsWith(".exe"))
                {
                    //BlockedAppMarker ba = new BlockedAppMarker();
                    //ba.AppPath = t;
                    //BlockedAppsContainer.Items.Add(ba);

                    IOGlobalHandler.AppBlockBuffer.Add(t);
                }
                else if (t.EndsWith(".lnk"))
                {
                    WshShell shell = new WshShell();
                    IWshShortcut lnk = (IWshShortcut)shell.CreateShortcut(t);
                    //BlockedAppMarker ba = new BlockedAppMarker();
                    //ba.AppPath = lnk.TargetPath;
                    //BlockedAppsContainer.Items.Add(ba);

                    IOGlobalHandler.AppBlockBuffer.Add(lnk.TargetPath);
                }
            }
            UpdateBlacklist();
        }

        private void UpdateBlacklist()
        {
            BlockedAppsContainer.Items.Clear();
            foreach (string t in IOGlobalHandler.AppBlockBuffer)
            {
                BlockedAppMarker ba = new BlockedAppMarker();
                ba.AppPath = t;
                ba.OnClick += (i, j) =>
                    {
                        IOGlobalHandler.AppBlockBuffer.Remove(t);
                        UpdateBlacklist();
                    };
                BlockedAppsContainer.Items.Add(ba);
                IOGlobalHandler.SaveBlockedApps();
            }

            if (IOGlobalHandler.AppBlockBuffer.Count >= 5)
            {
                noobfriendly.Foreground = new SolidColorBrush(Colors.Transparent);
            }
            else { noobfriendly.Foreground = new SolidColorBrush(Colors.DarkGray); }
        }

        private void load(object sender, RoutedEventArgs e)
        {
            UpdateBlacklist();
        }
	}
}