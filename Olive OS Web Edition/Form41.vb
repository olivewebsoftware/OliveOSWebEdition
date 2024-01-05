Public Class Form41
    Dim n As Integer = 0
    Dim m As Integer = 0
    Private Sub Form41_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Dim pack = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PackEnabled", Nothing)
        Dim setup = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Wallpaper", Nothing)
        If pack = "yes" Then
            Try
                Me.BackgroundImage = Image.FromFile(setup)
            Catch ex As Exception
                Form4.Show()
                Form4.Label1.Text = "We can't load your wallpaper."
            End Try
        End If
        If setup = "def" Then
            Me.BackgroundImage = My.Resources.def
        End If
        If setup = "rockwater" Then
            Me.BackgroundImage = My.Resources.rockwater
        End If
        If setup = "cliff" Then
            Me.BackgroundImage = My.Resources.cliff
        End If
        If setup = "def2" Then
            Me.BackgroundImage = My.Resources.webdefault
        End If
        If setup = "game" Then
            Me.BackgroundImage = My.Resources.gameon
        End If
        Dim ur = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Username", Nothing)
        Label5.Text = ur
        Dim pic = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "PFP", Nothing)
        If pic = "1" Then
            pb.Image = My.Resources.use1
        End If

        If pic = "3" Then
            pb.Image = My.Resources.use3
        End If
        If pic = "2" Then
            pb.Image = My.Resources.use2
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Dim pwd = My.Computer.Registry.GetValue(
       "HKEY_CURRENT_USER\Software\Olive OS Web Edition", "Password", Nothing)
        If e.KeyCode = Keys.Enter Then
            If m = 1 Then
                Form4.Show()
                Form4.Label1.Text = "Olive OS is disabled."
                Exit Sub
            End If
            If TextBox1.Text = pwd Then
                Me.Close()
                Form8.Show()
            Else
                If n = 3 Then
                    Form4.Show()
                    Form4.Label1.Text = My.Resources.err
                    m = 1
                    Timer1.Start()
                    Exit Sub
                End If
                Form4.Show()
                Form4.Label1.Text = "Incorrect password."
                n += 1
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim ui = My.Computer.Registry.GetValue(
    "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "SetupState", Nothing)
        If ui = "" Then
            Form4.Show()
            Form4.Label1.Text = My.Resources.dang
        Else
            Form32.Show()
        End If
    End Sub
End Class