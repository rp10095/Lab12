using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab12
{
    public partial class MainPage : ContentPage
    {        
       
        public MainPage()
        {            
            InitializeComponent();
            
            Label label = new Label
            {
                Text = "Rodrigo Pedro",
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            Label label2 = new Label
            {
                Text = DateTime.Now.ToString(),
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
             Button passage1Button = new Button
            {
                BorderColor = Color.White,
                Text = "Passage 1",
                TextColor = Color.White, 
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            passage1Button.Clicked += (sender, args) =>
            {
                var contentpage = new Passage1();

                var page = new NavigationPage(contentpage);
                Navigation.PushModalAsync(page);
            };
            Button passage2Button = new Button
            {
                BorderColor = Color.White, 
                Text = "Passage 2",
                TextColor = Color.White,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
            this.Content = new StackLayout
            {
                BackgroundColor = Color.Black,
                Children =
                {
                    label,
                    label2,
                    new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.CenterAndExpand,
                        Children =
                        {
                            passage1Button,
                            passage2Button
                        }
                    }
                }
            };
        }        
    }
}
