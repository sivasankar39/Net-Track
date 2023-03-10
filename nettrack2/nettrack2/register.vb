Public Class register
    Dim key1 As String = "0123-4567-8901-2345-6789"
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        If txtEmail.Text = Nothing And MtxtKey.Text = Nothing Then
            MsgBox("No Email/Key Found! Please fill all the provided spaces before continue", MsgBoxStyle.Information, "Error")
        Else
            If txtEmail.Text = Nothing Then
                MsgBox("No Email Found!", MsgBoxStyle.Critical, "Error")
            Else
                If MtxtKey.Text = Nothing Then
                    MsgBox("No Activation Key Found!", MsgBoxStyle.Critical, "Error")
                Else
                    If MtxtKey.Text = key1 Then
                        My.Settings.email = txtEmail.Text
                        My.Settings.key = MtxtKey.Text
                        My.Settings.Save()
                        Form1.lblHeading.Text = "Net-Track - Pre-activated"
                        Form1.btnPremium.Visible = False
                        Form1.lblRegister.Visible = False
                        Form1.lblstatus.Location = New Point(31, 81)
                        Form1.lblprotection.Location = New Point(138, 81)
                        MsgBox("Activation Key Accepted! Thank You for Purchasing our Software! Enjoy", MsgBoxStyle.Information, "Activated")
                        Me.Hide()
                        Form1.Show()
                    Else
                        MsgBox("Invalid Activation Key Provided! Please Try Again!", MsgBoxStyle.Critical, "Error")

                    End If
                End If
            End If
        End If
    End Sub
End Class