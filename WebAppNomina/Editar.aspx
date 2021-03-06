﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="WebAppNomina.Editar" %>

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
               
                <li><a id ="A1" runat="server" href="~/Insertar.aspx">Insertar</a></li>
                <li><a id ="A2" runat="server" href="~/Consultar.aspx">Consultar</a></li>
                <li><a id ="A3" runat="server" href="~/Eliminar.aspx">Eliminar</a></li>
                <li><a id ="A4" runat="server" href="~/CalcularSalario.aspx">Calcular Salario</a></li>
                 <li>Editar</li>
                 
            </ul>
        </nav>
    </header>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Identificacion" />
                <asp:TemplateField HeaderText="Apellidos">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtApellidos" runat="server" Text='<%# Bind("Apellidos") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("Apellidos") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombres">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtNombres" runat="server" Text='<%# Bind("Nombres") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("Nombres") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Horas Trabajadas">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtHoras" runat="server" Text='<%# Bind("HorasTrabajadas") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("HorasTrabajadas") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sueldo por hora">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtSueldo" runat="server" Text='<%# Bind("SueldoXHora") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("SueldoXHora") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" />
            </Columns>
        </asp:GridView>
       
    </div>
        <p>
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
