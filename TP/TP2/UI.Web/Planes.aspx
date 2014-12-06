<%@ Page Title="Planes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdPlanes" runat="server" CssClass="contenedor">

 <script type="text/javascript" language="javascript">
        $(document).ready(function () {
            $("#bodyForm").validate({
                rules: {
                    <%=txtDesc.UniqueID %>: { required: true }
                },
                messages: {
                    <%=txtDesc.UniqueID %>: { required: " Este campo es obligatorio.", }
                },
            });
        })
</script>

    <asp:GridView ID="GridViewPlanes" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged"
        CssClass="gridView">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
            <asp:BoundField DataField="DescEspecialidad" HeaderText="Especialidad" />
            <asp:CommandField SelectText="Seleccionar" ShowSelectButton="true" />
        </Columns>
        <SelectedRowStyle BackColor="Black" ForeColor="White" />
    </asp:GridView>

</asp:Panel>

<asp:Panel ID="formPanelPlan" visible="false" runat="server" CssClass="contenedor">
    <table class="table">
        <tr>
            <td>
                <asp:Label ID="lblDesc" runat="server" Text="Descripcion: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEspecialidad" runat="server" Text="Especialidad: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="dpdEspecialidad" runat="server" 
                    DataSourceID="odsEspecialidad" DataTextField="Descripcion" DataValueField="ID">
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
        <asp:ObjectDataSource ID="odsEspecialidad" runat="server" SelectMethod="GetAll" 
        TypeName="Business.Logic.EspecialidadLogic"></asp:ObjectDataSource>
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
        <asp:LinkButton ID="lnkVolver" runat="server" onclick="lnkVolver_Click">Atras</asp:LinkButton>
        <asp:ValidationSummary ID="ValidationSummary" runat="server" />
    </asp:Panel>

</asp:Content>

