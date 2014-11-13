<%@ Page Title="Especialidades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>

<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdEspecialidades" runat="server">
    <asp:GridView ID="GridViewEsp" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black"
        ShowHeaderWhenEmpty="True"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
        </Columns>

    </asp:GridView>

<asp:Panel ID="formPanelEsp" Visible="false" runat="server" >
    <asp:Label ID="lblDesc" runat="server" Text="Descripcion:"></asp:Label>
    &nbsp; &nbsp;<asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
</asp:Panel>

<asp:Panel ID="gridActionPanelEsp" runat="server">
    <asp:LinkButton ID="lnkEditar" OnClick="editarLinkButton_Click" runat="server">Editar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkEliminar" OnClick="eliminarLinkButton_Click" runat="server">Eliminar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkNueva" OnClick="nuevoLinkButton_Click" runat="server">Nueva</asp:LinkButton>
</asp:Panel>

<asp:Panel ID="formActionPanelEsp" Visible="false" runat="server">
    <asp:LinkButton ID="lnkAceptar" onclick="aceptarLinkButton_Click" runat="server">Aceptar</asp:LinkButton>
    &nbsp;<asp:LinkButton ID="lnkCancelar" onclick="cancelarLinkButton_Click" runat="server">Cancelar</asp:LinkButton>
</asp:Panel>
</asp:Panel>

</asp:Content>
