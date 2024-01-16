using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator;

public partial class MainWindow : Window {

    private void AdditionButton_Click(object sender, RoutedEventArgs e) {
        if (ResultDisplay.Text.ToString()) 
        this.ChangeDisplayContent(AdditionButton);
    }

    private void SubstractionButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(SubstractionButton);
    }

    private void MultiplicationButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(MultiplicationButton);
    }

    private void DivisionButton_Click(object sender, RoutedEventArgs e) {
        this.ChangeDisplayContent(DivisionButton);
    }

}