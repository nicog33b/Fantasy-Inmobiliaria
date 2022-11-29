'Form hijo necesario.
Imports System.Runtime.InteropServices
Public Class PantallaVentana



    'Metodos para abrir Forms Hijos
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub



    Private Sub MostrarBotones()
        ImagenEmpresa.Visible = True
        BtnCancelar.Visible = True
        BtnModificar.Visible = True
        BtnCons.Visible = True
        btnCanc.Visible = True
        btnMod.Visible = True
        BtnCons.Visible = True
        Cons.Visible = True
        acc.Visible = True
    End Sub
    Private Sub BorrarBotones()
        ImagenEmpresa.Visible = False
        BtnCancelar.Visible = False
        BtnModificar.Visible = False
        BtnCons.Visible = False
        btnCanc.Visible = False
        btnMod.Visible = False
        BtnCons.Visible = False
        Cons.Visible = False
        acc.Visible = False


    End Sub

    'BOTON MINIMIZAR VENTANA
    Public Sub Minimizar()
        Me.WindowState = FormWindowState.Minimized
    End Sub

    'Boton CERRAR VENTANA
    Public Sub Cerrar()
        Me.Close()
    End Sub


    'Boton que abre o cierra el menu


    'RELOJ - OCULTAR MENU. PANEL IZQ
    Private Sub OcultarMenu_Tick(sender As Object, e As EventArgs) Handles OcultarMenu.Tick

        If PanelMenuIzq.Width <= 50 Then

            Me.OcultarMenu.Enabled = False
        Else
            PanelMenuIzq.Width = PanelMenuIzq.Width - 20

        End If
    End Sub
    'RELOJ - MOSTRAR MENU. PANEL IZQ
    Private Sub AbrirMenu_Tick(sender As Object, e As EventArgs) Handles AbrirMenu.Tick

        If PanelMenuIzq.Width >= 200 Then
            Me.AbrirMenu.Enabled = False

            MostrarBotones()
        Else

            BorrarBotones()

            PanelMenuIzq.Width = PanelMenuIzq.Width + 20

        End If
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Cerrar()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Minimizar()
    End Sub

    'Boton del menu que expande o cierra las opciones.
    Private Sub DesplazarMenu_Click(sender As Object, e As EventArgs) 

        If PanelMenuIzq.Width = 206 Then

            OcultarMenu.Enabled = True

            BorrarBotones()

        ElseIf PanelMenuIzq.Width < 206 Then

            AbrirMenu.Enabled = True


        End If
    End Sub


    'Condicion tiene controles si es asi remueven tdo
    Private Sub AbrirPanelNuevo(ByVal FormHijo As Object)

        'le quita los controles posibles por el usuario al panel menu izquierdo que contiene las ventanas, logo y otros botones.
        If VentanaHija.Controls.Count > 0 Then
            VentanaHija.Controls.RemoveAt(0)
        End If

        'Crea una variable de tipo form para invocar las ventanas 
        Dim fh As Form = TryCast(FormHijo, Form)


        'vieja parte del codigo.

        'Ocultar el menu al entrar
        'OcultarMenu.Enabled = True

        'esconder botones
        'BorrarBotones()

        'No es de alto nivel jararquicamente.
        fh.TopLevel = False

        'Estilo de borde del formulario (ninguno)           
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        'Se aclopa todo el panel contenedor
        fh.Dock = DockStyle.Fill

        'se le asigna controles del form al panel izquierdo
        VentanaHija.Controls.Add(fh)

        'El panel izquierdo contiene los datos del formulario que se ingresara segun el boton
        VentanaHija.Tag = fh

        'Muestra el formulario
        fh.Show()

    End Sub

    Private Sub BtnCons_Click(sender As Object, e As EventArgs) Handles BtnCons.Click
        'ABRE LA VENTANA AGENDAS DEL DIA A LA CUAL CORRESPONDE EL BOTON
        'ESTA FUNCION HACE LLAMADO AL FORM PARA QUE SE UTILIZE DESDE LA VENTANA HIJA DE LA VENTANA GERENTE.
        AbrirPanelNuevo(New AgendaDia)
    End Sub



    Private Sub BarraArriba_Paint(sender As Object, e As PaintEventArgs) Handles BarraArriba.Paint

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'ABRE LA VENTANA CANCELAR VISITAS A LA CUAL CORRESPONDE EL BOTON
        'ESTA FUNCION HACE LLAMADO AL FORM PARA QUE SE UTILIZE DESDE LA VENTANA HIJA DE LA VENTANA GERENTE.
        AbrirPanelNuevo(New cancelvisit)
    End Sub



    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        'ABRE LA VENTANA MODIFICAR VISITAS A LA CUAL CORRESPONDE EL BOTON
        'ESTA FUNCION HACE LLAMADO AL FORM PARA QUE SE UTILIZE DESDE LA VENTANA HIJA DE LA VENTANA GERENTE.
        AbrirPanelNuevo(New ModVisita)
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        'ABRE LA VENTANA DE TODAS LAS AGENDAS MODIFICADAS A LA CUAL CORRESPONDE EL BOTON
        'ESTA FUNCION HACE LLAMADO AL FORM PARA QUE SE UTILIZE DESDE LA VENTANA HIJA DE LA VENTANA GERENTE.
        AbrirPanelNuevo(New AllModificadas)
    End Sub

    Private Sub btnCanc_Click(sender As Object, e As EventArgs) Handles btnCanc.Click
        'ABRE LA VENTANA DE TODAS LAS AGENAS CANCELADAS A LA CUAL CORRESPONDE EL BOTON
        'ESTA FUNCION HACE LLAMADO AL FORM PARA QUE SE UTILIZE DESDE LA VENTANA HIJA DE LA VENTANA GERENTE.
        AbrirPanelNuevo(New TodasCanceladas)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
