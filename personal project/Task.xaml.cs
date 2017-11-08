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
	/// <summary>
	/// Interaction logic for Task.xaml
	/// </summary>
	public partial class Task : UserControl
	{

		public Task()
		{
			this.InitializeComponent();
		}
        
        public static readonly RoutedEvent TaskTicked = EventManager.RegisterRoutedEvent("OnTaskTicked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Task));
        public static readonly RoutedEvent TaskUnticked = EventManager.RegisterRoutedEvent("OnTaskUnticked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(Task));
        public static readonly RoutedEvent TaskClicked = EventManager.RegisterRoutedEvent("OnTaskClick", RoutingStrategy.Bubble, typeof(RoutedEvent), typeof(Task));
        public static DependencyProperty PTaskName = DependencyProperty.Register("TaskName", typeof(string), typeof(Task));
        public static DependencyProperty PTaskTime = DependencyProperty.Register("TaskTime", typeof(DateTime), typeof(Task));
        public static DependencyProperty PLinkedTask = DependencyProperty.Register("LinkedTask", typeof(GlobalTask), typeof(Task));
        public static DependencyProperty PTaskChecked = DependencyProperty.Register("IsChecked", typeof(bool), typeof(Task));

        public string TaskName
        {
            set
            {
                base.SetValue(PTaskName, value);
            }
            get
            {
                return base.GetValue(PTaskName) as string;
            }
        }

        public DateTime TaskTime
        {
            set
            {
                base.SetValue(PTaskTime, value);
            }

            get
            {
                return (DateTime)base.GetValue(PTaskTime);
            }
        }

        public GlobalTask LinkedTask
        {
            set
            {
                base.SetValue(PLinkedTask, value);
            }
            get
            {
                return (GlobalTask)base.GetValue(PLinkedTask);
            }
        }
        public bool IsChecked
        {
            set
            {
                base.SetValue(PTaskChecked, value);
            }
            get
            {
                return (bool)base.GetValue(PTaskChecked);
            }
        }
        public event RoutedEventHandler OnTaskTicked
        {
            add
            {
                AddHandler(TaskTicked, value);
            }
            remove
            {
                RemoveHandler(TaskTicked, value);
            }
        }

        public event RoutedEventHandler OnTaskUnticked
        {
            add
            {
                AddHandler(TaskUnticked, value);
            }
            remove
            {
                RemoveHandler(TaskUnticked, value);
            }
        }

        public event RoutedEventHandler OnClick
        {
            add
            {
                AddHandler(TaskClicked, value);
            }
            remove
            {
                RemoveHandler(TaskClicked, value);
            }
        }

        
        private void chk(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(TaskTicked, this));
        }

        private void uchk(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(TaskUnticked, this));
        }

        private void issueDeletion()
        {
            LinkedTask.SubjectToDeletion = true;
            LinkedTask.DeletionIssued = DateTime.Now;
        }

        private void revokeDeletion()
        {
            LinkedTask.SubjectToDeletion = false;
        }

        private void click(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(TaskClicked, this));
            if (this.IsChecked)
            {
                issueDeletion();
            }
            else
            {
                revokeDeletion();
            }
        }

	}
}