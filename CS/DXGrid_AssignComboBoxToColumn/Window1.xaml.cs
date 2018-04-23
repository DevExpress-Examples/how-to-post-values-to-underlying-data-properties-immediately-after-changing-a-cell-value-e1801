using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;
using System.Data;

namespace DXGrid_AssignComboBoxToColumn {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void TableView_CellValueChanging(object sender, DevExpress.Xpf.Grid.CellValueEventArgs e) {
            TableView view = sender as TableView;
            view.PostEditor();
            this.Title = view.Grid.GetCellValue(e.RowHandle,e.Column.FieldName).ToString();
        }
    }
    public class NwindData {
        public static nwindDataSet.ProductsDataTable Data {
            get { return new nwindDataSetTableAdapters.ProductsTableAdapter().GetData(); }
        }
    }
}
