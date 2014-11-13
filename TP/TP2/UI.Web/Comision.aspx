<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comision.aspx.cs" Inherits="UI.Web.Comision" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:Panel ID="grdComision" runat="server">
        <asp:GridView ID="GridViewCom" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="AnioEspecialidad" HeaderText="Anio Especialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
            </Columns>
            <SelectedRowStyle BackColor="Black" ForeColor="White" />
        </asp:GridView>
    </asp:Panel>

    <asp:Panel ID="formPanelCom" runat="server">
        <asp:Label ID="lblID" runat="server" Text="ID"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtID" runat="server" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblDesc" runat="server" Text="Descripcion"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblAnioEsp" runat="server" Text="Anio Especialidad"></asp:Label>
        &nbsp;<asp:TextBox ID="txtAnioDesc" runat="server"></asp:TextBox>
        <br />
    </asp:Panel>

    <asp:Panel ID="gridActionPanel" runat="server">
        <asp:LinkButton ID="lnkEditar" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lnkEliminar" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lnkNuevo" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    
    </asp:Panel>

    <asp:Panel ID="formActionPanel" runat="server">
        <asp:LinkButton ID="lnkAceptar" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lnkCancelar" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    
    </asp:Panel>
</asp:Content>
