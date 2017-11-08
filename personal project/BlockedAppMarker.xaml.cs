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

namespace Personal_Project
{
	/// <summary>
	/// Interaction logic for BlockedAppMarker.xaml
	/// </summary>
	public partial class BlockedAppMarker : UserControl
	{
        public static readonly RoutedEvent LinkedAppChanged = EventManager.RegisterRoutedEvent("OnLinkChanged", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(BlockedAppMarker));
        public static readonly RoutedEvent DismissButtonClicked = EventManager.RegisterRoutedEvent("OnDismissButtonClicked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(BlockedAppMarker));
        public static DependencyProperty ApplicationPath = DependencyProperty.Register("AppPath", typeof(string), typeof(BlockedAppMarker));
        public static DependencyProperty ApplicationIcon = DependencyProperty.Register("icon", typeof(ImageSource), typeof(BlockedAppMarker));

        public BlockedAppMarker()
		{
            this.InitializeComponent();
		}


        public string AppPath
        {
            set
            {
                base.SetValue(ApplicationPath, value);
            }
            get
            {
                return (string)base.GetValue(ApplicationPath);
            }
        }

        public ImageSource AppIcon
        {
            set
            {
                base.SetValue(ApplicationIcon, value);
            }
            get
            {
                return (ImageSource)base.GetValue(ApplicationIcon);
            }
        }




        public event RoutedEventHandler AssociatedAppChanged
        {
            add
            {
                AddHandler(LinkedAppChanged, value);
            }
            remove
            {
                AddHandler(LinkedAppChanged, value);
            }
        }

        public event RoutedEventHandler OnClick
        {
            add
            {
                AddHandler(DismissButtonClicked, value);
            }
            remove
            {
                RemoveHandler(DismissButtonClicked, value);
            }
        }

        private void delete(object sender, RoutedEventArgs e)
        {
            RaiseEvent(new RoutedEventArgs(DismissButtonClicked, this));
        }

        
		
	}
}