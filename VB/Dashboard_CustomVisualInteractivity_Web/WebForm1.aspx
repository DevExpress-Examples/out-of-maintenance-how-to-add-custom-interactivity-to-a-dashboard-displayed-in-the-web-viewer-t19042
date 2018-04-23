<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="WebForm1.aspx.vb" 
         Inherits="Dashboard_CustomVisualInteractivity_Web.WebForm1" %>

<%@ Register Assembly="DevExpress.Dashboard.v15.1.Web, Version=15.1.6.0, 
                       Culture=neutral, 
                       PublicKeyToken=b88d1754d700e49a"
             Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="display: inline-block; float: left;">
        <dx:ASPxDashboardViewer ID="ASPxDashboardViewer1" runat="server" 
            ClientInstanceName="webViewer" 
            CalculateHiddenTotals="true"
            DashboardSource="Dashboard_CustomVisualInteractivity_Web.Dashboard1" 
            ClientSideEvents-Loaded = "function() { createControls(); }" 
            ClientSideEvents-ItemSelectionChanged = "function(s, e) { applyCurrentSelection(e); }" 
            ClientSideEvents-ItemVisualInteractivity = "function(s, e) { addCustomInteractivity(e); }" 
            Height="600px" Width="800px">
        </dx:ASPxDashboardViewer>
    </div>
    <div id="barGauge" style="display: inline-block; float: left; width: 600px; height: 600px;"></div>
    </form>
</body>
</html>
<script type="text/javascript" src="<%=Page.ResolveClientUrl("~/Scripts/CustomInteractivity.js")%>">
</script>