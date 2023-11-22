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
    /// Логика взаимодействия для RecipeWindow.xaml
    /// </summary>
    public partial class RecipeWindow : Window
    {
        public RecipeWindow(Recipe recipes)
        {
            InitializeComponent();
            Title.Text = recipes.Title;
            Ingredients.Text = recipes.Ingredients;
            Description.Text = recipes.Description;
            Complexity.Text = recipes.Complexity.ToString();
            Time.Text = recipes.Time.ToString();

            BitmapImage _bitmapImage = new BitmapImage();
            using (Stream stream = File.OpenRead(recipes.Image))
            {
                _bitmapImage.BeginInit();
                _bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                _bitmapImage.StreamSource = stream;
                _bitmapImage.EndInit();
            }
            Image.Source = _bitmapImage;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
