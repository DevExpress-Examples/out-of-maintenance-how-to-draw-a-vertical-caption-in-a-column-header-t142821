using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyXtraGrid {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        private BindingList<Customer> customers;
        public Form1() {
            InitializeComponent();
            FillGridDataSource();
            InitGridView();
        }
        private void InitGridView() {
            myGridView1.ColumnPanelRowHeight = verticalColumnHeaderPanel;
            myGridView1.CustomDrawColumnHeader += myGridView1_CustomDrawColumnHeader;
        }
        private int verticalColumnHeaderPanel = 85;
        private void myGridView1_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e) {            
            if (e.Column != null && !e.Column.Visible) {
                return;
            }
            DrawVertical(e);
        }
        static StringFormat stringFormat = new StringFormat() { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap };
        private static void DrawVertical(DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            e.Info.Caption = string.Empty;
            e.Painter.DrawObject(e.Info);

            if (e.Column != null)
            {
                e.Cache.DrawVString(e.Column.GetTextCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), e.Info.CaptionRect, stringFormat, 90);
            }
            e.Handled = true;
        }
        private void FillGridDataSource() {
            customers = new BindingList<Customer>();
            for (var i = 0; i < 50; i++) {
                var customer = new Customer();
                customer.Name = "Mike";
                if (i % 2 == 0) {
                    customer.Name = "John";
                }
                customer.Age = 70 - i;
                customer.Weight = 50 + i;
                customer.Height = 150 + i;
                customers.Add(customer);
            }
            myGridControl1.DataSource = customers;
        }
    }
}
