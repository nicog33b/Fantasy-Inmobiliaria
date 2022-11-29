<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entrar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.user = New System.Windows.Forms.TextBox()
        Me.contador = New System.Windows.Forms.Label()
        Me.TmrGerente = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUserIncorrecto = New System.Windows.Forms.Timer(Me.components)
        Me.TmrAgente = New System.Windows.Forms.Timer(Me.components)
        Me.TmrCliente = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VentanTop = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.ImagenEmpresa = New System.Windows.Forms.PictureBox()
        Me.atras = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PanelRecuperarPassword = New System.Windows.Forms.Panel()
        Me.Recuperar = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtusu = New System.Windows.Forms.TextBox()
        Me.txtci = New System.Windows.Forms.TextBox()
        Me.btnRecup = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.VentanTop.SuspendLayout()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.atras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRecuperarPassword.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Font = New System.Drawing.Font("Constantia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(408, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 59)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Usuario de cuenta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Constantia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(408, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(515, 59)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Contraseña de cuenta"
        '
        'pass
        '
        Me.pass.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.pass.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.ForeColor = System.Drawing.Color.DarkKhaki
        Me.pass.Location = New System.Drawing.Point(409, 374)
        Me.pass.Multiline = True
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.pass.Size = New System.Drawing.Size(521, 61)
        Me.pass.TabIndex = 41
        Me.pass.Text = "A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 45
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.RosyBrown
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Cornsilk
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.Desktop
        Me.LinkLabel1.Location = New System.Drawing.Point(734, 497)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(262, 23)
        Me.LinkLabel1.TabIndex = 46
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "¿Aun no estas registrado?"
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.user.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.DarkKhaki
        Me.user.Location = New System.Drawing.Point(409, 190)
        Me.user.Multiline = True
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(521, 58)
        Me.user.TabIndex = 40
        Me.user.Text = "5.011355.2"
        '
        'contador
        '
        Me.contador.AutoSize = True
        Me.contador.Location = New System.Drawing.Point(-3, 369)
        Me.contador.Name = "contador"
        Me.contador.Size = New System.Drawing.Size(13, 13)
        Me.contador.TabIndex = 54
        Me.contador.Text = "0"
        Me.contador.Visible = False
        '
        'TmrGerente
        '
        Me.TmrGerente.Interval = 500
        '
        'TmrUserIncorrecto
        '
        Me.TmrUserIncorrecto.Interval = 500
        '
        'TmrAgente
        '
        Me.TmrAgente.Interval = 500
        '
        'TmrCliente
        '
        Me.TmrCliente.Interval = 500
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
        Me.VentanTop.Controls.Add(Me.btnSalir)
        Me.VentanTop.Controls.Add(Me.btnMinimizar)
        Me.VentanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.VentanTop.Location = New System.Drawing.Point(0, 0)
        Me.VentanTop.Name = "VentanTop"
        Me.VentanTop.Size = New System.Drawing.Size(1368, 28)
        Me.VentanTop.TabIndex = 57
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(1303, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 28)
        Me.btnSalir.TabIndex = 63
        Me.btnSalir.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1260, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 41)
        Me.btnMinimizar.TabIndex = 62
        Me.btnMinimizar.TabStop = False
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
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEntrar.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEntrar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnEntrar.Location = New System.Drawing.Point(314, 662)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(722, 73)
        Me.BtnEntrar.TabIndex = 59
        Me.BtnEntrar.Text = "ENTRAR"
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'ImagenEmpresa
        '
        Me.ImagenEmpresa.Image = CType(resources.GetObject("ImagenEmpresa.Image"), System.Drawing.Image)
        Me.ImagenEmpresa.Location = New System.Drawing.Point(577, 555)
        Me.ImagenEmpresa.Name = "ImagenEmpresa"
        Me.ImagenEmpresa.Size = New System.Drawing.Size(217, 92)
        Me.ImagenEmpresa.TabIndex = 61
        Me.ImagenEmpresa.TabStop = False
        '
        'atras
        '
        Me.atras.Image = CType(resources.GetObject("atras.Image"), System.Drawing.Image)
        Me.atras.Location = New System.Drawing.Point(46, 662)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(74, 70)
        Me.atras.TabIndex = 62
        Me.atras.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(143, 685)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 30)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "ATRAS"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.RosyBrown
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Cornsilk
        Me.LinkLabel2.LinkColor = System.Drawing.SystemColors.MenuHighlight
        Me.LinkLabel2.Location = New System.Drawing.Point(322, 497)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(243, 23)
        Me.LinkLabel2.TabIndex = 60
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "¿Recuperar contraseña?"
        '
        'PanelRecuperarPassword
        '
        Me.PanelRecuperarPassword.Controls.Add(Me.Label8)
        Me.PanelRecuperarPassword.Controls.Add(Me.txtnom)
        Me.PanelRecuperarPassword.Controls.Add(Me.Label7)
        Me.PanelRecuperarPassword.Controls.Add(Me.Label6)
        Me.PanelRecuperarPassword.Controls.Add(Me.btnRecup)
        Me.PanelRecuperarPassword.Controls.Add(Me.txtci)
        Me.PanelRecuperarPassword.Controls.Add(Me.txtusu)
        Me.PanelRecuperarPassword.Controls.Add(Me.Label5)
        Me.PanelRecuperarPassword.Controls.Add(Me.Recuperar)
        Me.PanelRecuperarPassword.Location = New System.Drawing.Point(1061, 111)
        Me.PanelRecuperarPassword.Name = "PanelRecuperarPassword"
        Me.PanelRecuperarPassword.Size = New System.Drawing.Size(235, 381)
        Me.PanelRecuperarPassword.TabIndex = 64
        Me.PanelRecuperarPassword.Visible = False
        '
        'Recuperar
        '
        Me.Recuperar.AutoSize = True
        Me.Recuperar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recuperar.Location = New System.Drawing.Point(1, 15)
        Me.Recuperar.Name = "Recuperar"
        Me.Recuperar.Size = New System.Drawing.Size(231, 25)
        Me.Recuperar.TabIndex = 0
        Me.Recuperar.Text = "Recuperar contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label5.Location = New System.Drawing.Point(19, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 92)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Para recuperar tu " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "contraseña debes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingresar los siguientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "datos"
        '
        'txtusu
        '
        Me.txtusu.Location = New System.Drawing.Point(50, 232)
        Me.txtusu.Multiline = True
        Me.txtusu.Name = "txtusu"
        Me.txtusu.Size = New System.Drawing.Size(142, 28)
        Me.txtusu.TabIndex = 3
        '
        'txtci
        '
        Me.txtci.Location = New System.Drawing.Point(50, 170)
        Me.txtci.Multiline = True
        Me.txtci.Name = "txtci"
        Me.txtci.Size = New System.Drawing.Size(142, 28)
        Me.txtci.TabIndex = 4
        '
        'btnRecup
        '
        Me.btnRecup.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRecup.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecup.ForeColor = System.Drawing.SystemColors.Control
        Me.btnRecup.Location = New System.Drawing.Point(3, 325)
        Me.btnRecup.Name = "btnRecup"
        Me.btnRecup.Size = New System.Drawing.Size(229, 53)
        Me.btnRecup.TabIndex = 65
        Me.btnRecup.Text = "Recuperar"
        Me.btnRecup.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 20)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "C.i"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 20)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Usuario"
        '
        'txtnom
        '
        Me.txtnom.Location = New System.Drawing.Point(50, 291)
        Me.txtnom.Multiline = True
        Me.txtnom.Name = "txtnom"
        Me.txtnom.Size = New System.Drawing.Size(142, 28)
        Me.txtnom.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 20)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Nombre"
        '
        'Entrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1368, 788)
        Me.Controls.Add(Me.PanelRecuperarPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.ImagenEmpresa)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.BtnEntrar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.contador)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entrar"
        Me.Opacity = 0.94R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIO o C.I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.VentanTop.ResumeLayout(False)
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.atras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRecuperarPassword.ResumeLayout(False)
        Me.PanelRecuperarPassword.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents user As TextBox
    Friend WithEvents contador As Label
    Friend WithEvents TmrGerente As Timer
    Friend WithEvents TmrUserIncorrecto As Timer
    Friend WithEvents TmrAgente As Timer
    Friend WithEvents TmrCliente As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VentanTop As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents ImagenEmpresa As PictureBox
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents atras As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents PanelRecuperarPassword As Panel
    Friend WithEvents txtusu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Recuperar As Label
    Friend WithEvents btnRecup As Button
    Friend WithEvents txtci As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnom As TextBox
End Class
