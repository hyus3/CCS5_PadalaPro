<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_hr
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
        Me.label_employees = New System.Windows.Forms.Label()
        Me.data_employees = New System.Windows.Forms.DataGridView()
        Me.btn_manageEmployees = New System.Windows.Forms.Button()
        Me.label_title = New System.Windows.Forms.Label()
        CType(Me.data_employees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_employees
        '
        Me.label_employees.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label_employees.AutoSize = True
        Me.label_employees.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_employees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label_employees.Location = New System.Drawing.Point(12, 121)
        Me.label_employees.Name = "label_employees"
        Me.label_employees.Size = New System.Drawing.Size(216, 32)
        Me.label_employees.TabIndex = 31
        Me.label_employees.Text = "EMPLOYEES :"
        '
        'data_employees
        '
        Me.data_employees.AllowUserToAddRows = False
        Me.data_employees.AllowUserToDeleteRows = False
        Me.data_employees.AllowUserToResizeColumns = False
        Me.data_employees.AllowUserToResizeRows = False
        Me.data_employees.Anchor = System.Windows.Forms.AnchorStyles.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_employees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.data_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = "NULL"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_employees.DefaultCellStyle = DataGridViewCellStyle2
        Me.data_employees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_employees.Location = New System.Drawing.Point(201, 156)
        Me.data_employees.Name = "data_employees"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_employees.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.data_employees.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_employees.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.data_employees.RowTemplate.Height = 24
        Me.data_employees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_employees.ShowCellErrors = False
        Me.data_employees.ShowCellToolTips = False
        Me.data_employees.ShowEditingIcon = False
        Me.data_employees.ShowRowErrors = False
        Me.data_employees.Size = New System.Drawing.Size(240, 333)
        Me.data_employees.TabIndex = 30
        '
        'btn_manageEmployees
        '
        Me.btn_manageEmployees.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_manageEmployees.AutoSize = True
        Me.btn_manageEmployees.BackColor = System.Drawing.Color.Red
        Me.btn_manageEmployees.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manageEmployees.ForeColor = System.Drawing.Color.White
        Me.btn_manageEmployees.Location = New System.Drawing.Point(12, 495)
        Me.btn_manageEmployees.Name = "btn_manageEmployees"
        Me.btn_manageEmployees.Size = New System.Drawing.Size(296, 67)
        Me.btn_manageEmployees.TabIndex = 29
        Me.btn_manageEmployees.Text = "MANAGE EMPLOYEES"
        Me.btn_manageEmployees.UseVisualStyleBackColor = False
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(12, 16)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 28
        Me.label_title.Text = "Padala Pro"
        '
        'form_hr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(532, 578)
        Me.Controls.Add(Me.label_employees)
        Me.Controls.Add(Me.data_employees)
        Me.Controls.Add(Me.btn_manageEmployees)
        Me.Controls.Add(Me.label_title)
        Me.Name = "form_hr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR"
        CType(Me.data_employees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_employees As System.Windows.Forms.Label
    Friend WithEvents data_employees As System.Windows.Forms.DataGridView
    Friend WithEvents btn_manageEmployees As System.Windows.Forms.Button
    Friend WithEvents label_title As System.Windows.Forms.Label
End Class
