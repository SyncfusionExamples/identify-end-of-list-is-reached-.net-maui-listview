**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13167/how-to-identify-when-end-of-the-list-is-reached-on-scrolling-in-net-maui-listview)**

## Sample

```xaml
<listView:SfListView x:Name="listView" ItemsSource="{Binding BookInfo}" ItemSize="120">
        
<listView:SfListView.ItemTemplate>
    <DataTemplate>
        <StackLayout>
            <StackLayout Margin="10,0,0,0" VerticalOptions="StartAndExpand">
                <Label Text="{Binding BookName}" FontAttributes="Bold" FontSize="20" TextColor="Teal" VerticalOptions="CenterAndExpand"/>
                <Label Text="{Binding BookDescription}" FontSize="14" TextColor="Teal" VerticalOptions="StartAndExpand"/>
            </StackLayout>
            <BoxView HeightRequest="1" BackgroundColor="Teal" />
        </StackLayout>
    </DataTemplate>
</listView:SfListView.ItemTemplate>
</listView:SfListView>

C#:

ListView.Loaded += ListView_Loaded;
VisualContainer = ListView.GetVisualContainer();
VisualContainer.ScrollRows.Changed += ScrollRows_Changed;

private void ListView_Loaded(object sender, EventArgs e)
{
    var header = (ListView.HeaderTemplate != null && !ListView.IsStickyHeader) ? 1 : 0;
    var footer = (ListView.FooterTemplate != null && !ListView.IsStickyFooter) ? 1 : 0;
    totalItems = ListView.DataSource.DisplayItems.Count + header + footer;
}

private void ScrollRows_Changed(object sender, ScrollChangedEventArgs e)
{
    var lastIndex = VisualContainer.ScrollRows.LastBodyVisibleLineIndex;

    if (lastIndex != -1 && (lastIndex == totalItems - 1))
    {
        if (!isAlertShown)
        {
            App.Current.MainPage.DisplayAlert("Alert", "End of list reached...", "Ok");
            isAlertShown = true;
        }
    }
    else isAlertShown = false;
}
```
