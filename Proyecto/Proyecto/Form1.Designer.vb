<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentana1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVentana1))
		Me.LblBien = New System.Windows.Forms.Label()
		Me.BtnIngresar = New System.Windows.Forms.Button()
		Me.BtnSalir = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'LblBien
		'
		Me.LblBien.AutoSize = True
		Me.LblBien.BackColor = System.Drawing.Color.Transparent
		Me.LblBien.Font = New System.Drawing.Font("Arial", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblBien.Location = New System.Drawing.Point(302, 50)
		Me.LblBien.Name = "LblBien"
		Me.LblBien.Size = New System.Drawing.Size(172, 34)
		Me.LblBien.TabIndex = 0
		Me.LblBien.Text = "Bienvenido"
		'
		'BtnIngresar
		'
		Me.BtnIngresar.BackColor = System.Drawing.Color.White
		Me.BtnIngresar.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnIngresar.Location = New System.Drawing.Point(298, 228)
		Me.BtnIngresar.Name = "BtnIngresar"
		Me.BtnIngresar.Size = New System.Drawing.Size(114, 44)
		Me.BtnIngresar.TabIndex = 1
		Me.BtnIngresar.Text = "Ingresar"
		Me.BtnIngresar.UseVisualStyleBackColor = False
		'
		'BtnSalir
		'
		Me.BtnSalir.BackColor = System.Drawing.Color.White
		Me.BtnSalir.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.BtnSalir.Location = New System.Drawing.Point(429, 228)
		Me.BtnSalir.Name = "BtnSalir"
		Me.BtnSalir.Size = New System.Drawing.Size(114, 44)
		Me.BtnSalir.TabIndex = 2
		Me.BtnSalir.Text = "Salir"
		Me.BtnSalir.UseVisualStyleBackColor = False
		'
		'FrmVentana1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(794, 411)
		Me.Controls.Add(Me.BtnSalir)
		Me.Controls.Add(Me.BtnIngresar)
		Me.Controls.Add(Me.LblBien)
		Me.MinimizeBox = False
		Me.Name = "FrmVentana1"
		Me.Text = "Ventana1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LblBien As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents BtnSalir As Button
End Class
