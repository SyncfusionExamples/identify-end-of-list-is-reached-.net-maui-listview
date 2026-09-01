# How to identify when end of the list is reached on scrolling in .NET MAUI ListView (SfListView)?

The [.NET MAUI ListView (SfListView)](https://www.syncfusion.com/maui-controls/maui-listview) allows you to identify when the end of the list is reached while scrolling. By using the [Changed](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.ScrollAxisBase.html#Syncfusion_Maui_GridCommon_ScrollAxis_ScrollAxisBase_Changed) event of [ScrollAxisBase](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.ScrollAxisBase.html) in [VisualContainer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.VisualContainer.html), you can determine if you have reached the last item in the list based on the [LastBodyVisibleLineIndex](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.GridCommon.ScrollAxis.ScrollAxisBase.html#Syncfusion_Maui_GridCommon_ScrollAxis_ScrollAxisBase_LastBodyVisibleLineIndex) property and underlying collection count.

You can get the item elements held by a scrollable visual container using the [GetVisualContainer](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.ListView.Helpers.SfListViewHelper.html#Syncfusion_Maui_ListView_Helpers_SfListViewHelper_GetVisualContainer_Syncfusion_Maui_ListView_SfListView_) helper method.

Download the
complete sample on [GitHub](https://github.com/SyncfusionExamples/identify-end-of-list-is-reached-.net-maui-listview "https://github.com/SyncfusionExamples/identify-end-of-list-is-reached-.net-maui-listview").

**Conclusion**

I hope you enjoyed learning how to identify when the end of the list is reached on scrolling in the .NET MAUI ListView.

You can refer to our .[NET MAUI ListView](https://www.syncfusion.com/maui-controls/maui-listview "https://www.syncfusion.com/maui-controls/maui-listview") feature tour page to learn about its
other groundbreaking feature representations and [documentation](https://help.syncfusion.com/maui/listview/getting-started "https://help.syncfusion.com/maui/listview/getting-started"), and how to quickly get
started with configuration specifications. Explore our [.NET MAUI ListView](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView "https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView")[example](https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView "https://github.com/syncfusion/maui-demos/tree/master/MAUI/ListView") to understand how to create and manipulate data.

For current customers, check out our components from the [License and
Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to
Syncfusion®, try our 30-day [free trial](https://www.syncfusion.com/downloads?utm_medium=ads&amp;utm_source=googleads&amp;utm_campaign=winforms-tier3&amp;gclid=CjwKCAjwgqejBhBAEiwAuWHioHGi37_0A3P4JtugQp2qh86mquGYgLZtYLQQRoKU62TzJldf_Bc3RxoCl6oQAvD_BwE)to check out our other controls.

Please let us know in the comments section if you have any queries or require
clarification. Contact us through our [support forums](https://www.syncfusion.com/forums/), [Direct-Trac](https://support.syncfusion.com/create), or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sflistview). We are always happy to assist you!
