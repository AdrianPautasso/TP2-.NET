<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdCursos" runat="server" CssClass="contenedor">

 <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtAnioCalendario.UniqueID %>: { required: true, number: true },
                    <%=txtCupo.UniqueID %>: { required: true, number: true, min: 0, max: 50 }
                },
                messages: {
                    <%=txtAnioCalendario.UniqueID %>: { required: " Este campo es obligatorio.", number: "Ingrese el año en dígitos." },
                    <%=txtCupo.UniqueID %>: { required: " Este campo es obligatorio.", number: "Debe ser un número entre 0 y 50.",
                                                min: "Debe ser un valor entre 0 y 50.", max: "Debe ser un valor entre 0 y 50."}
                },
            });
        })
</script>

        <asp:GridView ID="GridViewCursos" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescComision" HeaderText="Comision" />
                <asp:BoundField DataField="AnioCalendario" HeaderText="Anio Calendario" />
                <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </asp:Panel>

    <asp:Panel ID="formPanelCursos" visible="false" runat="server" CssClass="contenedor">

        <table class="table">
            <tr>
                <td>
                    <asp:Label ID="lblMateria" runat="server" Text="Materia:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dpbMaterias" runat="server" DataSourceID="odsMaterias" 
                        DataTextField="Descripcion" DataValueField="ID" style="margin-bottom: 0px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblComision" runat="server" Text="Comisión:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="dpbComisiones" runat="server" 
                        DataSourceID="odsComisiones" DataTextField="Descripcion" DataValueField="ID">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCupo" runat="server" Text="Cupo:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
                </td>
            </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblAnioCalendario" runat="server" Text="Anio Calendario:"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtAnioCalendario" runat="server"></asp:TextBox>
                     </td>
            </tr>
        </table>
            <ul>
                <li>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" onclick="btnAceptar_Click" CssClass="btnAceptar"/>
                    <asp:LinkButton ID="lnkCancelar2" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </li>
            </ul>
        <asp:ObjectDataSource ID="odsMaterias" runat="server" SelectMethod="GetAll" 
            TypeName="Business.Logic.MateriaLogic"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsComisiones" runat="server" SelectMethod="GetAll" 
            TypeName="Business.Logic.ComisionLogic"></asp:ObjectDataSource>

    </asp:Panel>

    <asp:Panel ID="formActionPanel" Visible="False" runat="server" CssClass="contenedor">
            <ul>
                <li>
                    <asp:Button ID="btnAceptar2" runat="server" onclick="btnAceptar_Click" Text="Aceptar" CssClass="btnAceptar"/>
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


    <asp:Panel ID="panelLogin" runat="server">
        <asp:LinkButton ID="lnkVolver" runat="server" onclick="lnkVolver_Click" CssClass="submitButton">Atras</asp:LinkButton>
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
    </asp:Panel>


</asp:Content>
