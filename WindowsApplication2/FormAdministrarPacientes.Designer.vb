<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tb_direccion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tb_direccion))
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.tb_contraindicaciones = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.cb_departamento = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tb_nombredepto = New System.Windows.Forms.Label()
        Me.btnAgregarPaciente = New System.Windows.Forms.Button()
        Me.tb_estadoc = New System.Windows.Forms.ComboBox()
        Me.tb_sexo = New System.Windows.Forms.ComboBox()
        Me.tb_edad = New System.Windows.Forms.ComboBox()
        Me.tb_aseguradora = New System.Windows.Forms.TextBox()
        Me.tbb_direccion = New System.Windows.Forms.TextBox()
        Me.tb_apellidos = New System.Windows.Forms.TextBox()
        Me.tb_nombres = New System.Windows.Forms.TextBox()
        Me.tb_rut = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.ErrorGeneral = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(253, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(290, 24)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Registro Ingreso de Pacientes"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(507, 588)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 25)
        Me.btnSalir.TabIndex = 77
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'tb_contraindicaciones
        '
        Me.tb_contraindicaciones.Location = New System.Drawing.Point(297, 510)
        Me.tb_contraindicaciones.Name = "tb_contraindicaciones"
        Me.tb_contraindicaciones.Size = New System.Drawing.Size(100, 20)
        Me.tb_contraindicaciones.TabIndex = 76
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(167, 513)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(97, 13)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "Contraindicaciones"
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(303, 401)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 74
        '
        'cb_departamento
        '
        Me.cb_departamento.FormattingEnabled = True
        Me.cb_departamento.Items.AddRange(New Object() {"Cardiologia", "Traumatologia", "Pediatria", "Oftalmologia", "Psicologia"})
        Me.cb_departamento.Location = New System.Drawing.Point(303, 363)
        Me.cb_departamento.Name = "cb_departamento"
        Me.cb_departamento.Size = New System.Drawing.Size(121, 21)
        Me.cb_departamento.TabIndex = 72
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(168, 407)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Número de Camilla"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(325, 590)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 23)
        Me.Button4.TabIndex = 70
        Me.Button4.Text = "Modicar Paciente"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(297, 469)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker3.TabIndex = 69
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Location = New System.Drawing.Point(297, 434)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker4.TabIndex = 68
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(168, 476)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(84, 13)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Fecha de Salida"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(168, 441)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 13)
        Me.Label19.TabIndex = 66
        Me.Label19.Text = "Fecha de Ingreso"
        '
        'tb_nombredepto
        '
        Me.tb_nombredepto.AutoSize = True
        Me.tb_nombredepto.Location = New System.Drawing.Point(168, 366)
        Me.tb_nombredepto.Name = "tb_nombredepto"
        Me.tb_nombredepto.Size = New System.Drawing.Size(114, 13)
        Me.tb_nombredepto.TabIndex = 64
        Me.tb_nombredepto.Text = "Nombre Departamento"
        '
        'btnAgregarPaciente
        '
        Me.btnAgregarPaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPaciente.Location = New System.Drawing.Point(136, 590)
        Me.btnAgregarPaciente.Name = "btnAgregarPaciente"
        Me.btnAgregarPaciente.Size = New System.Drawing.Size(127, 23)
        Me.btnAgregarPaciente.TabIndex = 63
        Me.btnAgregarPaciente.Text = "Agregar Paciente"
        Me.btnAgregarPaciente.UseVisualStyleBackColor = True
        '
        'tb_estadoc
        '
        Me.tb_estadoc.AutoCompleteCustomSource.AddRange(New String() {"Soltero", "Casado", "Divorciado", "Viudo"})
        Me.tb_estadoc.FormattingEnabled = True
        Me.tb_estadoc.Items.AddRange(New Object() {"Activo", "Inactivo"})
        Me.tb_estadoc.Location = New System.Drawing.Point(297, 214)
        Me.tb_estadoc.Name = "tb_estadoc"
        Me.tb_estadoc.Size = New System.Drawing.Size(121, 21)
        Me.tb_estadoc.TabIndex = 62
        '
        'tb_sexo
        '
        Me.tb_sexo.AutoCompleteCustomSource.AddRange(New String() {"Masculino", "Femenino"})
        Me.tb_sexo.FormattingEnabled = True
        Me.tb_sexo.Items.AddRange(New Object() {"Femenino", "Masculino", "Otro"})
        Me.tb_sexo.Location = New System.Drawing.Point(297, 184)
        Me.tb_sexo.Name = "tb_sexo"
        Me.tb_sexo.Size = New System.Drawing.Size(100, 21)
        Me.tb_sexo.TabIndex = 61
        '
        'tb_edad
        '
        Me.tb_edad.AutoCompleteCustomSource.AddRange(New String() {"2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99"})
        Me.tb_edad.FormattingEnabled = True
        Me.tb_edad.Items.AddRange(New Object() {"18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99"})
        Me.tb_edad.Location = New System.Drawing.Point(297, 253)
        Me.tb_edad.Name = "tb_edad"
        Me.tb_edad.Size = New System.Drawing.Size(121, 21)
        Me.tb_edad.TabIndex = 60
        '
        'tb_aseguradora
        '
        Me.tb_aseguradora.Location = New System.Drawing.Point(297, 332)
        Me.tb_aseguradora.Name = "tb_aseguradora"
        Me.tb_aseguradora.Size = New System.Drawing.Size(100, 20)
        Me.tb_aseguradora.TabIndex = 59
        '
        'tbb_direccion
        '
        Me.tbb_direccion.Location = New System.Drawing.Point(297, 293)
        Me.tbb_direccion.Name = "tbb_direccion"
        Me.tbb_direccion.Size = New System.Drawing.Size(100, 20)
        Me.tbb_direccion.TabIndex = 58
        '
        'tb_apellidos
        '
        Me.tb_apellidos.Location = New System.Drawing.Point(297, 150)
        Me.tb_apellidos.Name = "tb_apellidos"
        Me.tb_apellidos.Size = New System.Drawing.Size(100, 20)
        Me.tb_apellidos.TabIndex = 57
        '
        'tb_nombres
        '
        Me.tb_nombres.Location = New System.Drawing.Point(297, 108)
        Me.tb_nombres.Name = "tb_nombres"
        Me.tb_nombres.Size = New System.Drawing.Size(100, 20)
        Me.tb_nombres.TabIndex = 56
        '
        'tb_rut
        '
        Me.tb_rut.Location = New System.Drawing.Point(297, 70)
        Me.tb_rut.Name = "tb_rut"
        Me.tb_rut.Size = New System.Drawing.Size(100, 20)
        Me.tb_rut.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(164, 332)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "Aseguradora"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(164, 296)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 13)
        Me.Label23.TabIndex = 53
        Me.Label23.Text = "Dirección"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(163, 256)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Edad"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(161, 214)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(62, 13)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "Estado Civil"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(164, 184)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(31, 13)
        Me.Label26.TabIndex = 50
        Me.Label26.Text = "Sexo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(161, 78)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(24, 13)
        Me.Label27.TabIndex = 49
        Me.Label27.Text = "Rut"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(161, 150)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(49, 13)
        Me.Label28.TabIndex = 48
        Me.Label28.Text = "Apellidos"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(161, 111)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(52, 13)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "Nombres "
        '
        'ErrorGeneral
        '
        Me.ErrorGeneral.ContainerControl = Me
        '
        'tb_direccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(794, 650)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.tb_contraindicaciones)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.cb_departamento)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.DateTimePicker4)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.tb_nombredepto)
        Me.Controls.Add(Me.btnAgregarPaciente)
        Me.Controls.Add(Me.tb_estadoc)
        Me.Controls.Add(Me.tb_sexo)
        Me.Controls.Add(Me.tb_edad)
        Me.Controls.Add(Me.tb_aseguradora)
        Me.Controls.Add(Me.tbb_direccion)
        Me.Controls.Add(Me.tb_apellidos)
        Me.Controls.Add(Me.tb_nombres)
        Me.Controls.Add(Me.tb_rut)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label14)
        Me.DoubleBuffered = True
        Me.Name = "tb_direccion"
        CType(Me.ErrorGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents tb_contraindicaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents cb_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tb_nombredepto As System.Windows.Forms.Label
    Friend WithEvents btnAgregarPaciente As System.Windows.Forms.Button
    Friend WithEvents tb_estadoc As System.Windows.Forms.ComboBox
    Friend WithEvents tb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents tb_edad As System.Windows.Forms.ComboBox
    Friend WithEvents tb_aseguradora As System.Windows.Forms.TextBox
    Friend WithEvents tbb_direccion As System.Windows.Forms.TextBox
    Friend WithEvents tb_apellidos As System.Windows.Forms.TextBox
    Friend WithEvents tb_nombres As System.Windows.Forms.TextBox
    Friend WithEvents tb_rut As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents ErrorGeneral As System.Windows.Forms.ErrorProvider
End Class
