Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient


Public Class CargaCliente

    Public contadorProgreso As String = 0



    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub


    'Permite mover la ventana desde el menu de arriba/TitleBar
    Private Sub VentanTop_MouseMove(sender As Object, e As MouseEventArgs) Handles VentanTop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



    Private Sub PantalladeCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contadorProgreso As String = 0
        ProgressBar1.Value = 0
        BarradeCarga.Enabled = True



    End Sub


    Private Sub BarradeCarga_Tick(sender As Object, e As EventArgs) Handles BarradeCarga.Tick
        If contadorProgreso < 100 Then
            ProgressBar1.Value = contadorProgreso
            contadorProgreso = contadorProgreso + 1
        Else
            BarradeCarga.Enabled = False
            ClienteSucursal.Show()
            Me.Close()

        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class