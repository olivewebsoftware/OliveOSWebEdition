Public Class Form19

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim setup = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Password", Nothing)
            If TextBox1.Text = setup Then
                Me.Close()
                Form18.Panel9.Show()
            Else
                Form4.Show()
                Form4.Label1.Text = "Incorrect password."
                TextBox1.Clear()
            End If
        End If
    End Sub

    Private Sub TextBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseDown

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form19_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
    End Sub
End Class