Public NotInheritable Class AboutBox1

    Private Sub Btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnok.Click

        Form1.Close()
        Me.Close()

    End Sub

    Private Sub AboutBox1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Form1.Close()

    End Sub

End Class
