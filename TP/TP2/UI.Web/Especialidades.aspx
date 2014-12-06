<%@ Page Title="Especialidades" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Especialidades" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="grdEspecialidades" runat="server" CssClass="contenedor">

     <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtDesc.UniqueID %>: { required: true }
                },
                messages: {
                    <%=txtDesc.UniqueID %>: { required: " Este campo es obligatorio.", }
                },
            });
        })
</script>

    <asp:GridView ID="GridViewEsp" runat="server" AutoGenerateColumns="False" SelectedRowStyle-BackColor="Black"
        ShowHeaderWhenEmpty="True"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
        </Columns>

    </asp:GridView>
</asp:Panel>

<asp:Panel ID="formPanelEsp" Visible="false" runat="server" CssClass="contenedor">

    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblDesc" runat="server" Text="Descripcion:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
            </td>
        </tr>

    </table>
            <ul>
                <li>
                    <asp:Button ID="btnAceptar" runat="server" onclick="btnAceptar_Click" Text="Aceptar" CssClass="btnAceptar"/>
                    <asp:LinkButton ID="lnkCancelar2" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </li>
            </ul>

    </asp:Panel>

<asp:Panel ID="gridActionPanelEsp" runat="server"  CssClass="contenedor">
    <ul>
        <li>
            <asp:LinkButton ID="lnkEditar" OnClick="editarLinkButton_Click" runat="server">Editar</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkEliminar" OnClick="eliminarLinkButton_Click" runat="server">Eliminar</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkNueva" OnClick="nuevoLinkButton_Click" runat="server">Nueva</asp:LinkButton>
        </li>
    </ul>
</asp:Panel>

<asp:Panel ID="formActionPanelEsp" Visible="false" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:Button ID="btnAceptar2" runat="server" onclick="btnAceptar_Click" Text="Aceptar" CssClass="btnAceptar"/>
                <asp:LinkButton ID="lnkCancelar" onclick="cancelarLinkButton_Click" runat="server">Cancelar</asp:LinkButton>    
            </li>
        </ul>
    </asp:Panel>

    <asp:Panel ID="panelLogin" runat="server">
        <asp:LinkButton ID="lnkVolver" runat="server" onclick="lnkVolver_Click">Atras</asp:LinkButton>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </asp:Panel>

</asp:Content>

