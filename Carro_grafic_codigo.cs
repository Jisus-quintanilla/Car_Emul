using Microsoft.Win32;
using PruebaNo._1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PruebaNo._1
{
    
    public partial class MainWindow : Window
    {

        Carro car;
        public MainWindow()
        {
            InitializeComponent();
            car = new Carro("Jesus", "Toyota", 2021, "Negro", 180);
        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;


        private void Apagar_Click(object sender, RoutedEventArgs e)
        {
            lblR1.Text = car.ApagarMotor();
        }

        private void Inicar_Click(object sender, RoutedEventArgs e)
        {
            lblR1.Text = car.EncenderMotor();
        }

        private void Datos_Click(object sender, RoutedEventArgs e)
        {
            DatosCarro.Text = car.Dameinformacion();
        }

        private void Frenar_Click(object sender, RoutedEventArgs e)
        {
            lblR1.Text = car.DesAcelerar();

        }

        private void Acelerar_Click(object sender, RoutedEventArgs e)
        {
            lblR1.Text = car.acelerar();
        }


        private void Playr_Click(object sender, RoutedEventArgs e)
        {
            //hola
        }

        private void BT_Click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp4"
            };
            bool? dialogOK = fileDialog.ShowDialog();
            if (dialogOK == true)
            {
                filename = fileDialog.FileName;
                TBFileName.Text = fileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));
            }
        }

        private void BT_Click_Play(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void BT_Click_Pause(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void BT_Click_Stop(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Pause();
        }
    }
}
