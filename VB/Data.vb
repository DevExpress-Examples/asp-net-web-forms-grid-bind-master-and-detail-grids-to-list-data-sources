Imports System
Imports System.Collections.Generic

Namespace EditableDetails

    Public Class DataHelper

        Public Shared Function CreateMasterData(ByVal masterRowCount As Integer) As List(Of Parent)
            Dim parentList As List(Of Parent) = New List(Of Parent)()
            For i As Integer = 0 To masterRowCount - 1
                parentList.Add(New Parent() With {.ID = i, .Name = "Parent" & i.ToString()})
            Next

            Return parentList
        End Function

        Public Shared Function CreateChildData(ByVal childRowCount As Integer, ByVal maxMasterIndex As Integer) As List(Of Child)
            Dim childList As List(Of Child) = New List(Of Child)()
            Dim r As Random = New Random()
            For i As Integer = 0 To childRowCount - 1
                childList.Add(New Child() With {.ID = i, .Name = "Child" & i.ToString(), .ParentID = r.Next(maxMasterIndex)})
            Next

            Return childList
        End Function
    End Class

    Public Class Parent

        Public Property ID As Integer

        Public Property Name As String
    End Class

    Public Class Child

        Public Property ID As Integer

        Public Property Name As String

        Public Property ParentID As Integer
    End Class
End Namespace
