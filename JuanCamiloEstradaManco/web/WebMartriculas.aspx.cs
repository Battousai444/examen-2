using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LibITMParcial.ReglaNegocios;

namespace WebMatricula.webparcial2
{
    public partial class WebMartriculas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNCalcular_Click(object sender, EventArgs e)
        {
            string Carrera;
            Int16 CantidadHoras;
            Int16 Estrato;
            
            Carrera = DDLCarrera.Text;
            CantidadHoras = Convert.ToInt16(TXTHoras.Text);
            Estrato = Convert.ToInt16(DDLEstrato.SelectedValue);

            clsMatricula oMatricula = new clsMatricula();
            oMatricula.Carrera = Carrera;
            oMatricula.CantidadHoras = CantidadHoras;
            oMatricula.Estrato = Estrato;

            if (oMatricula.CalcularTotal())
            {
                if (Estrato == 6)

                {
                    LBLValorDescuento.Text = oMatricula.ValorDescuento.ToString("#,###") + "0";
                }
                else 
                {
                    LBLValorDescuento.Text = oMatricula.ValorDescuento.ToString("#,###") + "$";
                }
                LBLPorcentajeDescuento.Text = (oMatricula.PorcentajeDescuento * 100).ToString() + "%";
               
                LBLValorPagar.Text = oMatricula.ValorPagar.ToString("#,###") + "$";
                LBLTotalPagar.Text = oMatricula.TotalPagar.ToString("#,###") + "$";

                LBLError.Text = "";
            }
            else 
            {
                LBLError.Text = oMatricula.Error;


                LBLPorcentajeDescuento.Text = "-";
                LBLValorDescuento.Text = "-";
                LBLValorPagar.Text = "-";
                LBLTotalPagar.Text = "-";

            }

        }

        protected void BTNLimpiar_Click(object sender, EventArgs e)
        {
            LBLError.Text = "";


            LBLPorcentajeDescuento.Text = "-";
            LBLValorDescuento.Text = "-";
            LBLValorPagar.Text = "-";
            LBLTotalPagar.Text = "-";
        }
    }
}