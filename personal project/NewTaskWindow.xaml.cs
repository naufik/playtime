using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personal_Project
{
	/// <summary>
	/// Interaction logic for NewTaskWindow.xaml
	/// </summary>
	public partial class NewTaskWindow : Window
	{
		public NewTaskWindow()
		{
			this.InitializeComponent();

            hourbox.Text = DateTime.Now.ToString("hh");
            minutebox.Text = DateTime.Now.ToString("mm");

            pm.IsChecked = (DateTime.Now.ToString("tt") == "PM" ? true : false);
            datepick.SelectedDate = DateTime.Now;
		}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Header_Drag(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void tbf(object sender, RoutedEventArgs e)
        {
            TextBox tt = (TextBox)sender;
            tt.Text = "";
        }

        private void hourlostfocus(object sender, RoutedEventArgs e)
        {
            TextBox tt = (TextBox)sender;
            if (tt.Text.Length == 1)
            {
                tt.Text = "0" + tt.Text;
            }
            if (tt.Text == "")
            {
                tt.Text = DateTime.Now.ToString("hh");
            }
            else if (Convert.ToInt32(tt.Text) > 12 || Convert.ToInt32(tt.Text) == 0)
            {
                tt.Text = "12";
            }

        }

        private void minutelostfocus(object sender, RoutedEventArgs e)
        {
            TextBox tt = (TextBox)sender;
            if (tt.Text.Length == 1)
            {
                tt.Text = "0" + tt.Text;
            }
            if (tt.Text == "")
            {
                tt.Text = DateTime.Now.ToString("mm");
            }
            else if (Convert.ToInt32(tt.Text) > 59)
            {
                tt.Text = "00";
            }
        }

        private void cm_pe(object sender, ExecutedRoutedEventArgs e)
        {
            if (e.Command == ApplicationCommands.Copy || e.Command == ApplicationCommands.Paste || e.Command == ApplicationCommands.Cut)
            {
                e.Handled = true;
            }
        }

        private void ptx(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void ebb(object sender, TextChangedEventArgs e)
        {
            if (((TextBox)sender).Text != "") 
            {
                OKbutton.IsEnabled = true;
            }
            else
            {
                OKbutton.IsEnabled = false;
            }
        }

        private void createTask(object sender, RoutedEventArgs e)
        {
            //Task t = new Task();
            //t.TaskName = taskname.Text;
            DateTime dt = (DateTime)datepick.SelectedDate;
            //t.TaskTime = new DateTime(dt.Year, dt.Month, dt.Day, Convert.ToInt32(hourbox.Text) + ((bool)pm.IsChecked ? 12 : 0), Convert.ToInt32(minutebox.Text), 0);
            GlobalTask t = new GlobalTask();
            t.RemindAt = new DateTime(dt.Year, dt.Month, dt.Day, Convert.ToInt32(hourbox.Text) + ((bool)pm.IsChecked ? 12 : 0) - ((Convert.ToInt32(hourbox.Text) == 12) ? 12: 0), Convert.ToInt32(minutebox.Text), 0);
            t.Entry = taskname.Text;
            

            IOGlobalHandler.TaskBuffer.Add(t);

            ((MainWindow)Application.Current.MainWindow).RecreateScene();
            //t.OnTaskTicked += (s, ev) =>
            //{
                //Turn on (Subject to Removal).
                //If possible -> add a fixed delay before removal time, not based on GlobalDispatcher.
                //((MainWindow)Application.Current.MainWindow).CurrentTasksBox.Items.Remove(t);
            //};
            this.Close();
        }
        

	}
}