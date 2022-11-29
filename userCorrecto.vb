Public Class userCorrecto


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador.Text += 1
        If contador.Text = "2" Then
            Me.Close()
        End If
    End Sub

    Private Sub userCorrecto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class