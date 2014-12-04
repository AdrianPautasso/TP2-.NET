<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportCursos.aspx.cs" Inherits="UI.Web.ReportCursos" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">

    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="True" EnableParameterPrompt="False" GroupTreeImagesFolderUrl="" 
        Height="1202px" ReportSourceID="crsCursos" ToolbarImagesFolderUrl="" 
        ToolPanelWidth="200px" Width="1104px" />
            <asp:Panel ID="Panel2" runat="server">
        <asp:Button ID="lblVolver" runat="server" Text="Atras" CssClass="submitButton" 
                    onclick="Button1_Click" />
    </asp:Panel>
    <CR:CrystalReportSource ID="crsCursos" runat="server">
        <Report FileName="ReporteCursos.rpt">
        </Report>
    </CR:CrystalReportSource>
</asp:Content>
