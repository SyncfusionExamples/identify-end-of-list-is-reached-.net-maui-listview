using Syncfusion.Maui.GridCommon.ScrollAxis;
using Syncfusion.Maui.ListView;
using Syncfusion.Maui.ListView.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region ListViewBehavior
    public class ListViewBehavior : Behavior<SfListView>
    {
        #region Fields

        SfListView ListView;
        VisualContainer VisualContainer;
        bool isAlertShown = false;
        int totalItems = 0;
        #endregion

        #region Overrides
        protected override void OnAttachedTo(SfListView bindable)
        {
            ListView = bindable;

            ListView.Loaded += ListView_Loaded;
            VisualContainer = ListView.GetVisualContainer();
            VisualContainer.ScrollRows.Changed += ScrollRows_Changed;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(SfListView bindable)
        {
            ListView.Loaded -= ListView_Loaded; 
            VisualContainer.ScrollRows.Changed -= ScrollRows_Changed;
            ListView = null;
            VisualContainer = null;
            base.OnDetachingFrom(bindable);
        }

        #endregion

        #region CallBacks

        private void ListView_Loaded(object sender, EventArgs e)
        {
            //To include header if used
            var header = (ListView.HeaderTemplate != null && !ListView.IsStickyHeader) ? 1 : 0;
            //To include footer if used
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

        #endregion
    }

    #endregion
}
