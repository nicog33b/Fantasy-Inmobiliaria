<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TodasCanceladas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TodasCanceladas))
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.EntrarTabUp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbxCi = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbxCodInm = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'data1
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.data1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.data1.BackgroundColor = System.Drawing.Color.White
        Me.data1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data1.Location = New System.Drawing.Point(116, 210)
        Me.data1.Name = "data1"
        Me.data1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.data1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.data1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.data1.Size = New System.Drawing.Size(920, 312)
        Me.data1.TabIndex = 16
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(311, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 61)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Todas las canceladas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(496, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 24)
        Me.Label2.TabIndex = 1137
        Me.Label2.Text = "Id. Inmueble"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(414, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 24)
        Me.Label3.TabIndex = 1136
        Me.Label3.Text = "Ci"
        '
        'cbxCi
        '
        Me.cbxCi.AutoSize = True
        Me.cbxCi.Location = New System.Drawing.Point(461, 176)
        Me.cbxCi.Name = "cbxCi"
        Me.cbxCi.Size = New System.Drawing.Size(15, 14)
        Me.cbxCi.TabIndex = 1135
        Me.cbxCi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(259, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 1134
        Me.Label4.Text = "Filtrar por"
        '
        'CbxCodInm
        '
        Me.CbxCodInm.AutoSize = True
        Me.CbxCodInm.Location = New System.Drawing.Point(628, 176)
        Me.CbxCodInm.Name = "CbxCodInm"
        Me.CbxCodInm.Size = New System.Drawing.Size(15, 14)
        Me.CbxCodInm.TabIndex = 1133
        Me.CbxCodInm.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(703, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 25)
        Me.Button2.TabIndex = 1132
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(735, 173)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(160, 21)
        Me.txt_buscar.TabIndex = 1131
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(304, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 20)
        Me.Label8.TabIndex = 1130
        '
        'TodasCanceladas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 752)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbxCi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbxCodInm)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data1)
        Me.Controls.Add(Me.EntrarTabUp)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TodasCanceladas"
        Me.Text = "}}"
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents data1 As DataGridView
    Friend WithEvents EntrarTabUp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbxCi As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CbxCodInm As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label8 As Label
End Class
