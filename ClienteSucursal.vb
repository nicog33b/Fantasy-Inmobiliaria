'Form hijo necesario.
Imports System.Runtime.InteropServices
Public Class ClienteSucursal



    'Metodos para abrir Forms Hijos
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub







    'Condicion tiene controles si es asi remueven tdo
    Private Sub AbrirPanelNuevo(ByVal FormHijo As Object)
        'le quita los controles posibles por el usuario al panel menu izquierdo que contiene las ventanas, logo y otros botones.
        If VentanaHija.Controls.Count > 0 Then
            VentanaHija.Controls.RemoveAt(0)
        End If
        'Crea una variable de tipo form para invocar las ventanas 
        Dim fh As Form = TryCast(FormHijo, Form)

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
        'Desaparece el boton que desliza el menu


    End Sub

    Private Sub BtnCons_Click(sender As Object, e As EventArgs)
        AbrirPanelNuevo(New ConsultarProp)
    End Sub



    Private Sub BarraArriba_Paint(sender As Object, e As PaintEventArgs)

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub



    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)
        AbrirPanelNuevo(New PantallaVacia)
    End Sub




    Private Sub BtnPer_Click(sender As Object, e As EventArgs)
        AbrirPanelNuevo(New PantallaVacia)
    End Sub


    Private Sub BarraArriba_MouseMove(sender As Object, e As MouseEventArgs)
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirPanelNuevo(New VerPropCliente)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AbrirPanelNuevo(New Agendarvisitas)
    End Sub

    Private Sub VentanaHija_Paint(sender As Object, e As PaintEventArgs) Handles VentanaHija.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BarraArriba_Paint_1(sender As Object, e As PaintEventArgs) Handles BarraArriba.Paint
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class
