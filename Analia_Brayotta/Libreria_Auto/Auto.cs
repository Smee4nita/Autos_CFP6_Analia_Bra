using System.Drawing;

namespace Libreria_Auto
{
    public class Auto
    {
        private string marca;
        private double cantidadCombustible;
        private Color color;

        public Auto(string marca, double cantidadCombustible, Color color)
        {
            this.marca = marca;
            this.cantidadCombustible = cantidadCombustible;
            this.color = color;
        }
        public Auto(string marca, string combustible, string color)
        {
            this.ConvertirStringEnCombustible(combustible);
            this.ConvertirColorStringEnColor(color);
            this.marca = marca;
        }

        public string GetMarca()
        {
            return marca;
        }
        public double GetCantidadCombustible()
        {
            return cantidadCombustible;
        }

        public Color GetColor()
        {
            return color;
        }


        public void SetColor(Color color)
        {
            this.color = color;
        }
        public string AutoToString()
        {
            return $"la marca del auto es: {marca} , la cantidad de combustible que tiene es: {cantidadCombustible} y el color es: {color}";

        }

        public bool Avanzar(double km)
        {   bool retorno = false;
            double combustibleNecesario = km/10;
            if (cantidadCombustible >0 && cantidadCombustible >= combustibleNecesario)
            {
               cantidadCombustible -= combustibleNecesario;
                retorno = true;
            }
            return retorno;
            
        }

        public bool ConvertirStringEnCombustible(string combustible)
        {
            bool retorno = false;
            if (double.TryParse(combustible, out double combustibleValido))
            {
                this.cantidadCombustible = combustibleValido;
                retorno = true;
            }
            return retorno;
        }

        public bool ConvertirColorStringEnColor(string nuevoColor)
        {
            bool retorno = true;

            switch (nuevoColor.ToLower())
            {
                case "rojo":
                    this.color = Color.Red;
                    break;
                case "azul":
                    this.color = Color.Blue;
                    break;
                case "blanco":
                    this.color = Color.White;
                    break;
                case "verde":
                    this.color = Color.Green;
                    break;
                default:
                    retorno=false; break;

            }
            return retorno;

        }

        public override string ToString()
        {
            return this.AutoToString();
        }

    }
}
