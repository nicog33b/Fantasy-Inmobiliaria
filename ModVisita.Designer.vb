<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ModVisita
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModVisita))
        Me.TituloAC = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.PnDatos = New System.Windows.Forms.Panel()
        Me.HoraaCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDia = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.concretadoNo = New System.Windows.Forms.CheckBox()
        Me.concretadoSi = New System.Windows.Forms.CheckBox()
        Me.Concretado = New System.Windows.Forms.Label()
        Me.Inmueble = New System.Windows.Forms.Label()
        Me.TxtInmueble = New System.Windows.Forms.TextBox()
        Me.BtnConfirmar = New System.Windows.Forms.Button()
        Me.concretadoBD = New System.Windows.Forms.TextBox()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.LbCi = New System.Windows.Forms.Label()
        Me.Ci_a_Modificar = New System.Windows.Forms.TextBox()
        Me.LbNewDatos = New System.Windows.Forms.Label()
        Me.FechaUpdate = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.horaUpdate = New System.Windows.Forms.TextBox()
        Me.final = New System.Windows.Forms.TextBox()
        Me.ckbCodInm = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ckbCi = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtb1 = New System.Windows.Forms.TextBox()
        Me.txtb2 = New System.Windows.Forms.TextBox()
        Me.PnDatos.SuspendLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloAC
        '
        Me.TituloAC.AutoSize = True
        Me.TituloAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TituloAC.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloAC.ForeColor = System.Drawing.Color.Black
        Me.TituloAC.Location = New System.Drawing.Point(391, 9)
        Me.TituloAC.Name = "TituloAC"
        Me.TituloAC.Size = New System.Drawing.Size(389, 61)
        Me.TituloAC.TabIndex = 15
        Me.TituloAC.Text = "Modificar visita"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Yellow
        Me.BtnActualizar.Location = New System.Drawing.Point(386, 704)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(376, 36)
        Me.BtnActualizar.TabIndex = 21
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        Me.BtnActualizar.Visible = False
        '
        'PnDatos
        '
        Me.PnDatos.Controls.Add(Me.HoraaCombo)
        Me.PnDatos.Controls.Add(Me.Label1)
        Me.PnDatos.Controls.Add(Me.lblDia)
        Me.PnDatos.Controls.Add(Me.dtpFecha)
        Me.PnDatos.Controls.Add(Me.Label4)
        Me.PnDatos.Controls.Add(Me.Label3)
        Me.PnDatos.Controls.Add(Me.concretadoNo)
        Me.PnDatos.Controls.Add(Me.concretadoSi)
        Me.PnDatos.Controls.Add(Me.Concretado)
        Me.PnDatos.Controls.Add(Me.Inmueble)
        Me.PnDatos.Controls.Add(Me.TxtInmueble)
        Me.PnDatos.ForeColor = System.Drawing.Color.DarkCyan
        Me.PnDatos.Location = New System.Drawing.Point(29, 578)
        Me.PnDatos.Name = "PnDatos"
        Me.PnDatos.Size = New System.Drawing.Size(1082, 120)
        Me.PnDatos.TabIndex = 22
        Me.PnDatos.Visible = False
        '
        'HoraaCombo
        '
        Me.HoraaCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HoraaCombo.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HoraaCombo.FormattingEnabled = True
        Me.HoraaCombo.Location = New System.Drawing.Point(641, 44)
        Me.HoraaCombo.Name = "HoraaCombo"
        Me.HoraaCombo.Size = New System.Drawing.Size(121, 37)
        Me.HoraaCombo.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 30)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Dia"
        '
        'lblDia
        '
        Me.lblDia.AutoSize = True
        Me.lblDia.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDia.Location = New System.Drawing.Point(558, 51)
        Me.lblDia.Name = "lblDia"
        Me.lblDia.Size = New System.Drawing.Size(68, 30)
        Me.lblDia.TabIndex = 12
        Me.lblDia.Text = "Hora"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpFecha.Location = New System.Drawing.Point(480, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowUpDown = True
        Me.dtpFecha.Size = New System.Drawing.Size(50, 35)
        Me.dtpFecha.TabIndex = 11
        Me.dtpFecha.Value = New Date(2019, 10, 25, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1017, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "No"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(968, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Si"
        '
        'concretadoNo
        '
        Me.concretadoNo.AutoSize = True
        Me.concretadoNo.Location = New System.Drawing.Point(1023, 57)
        Me.concretadoNo.Name = "concretadoNo"
        Me.concretadoNo.Size = New System.Drawing.Size(15, 14)
        Me.concretadoNo.TabIndex = 7
        Me.concretadoNo.UseVisualStyleBackColor = True
        '
        'concretadoSi
        '
        Me.concretadoSi.AutoSize = True
        Me.concretadoSi.Location = New System.Drawing.Point(969, 57)
        Me.concretadoSi.Name = "concretadoSi"
        Me.concretadoSi.Size = New System.Drawing.Size(15, 14)
        Me.concretadoSi.TabIndex = 6
        Me.concretadoSi.UseVisualStyleBackColor = True
        '
        'Concretado
        '
        Me.Concretado.AutoSize = True
        Me.Concretado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Concretado.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Concretado.Location = New System.Drawing.Point(832, 44)
        Me.Concretado.Name = "Concretado"
        Me.Concretado.Size = New System.Drawing.Size(108, 24)
        Me.Concretado.TabIndex = 5
        Me.Concretado.Text = "Concretado"
        '
        'Inmueble
        '
        Me.Inmueble.AutoSize = True
        Me.Inmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inmueble.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Inmueble.Location = New System.Drawing.Point(28, 62)
        Me.Inmueble.Name = "Inmueble"
        Me.Inmueble.Size = New System.Drawing.Size(155, 24)
        Me.Inmueble.TabIndex = 1
        Me.Inmueble.Text = "Codigo inmueble"
        '
        'TxtInmueble
        '
        Me.TxtInmueble.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInmueble.ForeColor = System.Drawing.Color.Purple
        Me.TxtInmueble.Location = New System.Drawing.Point(189, 62)
        Me.TxtInmueble.Name = "TxtInmueble"
        Me.TxtInmueble.Size = New System.Drawing.Size(49, 29)
        Me.TxtInmueble.TabIndex = 0
        '
        'BtnConfirmar
        '
        Me.BtnConfirmar.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.BtnConfirmar.Location = New System.Drawing.Point(386, 704)
        Me.BtnConfirmar.Name = "BtnConfirmar"
        Me.BtnConfirmar.Size = New System.Drawing.Size(376, 36)
        Me.BtnConfirmar.TabIndex = 24
        Me.BtnConfirmar.Text = "Confirmar"
        Me.BtnConfirmar.UseVisualStyleBackColor = True
        '
        'concretadoBD
        '
        Me.concretadoBD.Location = New System.Drawing.Point(832, 9)
        Me.concretadoBD.Name = "concretadoBD"
        Me.concretadoBD.Size = New System.Drawing.Size(22, 20)
        Me.concretadoBD.TabIndex = 25
        Me.concretadoBD.Text = "0"
        Me.concretadoBD.Visible = False
        '
        'data1
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.data1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data1.BackgroundColor = System.Drawing.Color.White
        Me.data1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(86, 158)
        Me.data1.Name = "data1"
        Me.data1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.data1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.data1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.data1.Size = New System.Drawing.Size(920, 312)
        Me.data1.TabIndex = 16
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(702, 131)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(160, 21)
        Me.txt_buscar.TabIndex = 19
        '
        'LbCi
        '
        Me.LbCi.AutoSize = True
        Me.LbCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbCi.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LbCi.Location = New System.Drawing.Point(342, 490)
        Me.LbCi.Name = "LbCi"
        Me.LbCi.Size = New System.Drawing.Size(502, 31)
        Me.LbCi.TabIndex = 24
        Me.LbCi.Text = "Ingrese la cedula de la visita a modificar."
        '
        'Ci_a_Modificar
        '
        Me.Ci_a_Modificar.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ci_a_Modificar.ForeColor = System.Drawing.Color.Purple
        Me.Ci_a_Modificar.Location = New System.Drawing.Point(504, 525)
        Me.Ci_a_Modificar.Multiline = True
        Me.Ci_a_Modificar.Name = "Ci_a_Modificar"
        Me.Ci_a_Modificar.Size = New System.Drawing.Size(183, 47)
        Me.Ci_a_Modificar.TabIndex = 23
        Me.Ci_a_Modificar.Text = "50113552"
        '
        'LbNewDatos
        '
        Me.LbNewDatos.AutoSize = True
        Me.LbNewDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNewDatos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LbNewDatos.Location = New System.Drawing.Point(419, 490)
        Me.LbNewDatos.Name = "LbNewDatos"
        Me.LbNewDatos.Size = New System.Drawing.Size(332, 31)
        Me.LbNewDatos.TabIndex = 25
        Me.LbNewDatos.Text = "Ingrese los nuevos datos.."
        Me.LbNewDatos.Visible = False
        '
        'FechaUpdate
        '
        Me.FechaUpdate.Location = New System.Drawing.Point(107, -6)
        Me.FechaUpdate.Multiline = True
        Me.FechaUpdate.Name = "FechaUpdate"
        Me.FechaUpdate.Size = New System.Drawing.Size(209, 25)
        Me.FechaUpdate.TabIndex = 26
        Me.FechaUpdate.Visible = False
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = CType(resources.GetObject("btn_buscar.BackgroundImage"), System.Drawing.Image)
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_buscar.Location = New System.Drawing.Point(670, 126)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(26, 25)
        Me.btn_buscar.TabIndex = 1105
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'horaUpdate
        '
        Me.horaUpdate.Location = New System.Drawing.Point(107, 35)
        Me.horaUpdate.Multiline = True
        Me.horaUpdate.Name = "horaUpdate"
        Me.horaUpdate.Size = New System.Drawing.Size(209, 25)
        Me.horaUpdate.TabIndex = 1106
        Me.horaUpdate.Visible = False
        '
        'final
        '
        Me.final.Location = New System.Drawing.Point(107, 75)
        Me.final.Multiline = True
        Me.final.Name = "final"
        Me.final.Size = New System.Drawing.Size(209, 25)
        Me.final.TabIndex = 1107
        Me.final.Visible = False
        '
        'ckbCodInm
        '
        Me.ckbCodInm.AutoSize = True
        Me.ckbCodInm.Location = New System.Drawing.Point(595, 134)
        Me.ckbCodInm.Name = "ckbCodInm"
        Me.ckbCodInm.Size = New System.Drawing.Size(15, 14)
        Me.ckbCodInm.TabIndex = 1108
        Me.ckbCodInm.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(226, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 1109
        Me.Label5.Text = "Filtrar por"
        '
        'ckbCi
        '
        Me.ckbCi.AutoSize = True
        Me.ckbCi.Location = New System.Drawing.Point(428, 134)
        Me.ckbCi.Name = "ckbCi"
        Me.ckbCi.Size = New System.Drawing.Size(15, 14)
        Me.ckbCi.TabIndex = 1112
        Me.ckbCi.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(381, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 24)
        Me.Label6.TabIndex = 1113
        Me.Label6.Text = "Ci"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(463, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 24)
        Me.Label7.TabIndex = 1114
        Me.Label7.Text = "Id. Inmueble"
        '
        'txtb1
        '
        Me.txtb1.Location = New System.Drawing.Point(858, 60)
        Me.txtb1.Multiline = True
        Me.txtb1.Name = "txtb1"
        Me.txtb1.Size = New System.Drawing.Size(209, 25)
        Me.txtb1.TabIndex = 1115
        Me.txtb1.Visible = False
        '
        'txtb2
        '
        Me.txtb2.Location = New System.Drawing.Point(858, 100)
        Me.txtb2.Multiline = True
        Me.txtb2.Name = "txtb2"
        Me.txtb2.Size = New System.Drawing.Size(209, 25)
        Me.txtb2.TabIndex = 1116
        Me.txtb2.Visible = False
        '
        'ModVisita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1141, 752)
        Me.Controls.Add(Me.txtb2)
        Me.Controls.Add(Me.txtb1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ckbCi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckbCodInm)
        Me.Controls.Add(Me.final)
        Me.Controls.Add(Me.horaUpdate)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Ci_a_Modificar)
        Me.Controls.Add(Me.LbNewDatos)
        Me.Controls.Add(Me.LbCi)
        Me.Controls.Add(Me.FechaUpdate)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.concretadoBD)
        Me.Controls.Add(Me.BtnConfirmar)
        Me.Controls.Add(Me.data1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.TituloAC)
        Me.Controls.Add(Me.PnDatos)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModVisita"
        Me.Text = "}}"
        Me.PnDatos.ResumeLayout(False)
        Me.PnDatos.PerformLayout()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TituloAC As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents PnDatos As Panel
    Friend WithEvents Inmueble As Label
    Friend WithEvents TxtInmueble As TextBox
    Friend WithEvents Concretado As Label
    Friend WithEvents concretadoSi As CheckBox
    Friend WithEvents BtnConfirmar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents concretadoNo As CheckBox
    Friend WithEvents concretadoBD As TextBox
    Friend WithEvents data1 As DataGridView
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents LbCi As Label
    Friend WithEvents Ci_a_Modificar As TextBox
    Friend WithEvents LbNewDatos As Label
    Friend WithEvents FechaUpdate As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents horaUpdate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDia As Label
    Friend WithEvents final As TextBox
    Friend WithEvents ckbCodInm As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ckbCi As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtb1 As TextBox
    Friend WithEvents txtb2 As TextBox
    Friend WithEvents HoraaCombo As ComboBox
End Class
