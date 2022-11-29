<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PantallaVentana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PantallaVentana))
        Me.BarraArriba = New System.Windows.Forms.Panel()
        Me.OcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.AbrirMenu = New System.Windows.Forms.Timer(Me.components)
        Me.ImagenEmpresa = New System.Windows.Forms.PictureBox()
        Me.PanelMenuIzq = New System.Windows.Forms.Panel()
        Me.acc = New System.Windows.Forms.Label()
        Me.Cons = New System.Windows.Forms.Label()
        Me.btnCanc = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.BtnCons = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BugMenuFix = New System.Windows.Forms.Timer(Me.components)
        Me.VentanaHija = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.BarraArriba.SuspendLayout()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenuIzq.SuspendLayout()
        Me.VentanaHija.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'OcultarMenu
        '
        '
        'AbrirMenu
        '
        '
        'ImagenEmpresa
        '
        Me.ImagenEmpresa.Image = CType(resources.GetObject("ImagenEmpresa.Image"), System.Drawing.Image)
        Me.ImagenEmpresa.Location = New System.Drawing.Point(0, 0)
        Me.ImagenEmpresa.Name = "ImagenEmpresa"
        Me.ImagenEmpresa.Size = New System.Drawing.Size(206, 80)
        Me.ImagenEmpresa.TabIndex = 2
        Me.ImagenEmpresa.TabStop = False
        '
        'PanelMenuIzq
        '
        Me.PanelMenuIzq.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.PanelMenuIzq.Controls.Add(Me.acc)
        Me.PanelMenuIzq.Controls.Add(Me.Cons)
        Me.PanelMenuIzq.Controls.Add(Me.btnCanc)
        Me.PanelMenuIzq.Controls.Add(Me.btnMod)
        Me.PanelMenuIzq.Controls.Add(Me.BtnModificar)
        Me.PanelMenuIzq.Controls.Add(Me.ImagenEmpresa)
        Me.PanelMenuIzq.Controls.Add(Me.BtnCons)
        Me.PanelMenuIzq.Controls.Add(Me.BtnCancelar)
        Me.PanelMenuIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuIzq.Location = New System.Drawing.Point(0, 36)
        Me.PanelMenuIzq.Name = "PanelMenuIzq"
        Me.PanelMenuIzq.Size = New System.Drawing.Size(206, 752)
        Me.PanelMenuIzq.TabIndex = 1
        '
        'acc
        '
        Me.acc.AutoSize = True
        Me.acc.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acc.ForeColor = System.Drawing.Color.SteelBlue
        Me.acc.Location = New System.Drawing.Point(3, 412)
        Me.acc.Name = "acc"
        Me.acc.Size = New System.Drawing.Size(106, 28)
        Me.acc.TabIndex = 6
        Me.acc.Text = "Acciones"
        '
        'Cons
        '
        Me.Cons.AutoSize = True
        Me.Cons.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cons.ForeColor = System.Drawing.Color.SteelBlue
        Me.Cons.Location = New System.Drawing.Point(0, 117)
        Me.Cons.Name = "Cons"
        Me.Cons.Size = New System.Drawing.Size(203, 28)
        Me.Cons.TabIndex = 0
        Me.Cons.Text = "Todas las agendas"
        '
        'btnCanc
        '
        Me.btnCanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCanc.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCanc.ForeColor = System.Drawing.Color.DarkKhaki
        Me.btnCanc.Image = CType(resources.GetObject("btnCanc.Image"), System.Drawing.Image)
        Me.btnCanc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCanc.Location = New System.Drawing.Point(-1, 276)
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.Size = New System.Drawing.Size(206, 58)
        Me.btnCanc.TabIndex = 3
        Me.btnCanc.Text = "       Canceladas"
        Me.btnCanc.UseVisualStyleBackColor = False
        '
        'btnMod
        '
        Me.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMod.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.ForeColor = System.Drawing.Color.DarkKhaki
        Me.btnMod.Image = CType(resources.GetObject("btnMod.Image"), System.Drawing.Image)
        Me.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMod.Location = New System.Drawing.Point(-1, 212)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(206, 58)
        Me.btnMod.TabIndex = 5
        Me.btnMod.Text = "          Modificadas "
        Me.btnMod.UseVisualStyleBackColor = False
        '
        'BtnModificar
        '
        Me.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.Color.DarkKhaki
        Me.BtnModificar.Image = CType(resources.GetObject("BtnModificar.Image"), System.Drawing.Image)
        Me.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnModificar.Location = New System.Drawing.Point(-2, 455)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(206, 122)
        Me.BtnModificar.TabIndex = 4
        Me.BtnModificar.Text = "           Modificar Agendas"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'BtnCons
        '
        Me.BtnCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCons.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCons.ForeColor = System.Drawing.Color.DarkKhaki
        Me.BtnCons.Image = CType(resources.GetObject("BtnCons.Image"), System.Drawing.Image)
        Me.BtnCons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCons.Location = New System.Drawing.Point(-1, 148)
        Me.BtnCons.Name = "BtnCons"
        Me.BtnCons.Size = New System.Drawing.Size(206, 58)
        Me.BtnCons.TabIndex = 2
        Me.BtnCons.Text = "Del dia"
        Me.BtnCons.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.DarkKhaki
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(-2, 595)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(208, 122)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "          Cancelar Agendas"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BugMenuFix
        '
        Me.BugMenuFix.Interval = 8000
        '
        'VentanaHija
        '
        Me.VentanaHija.BackColor = System.Drawing.Color.White
        Me.VentanaHija.Controls.Add(Me.Panel1)
        Me.VentanaHija.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VentanaHija.Location = New System.Drawing.Point(206, 36)
        Me.VentanaHija.Name = "VentanaHija"
        Me.VentanaHija.Size = New System.Drawing.Size(1162, 752)
        Me.VentanaHija.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1162, 752)
        Me.Panel1.TabIndex = 21
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(1295, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 28)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1252, 5)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 41)
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        '
        'PantallaVentana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1368, 788)
        Me.Controls.Add(Me.VentanaHija)
        Me.Controls.Add(Me.PanelMenuIzq)
        Me.Controls.Add(Me.BarraArriba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PantallaVentana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.BarraArriba.ResumeLayout(False)
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenuIzq.ResumeLayout(False)
        Me.PanelMenuIzq.PerformLayout()
        Me.VentanaHija.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraArriba As Panel
    Friend WithEvents OcultarMenu As Timer
    Friend WithEvents AbrirMenu As Timer
    Friend WithEvents ImagenEmpresa As PictureBox
    Friend WithEvents PanelMenuIzq As Panel
    Friend WithEvents BtnModificar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnCons As Button
    Friend WithEvents BugMenuFix As Timer
    Friend WithEvents btnMod As Button
    Friend WithEvents acc As Label
    Friend WithEvents Cons As Label
    Friend WithEvents btnCanc As Button
    Friend WithEvents VentanaHija As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
End Class
