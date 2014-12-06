<%@ Page Title="Alumno" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Alumno.aspx.cs" Inherits="UI.Web.Alumno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
<div class="contenedor"
    <ul>
        <li>
            <asp:LinkButton ID="lnkUsuarios" runat="server" onclick="lnkUsuarios_Click">Usuario</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkPersonas" runat="server" onclick="lnkPersonas_Click">Persona</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkAlumInsc" runat="server" onclick="lnkAlumInsc_Click">Inscripciones</asp:LinkButton>
        </li>                
    </ul>
</div>
    <asp:Panel ID="panelLogin" runat="server">
        <asp:Button ID="btnVolver" runat="server" onclick="btnVolver_Click" 
                                Text="Atras" CssClass="submitButton"/>
    </asp:Panel>


</asp:Content>
