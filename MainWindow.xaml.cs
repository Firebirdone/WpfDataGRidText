using System;
using System.Windows;
using System.Collections.ObjectModel;

namespace WpfDataGRidText
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Member> memberData = new ObservableCollection<Member>();
            memberData.Add(new Member()
            {
                Name = "Joe",
                Age = "23",
                Gender = GenderOpt.Male,
                Pass = true,
                Email = new Uri("mailto:Joe@school.com")
            });
            memberData.Add(new Member()
            {
                Name = "Mike",
                Age = "20",
                Gender = GenderOpt.Male,
                Pass = false,
                Email = new Uri("mailto:Mike@school.com")
            });
            memberData.Add(new Member()
            {
                Name = "Lucy",
                Age = "25",
                Gender = GenderOpt.Female,
                Pass = true,
                Email = new Uri("mailto:Lucy@school.com")
            });
            dataGrid.DataContext = memberData;
        }
    }
}