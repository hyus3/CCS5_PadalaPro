Public Class form_manageEmployees
    Private isRemove = False
    Dim dt As New DataTable 'remove this later, change to actual db variable

    'checks if it is inbound or outbound
    Private Sub radio_remove_CheckedChanged(sender As Object, e As EventArgs) Handles radio_remove.CheckedChanged
        isRemove = radio_remove.Checked

        If isRemove Then
            txt_lname.ReadOnly = False
            txt_fname.ReadOnly = False
            txt_mi.ReadOnly = False
            txt_type.Enabled = False
            btn_save.Text = "REMOVE"

            'reset fields when radio is toggled
            clearFields()
        Else
            clearFields()
            txt_type.Enabled = True
            txt_lname.ReadOnly = False
            txt_fname.ReadOnly = False
            txt_mi.ReadOnly = False
            txt_type.Items.Clear()
            txt_type.Items.Add("Clerk")
            txt_type.Items.Add("Driver")
            txt_type.Items.Add("HR")
            btn_save.Text = "ADD"
            'adds a new ID based on pattern automatically
            Dim newID As Integer
            If dt.Rows.Count > 0 Then
                newID = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)("Employee ID"))
            End If
            txt_empID.Text = newID + 1.ToString()
        End If
    End Sub
    Private Sub form_manageEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_employee.Visible = False
        txt_type.Items.Clear()
        txt_type.Items.Add("Clerk")
        txt_type.Items.Add("Driver")
        txt_type.Items.Add("HR")
        btn_save.Text = "ADD"
        label_error1.Visible = False
        label_error2.Visible = False
        label_error3.Visible = False
        label_error4.Visible = False
        Dim newID As Integer

        'Sample data, remove this later
        dt.Columns.Add("Employee ID")
        dt.Columns.Add("First Name")
        dt.Columns.Add("Last Name")
        dt.Columns.Add("M.I.")
        dt.Columns.Add("Type")

        dt.Rows.Add(10001, "Anna", "Garcia", "M", "Clerk")
        dt.Rows.Add(10002, "Carlos", "Lopez", "J", "Driver")
        dt.Rows.Add(10003, "Maria", "Santos", "L", "Clerk")
        dt.Rows.Add(10004, "John", "Reyes", "D", "Driver")

        'adds a new ID based on pattern automatically
        If dt.Rows.Count > 0 Then
            newID = Convert.ToInt32(dt.Rows(dt.Rows.Count - 1)("Employee ID"))
        End If
        txt_empID.Text = newID + 1.ToString()
    End Sub

    Private Sub txt_empID_Click(sender As Object, e As EventArgs) Handles txt_empID.Click

        If isRemove Then
            'load employee db here

            data_employee.DataSource = dt
        Else
            Return
        End If


        'dont touch this
        data_employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        data_employee.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_employee.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_employee.Width = totalWidth
        data_employee.Top = txt_empID.Bottom + 5
        data_employee.Left = txt_empID.Right - data_employee.Width
        data_employee.Visible = True
    End Sub

    'handles autocomplete of details when hr add/removes employees
    Private Sub data_employee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_employee.CellClick
        If e.RowIndex >= 0 Then
            'adjust column names as needed
            Dim empID As String = data_employee.Rows(e.RowIndex).Cells("Employee ID").Value.ToString()
            Dim lname As String = data_employee.Rows(e.RowIndex).Cells("Last Name").Value.ToString()
            Dim fname As String = data_employee.Rows(e.RowIndex).Cells("First Name").Value.ToString()
            Dim mi As String = data_employee.Rows(e.RowIndex).Cells("M.I.").Value.ToString()
            Dim type As String = data_employee.Rows(e.RowIndex).Cells("Type").Value.ToString()

            txt_empID.Text = empID
            txt_lname.Text = lname
            txt_fname.Text = fname
            txt_mi.Text = mi
            txt_type.Text = type
            data_employee.Visible = False
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        'load employee db here again
        Dim empID As Integer
        Dim valid = True

        If Not Integer.TryParse(txt_empID.Text.Trim(), empID) Then
            label_error1.Text = "Employee ID cannot be empty."
            valid = False
        End If
        If txt_lname.Text = "" Then
            label_error2.Text = "Last name cannot be empty."
            valid = False
        End If
        If txt_fname.Text = "" Then
            label_error2.Text = "First name cannot be empty."
            valid = False
        End If
        If txt_mi.Text = "" Then
            label_error3.Text = "Middle initial cannot be empty."
            valid = False
        End If
        If txt_type.Text = "Type..." Then
            label_error4.Text = "Employee must have a type."
            valid = False
        End If

        'if input is valid
        If valid Then
            If isRemove Then
                'remove here
                For Each row As DataRow In dt.Rows
                    If row("Employee ID").ToString() = txt_empID.Text Then
                        dt.Rows.Remove(row)
                        MessageBox.Show("Employee removed from the database successfully.")
                        Exit For
                    End If
                Next
            Else
                'add here
                Dim lname = txt_lname.Text
                Dim fname = txt_fname.Text
                Dim mi = label_mi.Text
                Dim type = txt_type.Text.Substring(0, 1)

                'add employee here, just replace this logic
                dt.Rows.Add(empID, fname, lname, mi, type)
                MessageBox.Show("Employee to the database successfully.")
            End If
        End If
        clearFields()
    End Sub

    Private Sub clearFields()
        txt_empID.Text = ""
        txt_lname.Text = ""
        txt_fname.Text = ""
        txt_mi.Text = ""
        txt_type.Text = "Type..."
    End Sub

    'change color on hover of log in button
    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        btn_save.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        btn_save.BackColor = Color.Red
    End Sub

    Private Sub form_manageEmployees_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_hr.Show()
    End Sub
End Class