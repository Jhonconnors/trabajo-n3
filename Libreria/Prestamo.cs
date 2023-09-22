using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_numero_3.Libreria
{
    internal class Prestamo : IPrestamo
    {
        #region"Atributos"
        private int _valorFuturo;
        private int _valorPresente;
        private float _tasaInteres;
        #endregion
        #region "Constructores"
        public Prestamo()
        {
            _valorFuturo = 0;
            _valorPresente = 0;
            _tasaInteres = 0.0F;
        }
        public Prestamo(int valorFuturo, int valorPresente, float tasaInteres)
        {
            _valorFuturo = valorFuturo;
            _valorPresente = valorPresente;
            _tasaInteres = tasaInteres;
        }

        #endregion
        #region"Propiedades"
        public int valorFuturo
        {
            set { _valorFuturo = value;}
            get { return _valorFuturo;}
        }
        public int valorPresente
        {
            set { _valorPresente = value; }
            get { return _valorPresente; }
        }
        public float tasaInteres
        {
            set { _tasaInteres = value; }
            get { return _tasaInteres; }
        }
        #endregion
        #region "Metodos"
        public int obtenerPeriodoTiempo()
        {
            try
            {
                int resultado = (int) Math.Floor(
                    Math.Log10(1564474 / 1000000) / Math.Log10(1+3.8F));
                Console.WriteLine(resultado);
                return resultado;

            }catch (Exception ex)
            {
                return -1;
            }
        }
        public string obtenerDatos()
        {
            StringBuilder objSB = new StringBuilder();
            objSB.AppendFormat("RESULTADOS \n \n");
            objSB.AppendFormat("Valor Futuro    : {0} \n", _valorFuturo);
            objSB.AppendFormat("Valor Presente  : {0} \n", _valorPresente);
            objSB.AppendFormat("Tasa de Interes : {0} % \n \n", _tasaInteres);
            objSB.AppendFormat("Periodo Tiempo  : {0} \n", obtenerPeriodoTiempo());
            return objSB.ToString();
        }
        #endregion
       
    }
}
