<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" 
AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" 
Inherits="UI.Web.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" 
runat="server">

    <asp:Panel ID="gridPanel" runat="server" Height="235px">
        <asp:GridView ID="gridView" runat="server"
            AutoGenerateColumns="False"
            SelectedRowStyle-BackColor="Black"
            SelectedRowStyle-ForeColor="White"
            DataKeyNames="ID" >
            <Columns>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="EMail" HeaderText="EMail" />
                <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
                <asp:BoundField DataField="Habilitado" HeaderText="Habilitado" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </asp:Panel>

</asp:Content>
