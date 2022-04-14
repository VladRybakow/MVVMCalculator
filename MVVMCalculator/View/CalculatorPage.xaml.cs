using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MVVMCalculator.Model;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMCalculator.View
{
    public partial class Calculator : ContentPage
    {
        public Calculator(CalculatorModel model)
        {
            InitializeComponent();

            BindingContext = model;
        }
    }
}