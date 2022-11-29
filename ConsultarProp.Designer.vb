<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConsultarProp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultarProp))
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EntrarTabUp = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckbCodInm = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckbCi = New System.Windows.Forms.CheckBox()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.data1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data1.BackgroundColor = System.Drawing.Color.White
        Me.data1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(119, 218)
        Me.data1.Name = "data1"
        Me.data1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.data1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.data1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.data1.Size = New System.Drawing.Size(920, 500)
        Me.data1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(311, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(558, 61)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Consultar Propiedades"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(302, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 20)
        Me.Label2.TabIndex = 1130
        '
        'EntrarTabUp
        '
        Me.EntrarTabUp.AutoSize = True
        Me.EntrarTabUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EntrarTabUp.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntrarTabUp.ForeColor = System.Drawing.Color.Black
        Me.EntrarTabUp.Location = New System.Drawing.Point(311, 13)
        Me.EntrarTabUp.Name = "EntrarTabUp"
        Me.EntrarTabUp.Size = New System.Drawing.Size(514, 61)
        Me.EntrarTabUp.TabIndex = 15
        Me.EntrarTabUp.Text = "Agendas Canceladas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label5.Location = New System.Drawing.Point(257, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 1134
        Me.Label5.Text = "Filtrar por"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(733, 174)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(160, 21)
        Me.txt_buscar.TabIndex = 1131
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(701, 169)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 25)
        Me.Button1.TabIndex = 1132
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckbCodInm
        '
        Me.ckbCodInm.AutoSize = True
        Me.ckbCodInm.Location = New System.Drawing.Point(626, 177)
        Me.ckbCodInm.Name = "ckbCodInm"
        Me.ckbCodInm.Size = New System.Drawing.Size(15, 14)
        Me.ckbCodInm.TabIndex = 1133
        Me.ckbCodInm.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label7.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(494, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 24)
        Me.Label7.TabIndex = 1137
        Me.Label7.Text = "Id. Inmueble"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(412, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 24)
        Me.Label6.TabIndex = 1136
        Me.Label6.Text = "Ci"
        '
        'ckbCi
        '
        Me.ckbCi.AutoSize = True
        Me.ckbCi.Location = New System.Drawing.Point(459, 177)
        Me.ckbCi.Name = "ckbCi"
        Me.ckbCi.Size = New System.Drawing.Size(15, 14)
        Me.ckbCi.TabIndex = 1135
        Me.ckbCi.UseVisualStyleBackColor = True
        '
        'ConsultarProp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 752)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ckbCi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ckbCodInm)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data1)
        Me.Controls.Add(Me.EntrarTabUp)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarProp"
        Me.Text = "}}"
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EntrarTabUp As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ckbCodInm As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ckbCi As CheckBox
End Class
