Public Class Form27

    Private Sub Form27_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Select()
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form4.Show()
        Form4.Label1.Text = My.Resources.notif
        Me.Close()
        Form2.Close()
        Form7.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
     "User", TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
    "FileSet", "yes")
        Me.Close()
        Form30.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox(My.Resources.tips)
    End Sub
End Class