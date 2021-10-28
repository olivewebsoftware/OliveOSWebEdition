Public Class Form16
    Dim tabs As Integer = 0
    Dim wb1 As New WebBrowser
    Dim wb2 As New WebBrowser
    Dim wb3 As New WebBrowser
    Dim wb4 As New WebBrowser
    Dim wb5 As New WebBrowser
    Dim tp1 As New TabPage
    Dim tp2 As New TabPage
    Dim tp3 As New TabPage
    Dim tp4 As New TabPage
    Dim tp5 As New TabPage
    Dim browser As String = ""
    Dim r As Integer = 0
    Dim wb11 As Integer = 0
    Dim wb22 As Integer = 0
    Dim wb33 As Integer = 0
    Dim wb44 As Integer = 0
    Dim wb55 As Integer = 0
    Dim mouse_move As System.Drawing.Point
    Private Sub Form16_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        webbr.ScriptErrorsSuppressed = True
        wb1.ScriptErrorsSuppressed = True
        wb2.ScriptErrorsSuppressed = True
        wb3.ScriptErrorsSuppressed = True
        wb4.ScriptErrorsSuppressed = True
        wb5.ScriptErrorsSuppressed = True
        wb1.IsWebBrowserContextMenuEnabled = False
        wb2.IsWebBrowserContextMenuEnabled = False
        wb3.IsWebBrowserContextMenuEnabled = False
        wb4.IsWebBrowserContextMenuEnabled = False
        wb5.IsWebBrowserContextMenuEnabled = False
        wb1.ContextMenuStrip = ContextMenuStrip2
        wb2.ContextMenuStrip = ContextMenuStrip3
        wb3.ContextMenuStrip = ContextMenuStrip4
        wb4.ContextMenuStrip = ContextMenuStrip5
        wb5.ContextMenuStrip = ContextMenuStrip6
        Dim j As String = ""
        j = My.Resources.sug
        webbr.DocumentText = j
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Browser", Nothing)
        browser = setup
        Dim sec = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Security", Nothing)
        If sec = "" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "Security", "yes")
        End If
        If sec = "yes" Then
            r = 1
        End If
        If sec = "no" Then
            r = 0
        End If
        If r = 1 Then
            Timer6.Start()
        Else
            'nothing
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            doSearch()
        End If
    End Sub
    Private Sub doSearch()
        ListBox1.Items.Add(TextBox1.Text)
        webbr.Navigate("https://www.bing.com/search?q=" & TextBox1.Text & "&form=QBLH&sp=-1&pq=" & TextBox1.Text & "&sc=8-4&qs=n&sk=&cvid=B01C25CA0AE840E6A0CA4522B80BF41D")
        TextBox1.Clear()
        TextBox1.Text = "Enter a URL or Search"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        tabs += 1
        If tabs = 5 Then
            Form4.Show()
            Form4.Label1.Text = "TabOverload Exception"
            Exit Sub
        End If
        If tabs = 1 Then
            wb11 = 1
            wb1.Navigate(browser)
            wb1.Width = 1567
            wb1.Height = 517
            tp1.Controls.Add(wb1)
            tp1.ContextMenuStrip = ContextMenuStrip2
            TabControl1.TabPages.Add(tp1)
            tp1.Text = "Tab"
            Timer1.Start()
        End If
        If tabs = 2 Then
            wb22 = 1
            wb2.Width = 1567
            wb2.Height = 517
            tp2.Controls.Add(wb2)
            wb2.Navigate(browser)
            tp2.ContextMenuStrip = ContextMenuStrip3
            TabControl1.TabPages.Add(tp2)
            tp2.Text = "Tab"
            Timer2.Start()
        End If
        If tabs = 3 Then
            wb33 = 1
            wb3.Navigate(browser)
            wb3.Width = 1567
            wb3.Height = 517
            tp3.Controls.Add(wb3)
            tp3.ContextMenuStrip = ContextMenuStrip4
            TabControl1.TabPages.Add(tp3)
            tp3.Text = "Tab"
            Timer3.Start()
        End If
        If tabs = 4 Then
            wb44 = 1
            wb4.Navigate(browser)
            wb4.Width = 1567
            wb4.Height = 517
            tp4.Controls.Add(wb4)
            tp4.ContextMenuStrip = ContextMenuStrip5
            TabControl1.TabPages.Add(tp4)
            tp4.Text = "Tab"
            Timer4.Start()
        End If
        If tabs = 5 Then
            wb55 = 1
            wb5.Navigate(browser)
            wb5.Width = 1567
            wb5.Height = 517
            tp5.Controls.Add(wb5)
            tp5.ContextMenuStrip = ContextMenuStrip6
            TabControl1.TabPages.Add(tp5)
            tp5.Text = "Tab"
            Timer5.Start()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TabControl1.SelectedTab Is tp1 Then
            wb11 = 0
            Timer1.Stop()
            TabControl1.SelectedTab.Dispose()
        End If
        If TabControl1.SelectedTab Is tp2 Then
            wb22 = 0
            Timer2.Stop()
            TabControl1.SelectedTab.Dispose()
        End If
        If TabControl1.SelectedTab Is tp3 Then
            wb33 = 0
            Timer3.Stop()
            TabControl1.SelectedTab.Dispose()
        End If
        If TabControl1.SelectedTab Is tp4 Then
            wb44 = 0
            Timer4.Stop()
            TabControl1.SelectedTab.Dispose()
        End If
        If TabControl1.SelectedTab Is tp5 Then
            wb55 = 0
            Timer5.Stop()
            TabControl1.SelectedTab.Dispose()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Panel1_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDoubleClick
        Me.WindowState = FormWindowState.Maximized
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
        tp1.Text = wb1.DocumentTitle
        If wb1.DocumentTitle = "You are an Idiot! (dot cc)" Then
            wb1.DocumentText = My.Resources.protect
        End If
        If wb1.DocumentTitle = "Online Help Support | mchelper.com | Computer Repair & Maintenance" Then
            wb1.DocumentText = My.Resources.protect
        End If
        If wb1.DocumentTitle = "Watch cartoons online free in high quality kisscartoon" Then
            wb1.DocumentText = My.Resources.protect
        End If
        If wb1.DocumentTitle = "HURR-DURR" Then
            wb1.DocumentText = My.Resources.protect
        End If
        If wb1.DocumentTitle = "Free Roblox Generator | Get Roblox Robux and Roblox Premium" Then
            wb1.DocumentText = My.Resources.protect
        End If
        If wb1.DocumentTitle = "TheRewardGenius: Take Surveys, Discover Deals and Get Gift Cards" Then
            wb1.DocumentText = My.Resources.protect
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            webbr.Refresh()
        End If
        If TabControl1.SelectedTab Is tp1 Then
            wb1.Refresh()
        End If
        If TabControl1.SelectedTab Is tp2 Then
            wb2.Refresh()
        End If
        If TabControl1.SelectedTab Is tp3 Then
            wb3.Refresh()
        End If
        If TabControl1.SelectedTab Is tp4 Then
            wb4.Refresh()
        End If
        If TabControl1.SelectedTab Is tp5 Then
            wb5.Refresh()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            webbr.GoBack()
        End If
        If TabControl1.SelectedTab Is tp1 Then
            wb1.GoBack()
        End If
        If TabControl1.SelectedTab Is tp2 Then
            wb2.GoBack()
        End If
        If TabControl1.SelectedTab Is tp3 Then
            wb3.GoBack()
        End If
        If TabControl1.SelectedTab Is tp4 Then
            wb4.GoBack()
        End If
        If TabControl1.SelectedTab Is tp5 Then
            wb5.GoBack()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TabControl1.SelectedTab Is TabPage1 Then
            webbr.GoForward()
        End If
        If TabControl1.SelectedTab Is tp1 Then
            wb1.GoForward()
        End If
        If TabControl1.SelectedTab Is tp2 Then
            wb2.GoForward()
        End If
        If TabControl1.SelectedTab Is tp3 Then
            wb3.GoForward()
        End If
        If TabControl1.SelectedTab Is tp4 Then
            wb4.GoForward()
        End If
        If TabControl1.SelectedTab Is tp5 Then
            wb5.GoForward()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        tp2.Text = wb2.DocumentTitle
        dowb2()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        tp3.Text = wb3.DocumentTitle
        dowb3()
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        tp4.Text = wb4.DocumentTitle
        dowb4()
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        tp5.Text = wb5.DocumentTitle
        dowb5()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Panel2.Hide()
        Panel3.Hide()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel2.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Button5.PerformClick()
        Panel2.Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Button6.PerformClick()
        Panel2.Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Panel3.Show()
        Panel2.Hide()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        Panel3.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Dim admin = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "BrowserSettings", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Panel4.Show()
            Panel2.Hide()
        End If
    End Sub

    Private Sub cb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb.SelectedIndexChanged
        If cb.Text = "Bing" Then
            Form4.Show()
            Form4.Label1.Text = "Reboot browser to apply changes."
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
              "Browser", "https://www.bing.com")
        End If
        If cb.Text = "Google" Then
            Form4.Show()
            Form4.Label1.Text = "Reboot browser to apply changes."
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
              "Browser", "https://www.google.com")
        End If
        If cb.Text = "Yahoo!" Then
            Form4.Show()
            Form4.Label1.Text = "Reboot browser to apply changes."
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
              "Browser", "https://www.yahoo.com")
        End If
        If cb.Text = "DuckDuckGo" Then
            Form4.Show()
            Form4.Label1.Text = "Reboot browser to apply changes."
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
              "Browser", "https://www.duckduckgo.com")
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        'security
        If webbr.DocumentTitle = "You are an Idiot! (dot cc)" Then
            webbr.DocumentText = My.Resources.protect
        End If
        If webbr.DocumentTitle = "Online Help Support | mchelper.com | Computer Repair & Maintenance" Then
            webbr.DocumentText = My.Resources.protect
        End If
        If webbr.DocumentTitle = "Watch cartoons online free in high quality kisscartoon" Then
            webbr.DocumentText = My.Resources.protect
        End If
        If webbr.DocumentTitle = "HURR-DURR" Then
            webbr.DocumentText = My.Resources.protect
        End If
        If webbr.DocumentTitle = "Free Roblox Generator | Get Roblox Robux and Roblox Premium" Then
            webbr.DocumentText = My.Resources.protect
        End If
        If webbr.DocumentTitle = "TheRewardGenius: Take Surveys, Discover Deals and Get Gift Cards" Then
            webbr.DocumentText = My.Resources.protect
        End If
    End Sub
    Private Sub dowb1()
       
    End Sub
    Private Sub dowb2()
        If wb2.DocumentTitle = "You are an Idiot! (dot cc)" Then
            wb2.DocumentText = My.Resources.protect
        End If
        If wb2.DocumentTitle = "Online Help Support | mchelper.com | Computer Repair & Maintenance" Then
            wb2.DocumentText = My.Resources.protect
        End If
        If wb2.DocumentTitle = "Watch cartoons online free in high quality kisscartoon" Then
            wb2.DocumentText = My.Resources.protect
        End If
        If wb2.DocumentTitle = "HURR-DURR" Then
            wb2.DocumentText = My.Resources.protect
        End If
        If wb2.DocumentTitle = "Free Roblox Generator | Get Roblox Robux and Roblox Premium" Then
            wb2.DocumentText = My.Resources.protect
        End If
        If wb2.DocumentTitle = "TheRewardGenius: Take Surveys, Discover Deals and Get Gift Cards" Then
            wb2.DocumentText = My.Resources.protect
        End If
    End Sub
    Private Sub dowb3()
        If wb3.DocumentTitle = "You are an Idiot! (dot cc)" Then
            wb3.DocumentText = My.Resources.protect
        End If
        If wb3.DocumentTitle = "Online Help Support | mchelper.com | Computer Repair & Maintenance" Then
            wb3.DocumentText = My.Resources.protect
        End If
        If wb3.DocumentTitle = "Watch cartoons online free in high quality kisscartoon" Then
            wb3.DocumentText = My.Resources.protect
        End If
        If wb3.DocumentTitle = "HURR-DURR" Then
            wb3.DocumentText = My.Resources.protect
        End If
        If wb3.DocumentTitle = "Free Roblox Generator | Get Roblox Robux and Roblox Premium" Then
            wb3.DocumentText = My.Resources.protect
        End If
        If wb3.DocumentTitle = "TheRewardGenius: Take Surveys, Discover Deals and Get Gift Cards" Then
            wb3.DocumentText = My.Resources.protect
        End If
    End Sub
    Private Sub dowb4()
        If wb4.DocumentTitle = "You are an Idiot! (dot cc)" Then
            wb4.DocumentText = My.Resources.protect
        End If
        If wb4.DocumentTitle = "Online Help Support | mchelper.com | Computer Repair & Maintenance" Then
            wb4.DocumentText = My.Resources.protect
        End If
        If wb4.DocumentTitle = "Watch cartoons online free in high quality kisscartoon" Then
            wb4.DocumentText = My.Resources.protect
        End If
        If wb4.DocumentTitle = "HURR-DURR" Then
            wb4.DocumentText = My.Resources.protect
        End If
        If wb4.DocumentTitle = "Free Roblox Generator | Get Roblox Robux and Roblox Premium" Then
            wb4.DocumentText = My.Resources.protect
        End If
        If wb4.DocumentTitle = "TheRewardGenius: Take Surveys, Discover Deals and Get Gift Cards" Then
            wb4.DocumentText = My.Resources.protect
        End If
    End Sub
    Private Sub dowb5()
        If wb5.DocumentTitle = "You are an Idiot! (dot cc)" Then
            wb5.DocumentText = My.Resources.protect
        End If
        If wb5.DocumentTitle = "Online Help Support | mchelper.com | Computer Repair & Maintenance" Then
            wb5.DocumentText = My.Resources.protect
        End If
        If wb5.DocumentTitle = "Watch cartoons online free in high quality kisscartoon" Then
            wb5.DocumentText = My.Resources.protect
        End If
        If wb5.DocumentTitle = "HURR-DURR" Then
            wb5.DocumentText = My.Resources.protect
        End If
        If wb5.DocumentTitle = "Free Roblox Generator | Get Roblox Robux and Roblox Premium" Then
            wb5.DocumentText = My.Resources.protect
        End If
        If wb5.DocumentTitle = "TheRewardGenius: Take Surveys, Discover Deals and Get Gift Cards" Then
            wb5.DocumentText = My.Resources.protect
        End If
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            webbr.Navigate(TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ViewSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem.Click
        MsgBox(webbr.DocumentText)
    End Sub
   

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        Panel4.Hide()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "Security", "yes")
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
             "Security", "no")
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem.Click
        webbr.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem.Click
        webbr.GoForward()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshToolStripMenuItem.Click
        webbr.Refresh()
    End Sub

    Private Sub BackToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem1.Click
        wb1.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem1.Click
        wb1.GoForward()
    End Sub

    Private Sub ReloadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem.Click
        wb1.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem1.Click
        MsgBox(wb1.DocumentText)
    End Sub

    Private Sub BackToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem2.Click
        wb2.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem2.Click
        wb2.GoForward()
    End Sub

    Private Sub ReloadToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem1.Click
        wb2.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem2.Click
        MsgBox(wb2.DocumentText)
    End Sub

    Private Sub BackToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem3.Click
        wb3.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem3.Click
        wb3.GoForward()
    End Sub

    Private Sub ReloadToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem2.Click
        wb3.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem3.Click
        MsgBox(wb3.DocumentText)
    End Sub

    Private Sub BackToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem4.Click
        wb4.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem4.Click
        wb4.GoForward()
    End Sub

    Private Sub ReloadToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem3.Click
        wb4.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem4.Click
        MsgBox(wb4.DocumentText)
    End Sub

    Private Sub BackToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackToolStripMenuItem5.Click
        wb5.GoBack()
    End Sub

    Private Sub ForwardToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForwardToolStripMenuItem5.Click
        wb5.GoForward()
    End Sub

    Private Sub ReloadToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadToolStripMenuItem4.Click
        wb5.Refresh()
    End Sub

    Private Sub ViewSourceToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewSourceToolStripMenuItem5.Click
        MsgBox(wb5.DocumentText)
    End Sub

    Private Sub webbr_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles webbr.DocumentCompleted

    End Sub
End Class