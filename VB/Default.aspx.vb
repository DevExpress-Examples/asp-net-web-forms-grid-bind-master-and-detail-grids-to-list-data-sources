Imports System
Imports System.Data
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web
Imports System.Collections.Generic
Imports System.Linq

Namespace EditableDetails

    Public Partial Class _Default
        Inherits Page

        Public Property ParentData As List(Of Parent)
            Get
                If Session("ParentData") Is Nothing Then Session("ParentData") = DataHelper.CreateMasterData(5)
                Return CType(Session("ParentData"), List(Of Parent))
            End Get

            Set(ByVal value As List(Of Parent))
                Session("ParentData") = value
            End Set
        End Property

        Public Property ChildData As List(Of Child)
            Get
                If Session("ChildData") Is Nothing Then Session("ChildData") = DataHelper.CreateChildData(50, ParentData.Count)
                Return CType(Session("ChildData"), List(Of Child))
            End Get

            Set(ByVal value As List(Of Child))
                Session("ChildData") = value
            End Set
        End Property

        Protected Sub Page_Init(ByVal sender As Object, ByVal e As EventArgs)
            masterGrid.DataSource = ParentData
            masterGrid.DataBind()
        End Sub

        Protected Sub detailGrid_BeforePerformDataSelect(ByVal sender As Object, ByVal e As EventArgs)
            Dim detailGrid As ASPxGridView = CType(sender, ASPxGridView)
            Dim id As Integer = CInt(detailGrid.GetMasterRowKeyValue())
            Dim result = From q In ChildData Where q.ParentID = id Select q
            detailGrid.DataSource = result
        End Sub
    End Class
End Namespace
