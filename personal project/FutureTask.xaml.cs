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
	/// Interaction logic for FutureTask.xaml
	/// </summary>
	public partial class FutureTask : UserControl
	{
        public static readonly RoutedEvent TaskClicked = EventManager.RegisterRoutedEvent("FutureTaskClicked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(FutureTask));
        public static readonly RoutedEvent TaskTicked = EventManager.RegisterRoutedEvent("FutureTaskTicked", RoutingStrategy.Bubble, typeof(RoutedEventArgs), typeof(FutureTask));
        public static readonly RoutedEvent TaskUnticked = EventManager.RegisterRoutedEvent("FutureTaskUnticked", RoutingStrategy.Bubble, typeof(RoutedEventArgs), typeof(FutureTask));
        public static DependencyProperty FTaskName = DependencyProperty.Register("TaskName", typeof(string), typeof(FutureTask));
        public static DependencyProperty FTaskTime = DependencyProperty.Register("TaskTime", typeof(DateTime), typeof(FutureTask));
        public static DependencyProperty FLinkedTask = DependencyProperty.Register("LinkedTask", typeof(GlobalTask), typeof(FutureTask));
        public static DependencyProperty FTaskChecked = DependencyProperty.Register("IsChecked", typeof(bool), typeof(FutureTask));

        public FutureTask()
		{
			this.InitializeComponent();
		}

        public string TaskName
        {
            set
            {
                base.SetValue(FTaskName, value);
            }
            get
            {
                return base.GetValue(FTaskName) as string;
            }
        }

        public DateTime TaskTime
        {
            set
            {
                base.SetValue(FTaskTime, value);
            }

            get
            {
                return (DateTime)base.GetValue(FTaskTime);
            }
        }

        public GlobalTask LinkedTask
        {
            set
            {
                base.SetValue(FLinkedTask, value);
            }

            get
            {
                return (GlobalTask)base.GetValue(FLinkedTask);
            }
        }

        public bool IsChecked
        {
            set
            {
                base.SetValue(FTaskChecked, value);
            }
            get
            {
                return (bool)base.GetValue(FTaskChecked);
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