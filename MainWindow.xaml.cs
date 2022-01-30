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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace municipalities_basic_reports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Municipality> municipalities;
        private SeriesCollection SeriesCollection;

        public MainWindow()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Municipio",
                    Values = new ChartValues<ObservableValue> {new ObservableValue(10)},
                    DataLabels = true
                },
            };

            DataContext = this;

            municipalities = new List<Municipality>();

            for (char character = 'A'; character <= 'Z'; character++)
            {
                ComboBox.Items.Add(character);
            }
        }

        private void readFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            var line = reader.ReadLine();
            line = reader.ReadLine();

            while (line != "Fuente: DANE.,,,,")
            {
                var data = line.Split('\u002C');
                string departmentCode = data[0];
                string municipalityCode = data[1];
                string departmentName = data[2];
                string municipalityName = data[3];
                string municipalityType = data[4];

                municipalities.Add(new Municipality(municipalityName, municipalityCode, municipalityType, departmentCode, departmentName));
                line = reader.ReadLine();

            }
            reportGrid.ItemsSource = municipalities;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Database files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == true)
            {
                string selectedFileName = openFileDialog1.FileName;
                readFile(selectedFileName);
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            char selectedCharacter = (char)ComboBox.SelectedItem;
            modifyTable(selectedCharacter);

        }

        private void modifyTable (char initial)
        {
            List<Municipality> newList = new List<Municipality>();
            foreach (Municipality element in municipalities)
            {
                if (element.departmentName.StartsWith(initial))
                {
                    newList.Add(element);
                }
            }
            reportGrid.ItemsSource = newList;
        }

        private void resetTable(object sender, RoutedEventArgs e)
        {
            reportGrid.ItemsSource = municipalities;
        }
    }
}
