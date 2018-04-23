Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace MyXtraGrid
    Public Class CustomizationFormEx
        Inherits CustomizationForm

        Public Sub New(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView)
            MyBase.New(view)
        End Sub
        Protected Overrides Function CreateCustomizationListBox() As DevExpress.XtraEditors.Customization.CustomizationListBoxBase
            Return New ColumnCustomizationListBoxEx(Me)
        End Function
    End Class
End Namespace
