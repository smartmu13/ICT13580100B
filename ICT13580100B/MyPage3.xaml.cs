using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580100B
{
    public partial class MyPage3 : ContentPage
    {
        public MyPage3()
        {
            InitializeComponent();
            backButton.Clicked += BackButton_Clicked;
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage2());
        }
    }
}
