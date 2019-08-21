using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using Skork_Engine_Library.Parse;
using SkorkEngine.Service;

namespace SkorkEngine.GUI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }


        private void MenuCompile_Click(object sender, RoutedEventArgs e) {
            int i = CompileService.CompileCode(ref richTextCode);
            MessageBox.Show(i.ToString());
        }

        private void MenuClean_Click(object sender, RoutedEventArgs e) {
            List<string> code = CompileService.CleanCode(ref richTextCode);

            foreach (string s in code) {
                MessageBox.Show(s);
            }
        }

        private void MenuParse_Click(object sender, RoutedEventArgs e) {

        }

        private void MenuCustom_Click(object sender, RoutedEventArgs e) {

        }
    }
}
