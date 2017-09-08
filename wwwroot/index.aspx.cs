using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BibliotecaPizzeria;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Array colors = Enum.GetValues(typeof(TipoPizza));
            foreach (TipoPizza color in colors)
            {
                DropDownList1.Items.Add(new ListItem(color.ToString(), ((int)color).ToString()));
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        string cliente = txtCliente.ToString();
        string telefono = txtTelefono.ToString();
        string direccion = txtDireccion.ToString();
        string detalle = txtDetalle.ToString();

        Session.Add("cliente", cliente);
        Session.Add("telefono", telefono);
        Session.Add("direccion", direccion);
        Session.Add("detalle", detalle);

        Server.Transfer("pedido.aspx");

    }
}