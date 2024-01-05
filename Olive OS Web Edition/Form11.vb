Public Class Form11
    Dim r As Integer = 0
    Private f As String
    Private g As String
    Dim bad As Integer = 0
    Dim mouse_move As System.Drawing.Point
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form11_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim j As String = ""
        j = My.Resources.photo
        WebBrowser1.DocumentText = j
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Timer2.Start()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If r = 0 Then
            Dim o = WebBrowser1.Document.GetElementById("q").InnerText
            If o = "1" Then
                r = 1
                funct()
            End If
        End If
    End Sub
    Private Sub funct()
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each Tag As HtmlElement In WebBrowser1.Document.GetElementsByTagName("p") 'Iterate through all <input> tags.
                If Tag.GetAttribute("innerHTML").ToLower() = "---" Then 'Check if the 'value' attribute is set to 'football'.
                    Tag.SetAttribute("innerHTML", OpenFileDialog1.FileName) 'Set the attribute to 'basketball' instead.
                    Exit For 'Exit the loop.
                End If
            Next
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        f = WebBrowser1.Document.GetElementById("bruh").InnerText
        If f = "1" Then
            If bad = 0 Then
                bad = 1
                g = WebBrowser1.Document.GetElementById("pathname").InnerText
                Process.Start(g)
            End If
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

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ViewPageSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPageSourceToolStripMenuItem.Click
        MsgBox(WebBrowser1.DocumentText)
    End Sub
End Class