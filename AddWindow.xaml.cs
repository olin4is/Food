using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Food
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private OpenFileDialog _img;
        public AddWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); 
        }

        private void Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images (*.jpg, *.png)|*.jpg; *.png; *.JPG; *.PNG";
            if (openFileDialog.ShowDialog() == true)
            {
                _img = openFileDialog;
                string path = System.IO.Path.Combine("S:\\qqq\\Рецепты\\images", _img.SafeFileName);
                File.Copy(_img.FileName, path, true);
            }
        }
    }
}
