Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lblCalculate.Click
        Dim sngSpeed As Single
        Dim sngTime As Single
        Const SPEED As Single = 9.81

        sngTime = Val(txtTime.Text)

        sngSpeed = SPEED * sngTime

        lblNumber.Text = sngSpeed

    End Sub
End Class
