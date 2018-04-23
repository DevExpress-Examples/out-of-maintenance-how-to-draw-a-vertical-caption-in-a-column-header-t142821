Imports DevExpress.XtraGrid.Views.Grid.Customization
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace MyXtraGrid
    Public Class ColumnCustomizationListBoxEx
        Inherits ColumnCustomizationListBox

        Public Sub New(ByVal form As CustomizationForm)
            MyBase.New(form)
        End Sub
        Public Overrides Function GetItemHeight() As Integer
            Dim view As MyGridView = TryCast(Me.View, MyGridView)
            If view IsNot Nothing Then
                Return view.CustomColumnRowHeight
            End If
            Return MyBase.GetItemHeight()
        End Function
    End Class
End Namespace
