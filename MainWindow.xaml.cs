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

namespace municipalities_basic_reports
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// private List<Municipality> municipalities;
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
<<<<<<< HEAD
            //municipalities = (Municipality) new List<Municipality>();
        }

        private void readFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
=======
            for (char character = 'A'; character <= 'Z'; character++)
            {
                ComboBox.Items.Add(character);
            }
>>>>>>> 9f49ec2c1b074015220ac1ea418d4e7a3e4f6e0d
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
            }

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
