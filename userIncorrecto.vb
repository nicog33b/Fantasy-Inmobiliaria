Public Class userIncorrecto
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contando.Text += 1
        If contando.Text = "2" Then
            Me.Close()
        End If
    End Sub

    Private Sub userIncorrect(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub
End Class