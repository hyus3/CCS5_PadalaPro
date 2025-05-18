<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_driver
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label_deliveries = New System.Windows.Forms.Label()
        Me.data_deliveries = New System.Windows.Forms.DataGridView()
        Me.btn_manageDeliveries = New System.Windows.Forms.Button()
        Me.label_title = New System.Windows.Forms.Label()
        CType(Me.data_deliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_deliveries
        '
        Me.label_deliveries.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label_deliveries.AutoSize = True
        Me.label_deliveries.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_deliveries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label_deliveries.Location = New System.Drawing.Point(12, 163)
        Me.label_deliveries.Name = "label_deliveries"
        Me.label_deliveries.Size = New System.Drawing.Size(207, 32)
        Me.label_deliveries.TabIndex = 27
        Me.label_deliveries.Text = "DELIVERIES :"
        '
        'data_deliveries
        '
        Me.data_deliveries.AllowUserToAddRows = False
        Me.data_deliveries.AllowUserToDeleteRows = False
        Me.data_deliveries.AllowUserToResizeColumns = False
        Me.data_deliveries.AllowUserToResizeRows = False
        Me.data_deliveries.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_deliveries.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.data_deliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = "NULL"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_deliveries.DefaultCellStyle = DataGridViewCellStyle10
        Me.data_deliveries.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_deliveries.Location = New System.Drawing.Point(121, 198)
        Me.data_deliveries.Name = "data_deliveries"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_deliveries.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.data_deliveries.RowHeadersVisible = False
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_deliveries.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.data_deliveries.RowTemplate.Height = 24
        Me.data_deliveries.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_deliveries.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_deliveries.ShowCellErrors = False
        Me.data_deliveries.ShowCellToolTips = False
        Me.data_deliveries.ShowEditingIcon = False
        Me.data_deliveries.ShowRowErrors = False
        Me.data_deliveries.Size = New System.Drawing.Size(240, 333)
        Me.data_deliveries.TabIndex = 26
        '
        'btn_manageDeliveries
        '
        Me.btn_manageDeliveries.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_manageDeliveries.AutoSize = True
        Me.btn_manageDeliveries.BackColor = System.Drawing.Color.Red
        Me.btn_manageDeliveries.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageDeliveries.ForeColor = System.Drawing.Color.White
        Me.btn_manageDeliveries.Location = New System.Drawing.Point(12, 537)
        Me.btn_manageDeliveries.Name = "btn_manageDeliveries"
        Me.btn_manageDeliveries.Size = New System.Drawing.Size(296, 67)
        Me.btn_manageDeliveries.TabIndex = 25
        Me.btn_manageDeliveries.Text = "MANAGE DELIVERIES"
        Me.btn_manageDeliveries.UseVisualStyleBackColor = False
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(12, 58)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 24
        Me.label_title.Text = "Padala Pro"
        '
        'form_driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 662)
        Me.Controls.Add(Me.label_deliveries)
        Me.Controls.Add(Me.data_deliveries)
        Me.Controls.Add(Me.btn_manageDeliveries)
        Me.Controls.Add(Me.label_title)
        Me.Name = "form_driver"
        Me.Text = "Driver"
        CType(Me.data_deliveries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_deliveries As System.Windows.Forms.Label
    Friend WithEvents data_deliveries As System.Windows.Forms.DataGridView
    Friend WithEvents btn_manageDeliveries As System.Windows.Forms.Button
    Friend WithEvents label_title As System.Windows.Forms.Label
End Class
