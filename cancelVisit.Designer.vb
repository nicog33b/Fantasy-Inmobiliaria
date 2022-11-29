<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cancelvisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cancelvisit))
        Me.Busquedatxt = New System.Windows.Forms.Label()
        Me.data1 = New System.Windows.Forms.DataGridView()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ci_a_Cancelar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.data1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Busquedatxt
        '
        Me.Busquedatxt.AutoSize = True
        Me.Busquedatxt.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busquedatxt.ForeColor = System.Drawing.Color.MediumBlue
        Me.Busquedatxt.Location = New System.Drawing.Point(112, 183)
        Me.Busquedatxt.Name = "Busquedatxt"
        Me.Busquedatxt.Size = New System.Drawing.Size(93, 21)
        Me.Busquedatxt.TabIndex = 18
        Me.Busquedatxt.Text = "Busqueda:"
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
        Me.data1.Location = New System.Drawing.Point(116, 210)
        Me.data1.Name = "data1"
        Me.data1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.data1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.data1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.data1.Size = New System.Drawing.Size(920, 312)
        Me.data1.TabIndex = 16
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(434, 179)
        Me.txt_buscar.Multiline = True
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(279, 25)
        Me.txt_buscar.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(386, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 61)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Cancelar Visita"
        '
        'Ci_a_Cancelar
        '
        Me.Ci_a_Cancelar.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ci_a_Cancelar.ForeColor = System.Drawing.Color.Purple
        Me.Ci_a_Cancelar.Location = New System.Drawing.Point(493, 605)
        Me.Ci_a_Cancelar.Multiline = True
        Me.Ci_a_Cancelar.Name = "Ci_a_Cancelar"
        Me.Ci_a_Cancelar.Size = New System.Drawing.Size(167, 47)
        Me.Ci_a_Cancelar.TabIndex = 21
        Me.Ci_a_Cancelar.Text = "50113552"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(346, 539)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(456, 31)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Ingrese la cedula de la visita a borrar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelar.Image = CType(resources.GetObject("btn_cancelar.Image"), System.Drawing.Image)
        Me.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_cancelar.Location = New System.Drawing.Point(547, 671)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(61, 52)
        Me.btn_cancelar.TabIndex = 1109
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = CType(resources.GetObject("btn_buscar.BackgroundImage"), System.Drawing.Image)
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_buscar.Location = New System.Drawing.Point(719, 183)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(20, 20)
        Me.btn_buscar.TabIndex = 1110
        Me.btn_buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cancelvisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1141, 752)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Ci_a_Cancelar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Busquedatxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.data1)
        Me.ForeColor = System.Drawing.Color.Crimson
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cancelvisit"
        Me.Text = "}}"
        CType(Me.data1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Busquedatxt As Label
    Friend WithEvents data1 As DataGridView
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Ci_a_Cancelar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_buscar As Button
End Class
