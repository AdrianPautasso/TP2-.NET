<%@ Page Title="Especialidades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdEspecialidades" runat="server">
    <asp:GridView ID="GridViewEsp" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
        </Columns>

    </asp:GridView>

<asp:Panel ID="formPanelEsp" runat="server" >
    <br />
    <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblDesc" runat="server" Text="Descripcion:"></asp:Label>
    &nbsp; &nbsp;<asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
</asp:Panel>

<asp:Panel ID="gridActionPanelEsp" runat="server">
    <asp:LinkButton ID="lnkEditar" runat="server">Editar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkEliminar" runat="server">Eliminar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkNueva" runat="server">Nueva</asp:LinkButton>
</asp:Panel>

<asp:Panel ID="formActionPanelEsp" runat="server">
    <asp:LinkButton ID="lnkAceptar" runat="server">Aceptar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkCancelar" runat="server">Cancelar</asp:LinkButton>
</asp:Panel>
</asp:Panel>

</asp:Content>
