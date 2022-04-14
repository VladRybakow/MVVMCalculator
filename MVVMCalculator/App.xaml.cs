using System;
using System.Collections.Generic;
using System.Text;
using MVVMCalculator.Model;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMCalculator
{
    public partial class App : Application
    {
        CalculatorModel model;
        public App()
        {
            InitializeComponent();

            model = new CalculatorModel();
            model.RestoreState(Current.Properties);

            MainPage = new View.Calculator(model);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
