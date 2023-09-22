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
                double vf = _valorFuturo;
                double vp = _valorPresente;
                double i = _tasaInteres;
                double result = Math.Log10(vf / vp) / Math.Log10(1 + i);
                return (int)result;

            }
            catch (Exception e)
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
            objSB.AppendFormat("Tasa de Interes : {0} % \n \n", _tasaInteres*100);
            objSB.AppendFormat("Periodo Tiempo  : {0} \n", obtenerPeriodoTiempo());
            return objSB.ToString();
        }
        #endregion
       
    }
}
