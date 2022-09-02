Public Class Form1
    Dim sec As Integer = 0
    Dim minute, hour, percent, counter As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lbl.Text = Date.Now

        If Me.WindowState = FormWindowState.Minimized Then
            Me.Hide()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        sec = sec + 1
        counter = counter + 1

        If lblsec.Text = "60" Then
            sec = 0
            minute = minute + 1
        End If

        If Lblmin.Text = "60" Then
            hour = hour + 1
            minute = 0
        End If

        percent = (counter / (list.Text * 60)) * 100

        Me.lblsec.Text = Format(sec)
        Me.Lblmin.Text = Format(minute)
        Me.lblhour.Text = Format(hour)
        Me.lblpercent.Text = Format(percent) & " %"

        Try
            Progbar.Value = percent
        Catch

        End Try

        If (list.Text * 60) = counter Then
            lbl3.Text = "Œ·«’ Ì« " & txtnam.Text
            lbl3.Visible = True
            Me.Activate()
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)
        End If

        Notify.Text = "«·Êﬁ  ‘€«·" & vbCrLf & "«·Êﬁ  «··Ï ›«  : " & minute & " œﬁÌﬁ… , " & hour & " ”«⁄…"

    End Sub

    Private Sub start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles start.Click
        If list.Text = "" Then
            MessageBox.Show("      . ≈Œ «— «·Êﬁ  ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If list.Text = 0 Or list.Text < 0.1 Then
                    MessageBox.Show("      .  «·Êﬁ  „ﬂ Ê» €·ÿ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Try
                        Dim x As Decimal
                        x = list.Text
                    Catch
                        MessageBox.Show("      .  «·Êﬁ  „ﬂ Ê» €·ÿ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    If txtnam.Text = "" Then
                        MessageBox.Show("      . ≈ﬂ » ≈”„ﬂ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        txtnam.Enabled = False
                        Me.Timer2.Enabled = True
                        Me.start.Text = "≈»œ√"
                        Me.list.Enabled = False
                        ToolStripMenuItem2.Enabled = True
                        ToolStripMenuItem3.Enabled = False
                        ToolStripMenuItem3.Text = "≈»œ√"
                        wait.Enabled = True
                        reset.Enabled = True
                        start.Enabled = False
                        ToolStripMenuItem4.Enabled = True
                        ToolStripMenuItem5.Enabled = False
                        If txtnam.Items.Contains(txtnam.Text) = False Then
                            txtnam.Items.Add(txtnam.Text)
                        End If
                    End If
                End If
            Catch
                MessageBox.Show("      .  «·Êﬁ  „ﬂ Ê» €·ÿ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub wait_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wait.Click
        wait.Enabled = False
        start.Enabled = True
        ToolStripMenuItem3.Enabled = True
        ToolStripMenuItem2.Enabled = False
        ToolStripMenuItem3.Text = "ﬂ„·"
        Me.Timer2.Enabled = False
        Me.start.Text = "ﬂ„·"
        Notify.Text = "«·Êﬁ  Ê«ﬁ›" & vbCrLf & "«·Êﬁ  «··Ï ›«  : " & minute & " œﬁÌﬁ… , " & hour & " ”«⁄…"
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        txtnam.Enabled = True
        Me.List.Enabled = True
        Me.Timer2.Enabled = False
        Me.lblsec.Text = "0"
        Me.Lblmin.Text = "0"
        Me.lblhour.Text = "0"
        Me.start.Text = "≈»œ√"
        lbl3.Visible = False
        lbl3.Text = ""
        Me.lblpercent.Text = ""
        counter = 0
        sec = 0
        minute = 0
        hour = 0
        percent = 0
        Progbar.Value = 0
        Notify.Text = "Timer"
        ToolStripMenuItem3.Text = "≈»œ√"
        ToolStripMenuItem3.Enabled = True
        ToolStripMenuItem2.Enabled = False
        wait.Enabled = False
        reset.Enabled = False
        start.Enabled = True
        ToolStripMenuItem4.Enabled = False
        ToolStripMenuItem5.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As DialogResult
        x = MessageBox.Show("                           ⁄«Ì“  Œ—Ãø", "                       Œ—ÊÃ ", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If x = Windows.Forms.DialogResult.Yes Then
            Timer2.Enabled = False
            AboutBox1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Notify.MouseDoubleClick
        Me.Show()
        Me.Activate()
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Dim x As DialogResult
        x = MessageBox.Show("                           ⁄«Ì“  Œ—Ãø", "                       Œ—ÊÃ ", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If x = Windows.Forms.DialogResult.Yes Then
            Timer2.Enabled = False
            AboutBox1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If list.Text = "" Then
            MessageBox.Show("      . ≈Œ «— «·Êﬁ  ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                If list.Text = 0 Or list.Text < 0.1 Then
                    MessageBox.Show("      .  «·Êﬁ  „ﬂ Ê» €·ÿ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Try
                        Dim x As Decimal
                        x = list.Text
                    Catch
                        MessageBox.Show("      .  «·Êﬁ  „ﬂ Ê» €·ÿ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                Else
                    If txtnam.Text = "" Then
                        MessageBox.Show("      . ≈ﬂ » ≈”„ﬂ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        txtnam.Enabled = False
                        Me.Timer2.Enabled = True
                        Me.start.Text = "≈»œ√"
                        Me.list.Enabled = False
                        ToolStripMenuItem2.Enabled = True
                        ToolStripMenuItem3.Enabled = False
                        ToolStripMenuItem3.Text = "≈»œ√"
                        wait.Enabled = True
                        reset.Enabled = True
                        start.Enabled = False
                        ToolStripMenuItem4.Enabled = True
                        ToolStripMenuItem5.Enabled = False
                        If txtnam.Items.Contains(txtnam.Text) = False Then
                            txtnam.Items.Add(txtnam.Text)
                        End If
                    End If
                End If
            Catch
                MessageBox.Show("      .  «·Êﬁ  „ﬂ Ê» €·ÿ ", "                       „‘ﬂ·… ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        wait.Enabled = False
        start.Enabled = True
        ToolStripMenuItem3.Enabled = True
        ToolStripMenuItem2.Enabled = False
        ToolStripMenuItem3.Text = "ﬂ„·"
        Me.Timer2.Enabled = False
        Me.start.Text = "ﬂ„·"
        Notify.Text = "«·Êﬁ  Ê«ﬁ›" & vbCrLf & "«·Êﬁ  «··Ï ›«  : " & minute & " œﬁÌﬁ… , " & hour & " ”«⁄…"
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        txtnam.Enabled = True
        Me.List.Enabled = True
        Me.Timer2.Enabled = False
        Me.lblsec.Text = "0"
        Me.Lblmin.Text = "0"
        Me.lblhour.Text = "0"
        Me.start.Text = "≈»œ√"
        lbl3.Visible = False
        lbl3.Text = ""
        Me.lblpercent.Text = ""
        counter = 0
        sec = 0
        minute = 0
        hour = 0
        percent = 0
        Progbar.Value = 0
        Notify.Text = "Timer"
        ToolStripMenuItem3.Text = "≈»œ√"
        ToolStripMenuItem3.Enabled = True
        ToolStripMenuItem2.Enabled = False
        wait.Enabled = False
        reset.Enabled = False
        start.Enabled = True
        ToolStripMenuItem4.Enabled = False
        ToolStripMenuItem5.Enabled = True
    End Sub

    Private Sub txtnam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnam.TextChanged
        TextBox1.Text = txtnam.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        txtnam.Text = TextBox1.Text
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.TextChanged
        list.Text = ToolStripTextBox1.Text
    End Sub

    Private Sub list_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list.TextChanged
        ToolStripTextBox1.Text = list.Text
    End Sub
End Class
