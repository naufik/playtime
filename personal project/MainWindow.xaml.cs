using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Personal_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Common operations
        private void ExitApp()
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            ExitApp();
        }

        private void Header_Drag(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                this.ResizeMode = System.Windows.ResizeMode.NoResize;
                this.UpdateLayout();
                this.DragMove();

                DispatcherTimer timer = new DispatcherTimer();
                timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
                timer.Tick += new EventHandler(Header_TimerTick);
                timer.IsEnabled = true;

            }
        }

        private void Header_TimerTick(object sender, EventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Released)
            {
                this.ResizeMode = System.Windows.ResizeMode.CanResizeWithGrip;
                this.UpdateLayout();
                ((DispatcherTimer)sender).IsEnabled = false;
            }
        }

        private void OpenSettings(object sender, System.Windows.RoutedEventArgs e)
        {
            Settings s = new Settings();
            s.Show();
        }

        private void TaskCreate(object sender, System.Windows.RoutedEventArgs e)
        {
            /**
           Task i = new Task();
           i.TaskName = new Random().Next(200).ToString();
           i.TaskTime = DateTime.Now;
           CurrentTasksBox.Items.Add(i);
            */

           NewTaskWindow win = new NewTaskWindow();
           win.Show();
           win.taskname.Focus();
        }
        public void RecreateScene()
        {
            CurrentTasksBox.Items.Clear();
            UpcomingTasksBox.Items.Clear();
            foreach (GlobalTask t in IOGlobalHandler.TaskBuffer)
            {
                
                if (t.RemindAt <= DateTime.Now)
                {
                    //Put the task into CURRENT
                    Task task = new Task();
                    task.TaskName = t.Entry;
                    task.TaskTime = t.RemindAt;
                    task.LinkedTask = t;
                    task.IsChecked = t.SubjectToDeletion;

                    CurrentTasksBox.Items.Add(task);
                }
                else
                {
                    //Put the task into FUTURE
                    FutureTask task = new FutureTask();
                    task.TaskName = t.Entry;
                    task.TaskTime = t.RemindAt;
                    task.LinkedTask = t;
                    task.IsChecked = t.SubjectToDeletion;
                    task.OnTaskTicked += (s, x) =>
                        {
                            //IOGlobalHandler.TaskBuffer.Remove(task.LinkedTask);
                        };
                    UpcomingTasksBox.Items.Add(task);
                }
            }
            IOGlobalHandler.SaveTasks();
        }

        private void form_initialize(object sender, EventArgs e)
        {
            IOGlobalHandler.FirstTimeIOInitialization();
            IOGlobalHandler.LoadBlockedApps();
            GlobalDispatcher.Initialize();
            RecreateScene();
        }

        
    }
}
