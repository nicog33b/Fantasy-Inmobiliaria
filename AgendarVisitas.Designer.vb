<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agendarvisitas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agendarvisitas))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ErrorRegistro1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorRegistro2 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorRegistro3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txt2 = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.ImagenEmpresa = New System.Windows.Forms.PictureBox()
        Me.txt1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ruser = New System.Windows.Forms.TextBox()
        Me.Rpass = New System.Windows.Forms.TextBox()
        Me.FechaAgenda = New System.Windows.Forms.DateTimePicker()
        Me.lblFechayHora = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.txtRecuerdo = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lblIdInMUEBLE = New System.Windows.Forms.Label()
        Me.BtnAgendar = New System.Windows.Forms.Button()
        Me.horas = New System.Windows.Forms.ComboBox()
        Me.cbxInm = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 45
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
        Me.Panel1.Size = New System.Drawing.Size(1038, 28)
        Me.Panel1.TabIndex = 55
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1038, 28)
        Me.Panel2.TabIndex = 56
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1038, 28)
        Me.Panel3.TabIndex = 57
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 778)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1038, 10)
        Me.Panel4.TabIndex = 58
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
        'ErrorRegistro2
        '
        Me.ErrorRegistro2.Interval = 1200
        '
        'ErrorRegistro3
        '
        Me.ErrorRegistro3.Interval = 1200
        '
        'Timer1
        '
        Me.Timer1.Interval = 1200
        '
        'txt2
        '
        Me.txt2.AutoSize = True
        Me.txt2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txt2.Font = New System.Drawing.Font("Georgia", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt2.ForeColor = System.Drawing.Color.BlueViolet
        Me.txt2.Location = New System.Drawing.Point(175, 18)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(711, 109)
        Me.txt2.TabIndex = 95
        Me.txt2.Text = "Agendar Visitas"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.BackColor = System.Drawing.Color.Silver
        Me.lbluser.Font = New System.Drawing.Font("Constantia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lbluser.Location = New System.Drawing.Point(592, 442)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(296, 59)
        Me.lbluser.TabIndex = 97
        Me.lbluser.Text = "Contraseña "
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.BackColor = System.Drawing.Color.Silver
        Me.lblpass.Font = New System.Drawing.Font("Constantia", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpass.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.lblpass.Location = New System.Drawing.Point(98, 442)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(205, 59)
        Me.lblpass.TabIndex = 96
        Me.lblpass.Text = "Usuario"
        '
        'ImagenEmpresa
        '
        Me.ImagenEmpresa.Image = CType(resources.GetObject("ImagenEmpresa.Image"), System.Drawing.Image)
        Me.ImagenEmpresa.Location = New System.Drawing.Point(434, 162)
        Me.ImagenEmpresa.Name = "ImagenEmpresa"
        Me.ImagenEmpresa.Size = New System.Drawing.Size(217, 92)
        Me.ImagenEmpresa.TabIndex = 100
        Me.ImagenEmpresa.TabStop = False
        '
        'txt1
        '
        Me.txt1.AutoSize = True
        Me.txt1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1.ForeColor = System.Drawing.Color.Brown
        Me.txt1.Location = New System.Drawing.Point(199, 327)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(710, 58)
        Me.txt1.TabIndex = 101
        Me.txt1.Text = "Es necesario que ingreses tu usuario y contraseña antes de entrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a esta seccio" &
    "n por motivos de seguridad." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txt2)
        Me.Panel5.Location = New System.Drawing.Point(-9, 27)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1129, 129)
        Me.Panel5.TabIndex = 1151
        '
        'ruser
        '
        Me.ruser.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.ruser.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ruser.ForeColor = System.Drawing.Color.DarkKhaki
        Me.ruser.Location = New System.Drawing.Point(108, 504)
        Me.ruser.Multiline = True
        Me.ruser.Name = "ruser"
        Me.ruser.Size = New System.Drawing.Size(373, 49)
        Me.ruser.TabIndex = 1152
        Me.ruser.Text = "5.011355.2"
        '
        'Rpass
        '
        Me.Rpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.Rpass.Font = New System.Drawing.Font("Times New Roman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rpass.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Rpass.Location = New System.Drawing.Point(602, 504)
        Me.Rpass.Multiline = True
        Me.Rpass.Name = "Rpass"
        Me.Rpass.Size = New System.Drawing.Size(394, 49)
        Me.Rpass.TabIndex = 1153
        '
        'FechaAgenda
        '
        Me.FechaAgenda.CalendarFont = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAgenda.CustomFormat = "yyyy-MM-dd"
        Me.FechaAgenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaAgenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.FechaAgenda.Location = New System.Drawing.Point(102, 330)
        Me.FechaAgenda.MaxDate = New Date(2025, 12, 30, 0, 0, 0, 0)
        Me.FechaAgenda.MinDate = New Date(2019, 10, 25, 0, 0, 0, 0)
        Me.FechaAgenda.Name = "FechaAgenda"
        Me.FechaAgenda.Size = New System.Drawing.Size(201, 38)
        Me.FechaAgenda.TabIndex = 1154
        Me.FechaAgenda.Value = New Date(2019, 10, 25, 0, 0, 0, 0)
        Me.FechaAgenda.Visible = False
        '
        'lblFechayHora
        '
        Me.lblFechayHora.AutoSize = True
        Me.lblFechayHora.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechayHora.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblFechayHora.Location = New System.Drawing.Point(98, 246)
        Me.lblFechayHora.Name = "lblFechayHora"
        Me.lblFechayHora.Size = New System.Drawing.Size(150, 56)
        Me.lblFechayHora.TabIndex = 1155
        Me.lblFechayHora.Text = "Fecha"
        Me.lblFechayHora.Visible = False
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.ForeColor = System.Drawing.Color.Blue
        Me.lblfecha.Location = New System.Drawing.Point(105, 302)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(154, 25)
        Me.lblfecha.TabIndex = 1156
        Me.lblfecha.Text = "Elije una fecha"
        Me.lblfecha.Visible = False
        '
        'txtRecuerdo
        '
        Me.txtRecuerdo.AutoSize = True
        Me.txtRecuerdo.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecuerdo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txtRecuerdo.Location = New System.Drawing.Point(31, 727)
        Me.txtRecuerdo.Name = "txtRecuerdo"
        Me.txtRecuerdo.Size = New System.Drawing.Size(995, 38)
        Me.txtRecuerdo.TabIndex = 1160
        Me.txtRecuerdo.Text = "Hola, te recordamos que revises los datos antes de confirmar la visita."
        Me.txtRecuerdo.Visible = False
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.ForeColor = System.Drawing.Color.Blue
        Me.lblhora.Location = New System.Drawing.Point(105, 473)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(147, 25)
        Me.lblhora.TabIndex = 1161
        Me.lblhora.Text = "Elije una Hora"
        Me.lblhora.Visible = False
        '
        'lblIdInMUEBLE
        '
        Me.lblIdInMUEBLE.AutoSize = True
        Me.lblIdInMUEBLE.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdInMUEBLE.ForeColor = System.Drawing.Color.FloralWhite
        Me.lblIdInMUEBLE.Location = New System.Drawing.Point(499, 350)
        Me.lblIdInMUEBLE.Name = "lblIdInMUEBLE"
        Me.lblIdInMUEBLE.Size = New System.Drawing.Size(497, 56)
        Me.lblIdInMUEBLE.TabIndex = 1163
        Me.lblIdInMUEBLE.Text = "Identifica tu inmueble"
        Me.lblIdInMUEBLE.Visible = False
        '
        'BtnAgendar
        '
        Me.BtnAgendar.BackColor = System.Drawing.Color.Green
        Me.BtnAgendar.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgendar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnAgendar.Location = New System.Drawing.Point(242, 655)
        Me.BtnAgendar.Name = "BtnAgendar"
        Me.BtnAgendar.Size = New System.Drawing.Size(554, 69)
        Me.BtnAgendar.TabIndex = 1167
        Me.BtnAgendar.Text = "Confirmar"
        Me.BtnAgendar.UseVisualStyleBackColor = False
        Me.BtnAgendar.Visible = False
        '
        'horas
        '
        Me.horas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.horas.Font = New System.Drawing.Font("Georgia", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.FormattingEnabled = True
        Me.horas.Location = New System.Drawing.Point(110, 511)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(127, 39)
        Me.horas.TabIndex = 1168
        Me.horas.Visible = False
        '
        'cbxInm
        '
        Me.cbxInm.Font = New System.Drawing.Font("Georgia", 20.25!)
        Me.cbxInm.FormattingEnabled = True
        Me.cbxInm.Location = New System.Drawing.Point(689, 428)
        Me.cbxInm.Name = "cbxInm"
        Me.cbxInm.Size = New System.Drawing.Size(95, 39)
        Me.cbxInm.TabIndex = 1170
        Me.cbxInm.Text = "1"
        Me.cbxInm.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1047, 249)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(10, 20)
        Me.TextBox1.TabIndex = 1172
        Me.TextBox1.Visible = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnConfirmar.Font = New System.Drawing.Font("Yu Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConfirmar.Location = New System.Drawing.Point(242, 655)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(554, 69)
        Me.btnConfirmar.TabIndex = 1173
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Label1.Location = New System.Drawing.Point(100, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 56)
        Me.Label1.TabIndex = 1175
        Me.Label1.Text = "Hora"
        Me.Label1.Visible = False
        '
        'Agendarvisitas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(1038, 788)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cbxInm)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.BtnAgendar)
        Me.Controls.Add(Me.lblIdInMUEBLE)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.txtRecuerdo)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lblFechayHora)
        Me.Controls.Add(Me.FechaAgenda)
        Me.Controls.Add(Me.Rpass)
        Me.Controls.Add(Me.ruser)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.ImagenEmpresa)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel5)
        Me.ForeColor = System.Drawing.Color.BlueViolet
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Agendarvisitas"
        Me.Opacity = 0.94R
        Me.Text = "USUARIO o C.I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenEmpresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents ErrorRegistro1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorRegistro2 As Timer
    Friend WithEvents ErrorRegistro3 As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt2 As Label
    Friend WithEvents lbluser As Label
    Friend WithEvents lblpass As Label
    Friend WithEvents txt1 As Label
    Friend WithEvents ImagenEmpresa As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ruser As TextBox
    Friend WithEvents Rpass As TextBox
    Friend WithEvents FechaAgenda As DateTimePicker
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblFechayHora As Label
    Friend WithEvents txtRecuerdo As Label
    Friend WithEvents lblhora As Label
    Friend WithEvents lblIdInMUEBLE As Label
    Friend WithEvents BtnAgendar As Button
    Friend WithEvents horas As ComboBox
    Friend WithEvents cbxInm As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents Label1 As Label
End Class
