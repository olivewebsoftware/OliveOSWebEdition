Public Class Form12
    Dim mouse_move As System.Drawing.Point
    Private a As String
    Private b As String
    Private c As String
    Private d As String
    Private r As String
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Timer1.Start()
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim j As String = ""
        j = My.Resources.wallpaper
        WebBrowser1.DocumentText = j
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

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        a = WebBrowser1.Document.GetElementById("a").InnerText
        b = WebBrowser1.Document.GetElementById("b").InnerText
        c = WebBrowser1.Document.GetElementById("c").InnerText
        d = WebBrowser1.Document.GetElementById("d").InnerText
        r = WebBrowser1.Document.GetElementById("e").InnerText
        If a = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "Wallpaper", "def")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PackEnabled", "no")
            Form8.BackgroundImage = My.Resources.def
            Form4.Show()
            Form4.Label1.Text = "Set."
            Me.Close()
        End If
        If b = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "Wallpaper", "rockwater")
            Form8.BackgroundImage = My.Resources.rockwater
            Form4.Show()
            Form4.Label1.Text = "Set."
            Me.Close()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PackEnabled", "no")
        End If
        If c = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "Wallpaper", "cliff")
            Form8.BackgroundImage = My.Resources.cliff
            Form4.Show()
            Form4.Label1.Text = "Set."
            Me.Close()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PackEnabled", "no")
        End If
        If d = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "Wallpaper", "def2")
            Form8.BackgroundImage = My.Resources.webdefault
            Form4.Show()
            Form4.Label1.Text = "Set."
            Me.Close()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PackEnabled", "no")
        End If
        If r = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
           "Wallpaper", "game")
            Form8.BackgroundImage = My.Resources.gameon
            Form4.Show()
            Form4.Label1.Text = "Set."
            Me.Close()
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "PackEnabled", "no")
        End If
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem.Click
        MsgBox(WebBrowser1.DocumentText)
    End Sub
End Class