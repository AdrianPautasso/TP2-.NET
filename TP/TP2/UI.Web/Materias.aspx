<%@ Page Title="Materias" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdMateria" runat="server" CssClass="contenedor">

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
                <td>
                    <asp:TextBox ID="txtMateria" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvMateria" runat="server" 
                        ControlToValidate="txtMateria" ErrorMessage="Debe ingresar la materia" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsSemanales" runat="server" Text="Horas Semanales:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsSem" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvHsSemanales" runat="server" 
                        ControlToValidate="txtHsSem" ErrorMessage="Debe ingresar las horas semanales" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvHsSemanales" runat="server" 
                        ControlToValidate="txtHsSem" 
                        ErrorMessage="Las horas semanales son de 2 a 8 hs" ForeColor="Red" 
                        MaximumValue="8" MinimumValue="2" Type="Integer">*</asp:RangeValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblHsTotales" runat="server" Text="Horas Totales:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtHsTot" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvHsTotales" runat="server" 
                        ControlToValidate="txtHsTot" ErrorMessage="Debe ingresar las horas totales" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvHsTotales" runat="server" 
                        ControlToValidate="txtHsTot" 
                        ErrorMessage="Las horas totales son de 100 a 200 hs" MaximumValue="200" 
                        MinimumValue="100" ForeColor="Red">*</asp:RangeValidator>
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
                    <asp:LinkButton ID="lnkAceptar2" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
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

    <asp:Panel ID="panelLogin" runat="server">
        <asp:Button ID="btnVolver" runat="server" Text="Atras" 
            onclick="btnVolver_Click" CssClass="submitButton"/>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

    </asp:Panel>

</asp:Content>