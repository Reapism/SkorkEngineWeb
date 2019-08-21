using System.Windows;

namespace SkorkEngine.GUI {
    /// <summary>
    /// Interaction logic for <see cref="LoginWindow"/>.
    /// </summary>
    public partial class LoginWindow : Window {
        public LoginWindow() {
            InitializeComponent();
        }

        private void BtnLoginAccount_Click(object sender, RoutedEventArgs e) {
            new MainWindow().Show();
        }
    }
}
