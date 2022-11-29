

Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class VerPropCliente
    'Variables de conexion(bd) 
    Public bdconexion As MySqlConnection
    Public tabla_de_datos As New DataTable
    Public Consulta As String
    Public comando As MySqlCommand

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

            Consulta = "SELECT Tipo_inmueble as 'Tipo',Estado_inmueble as 'Estado del Inmueble',Precio_venta as 'Precio',Precio_alquiler as 'Precio Alquiler',lavabo as 'Tocador',Garage as 'Garage',Livingroom as 'Living',Cuartos as 'Dormitorios',Cocina as 'Cocinas',Codigo_thab as 'CdgH',Codigo_inmueble as 'CdgI'  from kodenbd.inmueble INNER JOIN tiposhabitacion WHERE inmueble.Codigo_inmueble=tiposhabitacion.Codigo_thab AND Disponibilidad=1"

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
            dgvInmueble.DataSource = binding_source
            'update, depurar informacion adentro del adatpador.
            adaptador_de_datos.Update(tabla_de_datos)



            bdconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            bdconexion.Dispose()

        End Try
    End Sub





    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_Buscar.TextChanged
        'Filtros segun parte de la casa.
        If CbxBaño.Checked = True Then

            Dim Buscar_En_Datagridview As New DataView(tabla_de_datos)
            Buscar_En_Datagridview.RowFilter = String.Format("CONVERT(lavabo, System.String) LIKE '%{0}%'", txt_Buscar.Text)
            dgvInmueble.DataSource = Buscar_En_Datagridview

        ElseIf CbxCuartos.Checked = True Then

            Dim Buscar_En_Datagridview As New DataView(tabla_de_datos)
            Buscar_En_Datagridview.RowFilter = String.Format("CONVERT(Dormitorios, System.String) LIKE '%{0}%'", txt_Buscar.Text)
            dgvInmueble.DataSource = Buscar_En_Datagridview

        ElseIf CbxGaraje.Checked = True Then

            Dim Buscar_En_Datagridview2 As New DataView(tabla_de_datos)
            Buscar_En_Datagridview2.RowFilter = String.Format("CONVERT(Garage, System.String) LIKE '%{0}%'", txt_Buscar.Text)
            dgvInmueble.DataSource = Buscar_En_Datagridview2

        ElseIf CbxLiving.Checked = True Then

            Dim Buscar_En_Datagridview3 As New DataView(tabla_de_datos)
            Buscar_En_Datagridview3.RowFilter = String.Format("CONVERT(Living, System.String) LIKE '%{0}%'", txt_Buscar.Text)
            dgvInmueble.DataSource = Buscar_En_Datagridview3

        ElseIf CbxCocina.Checked = True Then

            Dim Buscar_En_Datagridview As New DataView(tabla_de_datos)
            Buscar_En_Datagridview.RowFilter = String.Format("CONVERT(Cocinas, System.String) LIKE '%{0}%'", txt_Buscar.Text)
            dgvInmueble.DataSource = Buscar_En_Datagridview

        Else


        End If


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

    Private Sub datosDeInicio(sender As Object, e As EventArgs) Handles Me.Load
        'Array(Combobox1)-Seleccion de filtros.


        'Carga la tabla de datos(bd)
        load_data_usuarios()

        'Oculta columnas del dgv de poco interes para el cliente, pero necesarias para la ejecuccion del programa.
        dgvInmueble.Columns(10).Visible = False
        dgvInmueble.Columns(9).Visible = False
        dgvInmueble.Columns(8).Visible = False
        dgvInmueble.Columns(7).Visible = False
        dgvInmueble.Columns(6).Visible = False
        dgvInmueble.Columns(5).Visible = False
        dgvInmueble.Columns(4).Visible = False
        dgvInmueble.Columns(3).Visible = False



    End Sub

    Private Sub dgvInmueble_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInmueble.CellContentClick, dgvInmueble.CellClick
        'Koden. 094272390. 25/10/2019

        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow

            fila = Me.dgvInmueble.Rows(e.RowIndex)
            lblcuarto.Text = fila.Cells("Dormitorios").Value.ToString
            lblcocina.Text = fila.Cells("Cocinas").Value.ToString
            lblbaño.Text = fila.Cells("Lavabo").Value.ToString
            lblgarage.Text = fila.Cells("Garage").Value.ToString
            lblLiving.Text = fila.Cells("Living").Value.ToString

            'Cdgh(Codigo_Habitacion):cantidad de ambientes segun cada tipo que contiene.
            'Cada inmueble tiene su "Cdgh" o id.
            If fila.Cells("CdgH").Value.ToString = 1 Then
                img1.Visible = True
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 2 Then
                img1.Visible = False
                img2.Visible = True
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 3 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = True
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 4 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = True
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 5 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = True
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 6 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = True
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 7 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = True
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 8 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = True
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 9 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = True
                img10.Visible = False
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 10 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = True
                img11.Visible = False
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 11 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = True
                img12.Visible = False
            ElseIf fila.Cells("CdgH").Value.ToString = 12 Then
                img1.Visible = False
                img2.Visible = False
                img3.Visible = False
                img4.Visible = False
                img5.Visible = False
                img6.Visible = False
                img7.Visible = False
                img8.Visible = False
                img9.Visible = False
                img10.Visible = False
                img11.Visible = False
                img12.Visible = True
            Else
                'NOTHING!!!!! :D
            End If

        End If



    End Sub

    Private Sub CbxBaño_CheckedChanged(sender As Object, e As EventArgs) Handles CbxBaño.Click
        If CbxBaño.Checked = True Then
            CbxBaño.Checked = False
        End If

        If CbxBaño.Checked = False Then
            CbxBaño.Checked = True
            CbxCuartos.Checked = False
            CbxGaraje.Checked = False
            CbxLiving.Checked = False
            CbxCocina.Checked = False
        End If
    End Sub

    Private Sub CbxPiscina_CheckedChanged(sender As Object, e As EventArgs) Handles CbxCocina.Click
        If CbxCocina.Checked = True Then
            CbxCocina.Checked = False
        End If

        If CbxCocina.Checked = False Then
            CbxCocina.Checked = True
            CbxCuartos.Checked = False
            CbxGaraje.Checked = False
            CbxLiving.Checked = False
            CbxBaño.Checked = False
        End If
    End Sub

    Private Sub CbxGaraje_CheckedChanged(sender As Object, e As EventArgs) Handles CbxGaraje.Click
        If CbxGaraje.Checked = True Then
            CbxGaraje.Checked = False
        End If

        If CbxGaraje.Checked = False Then
            CbxGaraje.Checked = True
            CbxCuartos.Checked = False
            CbxCocina.Checked = False
            CbxLiving.Checked = False
            CbxBaño.Checked = False
        End If
    End Sub
    Private Sub CbxCuartos_CheckedChanged(sender As Object, e As EventArgs) Handles CbxCuartos.Click
        If CbxCuartos.Checked = True Then

            CbxCuartos.Checked = False

        End If

        If CbxCuartos.Checked = False Then

            CbxCuartos.Checked = True
            CbxGaraje.Checked = False
            CbxCocina.Checked = False
            CbxLiving.Checked = False
            CbxBaño.Checked = False

        End If
    End Sub

    Private Sub CbxLiving_CheckedChanged(sender As Object, e As EventArgs) Handles CbxLiving.Click
        If CbxLiving.Checked = True Then

            CbxLiving.Checked = False

        End If

        If CbxLiving.Checked = False Then
            CbxLiving.Checked = True
            CbxGaraje.Checked = False
            CbxCocina.Checked = False
            CbxCuartos.Checked = False
            CbxBaño.Checked = False
        End If
    End Sub













    Private Sub cbxAmbiente_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAmbiente.Click
        If cbxAmbiente.Checked = True Then
            cbxAmbiente.Checked = False
        End If

        If cbxAmbiente.Checked = False Then
            cbxGeneral.Checked = False
            cbxAmbiente.Checked = True

            panelAmbientes.Visible = True

            dgvInmueble.Columns(10).Visible = False
            dgvInmueble.Columns(3).Visible = False
            dgvInmueble.Columns(2).Visible = False
            dgvInmueble.Columns(1).Visible = False
            dgvInmueble.Columns(0).Visible = False

            dgvInmueble.Columns(9).Visible = True
            dgvInmueble.Columns(8).Visible = True
            dgvInmueble.Columns(7).Visible = True
            dgvInmueble.Columns(6).Visible = True
            dgvInmueble.Columns(5).Visible = True
            dgvInmueble.Columns(4).Visible = True

        End If
    End Sub

    Private Sub cbxGeneral_Click(sender As Object, e As EventArgs) Handles cbxGeneral.Click
        If cbxGeneral.Checked = True Then
            cbxGeneral.Checked = False
        End If

        If cbxGeneral.Checked = False Then
            cbxAmbiente.Checked = False
            cbxGeneral.Checked = True

            panelAmbientes.Visible = False

            dgvInmueble.Columns(10).Visible = False
            dgvInmueble.Columns(3).Visible = False
            dgvInmueble.Columns(2).Visible = True
            dgvInmueble.Columns(1).Visible = True
            dgvInmueble.Columns(0).Visible = True

            dgvInmueble.Columns(9).Visible = False
            dgvInmueble.Columns(8).Visible = False
            dgvInmueble.Columns(7).Visible = False
            dgvInmueble.Columns(6).Visible = False
            dgvInmueble.Columns(4).Visible = False
        End If
    End Sub




    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
