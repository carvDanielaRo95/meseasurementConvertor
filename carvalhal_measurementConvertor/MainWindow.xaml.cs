using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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

namespace carvalhal_measurementConvertor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        List<ConvertionType> lst_convertionTypes;
        private double _resultConvertion;
        public double resultConvertion { get { return _resultConvertion; } set { _resultConvertion = value; OnPropertyChanged(); } }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            GenerateData();
            cbx_convertionTypes.ItemsSource = lst_convertionTypes;
            cbx_convertionTypes.SelectedItem = lst_convertionTypes[0];
        }

        public void GenerateData()
        {
            List<Unit> lstUnitG = new List<Unit>();
            lstUnitG.Add(new Unit("mg", -3));
            lstUnitG.Add(new Unit("cg", -2));
            lstUnitG.Add(new Unit("dg", -1));
            lstUnitG.Add(new Unit("g", 0));
            lstUnitG.Add(new Unit("hg", 1));
            lstUnitG.Add(new Unit("dag", 2));
            lstUnitG.Add(new Unit("kg", 4));

            List<Unit> lstUnitD = new List<Unit>();
            lstUnitD.Add(new Unit("mm", -3));
            lstUnitD.Add(new Unit("cm", -2));
            lstUnitD.Add(new Unit("dm", -1));
            lstUnitD.Add(new Unit("m", 0));
            lstUnitD.Add(new Unit("hm", 1));
            lstUnitD.Add(new Unit("dam", 2));
            lstUnitD.Add(new Unit("km", 4));

            List<Unit> lstUnitL = new List<Unit>();
            lstUnitL.Add(new Unit("ml", -3));
            lstUnitL.Add(new Unit("cl", -2));
            lstUnitL.Add(new Unit("dl", -1));
            lstUnitL.Add(new Unit("l", 0));
            lstUnitL.Add(new Unit("hl", 1));
            lstUnitL.Add(new Unit("dal", 2));
            lstUnitL.Add(new Unit("kl", 4));

            lst_convertionTypes = new List<ConvertionType>();

            ConvertionType convertionTypeD = new ConvertionType("Distance", lstUnitD);
            ConvertionType convertionTypeG = new ConvertionType("Weight", lstUnitG);
            ConvertionType convertionTypeL = new ConvertionType("Volum", lstUnitL);
            lst_convertionTypes.Add(convertionTypeD);
            lst_convertionTypes.Add(convertionTypeG);
            lst_convertionTypes.Add(convertionTypeL);
        }
        private void ConvertCommand(object sender, RoutedEventArgs e)
        {
            ConvertionType selectedList = cbx_convertionTypes.SelectedItem as ConvertionType;
            resultConvertion = selectedList.Convertion(Convert.ToDouble(txb_valueIn.Text), (cbx_convertFrom.SelectedItem as Unit).Puissance, (cbx_convertTo.SelectedItem as Unit).Puissance);
        }

        private bool handle = true;
        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            if (handle) UpdateList();
            handle = true;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            handle = !cmb.IsDropDownOpen;
            UpdateList();
        }

        /// <summary>
        /// Update all values in combobox
        /// </summary>
        private void UpdateList()
        {
            ConvertionType selectedList = cbx_convertionTypes.SelectedItem as ConvertionType;
            cbx_convertFrom.ItemsSource = selectedList.LstUnit;
            cbx_convertFrom.SelectedItem = selectedList.LstUnit[0];
            cbx_convertTo.ItemsSource = selectedList.LstUnit;
            cbx_convertTo.SelectedItem = selectedList.LstUnit[0];
            txb_valueIn.Text = "0.0";
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9.]");
            e.Handled = !regex.IsMatch(e.Text);
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Raises this object's PropertyChanged event.
        /// </summary>
        /// <param name="propertyName">The property that has a new value.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null)
            {
                var e = new PropertyChangedEventArgs(propertyName);
                handler(this, e);
            }
        }
        #endregion
    }
}
