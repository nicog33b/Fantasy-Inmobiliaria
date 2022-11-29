









Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient


Public Class Registro

    Public fecha As String
    Public tablaAgente As MySqlDataReader
    Public userError As String

    Public RegistroDeDatos As String = String.Empty
    Public consultaTipo As String = String.Empty
    Public tipoUser As String
    Public agenteUser As String = String.Empty
    Public Ventana As String
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

    'Permite mover la ventana desde el menu de arriba/TitleBar
    Private Sub VentanTop_MouseMove(sender As Object, e As MouseEventArgs) Handles VentanTop.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub


    Private Sub registrarUsuario(sender As Object, e As EventArgs) Handles BtnRegistrar.Click
        Dim x As String = "VALIDO"
        If ErrorProvider2.GetError(Me.Ruser) = x And ErrorProvider2.GetError(Me.Rci) = x And ErrorProvider2.GetError(Me.Rpass) = x And ErrorProvider2.GetError(Me.Rnom) = x And ErrorProvider2.GetError(Me.Rape) = x And ErrorProvider2.GetError(Me.Rcorreo) = x And ErrorProvider2.GetError(Me.Rdir) = x Then

            'Variables correspondientes a la (tabla-persona) en la base de datos.
            Dim Rusuario As String = Ruser.Text
            Dim Rcontraseña As String = Rpass.Text
            Dim ridentidad As String = Rci.Text
            Dim Rnombre As String = Rnom.Text
            Dim Rapellido As String = Rape.Text
            Dim Rmail As String = Rcorreo.Text
            Dim Rdireccion As String = Rdir.Text
            'La fecha tiene que tener esta forma para ser introducida correctamente en la bd.
            fecha = FechaAño.Text + "/" + FechaMes.Text + "/" + FechaDia.Text
            'conexion a bd
            Dim bddconexion As MySqlConnection
            'datos bd
            bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
            Try  'Validacion de errores para insertar datos.
                Dim a As String = 9
                Dim b As String = 2
                Dim c As String = 3

                'consulta a la base de datos 
                RegistroDeDatos = "Insert into kodenbd.persona (ci,nombre,apellido,direccion,fecha_nacimiento,user,password,codigo_barrio,codigo_ciudad,codigo_departamento,email) values ('" & ridentidad & "','" & Rnombre & "','" & Rapellido & "','" & Rdireccion & "','" & fecha & "','" & Rusuario & "','" & a & "','" & b & "','" & c & "','" & Rmail & "')"

                'ABRE BASE DE DATOS
                bddconexion.Open()


                'Llamada de verificacion de user para que no se repita.

                Dim EnvioDatosRegistro As MySqlCommand
                Dim leer As MySqlDataReader


                EnvioDatosRegistro = New MySqlCommand(RegistroDeDatos, bddconexion)

                leer = EnvioDatosRegistro.ExecuteReader

            Catch ex As MySqlException



            Finally


                bddconexion.Dispose()

            End Try




            Try
                'consulta a la base de datos 
                RegistroDeDatos = "Insert into kodenbd.cliente (ci_cliente) values ('" & ridentidad & "')"

                'ABRE BASE DE DATOS
                bddconexion.Open()


                'Llamada de verificacion de user para que no se repita.

                Dim EnvioDatos As MySqlCommand
                Dim leer2 As MySqlDataReader


                EnvioDatos = New MySqlCommand(RegistroDeDatos, bddconexion)

                leer2 = EnvioDatos.ExecuteReader


            Catch ex As MySqlException

            End Try
        Else
            'Si el registro no esta completo , entonces pasa esto:

            'Cambia a red el color del boton registro.
            'Y BLOQUEA EL USO DEL BOTON.

            Me.BtnRegistrar.BackColor = System.Drawing.Color.Red
            'Activa mensaje de error 
            Incorrectomsg.Visible = True

            BtnRegistrar.Enabled = False

            'ACTIVA LOS 2 TIMERS DE ERRORES:

            '1:DEVUELVE EL BOTON A COLOR VERDE EN CIERTO TIEMPO A CONTADOR.
            '2:DEVUELVE AL BOTON LA POSIBILIDAD DE SER USADO, EN CIERTO TIEMPO A CONTADOR.
            ErrorRegistro1.Enabled = True
            ErrorRegistro2.Enabled=true

        End If







    End Sub
    'VALIDACION TEXTBOX CEDULA DE IDENTIDAD.

    Private Sub ValidacionDeCedulaDeIdentidad(sender As Object, e As EventArgs) Handles Rci.LostFocus
        Dim bddconexion As MySqlConnection
        bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        Try
            RegistroDeDatos = "SELECT * FROM kodenbd.persona WHERE ci='" & Rci.Text & "'"

            'ABRE BASE DE DATOS
            bddconexion.Open()


            'Llamada de verificacion de user para que no se repita.

            Dim CiExiste As MySqlCommand



            CiExiste = New MySqlCommand(RegistroDeDatos, bddconexion)



            Dim tablaPersona As MySqlDataReader


            tablaPersona = CiExiste.ExecuteReader


            Dim cantidadUV As Integer = 0

            'Bucle while. Si lee el nombre entonces suma 1.
            While tablaPersona.Read
                cantidadUV += 1
            End While
            'Si suma mas de 1 , esta repetido.
            'Civ Toma el valor del textbox que contiene lo typeado por el usuario en el campo CI.
            '
            Dim CiV As String = Rci.Text

            If cantidadUV = 1 And CiV.Length <> 8 Then
                Me.Rci.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
                Me.Rci.ForeColor = System.Drawing.Color.Black
                Me.ErrorProvider2.SetError(Me.Rci, "")
                Me.ErrorProvider1.SetError(Me.Rci, UCase("Solo puedes usar numeros sin simbolos, EJ:50113552"))
                Return
            Else
                Me.Rci.ForeColor = System.Drawing.Color.DarkKhaki
                Rci.BackColor = Color.PaleGreen
                Me.ErrorProvider1.SetError(Me.Rci, "")
                Me.ErrorProvider2.SetError(Me.Rci, UCase("VALIDO"))


            End If
        Catch ex As MySqlException





        Finally


            bddconexion.Dispose()

        End Try
    End Sub
    'VALIDACION TEXTBOX NOMBRE REAL DEL USUARIO


    Private Sub ValidacionDeNombre(sender As Object, e As EventArgs) Handles Rnom.LostFocus
        Dim NomV As String = Rnom.Text

        If NomV.Length > 0 Then
            Me.Rnom.ForeColor = System.Drawing.Color.DarkKhaki
            Rnom.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.Rnom, "")
            Me.ErrorProvider2.SetError(Me.Rnom, UCase("VALIDO"))

            Return
        Else
            Me.Rnom.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.Rnom.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.Rnom, "")
            Me.ErrorProvider1.SetError(Me.Rnom, UCase("Debes escribir tu nombre,solo con letras, EJ:Nicolas"))
        End If
    End Sub
    'VALIDACION TEXTBOX EMAIL


    Private Sub ValidacionDeEmail(sender As Object, e As EventArgs) Handles Rcorreo.LostFocus
        Dim emailV As String = Rcorreo.Text

        If emailV.Length > 0 Then
            Me.Rcorreo.ForeColor = System.Drawing.Color.DarkKhaki
            Rcorreo.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.Rcorreo, "")
            Me.ErrorProvider2.SetError(Me.Rcorreo, UCase("VALIDO"))

            Return
        Else
            Me.Rcorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.Rcorreo.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.Rcorreo, "")
            Me.ErrorProvider1.SetError(Me.Rcorreo, UCase("No puedes dejar este espacio vacio EJ:sas@gmail.com"))
        End If
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

    Private Sub ValidacionDeCuenta(sender As Object, e As EventArgs) Handles Ruser.LostFocus
        Dim bddconexion As MySqlConnection
        bddconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        Try
            RegistroDeDatos = "SELECT * FROM kodenbd.persona WHERE user='" & Ruser.Text & "'"

            'ABRE BASE DE DATOS
            bddconexion.Open()


            'Llamada de verificacion de user para que no se repita.

            Dim UserExiste As MySqlCommand



            UserExiste = New MySqlCommand(RegistroDeDatos, bddconexion)



            Dim tablaPersona As MySqlDataReader


            tablaPersona = UserExiste.ExecuteReader


            Dim cantidadUV As Integer = 0

            'Bucle while. Si lee el nombre entonces suma 1.
            While tablaPersona.Read
                cantidadUV += 1
            End While
            'Si suma mas de 1 , esta repetido.

            Dim usuarioV As String = Ruser.Text


            If cantidadUV >= 1 Or usuarioV = String.Empty Then
                Me.Ruser.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
                Me.Ruser.ForeColor = System.Drawing.Color.Black
                Me.ErrorProvider2.SetError(Me.Ruser, "")
                Me.ErrorProvider1.SetError(Me.Ruser, UCase("El usuario ya existe o esta vacio."))

                Return
            Else
                Me.Ruser.ForeColor = System.Drawing.Color.DarkKhaki
                Ruser.BackColor = Color.PaleGreen
                Me.ErrorProvider1.SetError(Me.Ruser, "")
                Me.ErrorProvider2.SetError(Me.Ruser, UCase("VALIDO"))

            End If

        Catch ex As MySqlException





        Finally


            bddconexion.Dispose()

        End Try


    End Sub






    'VALIDACION TEXTBOX APELLIDO

    Private Sub ValidacionDeApellido(sender As Object, e As EventArgs) Handles Rape.LostFocus
        Dim apeV As String = Rape.Text

        If apeV.Length > 2 Then
            Me.Rape.ForeColor = System.Drawing.Color.DarkKhaki
            Rape.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.Rape, "")
            Me.ErrorProvider2.SetError(Me.Rape, UCase("VALIDO"))

            Return
        Else
            Me.Rape.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.Rape.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.Rape, "")
            Me.ErrorProvider1.SetError(Me.Rape, UCase("Minimo 3 Caracteres EJ: Washington"))
        End If
    End Sub

    'VALIDACION TEXTBOX DIRECCION

    Private Sub ValidacionDeDireccion(sender As Object, e As EventArgs) Handles Rdir.LostFocus
        Dim dirV As String = Rdir.Text

        If dirV.Length > 9 Then
            Me.Rdir.ForeColor = System.Drawing.Color.DarkKhaki
            Rdir.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.Rdir, "")
            Me.ErrorProvider2.SetError(Me.Rdir, UCase("VALIDO"))

            Return
        Else
            Me.Rdir.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.Rdir.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.Rdir, "")
            Me.ErrorProvider1.SetError(Me.Rdir, UCase("Minimo de 10 caracteresEJ:Washington"))
        End If
    End Sub

    'VALIDACION TEXTBOX FECHA - DIA
    Private Sub ValidacionDeFechaDay(sender As Object, e As EventArgs) Handles FechaDia.LostFocus
        Dim fechaDayV As String = FechaDia.Text

        If fechaDayV.Length = 2 Then
            Me.FechaDia.ForeColor = System.Drawing.Color.DarkKhaki
            FechaDia.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.FechaDia, "")
            Me.ErrorProvider2.SetError(Me.FechaDia, UCase("VALIDO"))

            Return
        Else
            Me.FechaDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.FechaDia.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.FechaDia, "")
            Me.ErrorProvider1.SetError(Me.FechaDia, UCase("Ejemplo:06 o 26"))
        End If
    End Sub

    Private Sub ValidacionDeFechaMonth(sender As Object, e As EventArgs) Handles FechaMes.LostFocus
        Dim fechaMesV As String = FechaMes.Text

        If fechaMesV.Length = 2 Then
            Me.FechaMes.ForeColor = System.Drawing.Color.DarkKhaki
            FechaMes.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.FechaMes, "")
            Me.ErrorProvider2.SetError(Me.FechaMes, UCase("VALIDO"))

            Return
        Else
            Me.FechaMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.FechaMes.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.FechaMes, "")
            Me.ErrorProvider1.SetError(Me.FechaMes, UCase("Ejemplo:02 o 12"))
        End If
    End Sub

    Private Sub ValidacionDeFechaYear(sender As Object, e As EventArgs) Handles FechaAño.LostFocus
        Dim fechaAñoV As String = FechaAño.Text

        If fechaAñoV.Length = 4 Then
            Me.FechaAño.ForeColor = System.Drawing.Color.DarkKhaki
            FechaAño.BackColor = Color.PaleGreen
            Me.ErrorProvider1.SetError(Me.FechaAño, "")
            Me.ErrorProvider2.SetError(Me.FechaAño, UCase("VALIDO"))

            Return
        Else
            Me.FechaAño.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
            Me.FechaAño.ForeColor = System.Drawing.Color.Black
            Me.ErrorProvider2.SetError(Me.FechaAño, "")
            Me.ErrorProvider1.SetError(Me.FechaAño, UCase("Ejemplo:1995 o 1957"))
        End If

    End Sub

    Private Sub BotonRegistroRojo(sender As Object, e As EventArgs) Handles ErrorRegistro1.Tick

        contador2.Text += 1

        If contador2.Text = "3" Then
            '
            contador2.Text = 0
            ErrorRegistro1.Enabled = False
            '
            'Pone el boton a su color inicial.
            Me.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(60, Byte), Integer))
            'Saca el mensaje de datos incorrectos
            Incorrectomsg.Visible = False



        End If




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

    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Rci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Rci.KeyPress
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

    Private Sub Rnom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Rnom.KeyPress
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

    Private Sub Rape_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Rape.KeyPress
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

    Private Sub EnabledRegistrar(sender As Object, e As EventArgs) Handles ErrorRegistro2.Tick
        'Demora hasta que el contador3 este en 7 para volver a permitir usar el boton registrar, aproximadamente 12 segundos.

        contador3.Text += 1

        If contador3.Text = "7" Then
            'reinicia  para ser reutilizable
            contador3.Text = 0
            ErrorRegistro2.Enabled = False
            'Habilita el boton registrar
            BtnRegistrar.Enabled = True

            'Mensaje de intentar denuevo. 
            IntentaMsg.Visible = True
            'Timer que borra el mensaje de  "intentar denuevo"
            ErrorRegistro3.Enabled = True



        End If
    End Sub

    Private Sub MensajeDeCoreccionDeErroresDelUsuario(sender As Object, e As EventArgs) Handles ErrorRegistro3.Tick

        contador4.Text += 1

        If contador4.Text = "3" Then
            '
            contador4.Text = 0
            ErrorRegistro3.Enabled = False
            IntentaMsg.Visible = False







        End If
    End Sub

    Private Sub IntentaMsg_Click(sender As Object, e As EventArgs) Handles IntentaMsg.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        LoginGenerico.Show()
        Me.Close()

    End Sub

    Private Sub atras_Click(sender As Object, e As EventArgs) Handles atras.Click
        LoginGenerico.Show()
        Me.Close()

    End Sub
End Class
