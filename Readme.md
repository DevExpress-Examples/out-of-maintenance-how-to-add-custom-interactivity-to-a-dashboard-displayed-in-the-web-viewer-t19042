<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128580065/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T190426)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Dashboard1.cs](./CS/Dashboard_CustomVisualInteractivity_Web/Dashboard1.cs) (VB: [Dashboard1.vb](./VB/Dashboard_CustomVisualInteractivity_Web/Dashboard1.vb))
* [CustomInteractivity.js](./CS/Dashboard_CustomVisualInteractivity_Web/Scripts/CustomInteractivity.js) (VB: [CustomInteractivity.js](./VB/Dashboard_CustomVisualInteractivity_Web/Scripts/CustomInteractivity.js))
* [WebForm1.aspx](./CS/Dashboard_CustomVisualInteractivity_Web/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_CustomVisualInteractivity_Web/WebForm1.aspx))
<!-- default file list end -->
# How to add custom interactivity to a dashboard displayed in the Web Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t190426/)**
<!-- run online end -->


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15364">Web Viewer</a> allows you to add a custom interactivity to dashboards using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemVisualInteractivitytopic">ItemVisualInteractivity</a> event.<br>This example demonstrates the following capabilities

* The <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15150">Grid</a> dashboard item allows you to select categories and visualize a corresponding product quantity using the <a href="http://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/dxBarGauge/">dxBarGauge</a> widget. Note that the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15706">hidden</a> 'Quantity' measure is used to pass the required values to the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17375">client</a>.
* The <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument14719">Chart</a> dashboard item highlights bars corresponding to a hovered argument value.

<br/>


