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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Memory
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Game : Page
    {
        public Game()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void MenuFlyoutItem_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
        //###########################################################################################
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            TextBlock1.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.hdcarwallpapers.com/walls/porsche_911_turbo_s_2020_5k_3-HD.jpg"));
        }//A

        private void Image_Tapped_1(object sender, TappedRoutedEventArgs e)
        {
            TextBlock2.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-maya-blue-solid-color-background.jpg")); 
        }//B

        private void Image_Tapped_2(object sender, TappedRoutedEventArgs e)
        {
            TextBlock3.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-orange-color-wheel-solid-color-background.jpg"));
        }//C

        private void Image_Tapped_3(object sender, TappedRoutedEventArgs e)
        {
            TextBlock4.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-dark-red-solid-color-background.jpg"));
        }//D

        private void Image_Tapped_4(object sender, TappedRoutedEventArgs e)
        {
            TextBlock5.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-purple-heart-solid-color-background.jpg"));
        }//H

        private void Image_Tapped_5(object sender, TappedRoutedEventArgs e)
        {
            TextBlock6.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-bottle-green-solid-color-background.jpg"));
        }//G

        private void Image_Tapped_6(object sender, TappedRoutedEventArgs e)
        {
            TextBlock7.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://media.sketchfab.com/models/c5e433fa5f3046fa957c78f697595ac0/thumbnails/475b7f29ae3e4b07ba43610d73a2bd97/2bd36f6242f24a39af9d9cb1317fa306.jpeg"));
        }//F

        private void Image_Tapped_7(object sender, TappedRoutedEventArgs e)
        {
            TextBlock8.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://static.jutarnji.hr/images/slike/2021/09/18/12525163.jpg"));
        }//E

        //#######################################################################

        private void Image_Tapped_8(object sender, TappedRoutedEventArgs e)
        {
            TextBlock9.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-purple-heart-solid-color-background.jpg"));
        }

        private void Image_Tapped_9(object sender, TappedRoutedEventArgs e)
        {
            TextBlock10.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-maya-blue-solid-color-background.jpg"));
        }

        private void Image_Tapped_10(object sender, TappedRoutedEventArgs e)
        {
            TextBlock11.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-orange-color-wheel-solid-color-background.jpg"));
        }

        private void Image_Tapped_11(object sender, TappedRoutedEventArgs e)
        {
            TextBlock12.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.hdcarwallpapers.com/walls/porsche_911_turbo_s_2020_5k_3-HD.jpg"));
        }

        private void Image_Tapped_12(object sender, TappedRoutedEventArgs e)
        {
            TextBlock13.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-dark-red-solid-color-background.jpg"));
        }

        private void Image_Tapped_13(object sender, TappedRoutedEventArgs e)
        {
            TextBlock14.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://media.sketchfab.com/models/c5e433fa5f3046fa957c78f697595ac0/thumbnails/475b7f29ae3e4b07ba43610d73a2bd97/2bd36f6242f24a39af9d9cb1317fa306.jpeg"));
        }

        private void Image_Tapped_14(object sender, TappedRoutedEventArgs e)
        {
            TextBlock15.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://www.solidbackgrounds.com/images/1920x1080/1920x1080-bottle-green-solid-color-background.jpg"));
        }

        private void Image_Tapped_15(object sender, TappedRoutedEventArgs e)
        {
            TextBlock16.Text = "Clicked";
            (sender as Image).Source = new BitmapImage(new Uri("https://static.jutarnji.hr/images/slike/2021/09/18/12525163.jpg"));
        }
    }
}
