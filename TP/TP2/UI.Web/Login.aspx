<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">


    <h1 id="tituloLogin">Bienvenido al Sistema de gestión académica</h1>
    <div class="contenedor">
        <table class="table">
            <tr>
                <td>
        <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>

                </td>
                <td>

        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </td>
                <td>

                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" 
                        ControlToValidate="txtUsuario" ErrorMessage="Debe ingresar el nombre de usuario" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>

                    </td>
            </tr>
            <tr>
                <td>

        <asp:Label ID="lblPass" runat="server" Text="Password:" style="text-align: center"></asp:Label>

                </td>
                <td>

        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                <td>

                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                        ControlToValidate="txtPass" ErrorMessage="Debe ingresar el password" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    </td>
            </tr>
        </table>
    </div>

        <asp:Button ID="btnIngresar" runat="server" onclick="btnIngresar_Click" 
            Text="Ingresar" CssClass="submitButton"/>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

</asp:Content>

