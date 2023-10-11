using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibITMParcial.ReglaNegocios
{
   public class clsMatricula
    {
        #region constructor
        public clsMatricula()
        {
            ValorHora = 0;
        }
            #endregion
       #region  atributos/propiedades
       public Int16 Estrato  {private get; set; }
       public Int16 CantidadHoras  {private get; set; }
       public string Carrera { private get; set; }
       public double ValorDescuento{  get; private set; }
        public double ValorPagar { get; private set; }
       
        public double TotalPagar { get; private set; }
        public string Error { get; private set; }
        public double PorcentajeDescuento { get; private set; }
        private double ValorHora;

        #endregion

        #region metodos

        public bool CalcularTotal() 
        {
            if (Validar())
            {
                if (CalcularValorHoras())
                {
                    ValorPagar = ValorHora * CantidadHoras;
                    if (CalcularDescuento())
                    {
                        TotalPagar = ValorPagar - ValorDescuento;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
        }


        private bool CalcularValorHoras() 
        {
            switch (Carrera.ToUpper())
            {
                case "INGENIERIA":
                    ValorHora  = 35000;
                    return true;
                case "TECNOLOGIA":
                    ValorHora = 22500;
                    return true;
                default:
                    Error = "No escogio una carrera.";
                    return false;
            }
        }

        private bool Validar()
        {
            if (Estrato <= 0 || Estrato > 6)
            {
                Error = "no se definio un estrato valido(debe ser entre 1-6)";
                return false;
            }
            if (CantidadHoras <= 0 || CantidadHoras > 168)
            {
                Error = "usted no estudia o estudia de mas por que no hay tantas horas en la semana y no se las podemos restar";
                return false;
            }
            return true;
        }
        private bool CalcularDescuento()
        {
            
            clsRN_DescuentoMatriculacs oDescuento = new clsRN_DescuentoMatriculacs();
            oDescuento.Estrato = Estrato;
            oDescuento.CantidadHoras = CantidadHoras;
            
            if (oDescuento.CalcularDescuento())
            {
               
                PorcentajeDescuento = oDescuento.PorcentajeDescuento;
                ValorDescuento = ValorPagar * PorcentajeDescuento;
                return true;
            }
            else
            {
                
                Error = oDescuento.Error;
                return false;
            }
        }
        #endregion
    }
}
