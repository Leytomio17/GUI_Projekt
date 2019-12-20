using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System;


namespace GUI_Projekt
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private Kunde meinKunde = new Kunde()
        {
            Vorname = "Leyton"
        };
        public bool isEdit = false;

        private List<Kunde> KundenListe;

        public UserControl1()
        {
            InitializeComponent();
            this.meinKunde.PLZ = 0000;
            this.meinKunde.Vorname = "Leyton";
            this.meinKunde.Name = "Tomio";
            this.DataContext = this.meinKunde;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (this.isEdit)
            {

            }
            else if (this.isEdit == false)
            {
                using (var context = new M120Entities1())
                {
                    context.Kunde.Add(this.meinKunde);
                    context.SaveChanges();
                }
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }
    }
}
