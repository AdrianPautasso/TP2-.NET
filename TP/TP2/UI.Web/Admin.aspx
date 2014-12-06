<%@ Page Title="Administrador" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="UI.Web.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <div class="contenedor">
    <ul>
        <li>
            <asp:LinkButton ID="lnkPersonas" runat="server" onclick="lnkPersonas_Click">Alumnos</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkAdministradores" runat="server" onclick="lnkAdmin_Click">Administradores</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkComisiones" runat="server" onclick="lnkComisiones_Click">Comisiones</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkCursos" runat="server" onclick="lnkCursos_Click">Cursos</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkDocentes" runat="server" onclick="lnkDocentes_Click">Docentes</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkMaterias" runat="server" onclick="lnkMaterias_Click">Materias</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkPlanes" runat="server" onclick="lnkPlanes_Click">Planes</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkEspecialidades" runat="server" onclick="lnkEspecialidades_Click">Especialidades</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkDocCurso" runat="server" onclick="lnkDocCurso_Click">Docentes Cursos</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkAlumInsc" runat="server" onclick="lnkAlumInsc_Click">Inscripciones</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkReporte1" runat="server" onclick="lnkReporte1_Click">Reporte Cursos</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="lnkReporte2" runat="server" onclick="lnkReporte2_Click1">Reporte Planes</asp:LinkButton>
        </li>
        <li>
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="lnkUsuarios_Click">Usuarios</asp:LinkButton>
        </li>              
    </ul>
</div>
    <asp:Panel ID="panelLogin" runat="server">
     <asp:Button ID="btnVolver" runat="server" onclick="btnVolver_Click" 
        CssClass="submitButton" Text="Atras"/>
    </asp:Panel>
</asp:Content>
