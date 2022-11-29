

Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Public Class TodasCanceladas
    'Contiene la tabla consultada. ' 
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

            Consulta = "SELECT * from kodenbd.visita WHERE Estado_visita='Cancelado'"

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
    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs)
        Dim Buscar_En_Datagridview As New DataView(tabla_de_datos)
        Buscar_En_Datagridview.RowFilter = String.Format("Ci_cliente like '%{0}%'", txt_buscar.Text)
        data1.DataSource = Buscar_En_Datagridview
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

    Private Sub TodasCanceladas_Load(sender As Object, e As EventArgs) Handles Me.Load
        load_data_usuarios()

    End Sub

End Class
