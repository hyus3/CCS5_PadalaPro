<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_manageShipment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.radio_inbound = New System.Windows.Forms.RadioButton()
        Me.radio_outbound = New System.Windows.Forms.RadioButton()
        Me.label_shipmentID = New System.Windows.Forms.Label()
        Me.txt_shipmentID = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.label_qty = New System.Windows.Forms.Label()
        Me.label_date = New System.Windows.Forms.Label()
        Me.txt_clerkID = New System.Windows.Forms.TextBox()
        Me.label_clerkID = New System.Windows.Forms.Label()
        Me.txt_retailer = New System.Windows.Forms.TextBox()
        Me.label_retailer = New System.Windows.Forms.Label()
        Me.txt_driver = New System.Windows.Forms.TextBox()
        Me.label_driver = New System.Windows.Forms.Label()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.data_shipment = New System.Windows.Forms.DataGridView()
        Me.data_driver = New System.Windows.Forms.DataGridView()
        Me.label_error1 = New System.Windows.Forms.Label()
        Me.label_title = New System.Windows.Forms.Label()
        Me.label_error3 = New System.Windows.Forms.Label()
        Me.label_error2 = New System.Windows.Forms.Label()
        CType(Me.data_shipment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_driver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radio_inbound
        '
        Me.radio_inbound.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_inbound.AutoSize = True
        Me.radio_inbound.Checked = True
        Me.radio_inbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_inbound.Location = New System.Drawing.Point(60, 153)
        Me.radio_inbound.Name = "radio_inbound"
        Me.radio_inbound.Size = New System.Drawing.Size(228, 24)
        Me.radio_inbound.TabIndex = 0
        Me.radio_inbound.TabStop = True
        Me.radio_inbound.Text = "Receive Inbound Shipment"
        Me.radio_inbound.UseVisualStyleBackColor = True
        '
        'radio_outbound
        '
        Me.radio_outbound.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_outbound.AutoSize = True
        Me.radio_outbound.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_outbound.Location = New System.Drawing.Point(60, 183)
        Me.radio_outbound.Name = "radio_outbound"
        Me.radio_outbound.Size = New System.Drawing.Size(249, 24)
        Me.radio_outbound.TabIndex = 1
        Me.radio_outbound.Text = "Dispatch Outbound Shipment"
        Me.radio_outbound.UseVisualStyleBackColor = True
        '
        'label_shipmentID
        '
        Me.label_shipmentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_shipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_shipmentID.Location = New System.Drawing.Point(56, 252)
        Me.label_shipmentID.Name = "label_shipmentID"
        Me.label_shipmentID.Size = New System.Drawing.Size(150, 20)
        Me.label_shipmentID.TabIndex = 2
        Me.label_shipmentID.Text = "Shipment ID :"
        Me.label_shipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_shipmentID
        '
        Me.txt_shipmentID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_shipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shipmentID.Location = New System.Drawing.Point(262, 249)
        Me.txt_shipmentID.Name = "txt_shipmentID"
        Me.txt_shipmentID.ReadOnly = True
        Me.txt_shipmentID.Size = New System.Drawing.Size(238, 27)
        Me.txt_shipmentID.TabIndex = 3
        '
        'txt_qty
        '
        Me.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(262, 299)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(238, 27)
        Me.txt_qty.TabIndex = 5
        '
        'label_qty
        '
        Me.label_qty.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_qty.Location = New System.Drawing.Point(56, 302)
        Me.label_qty.Name = "label_qty"
        Me.label_qty.Size = New System.Drawing.Size(150, 20)
        Me.label_qty.TabIndex = 4
        Me.label_qty.Text = "Quantity :"
        Me.label_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label_date
        '
        Me.label_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_date.Location = New System.Drawing.Point(56, 402)
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(150, 20)
        Me.label_date.TabIndex = 6
        Me.label_date.Text = "Arrival Date :"
        Me.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_clerkID
        '
        Me.txt_clerkID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_clerkID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_clerkID.Location = New System.Drawing.Point(262, 349)
        Me.txt_clerkID.Name = "txt_clerkID"
        Me.txt_clerkID.ReadOnly = True
        Me.txt_clerkID.Size = New System.Drawing.Size(238, 27)
        Me.txt_clerkID.TabIndex = 9
        '
        'label_clerkID
        '
        Me.label_clerkID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_clerkID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_clerkID.Location = New System.Drawing.Point(56, 352)
        Me.label_clerkID.Name = "label_clerkID"
        Me.label_clerkID.Size = New System.Drawing.Size(150, 20)
        Me.label_clerkID.TabIndex = 8
        Me.label_clerkID.Text = "Received By :"
        Me.label_clerkID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_retailer
        '
        Me.txt_retailer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_retailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_retailer.Location = New System.Drawing.Point(262, 449)
        Me.txt_retailer.Name = "txt_retailer"
        Me.txt_retailer.ReadOnly = True
        Me.txt_retailer.Size = New System.Drawing.Size(238, 27)
        Me.txt_retailer.TabIndex = 11
        '
        'label_retailer
        '
        Me.label_retailer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_retailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_retailer.Location = New System.Drawing.Point(56, 452)
        Me.label_retailer.Name = "label_retailer"
        Me.label_retailer.Size = New System.Drawing.Size(150, 20)
        Me.label_retailer.TabIndex = 10
        Me.label_retailer.Text = "Retailer ID :"
        Me.label_retailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_driver
        '
        Me.txt_driver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_driver.Location = New System.Drawing.Point(262, 499)
        Me.txt_driver.Name = "txt_driver"
        Me.txt_driver.ReadOnly = True
        Me.txt_driver.Size = New System.Drawing.Size(238, 27)
        Me.txt_driver.TabIndex = 13
        '
        'label_driver
        '
        Me.label_driver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_driver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_driver.Location = New System.Drawing.Point(56, 502)
        Me.label_driver.Name = "label_driver"
        Me.label_driver.Size = New System.Drawing.Size(150, 20)
        Me.label_driver.TabIndex = 12
        Me.label_driver.Text = "Driver :"
        Me.label_driver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_date
        '
        Me.txt_date.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_date.CalendarTitleBackColor = System.Drawing.Color.Red
        Me.txt_date.Enabled = False
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.Location = New System.Drawing.Point(262, 399)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(238, 27)
        Me.txt_date.TabIndex = 14
        Me.txt_date.Value = New Date(2025, 5, 17, 19, 35, 57, 0)
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Red
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(300, 626)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(200, 42)
        Me.btn_save.TabIndex = 15
        Me.btn_save.Text = "RECEIVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'data_shipment
        '
        Me.data_shipment.AllowUserToAddRows = False
        Me.data_shipment.AllowUserToDeleteRows = False
        Me.data_shipment.AllowUserToResizeColumns = False
        Me.data_shipment.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "NULL"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_shipment.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_shipment.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.data_shipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.data_shipment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.data_shipment.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_shipment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data_shipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_shipment.DefaultCellStyle = DataGridViewCellStyle3
        Me.data_shipment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_shipment.Location = New System.Drawing.Point(470, 57)
        Me.data_shipment.Name = "data_shipment"
        Me.data_shipment.RowHeadersVisible = False
        Me.data_shipment.RowHeadersWidth = 40
        Me.data_shipment.RowTemplate.Height = 24
        Me.data_shipment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_shipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_shipment.ShowCellErrors = False
        Me.data_shipment.ShowCellToolTips = False
        Me.data_shipment.ShowEditingIcon = False
        Me.data_shipment.ShowRowErrors = False
        Me.data_shipment.Size = New System.Drawing.Size(30, 150)
        Me.data_shipment.TabIndex = 16
        '
        'data_driver
        '
        Me.data_driver.AllowUserToAddRows = False
        Me.data_driver.AllowUserToDeleteRows = False
        Me.data_driver.AllowUserToResizeColumns = False
        Me.data_driver.AllowUserToResizeRows = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.NullValue = "NULL"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_driver.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data_driver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.data_driver.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.data_driver.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.data_driver.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_driver.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.data_driver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_driver.DefaultCellStyle = DataGridViewCellStyle6
        Me.data_driver.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_driver.Location = New System.Drawing.Point(434, 57)
        Me.data_driver.Name = "data_driver"
        Me.data_driver.RowHeadersVisible = False
        Me.data_driver.RowHeadersWidth = 40
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_driver.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.data_driver.RowTemplate.Height = 24
        Me.data_driver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_driver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_driver.ShowCellErrors = False
        Me.data_driver.ShowCellToolTips = False
        Me.data_driver.ShowEditingIcon = False
        Me.data_driver.ShowRowErrors = False
        Me.data_driver.Size = New System.Drawing.Size(30, 150)
        Me.data_driver.TabIndex = 17
        '
        'label_error1
        '
        Me.label_error1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error1.AutoSize = True
        Me.label_error1.ForeColor = System.Drawing.Color.Red
        Me.label_error1.Location = New System.Drawing.Point(259, 229)
        Me.label_error1.Name = "label_error1"
        Me.label_error1.Size = New System.Drawing.Size(101, 17)
        Me.label_error1.TabIndex = 18
        Me.label_error1.Text = "*errormessage"
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(50, 57)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 19
        Me.label_title.Text = "Padala Pro"
        '
        'label_error3
        '
        Me.label_error3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error3.AutoSize = True
        Me.label_error3.ForeColor = System.Drawing.Color.Red
        Me.label_error3.Location = New System.Drawing.Point(259, 479)
        Me.label_error3.Name = "label_error3"
        Me.label_error3.Size = New System.Drawing.Size(101, 17)
        Me.label_error3.TabIndex = 24
        Me.label_error3.Text = "*errormessage"
        '
        'label_error2
        '
        Me.label_error2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error2.AutoSize = True
        Me.label_error2.ForeColor = System.Drawing.Color.Red
        Me.label_error2.Location = New System.Drawing.Point(259, 279)
        Me.label_error2.Name = "label_error2"
        Me.label_error2.Size = New System.Drawing.Size(101, 17)
        Me.label_error2.TabIndex = 25
        Me.label_error2.Text = "*errormessage"
        '
        'form_manageShipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(557, 703)
        Me.Controls.Add(Me.label_error2)
        Me.Controls.Add(Me.label_error3)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_error1)
        Me.Controls.Add(Me.data_driver)
        Me.Controls.Add(Me.data_shipment)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_driver)
        Me.Controls.Add(Me.label_driver)
        Me.Controls.Add(Me.txt_retailer)
        Me.Controls.Add(Me.label_retailer)
        Me.Controls.Add(Me.txt_clerkID)
        Me.Controls.Add(Me.label_clerkID)
        Me.Controls.Add(Me.label_date)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.label_qty)
        Me.Controls.Add(Me.txt_shipmentID)
        Me.Controls.Add(Me.label_shipmentID)
        Me.Controls.Add(Me.radio_outbound)
        Me.Controls.Add(Me.radio_inbound)
        Me.MinimizeBox = False
        Me.Name = "form_manageShipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Shipments"
        CType(Me.data_shipment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_driver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radio_inbound As System.Windows.Forms.RadioButton
    Friend WithEvents radio_outbound As System.Windows.Forms.RadioButton
    Friend WithEvents label_shipmentID As System.Windows.Forms.Label
    Friend WithEvents txt_shipmentID As System.Windows.Forms.TextBox
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents label_qty As System.Windows.Forms.Label
    Friend WithEvents label_date As System.Windows.Forms.Label
    Friend WithEvents txt_clerkID As System.Windows.Forms.TextBox
    Friend WithEvents label_clerkID As System.Windows.Forms.Label
    Friend WithEvents txt_retailer As System.Windows.Forms.TextBox
    Friend WithEvents label_retailer As System.Windows.Forms.Label
    Friend WithEvents txt_driver As System.Windows.Forms.TextBox
    Friend WithEvents label_driver As System.Windows.Forms.Label
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents data_shipment As System.Windows.Forms.DataGridView
    Friend WithEvents data_driver As System.Windows.Forms.DataGridView
    Friend WithEvents label_error1 As System.Windows.Forms.Label
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents label_error3 As System.Windows.Forms.Label
    Friend WithEvents label_error2 As System.Windows.Forms.Label
End Class
