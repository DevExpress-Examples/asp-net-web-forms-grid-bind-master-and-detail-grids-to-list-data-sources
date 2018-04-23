Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web

Namespace EditableDetails
	Public Class DataHelper
		Public Shared Function CreateMasterData(ByVal masterRowCount As Integer) As List(Of Parent)
			Dim parentList As List(Of Parent) = New List(Of Parent)()

			For i As Integer = 0 To masterRowCount - 1
				parentList.Add(New Parent() With {.ID = i, .Name = "Parent" & i.ToString()})
			Next i

			Return parentList
		End Function

		Public Shared Function CreateChildData(ByVal childRowCount As Integer, ByVal maxMasterIndex As Integer) As List(Of Child)
			Dim childList As List(Of Child) = New List(Of Child)()
			Dim r As New Random()

			For i As Integer = 0 To childRowCount - 1
				childList.Add(New Child() With {.ID = i, .Name = "Child" & i.ToString(), .ParentID = r.Next(maxMasterIndex)})
			Next i

			Return childList
		End Function
	End Class

	Public Class Parent
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
	End Class

	Public Class Child
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateName As String
		Public Property Name() As String
			Get
				Return privateName
			End Get
			Set(ByVal value As String)
				privateName = value
			End Set
		End Property
		Private privateParentID As Integer
		Public Property ParentID() As Integer
			Get
				Return privateParentID
			End Get
			Set(ByVal value As Integer)
				privateParentID = value
			End Set
		End Property
	End Class

End Namespace