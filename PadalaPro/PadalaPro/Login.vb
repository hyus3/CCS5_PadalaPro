Public Class form_Login

    'window
    Private Sub form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'implement db connections here

        label_invalidInput.Hide()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim empID As Integer '5 DIGITS MAX
        Dim form As Form

        If Integer.TryParse(txt_empID.Text.Trim(), empID) Then
            'load employee db here to validate login

            If empID = 1 Then 'CLERK
                form = New form_clerk(empID)
            ElseIf empID = 222 Then 'DRIVER
                form = New form_driver(empID)
            ElseIf empID = 3 Then 'HR
                form = New form_hr()
            Else
                label_invalidInput.Show()
                label_invalidInput.Text = "Enter a valid employee ID."
                Return
            End If
        Else
            label_invalidInput.Show()
            label_invalidInput.Text = "Employee ID cannot be empty."
            Return
        End If
        form.Show()
        Me.Hide()
    End Sub

    'ensures that only numbers are the accepted input
    Private Sub txt_empID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_empID.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Reject the input
        End If
    End Sub

    'change color on hover of log in button
    Private Sub btn_login_MouseHover(sender As Object, e As EventArgs) Handles btn_login.MouseHover
        btn_login.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_login_MouseLeave(sender As Object, e As EventArgs) Handles btn_login.MouseLeave
        btn_login.BackColor = Color.Red
    End Sub
End Class
