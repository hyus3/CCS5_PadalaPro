Public Class form_hr
    Private Sub form_hr_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load employee db here

        ' Sample data, delete this later
        Dim dt As New DataTable()
        dt.Columns.Add("Employee ID")
        dt.Columns.Add("First Name")
        dt.Columns.Add("Last Name")
        dt.Columns.Add("M.I.")
        dt.Columns.Add("Type")
        
        dt.Rows.Add(10001, "Anna", "Garcia", "M", "C")
        dt.Rows.Add(10002, "Carlos", "Lopez", "J", "D")
        dt.Rows.Add(10003, "Maria", "Santos", "L", "C")
        dt.Rows.Add(10004, "John", "Reyes", "D", "D")
        dt.Rows.Add(10005, "Liza", "Cruz", "A", "HR")
        dt.Rows.Add(10006, "Helen", "Tan", "S", "C")
        dt.Rows.Add(10007, "Mark", "Torres", "P", "D")
        dt.Rows.Add(10008, "Grace", "Lim", "B", "HR")

        data_employees.DataSource = dt


        'don't touch this
        data_employees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        data_employees.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_employees.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_employees.Width = totalWidth
        Me.Width = totalWidth + 40
        data_employees.Left = (Me.ClientSize.Width - data_employees.Width) \ 2
    End Sub

    Private Sub form_hr_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_Login.Show()
    End Sub

    'change color on hover of button
    Private Sub btn_manageEmployees_MouseHover(sender As Object, e As EventArgs) Handles btn_manageEmployees.MouseHover
        btn_manageEmployees.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_manageEmployees_MouseLeave(sender As Object, e As EventArgs) Handles btn_manageEmployees.MouseLeave
        btn_manageEmployees.BackColor = Color.Red
    End Sub

    Private Sub btn_manageEmployees_Click(sender As Object, e As EventArgs) Handles btn_manageEmployees.Click
        form_manageEmployees.Show()
        Me.Hide()
    End Sub
End Class