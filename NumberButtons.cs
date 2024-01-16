using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Calculator;

public partial class MainWindow : Window {

    // handle the numbers buttons
    private void NumberOneButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberOneButton);
    }

    private void NumberTwoButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberTwoButton);
    }

    private void NumberThreeButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberThreeButton);
    }

    private void NumberFourButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberFourButton);
    }

    private void NumberFiveButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberFiveButton);
    }

    private void NumberSixButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberSixButton);
    }

    private void NumberSevenButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberSevenButton);
    }

    private void NumberEightButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberEightButton);
    }

    private void NumberNineButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberNineButton);
    }

    private void NumberZeroButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(NumberZeroButton);
    }

    private void DotButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(DotButton);
    }
}
