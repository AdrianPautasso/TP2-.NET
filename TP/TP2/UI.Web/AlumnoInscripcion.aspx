<%@ Page Title="Alumno Inscripcion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoInscripcion.aspx.cs" Inherits="UI.Web.AlumnoInscripcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdInscripciones" runat="server" CssClass="contenedor">

        <asp:GridView ID="GridViewAlumInsc" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="NombreAlumno" HeaderText="Nombre" />
                <asp:BoundField DataField="ApellidoAlumno" HeaderText="Apellido" />
                <asp:BoundField DataField="LegajoAlumno" HeaderText="Legajo" />
                <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescComision" HeaderText="Comision" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
                <asp:BoundField DataField="Nota" HeaderText="Nota" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </asp:Panel>

    <asp:Panel ID="formPanelAlumInsc" visible="false" runat="server">

        <table class="table">
            <tr>
                <td>
                    <asp:Label ID="lblAlumno" runat="server" Text="Alumno:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAlumno" runat="server" DataSourceID="odsAlum" 
                        DataTextField="NombreCompleto" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsAlum" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.PersonaLogic" 
                        OldValuesParameterFormatString="original_{0}">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="1" Name="id_tipo_persona" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCurso" runat="server" Text="Curso"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCurso" runat="server" DataSourceID="odsCurso" 
                        DataTextField="DescMateriaYComision" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsCurso" runat="server" SelectMethod="GetConCupo" 
                        TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCondicion" runat="server" Text="Condicion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCondicion" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCondicion" runat="server" 
                        ControlToValidate="txtCondicion" ErrorMessage="Debe ingresar la condicion del alumno" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNota" runat="server" Text="Nota:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvNota" runat="server" 
                        ControlToValidate="txtNota" ErrorMessage="Debe ingresar la nota del alumno" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:RangeValidator ID="rvNota" runat="server" ControlToValidate="txtNota" 
                        ErrorMessage="RangeValidator" ForeColor="Red" MaximumValue="10" 
                        MinimumValue="0" Type="Integer">La nota debe tener un valor entre 0 y 10</asp:RangeValidator>
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

    <asp:Panel ID="gridActionPanel" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:LinkButton ID="lnkEditar" runat="server" OnClick="editarLinkButton_Click">Editar</asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="lnkEliminar" runat="server" OnClick="eliminarLinkButton_Click">Eliminar</asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="lnkNuevo" runat="server" OnClick="nuevoLinkButton_Click">Nuevo</asp:LinkButton>
            </li>
        </ul>
    </asp:Panel>
            
            
<asp:Panel ID="formActionPanel" runat="server" Visible="false" CssClass="contenedor">
            <ul>
                <li>
                    <asp:LinkButton ID="lnkAceptar" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                    <asp:LinkButton ID="lnkCancelar" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>        
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

