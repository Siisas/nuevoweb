﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="WebAppNomina.Eliminar" %>

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
                <li><a id ="A3" runat="server" href="~/Editar.aspx">Editar</a></li>
                <li><a id ="A2" runat="server" href="~/Consultar.aspx">Consultar</a></li>
                <li><a id ="A4" runat="server" href="~/CalcularSalario.aspx">Calcular Salario</a></li>
                 <li>Eliminar</li>
                 
            </ul>
        </nav>
    </header>
    <form id="form1" runat="server">
    <div>
    <h1>
        Eliminar Empleado
    </h1>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Identificacion" />
                    <asp:BoundField DataField="Apellidos" HeaderText="Apellidos" />
                    <asp:BoundField DataField="Nombres" HeaderText="Nombres" />
                    <asp:BoundField DataField="HorasTrabajadas" HeaderText="Horas Trabajadas" />
                    <asp:BoundField DataField="SueldoXHora" HeaderText="Sueldo Por hora" />
                    <asp:TemplateField HeaderText="Eliminar">
                        
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" Text="Eliminar" CausesValidation="False" CommandName="Delete"></asp:LinkButton>
                            
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </p>
    </div>
         <p>
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
