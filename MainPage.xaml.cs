using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NavView24Test
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private List<SampleCategory> sampleCategories = new List<SampleCategory>()
        {
            new SampleCategory()
            {
                Name = "Controls",
                Samples = new Sample[] {
                    new Sample()
                    {
                        Name = "UniformGrid",
                        Subcategory = "Panels",
                        About = "Some Info...",
                    },
                    new Sample()
                    {
                        Name = "WrapPanel",
                        Subcategory = "Panels",
                        About = "Some Info...",
                    }
                }
            },
            new SampleCategory()
            {
                Name = "Extensions",
                Samples = new Sample[] {
                    new Sample()
                    {
                        Name = "Mouse",
                        About = "Some Info...",
                    },
                    new Sample()
                    {
                        Name = "OnDevice",
                        About = "Some Info...",
                    }
                }
            }
        };

        public MainPage()
        {
            this.InitializeComponent();

            NavView.MenuItemsSource = sampleCategories;
        }

        private void NavView_ItemInvoked(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItem is SampleCategory cat && cat.Name == "Controls")
            {
                var msg = new MessageDialog("You clicked 'Controls'!")
                {
                    Title = "Clicked NavigationView Item"
                };
                _ = msg.ShowAsync();
            }
        }
    }
}
