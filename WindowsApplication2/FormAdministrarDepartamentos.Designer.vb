<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrarDepartamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAdministrarDepartamentos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.b_salir = New System.Windows.Forms.Button()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.btnAgregardepto = New System.Windows.Forms.Button()
        Me.txtNombreDepto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DEPARTAMENTOS"
        '
        'b_salir
        '
        Me.b_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_salir.Location = New System.Drawing.Point(470, 310)
        Me.b_salir.Name = "b_salir"
        Me.b_salir.Size = New System.Drawing.Size(75, 23)
        Me.b_salir.TabIndex = 15
        Me.b_salir.Text = "Salir"
        Me.b_salir.UseVisualStyleBackColor = True
        '
        'bt_modificar
        '
        Me.bt_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_modificar.Location = New System.Drawing.Point(288, 310)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(155, 23)
        Me.bt_modificar.TabIndex = 14
        Me.bt_modificar.Text = "Modificar Departamento"
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'btnAgregardepto
        '
        Me.btnAgregardepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregardepto.Location = New System.Drawing.Point(117, 310)
        Me.btnAgregardepto.Name = "btnAgregardepto"
        Me.btnAgregardepto.Size = New System.Drawing.Size(139, 23)
        Me.btnAgregardepto.TabIndex = 13
        Me.btnAgregardepto.Text = "Agregar Departamento"
        Me.btnAgregardepto.UseVisualStyleBackColor = True
        '
        'txtNombreDepto
        '
        Me.txtNombreDepto.Location = New System.Drawing.Point(343, 179)
        Me.txtNombreDepto.Name = "txtNombreDepto"
        Me.txtNombreDepto.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreDepto.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre de Departamento"
        '
        'FormAdministrarDepartamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(663, 458)
        Me.Controls.Add(Me.b_salir)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.btnAgregardepto)
        Me.Controls.Add(Me.txtNombreDepto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "FormAdministrarDepartamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents b_salir As System.Windows.Forms.Button
    Friend WithEvents bt_modificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregardepto As System.Windows.Forms.Button
    Friend WithEvents txtNombreDepto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
