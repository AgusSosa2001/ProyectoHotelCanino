Public Class FrmVentana2
	Private Const V As String = ""

	Private Sub FrmIngreseUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
		Me.Hide()
		FrmVentana1.Show()
	End Sub

	Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
		End
	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TexUs.TextChanged

	End Sub

	Private Sub BtnContinuar_Click(sender As Object, e As EventArgs) Handles BtnContinuar.Click
		If TexUs.Text = "Gerente" AndAlso TexCon.Text = "123Gerente" Then
			Me.Hide()
			FrmGerente.Show()
			If TexUs.Text <> "Gerente" Then
				MsgBox("Usuario Incorrecto")

			End If

			If TexCon.Text <> "123Gerente" Then
				MsgBox("Contraseña Incorrecta")
			End If
		End If


		If TexUs.Text = "Oficinista" AndAlso TexCon.Text = "123Oficinista" Then
			Me.Hide()
			FrmVentana4.Show()
			If TexUs.Text <> "Oficinista" Then
				MsgBox("Usuario Incorrecto")
			End If
			If TexCon.Text <> "123Oficinista" Then
				MsgBox("Contraseña Incorrecta")
			End If
		End If

		If TexUs.Text = "Recepcionista" AndAlso TexCon.Text = "123Recepcionista" Then
			Me.Hide()
			FrmVentana5.Show()
			If TexUs.Text <> "Recepcionista" Then
				MsgBox("Usuario Incorrecto")
			End If
			If TexCon.Text <> "123Recepcionista" Then
				MsgBox("Contraseña Incorrecta")
			End If
		End If





	End Sub

	Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
		TexUs.Text = ""
		TexCon.Text = ""
	End Sub
End Class