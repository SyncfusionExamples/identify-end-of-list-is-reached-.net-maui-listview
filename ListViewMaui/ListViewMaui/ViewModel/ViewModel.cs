using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
    #region ViewModel
    public class ViewModel
    {
        #region Constructor

        public ViewModel()
        {
            GenerateSource();
        }

        #endregion

        #region Properties

        public ObservableCollection<BookInfo> BookInfo { get; set; }

        #endregion

        #region Generate Source

        private void GenerateSource()
        {
            BookInfoRepository bookinfo = new BookInfoRepository();
            BookInfo = bookinfo.GetBookInfo();
        }

        #endregion
    }
    #endregion
}
