using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CommonView.Animate
{
    public class Animate
    {
        //
        public static async Task BallAnimate(View view,int Top,int reduce,int time)
        {
            //旋轉360度
            await view.RelRotateTo(360, 1000);
            //球上下跳的感覺每次遞減的效果,top => y軸偏移量,reduce=>每次減少多少,time=>跳幾下
            do
            {
                await view.TranslateTo(view.TranslationX, view.TranslationY - Top, 500, Easing.CubicOut);

                await view.TranslateTo(view.TranslationX, view.TranslationY + Top, 300, Easing.CubicIn);

                Top = Top - reduce;
                time--;
            } while (time != 0);

            /*
            await view.TranslateTo(view.TranslationX, view.TranslationY - 50, 500, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 50, 300, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY - 20, 300, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 20, 150, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY - 10, 150, Easing.Linear);

            await view.TranslateTo(view.TranslationX, view.TranslationY + 10, 100, Easing.Linear);

            await view.FadeTo(-0, 1000);
            */
        }
    }
}
