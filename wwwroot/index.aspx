<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
            <div>
                <h1>Menu de Ingreso de Pedidos</h1>
            </div>
            <div>
                <h3>Seleccion de Producto</h3>
                <br />
                Producto: <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                Cantidad: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            <div>
                <h3>Datos de Contacto</h3>
                
                Nombre Cliente <asp:TextBox ID="txtCliente" runat="server"></asp:TextBox><br />
                Telefono <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox><br />
                Direccion <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox><br />
                Detalle del Producto <asp:TextBox ID="txtDetalle" runat="server"></asp:TextBox><br />
                Agrega Propina <br />
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" OnClick="btnIngresar_Click" />
            </div>
    </div>
    </form>
</body>
</html>
