<%@ Page Title="Personas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdPersona" runat="server" CssClass="contenedor">

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
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" 
                        ControlToValidate="txtNombre" ErrorMessage="Debe ingresar el nombre" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblApellido" runat="server" Text="Apellido:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" 
                        ControlToValidate="txtApellido" ErrorMessage="Debe ingresar el apellido" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblDireccion" runat="server" Text="Direccion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" 
                        ControlToValidate="txtDireccion" ErrorMessage="Debe ingresar la direccion" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Debe ingresar el email" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                        ControlToValidate="txtEmail" ErrorMessage="Email incorrecto" 
                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>
                    <asp:Label ID="lblTelefono" runat="server" Text="Telefono:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" 
                        ControlToValidate="txtTelefono" ErrorMessage="Debe ingresar el telefono" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblFecNac" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtFecNac" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="fvFecNac" runat="server" 
                        ControlToValidate="txtFecNac" 
                        ErrorMessage="Debe ingresar la fecha de nacimiento" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:Label ID="lblLegajo" runat="server" Text="Legajo:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLegajo" runat="server" 
                        ControlToValidate="txtLegajo" ErrorMessage="Debe ingresar el legajo" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
            <ul>
                <li>
                    <asp:LinkButton ID="lnkAceptar2" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                    <asp:LinkButton ID="lnkCancelar2" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </li>
            </ul>
    </asp:Panel>

    <asp:Panel ID="formActionPanel" Visible="false" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:LinkButton ID="aceptarLinkButton" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
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
        <asp:Button ID="btnVolver" runat="server" Text="Atras" 
            onclick="btnVolver_Click" CssClass="submitButton"/>

        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

    </asp:Panel>

</asp:Content>