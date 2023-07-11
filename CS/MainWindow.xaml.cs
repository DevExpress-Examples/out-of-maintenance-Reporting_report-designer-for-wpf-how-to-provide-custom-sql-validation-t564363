using DevExpress.Xpf.Core;
using System.Windows;

namespace ValidateCustomSql {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        void UseServicesRegistry(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseServicesRegistry() }.ShowDialog();
        }

        void UseWizardCustomization(object sender, RoutedEventArgs e) {
            new DXTabbedWindow() { Content = new UseWizardCustomization() }.ShowDialog();
        }
    }
}
