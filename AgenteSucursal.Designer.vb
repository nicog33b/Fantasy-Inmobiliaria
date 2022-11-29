<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgenteSucursal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgenteSucursal))
        Me.OcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.AbrirMenu = New System.Windows.Forms.Timer(Me.components)
        Me.ImagenEmpresa = New System.Windows.Forms.PictureBox()
        Me.PanelMenuIzq = New System.Windows.Forms.Panel()
        Me.BtnCons = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.acc = New System.Windows.Forms.Label()
        Me.BugMenuFix = New System.Windows.Forms.Timer(Me.components)
        Me.BarraArriba = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.VentanaHija = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenuIzq.SuspendLayout()
        Me.BarraArriba.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentanaHija.SuspendLayout()
        Me.SuspendLayout()
        '
        'OcultarMenu
        '
        '
        'AbrirMenu
        '
        '
        'ImagenEmpresa
        '
        Me.ImagenEmpresa.Image = CType(resources.GetObject("ImagenEmpresa.Image"), System.Drawing.Image)
        Me.ImagenEmpresa.Location = New System.Drawing.Point(12, 6)
        Me.ImagenEmpresa.Name = "ImagenEmpresa"
        Me.ImagenEmpresa.Size = New System.Drawing.Size(200, 91)
        Me.ImagenEmpresa.TabIndex = 2
        Me.ImagenEmpresa.TabStop = False
        '
        'PanelMenuIzq
        '
        Me.PanelMenuIzq.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelMenuIzq.Controls.Add(Me.BtnCons)
        Me.PanelMenuIzq.Controls.Add(Me.BtnModificar)
        Me.PanelMenuIzq.Controls.Add(Me.BtnCancelar)
        Me.PanelMenuIzq.Controls.Add(Me.acc)
        Me.PanelMenuIzq.Controls.Add(Me.ImagenEmpresa)
        Me.PanelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuIzq.Location = New System.Drawing.Point(0, 36)
        Me.PanelMenuIzq.Name = "PanelMenuIzq"
        Me.PanelMenuIzq.Size = New System.Drawing.Size(227, 752)
        Me.PanelMenuIzq.TabIndex = 1
        '
        'BtnCons
        '
        Me.BtnCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCons.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCons.ForeColor = System.Drawing.Color.DarkKhaki
        Me.BtnCons.Image = CType(resources.GetObject("BtnCons.Image"), System.Drawing.Image)
        Me.BtnCons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCons.Location = New System.Drawing.Point(-7, 239)
        Me.BtnCons.Name = "BtnCons"
        Me.BtnCons.Size = New System.Drawing.Size(234, 80)
        Me.BtnCons.TabIndex = 2
        Me.BtnCons.Text = "            Consultar Propiedades"
        Me.BtnCons.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.DarkKhaki
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(-1, 353)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(227, 77)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "           Modificar Agendas"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.DarkKhaki
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(-1, 461)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(227, 80)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "          Cancelar Agendas"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'acc
        '
        Me.acc.AutoSize = True
        Me.acc.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc.ForeColor = System.Drawing.Color.SteelBlue
        Me.acc.Location = New System.Drawing.Point(33, 172)
        Me.acc.Name = "acc"
        Me.acc.Size = New System.Drawing.Size(136, 36)
        Me.acc.TabIndex = 7
        Me.acc.Text = "Acciones"
        '
        'BugMenuFix
        '
        Me.BugMenuFix.Interval = 8000
        '
        'BarraArriba
        '
        Me.BarraArriba.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BarraArriba.Controls.Add(Me.btnSalir)
        Me.BarraArriba.Controls.Add(Me.btnMinimizar)
        Me.BarraArriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraArriba.Location = New System.Drawing.Point(0, 0)
        Me.BarraArriba.Name = "BarraArriba"
        Me.BarraArriba.Size = New System.Drawing.Size(1368, 36)
        Me.BarraArriba.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(1294, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 28)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1251, 5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 41)
        Me.btnMinimizar.TabIndex = 4
        Me.btnMinimizar.TabStop = False
        '
        'VentanaHija
        '
        Me.VentanaHija.BackColor = System.Drawing.Color.White
        Me.VentanaHija.Controls.Add(Me.Panel1)
        Me.VentanaHija.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VentanaHija.Location = New System.Drawing.Point(227, 36)
        Me.VentanaHija.Name = "VentanaHija"
        Me.VentanaHija.Size = New System.Drawing.Size(1141, 752)
        Me.VentanaHija.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1141, 752)
        Me.Panel1.TabIndex = 16
        '
        'AgenteSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1368, 788)
        Me.Controls.Add(Me.VentanaHija)
        Me.Controls.Add(Me.PanelMenuIzq)
        Me.Controls.Add(Me.BarraArriba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgenteSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenuIzq.ResumeLayout(False)
        Me.PanelMenuIzq.PerformLayout()
        Me.BarraArriba.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentanaHija.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OcultarMenu As Timer
    Friend WithEvents AbrirMenu As Timer
    Friend WithEvents ImagenEmpresa As PictureBox
    Friend WithEvents PanelMenuIzq As Panel
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnCons As Button
    Friend WithEvents BugMenuFix As Timer
    Friend WithEvents acc As Label
    Friend WithEvents BarraArriba As Panel
    Friend WithEvents VentanaHija As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
End Class
