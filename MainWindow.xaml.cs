using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
/// 
namespace DanielKaarur_CSharp2_06
{


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CalculationComboBox.Items.Add("Add");
            CalculationComboBox.Items.Add("Subtract");
            CalculationComboBox.Items.Add("Multiply");
            CalculationComboBox.Items.Add("Divide");
            CalculationComboBox.Items.Add("Modulo");
            CalculationComboBox.Items.Add("Exponentiate");
            CalculationComboBox.SelectedIndex = 0;
        }

        private delegate int CalculationDelegate(int x, int y);

        private void calculate_Btn_Click(object sender, RoutedEventArgs e)
        {
            string selectedOption = CalculationComboBox.SelectedItem.ToString();
        
            CalculationDelegate calculationDelegate;
        
            int x = int.Parse(TextBox1.Text);
            int y = int.Parse(TextBox2.Text);
        
              switch (selectedOption)
              {
                  case "Add":
                      calculationDelegate = Add;
                      break;
                  case "Subtract":
                      calculationDelegate = Subtract;
                      break;
                  case "Multiply":
                      calculationDelegate = Multiply;
                      break;
                  case "Divide":
                      calculationDelegate = Divide;
                      break;
                  case "Modulo":
                      calculationDelegate = Modulo;
                      break;
                  case "Exponentiate":
                      calculationDelegate = Exponentiate;
                      break;
                  default:
                      throw new InvalidOperationException("Invalid calculation option selected");
              }
        
            CalculatedValueLable.Content = calculationDelegate(x, y).ToString();
        
        }
        private int Add(int x, int y)
        {
            return x + y;
        }

        private int Subtract(int x, int y)
        {
            return x - y;
        }

        private int Multiply(int x, int y)
        {
            return x * y;
        }

        private int Divide(int x, int y)
        {
            return x / y;
        }

        private int Modulo(int x, int y)
        {
            return x % y;
        }

        private int Exponentiate(int x, int y)
        {
            return (int)Math.Pow(x, y);
        }

    }
}