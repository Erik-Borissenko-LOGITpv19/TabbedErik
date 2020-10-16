using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedErik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LETO : TabbedPage
    {
        public LETO()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(2,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(3,GridUnitType.Star)}
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };
            Label LblLeto = new Label { Text = "Лето", FontSize = 30 };
            Image Leto1 = new Image { Source = "Leto.jpg" };
            grd.Children.Add(LblLeto, 0, 0);
            grd.Children.Add(Leto1, 0, 1);
            Content = grd;
        }
    }
}