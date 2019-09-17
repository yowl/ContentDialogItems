using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ContentDialogItemsControl.Shared;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ContentDialogItemsControl
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var cd = new ContentDialog();
            cd.PrimaryButtonText = "OK";
            cd.IsPrimaryButtonEnabled = true;
            cd.DataContext = new ViewModel();
            cd.Content = new MyUserControl1();
            cd.ShowAsync();
        }
    }

    public  class ViewModel
    {
        public List<string> Items => new List<string>
        {
            "asaa"
        };
    }
}
