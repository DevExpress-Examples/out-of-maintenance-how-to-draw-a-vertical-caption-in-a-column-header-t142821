Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace MyXtraGrid
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private customers As BindingList(Of Customer)
        Public Sub New()
            InitializeComponent()
            FillGridDataSource()
            InitGridView()
        End Sub
        Private Sub InitGridView()
            myGridView1.ColumnPanelRowHeight = verticalColumnHeaderPanel
            AddHandler myGridView1.CustomDrawColumnHeader, AddressOf myGridView1_CustomDrawColumnHeader
        End Sub
        Private verticalColumnHeaderPanel As Integer = 85
        Private Sub myGridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs)
            If e.Column IsNot Nothing AndAlso (Not e.Column.Visible) Then
                Return
            End If
            DrawVertical(e)
        End Sub

        Private Shared Sub DrawVertical(ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs)
            Dim r As Rectangle
            r = e.Info.CaptionRect
            e.Info.Caption = String.Empty
            e.Painter.DrawObject(e.Info)
            If e.Column IsNot Nothing Then
                Dim state = e.Graphics.Save()
                Dim sf = New StringFormat()
                sf.Trimming = StringTrimming.EllipsisCharacter
                sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.NoWrap
                sf.FormatFlags = sf.FormatFlags Or StringFormatFlags.DirectionVertical
                e.Graphics.DrawString(e.Column.GetTextCaption(), e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), r, sf)
                e.Graphics.Restore(state)
            End If
            e.Handled = True
        End Sub
        Private Sub FillGridDataSource()
            customers = New BindingList(Of Customer)()
            For i = 0 To 49
                Dim customer = New Customer()
                customer.Name = "Mike"
                If i Mod 2 = 0 Then
                    customer.Name = "John"
                End If
                customer.Age = 70 - i
                customer.Weight = 50 + i
                customer.Height = 150 + i
                customers.Add(customer)
            Next i
            myGridControl1.DataSource = customers
        End Sub
    End Class
End Namespace
