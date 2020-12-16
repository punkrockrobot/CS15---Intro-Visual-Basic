'Brian Worth Assignment 10

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalcAvg.Click
        'declares variables and assgins a data type
        Dim Test1 As Integer
        Dim Test2 As Integer
        Dim Test3 As Integer
        Dim Average As Integer

        'assigns Variable to populate textboxes
        Test1 = txtTest1.Text
        Test2 = txtTest2.Text
        Test3 = txtTest3.Text

        'formula for calc average
        Average = (Test1 + Test2 + Test3) / 3

        'if statements based on the above formula and will populate form as follows
        If Average < 60 Then
            lblAverage.Text = Average
            lblGrade.Text = "F"
        ElseIf Average < 70 Then
            lblAverage.Text = Average
            lblGrade.Text = "D"
        ElseIf Average < 80 Then
            lblAverage.Text = Average
            lblGrade.Text = "C"
        ElseIf Average < 90 Then
            lblAverage.Text = Average
            lblGrade.Text = "B"
        ElseIf Average < 100 Then
            lblAverage.Text = Average
            lblGrade.Text = "A"
        End If



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears form 
        txtTest1.Text = ""
        txtTest2.Text = ""
        txtTest3.Text = ""
        lblAverage.Text = ""
        lblGrade.Text = ""
    End Sub
End Class
