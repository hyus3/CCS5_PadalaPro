Public Class form_addShipment
    Private empID As Integer
    Dim shipmentID As Integer

    'constructor so that we are able to use the employee ID that was used to log in
    Public Sub New(ID As Integer)
        InitializeComponent()
        empID = ID
    End Sub

    Private Sub form_addShipment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        data_retailer.Visible = False
        label_error1.Visible = False
        label_error2.Visible = False

        'get the last row in shipment ID and get the ID
        shipmentID = 10000 'store it here
        txt_shipmentID.Text = shipmentID + 1.ToString()
    End Sub

    Private Sub txt_retailer_Click(sender As Object, e As EventArgs) Handles txt_retailer.Click

        'load retailer db here

        'sample data
        Dim dt As New DataTable
        dt.Columns.Add("Retailer ID")
        dt.Columns.Add("Address")
        dt.Columns.Add("Store Name")
        dt.Columns.Add("Contact Number")

        dt.Rows.Add(20001, "123 Rizal St., Dumaguete City", "Garcia's Mart", "09171234567")
        dt.Rows.Add(20002, "456 Mabini St., Dumaguete City", "Lopez Superstore", "09281234567")
        dt.Rows.Add(20003, "789 Bonifacio Ave., Bacong", "Santos Groceries", "09391234567")
        dt.Rows.Add(20004, "101 San Jose St., Valencia", "Reyes Retail Hub", "09451234567")
        dt.Rows.Add(20005, "202 Katipunan Rd., Sibulan", "Cruz General Store", "09561234567")

        data_retailer.DataSource = dt

        'dont touch this
        data_retailer.Columns("Address").Visible = False
        data_retailer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        data_retailer.AutoResizeColumns()
        Dim totalWidth As Integer = 0
        For Each col As DataGridViewColumn In data_retailer.Columns
            If col.Visible Then
                totalWidth += col.Width
            End If
        Next
        totalWidth += SystemInformation.VerticalScrollBarWidth
        data_retailer.Width = totalWidth
        data_retailer.Top = txt_retailer.Bottom + 5
        data_retailer.Left = txt_retailer.Right - data_retailer.Width()
        data_retailer.Visible = True
    End Sub
    'handles autocomplete of details when clerk receives/dispatches shipments
    Private Sub data_driver_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_retailer.CellClick
        If e.RowIndex >= 0 Then
            'adjust row names as needed
            Dim retailerID As String = data_retailer.Rows(e.RowIndex).Cells("Retailer ID").Value.ToString()

            txt_retailer.Text = retailerID
            data_retailer.Visible = False
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        label_error1.Visible = False
        label_error2.Visible = False

        'input validation
        Dim qty As Integer
        Dim retailerID As Integer
        Dim validInput = True

        'checks if quantity is a valid int
        If Integer.TryParse(txt_qty.Text.Trim(), qty) Then
            If qty < 1 Then
                label_error2.Text = "Quantity cannot be less than 1."
                label_error2.Visible = True
                validInput = False
            End If
        Else
            label_error1.Text = "Quantity cannot be empty."
            label_error1.Visible = True
            validInput = False
        End If
        'checks if driver id is a valid int
        If Not Integer.TryParse(txt_retailer.Text, retailerID) Then
            label_error2.Text = "Driver ID cannot be empty."
            label_error2.Visible = True
            validInput = False
        End If


        'save changes to db here
        If validInput Then
            'save to shipment db here


            clearFields()
            'update shipment ID to a new one
            'get the last row in shipment ID and get the ID
            shipmentID += 1
            txt_shipmentID.Text = shipmentID + 1.ToString()
            MessageBox.Show("Shipment added successfully")
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
        txt_retailer.Text = ""
    End Sub

    Private Sub form_addShipment_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Dim form As New form_clerk(empID)
        form.Show()
    End Sub
End Class