<%@ Page Title="Reporte Planes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportPlanes.aspx.cs" Inherits="UI.Web.ReportPlanes" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" 
        ReportSourceID="crsPlanes" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" 
        Width="1104px" EnableParameterPrompt="False" />
    <asp:Panel ID="panelLogin" runat="server">
        <asp:Button ID="lblVolver" runat="server" Text="Atras" 
            onclick="lblVolver_Click" style="text-align: right" CssClass="submitButton" />
    </asp:Panel>
    <CR:CrystalReportSource ID="crsPlanes" runat="server">
        <Report FileName="ReportePlanes.rpt">
        </Report>
    </CR:CrystalReportSource>
</asp:Content>
