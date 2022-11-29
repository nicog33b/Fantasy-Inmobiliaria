









Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient


Public Class Agendarvisitas
    Public consultaLogin As String
    Public VarHoraFinal As String
    Public ciPersona As String
    Public VarIdInm As String
    Public VarHora As String
    Public fecha As String
    Public tablaAgente As MySqlDataReader
    Public AgendarVisitaComando As String
    Public RegistroDeDatos As String = String.Empty






    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)
    End Sub

    'Permite mover la ventana desde el menu de arriba/TitleBar
    Private Sub VentanTop_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub HorasCombo(sender As Object, e As EventArgs) Handles horas.SelectedIndexChanged

        'horas(selec por usuario) > variable > bd


        If (horas.SelectedIndex <> -1) Then
            VarHora = horas.Text
        End If



    End Sub
    Private Sub IdInmCombo(sender As Object, e As EventArgs) Handles cbxInm.SelectedIndexChanged


        'idinmueble(selec por usuario) > variable > bd

        If (cbxInm.SelectedIndex <> -1) Then
            VarIdInm = cbxInm.Text
        End If
        TextBox1.Text = VarIdInm


    End Sub
    Private Sub llenarInmuebles()
        cbxInm.Items.Add("1")
        cbxInm.Items.Add("2")
        cbxInm.Items.Add("3")
        cbxInm.Items.Add("4")
        cbxInm.Items.Add("5")
        cbxInm.Items.Add("6")
        cbxInm.Items.Add("7")
        cbxInm.Items.Add("8")
        cbxInm.Items.Add("9")
        cbxInm.Items.Add("10")
        cbxInm.Items.Add("11")
        cbxInm.Items.Add("12")
        cbxInm.Items.Add("13")


    End Sub
    Public Sub ValidaHora()
        If VarHora = "8:30" Then
            VarHoraFinal = "08:30:00"
        ElseIf VarHora = "9:00" Then
            VarHoraFinal = "09:00:00"
        ElseIf VarHora = "9:30" Then
            VarHoraFinal = "09:30:00"
        ElseIf VarHora = "10:00" Then
            VarHoraFinal = "10:00:00"
        ElseIf VarHora = "10:30" Then
            VarHoraFinal = "10:30:00"
        ElseIf VarHora = "11:00" Then
            VarHoraFinal = "11:00:00"
        ElseIf VarHora = "11:30" Then
            VarHoraFinal = "11:30:00"
        ElseIf VarHora = "12:00" Then
            VarHoraFinal = "12:00:00"
        ElseIf VarHora = "12:30" Then
            VarHoraFinal = "12:30:00"
        ElseIf VarHora = "13:00" Then
            VarHoraFinal = "13:00:00"



        End If
    End Sub
    Private Sub llenarHoras()
        horas.Items.Add("8:30")
        horas.Items.Add("9:00")
        horas.Items.Add("9:30")
        horas.Items.Add("10:00")
        horas.Items.Add("10:30")
        horas.Items.Add("11:00")
        horas.Items.Add("11:30")
        horas.Items.Add("12:00")
        horas.Items.Add("12:30")
        horas.Items.Add("13:00")
        horas.Items.Add("13:30")
        horas.Items.Add("14:00")
        horas.Items.Add("14:30")
        horas.Items.Add("15:00")
        horas.Items.Add("15:30")
        horas.Items.Add("16:00")
        horas.Items.Add("16:30")
        horas.Items.Add("17:00")
        horas.Items.Add("17:30")
        horas.Items.Add("18:00")
        horas.Items.Add("18:30")
        horas.Items.Add("19:00")
        horas.Items.Add("19:30")
        horas.Items.Add("20:00")
        horas.Items.Add("20:30")
        horas.Items.Add("21:00")
        horas.Items.Add("21:30")
        horas.Items.Add("22:00")
    End Sub



    'VALIDACION TEXTBOX CONTRASEÑA

    Private Sub ValidacionDeContraseña(sender As Object, e As EventArgs) Handles Rpass.LostFocus
        Dim passV As String = Rpass.Text

        If passV.Length > 6 Then
            Me.Rpass.ForeColor = System.Drawing.Color.DarkKhaki
            Rpass.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.Rpass, "")
            Me.ErrorProvider2.SetError(Me.Rpass, UCase("VALIDO"))

            Return
        Else
            Me.Rpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.Rpass.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.Rpass, "")
            Me.ErrorProvider1.SetError(Me.Rpass, UCase("Minimo 7 caracteres."))
        End If
    End Sub
    'VALIDACION TEXTBOX NOMBRE DE USUARIO

    Private Sub ValidacionDeCuenta(sender As Object, e As EventArgs) Handles ruser.LostFocus
        Dim bddconexion As MySqlConnection
        bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        Try
            RegistroDeDatos = "SELECT * FROM kodenbd.persona WHERE user='" & ruser.Text & "'"

            'ABRE BASE DE DATOS
            bddconexion.Open()


            'Llamada de verificacion de user para que no se repita.

            Dim UserExiste As MySqlCommand



            UserExiste = New MySqlCommand(RegistroDeDatos, bddconexion)



            Dim tablaPersona As MySqlDataReader


            tablaPersona = UserExiste.ExecuteReader


            Dim cantidadUV As Integer = 0


            While tablaPersona.Read
                cantidadUV = 1
            End While


            Dim usuarioV As String = ruser.Text


            If cantidadUV = 1 Then
                Me.ruser.ForeColor = System.Drawing.Color.DarkKhaki
                ruser.BackColor = Color.PaleGreen
                Me.ErrorProvider1.SetError(Me.ruser, "")
                Me.ErrorProvider2.SetError(Me.ruser, UCase("VALIDO"))
                Return
            Else
                Me.ruser.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
                Me.ruser.ForeColor = System.Drawing.Color.Black
                Me.ErrorProvider2.SetError(Me.ruser, "")
                Me.ErrorProvider1.SetError(Me.ruser, UCase("El usuario no existe"))

            End If




        Catch ex As MySqlException





        Finally


            bddconexion.Dispose()


        End Try


    End Sub










    Private Sub Rci_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SOLO NUMEROS'
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub Rape_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SOLO LETRAS'
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub



    Private Sub BtnAgendar_Click(sender As Object, e As EventArgs) Handles BtnAgendar.Click
        ValidaHora()
        Dim verifEstadoVisita As String = "Disponible"
        Dim verifConcretado As String = "1"

        Dim bddconexion As MySqlConnection
        bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        'bddconexion = New MySqlConnection("server=10.0.13.29;userid=ngarcia;password=ngarcia123*;database=kodenbd")


        Try

            AgendarVisitaComando = "Insert into kodenbd.visita (ci_cliente,codigo_inmueble,fecha,hora,conretado,estado_visita) values ('" & ciPersona & "','" & VarIdInm & "','" & FechaAgenda.Value.Date.ToString("yyyy-MM-dd") & "','" & VarHoraFinal & "','" & verifConcretado & "','" & verifEstadoVisita & "')"

            'ABRE BASE DE DATOS
            bddconexion.Open()
                Dim EnvioDatosRegistro As MySqlCommand
                Dim leer As MySqlDataReader


                EnvioDatosRegistro = New MySqlCommand(AgendarVisitaComando, bddconexion)

                leer = EnvioDatosRegistro.ExecuteReader
                MsgBox("Gracias por realizar tu agenda")




        Catch ex As MySqlException

            MsgBox("ha ingresado datos incorrectos.")


        Finally


            bddconexion.Dispose()


        End Try


    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        Dim bddconexion As MySqlConnection
        bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        Try

            consultaLogin = "SELECT ci,user,password,ci_cliente FROM kodenbd.persona INNER JOIN cliente WHERE user='" & ruser.Text & "' AND password='" & Rpass.Text & "' AND ci=ci_cliente"
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
            ciPersona = tablaPersona("Ci").ToString
            'un solo usuario existe en la base de datos de este tipo


            If cantidadUyp = 1 Then
                'Desaparecen de pantalla:
                ImagenEmpresa.Visible = False
                lblpass.Visible = False
                lbluser.Visible = False
                txt1.Visible = False
                Rpass.Visible = False
                ruser.Visible = False
                btnConfirmar.Visible = False

                'MiniImagenDeMuestra4.Visible = False
                ' MiniImagenDeMuestra5.Visible = False
                ' MiniImagenDeMuestra6.Visible = False
                'MiniImagenDeMuestra7.Visible = False
                'MiniImagenDeMuestra8.Visible = False
                'MiniImagenDeMuestra9.Visible = False
                'MiniImagenDeMuestra10.Visible = False
                'MiniImagenDeMuestra11.Visible = False
                ' MiniImagenDeMuestra12.Visible = False
                ' MiniImagenDeMuestra13.Visible = False
                ' MiniImagenDeMuestra14.Visible = False
                'Aparecen en pantalla
                horas.Visible = True
                FechaAgenda.Visible = True
                lblIdInMUEBLE.Visible = True
                lblFechayHora.Visible = True
                lblfecha.Visible = True
                lblhora.Visible = True
                cbxInm.Visible = True
                txtRecuerdo.Visible = True
                BtnAgendar.Visible = True
                Label1.Visible = True
                'Funciones      
                llenarHoras()
                llenarInmuebles()

            End If


        Catch ex As MySqlException





        Finally


            bddconexion.Dispose()


        End Try
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Cerrar()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
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

    Private Sub Agendarvisitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidaHora()
    End Sub

    Private Sub lblhora_Click(sender As Object, e As EventArgs) Handles lblhora.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
