# How to add custom interactivity to a dashboard displayed in the Web Viewer


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15364">Web Viewer</a> allows you to add a custom interactivity to dashboards using the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboardViewer_ItemVisualInteractivitytopic">ItemVisualInteractivity</a> event.<br>This example demonstrates the following capabilities

* The <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15150">Grid</a> dashboard item allows you to select categories and visualize a corresponding product quantity using the <a href="http://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/dxBarGauge/">dxBarGauge</a> widget. Note that the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument15706">hidden</a> 'Quantity' measure is used to pass the required values to the <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument17375">client</a>.
* The <a href="http://documentation.devexpress.com/#Dashboard/CustomDocument14719">Chart</a> dashboard item highlights bars corresponding to a hovered argument value.

<br/>


