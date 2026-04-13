using Microsoft.Win32;
using StrandC;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace StrandWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Furdo> lista = new List<Furdo>();

        public MainWindow()
        {
            InitializeComponent();
            String[] Sorok = File.ReadAllLines("strandadatok.txt");
            foreach (String s in Sorok.Skip(1))
            {
                lista.Add(new Furdo(s));
            }

            datagrid.ItemsSource = lista;


        }

        private void datagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Furdo selected = datagrid.SelectedItem as Furdo;
            progressbar.Value = selected.Vizhofok;
            nev.Text = selected.Nev;
            cim.Text = selected.Cim;
            ar.Text = selected.Ar.ToString();
            vizhofok.Text = selected.Vizhofok.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (datagrid.SelectedItem !=null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog.FileName = "Untitled";
                if (saveFileDialog.ShowDialog() == true)
                {
                    string selectedPath = saveFileDialog.FileName;


                    File.WriteAllText(selectedPath, $"{nev.Text};{cim.Text};{ar.Text};{vizhofok.Text}");


                }
            }
            else
            {
                MessageBox.Show("Nem menthető amíg nincs kiválasztva semmi");

            }
        }
    }
}

