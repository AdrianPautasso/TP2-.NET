<%@ Page Title="Comisiones" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <asp:Panel ID="grdComision" runat="server" CssClass="contenedor">

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

    <asp:Panel ID="formPanelCom" visible="false" runat="server">

        <table class="table">
            <tr>
                <td>
                    <asp:Label ID="lblDesc" runat="server" Text="Descripcion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" 
                        ControlToValidate="txtDesc" ErrorMessage="Debe ingresar la descripcion" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAnioEsp" runat="server" Text="Anio Especialidad:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAnioDesc" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvAnioEsp" runat="server" 
                        ControlToValidate="txtAnioDesc" ErrorMessage="Debe ingresar el anio" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
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
    </asp:Panel>

    <asp:Panel ID="formActionPanel" Visible="False" runat="server" CssClass="contenedor">
        <ul>
            <li>
                <asp:LinkButton ID="lnkAceptar" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
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



    <asp:Panel ID="PanelLogin" runat="server">
        <asp:Button ID="btnVolver" runat="server" Text="Atras" 
            onclick="btnVolver_Click" CssClass="submitButton" />
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </asp:Panel>

</asp:Content>
