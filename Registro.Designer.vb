<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro))
        Me.ci = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Rci = New System.Windows.Forms.TextBox()
        Me.contador = New System.Windows.Forms.Label()
        Me.ErrorRegistro1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VentanTop = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ruser = New System.Windows.Forms.TextBox()
        Me.Rpass = New System.Windows.Forms.TextBox()
        Me.Rcorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Rape = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Rnom = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Rdir = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FechaDia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FechaMes = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FechaAño = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.contador2 = New System.Windows.Forms.TextBox()
        Me.ImagenEmpresa = New System.Windows.Forms.PictureBox()
        Me.ErrorRegistro2 = New System.Windows.Forms.Timer(Me.components)
        Me.contador3 = New System.Windows.Forms.TextBox()
        Me.ErrorRegistro3 = New System.Windows.Forms.Timer(Me.components)
        Me.contador4 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.IntentaMsg = New System.Windows.Forms.Label()
        Me.Incorrectomsg = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.atras = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.VentanTop.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.atras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ci
        '
        Me.ci.AutoSize = True
        Me.ci.BackColor = System.Drawing.Color.Transparent
        Me.ci.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ci.ForeColor = System.Drawing.Color.DarkBlue
        Me.ci.Location = New System.Drawing.Point(227, 101)
        Me.ci.Name = "ci"
        Me.ci.Size = New System.Drawing.Size(321, 39)
        Me.ci.TabIndex = 38
        Me.ci.Text = "Cedula de identidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(209, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(339, 39)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Contraseña de cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 45
        '
        'Rci
        '
        Me.Rci.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rci.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rci.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rci.Location = New System.Drawing.Point(24, 144)
        Me.Rci.Multiline = True
        Me.Rci.Name = "Rci"
        Me.Rci.Size = New System.Drawing.Size(510, 53)
        Me.Rci.TabIndex = 40
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
        'ErrorRegistro1
        '
        Me.ErrorRegistro1.Interval = 1200
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
        Me.VentanTop.Controls.Add(Me.btnMinimizar)
        Me.VentanTop.Controls.Add(Me.btnSalir)
        Me.VentanTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.VentanTop.Location = New System.Drawing.Point(0, 0)
        Me.VentanTop.Name = "VentanTop"
        Me.VentanTop.Size = New System.Drawing.Size(1368, 28)
        Me.VentanTop.TabIndex = 57
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.Location = New System.Drawing.Point(1255, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(37, 41)
        Me.btnMinimizar.TabIndex = 87
        Me.btnMinimizar.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.Location = New System.Drawing.Point(1298, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 28)
        Me.btnSalir.TabIndex = 86
        Me.btnSalir.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(238, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 39)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Usuario  de cuenta"
        '
        'Ruser
        '
        Me.Ruser.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Ruser.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ruser.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Ruser.Location = New System.Drawing.Point(26, 254)
        Me.Ruser.Multiline = True
        Me.Ruser.Name = "Ruser"
        Me.Ruser.Size = New System.Drawing.Size(508, 51)
        Me.Ruser.TabIndex = 61
        '
        'Rpass
        '
        Me.Rpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rpass.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rpass.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rpass.Location = New System.Drawing.Point(24, 369)
        Me.Rpass.Multiline = True
        Me.Rpass.Name = "Rpass"
        Me.Rpass.Size = New System.Drawing.Size(510, 52)
        Me.Rpass.TabIndex = 62
        '
        'Rcorreo
        '
        Me.Rcorreo.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rcorreo.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rcorreo.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rcorreo.Location = New System.Drawing.Point(24, 497)
        Me.Rcorreo.Multiline = True
        Me.Rcorreo.Name = "Rcorreo"
        Me.Rcorreo.Size = New System.Drawing.Size(510, 53)
        Me.Rcorreo.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(238, 455)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 39)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Correo electronico"
        '
        'Rape
        '
        Me.Rape.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rape.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rape.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rape.Location = New System.Drawing.Point(896, 256)
        Me.Rape.Multiline = True
        Me.Rape.Name = "Rape"
        Me.Rape.Size = New System.Drawing.Size(441, 58)
        Me.Rape.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label6.Location = New System.Drawing.Point(889, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 39)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Apellido"
        '
        'Rnom
        '
        Me.Rnom.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rnom.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnom.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rnom.Location = New System.Drawing.Point(896, 143)
        Me.Rnom.Multiline = True
        Me.Rnom.Name = "Rnom"
        Me.Rnom.Size = New System.Drawing.Size(441, 52)
        Me.Rnom.TabIndex = 67
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label8.Location = New System.Drawing.Point(889, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 39)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Nombre"
        '
        'Rdir
        '
        Me.Rdir.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rdir.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdir.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rdir.Location = New System.Drawing.Point(896, 368)
        Me.Rdir.Multiline = True
        Me.Rdir.Name = "Rdir"
        Me.Rdir.Size = New System.Drawing.Size(441, 52)
        Me.Rdir.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(889, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 39)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Direccion"
        '
        'FechaDia
        '
        Me.FechaDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FechaDia.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaDia.ForeColor = System.Drawing.Color.DarkKhaki
        Me.FechaDia.Location = New System.Drawing.Point(947, 496)
        Me.FechaDia.Multiline = True
        Me.FechaDia.Name = "FechaDia"
        Me.FechaDia.Size = New System.Drawing.Size(71, 54)
        Me.FechaDia.TabIndex = 71
        Me.FechaDia.Text = "06"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(889, 454)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(327, 39)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label9.Location = New System.Drawing.Point(889, 511)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 39)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "D"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label10.Location = New System.Drawing.Point(1034, 511)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 39)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "M"
        '
        'FechaMes
        '
        Me.FechaMes.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FechaMes.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaMes.ForeColor = System.Drawing.Color.DarkKhaki
        Me.FechaMes.Location = New System.Drawing.Point(1098, 496)
        Me.FechaMes.Multiline = True
        Me.FechaMes.Name = "FechaMes"
        Me.FechaMes.Size = New System.Drawing.Size(71, 54)
        Me.FechaMes.TabIndex = 76
        Me.FechaMes.Text = "11"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Constantia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label11.Location = New System.Drawing.Point(1178, 511)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 39)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "A"
        '
        'FechaAño
        '
        Me.FechaAño.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.FechaAño.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAño.ForeColor = System.Drawing.Color.DarkKhaki
        Me.FechaAño.Location = New System.Drawing.Point(1230, 497)
        Me.FechaAño.Multiline = True
        Me.FechaAño.Name = "FechaAño"
        Me.FechaAño.Size = New System.Drawing.Size(107, 54)
        Me.FechaAño.TabIndex = 78
        Me.FechaAño.Text = "1999"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        Me.ErrorProvider2.Icon = CType(resources.GetObject("ErrorProvider2.Icon"), System.Drawing.Icon)
        Me.ErrorProvider2.RightToLeft = True
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'contador2
        '
        Me.contador2.Location = New System.Drawing.Point(1180, 656)
        Me.contador2.Name = "contador2"
        Me.contador2.Size = New System.Drawing.Size(65, 20)
        Me.contador2.TabIndex = 80
        Me.contador2.Text = "0"
        Me.contador2.Visible = False
        '
        'ImagenEmpresa
        '
        Me.ImagenEmpresa.Image = CType(resources.GetObject("ImagenEmpresa.Image"), System.Drawing.Image)
        Me.ImagenEmpresa.Location = New System.Drawing.Point(604, 48)
        Me.ImagenEmpresa.Name = "ImagenEmpresa"
        Me.ImagenEmpresa.Size = New System.Drawing.Size(217, 92)
        Me.ImagenEmpresa.TabIndex = 81
        Me.ImagenEmpresa.TabStop = False
        '
        'ErrorRegistro2
        '
        Me.ErrorRegistro2.Interval = 1200
        '
        'contador3
        '
        Me.contador3.Location = New System.Drawing.Point(1198, 630)
        Me.contador3.Name = "contador3"
        Me.contador3.Size = New System.Drawing.Size(65, 20)
        Me.contador3.TabIndex = 82
        Me.contador3.Text = "0"
        Me.contador3.Visible = False
        '
        'ErrorRegistro3
        '
        Me.ErrorRegistro3.Interval = 1200
        '
        'contador4
        '
        Me.contador4.Location = New System.Drawing.Point(1198, 604)
        Me.contador4.Name = "contador4"
        Me.contador4.Size = New System.Drawing.Size(65, 20)
        Me.contador4.TabIndex = 83
        Me.contador4.Text = "0"
        Me.contador4.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1200
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.BtnRegistrar.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnRegistrar.Location = New System.Drawing.Point(436, 675)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(563, 69)
        Me.BtnRegistrar.TabIndex = 59
        Me.BtnRegistrar.Text = "REGISTRAR"
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'IntentaMsg
        '
        Me.IntentaMsg.AutoSize = True
        Me.IntentaMsg.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntentaMsg.ForeColor = System.Drawing.Color.DodgerBlue
        Me.IntentaMsg.Location = New System.Drawing.Point(625, 528)
        Me.IntentaMsg.Name = "IntentaMsg"
        Me.IntentaMsg.Size = New System.Drawing.Size(174, 23)
        Me.IntentaMsg.TabIndex = 85
        Me.IntentaMsg.Text = "Intenta denuevo."
        Me.IntentaMsg.Visible = False
        '
        'Incorrectomsg
        '
        Me.Incorrectomsg.AutoSize = True
        Me.Incorrectomsg.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Incorrectomsg.ForeColor = System.Drawing.Color.Red
        Me.Incorrectomsg.Location = New System.Drawing.Point(625, 528)
        Me.Incorrectomsg.Name = "Incorrectomsg"
        Me.Incorrectomsg.Size = New System.Drawing.Size(184, 23)
        Me.Incorrectomsg.TabIndex = 84
        Me.Incorrectomsg.Text = "Datos incorrectos."
        Me.Incorrectomsg.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(153, 687)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 30)
        Me.Label12.TabIndex = 87
        Me.Label12.Text = "ATRAS"
        '
        'atras
        '
        Me.atras.Image = CType(resources.GetObject("atras.Image"), System.Drawing.Image)
        Me.atras.Location = New System.Drawing.Point(56, 664)
        Me.atras.Name = "atras"
        Me.atras.Size = New System.Drawing.Size(74, 70)
        Me.atras.TabIndex = 86
        Me.atras.TabStop = False
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1368, 788)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.atras)
        Me.Controls.Add(Me.IntentaMsg)
        Me.Controls.Add(Me.Incorrectomsg)
        Me.Controls.Add(Me.contador4)
        Me.Controls.Add(Me.contador3)
        Me.Controls.Add(Me.ImagenEmpresa)
        Me.Controls.Add(Me.contador2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FechaAño)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FechaMes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Rdir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FechaDia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Rape)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Rnom)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Rcorreo)
        Me.Controls.Add(Me.Rpass)
        Me.Controls.Add(Me.Ruser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.contador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Rci)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ci)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro"
        Me.Opacity = 0.94R
        Me.Text = "USUARIO o C.I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.VentanTop.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.atras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ci As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Rci As TextBox
    Friend WithEvents contador As Label
    Friend WithEvents ErrorRegistro1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VentanTop As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Ruser As TextBox
    Friend WithEvents Rpass As TextBox
    Friend WithEvents Rcorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Rape As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Rnom As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Rdir As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents FechaDia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents FechaMes As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents FechaAño As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents contador2 As TextBox
    Friend WithEvents ImagenEmpresa As PictureBox
    Friend WithEvents ErrorRegistro2 As Timer
    Friend WithEvents contador3 As TextBox
    Friend WithEvents ErrorRegistro3 As Timer
    Friend WithEvents contador4 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents IntentaMsg As Label
    Friend WithEvents Incorrectomsg As Label
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnSalir As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents atras As PictureBox
End Class
