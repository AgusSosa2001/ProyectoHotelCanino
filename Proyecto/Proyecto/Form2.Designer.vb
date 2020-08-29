<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentana2
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
		Me.LblUsu = New System.Windows.Forms.Label()
		Me.TexCon = New System.Windows.Forms.TextBox()
		Me.LblContra = New System.Windows.Forms.Label()
		Me.TexUs = New System.Windows.Forms.TextBox()
		Me.LblTitulo = New System.Windows.Forms.Label()
		Me.BtnContinuar = New System.Windows.Forms.Button()
		Me.BtnSalir = New System.Windows.Forms.Button()
		Me.BtnVolver = New System.Windows.Forms.Button()
		Me.BtnLimpiar = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'LblUsu
		'
		Me.LblUsu.AutoSize = True
		Me.LblUsu.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblUsu.Location = New System.Drawing.Point(39, 180)
		Me.LblUsu.Name = "LblUsu"
		Me.LblUsu.Size = New System.Drawing.Size(89, 22)
		Me.LblUsu.TabIndex = 0
		Me.LblUsu.Text = "Usuario:"
		'
		'TexCon
		'
		Me.TexCon.Location = New System.Drawing.Point(190, 262)
		Me.TexCon.Name = "TexCon"
		Me.TexCon.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TexCon.Size = New System.Drawing.Size(135, 20)
		Me.TexCon.TabIndex = 1
		'
		'LblContra
		'
		Me.LblContra.AutoSize = True
		Me.LblContra.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblContra.Location = New System.Drawing.Point(39, 262)
		Me.LblContra.Name = "LblContra"
		Me.LblContra.Size = New System.Drawing.Size(125, 22)
		Me.LblContra.TabIndex = 2
		Me.LblContra.Text = "Contraseña:"
		'
		'TexUs
		'
		Me.TexUs.Location = New System.Drawing.Point(171, 180)
		Me.TexUs.Name = "TexUs"
		Me.TexUs.Size = New System.Drawing.Size(100, 20)
		Me.TexUs.TabIndex = 3
		'
		'LblTitulo
		'
		Me.LblTitulo.AutoSize = True
		Me.LblTitulo.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblTitulo.Location = New System.Drawing.Point(198, 32)
		Me.LblTitulo.Name = "LblTitulo"
		Me.LblTitulo.Size = New System.Drawing.Size(380, 37)
		Me.LblTitulo.TabIndex = 4
		Me.LblTitulo.Text = "Ingresar con mi usuario"
		'
		'BtnContinuar
		'
		Me.BtnContinuar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnContinuar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.BtnContinuar.Location = New System.Drawing.Point(73, 333)
		Me.BtnContinuar.Name = "BtnContinuar"
		Me.BtnContinuar.Size = New System.Drawing.Size(137, 49)
		Me.BtnContinuar.TabIndex = 5
		Me.BtnContinuar.Text = "Continuar"
		Me.BtnContinuar.UseVisualStyleBackColor = True
		'
		'BtnSalir
		'
		Me.BtnSalir.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.BtnSalir.Location = New System.Drawing.Point(625, 333)
		Me.BtnSalir.Name = "BtnSalir"
		Me.BtnSalir.Size = New System.Drawing.Size(137, 49)
		Me.BtnSalir.TabIndex = 6
		Me.BtnSalir.Text = "Salir"
		Me.BtnSalir.UseVisualStyleBackColor = True
		'
		'BtnVolver
		'
		Me.BtnVolver.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.BtnVolver.Location = New System.Drawing.Point(432, 333)
		Me.BtnVolver.Name = "BtnVolver"
		Me.BtnVolver.Size = New System.Drawing.Size(137, 49)
		Me.BtnVolver.TabIndex = 7
		Me.BtnVolver.Text = "Volver"
		Me.BtnVolver.UseVisualStyleBackColor = True
		'
		'BtnLimpiar
		'
		Me.BtnLimpiar.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.BtnLimpiar.Location = New System.Drawing.Point(258, 333)
		Me.BtnLimpiar.Name = "BtnLimpiar"
		Me.BtnLimpiar.Size = New System.Drawing.Size(137, 49)
		Me.BtnLimpiar.TabIndex = 8
		Me.BtnLimpiar.Text = "Limpiar"
		Me.BtnLimpiar.UseVisualStyleBackColor = True
		'
		'FrmVentana2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.BtnLimpiar)
		Me.Controls.Add(Me.BtnVolver)
		Me.Controls.Add(Me.BtnSalir)
		Me.Controls.Add(Me.BtnContinuar)
		Me.Controls.Add(Me.LblTitulo)
		Me.Controls.Add(Me.TexUs)
		Me.Controls.Add(Me.LblContra)
		Me.Controls.Add(Me.TexCon)
		Me.Controls.Add(Me.LblUsu)
		Me.Name = "FrmVentana2"
		Me.Text = "Ventana2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LblUsu As Label
    Friend WithEvents TexCon As TextBox
    Friend WithEvents LblContra As Label
    Friend WithEvents TexUs As TextBox
    Friend WithEvents LblTitulo As Label
    Friend WithEvents BtnContinuar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnVolver As Button
	Friend WithEvents BtnLimpiar As Button
End Class
