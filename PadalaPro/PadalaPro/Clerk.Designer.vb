<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_clerk
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label_title = New System.Windows.Forms.Label()
        Me.btn_manageShipments = New System.Windows.Forms.Button()
        Me.data_shipment = New System.Windows.Forms.DataGridView()
        Me.label_shipments = New System.Windows.Forms.Label()
        Me.btn_addShipment = New System.Windows.Forms.Button()
        CType(Me.data_shipment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(12, 38)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 20
        Me.label_title.Text = "Padala Pro"
        '
        'btn_manageShipments
        '
        Me.btn_manageShipments.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_manageShipments.AutoSize = True
        Me.btn_manageShipments.BackColor = System.Drawing.Color.Red
        Me.btn_manageShipments.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageShipments.ForeColor = System.Drawing.Color.White
        Me.btn_manageShipments.Location = New System.Drawing.Point(12, 517)
        Me.btn_manageShipments.Name = "btn_manageShipments"
        Me.btn_manageShipments.Size = New System.Drawing.Size(296, 67)
        Me.btn_manageShipments.TabIndex = 21
        Me.btn_manageShipments.Text = "MANAGE SHIPMENTS"
        Me.btn_manageShipments.UseVisualStyleBackColor = False
        '
        'data_shipment
        '
        Me.data_shipment.AllowUserToAddRows = False
        Me.data_shipment.AllowUserToDeleteRows = False
        Me.data_shipment.AllowUserToResizeColumns = False
        Me.data_shipment.AllowUserToResizeRows = False
        Me.data_shipment.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_shipment.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.data_shipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = "NULL"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_shipment.DefaultCellStyle = DataGridViewCellStyle6
        Me.data_shipment.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_shipment.Location = New System.Drawing.Point(256, 178)
        Me.data_shipment.Name = "data_shipment"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_shipment.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.data_shipment.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_shipment.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.data_shipment.RowTemplate.Height = 24
        Me.data_shipment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_shipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_shipment.ShowCellErrors = False
        Me.data_shipment.ShowCellToolTips = False
        Me.data_shipment.ShowEditingIcon = False
        Me.data_shipment.ShowRowErrors = False
        Me.data_shipment.Size = New System.Drawing.Size(240, 333)
        Me.data_shipment.TabIndex = 22
        '
        'label_shipments
        '
        Me.label_shipments.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label_shipments.AutoSize = True
        Me.label_shipments.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_shipments.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label_shipments.Location = New System.Drawing.Point(6, 143)
        Me.label_shipments.Name = "label_shipments"
        Me.label_shipments.Size = New System.Drawing.Size(204, 32)
        Me.label_shipments.TabIndex = 23
        Me.label_shipments.Text = "SHIPMENTS :"
        '
        'btn_addShipment
        '
        Me.btn_addShipment.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_addShipment.AutoSize = True
        Me.btn_addShipment.BackColor = System.Drawing.Color.Red
        Me.btn_addShipment.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addShipment.ForeColor = System.Drawing.Color.White
        Me.btn_addShipment.Location = New System.Drawing.Point(314, 517)
        Me.btn_addShipment.Name = "btn_addShipment"
        Me.btn_addShipment.Size = New System.Drawing.Size(296, 67)
        Me.btn_addShipment.TabIndex = 24
        Me.btn_addShipment.Text = "ADD SHIPMENTS"
        Me.btn_addShipment.UseVisualStyleBackColor = False
        '
        'form_clerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(752, 653)
        Me.Controls.Add(Me.btn_addShipment)
        Me.Controls.Add(Me.label_shipments)
        Me.Controls.Add(Me.data_shipment)
        Me.Controls.Add(Me.btn_manageShipments)
        Me.Controls.Add(Me.label_title)
        Me.MinimumSize = New System.Drawing.Size(500, 600)
        Me.Name = "form_clerk"
        Me.Text = "Clerk"
        CType(Me.data_shipment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents btn_manageShipments As System.Windows.Forms.Button
    Friend WithEvents data_shipment As System.Windows.Forms.DataGridView
    Friend WithEvents label_shipments As System.Windows.Forms.Label
    Friend WithEvents btn_addShipment As System.Windows.Forms.Button
End Class
