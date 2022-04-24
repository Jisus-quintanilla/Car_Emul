using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaNo._1.Clases
{
    public class Carro
    {
        public string Prop { get; }
        public string Marca { get; }
        public int Modelo { get; }
        public string Color { get; }

        private int Encendido = 0;
        private int Velocidd_actual = 0;
        public int MAXVELOCIDAD { get; }

        public Carro(string _Prop, string _marca, int _modelo, string _color, int maxvel)
        {
            Prop = _Prop;
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            Encendido = 0;
            MAXVELOCIDAD = maxvel;
            this.Velocidd_actual = 0;
        }

        public string acelerar()
        {
            if (Encendido == 0)
            {
                return $"Esta apagado, asi no se puede";

            }

            string mensaje = "";
            if (Velocidd_actual < MAXVELOCIDAD)
            {
                Velocidd_actual += 10;
                mensaje = $"vas a {Velocidd_actual} KPH";
            }
            else
            {
                Velocidd_actual = MAXVELOCIDAD;
                mensaje = "CUIDADO, VAS MUY RAPIDO";

            }
            return mensaje;
        }

        public string DesAcelerar()
        {


            Velocidd_actual -= 20;
            return $"Acabas de desacelerar ahora vas a {Velocidd_actual} KPH";
        }

        public string Frenar()
        {
            Velocidd_actual = 0;
            return $"*Comiensa a frenar* a hora vas a {Velocidd_actual} KPH";
        }

        public string GetVelocidadActual()
        {
            return $"Vamos a {Velocidd_actual}KPH";
        }

        public string EncenderMotor()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                Encendido = 1;
                mensaje = "\n*Lo enciende*  Bruruurru encendido!!";
                Velocidd_actual = 0;
            }
            else
            {
                mensaje = "\n*Lo enciende de nuevo* ups ya estaba encendido";


            }
            return mensaje;
        }

        public string ApagarMotor()
        {
            Encendido = 0;
            return "\n*prodede a apagar el motor*";
        }

        public string Bocina()
        {
            return "*pita* PIPIIIII!!";
        }


        public string Dameinformacion()
        {
            return $"El propietario es = {Prop} \nLa marca es = {Marca}. \nEl modelo es = {Modelo}. \nEl color es = {Color}." +
                $" \nTiene una velocidad maxima de = {MAXVELOCIDAD} KPH  ";
        }
    }
}
