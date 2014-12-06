<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

 <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtNombreUsuario.UniqueID %>: { required: true },
                    <%=txtClave.UniqueID %>: { required: true },
                    <%=txtRepetirClave.UniqueID %>: { required: true }
                },
                messages: {
                    <%=txtNombreUsuario.UniqueID %>: { required: " Este campo es obligatorio.", },
                    <%=txtClave.UniqueID %>: { required: " Este campo es obligatorio." },
                    <%=txtRepetirClave.UniqueID %>: { required: " Este campo es obligatorio." }
                },
            });
        })
</script>

    <asp:Panel ID="grdUsuarios" runat="server" CssClass="contenedor">
    <asp:GridView ID="gridView" ShowHeaderWhenEmpty="True" runat="server" AutoGenerateColumns="false"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">
        <Columns>
        <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
        <asp:BoundField HeaderText="Apellido" DataField="Apellido"/>
        <asp:BoundField HeaderText="EMail" DataField="EMail" />
        <asp:BoundField HeaderText="Usuario" DataField="NombreUsuario"/>
        <asp:BoundField HeaderText="Habilitado" DataField="Habilitado" />
        <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true"/>
        </Columns>
        </asp:GridView>
</asp:Panel>


<asp:Panel ID="formPanel" Visible="false" runat="server" CssClass="contenedor">
    <table class="table">
        <tr>
            <td>
                <asp:Label ID="personaLabel" runat="server" Text="Persona:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="dpdPersonas" runat="server" 
                    DataSourceID="ObjectDataSource1" DataTextField="NombreCompleto" 
                    DataValueField="ID">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="habilitadoLabel" runat="server" Text="Habilitado: "></asp:Label>
            </td>
            <td>
                <asp:CheckBox ID="habilitadoCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRepetirClave" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
    </table>
            <ul>
                <li>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" onclick="btnAceptar_Click" CssClass="btnAceptar"/>
                    <asp:LinkButton ID="lnkCancelar2" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </li>
            </ul>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="GetAll" TypeName="Business.Logic.PersonaLogic">
    </asp:ObjectDataSource>
</asp:Panel>

<asp:Panel ID="formActionPanel" Visible="false" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:Button ID="btnAceptar2" runat="server" onclick="btnAceptar_Click" Text="Aceptar" CssClass="btnAceptar"/>
                <asp:LinkButton ID="cancelarLinkButton" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            </li>
        </ul> 
    </asp:Panel>

<asp:Panel ID="gridActionsPanel" runat="server" CssClass="contenedor">
    <ul>
        <li>
            <asp:LinkButton ID="editarLinkButton" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="elimnarLinkButton" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
        </li>
    </ul>
</asp:Panel>

    <asp:Panel ID="panelLogin" runat="server">
        <asp:LinkButton ID="lnkVolver" runat="server" onclick="lnkVolver_Click" CssClass="submitButton">Atras</asp:LinkButton>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </asp:Panel>

</asp:Content>