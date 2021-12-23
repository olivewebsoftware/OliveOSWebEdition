Imports System.IO
Public Class Form26
    Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        Try
            Dim user = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "User", Nothing)
            For Each File As String In My.Computer.FileSystem.GetFiles("C:\Users\" & user & "\Downloads")
                ListBox1.Items.Add("C:\Users\" & user & "\Downloads\" & My.Computer.FileSystem.GetFileInfo(File).Name)
            Next
        Catch ex As Exception
            Form43.Show()
            Form43.Label2.Text = ex.Message
        End Try

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        Dim mouse_move As New System.Drawing.Point
        mouse_move = New Point(-e.X, e.Y)
    End Sub

    Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "User", TextBox1.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
    "FileSet", "yes")
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Form26_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
       
        Dim f = My.Computer.Registry.GetValue(
   "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "FileSet", Nothing)
        If f = "" Then
            TabControl1.SelectTab(2)
            Label11.Show()
        Else
            'nothing
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Try
            Dim user = My.Computer.Registry.GetValue(
 "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "User", Nothing)
            For Each File As String In My.Computer.FileSystem.GetFiles("C:\Users\" & user & "\OneDrive\Documents")
                ListBox1.Items.Add("C:\Users\" & user & "\OneDrive\Documents\" & My.Computer.FileSystem.GetFileInfo(File).Name)
            Next
        Catch ex As Exception
            Form43.Show()
            Form43.Label2.Text = ex.Message
        End Try
      
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        Try
            Dim user = My.Computer.Registry.GetValue(
  "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "User", Nothing)
            For Each File As String In My.Computer.FileSystem.GetFiles("C:\Users\" & user & "\Music")
                ListBox1.Items.Add("C:\Users\" & user & "\Music\" & My.Computer.FileSystem.GetFileInfo(File).Name)
            Next
        Catch ex As Exception
            Form43.Show()
            Form43.Label2.Text = ex.Message
        End Try
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        Try
            Dim user = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition", "User", Nothing)
            For Each File As String In My.Computer.FileSystem.GetFiles("C:\Users\" & user & "\OneDrive\Pictures")
                ListBox1.Items.Add("C:\Users\" & user & "\OneDrive\Picture\" & My.Computer.FileSystem.GetFileInfo(File).Name)
            Next
        Catch ex As Exception
            Form43.Show()
            Form43.Label2.Text = ex.Message
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()
        Try
            Dim user = My.Computer.Registry.GetValue(
  "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "User", Nothing)
            For Each File As String In My.Computer.FileSystem.GetFiles("C:\Users\" & user & "\Videos")
                ListBox1.Items.Add("C:\Users\" & user & "\Videos\" & My.Computer.FileSystem.GetFileInfo(File).Name)
            Next
        Catch ex As Exception
            Form43.Show()
            Form43.Label2.Text = ex.Message
        End Try
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Form57.Show()
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        Form57.Show()
        Form57.Label5.Text = "1"
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ListBox1.Items.Clear()
        For Each File As String In My.Computer.FileSystem.GetFiles("C:\Program Files\Olive OS Web Edition")
            ListBox1.Items.Add("C:\Program Files\Olive OS Web Edition\" & My.Computer.FileSystem.GetFileInfo(File).Name)
        Next
    End Sub
End Class