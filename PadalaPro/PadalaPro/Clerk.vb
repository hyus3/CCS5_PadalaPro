Public Class form_clerk
    Private empID As Integer

    'constructor so that we are able to use the employee ID that was used to log in
    Public Sub New(ID As Integer)
        InitializeComponent()
        empID = ID
    End Sub
    Private Sub Clerk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load shipment db here

        ' Sample data, delete this later
        Dim dt As New DataTable()
        dt.Columns.Add("Shipment ID")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Date Received", GetType(Date))
        dt.Columns.Add("Received By")
        dt.Columns.Add("Dispatch Date", GetType(Date))
        dt.Columns.Add("Dispatched By")
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Delivery Date", GetType(Date))
        dt.Columns.Add("Driver(Receive)")
        dt.Columns.Add("Driver(Dispatch)")


        dt.Rows.Add(10000, 10, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, 11111, DBNull.Value, DBNull.Value, DBNull.Value)
        dt.Rows.Add(10001, 10, #5/15/2025#, 12340, DBNull.Value, DBNull.Value, 11111, DBNull.Value, 20001, DBNull.Value)
        dt.Rows.Add(10002, 25, #5/15/2025#, 12345, DBNull.Value, DBNull.Value, 11112, DBNull.Value, 20001, DBNull.Value)
        dt.Rows.Add(10003, 5, #5/15/2025#, 12345, #5/16/2025#, 12346, 11113, #5/17/2025#, 20001, 20002)
        dt.Rows.Add(10004, 8, DBNull.Value, DBNull.Value, #5/17/2025#, 12347, 11114, #5/18/2025#, DBNull.Value, 20003)
        dt.Rows.Add(10005, 12, #5/10/2025#, 12350, DBNull.Value, DBNull.Value, 11115, DBNull.Value, 20004, DBNull.Value)
        dt.Rows.Add(10006, 18, #5/14/2025#, 12351, #5/16/2025#, 12352, 11116, #5/19/2025#, 20005, 20006)
        dt.Rows.Add(10007, 30, DBNull.Value, DBNull.Value, #5/20/2025#, 12353, 11117, #5/21/2025#, DBNull.Value, 20007)
        dt.Rows.Add(10008, 7, #5/13/2025#, 12354, DBNull.Value, DBNull.Value, 11118, DBNull.Value, 20008, DBNull.Value)
        dt.Rows.Add(10009, 16, #5/14/2025#, 12355, #5/15/2025#, 12356, 11119, #5/16/2025#, 20009, 20010)

        data_shipment.DataSource = dt

        'don't touch this
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
        Me.Width = totalWidth + 40
        data_shipment.Left = (Me.ClientSize.Width - data_shipment.Width) \ 2
    End Sub

    Private Sub btn_manageShipments_Click(sender As Object, e As EventArgs) Handles btn_manageShipments.Click
        Dim form As New form_manageShipment(empID)
        Me.Hide()
        form.Show()
    End Sub

    Private Sub form_clerk_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_Login.Show()
    End Sub

    'change color on hover of log in button
    Private Sub btn_manageShipments_MouseHover(sender As Object, e As EventArgs) Handles btn_manageShipments.MouseHover
        btn_manageShipments.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_manageShipments_MouseLeave(sender As Object, e As EventArgs) Handles btn_manageShipments.MouseLeave
        btn_manageShipments.BackColor = Color.Red
    End Sub

    Private Sub btn_addShipment_Click(sender As Object, e As EventArgs) Handles btn_addShipment.Click
        Dim form As New form_addShipment(empID)
        Me.Hide()
        form.Show()
    End Sub
End Class