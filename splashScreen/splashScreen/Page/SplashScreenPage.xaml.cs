using CommonView.Animate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace splashScreen.Page
{
    public partial class SplashScreenPage : ContentPage
    {
        public SplashScreenPage()
        {
            InitializeComponent();
        }

        //畫面顯示完要做的事
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            //imageview 讓他往上偏移50,每次遞減10,跳5次
            await Animate.BallAnimate(this.logoImage,50,10,5);

            //動畫顯示完進入首頁
            await Navigation.PushModalAsync(new FirstPage());

        }
    }
}
