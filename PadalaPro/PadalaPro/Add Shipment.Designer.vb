<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_addShipment
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
        Me.label_error2 = New System.Windows.Forms.Label()
        Me.label_title = New System.Windows.Forms.Label()
        Me.label_error1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_retailer = New System.Windows.Forms.TextBox()
        Me.label_retailer = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.label_qty = New System.Windows.Forms.Label()
        Me.txt_shipmentID = New System.Windows.Forms.TextBox()
        Me.label_shipmentID = New System.Windows.Forms.Label()
        Me.data_retailer = New System.Windows.Forms.DataGridView()
        CType(Me.data_retailer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_error2
        '
        Me.label_error2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_error2.AutoSize = True
        Me.label_error2.ForeColor = System.Drawing.Color.Red
        Me.label_error2.Location = New System.Drawing.Point(431, 282)
        Me.label_error2.Name = "label_error2"
        Me.label_error2.Size = New System.Drawing.Size(101, 17)
        Me.label_error2.TabIndex = 65
        Me.label_error2.Text = "*errormessage"
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(207, 53)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 63
        Me.label_title.Text = "Padala Pro"
        '
        'label_error1
        '
        Me.label_error1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_error1.AutoSize = True
        Me.label_error1.ForeColor = System.Drawing.Color.Red
        Me.label_error1.Location = New System.Drawing.Point(431, 231)
        Me.label_error1.Name = "label_error1"
        Me.label_error1.Size = New System.Drawing.Size(101, 17)
        Me.label_error1.TabIndex = 62
        Me.label_error1.Text = "*errormessage"
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Red
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(434, 395)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(238, 42)
        Me.btn_save.TabIndex = 60
        Me.btn_save.Text = "ADD SHIPMENT"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'txt_retailer
        '
        Me.txt_retailer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_retailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_retailer.Location = New System.Drawing.Point(434, 302)
        Me.txt_retailer.Name = "txt_retailer"
        Me.txt_retailer.ReadOnly = True
        Me.txt_retailer.Size = New System.Drawing.Size(238, 27)
        Me.txt_retailer.TabIndex = 56
        '
        'label_retailer
        '
        Me.label_retailer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_retailer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_retailer.Location = New System.Drawing.Point(228, 307)
        Me.label_retailer.Name = "label_retailer"
        Me.label_retailer.Size = New System.Drawing.Size(150, 20)
        Me.label_retailer.TabIndex = 55
        Me.label_retailer.Text = "Retailer ID :"
        Me.label_retailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_qty
        '
        Me.txt_qty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(434, 251)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(238, 27)
        Me.txt_qty.TabIndex = 54
        '
        'label_qty
        '
        Me.label_qty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_qty.Location = New System.Drawing.Point(228, 255)
        Me.label_qty.Name = "label_qty"
        Me.label_qty.Size = New System.Drawing.Size(150, 20)
        Me.label_qty.TabIndex = 53
        Me.label_qty.Text = "Quantity :"
        Me.label_qty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_shipmentID
        '
        Me.txt_shipmentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txt_shipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_shipmentID.Location = New System.Drawing.Point(434, 200)
        Me.txt_shipmentID.Name = "txt_shipmentID"
        Me.txt_shipmentID.ReadOnly = True
        Me.txt_shipmentID.Size = New System.Drawing.Size(238, 27)
        Me.txt_shipmentID.TabIndex = 52
        '
        'label_shipmentID
        '
        Me.label_shipmentID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.label_shipmentID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_shipmentID.Location = New System.Drawing.Point(228, 203)
        Me.label_shipmentID.Name = "label_shipmentID"
        Me.label_shipmentID.Size = New System.Drawing.Size(150, 20)
        Me.label_shipmentID.TabIndex = 51
        Me.label_shipmentID.Text = "Shipment ID :"
        Me.label_shipmentID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'data_retailer
        '
        Me.data_retailer.AllowUserToAddRows = False
        Me.data_retailer.AllowUserToDeleteRows = False
        Me.data_retailer.AllowUserToResizeColumns = False
        Me.data_retailer.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.NullValue = "NULL"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_retailer.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_retailer.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.data_retailer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.data_retailer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.data_retailer.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_retailer.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.data_retailer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_retailer.DefaultCellStyle = DataGridViewCellStyle3
        Me.data_retailer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_retailer.Location = New System.Drawing.Point(642, 44)
        Me.data_retailer.Name = "data_retailer"
        Me.data_retailer.RowHeadersVisible = False
        Me.data_retailer.RowHeadersWidth = 40
        Me.data_retailer.RowTemplate.Height = 24
        Me.data_retailer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_retailer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_retailer.ShowCellErrors = False
        Me.data_retailer.ShowCellToolTips = False
        Me.data_retailer.ShowEditingIcon = False
        Me.data_retailer.ShowRowErrors = False
        Me.data_retailer.Size = New System.Drawing.Size(30, 150)
        Me.data_retailer.TabIndex = 67
        '
        'form_addShipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 570)
        Me.Controls.Add(Me.data_retailer)
        Me.Controls.Add(Me.label_error2)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_error1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_retailer)
        Me.Controls.Add(Me.label_retailer)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.label_qty)
        Me.Controls.Add(Me.txt_shipmentID)
        Me.Controls.Add(Me.label_shipmentID)
        Me.Name = "form_addShipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Shipment"
        CType(Me.data_retailer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_error2 As System.Windows.Forms.Label
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents label_error1 As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_retailer As System.Windows.Forms.TextBox
    Friend WithEvents label_retailer As System.Windows.Forms.Label
    Friend WithEvents txt_qty As System.Windows.Forms.TextBox
    Friend WithEvents label_qty As System.Windows.Forms.Label
    Friend WithEvents txt_shipmentID As System.Windows.Forms.TextBox
    Friend WithEvents label_shipmentID As System.Windows.Forms.Label
    Friend WithEvents data_retailer As System.Windows.Forms.DataGridView
End Class
