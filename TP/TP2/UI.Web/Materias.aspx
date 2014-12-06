<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdMateria" runat="server" CssClass="contenedor">

 <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtMateria.UniqueID %>: { required: true },
                    <%=txtHsSem.UniqueID %>: { required: true, number: true },
                    <%=txtHsTot.UniqueID %>: { required: true, number: true }
                },
                messages: {
                    <%=txtMateria.UniqueID %>: { required: " Este campo es obligatorio.", },
                    <%=txtHsSem.UniqueID %>: { required: " Este campo es obligatorio.", number: "Debe ser un número." },
                    <%=txtHsTot.UniqueID %>: { required: " Este campo es obligatorio.", number: "Debe ser un número." }
                },
            });
        })
</script>

        <asp:GridView ID="GridViewMat" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged" 
        CssClass="gridView">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Materia" />
                <asp:BoundField DataField="HSSemanales" HeaderText="Horas Semanales" />
                <asp:BoundField DataField="HSTotales" HeaderText="Horas Totales" />
                <asp:BoundField DataField="DescPlan" HeaderText="Plan" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </asp:Panel>

    <asp:Panel ID="formPanelMat" visible="false" runat="server" CssClass="contenedor">

       <table class="table">
            <tr>
                <td>
                    <asp:Label ID="lblMateria" runat="server" Text="Materia:"></asp:Label>
                </td>
                <td style="width: 165px">
                    <asp:TextBox ID="txtMateria" runat="server"></asp:TextBox> 
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsSemanales" runat="server" Text="Horas Semanales:"></asp:Label>
                </td>
                <td style="width: 165px">
                    <asp:TextBox ID="txtHsSem" runat="server"></asp:TextBox>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsTotales" runat="server" Text="Horas Totales:"></asp:Label>
                </td>
                <td style="width: 165px">
                    <asp:TextBox ID="txtHsTot" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lnkPlan" runat="server" Text="Plan:"></asp:Label>
                </td>
                <td style="width: 165px">
                    <asp:DropDownList ID="dpdPlan" runat="server" DataSourceID="obdPlan" 
                        DataTextField="DescPlanYEspecialidad" DataValueField="ID">
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
            <ul>
                <li>
                    <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" onclick="btnAceptar_Click" CssClass="btnAceptar"/>
                    <asp:LinkButton ID="lnkCancelar2" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
                </li>
            </ul>
        <asp:ObjectDataSource ID="obdPlan" runat="server" SelectMethod="GetAll" 
            TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
        <br />

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

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

    </asp:Panel>

</asp:Content>