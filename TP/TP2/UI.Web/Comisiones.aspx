<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="grdComision" runat="server" CssClass="contenedor">

     <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtAnioDesc.UniqueID %>: { required: true, number: true, min: 1, max: 5 },
                    <%=txtDesc.UniqueID %>: { required: true, number: true }
                },
                messages: {
                    <%=txtAnioDesc.UniqueID %>: { required: " Este campo es obligatorio.", number: "Ingrese el año en dígitos.", min: "El año mínimo es 1.", max: "El año máximo es 5." },
                    <%=txtDesc.UniqueID %>: { required: " Este campo es obligatorio.", number: "La descripción de la comisión deben ser números (Ejemplo: 304)." }
                },
            });
        })
    </script>

        <asp:GridView ID="GridViewCom" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">

            <Columns>

                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
                <asp:BoundField DataField="AnioEspecialidad" HeaderText="Anio Especialidad" />
                <asp:BoundField DataField="DescPlan" HeaderText="Plan" />
                <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />

            </Columns>

            <SelectedRowStyle BackColor="Black" ForeColor="White" />

        </asp:GridView>

    </asp:Panel>

    <asp:Panel ID="formPanelCom" visible="false" runat="server" CssClass="contenedor">

        <table class="table">
            <tr>
                <td>
                    <asp:Label ID="lblDesc" runat="server" Text="Descripcion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAnioEsp" runat="server" Text="Anio Especialidad:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAnioDesc" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lnkPlan" runat="server" Text="Plan:"></asp:Label>
                </td>
                <td>
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
    </asp:Panel>

    <asp:Panel ID="formActionPanel" Visible="False" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:Button ID="btnAceptar2" runat="server" onclick="btnAceptar_Click" Text="Aceptar" CssClass="btnAceptar"/>
                <asp:LinkButton ID="lnkCancelar" runat="server" onclick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>      
            </li>
        </ul>
        </asp:Panel>

    <asp:Panel ID="gridActionPanel" runat="server"  CssClass="contenedor">
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
