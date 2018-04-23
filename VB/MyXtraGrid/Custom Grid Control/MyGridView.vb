Imports System

Namespace MyXtraGrid
    Public Class MyGridView
        Inherits DevExpress.XtraGrid.Views.Grid.GridView

        Public Sub New()
            Me.New(Nothing)
        End Sub
        Public Sub New(ByVal grid As DevExpress.XtraGrid.GridControl)
            MyBase.New(grid)
        End Sub
        Protected Overrides ReadOnly Property ViewName() As String
            Get
                Return "MyGridView"
            End Get
        End Property
        Protected Overrides Function CreateCustomizationForm() As DevExpress.XtraGrid.Views.Grid.Customization.CustomizationForm
            Return New CustomizationFormEx(Me)
        End Function

        Public ReadOnly Property CustomColumnRowHeight() As Integer
            Get
                Return 20
            End Get
        End Property
    End Class
End Namespace
