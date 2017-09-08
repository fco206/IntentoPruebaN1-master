using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string cliente = (string)(Session["cliente"]);
        string telefono = (string)(Session["telefono"]);
        string direccion = (string)(Session["direccion"]);
        string detalle = (string)(Session["detalle"]);

        
    }
}