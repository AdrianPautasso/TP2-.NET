<%@ Page Title="Cursos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

<asp:Panel ID="grdCursos" runat="server" CssClass="contenedor">

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

    <asp:Panel ID="formPanelCursos" visible="false" runat="server">

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
                 <td>
                    <asp:RequiredFieldValidator ID="rfvCupo" runat="server" 
                    ControlToValidate="txtCupo" 
                    ErrorMessage="Debe ingresar el cupo" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvCupo" runat="server" ControlToValidate="txtCupo" 
                        ErrorMessage="El cupo maximo es de 50 alumnos" ForeColor="Red" MaximumValue="50" 
                        MinimumValue="1" Type="Integer"></asp:RangeValidator>
                </td>
            </tr>
                 <tr>
                     <td>
                         <asp:Label ID="lblAnioCalendario" runat="server" Text="Anio Calendario:"></asp:Label>
                     </td>
                     <td>
                         <asp:TextBox ID="txtAnioCalendario" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="rfvAnioCalendario" runat="server" 
                             ControlToValidate="txtAnioCalendario" 
                             ErrorMessage="Debe ingresar el anio calendario" ForeColor="Red">*</asp:RequiredFieldValidator>
                     </td>
            </tr>
        </table>
            <ul>
                <li>
                    <asp:LinkButton ID="lnkAceptar2" runat="server" onclick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
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
        <asp:Button ID="btnVolver" runat="server" Text="Atras" 
            onclick="btnVolver_Click" CssClass="submitButton"/>
        <br />
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    </asp:Panel>


</asp:Content>
