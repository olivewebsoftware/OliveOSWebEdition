Option Strict On
Public Class Form42

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Form42_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        End
        End
        End
        End
        End
        End
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Select Case MsgBox("Are you sure you want to reset? This cannot be undone.", MsgBoxStyle.YesNo, "Confirm Reset.")
            Case MsgBoxResult.Yes
                Me.Close()
                Form8.Close()
                Form29.Show()
        End Select
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form18.Show()
        Form18.TabControl1.SelectTab(6)
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Me.Close()
        Form36.WindowState = FormWindowState.Minimized
        Form39.Show()
    End Sub
End Class