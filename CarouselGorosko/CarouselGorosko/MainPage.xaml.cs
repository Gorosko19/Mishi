using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarouselGorosko
{
    public partial class MainPage : CarouselPage
    {
        Image img;
        public MainPage()
        {
            var ListonosContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                    {Text = "Листонос Пратта",//text
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions= LayoutOptions.Center
                    },
                    new Image
                    { Source = "Listonos.PNG",
                     WidthRequest = 200,
                     HeightRequest = 200,
                     HorizontalOptions = LayoutOptions.Center,
                     VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                    }
                }
            };
            var ribolovContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                    {Text = "Большой рыболов",//text
                            FontSize = Device.GetNamedSize ( NamedSize.Medium, typeof(Label)),
                            HorizontalOptions= LayoutOptions.Center
                    },
                    new Image
                    { Source = "Ribolov.PNG",
                     WidthRequest = 200,
                     HeightRequest = 200,
                     HorizontalOptions = LayoutOptions.Center,
                     VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                    }
                }
            };
            var  krilanContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                    {Text = "Трубконосый крылан",//text
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions= LayoutOptions.Center
                    },
                    new Image
                    { Source = "Krilan.PNG",
                     WidthRequest = 200,
                     HeightRequest = 200,
                     HorizontalOptions = LayoutOptions.Center,
                     VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                    }
                }
            };
            var ushanContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                    {Text = "Обыкновенный крылан",//text
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            HorizontalOptions= LayoutOptions.Center
                    },
                    new Image
                    {  Source = "Ushan.PNG",
                     WidthRequest = 200,
                     HeightRequest = 200,
                     HorizontalOptions = LayoutOptions.Center,
                     VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                    }
                }
            };
            Children.Add(ListonosContentPage);
            Children.Add(ribolovContentPage);
            Children.Add(krilanContentPage);
            Children.Add(ushanContentPage);
        }
    }
}
