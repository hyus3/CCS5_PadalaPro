Public Class form_manageDeliveries
    Private empID As Integer

    'constructor so that we are able to use the employee ID that was used to log in
    Public Sub New(ID As Integer)
        InitializeComponent()
        empID = ID
    End Sub

    Private Sub Manage_Deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_delivery.Visible = False
        label_error1.Visible = False
        txt_date.Value = DateTime.Now
    End Sub
    Private Sub form_manageDeliveries_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New form_driver(empID)
        form.Show()
    End Sub

    Private Sub txt_shipmentID_Click(sender As Object, e As EventArgs) Handles txt_shipmentID.Click
        'load shipment db here

        ' Sample data, delete this later
        Dim dt As New DataTable()
        dt.Columns.Add("Shipment ID")
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Delivery Date", GetType(Date))
        dt.Columns.Add("Delivery Status")
        dt.Columns.Add("Driver(Dispatch)")

        dt.Rows.Add(10001, 30001, #5/10/2025#, "Delivered", 222)
        dt.Rows.Add(10002, 30002, #5/12/2025#, "Not Delivered", 324234)
        dt.Rows.Add(10003, 30003, #5/13/2025#, "Delivered", 222)
        dt.Rows.Add(10004, 30004, #5/15/2025#, "Not Delivered", 222)
        dt.Rows.Add(10005, 30005, #5/16/2025#, "Not Delivered", 222)


        For Each row As DataRow In dt.Rows
            row("Delivery Status") = row("Delivery Status").ToString().ToUpper()
        Next

        Dim deliveries As New DataView(dt)
        deliveries.RowFilter = "[Driver(Dispatch)] = " & empID & " AND [Delivery Status] = 'NOT DELIVERED'"
        data_delivery.DataSource = deliveries

        'dont touch this
        data_delivery.Columns("Delivery Status").Visible = False
        data_delivery.Columns("Driver(Dispatch)").Visible = False
        data_delivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        data_delivery.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_delivery.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_delivery.Width = totalWidth
        data_delivery.Top = txt_shipmentID.Bottom + 5
        data_delivery.Left = txt_shipmentID.Right - data_delivery.Width
        data_delivery.Visible = True
    End Sub

    'handles autocomplete of fields when the driver selects a shipment
    Private Sub data_delivery_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_delivery.CellClick
        If e.RowIndex >= 0 Then
            'adjust row names as needed
            Dim shipmentID As String = data_delivery.Rows(e.RowIndex).Cells("Shipment ID").Value.ToString()
            Dim retailerID As String = data_delivery.Rows(e.RowIndex).Cells("Retailer ID").Value.ToString()

            txt_shipmentID.Text = shipmentID
            txt_retailer.Text = retailerID

            data_delivery.Visible = False
        End If
    End Sub


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        label_error1.Visible = False

        'input validation
        Dim shipmentID As Integer
        Dim dateString As String = txt_date.Value.ToString("yyyy-MM-dd")
        Dim validInput = True

        'checks if shipment id is a valid int
        If Not Integer.TryParse(txt_shipmentID.Text, shipmentID) Then
            label_error1.Text = "Shipment ID cannot be empty."
            label_error1.Visible = True
            validInput = False
        End If

        'save changes to db here
        If validInput Then
            'set delivery status to "Delivered" here
            'also update the delivery date here
            MessageBox.Show("Shipment Delivered")
            clearFields()
        End If
    End Sub

    Private Sub clearFields()
        txt_shipmentID.Text = ""
        txt_retailer.Text = ""
    End Sub

    'change color on hover of log in button
    Private Sub btn_save_MouseHover(sender As Object, e As EventArgs) Handles btn_save.MouseHover
        btn_save.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_save_MouseLeave(sender As Object, e As EventArgs) Handles btn_save.MouseLeave
        btn_save.BackColor = Color.Red
    End Sub
End Class