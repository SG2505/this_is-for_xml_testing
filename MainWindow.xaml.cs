using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Xml;
using System.Xml.Serialization;


namespace this_is_for_xml_testing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string filepath = "test2.xml";
        
        public MainWindow()
        {
            InitializeComponent();
            DeserialzieXmlFiletoList();

        }

        
        private void DeserialzieXmlFiletoList()
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(List<burgers>));
                using (var reader = new StreamReader(filepath))
                {
                    var burgers = (List<burgers>)xmlSerializer.Deserialize(reader);
                    DataGrid1.ItemsSource = burgers;
                }
            }

            catch(FileNotFoundException e)
            {
                MessageBox.Show(e.Message);
            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

    }
}
