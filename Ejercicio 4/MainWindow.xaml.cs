using System;

using System.Windows;
using System.Windows.Controls;


namespace Ejercicio_4
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void textoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            contadorTextBlock.Text = (textoTextBox.Text.Length) + "/140";
            if(textoTextBox.Text.Length >= 140)
            {
                textoTextBox.IsReadOnly = true;
            }
        }
    }
}
