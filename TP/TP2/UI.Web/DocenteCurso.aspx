<%@ Page Title="Docentes Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocenteCurso.aspx.cs" Inherits="UI.Web.DocenteCurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdDocentesCursos" runat="server" CssClass="contenedor">

        <asp:GridView ID="GridViewDocCur" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="NombreDocente" HeaderText="Nombre" />
                <asp:BoundField DataField="ApellidoDocente" HeaderText="Apellido" />
                <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescComision" HeaderText="Comision" />
                <asp:BoundField DataField="Cargo" HeaderText="Cargo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </asp:Panel>

    <asp:Panel ID="formPanelDocCur" visible="false" runat="server">

       <table class="table">
            <tr>
                <td>
                    <asp:Label ID="blDocente" runat="server" Text="Docente:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlDocente" runat="server" DataSourceID="odsDocente" 
                        DataTextField="NombreCompleto" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsDocente" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.PersonaLogic" 
                        OldValuesParameterFormatString="original_{0}">
                        <SelectParameters>
                            <asp:Parameter DefaultValue="2" Name="id_tipo_persona" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td style="height: 59px">
                    <asp:Label ID="blCurso" runat="server" Text="Curso:"></asp:Label>
                </td>
                <td style="height: 59px">
                    <asp:DropDownList ID="ddlCurso" runat="server" DataSourceID="odsCur" 
                        DataTextField="DescMateriaYComision" DataValueField="ID">
                    </asp:DropDownList>
                    <asp:ObjectDataSource ID="odsCur" runat="server" SelectMethod="GetAll" 
                        TypeName="Business.Logic.CursoLogic"></asp:ObjectDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCargo" runat="server" Text="Cargo:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCargo" runat="server">
                    </asp:DropDownList>
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

    <asp:Panel ID="formActionPanel" Visible="False" runat="server" CssClass="contenedor">
            <ul>
                <li>
                    <asp:LinkButton ID="lnkAceptar" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
                    <asp:LinkButton ID="lnkCancelar" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
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



    <asp:Panel ID="PanelLogin" runat="server">
        <asp:Button ID="btnVolver" runat="server" 
    Text="Atras" onclick="btnVolver_Click" CssClass="submitButton"/>
    </asp:Panel>

</asp:Content>
