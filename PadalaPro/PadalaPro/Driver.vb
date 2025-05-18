Public Class form_driver
    Private empID As Integer

    'constructor so that we are able to use the employee ID that was used to log in
    Public Sub New(ID As Integer)
        InitializeComponent()
        empID = ID
    End Sub

    Private Sub form_driver_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load shipment db here
        'already filtered by employee ID used in login

        ' Sample data, delete this later
        Dim dt As New DataTable()
        dt.Columns.Add("Shipment ID")
        dt.Columns.Add("Dispatch Date", GetType(Date))
        dt.Columns.Add("Dispatched By")
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Delivery Date", GetType(Date))
        dt.Columns.Add("Driver(Dispatch)")
        dt.Columns.Add("Delivery Status")

        dt.Rows.Add(10010, #5/10/2025#, 20001, 30001, #5/11/2025#, 222, "Delivered")
        dt.Rows.Add(10011, #5/11/2025#, 20002, 30002, #5/13/2025#, 40002, "Not Delivered")
        dt.Rows.Add(10012, #5/12/2025#, 20003, 30003, #5/14/2025#, 222, "Delivered")
        dt.Rows.Add(10013, #5/13/2025#, 20004, 30004, #5/15/2025#, 222, "Not Delivered")
        dt.Rows.Add(10014, #5/14/2025#, 20005, 30005, #5/16/2025#, 222, "Not Delivered")


        'filter to deliveries assigned to current driver that is logged in
        Dim deliveries As New DataView(dt)
        deliveries.RowFilter = "[Driver(Dispatch)] = " & empID
        data_deliveries.DataSource = deliveries


        'don't touch this
        data_deliveries.Columns("Driver(Dispatch)").Visible = False
        data_deliveries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        data_deliveries.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_deliveries.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_deliveries.Width = totalWidth
        Me.Width = totalWidth + 40
        data_deliveries.Left = (Me.ClientSize.Width - data_deliveries.Width) \ 2
    End Sub

    Private Sub form_driver_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        form_Login.Show()
    End Sub

    'change color on hover of button
    Private Sub btn_manageDeliveries_MouseHover(sender As Object, e As EventArgs) Handles btn_manageDeliveries.MouseHover
        btn_manageDeliveries.BackColor = Color.DarkRed
    End Sub
    Private Sub btn_manageDeliveries_MouseLeave(sender As Object, e As EventArgs) Handles btn_manageDeliveries.MouseLeave
        btn_manageDeliveries.BackColor = Color.Red
    End Sub

    Private Sub btn_manageDeliveries_Click(sender As Object, e As EventArgs) Handles btn_manageDeliveries.Click
        Dim form As New form_manageDeliveries(empID)
        form.Show()
        Me.Hide()
    End Sub
End Class