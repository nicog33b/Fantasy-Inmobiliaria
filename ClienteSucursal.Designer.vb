<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClienteSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClienteSucursal))
        Me.OcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.AbrirMenu = New System.Windows.Forms.Timer(Me.components)
        Me.BugMenuFix = New System.Windows.Forms.Timer(Me.components)
        Me.VentanaHija = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelMenuIzq = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ImagenEmpresa1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BarraArriba = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.VentanaHija.SuspendLayout()
        Me.PanelMenuIzq.SuspendLayout()
        CType(Me.ImagenEmpresa1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraArriba.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BugMenuFix
        '
        Me.BugMenuFix.Interval = 8000
        '
        'VentanaHija
        '
        Me.VentanaHija.BackColor = System.Drawing.Color.Black
        Me.VentanaHija.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VentanaHija.Controls.Add(Me.Panel2)
        Me.VentanaHija.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VentanaHija.Location = New System.Drawing.Point(330, 0)
        Me.VentanaHija.Name = "VentanaHija"
        Me.VentanaHija.Size = New System.Drawing.Size(1038, 788)
        Me.VentanaHija.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 774)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1036, 12)
        Me.Panel2.TabIndex = 1
        '
        'PanelMenuIzq
        '
        Me.PanelMenuIzq.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.PanelMenuIzq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMenuIzq.Controls.Add(Me.Panel3)
        Me.PanelMenuIzq.Controls.Add(Me.Panel1)
        Me.PanelMenuIzq.Controls.Add(Me.ImagenEmpresa1)
        Me.PanelMenuIzq.Controls.Add(Me.Button1)
        Me.PanelMenuIzq.Controls.Add(Me.Button2)
        Me.PanelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuIzq.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenuIzq.Name = "PanelMenuIzq"
        Me.PanelMenuIzq.Size = New System.Drawing.Size(330, 788)
        Me.PanelMenuIzq.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(328, 27)
        Me.Panel3.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 774)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 12)
        Me.Panel1.TabIndex = 5
        '
        'ImagenEmpresa1
        '
        Me.ImagenEmpresa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ImagenEmpresa1.Image = CType(resources.GetObject("ImagenEmpresa1.Image"), System.Drawing.Image)
        Me.ImagenEmpresa1.Location = New System.Drawing.Point(64, 63)
        Me.ImagenEmpresa1.Name = "ImagenEmpresa1"
        Me.ImagenEmpresa1.Size = New System.Drawing.Size(212, 90)
        Me.ImagenEmpresa1.TabIndex = 2
        Me.ImagenEmpresa1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(330, 117)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ver Propiedades"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Cambria", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.Cornsilk
        Me.Button2.Location = New System.Drawing.Point(-2, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(330, 117)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Agendar Visita"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BarraArriba
        '
        Me.BarraArriba.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BarraArriba.Controls.Add(Me.btnSalir)
        Me.BarraArriba.Controls.Add(Me.btnMinimizar)
        Me.BarraArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraArriba.Location = New System.Drawing.Point(330, 0)
        Me.BarraArriba.Name = "BarraArriba"
        Me.BarraArriba.Size = New System.Drawing.Size(1038, 27)
        Me.BarraArriba.TabIndex = 3
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(971, -3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 28)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(928, -3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 41)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.TabStop = False
        '
        'ClienteSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1368, 788)
        Me.Controls.Add(Me.BarraArriba)
        Me.Controls.Add(Me.VentanaHija)
        Me.Controls.Add(Me.PanelMenuIzq)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClienteSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.VentanaHija.ResumeLayout(False)
        Me.PanelMenuIzq.ResumeLayout(False)
        CType(Me.ImagenEmpresa1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraArriba.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OcultarMenu As Timer
    Friend WithEvents AbrirMenu As Timer
    Friend WithEvents BugMenuFix As Timer
    Friend WithEvents VentanaHija As Panel
    Friend WithEvents PanelMenuIzq As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ImagenEmpresa1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BarraArriba As Panel
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
End Class
