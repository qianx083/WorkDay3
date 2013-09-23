Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click

        Dim num1, num2 As Double
        ' if the user did the wrong thing, then msgbox and eliminate them
        If ((IsNumeric(txtFirstNum.Text)) Or IsNumeric(txtSecondNum.Text)) Then
            MessageBox.Show("Error: please choice a number", "error")
            Return
        End If

        'sterile area
        num1 = CDbl(txtFirstNum.Text)
        num2 = CDbl(txtSecondNum.Text)

        If (num1 < 0 Or num2 < 0) Then
            MessageBox.Show("error: please type a positive number", "error")
            Return
        End If

        If num1 > num2 Then
            txtResult.Text = "the larger number is " & num1
        ElseIf num2 > num1 Then
            txtResult.Text = "the larger number is " & num2
        Else
            txtResult.Text = "the two are equal "
        End If

    End Sub

End Class
