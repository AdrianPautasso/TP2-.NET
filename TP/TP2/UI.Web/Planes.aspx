<%@ Page Title="Planes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdPlanes" runat="server">
    <asp:GridView ID="GridViewPlanes" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="IdPlan" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="DescEspecialidad" HeaderText="Especialidad" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
        </Columns>
        <SelectedRowStyle BackColor="Black" ForeColor="White" />
    </asp:GridView>

</asp:Panel>

<asp:Panel ID="formPanelPlan" visible="false" runat="server">
    <asp:Label ID="lblDesc" runat="server" Text="Descripcion"></asp:Label>
    &nbsp;&nbsp;<asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad"></asp:Label>
    &nbsp;<asp:DropDownList ID="dpdEspecialidad" runat="server" 
        DataSourceID="odsEspecialidad" DataTextField="Descripcion" DataValueField="ID">
    </asp:DropDownList>
    <asp:ObjectDataSource ID="odsEspecialidad" runat="server" SelectMethod="GetAll" 
        TypeName="Business.Logic.EspecialidadLogic"></asp:ObjectDataSource>

</asp:Panel>

<asp:Panel ID="gridActionPanel" runat="server">
          <asp:LinkButton CssClass="linkButton" ID="nkEditar" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
    &nbsp;<asp:LinkButton CssClass="linkButton" ID="lnkEliminar" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
    &nbsp;<asp:LinkButton CssClass="linkButton" ID="lnkNuevo" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>

</asp:Panel>

<asp:Panel ID="formActionPanel" Visible="False" runat="server">
    <asp:LinkButton ID="lnkAceptar" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkCancelar" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>

</asp:Panel>

</asp:Content>

