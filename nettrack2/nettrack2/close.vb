Public Class close
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Form1.Close1.Visible = False
        Form1.Close1.SendToBack()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close1.Visible = False
        Form1.Close1.SendToBack()

    End Sub
End Class
