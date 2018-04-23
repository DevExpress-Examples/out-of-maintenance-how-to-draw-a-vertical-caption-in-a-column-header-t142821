using DevExpress.XtraGrid.Views.Grid.Customization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyXtraGrid {
    public class ColumnCustomizationListBoxEx : ColumnCustomizationListBox {
        public ColumnCustomizationListBoxEx(CustomizationForm form)
            : base(form) {
        }
        public override int GetItemHeight() {
            MyGridView view = this.View as MyGridView;
            if(view != null)
                return view.CustomColumnRowHeight;
            return base.GetItemHeight();
        }
    }
}
