Public Class form_manageShipment
    Private empID As Integer
    Private isOutbound = False

    'constructor so that we are able to use the employee ID that was used to log in
    Public Sub New(ID As Integer)
        InitializeComponent()
        empID = ID
    End Sub

    'checks if it is inbound or outbound
    Private Sub radio_outbound_CheckedChanged(sender As Object, e As EventArgs) Handles radio_outbound.CheckedChanged
        isOutbound = radio_outbound.Checked

        If isOutbound Then
            txt_qty.ReadOnly = True
            label_date.Text = "Delivery Date :"
            label_clerkID.Text = "Dispatched By :"
            btn_save.Text = "DISPATCH"
            txt_date.Enabled = True

            'reset fields when radio is toggled
            clearFields()
        Else
            txt_qty.ReadOnly = False
            label_date.Text = "Arrival Date :"
            label_clerkID.Text = "Received By :"
            btn_save.Text = "RECEIVE"
            txt_date.Enabled = False

            clearFields()
        End If
    End Sub

    'when the form is opened
    Private Sub form_manageShipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_shipment.Visible = False
        data_driver.Visible = False
        label_error1.Visible = False
        label_error2.Visible = False
        label_error3.Visible = False
        txt_clerkID.Text = empID.ToString()
        txt_date.Value = DateTime.Now
    End Sub

    Private Sub form_manageShipment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New form_clerk(empID)
        form.Show()
    End Sub

    'toggles dropdown of datagrid when clerk tries to edit shipment ID
    Private Sub txt_shipmentID_Click(sender As Object, e As EventArgs) Handles txt_shipmentID.Click
        'read data from shipment db here 
        'adjust dt to whatever name of the datatable you will use
        'rows are already filtered based on if the receiver/dispatcher is NULL
        'feel free to pull all the rows from db since we have a filter here

        ' Sample data, delete this later
        Dim dt As New DataTable()
        dt.Columns.Add("Shipment ID")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Received By")
        dt.Columns.Add("Dispatched By")

        ' Add sample rows
        dt.Rows.Add(10001, 10, 30001, DBNull.Value, DBNull.Value)
        dt.Rows.Add(10002, 25, 30002, 20001, DBNull.Value)
        dt.Rows.Add(10003, 5, 30003, 20002, 20003)
        dt.Rows.Add(10004, 15, 30004, DBNull.Value, DBNull.Value)
        dt.Rows.Add(10005, 8, 30005, 20004, DBNull.Value)
        dt.Rows.Add(10006, 12, 30006, 20005, 20006)


        Dim inboundFilter As New DataView(dt)
        inboundFilter.RowFilter = "[Received By] IS NULL"
        Dim outboundFilter As New DataView(dt)
        outboundFilter.RowFilter = "[Received By] IS NOT NULL AND [Dispatched By] IS NULL"

        If isOutbound Then
            data_shipment.DataSource = outboundFilter
        Else
            data_shipment.DataSource = inboundFilter
        End If


        'dont touch this
        data_shipment.Columns("Received By").Visible = False
        data_shipment.Columns("Dispatched By").Visible = False
        data_shipment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        data_shipment.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_shipment.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_shipment.Width = totalWidth
        data_shipment.Top = txt_shipmentID.Bottom + 5
        data_shipment.Left = txt_shipmentID.Right - data_shipment.Width
        data_shipment.Visible = True
    End Sub

    'handles autocomplete of details when clerk receives/dispatches shipments
    Private Sub data_inbound_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_shipment.CellClick
        If e.RowIndex >= 0 Then
            'adjust row names as needed
            Dim shipmentID As String = data_shipment.Rows(e.RowIndex).Cells("Shipment ID").Value.ToString()
            Dim qty As String = data_shipment.Rows(e.RowIndex).Cells("Quantity").Value.ToString()
            Dim retailerID As String = data_shipment.Rows(e.RowIndex).Cells("Retailer ID").Value.ToString()

            txt_shipmentID.Text = shipmentID
            txt_qty.Text = qty
            txt_retailer.Text = retailerID
            data_shipment.Visible = False
        End If
    End Sub

    'toggles dropdown of datagrid when clerk tries to edit driver ID
    Private Sub txt_driver_Click(sender As Object, e As EventArgs) Handles txt_driver.Click
        'read data from employee db here
        'filter for drivers already implemented
        'adjust dt to whatever name of the datatable you will use
        'feel free to pull all the rows from db since we have a filter here

        ' Sample data, delete this later
        Dim dt As New DataTable()
        dt.Columns.Add("Employee ID")
        dt.Columns.Add("Last Name")
        dt.Columns.Add("First Name")
        dt.Columns.Add("Type")

        ' Add sample rows
        dt.Rows.Add(11111, "Garcia", "Anna", "D")
        dt.Rows.Add(11112, "Lopez", "Carlos", "c")
        dt.Rows.Add(11113, "Santos", "Maria", "d")
        dt.Rows.Add(11114, "Reyes", "John", "d")
        dt.Rows.Add(11115, "Cruz", "Liza", "c")
        dt.Rows.Add(11116, "Tan", "Helen", "h")

        For Each row As DataRow In dt.Rows
            row("Type") = row("Type").ToString().ToLower()
        Next
        Dim driver As New DataView(dt)
        driver.RowFilter = "Type = 'd'"
        data_driver.DataSource = driver


        'dont touch this
        data_driver.Columns("Type").Visible = False
        data_driver.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        data_driver.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_driver.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_driver.Width = totalWidth
        data_driver.Top = txt_driver.Bottom + 5
        data_driver.Left = txt_driver.Right - data_driver.Width
        data_driver.Visible = True
    End Sub

    'handles autocomplete of details when clerk receives/dispatches shipments
    Private Sub data_driver_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_driver.CellClick
        If e.RowIndex >= 0 Then
            'adjust row names as needed
            Dim driverID As String = data_driver.Rows(e.RowIndex).Cells("Employee ID").Value.ToString()

            txt_driver.Text = driverID
            data_driver.Visible = False
        End If
    End Sub

    'save button
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        label_error1.Visible = False
        label_error2.Visible = False
        label_error3.Visible = False

        'input validation
        Dim shipmentID As Integer
        Dim qty As Integer
        Dim clerkID As Integer = empID
        Dim dateString As String = txt_date.Value.ToString("yyyy-MM-dd")
        Dim driverID As Integer
        Dim validInput = True

        'checks if shipment id is a valid int
        If Not Integer.TryParse(txt_shipmentID.Text, shipmentID) Then
            label_error1.Text = "Shipment ID cannot be empty."
            label_error1.Visible = True
            validInput = False
        End If

        'checks if quantity is a valid int
        If Integer.TryParse(txt_qty.Text.Trim(), qty) Then
            If qty < 1 Then
                label_error2.Text = "Quantity cannot be less than 1."
                label_error2.Visible = True
                validInput = False
            End If
        Else
            label_error2.Text = "Quantity cannot be empty."
            label_error2.Visible = True
            validInput = False
        End If
        'checks if driver id is a valid int
        If Not Integer.TryParse(txt_driver.Text, driverID) Then
            label_error3.Text = "Driver ID cannot be empty."
            label_error3.Visible = True
            validInput = False
        End If


        'save changes to db here
        If validInput Then
            If isOutbound Then
                'for outbound here
                MessageBox.Show("Shipment dispatched.")
                clearFields()
            Else
                'for inbound here
                MessageBox.Show("Shipment received.")
                clearFields()
            End If
        End If
    End Sub

    'ensures that only numbers are the accepted input
    Private Sub txt_qty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_qty.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub clearFields()
        txt_shipmentID.Text = ""
        txt_qty.Text = ""
        txt_clerkID.Text = ""
        txt_retailer.Text = ""
        txt_driver.Text = ""
    End Sub

    'change color on hover of log in button
    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        btn_save.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        btn_save.BackColor = Color.Red
    End Sub
End Class