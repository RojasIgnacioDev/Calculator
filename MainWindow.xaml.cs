using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window {

    string TextDisplay { get; set; } = "0";
    
    public MainWindow() {
        InitializeComponent();
        Console.Beep();
    }

   
    private void ChangeDisplayContent(Button buttonToGatherContent) {
        var newText = buttonToGatherContent.Content?.ToString();
        ResultDisplay.Text += newText;
    }

}