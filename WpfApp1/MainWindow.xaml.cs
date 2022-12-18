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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (textBox != null)
            {
                string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
                textBox.FontSize = Convert.ToDouble(fontSize);
            }
        }

        private void ButtonBold_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontWeight== FontWeights.Normal)
            {                
                textBox.FontWeight = FontWeights.Bold;
                //double thickness = Convert.ToDouble((sender as Button).BorderThickness);
                //(sender as Button).BorderThickness = new Thickness(5,5,5,5);
                //(sender as Button).BorderBrush = new Brush(Brush.OpacityProperty);
            }
            else
                textBox.FontWeight = FontWeights.Normal;
        }

        private void ButtonItalic_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.FontStyle == FontStyles.Normal)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else textBox.FontStyle = FontStyles.Normal;
        }

        private void ButtonUnderline_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.TextDecorations.Count == 0)
                textBox.TextDecorations.Add(TextDecorations.Underline);
            else
            {
                textBox.TextDecorations.RemoveAt(0);
            }

            //if (textBox.TextDecorations == null)
            //    textBox.TextDecorations = TextDecorations.Underline;
            //else
            //{
            //    textBox.TextDecorations = null;
            //}
            ////Работает не стабильно. логика переворачивается и в итоге кнопка подсвечена, а подчеркивания нет
        }

        private void RadioButtonBlack_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Black;
            }
        }

        private void RadioButtonRed_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = Brushes.Red;
            }

        }
    }
}
