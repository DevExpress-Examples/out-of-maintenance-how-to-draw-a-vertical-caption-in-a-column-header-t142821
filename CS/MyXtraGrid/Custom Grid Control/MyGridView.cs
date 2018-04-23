using System;

namespace MyXtraGrid {
    public class MyGridView : DevExpress.XtraGrid.Views.Grid.GridView {
        public MyGridView()
            : this(null) {
        }
        public MyGridView(DevExpress.XtraGrid.GridControl grid)
            : base(grid) {
        }
        protected override string ViewName {
            get {
                return "MyGridView";
            }
        }
        protected override DevExpress.XtraGrid.Views.Grid.Customization.CustomizationForm CreateCustomizationForm() {
            return new CustomizationFormEx(this);
        }

        public int CustomColumnRowHeight {
            get {
                return 20;
            }
        }
    }
}
