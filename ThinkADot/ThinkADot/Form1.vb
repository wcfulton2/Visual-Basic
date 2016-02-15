'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Program Name: Think-A-Dot
' Description: A VB.Net remake of the classic game Think-A-Dot
' Programmed by: Bill Fulton
' Class: CIS 310 Online
' Date: 12 February 2016 - Winter 2016
'
' Board And Flipper object created by Dr. Glenn Cummings
'
' Flipper layout: 0    3    6
'                   2     5
'                 1    4    7
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Option Strict On

Public Class Form1

    Private flipperList As New List(Of Flipper)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'form load event
        populateList() 'call to populate list sub - add flippers to a list
    End Sub

    Private Sub leftBtn_Click(sender As Object, e As EventArgs) Handles leftBtn.Click 'Left button click event
        getFlipperNumber(1)
    End Sub

    Private Sub middleBtn_Click(sender As Object, e As EventArgs) Handles middleBtn.Click 'Middle button click event
        getFlipperNumber(2)
    End Sub

    Private Sub rightBtn_Click(sender As Object, e As EventArgs) Handles rightBtn.Click 'Right button click event
        getFlipperNumber(3)
    End Sub

    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click 'Reset button click event
        For Each flipper As Flipper In flipperList
            flipper.reset()
        Next flipper
    End Sub

    Private Sub populateList()
        For Each flipper As Control In Me.Controls 'populate the list with the flipper objects
            If TypeOf flipper Is Flipper Then
                flipperList.Add(CType(flipper, Flipper))
            End If
        Next flipper
        flipperList.Reverse() 'reverse the index of the list
    End Sub

    Private Sub getFlipperNumber(buttonNum As Integer) 'select the top flipper based on which button was pressed
        If buttonNum = 1 Then 'if Left button
            changeFlippers(0) 'top flipper is index 0
        ElseIf buttonNum = 2 'if Middle button
            changeFlippers(3) 'top flipper is index 3
        ElseIf buttonNum = 3 'if Right button
            changeFlippers(6) 'top flipper index is 6
        End If
    End Sub

    Private Function getFlipperPos(flipperNum As Integer) As Integer 'get the current position of a flipper
        Return flipperList.Item(flipperNum).Dot.ImageIndex()
    End Function

    Private Function isBottom(flipperNum As Integer) As Boolean 'check and return if a flipper is on the bottom of the board
        If flipperNum = 1 Or flipperNum = 4 Or flipperNum = 7 Then
            Return True 'the flipper is on the bottom
        Else
            Return False 'the flipper is not on the bottom
        End If
    End Function

    Private Sub changeFlippers(value As Integer) 'Change the top flipper and decide which flipper to check next
        Dim flipperNum As Integer = value 'current flipper to be checked
        Dim currentFlipperPos As Integer 'Flippers current position - Blue or yellow

        Dim bottomCorner As Boolean = False 'Flag if the marble hit the bottom corners of the board
        Dim bottom As Boolean = False 'Flag if the marble hit the botom of the board

        Do While Not bottom And Not bottomCorner 'Loop while the last marble was not at the bottom or a corner

            bottom = isBottom(flipperNum) 'Check if the marble is at the bottom

            If flipperNum = 8 Then 'Check for right side out-of-bounds
                flipperNum = 7
                bottomCorner = True
            ElseIf flipperNum = -1 'Check for left side out-of-bounds
                flipperNum = 1
                bottomCorner = True
            End If

            currentFlipperPos = getFlipperPos(flipperNum) 'get the current position of the flipper being checked - Yellow or blue

            If currentFlipperPos = 0 Then 'If yellow
                flipperList.Item(flipperNum).flip() 'flip to blue
                flipperNum -= 1 'change the flipper number to the next flipper to be checked
            ElseIf currentFlipperPos = 1 Then 'if blue
                flipperList.Item(flipperNum).flip() 'flip to yellow
                flipperNum += 2 'change the flipper number to the next flipper to be checked
            End If

            Threading.Thread.Sleep(200) 'sleep the current running thread
            Me.Refresh() 'refresh the board
        Loop 'end do/while
    End Sub
End Class