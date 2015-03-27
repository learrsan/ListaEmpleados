<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ListadoCaml.ascx.cs" Inherits="ListaEmpleados.ListadoCaml.ListadoCaml" %>
<asp:Label ID="lblSalario" runat="server" Text="Salario:"></asp:Label>
<asp:TextBox ID="txtSal" runat="server"></asp:TextBox>
<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click1" />
<asp:ListView ID="lstEmpleados" runat="server">
    <LayoutTemplate>
     <table runat="server" ID="tblDatos">
        <thead>
        <tr>
            <th>DNI</th>
            <th>Nombre</th>
            <th>Puesto</th>
            <th>Fecha de alta</th>
        </tr>
        </thead>
         <tbody>
            <tr runat="server" ID ="itemPlaceHolder"></tr>
         </tbody>

    </table>   
    </LayoutTemplate>
    <ItemTemplate>
        <tr runat="server">
            <td runat="server">
                <asp:Label runat="server" Text='<%# Eval("Title") %>'></asp:Label>
            </td>
            <td runat="server">
                <asp:Label runat="server" Text='<%# Eval("_x0062_183") %>'></asp:Label>
            </td>
            <td runat="server">
                <asp:Label runat="server" Text='<%# Eval("edyu") %>'></asp:Label>
            </td>
            <td runat="server">
                <asp:Label runat="server" Text='<%# Eval("s2z3") %>'></asp:Label>
            </td>
        </tr>
    </ItemTemplate>
</asp:ListView>

