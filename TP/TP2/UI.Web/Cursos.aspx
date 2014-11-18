<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdCursos" runat="server">

        <asp:GridView ID="GridViewCursos" runat="server" AutoGenerateColumns="False" ShowHeaderWhenEmpty="True"
        SelectedRowStyle-BackColor="Black"
        SelectedRowStyle-ForeColor="White"
        DataKeyNames="ID"
        OnSelectedIndexChanged="gridView_SelectedIndexChanged">

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

    <asp:Panel ID="formPanelCursos" visible="false" runat="server">

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />&nbsp;<asp:Label 
            ID="lblMateria" runat="server" Text="Materia:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:DropDownList ID="dpbMaterias" runat="server" 
            DataSourceID="odsMaterias" DataTextField="Descripcion" 
            DataValueField="ID">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="odsMaterias" runat="server" SelectMethod="GetAll" 
            TypeName="Business.Logic.MateriaLogic"></asp:ObjectDataSource>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        <asp:Label ID="lblComision" runat="server" Text="Comisión:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="dpbComisiones" runat="server" 
            DataSourceID="odsComisiones" DataTextField="Descripcion" DataValueField="ID">
        </asp:DropDownList>
        <asp:ObjectDataSource ID="odsComisiones" runat="server" SelectMethod="GetAll" 
            TypeName="Business.Logic.ComisionLogic"></asp:ObjectDataSource>
        <br />
        &nbsp;<br />
        <asp:Label ID="lblAnioCalendario" runat="server" Text="Anio Calendario:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtAnioCalendario" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblCupo" runat="server" Text="Cupo:"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />

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


</asp:Content>
