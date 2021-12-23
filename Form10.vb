Imports System
Public Class Form10

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Form16.Show()
            Form16.webbr.Navigate("https://www.bing.com/search?q=" & TextBox1.Text & "&form=QBLH&sp=-1&pq=" & TextBox1.Text & "&sc=8-4&qs=n&sk=&cvid=B01C25CA0AE840E6A0CA4522B80BF41D")
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus

    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form10_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form8.Panel1.Show()
    End Sub

    Private Sub Form10_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

    End Sub

    Private Sub Form10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        apploader()
        loadSug()
        suggest()
        Dim ui = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "ui", Nothing)
        If ui = "light" Then
            Me.BackColor = Color.White
            Panel1.ForeColor = Color.Black
            Panel2.ForeColor = Color.Black
            Panel3.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            Label5.ForeColor = Color.Black
            Label7.ForeColor = Color.Black
            Label8.ForeColor = Color.Black
            Label9.ForeColor = Color.Black
            Label10.ForeColor = Color.Black
            Label12.ForeColor = Color.Black
            l1.ForeColor = Color.Black
            l2.ForeColor = Color.Black
            l3.ForeColor = Color.Black
            l4.ForeColor = Color.Black
            l5.ForeColor = Color.Black
        End If
    End Sub
    Private Sub suggest()
        Dim rn As New Random
        Dim u As Integer = rn.Next(0, 10)
        If u = 1 Then
            sug1.Text = "Having issues with Olive OS?"
            sug2.Text = "Let's fix that."
        End If
        If u = 2 Then
            sug1.Text = "Want to check your security?"
            sug2.Text = "Run a security checkup."
        End If
        If u = 3 Then
            sug1.Text = "Enjoying Olive OS?"
            sug2.Text = "Submit Feedback"
        End If
        If u = 4 Then
            sug1.Text = "Check out our YouTube channel."
            sug2.Text = "Check it out."
        End If
        If u = 5 Then
            sug1.Text = "Have the latest updates?"
            sug2.Text = "Check for updates."
        End If
        If u = 6 Then
            sug1.Text = "Do you want to change your theme?"
            sug2.Text = "Open personalization settings."
        End If
        If u = 7 Then
            sug1.Text = "Want to get some work done?"
            sug2.Text = "Open the browser."
        End If
        If u = 8 Then
            sug1.Text = "Explore the latest apps!"
            sug2.Text = "Open Webapp installer."
        End If
        If u = 9 Then
            sug1.Text = "Check out our software!"
            sug2.Text = "Open OliveWeb Website"
        End If
        If u = 10 Then
            sug1.Text = "Want to scan your computer?"
            sug2.Text = "Check for viruses."
        End If
    End Sub
    Private Sub apploader()
        Dim web1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName1", Nothing)
        Dim web2 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName2", Nothing)
        Dim web3 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName3", Nothing)
        Dim web4 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName4", Nothing)
        Dim web5 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "AppName5", Nothing)
        Dim img1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img1", Nothing)
        Dim img2 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img2", Nothing)
        Dim img3 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img3", Nothing)
        Dim img4 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img4", Nothing)
        Dim img5 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "Img5", Nothing)
        Dim q As String = ""
        Dim w As String = ""
        Dim r As String = ""
        Dim t As String = ""
        Dim y As String = ""
        q = img1
        w = img2
        r = img3
        t = img4
        y = img5
        If web1 <> "" Then
            b1.Show()
            l1.Show()
            l1.Text = web1
        End If
        If web2 <> "" Then
            b2.Show()
            l2.Show()
            l2.Text = web2
        End If
        If web3 <> "" Then
            b3.Show()
            l3.Show()
            l3.Text = web3
        End If
        If web4 <> "" Then
            b4.Show()
            l4.Show()
            l4.Text = web4
        End If
        If web5 <> "" Then
            b5.Show()
            l5.Show()
            l5.Text = web5
        End If
        If img1 = "" Then
            'nothing
        Else
            b1.Image = Image.FromFile(q)
        End If
        If img2 = "" Then
            'nothing
        Else
            b2.Image = Image.FromFile(w)
        End If
        If img3 = "" Then
            'nothing
        Else
            b3.Image = Image.FromFile(r)
        End If
        If img4 = "" Then
            'nothing
        Else
            b4.Image = Image.FromFile(t)
        End If
        If img5 = "" Then
            'nothing
        Else
            b5.Image = Image.FromFile(y)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form11.Show()
        Me.Close()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "Wallpaper", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form12.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
        Form14.Show()
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        Form15.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form16.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Form18.Show()
        Me.Close()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim admin = My.Computer.Registry.GetValue(
"HKEY_CURRENT_USER\Software\Olive OS Web Edition\AdminControl", "WebApps", Nothing)
        If admin = "no" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.warning
        Else
            Form21.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ContextMenuStrip2_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening
        Form22.Show()
        Form22.Label4.Text = "1"
    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        Dim web1 = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent1", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "1"
        Me.Close()
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent2", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "2"
        Me.Close()
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent3", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "3"
        Me.Close()
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent4", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "4"
        Me.Close()
    End Sub

    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        Dim web1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\WebApps", "MalwarePresent5", Nothing)
        If web1 = 1 Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.oof
            Exit Sub
        End If
        Form23.Show()
        Form23.label.Text = "5"
        Me.Close()
    End Sub

    Private Sub ContextMenuStrip3_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip3.Opening
        Form22.Show()
        Form22.Label4.Text = "2"
    End Sub

    Private Sub ContextMenuStrip4_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip4.Opening
        Form22.Show()
        Form22.Label4.Text = "3"
    End Sub

    Private Sub ContextMenuStrip5_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip5.Opening
        Form22.Show()
        Form22.Label4.Text = "4"
    End Sub

    Private Sub ContextMenuStrip6_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip6.Opening
        Form22.Show()
        Form22.Label4.Text = "5"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form26.Show()
        Me.Close()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Form33.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form4.Show()
        Form4.Label1.Text = "Feature not set (0xa)"
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim t = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Suggest", Nothing)
        If t = "1" Then
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Suggest", "0")
            loadSug()
            Exit Sub
        Else
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
       "Suggest", "1")
            loadSug()
            Exit Sub
        End If
        loadSug()
    End Sub
    Private Sub loadSug()
        Dim t = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Suggest", Nothing)
        If t = "0" Then
            sug1.Hide()
            sug2.Hide()
            LinkLabel1.Text = "Turn On Suggestions"
        End If
    End Sub

    Private Sub sug2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles sug2.LinkClicked
        If sug2.Text = "Let's fix that." Then
            Form45.Show()
        End If
        If sug2.Text = "Run a security checkup." Then
            Form33.Show()
            Form33.TabControl1.SelectTab(2)
            Me.Close()
        End If
        If sug2.Text = "Submit Feedback." Then
            Form18.Show()
            Me.Close()
            Form18.TabControl1.SelectTab(3)
        End If
        If sug2.Text = "Check it out." Then
            Form18.Show()
            Me.Close()
            Form18.TabControl1.SelectTab(3)
        End If
        If sug2.Text = "Check for updates." Then
            Form18.Show()
            Me.Close()
            Form18.TabControl1.SelectTab(3)
        End If
        If sug2.Text = "Open personalization settings." Then
            Form18.Show()
            Form18.TabControl1.SelectTab(4)
        End If
        If sug2.Text = "Open the browser." Then
            Form16.Show()
            Me.Close()
        End If
        If sug2.Text = "Open Webapp installer." Then
            Form21.Show()
            Me.Close()
        End If
        If sug2.Text = "Open OliveWeb Website" Then
            Form16.Show()
            Form16.webbr.Navigate("https://olivewebsoftware.github.io/oliveweb")
            Me.Close()
        End If
        If sug2.Text = "Check for viruses." Then
            Form33.Show()
            Form33.TabControl1.SelectTab(1)
        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form45.Show()
        Me.Close()
    End Sub
End Class