<%@ Page Title="Personas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdPersona" runat="server">

        <asp:GridView ID="GridViewPer" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="Direccion" HeaderText="Direccion" />
                <asp:BoundField DataField="FechaNacimiento" HeaderText="Fecha de Nacimiento" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Telefono" HeaderText="Telefono" />
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="DescTipoPersona" HeaderText="Tipo de Persona" />
                <asp:BoundField DataField="DescPlan" HeaderText="Plan" />
                <asp:BoundField DataField="DescEspecialidad" HeaderText="Especialidad" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </asp:Panel>

    <asp:Panel ID="formPanelPer" visible="false" runat="server">
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtID" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFecNac" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFecNac" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="lblLegajo" runat="server" Text="Legajo:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblPlan" runat="server" Text="Plan:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dblPlan" runat="server" DataSourceID="odsPlan" 
                        DataTextField="DescPlanYEspecialidad" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsPlan" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Tipo Persona:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dblTipoPersona" runat="server" 
                        DataSourceID="odsTipoPersona" DataTextField="Descripcion" 
                        DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsTipoPersona" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.TipoPersonaLogic"></asp:ObjectDataSource>
                </td>
            </tr>
        </table>

    </asp:Panel>

    <asp:Panel ID="gridActionPanel" runat="server">

        <asp:LinkButton ID="lnkEditar" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lnkEliminar" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lnkNuevo" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
    
    </asp:Panel>

    <asp:Panel ID="formActionPanel" Visible="False" runat="server">

        <asp:LinkButton ID="lnkAceptar" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
        &nbsp;<asp:LinkButton ID="lnkCancelar" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    
    </asp:Panel>

    <asp:Panel ID="panelLogin" runat="server">
        <asp:Button ID="btnVolver" runat="server" Text="Volver" 
            onclick="btnVolver_Click" />

    </asp:Panel>

</asp:Content>
