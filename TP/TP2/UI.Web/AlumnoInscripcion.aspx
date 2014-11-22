<%@ Page Title="Alumno Inscripcion" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AlumnoInscripcion.aspx.cs" Inherits="UI.Web.AlumnoInscripcion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdComision" runat="server">

        <asp:GridView ID="GridViewCom" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged">

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

    <asp:Panel ID="formPanelCom" visible="false" runat="server">

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table 
            style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblAlumno" runat="server" Text="Alumno:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAlumno" runat="server" DataSourceID="odsAlum" 
                        DataTextField="NombreCompleto" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsAlum" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.PersonaLogic"></asp:ObjectDataSource>
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
                    <asp:ObjectDataSource ID="odsCurso" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCondicion" runat="server" Text="Condicion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCondicion" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNota" runat="server" Text="Nota:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />

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
