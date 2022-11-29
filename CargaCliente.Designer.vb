<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CargaCliente
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CargaCliente))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.contador = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VentanTop = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BarradeCarga = New System.Windows.Forms.Timer(Me.components)
        Me.a1 = New System.Windows.Forms.Label()
        Me.a2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImagenEmpresa = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 45
        '
        'contador
        '
        Me.contador.AutoSize = True
        Me.contador.Location = New System.Drawing.Point(190, 483)
        Me.contador.Name = "contador"
        Me.contador.Size = New System.Drawing.Size(13, 13)
        Me.contador.TabIndex = 54
        Me.contador.Text = "0"
        Me.contador.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1368, 28)
        Me.Panel1.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Controls.Add(Me.VentanTop)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1368, 28)
        Me.Panel2.TabIndex = 56
        '
        'VentanTop
        '
        Me.VentanTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.VentanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.VentanTop.Location = New System.Drawing.Point(0, 0)
        Me.VentanTop.Name = "VentanTop"
        Me.VentanTop.Size = New System.Drawing.Size(1368, 28)
        Me.VentanTop.TabIndex = 57
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 778)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1368, 10)
        Me.Panel4.TabIndex = 58
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.MediumOrchid
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.ProgressBar1.Location = New System.Drawing.Point(410, 643)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(546, 32)
        Me.ProgressBar1.TabIndex = 59
        '
        'BarradeCarga
        '
        Me.BarradeCarga.Enabled = True
        Me.BarradeCarga.Interval = 20
        '
        'a1
        '
        Me.a1.AutoSize = True
        Me.a1.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a1.ForeColor = System.Drawing.Color.DarkGreen
        Me.a1.Location = New System.Drawing.Point(97, 77)
        Me.a1.Name = "a1"
        Me.a1.Size = New System.Drawing.Size(299, 64)
        Me.a1.TabIndex = 60
        Me.a1.Text = "Bienvenido"
        '
        'a2
        '
        Me.a2.AutoSize = True
        Me.a2.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.a2.ForeColor = System.Drawing.Color.DarkGreen
        Me.a2.Location = New System.Drawing.Point(483, 77)
        Me.a2.Name = "a2"
        Me.a2.Size = New System.Drawing.Size(56, 64)
        Me.a2.TabIndex = 61
        Me.a2.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(393, 589)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(579, 29)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Ya estas listo. Encuentra la casa de tus sueños."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(263, 383)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 65
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(572, 238)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(246, 158)
        Me.PictureBox3.TabIndex = 70
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1005, 328)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(246, 158)
        Me.PictureBox2.TabIndex = 71
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(107, 328)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 158)
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 68
        '
        'ImagenEmpresa
        '
        Me.ImagenEmpresa.Image = CType(resources.GetObject("ImagenEmpresa.Image"), System.Drawing.Image)
        Me.ImagenEmpresa.Location = New System.Drawing.Point(1148, 684)
        Me.ImagenEmpresa.Name = "ImagenEmpresa"
        Me.ImagenEmpresa.Size = New System.Drawing.Size(217, 92)
        Me.ImagenEmpresa.TabIndex = 72
        Me.ImagenEmpresa.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(904, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(318, 64)
        Me.Label13.TabIndex = 103
        Me.Label13.Text = "Inmobiliaria"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft YaHei", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkRed
        Me.Label14.Location = New System.Drawing.Point(626, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(214, 64)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Fantasy"
        '
        'CargaCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1368, 788)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ImagenEmpresa)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.a2)
        Me.Controls.Add(Me.a1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.contador)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CargaCliente"
        Me.Opacity = 0.94R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIO o C.I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents contador As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VentanTop As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BarradeCarga As Timer
    Friend WithEvents a1 As Label
    Friend WithEvents a2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ImagenEmpresa As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
