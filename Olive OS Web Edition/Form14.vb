Public Class Form14
    Dim mouse_move As System.Drawing.Point
    Dim u As Integer = 0
    Dim path As String = ""
    Private a As String
    Private b As String
    Private c As String
    Private f1 As String
    Private f2 As String
    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim j As String = ""
        j = My.Resources.music
        WebBrowser1.DocumentText = j
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            AxWindowsMediaPlayer1.URL = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
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

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        a = WebBrowser1.Document.GetElementById("pr").InnerText
        b = WebBrowser1.Document.GetElementById("pa").InnerText
        c = WebBrowser1.Document.GetElementById("st").InnerText
        f1 = WebBrowser1.Document.GetElementById("f").InnerText
        f2 = WebBrowser1.Document.GetElementById("r").InnerText
        If a = "1" Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
        If b = "1" Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        End If
        If c = "1" Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
        If f1 = "1" Then
            AxWindowsMediaPlayer1.Ctlcontrols.fastForward()
        End If
        If f2 = "1" Then
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem.Click
        MsgBox(WebBrowser1.DocumentText)
    End Sub
End Class