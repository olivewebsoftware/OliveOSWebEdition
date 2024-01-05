Public Class Form3
    Private a As String
    Private b As String
    Dim c As Integer = 0
    Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim j As String = ""
        j = My.Resources.textedit
        WebBrowser1.DocumentText = j
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        a = WebBrowser1.Document.GetElementById("sr").InnerText
        If a = "1" Then
            doSave()
        End If
    End Sub
    Private Sub doSave()
        If c = 0 Then
            c = 1
            b = WebBrowser1.Document.GetElementById("main-edit").InnerText
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                SaveFileDialog1.Title = "Save this file..."
                System.IO.File.WriteAllText(SaveFileDialog1.FileName, b)
                Form4.Show()
                Form4.Label1.Text = "Saved sucessfully."
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If WebBrowser1.ReadyState = WebBrowserReadyState.Complete Then
            Timer2.Start()
        End If
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

    Private Sub ViewPageSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPageSourceToolStripMenuItem.Click
        For Each Tag As HtmlElement In WebBrowser1.Document.GetElementsByTagName("textarea") 'Iterate through all <input> tags.
            If Tag.GetAttribute("value").ToLower() = "" Then 'Check if the 'value' attribute is set to 'football'.
                Tag.SetAttribute("value", WebBrowser1.DocumentText) 'Set the attribute to 'basketball' instead.
                Exit For 'Exit the loop.
            End If
        Next
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub FowardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FowardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub


    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class