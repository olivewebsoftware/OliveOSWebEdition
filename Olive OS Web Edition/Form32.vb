Public Class Form32

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Form32_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cursor As Icon
        cursor = (My.Resources.defc2)
        Me.Cursor = New Cursor(cursor.Handle)
        Dim q1 = My.Computer.Registry.GetValue(
     "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "Q1", Nothing)
        Dim q2 = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "Q2", Nothing)
        Label1.Text = q1
        Label2.Text = q2
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a1 = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "A1", Nothing)
        Dim a2 = My.Computer.Registry.GetValue(
      "HKEY_CURRENT_USER\Software\Olive OS Web Edition\Login", "A2", Nothing)
        If TextBox1.Text = a1 And TextBox2.Text = a2 Then
            Label3.Show()
            TextBox3.Show()
            Button2.Show()
        Else
            Form4.Show()
            Form4.Label1.Text = "Incorrect answer(s)."
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Olive OS Web Edition",
      "Password", TextBox3.Text)
        Me.Close()
        Form4.Show()
        Form4.Label1.Text = "Set."
    End Sub
End Class