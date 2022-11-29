'Form hijo necesario.
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class LoginGenerico
    Dim bddConexion As MySqlConnection


    'Metodos para abrir Forms Hijos
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()


    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)

    End Sub

    'BOTON MINIMIZAR VENTANA
    Public Sub Minimizar()

        Me.WindowState = FormWindowState.Minimized

    End Sub
    'Boton CERRAR VENTANA
    Public Sub Cerrar()

        Me.Close()

    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs)

        Minimizar()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)

        Cerrar()

    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        Entrar.Show()
        Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Registro.Show()
        Close()
    End Sub

    Private Sub cntservicio0_Click(sender As Object, e As EventArgs) Handles cntservicio0.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        VerPropdesc.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class