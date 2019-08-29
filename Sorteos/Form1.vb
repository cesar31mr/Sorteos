Public Class Form1
    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Try
            If IsNumeric(txtInferior.Text) And IsNumeric(txtSuperior.Text) Then
                Dim nmbAleatorio As New Random()
                Dim inferior As Integer = CInt(txtInferior.Text)
                Dim Superior As Integer = CInt(txtSuperior.Text)
                Dim historico As String = String.Empty

                historico = txtHistorial.Text
                txtResultado.Text = Convert.ToString(nmbAleatorio.Next(inferior, Superior + 1))

                If txtHistorial.MaxLength < (txtResultado.Text.Length + historico.Length) Then
                    txtHistorial.Text = txtResultado.Text
                Else
                    txtHistorial.Text = String.Format("{0}{1}{2}", txtResultado.Text, vbCrLf, txtHistorial.Text)
                End If

                lblResultados.Text = String.Format("Resultados: {0}", txtHistorial.Text.Split(vbCrLf).Length - 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
