using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace webapp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {            

        }

        protected void submit_ServerClick(object sender, EventArgs e)
        {

// -----------------------------------------------------------------------------

            HtmlTableRow fila0 = new HtmlTableRow();

            fila0.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "Datos ingresados"
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRow fila1 = new HtmlTableRow();

            fila1.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "Caja de texto: " + text.Value
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRow fila2 = new HtmlTableRow();

            fila2.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "Combo: " + combo.Value
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRow fila3 = new HtmlTableRow();
            HtmlTableCell celdaImagen = new HtmlTableCell();

            celdaImagen.InnerText = "Imagen: ";
            celdaImagen.Controls.Add(saveFile());

            fila3.Controls.Add(celdaImagen);

// -----------------------------------------------------------------------------

            HtmlTableRow fila4 = new HtmlTableRow();

            fila4.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "CheckBox: " + getCheckBox()
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRow fila5 = new HtmlTableRow();

            fila5.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "Hipervínculo: " + web.HRef
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRow fila6 = new HtmlTableRow();

            fila6.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "Radio Button: " + getRadioButton()
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRow fila7 = new HtmlTableRow();

            fila7.Controls.Add(new HtmlTableCell
            {
                InnerHtml = "Campo Oculto: " + hidden.Value
            }
            );

// -----------------------------------------------------------------------------

            HtmlTableRowCollection filas = tabla2.Rows;
            filas.Add(fila0);
            filas.Add(fila1);
            filas.Add(fila2);
            filas.Add(fila3);
            filas.Add(fila4);
            filas.Add(fila5);
            filas.Add(fila6);
            filas.Add(fila7);
            tabla2.Visible = true;
        }

// ------------------------ MÉTODOS --------------------------------

        protected string getCheckBox()
        {
            string valor = "";
            if (checkboxSI.Checked == true)
            {
                valor = "SI";
            }
            else if (checkboxNO.Checked == true)
            {
                valor = "NO";
            }
            return valor;
        }

        protected string getRadioButton()
        {
            string valor = "";
            if (alta.Checked == true)
            {
                valor = "Alta";
            }
            else if (media.Checked == true)
            {
                valor = "Media";
            }
            else if (baja.Checked == true)
            {
                valor = "Baja";
            }
            return valor;
        }


        protected HtmlImage saveFile()
        {
            file.PostedFile.SaveAs("C:\\Users\\fsociety\\source\\repos\\WebFormHTML\\images\\imagen.jpg");
            HtmlImage imagen = new HtmlImage();
            imagen.Height = 100;
            imagen.Width = 180;
            imagen.Src = "images\\imagen.jpg";
            return imagen;
        }
    }
}