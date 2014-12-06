<%@ Page Title="Administradores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administradores.aspx.cs" Inherits="UI.Web.Administradores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdPersona" runat="server" CssClass="contenedor">

 <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtNombre.UniqueID %>: { required: true },
                    <%=txtApellido.UniqueID %>: { required: true },
                    <%=txtDireccion.UniqueID %>: { required: true },
                    <%=txtEmail.UniqueID %>: { required: true, email: true },
                    <%=txtTelefono.UniqueID %>: { required: true },
                    <%=txtFecNac.UniqueID %>: { required: true }
                },
                messages: {
                    <%=txtNombre.UniqueID %>: { required: " Este campo es obligatorio.", },
                    <%=txtApellido.UniqueID %>: { required: " Este campo es obligatorio." },
                    <%=txtDireccion.UniqueID %>: { required: " Este campo es obligatorio." },
                    <%=txtEmail.UniqueID %>: { required: " Este campo es obligatorio.", email: "Debe ser un email (ejemplo@email.com)." },
                    <%=txtTelefono.UniqueID %>: { required: " Este campo es obligatorio." },
                    <%=txtFecNac.UniqueID %>: { required: " Este campo es obligatorio." }
                },
            });
        })
</script>

        <asp:GridView ID="GridViewPer" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID"/>
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

    <asp:Panel ID="formPanelPer" visible="false" runat="server" CssClass="contenedor">
        <table class="table" id="dosColumnas">
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
                    <asp:TextBox ID="txtFecNac" runat="server" Text='<%# Bind("DateofBirth") %>' TextMode="Date"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="Label10" runat="server" Text="Tipo Persona:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dblTipoPersona" runat="server" 
                        DataSourceID="odsTipoPersona" DataTextField="Descripcion" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsTipoPersona" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.TipoPersonaLogic"></asp:ObjectDataSource>
                </td>
            </tr>

        </table>
            <ul>
                <li>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" onclick="btnAceptar_Click" CssClass="btnAceptar"/>
                    <asp:LinkButton ID="lnkCancelar2" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </li>
            </ul>
    </asp:Panel>

    <asp:Panel ID="formActionPanel" Visible="false" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:Button ID="btnAceptar2" runat="server" onclick="btnAceptar_Click" Text="Aceptar" CssClass="btnAceptar"/>
                <asp:LinkButton ID="cancelarLinkButton" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
            </li>
        </ul> 
        </asp:Panel>

<asp:Panel ID="gridActionPanel" runat="server" CssClass="contenedor">
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
        <asp:LinkButton ID="lnkVolver" runat="server" onclick="lnkVolver_Click">Atras</asp:LinkButton>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </asp:Panel>

</asp:Content>
