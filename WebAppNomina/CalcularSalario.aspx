﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalcularSalario.aspx.cs" Inherits="WebAppNomina.CalcularSalario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <header>
        <nav>
            <ul id ="Menu">
                <li>Menu</li>
                 <li>Calcular Salario</li>
                 <li><a id ="A2" runat="server" href="~/Editar.aspx">Editar</a></li>
                <li><a id ="A1" runat="server" href="~/Insertar.aspx">Insertar</a></li>
                <li><a id ="A3" runat="server" href="~/Eliminar.aspx">Eliminar</a></li>
                <li><a id ="A4" runat="server" href="~/Consultar.aspx">Consultar</a></li>
            </ul>
        </nav>
    </header>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Identificacion" />
                <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                <asp:BoundField DataField="Salario" HeaderText="Salario" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
