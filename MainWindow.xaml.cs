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

    const string EmptyTextDisplay = "0";

    string DisplayContent = "";

    decimal FirstNumberInput = 0m;
    decimal SecondNumberInput = 0m;

    
    public MainWindow() {
        InitializeComponent();

        ResultDisplay.Text = EmptyTextDisplay;

        Console.Beep();
    }

    // adds to the display the content of the button
    private void ChangeDisplayContent(Button buttonToGatherContent) {
        var newText = buttonToGatherContent.Content?.ToString();

        DisplayContent += buttonToGatherContent.Content?.ToString();
        ResultDisplay.Text = DisplayContent;
    }

}