Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient


Public Class Entrar
    Public tablaAgente As MySqlDataReader
    Public userError As String
    Public CiPersona As String = String.Empty
    Public CiAgente As String = String.Empty
    Public CiGerente As String = String.Empty
    Public CiCliente As String = String.Empty
    Public consultaLogin As String = String.Empty
    Public consultaLogin2 As String = String.Empty
    Public consultaLogin3 As String = String.Empty
    Public consultaLogin4 As String = String.Empty
    Public consultaLogin5 As String = String.Empty
    Public consultaTipo As String = String.Empty
    Public tipoUser As String
    Public agenteUser As String = String.Empty
    Public Ventana As String
    Public passwordresc As String

    'TIPOS DE USUARIOS DENTRO DE LA BASE DE DATOS
    'CLIENTE - 0
    'GERENTE - 1
    'AGENTE  - 2
    'ADMINISTRADOR - 3


    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub



    'el contador empieza en 0
    'al llegar a 3 que es el tiempo en el que desaparece el form de userCorrecto
    'apaga el timer , evita errores.
    'por ultimo habre la ventana
    Private Sub Gerente(sender As Object, e As EventArgs) Handles TmrGerente.Tick
        contador.Text += 1

        If contador.Text = "3" Then

            contador.Text = 0

            TmrGerente.Enabled = False

            CargaGerente.Show()
            'Me.Close()
        End If

    End Sub



    Private Sub CierraUserIncorrecto(sender As Object, e As EventArgs) Handles TmrUserIncorrecto.Tick


        contador.Text += 1

        If contador.Text = "1" Then
            contador.Text = 0

            TmrUserIncorrecto.Enabled = False

            userIncorrecto.Close()
        End If
    End Sub

    Private Sub TmrAgente_Tick(sender As Object, e As EventArgs) Handles TmrAgente.Tick


        contador.Text += 1
        If contador.Text = "3" Then

            contador.Text = 0

            TmrAgente.Enabled = False

            PantalladeCarga.Show()

            Me.Close()
            PantalladeCarga.Show()

        End If
    End Sub

    Private Sub Cliente(sender As Object, e As EventArgs) Handles TmrCliente.Tick


        contador.Text += 1

        If contador.Text = "3" Then

            contador.Text = 0


            TmrCliente.Enabled = False
            CargaCliente.Show()
            Me.Close()
            CargaCliente.Show()





        End If
    End Sub
    'Permite mover la ventana desde el menu de arriba/TitleBar
    Private Sub VentanTop_MouseMove(sender As Object, e As MouseEventArgs) Handles VentanTop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnEntrar_Click_1(sender As Object, e As EventArgs) Handles BtnEntrar.Click
   
        Dim bddconexion As MySqlConnection
        bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        Try
            consultaLogin = "SELECT ci,user,password FROM kodenbd.persona cliente  WHERE user='" & user.Text & "' AND password='" & pass.Text & "'"
            bddconexion.Open()
            'Llamada de verificacion de user y password , BASE DE DATOS.
            Dim UseryPass As MySqlCommand
            UseryPass = New MySqlCommand(consultaLogin, bddconexion)
            Dim tablaPersona As MySqlDataReader
            tablaPersona = UseryPass.ExecuteReader
            Dim cantidadUyp As Integer = 0
            While tablaPersona.Read
                cantidadUyp = 1
            End While
            CiPersona = tablaPersona("Ci").ToString
            'un solo usuario existe en la base de datos de este tipo
            If cantidadUyp = 1 Then

                bddconexion.Close()
                userCorrecto.Show()
            End If
            consultaLogin2 = "SELECT ci_cliente from kodenbd.cliente WHERE Ci_cliente='" & CiPersona & "'"
            bddconexion.Open()

            UseryPass = New MySqlCommand(consultaLogin2, bddconexion)

            tablaPersona = UseryPass.ExecuteReader

                While tablaPersona.Read
                cantidadUyp = 2
            End While

            If cantidadUyp = 2 Then
                TmrCliente.Enabled = True
                bddconexion.Close()
            End If

            consultaLogin3 = "SELECT Ci_ai from kodenbd.agente_inmobiliario WHERE Ci_ai='" & CiPersona & "'"
            Dim bddconexion2 As MySqlConnection
            bddconexion2.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
            bddconexion2.Open()

            UseryPass = New MySqlCommand(consultaLogin3, bddconexion2)

            tablaPersona = UseryPass.ExecuteReader

            While tablaPersona.Read
                cantidadUyp = 3
            End While

            If cantidadUyp = 3 Then
                TmrAgente.Enabled = True
            End If

            consultaLogin4 = "SELECT Ci_gerente from kodenbd.gerente WHERE Ci_gerente='" & CiPersona & "'"
            Dim bddconexion3 As MySqlConnection
            bddconexion3.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
            bddconexion3.Open()

            UseryPass = New MySqlCommand(consultaLogin4, bddconexion3)

            tablaPersona = UseryPass.ExecuteReader

            While tablaPersona.Read
                cantidadUyp = 4
            End While

            If cantidadUyp = 4 Then
                TmrGerente.Enabled = True
            End If







        Catch ex As MySqlException
            userIncorrecto.Show()
        Finally
            bddconexion.Dispose()
        End Try
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Cerrar()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Minimizar()
    End Sub
    'BOTON MINIMIZAR VENTANA
    Public Sub Minimizar()
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Boton CERRAR VENTANA
    Public Sub Cerrar()
        Me.Close()
    End Sub



    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        LoginGenerico.Show()
        Me.Close()
    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        LoginGenerico.Show()
        Me.Close()
    End Sub

    Private Sub VentanTop_Paint(sender As Object, e As PaintEventArgs) Handles VentanTop.Paint

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Registro.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Registro.Show()
        Me.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        PanelRecuperarPassword.Visible = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtusu.TextChanged

    End Sub

    Private Sub Entrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRecup_Click(sender As Object, e As EventArgs) Handles btnRecup.Click
        Try
            If PanelRecuperarPassword.Visible = True Then
                PanelRecuperarPassword.Visible = False
            Else
                PanelRecuperarPassword.Visible = True
            End If

            consultaLogin = "SELECT ci,user,password,nombre FROM kodenbd.persona WHERE user='" & txtusu.Text & "' AND ci='" & txtci.Text & "' AND nombre='" & txtnom.Text & "'"
            Dim bddconexion As MySqlConnection
            bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
            bddconexion.Open()
            'Llamada de verificacion de user y password , BASE DE DATOS.
            Dim UseryPass As MySqlCommand
            UseryPass = New MySqlCommand(consultaLogin, bddconexion)
            Dim tablaPersona As MySqlDataReader
            tablaPersona = UseryPass.ExecuteReader
            Dim cantidadUyp As Integer = 0
            While tablaPersona.Read
                cantidadUyp = 1
            End While
            passwordresc = tablaPersona("password").ToString
            'un solo usuario existe en la base de datos de este tipo
            If cantidadUyp = 1 Then
                pass.Text = passwordresc
                pass.PasswordChar = ""
            End If
        Catch ex As Exception
            MsgBox("No existe ninguna contraseña relacionada con esos datos.")
            txtnom.Text = ""
            txtci.Text = ""
            txtusu.Text = ""


        End Try
    End Sub
End Class
