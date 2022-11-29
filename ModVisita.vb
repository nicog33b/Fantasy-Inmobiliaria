

Imports System.Runtime.InteropServices
'
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class ModVisita
    Public VARhorafinal As String
    Public VARhora As String
    Public estadoVisita As String

    'Declaracion de periodos de tiempo

    Public fechaHora As String
    Public fechaMinutos As String
    Public fechaSegundos As String

    Public fechaDia As String
    Public fechaMes As String
    Public fechaAño As String

    'Variables utilizadas al consultar los datos de una visita existente para ser modificados.
    Dim fechita As Date
    Public CiCliente As String = String.Empty
    Public Codinmueble As String = String.Empty
    Public fecha As String = String.Empty
    Public hora As String = String.Empty
    Public concreta2 As String = String.Empty


    'Conexion con la base de datos

    Public bdconexion As MySqlConnection
    Public bdconexion2 As MySqlConnection

    Public tabla_de_datos As New DataTable
    Public Consulta As String
    Public comando As MySqlCommand

    Private Sub VentanaPrincipalConexion()
        Me.Controls.Add(PantallaVentana)
    End Sub


    Private Sub load_data_usuarios()
        Dim bdconexion As MySqlConnection
        bdconexion = New MySqlConnection
        bdconexion.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
        'transforma informacion de formato mysql al formato del programa
        Dim adaptador_de_datos As New MySqlDataAdapter
        'tabla de datos , guarda informacion ya transformada en una tabla.
        'junta la tabla en memoria y se la muestra al usuario.
        Dim binding_source As New BindingSource
        Try
            bdconexion.Open()

            Consulta = "SELECT * from kodenbd.visita"

            'ejecutar la consulta y recopilando su resultado.
            comando = New MySqlCommand(Consulta, bdconexion)
            'selecciona la informacion que proporciona la consulta.
            adaptador_de_datos.SelectCommand = comando
            'llenar la informacion del adaptador a la tabla de datos
            adaptador_de_datos.Fill(tabla_de_datos)
            'mezcla la base de datos con el datagrid con los datos de la tabla_de_datos-
            'antes cargada con el adaptador.
            binding_source.DataSource = tabla_de_datos
            'le da la fuente de informacion al datagrid desde el binding_source
            data1.DataSource = binding_source
            'update, depurar informacion adentro del adatpador.
            adaptador_de_datos.Update(tabla_de_datos)



            bdconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            bdconexion.Dispose()

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
    Private Sub HorasCombo(sender As Object, e As EventArgs) Handles HoraaCombo.SelectedIndexChanged

        'horas(selec por usuario) > variable > bd


        If (HoraaCombo.SelectedIndex <> -1) Then
            VARhora = HoraaCombo.Text
        End If



    End Sub

    Public Sub ValidaHora()
        If VARhora = "8:30" Then
            VARhorafinal = "08:30:00"
        ElseIf VARhora = "9:00" Then
            VARhorafinal = "09:00:00"
        ElseIf VARhora = "9:30" Then
            VARhorafinal = "09:30:00"
        ElseIf VARhora = "10:00" Then
            VARhorafinal = "10:00:00"
        ElseIf VARhora = "10:30" Then
            VARhorafinal = "10:30:00"
        ElseIf VARhora = "11:00" Then
            VARhorafinal = "11:00:00"
        ElseIf VARhora = "11:30" Then
            VARhorafinal = "11:30:00"
        ElseIf VARhora = "12:00" Then
            VARhorafinal = "12:00:00"
        ElseIf VARhora = "12:30" Then
            VARhorafinal = "12:30:00"
        ElseIf VARhora = "13:00" Then
            VARhorafinal = "13:00:00"
        ElseIf VARhora = "13:30" Then
            VARhorafinal = "13:30:00"
        ElseIf VARhora = "14:00" Then
            VARhorafinal = "14:00:00"
        ElseIf VARhora = "14:30" Then
            VARhorafinal = "14:30:00"
        ElseIf VARhora = "15:00" Then
            VARhorafinal = "15:00:00"
        ElseIf VARhora = "15:30" Then
            VARhorafinal = "15:30:00"
        ElseIf VARhora = "16:00" Then
            VARhorafinal = "16:00:00"
        ElseIf VARhora = "16:30" Then
            VARhorafinal = "16:30:00"
        ElseIf VARhora = "17:00" Then
            VARhorafinal = "17:00:00"
        ElseIf VARhora = "17:30" Then
            VARhorafinal = "17:30:00"
        ElseIf VARhora = "18:00" Then
            VARhorafinal = "18:00:00"
        ElseIf VARhora = "18:30" Then
            VARhorafinal = "18:30:00"
        ElseIf VARhora = "19:00" Then
            VARhorafinal = "19:00:00"
        ElseIf VARhora = "19:30" Then
            VARhorafinal = "19:30:00"
        ElseIf VARhora = "20:00" Then
            VARhorafinal = "20:00:00"
        ElseIf VARhora = "20:30" Then
            VARhorafinal = "20:30:00"
        ElseIf VARhora = "21:00" Then
            VARhorafinal = "21:00:00"
        ElseIf VARhora = "21:30" Then
            VARhorafinal = "21:30:00"
        ElseIf VARhora = "22:00" Then
            VARhorafinal = "22:00:00"
        ElseIf VARhora = "22:00" Then
            VARhorafinal = "22:00:00"

        End If
    End Sub
    Private Sub llenarHoras()
        HoraaCombo.Items.Add("8:30")
        HoraaCombo.Items.Add("9:00")
        HoraaCombo.Items.Add("9:30")
        HoraaCombo.Items.Add("10:00")
        HoraaCombo.Items.Add("10:30")
        HoraaCombo.Items.Add("11:00")
        HoraaCombo.Items.Add("11:30")
        HoraaCombo.Items.Add("12:00")
        HoraaCombo.Items.Add("12:30")
        HoraaCombo.Items.Add("13:00")
        HoraaCombo.Items.Add("13:30")
        HoraaCombo.Items.Add("14:00")
        HoraaCombo.Items.Add("14:30")
        HoraaCombo.Items.Add("15:00")
        HoraaCombo.Items.Add("15:30")
        HoraaCombo.Items.Add("16:00")
        HoraaCombo.Items.Add("16:30")
        HoraaCombo.Items.Add("17:00")
        HoraaCombo.Items.Add("17:30")
        HoraaCombo.Items.Add("18:00")
        HoraaCombo.Items.Add("18:30")
        HoraaCombo.Items.Add("19:00")
        HoraaCombo.Items.Add("19:30")
        HoraaCombo.Items.Add("20:00")
        HoraaCombo.Items.Add("20:30")
        HoraaCombo.Items.Add("21:00")
        HoraaCombo.Items.Add("21:30")
        HoraaCombo.Items.Add("22:00")
    End Sub
    Private Sub TodasCanceladas_Load(sender As Object, e As EventArgs) Handles Me.Load

        load_data_usuarios()



    End Sub

    Private Sub ConfirmarCi(sender As Object, e As EventArgs) Handles BtnConfirmar.Click
        bdconexion2 = New MySqlConnection

        'Allow Zero Datetime=True   'Arregla error de compatibilidad entre mysql y vb.net
        bdconexion2.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"

        Try
            bdconexion2.Open()
            Dim Consulta As String
            Consulta = "SELECT * FROM kodenbd.visita WHERE ci_cliente='" & Ci_a_Modificar.Text & "'"
            'ejecutar la consulta y recopilando su resultado.
            Dim comando As MySqlCommand

            comando = New MySqlCommand(Consulta, bdconexion2)

            Dim tablaVisita As MySqlDataReader



            Dim vecesEncontradoEnBD As Integer = 0







            tablaVisita = comando.ExecuteReader

            While tablaVisita.Read
                vecesEncontradoEnBD = 1
            End While

            CiCliente = tablaVisita("Ci_cliente").ToString
            Codinmueble = tablaVisita("Codigo_inmueble").ToString
            concreta2 = tablaVisita("Conretado").ToString
            fecha = tablaVisita("Fecha").ToString
            hora = tablaVisita("Hora").ToString
            Dim fechacompleta As String = fecha + " " + hora


            If vecesEncontradoEnBD = 1 Then
                dtpFecha.Value = fechacompleta
                llenarHoras()


                'Recorta el string fecha para que coincida el valor con la  variable.
                PnDatos.Visible = True

                'Botones,txtbox,strings,validaciones.
                Ci_a_Modificar.Visible = False
                TxtInmueble.Text = Codinmueble

                concretadoBD.Text = concreta2
                'Lleva las fechas registrada en la base de dat
                txtb1.Text = fecha
                txtb2.Text = hora

                BtnConfirmar.Visible = False
                BtnActualizar.Visible = True

                LbCi.Visible = False
                LbNewDatos.Visible = True
                FechaUpdate.Text = Format(dtpFecha.Value, "dd")



                If concreta2 = True Then
                    concretadoSi.Checked = True
                Else
                    concretadoNo.Checked = True
                End If



            End If







            bdconexion2.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            bdconexion2.Dispose()

        End Try
    End Sub


    Private Sub ActualizarDatos(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Dim Modificado As String = "Modificado"
        'Obtener parte especifica de la fecha.
        FechaUpdate.Text = Format(dtpFecha.Value, "yyyy/MM/dd")
        'Corrije la hora.
        ValidaHora()
        'Comprueba si los datos ingresados corresponden con una fecha.
        If IsDate(FechaUpdate.Text) Then
            'Allow Zero Datetime=True   'Arregla error de compatibilidad entre mysql y vb.net
            bdconexion2.ConnectionString = "server=10.0.13.29:3306;userid=ngarcia;password=ngarcia123*;database=kodenbd;Convert Zero Datetime=True"
            Try
                'Conexion,consulta y ejeccucion de la base de datos.
                bdconexion2.Open()
                Dim Consulta As String
                Consulta = "UPDATE kodenbd.visita SET codigo_inmueble='" & TxtInmueble.Text & "', fecha='" & FechaUpdate.Text & "',hora='" & VARhorafinal & "', conretado='" & concretadoBD.Text & "', estado_visita='" & Modificado & "' WHERE ci_cliente= '" & Ci_a_Modificar.Text & "'"
                'ejecutar la consulta y recopilando su resultado.
                Dim comando As MySqlCommand
                comando = New MySqlCommand(Consulta, bdconexion2)
                comando.ExecuteNonQuery()
                MsgBox("los datos se actualizaron correctamente")

                bdconexion2.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                bdconexion2.Dispose()

            End Try
        End If

    End Sub










    'demas codigo

    'Concretado: solo puede elegir un checkbox.


    'Checked: propiedad que activa o desactiva el tick del checkbox.

    Private Sub ConcretadoS(sender As Object, e As EventArgs) Handles concretadoSi.Click
        concretadoNo.Checked = False
        concretadoBD.Text = 1
    End Sub
    Private Sub ConcretadoN(sender As Object, e As EventArgs) Handles concretadoNo.Click
        concretadoSi.Checked = False
        concretadoBD.Text = 0
    End Sub



    Private Sub TxtAño_KeyPress(sender As Object, e As KeyPressEventArgs)



        'Solo numeros permitidos.
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

    Private Sub TxtDia_KeyPress(sender As Object, e As KeyPressEventArgs)

        'Solo numeros permitidos.
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

    Private Sub TxtHora_KeyPress(sender As Object, e As KeyPressEventArgs)

        'Solo numeros permitidos.
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

    Private Sub TxtMes_KeyPress(sender As Object, e As KeyPressEventArgs)

        'Solo numeros permitidos.
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

    Private Sub TxtMin_KeyPress(sender As Object, e As KeyPressEventArgs)

        'Solo numeros permitidos.
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

    Private Sub TxtSeg_KeyPress(sender As Object, e As KeyPressEventArgs)

        'Solo numeros permitidos.
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




    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged


        'Filtra datos dentro de la tabla que contiene el datagridview.

        If ckbCodInm.Checked = True Then

            Dim Buscar_En_Datagridview As New DataView(tabla_de_datos)
            Buscar_En_Datagridview.RowFilter = String.Format("CONVERT(Codigo_inmueble, System.String) LIKE '%{0}%'", txt_buscar.Text)
            data1.DataSource = Buscar_En_Datagridview

        Else

        End If



    End Sub
    Private Sub ckbCi_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If ckbCi.Checked = True Then
            Dim Buscar_En_Datagridview As New DataView(tabla_de_datos)
            Buscar_En_Datagridview.RowFilter = String.Format("Ci_cliente like '%{0}%'", txt_buscar.Text)
            data1.DataSource = Buscar_En_Datagridview
        Else
        End If
    End Sub





End Class