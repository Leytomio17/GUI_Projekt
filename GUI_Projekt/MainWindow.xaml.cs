using System.Windows;

namespace GUI_Projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserControl1 form = new UserControl1();
            form.isEdit = true;
            this.ViewContainer.Children.Clear(); 
            this.ViewContainer.Children.Add(form);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                Hotels form = new Hotels();
                form.isEdit = true;
                this.ViewContainer.Children.Clear();
                this.ViewContainer.Children.Add(form);

            }
        }
    }
}
