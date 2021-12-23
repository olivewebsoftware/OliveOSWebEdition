Public Class Form57

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Process.Start(Form26.ListBox1.SelectedItem)
        Me.Close()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Process.Start(Form26.ListBox1.SelectedItem)
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Try
            My.Computer.FileSystem.DeleteFile(Form26.ListBox1.SelectedItem)
            Form4.Show()
            Form4.Label1.Text = "File deleted."
            Me.Close()
        Catch ex As Exception
            Form4.Show()
            Form4.Label1.Text = "You do not have permission" & vbNewLine & "to delete this file. This is a" & vbNewLine & "protected operating system file."
        End Try
    End Sub

    Private Sub Form57_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mp As Point = MousePosition
        Me.Location = mp
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        rtf.Text = Form26.ListBox1.SelectedItem
    End Sub

    Private Sub Form57_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LostFocus
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Process.Start(Form26.ListBox1.SelectedItem)
        Me.Close()
    End Sub
End Class