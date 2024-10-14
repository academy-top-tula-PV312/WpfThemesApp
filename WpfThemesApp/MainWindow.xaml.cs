using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfThemesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> themes = new List<string>() { "Dark", "Light" };
            themeChange.ItemsSource = themes;
            themeChange.SelectedItem = "Dark";
        }

        private void themeChange_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string? theme = themeChange.SelectedItem as string;

            var path = new Uri("red" + theme + ".xaml", UriKind.Relative);
            ResourceDictionary? dictTheme = Application.LoadComponent(path) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dictTheme);
        }
    }
}