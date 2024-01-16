using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Calculator;
public partial class MainWindow : Window {
    class EmptyDisplayContentException : Exception {
        public EmptyDisplayContentException() : base("The content of the display is empty.") {

        }
    }
}