using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace lab10.ViewModels
{
    public class OperacionesViewModel : ViewModelBase
    {

        int valor1;
        public int Valor1
        {
            get { return valor1; }
            set
            {
                if (valor1 != value)
                {
                    valor1 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor2;
        public int Valor2
        {
            get { return valor2; }
            set
            {
                if (valor2 != value)
                {
                    valor2 = value;
                    OnPropertyChanged();
                }
            }
        }
        int valor3;
        public int Valor3
        {
            get { return valor3; }
            set
            {
                if (valor3 != value)
                {
                    valor3 = value;
                    OnPropertyChanged();
                }
            }
        }
        int resultado;
        public int Resultado
        {
            get { return resultado; }
            set
            {
                if (resultado != value)
                {
                    resultado = value;
                    OnPropertyChanged();
                }
            }
        }
        
        public ICommand Sumar { protected set; get; }
        public ICommand Multiplicar { protected set; get; }

        public OperacionesViewModel()
        {
            Sumar = new Command(() =>
            {
                Resultado = Valor1 + Valor2 + valor3;
            });

            Multiplicar = new Command(() =>
            {
                Resultado = Valor1 * Valor2 * Valor3;
            });
            
        }
    }
    
}
