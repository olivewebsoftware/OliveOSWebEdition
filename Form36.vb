Option Strict On
Public Class Form36

    Private Sub Form36_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Me.Close()
            Form1.Timer2.Stop()
            Form7.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
        End If
        If e.KeyCode = Keys.F2 Then
            Form2.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Me.Close()
        End If
        If e.KeyCode = Keys.F3 Then
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Label2.Hide()
            Form18.Show()
        End If
        If e.KeyCode = Keys.F5 Then
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
        "Username", "Audit")
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Me.Close()
            Form8.Show()
            Form1.Timer2.Stop()
        End If
        If e.KeyCode = Keys.F6 Then
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Cursor.Show()
            Form18.Show()
            Form18.TabControl1.SelectTab(6)
        End If
    End Sub

    Private Sub Form36_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
        Form1.Timer2.Stop()
        Form7.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form2.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Form18.Show()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Username", "Audit")
        Me.Close()
        Form8.Show()
        Form1.Timer2.Stop()
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Form42.Show()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Form8.Show()
        Form8.wb.Navigate("about:blank")
        Form8.wb2.Navigate("about:blank")
        Form8.wb3.Navigate("about:blank")
        Form8.wb4.Navigate("about:blank")
        Form8.wb5.Navigate("about:blank")
        Form8.web.Navigate("about:blank")
    End Sub
End Class