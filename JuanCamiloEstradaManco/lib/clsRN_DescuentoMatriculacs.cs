using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LibITMParcial.ReglaNegocios
{
   public class clsRN_DescuentoMatriculacs
    {
        #region construc
        public clsRN_DescuentoMatriculacs()
        {
            Estrato = 0;
        }
        #endregion
        #region atributos/propiedades
        public Int16 Estrato { private get; set; }
        public Int16 CantidadHoras { private get; set; }
        public double PorcentajeDescuento { get; private set; }
        public string Error { get; private set; }

        #endregion
        #region metodos

        public bool CalcularDescuento() 
        {
            if (Validar()) 
            {
                try
                {
                    XmlDocument oDocumento = new XmlDocument();
                    oDocumento.Load(@"C:\Users\Acer\Desktop\uni\empresarial\parcial 2\LIB\LibITMParcial\XML\XML_PARCIAL2.xml");
                    string ConsultaXML = "/MATRICULA/DESCUENTO_MATRICULA/DESCUENTO[@ESTRATO=" + Estrato + "]";
                    XmlNodeList oNodos = oDocumento.SelectNodes(ConsultaXML);
                    if (oNodos.Count == 0)
                    {
                        Error = "No se obtuvo una respuesta válida. Consulte al administrador del sistema";
                        return false;
                    }
                    else
                    {
                        if (oNodos.Count > 1)
                        {
                            Error = "Se encontraron múltiples respuesta. Consulte al administrador del sistema";
                            return false;
                        }
                        else
                        {
                            PorcentajeDescuento = Convert.ToDouble(oNodos[0].InnerText) / 100;
                            return true;

                        }


                    }
                }
                catch (Exception ex)
                {
                    Error = ex.Message;
                    return false;
                }
            }
            else
            {
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
            if (CantidadHoras <= 0 || CantidadHoras >168) 
            {
                Error = "usted no estudia o estudia de mas por que no hay tantas horas en la semana y no se las podemos restar";
                return false;
            }
            return true;
        }

        #endregion
    }
}
