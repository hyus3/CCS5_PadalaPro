<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_manageEmployees
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.label_title = New System.Windows.Forms.Label()
        Me.label_error1 = New System.Windows.Forms.Label()
        Me.data_employee = New System.Windows.Forms.DataGridView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.label_type = New System.Windows.Forms.Label()
        Me.txt_mi = New System.Windows.Forms.TextBox()
        Me.label_mi = New System.Windows.Forms.Label()
        Me.txt_fname = New System.Windows.Forms.TextBox()
        Me.label_fName = New System.Windows.Forms.Label()
        Me.txt_lname = New System.Windows.Forms.TextBox()
        Me.label_lName = New System.Windows.Forms.Label()
        Me.txt_empID = New System.Windows.Forms.TextBox()
        Me.label_empID = New System.Windows.Forms.Label()
        Me.radio_remove = New System.Windows.Forms.RadioButton()
        Me.radio_add = New System.Windows.Forms.RadioButton()
        Me.label_error3 = New System.Windows.Forms.Label()
        Me.label_error2 = New System.Windows.Forms.Label()
        Me.label_error4 = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.ComboBox()
        CType(Me.data_employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_title.AutoSize = True
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(164, 32)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(284, 60)
        Me.label_title.TabIndex = 44
        Me.label_title.Text = "Padala Pro"
        '
        'label_error1
        '
        Me.label_error1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error1.AutoSize = True
        Me.label_error1.ForeColor = System.Drawing.Color.Red
        Me.label_error1.Location = New System.Drawing.Point(370, 255)
        Me.label_error1.Name = "label_error1"
        Me.label_error1.Size = New System.Drawing.Size(101, 17)
        Me.label_error1.TabIndex = 43
        Me.label_error1.Text = "*errormessage"
        '
        'data_employee
        '
        Me.data_employee.AllowUserToAddRows = False
        Me.data_employee.AllowUserToDeleteRows = False
        Me.data_employee.AllowUserToResizeColumns = False
        Me.data_employee.AllowUserToResizeRows = False
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.NullValue = "NULL"
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.data_employee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.data_employee.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.data_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.data_employee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.data_employee.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.data_employee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.data_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_employee.DefaultCellStyle = DataGridViewCellStyle15
        Me.data_employee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.data_employee.Location = New System.Drawing.Point(584, 32)
        Me.data_employee.Name = "data_employee"
        Me.data_employee.RowHeadersVisible = False
        Me.data_employee.RowHeadersWidth = 40
        Me.data_employee.RowTemplate.Height = 24
        Me.data_employee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_employee.ShowCellErrors = False
        Me.data_employee.ShowCellToolTips = False
        Me.data_employee.ShowEditingIcon = False
        Me.data_employee.ShowRowErrors = False
        Me.data_employee.Size = New System.Drawing.Size(30, 150)
        Me.data_employee.TabIndex = 41
        '
        'btn_save
        '
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_save.AutoSize = True
        Me.btn_save.BackColor = System.Drawing.Color.Red
        Me.btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.Location = New System.Drawing.Point(414, 601)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(200, 42)
        Me.btn_save.TabIndex = 40
        Me.btn_save.Text = "RECEIVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'label_type
        '
        Me.label_type.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_type.Location = New System.Drawing.Point(167, 434)
        Me.label_type.Name = "label_type"
        Me.label_type.Size = New System.Drawing.Size(150, 19)
        Me.label_type.TabIndex = 37
        Me.label_type.Text = "Employee Type :"
        Me.label_type.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_mi
        '
        Me.txt_mi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mi.Location = New System.Drawing.Point(373, 377)
        Me.txt_mi.MaxLength = 1
        Me.txt_mi.Name = "txt_mi"
        Me.txt_mi.Size = New System.Drawing.Size(238, 27)
        Me.txt_mi.TabIndex = 36
        '
        'label_mi
        '
        Me.label_mi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_mi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_mi.Location = New System.Drawing.Point(167, 383)
        Me.label_mi.Name = "label_mi"
        Me.label_mi.Size = New System.Drawing.Size(150, 19)
        Me.label_mi.TabIndex = 35
        Me.label_mi.Text = "M.I. :"
        Me.label_mi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_fname
        '
        Me.txt_fname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fname.Location = New System.Drawing.Point(373, 326)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Size = New System.Drawing.Size(238, 27)
        Me.txt_fname.TabIndex = 34
        '
        'label_fName
        '
        Me.label_fName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_fName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fName.Location = New System.Drawing.Point(167, 331)
        Me.label_fName.Name = "label_fName"
        Me.label_fName.Size = New System.Drawing.Size(150, 20)
        Me.label_fName.TabIndex = 33
        Me.label_fName.Text = "First Name :"
        Me.label_fName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_lname
        '
        Me.txt_lname.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lname.Location = New System.Drawing.Point(373, 275)
        Me.txt_lname.Name = "txt_lname"
        Me.txt_lname.Size = New System.Drawing.Size(238, 27)
        Me.txt_lname.TabIndex = 31
        '
        'label_lName
        '
        Me.label_lName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_lName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_lName.Location = New System.Drawing.Point(167, 279)
        Me.label_lName.Name = "label_lName"
        Me.label_lName.Size = New System.Drawing.Size(150, 20)
        Me.label_lName.TabIndex = 30
        Me.label_lName.Text = "Last Name :"
        Me.label_lName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_empID
        '
        Me.txt_empID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empID.Location = New System.Drawing.Point(373, 224)
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.ReadOnly = True
        Me.txt_empID.Size = New System.Drawing.Size(238, 27)
        Me.txt_empID.TabIndex = 29
        '
        'label_empID
        '
        Me.label_empID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_empID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_empID.Location = New System.Drawing.Point(167, 227)
        Me.label_empID.Name = "label_empID"
        Me.label_empID.Size = New System.Drawing.Size(150, 20)
        Me.label_empID.TabIndex = 28
        Me.label_empID.Text = "Employee ID :"
        Me.label_empID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radio_remove
        '
        Me.radio_remove.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_remove.AutoSize = True
        Me.radio_remove.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_remove.Location = New System.Drawing.Point(174, 158)
        Me.radio_remove.Name = "radio_remove"
        Me.radio_remove.Size = New System.Drawing.Size(169, 24)
        Me.radio_remove.TabIndex = 27
        Me.radio_remove.Text = "Remove Employee"
        Me.radio_remove.UseVisualStyleBackColor = True
        '
        'radio_add
        '
        Me.radio_add.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radio_add.AutoSize = True
        Me.radio_add.Checked = True
        Me.radio_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radio_add.Location = New System.Drawing.Point(174, 128)
        Me.radio_add.Name = "radio_add"
        Me.radio_add.Size = New System.Drawing.Size(137, 24)
        Me.radio_add.TabIndex = 26
        Me.radio_add.TabStop = True
        Me.radio_add.Text = "Add Employee"
        Me.radio_add.UseVisualStyleBackColor = True
        '
        'label_error3
        '
        Me.label_error3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error3.AutoSize = True
        Me.label_error3.ForeColor = System.Drawing.Color.Red
        Me.label_error3.Location = New System.Drawing.Point(370, 357)
        Me.label_error3.Name = "label_error3"
        Me.label_error3.Size = New System.Drawing.Size(101, 17)
        Me.label_error3.TabIndex = 45
        Me.label_error3.Text = "*errormessage"
        '
        'label_error2
        '
        Me.label_error2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error2.AutoSize = True
        Me.label_error2.ForeColor = System.Drawing.Color.Red
        Me.label_error2.Location = New System.Drawing.Point(370, 306)
        Me.label_error2.Name = "label_error2"
        Me.label_error2.Size = New System.Drawing.Size(101, 17)
        Me.label_error2.TabIndex = 46
        Me.label_error2.Text = "*errormessage"
        '
        'label_error4
        '
        Me.label_error4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_error4.AutoSize = True
        Me.label_error4.ForeColor = System.Drawing.Color.Red
        Me.label_error4.Location = New System.Drawing.Point(370, 408)
        Me.label_error4.Name = "label_error4"
        Me.label_error4.Size = New System.Drawing.Size(101, 17)
        Me.label_error4.TabIndex = 47
        Me.label_error4.Text = "*errormessage"
        '
        'txt_type
        '
        Me.txt_type.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_type.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_type.FormattingEnabled = True
        Me.txt_type.Location = New System.Drawing.Point(373, 430)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(238, 28)
        Me.txt_type.TabIndex = 48
        Me.txt_type.Text = "Type..."
        '
        'form_manageEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 674)
        Me.Controls.Add(Me.txt_type)
        Me.Controls.Add(Me.label_error4)
        Me.Controls.Add(Me.label_error2)
        Me.Controls.Add(Me.label_error3)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_error1)
        Me.Controls.Add(Me.data_employee)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.label_type)
        Me.Controls.Add(Me.txt_mi)
        Me.Controls.Add(Me.label_mi)
        Me.Controls.Add(Me.txt_fname)
        Me.Controls.Add(Me.label_fName)
        Me.Controls.Add(Me.txt_lname)
        Me.Controls.Add(Me.label_lName)
        Me.Controls.Add(Me.txt_empID)
        Me.Controls.Add(Me.label_empID)
        Me.Controls.Add(Me.radio_remove)
        Me.Controls.Add(Me.radio_add)
        Me.Name = "form_manageEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Employees"
        CType(Me.data_employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents label_error1 As System.Windows.Forms.Label
    Friend WithEvents data_employee As System.Windows.Forms.DataGridView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents label_type As System.Windows.Forms.Label
    Friend WithEvents txt_mi As System.Windows.Forms.TextBox
    Friend WithEvents label_mi As System.Windows.Forms.Label
    Friend WithEvents txt_fname As System.Windows.Forms.TextBox
    Friend WithEvents label_fName As System.Windows.Forms.Label
    Friend WithEvents txt_lname As System.Windows.Forms.TextBox
    Friend WithEvents label_lName As System.Windows.Forms.Label
    Friend WithEvents txt_empID As System.Windows.Forms.TextBox
    Friend WithEvents label_empID As System.Windows.Forms.Label
    Friend WithEvents radio_remove As System.Windows.Forms.RadioButton
    Friend WithEvents radio_add As System.Windows.Forms.RadioButton
    Friend WithEvents label_error3 As System.Windows.Forms.Label
    Friend WithEvents label_error2 As System.Windows.Forms.Label
    Friend WithEvents label_error4 As System.Windows.Forms.Label
    Friend WithEvents txt_type As System.Windows.Forms.ComboBox
End Class
