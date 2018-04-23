using DevExpress.XtraGrid.Views.Grid.Customization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyXtraGrid {
    public class CustomizationFormEx : CustomizationForm {
        public CustomizationFormEx(DevExpress.XtraGrid.Views.Grid.GridView view)
            : base(view) {
        }
        protected override DevExpress.XtraEditors.Customization.CustomizationListBoxBase CreateCustomizationListBox() {
            return new ColumnCustomizationListBoxEx(this);
        }
    }
}
