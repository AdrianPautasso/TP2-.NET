<%@ Page Title="Usuarios" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="UI.Web.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

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
            <td style="width: 142px">
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
            <td style="width: 142px">
                <asp:CheckBox ID="habilitadoCheckBox" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="nombreUsuarioLabel" runat="server" Text="Usuario: "></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:TextBox ID="nombreUsuarioTextBox" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="claveLabel" runat="server" Text="Clave: "></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:TextBox ID="claveTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="repetirClaveLabel" runat="server" Text="Repetir Clave: "></asp:Label>
            </td>
            <td style="width: 142px">
                <asp:TextBox ID="repetirclaveTextBox" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
    </table>
            <ul>
                <li>
                    <asp:LinkButton ID="lnkAceptar2" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
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
                <asp:LinkButton ID="aceptarLinkButton" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
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

    <asp:Panel ID="PanelLogin" runat="server">
        <asp:Button ID="btnVolver" runat="server" Text="Volver" onclick="btnVolver_Click" CssClass="submitButton"/>
    </asp:Panel>

</asp:Content>