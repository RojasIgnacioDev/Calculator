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

    const char AdditionCharacter = '+';
    const char SubstractionCharacter = '-';
    const char MultiplicationCharacter = '*';
    const char DivisionCharacter = '/';

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


    // TODO: when the result display is like "12+34"
    // take a string and convert it to a number before and after the plus operator 
    private void PerformOperation() {
        string displayText = DisplayContent;
        string exceptionMessage = "Trying to obtain numbers input with an empty display content.";
        
        int firstNumberString;
        int secondNumberString;
        
        // chech if the content is not null
        if (string.IsNullOrEmpty(displayText)) throw new Exception(exceptionMessage);
        // check 



    }
}