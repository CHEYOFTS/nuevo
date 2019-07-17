using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SumaConBinding.ViewModel;

namespace SumaConBinding
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Suma_Clicked(object sender, EventArgs e)
        {
            Operacion suma = new Operacion();
            suma.numero1 = Convert.ToDouble(num1.Text);
            suma.numero2 = Convert.ToDouble(num2.Text);

            RealizarSuma ObjOperacion = new RealizarSuma();
            suma.total = ObjOperacion.Sumar(suma.numero1, suma.numero2);

            var PagBinding = new Resultado();
            PagBinding.BindingContext = suma;

            Navigation.PushAsync(PagBinding);
        }
        
            
    }
    
}
