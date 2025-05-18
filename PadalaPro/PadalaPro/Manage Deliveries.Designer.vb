<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_manageDeliveries
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
        Me.label_title = New System.Windows.Forms.Label()
        Me.label_error1 = New System.Windows.Forms.Label()
        Me.data_delivery = New System.Windows.Forms.DataGridView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_retailer = New System.Windows.Forms.TextBox()
        Me.label_retailer = New System.Windows.Forms.Label()
        Me.label_date = New System.Windows.Forms.Label()
        Me.txt_shipmentID = New System.Windows.Forms.TextBox()
        Me.label_shipmentID = New System.Windows.Forms.Label()
        CType(Me.data_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(41, 39)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 44
        Me.label_title.Text = "Padala Pro"
        '
        'label_error1
        '
        Me.label_error1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_error1.AutoSize = True
        Me.label_error1.ForeColor = System.Drawing.Color.Red
        Me.label_error1.Location = New System.Drawing.Point(247, 223)
        Me.label_error1.Name = "label_error1"
        Me.label_error1.Size = New System.Drawing.Size(101, 17)
        Me.label_error1.TabIndex = 43
        Me.label_error1.Text = "*errormessage"
        '
        'data_delivery
        '
        Me.data_delivery.AllowUserToAddRows = False
        Me.data_delivery.AllowUserToDeleteRows = False
        Me.data_delivery.AllowUserToResizeColumns = False
        Me.data_delivery.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "NULL"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_delivery.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_delivery.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.data_delivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.data_delivery.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.data_delivery.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_delivery.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data_delivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_delivery.DefaultCellStyle = DataGridViewCellStyle3
        Me.data_delivery.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_delivery.Location = New System.Drawing.Point(461, 39)
        Me.data_delivery.Name = "data_delivery"
        Me.data_delivery.RowHeadersVisible = False
        Me.data_delivery.RowHeadersWidth = 40
        Me.data_delivery.RowTemplate.Height = 24
        Me.data_delivery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_delivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_delivery.ShowCellErrors = False
        Me.data_delivery.ShowCellToolTips = False
        Me.data_delivery.ShowEditingIcon = False
        Me.data_delivery.ShowRowErrors = False
        Me.data_delivery.Size = New System.Drawing.Size(30, 150)
        Me.data_delivery.TabIndex = 41
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Red
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(191, 406)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(300, 42)
        Me.btn_save.TabIndex = 40
        Me.btn_save.Text = "SHIPMENT DELIVERED"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_date
        '
        Me.txt_date.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_date.CalendarTitleBackColor = System.Drawing.Color.Red
        Me.txt_date.Enabled = False
        Me.txt_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_date.Location = New System.Drawing.Point(250, 342)
        Me.txt_date.Name = "txt_date"
        Me.txt_date.Size = New System.Drawing.Size(238, 27)
        Me.txt_date.TabIndex = 39
        Me.txt_date.Value = New Date(2025, 5, 17, 19, 35, 57, 0)
        '
        'txt_retailer
        '
        Me.txt_retailer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_retailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_retailer.Location = New System.Drawing.Point(250, 291)
        Me.txt_retailer.Name = "txt_retailer"
        Me.txt_retailer.ReadOnly = True
        Me.txt_retailer.Size = New System.Drawing.Size(238, 27)
        Me.txt_retailer.TabIndex = 36
        '
        'label_retailer
        '
        Me.label_retailer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_retailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_retailer.Location = New System.Drawing.Point(44, 294)
        Me.label_retailer.Name = "label_retailer"
        Me.label_retailer.Size = New System.Drawing.Size(150, 20)
        Me.label_retailer.TabIndex = 35
        Me.label_retailer.Text = "Retailer ID :"
        Me.label_retailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'label_date
        '
        Me.label_date.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_date.Location = New System.Drawing.Point(47, 347)
        Me.label_date.Name = "label_date"
        Me.label_date.Size = New System.Drawing.Size(150, 20)
        Me.label_date.TabIndex = 32
        Me.label_date.Text = "Arrival Date :"
        Me.label_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_shipmentID
        '
        Me.txt_shipmentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_shipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shipmentID.Location = New System.Drawing.Point(250, 243)
        Me.txt_shipmentID.Name = "txt_shipmentID"
        Me.txt_shipmentID.ReadOnly = True
        Me.txt_shipmentID.Size = New System.Drawing.Size(238, 27)
        Me.txt_shipmentID.TabIndex = 29
        '
        'label_shipmentID
        '
        Me.label_shipmentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_shipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_shipmentID.Location = New System.Drawing.Point(44, 250)
        Me.label_shipmentID.Name = "label_shipmentID"
        Me.label_shipmentID.Size = New System.Drawing.Size(150, 20)
        Me.label_shipmentID.TabIndex = 28
        Me.label_shipmentID.Text = "Shipment ID :"
        Me.label_shipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'form_manageDeliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 553)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_error1)
        Me.Controls.Add(Me.data_delivery)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_date)
        Me.Controls.Add(Me.txt_retailer)
        Me.Controls.Add(Me.label_retailer)
        Me.Controls.Add(Me.label_date)
        Me.Controls.Add(Me.txt_shipmentID)
        Me.Controls.Add(Me.label_shipmentID)
        Me.Name = "form_manageDeliveries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Ddeliveries"
        CType(Me.data_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents label_error1 As System.Windows.Forms.Label
    Friend WithEvents data_delivery As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_retailer As System.Windows.Forms.TextBox
    Friend WithEvents label_retailer As System.Windows.Forms.Label
    Friend WithEvents label_date As System.Windows.Forms.Label
    Friend WithEvents txt_shipmentID As System.Windows.Forms.TextBox
    Friend WithEvents label_shipmentID As System.Windows.Forms.Label
End Class
