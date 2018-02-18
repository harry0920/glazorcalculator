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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalculatorUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            WidthOutput.Text = "";
            HeightOutput.Text = "";
            QuantityOutput.Text = "";
            TintColorOutput.Text = "";
            areaOutput.Text = "";
            lengthOutput.Text = "";
            dateOutput.Text = "";
            
        }

        private async void submitButton_Click(object sender, RoutedEventArgs e)
        {

            double woodLength, glassArea;
            string widthString, heightString;

            double width = double.Parse(WidthBox.Text);
            double height = double.Parse(HeightBox.Text);




            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            WidthOutput.Text = "Width: " + width;
            HeightOutput.Text = "Height: " + height;
            lengthOutput.Text = "The length of the wood is " + woodLength + " feet" ;
            areaOutput.Text = "The area of the glass is " + glassArea + " square metres";
            dateOutput.Text = "Date Ordered: " + DateTime.Now.ToString();
          //  TintColorOutput.Text = "Tint Color: " + Tint_Color.SelectedItem;
            QuantityOutput.Text = "Quanity: " + quantityslider.Value.ToString();

        }

        private void WidthBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int width;
            widthError.Text = "";


            if (int.TryParse(WidthBox.Text, out width) && width > 0 && width < 100)
            {
                // Do NOthing
            }
            else
            {
                widthError.Text = "Width Should be an integer between 1 and 100";
            }

        }

        private void HeightBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            int height;
            heightError.Text = "";



            if (int.TryParse(HeightBox.Text, out height) && height > 0 && height < 100)
            {
                // Do NOthing
            }
            else
            {
                heightError.Text = "Height Should be an integer between 1 and 100";
            }

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
