using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace ForImg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            //
          
        }
        public void Button1_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@text1.Text);
            myBitmapImage.EndInit();
            FormatConvertedBitmap gray = new FormatConvertedBitmap(myBitmapImage, PixelFormats.Gray4, null, 0);
            myImage.Source = gray;
            var enc = new JpegBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(gray));
            using (var s = File.Create("gray.jpg"))
                enc.Save(s);
        }
       /* public void Button2_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage myBitmapImage = new BitmapImage();
            myBitmapImage.BeginInit();
            myBitmapImage.UriSource=new Uri(myImage);
            myBitmapImage.EndInit();
            var enc = new JpegBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(gray));
            using (var s = File.Create("gray.jpg"))
                enc.Save(s);*/
        }
    }

