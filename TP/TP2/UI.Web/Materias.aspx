<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdMateria" runat="server">

        <asp:GridView ID="GridViewMat" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged" Width="483px">

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

    <asp:Panel ID="formPanelMat" visible="false" runat="server">

       <table 
            style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="lblMateria" runat="server" Text="Materia:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMateria" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsSemanales" runat="server" Text="Horas Semanales:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsSem" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsTotales" runat="server" Text="Horas Totales:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsTot" runat="server"></asp:TextBox>
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
        <asp:ObjectDataSource ID="obdPlan" runat="server" SelectMethod="GetAll" 
            TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
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
