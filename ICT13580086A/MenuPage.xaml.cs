using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580086A
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();

            viewButton.Clicked += ViewButton_Clicked;
            stackButton.Clicked += StackButton_Clicked;
            gridButton.Clicked += GridButton_Clicked;
            absoluteButton.Clicked += AbsoluteButton_Clicked;


            contentButton.Clicked += ContentButton_Clicked;
            navButton.Clicked += NavButton_Clicked;
            tabButton.Clicked += TabButton_Clicked;
            carouselButton.Clicked += CarouselButton_Clicked;
        }

        void ViewButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new ICT13580086APage());
            mp.Detail = np;
            mp.IsPresented = false;
        }

        void StackButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new StackPage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void GridButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new GridPage());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void AbsoluteButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new AbsolutePage());
			mp.Detail = np;
			mp.IsPresented = false;
        }



        void ContentButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new MyPage1());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void NavButton_Clicked(object sender, EventArgs e)
        {
			var mp = Parent as MasterDetailPage;
            var np = new NavigationPage(new NavPage1());
			mp.Detail = np;
			mp.IsPresented = false;
        }

        void TabButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var tp = new TabbedPage();
            tp.Children.Add(new tabPage1());
            tp.Children.Add(new tabPage2());
            tp.Children.Add(new tabPage3());
            var np = new NavigationPage(tp);
            mp.Detail = np;
            mp.IsPresented = false;
        }

        void CarouselButton_Clicked(object sender, EventArgs e)
        {
            var mp = Parent as MasterDetailPage;
            var cp = new CarouselPage();
            cp.Children.Add(new tabPage1());
            cp.Children.Add(new tabPage2());
            cp.Children.Add(new tabPage3());
            var np = new NavigationPage(cp);
			mp.Detail = np;
			mp.IsPresented = false;
        }
    }
}
