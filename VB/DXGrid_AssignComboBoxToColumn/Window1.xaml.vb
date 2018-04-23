Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace DXGrid_AssignComboBoxToColumn
    Partial Public Class Window1
        Inherits Window
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub TableView_CellValueChanging(ByVal sender As Object, ByVal e As CellValueEventArgs)
            Dim view As TableView = TryCast(sender, TableView)
            view.PostEditor()
            Me.Title = view.Grid.GetCellValue(e.RowHandle, e.Column.FieldName).ToString()
        End Sub

    End Class

    Public Class NwindData
        Public Shared ReadOnly Property Data() As nwindDataSet.ProductsDataTable
            Get
                Return New nwindDataSetTableAdapters.ProductsTableAdapter().GetData()
            End Get
        End Property
    End Class

End Namespace
