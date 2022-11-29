Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient


Public Class PantalladeCarga

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



    'Activa el timer  "BarraDeCarga" Linea 41

    Private Sub PantalladeCarga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim contadorProgreso As String = 0
        ProgressBar2.Value = 0
        BarradeCarga.Enabled = True



    End Sub

    'Si el contadorprogreso es menor a 100
    Private Sub BarradeCarga_Tick(sender As Object, e As EventArgs) Handles BarradeCarga.Tick
        If contadorProgreso < 100 Then


            'El progressbar toma el value del contadorprogreso
            'Contadorprogreso es un String iniciado en 0
            'ContadorProgreso empieza a sumar 1 en el intervalo marcado por el timer.
            ProgressBar2.Value = contadorProgreso
            contadorProgreso = contadorProgreso + 1




        Else

            'Si es 100 se apaga el timer y muestra la ventana siguiente.
            BarradeCarga.Enabled = False
            AgenteSucursal.Show()
            Me.Close()

        End If
    End Sub


End Class