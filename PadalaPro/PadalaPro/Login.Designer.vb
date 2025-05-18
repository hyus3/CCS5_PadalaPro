<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Login
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
        Me.txt_empID = New System.Windows.Forms.TextBox()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.label_empID = New System.Windows.Forms.Label()
        Me.label_title = New System.Windows.Forms.Label()
        Me.label_invalidInput = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txt_empID
        '
        Me.txt_empID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_empID.CausesValidation = False
        Me.txt_empID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_empID.Location = New System.Drawing.Point(200, 292)
        Me.txt_empID.MaxLength = 5
        Me.txt_empID.Name = "txt_empID"
        Me.txt_empID.Size = New System.Drawing.Size(168, 27)
        Me.txt_empID.TabIndex = 0
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_login.BackColor = System.Drawing.Color.Red
        Me.btn_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(68, 337)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(300, 42)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "LOG IN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'label_empID
        '
        Me.label_empID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_empID.AutoSize = True
        Me.label_empID.BackColor = System.Drawing.Color.Transparent
        Me.label_empID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_empID.Location = New System.Drawing.Point(64, 294)
        Me.label_empID.Name = "label_empID"
        Me.label_empID.Size = New System.Drawing.Size(114, 20)
        Me.label_empID.TabIndex = 2
        Me.label_empID.Text = "Employee ID :"
        '
        'label_title
        '
        Me.label_title.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_title.BackColor = System.Drawing.Color.White
        Me.label_title.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.label_title.Font = New System.Drawing.Font("Helvetica", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.ForeColor = System.Drawing.Color.Red
        Me.label_title.Location = New System.Drawing.Point(12, 72)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(408, 60)
        Me.label_title.TabIndex = 3
        Me.label_title.Text = "Padala Pro"
        Me.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label_invalidInput
        '
        Me.label_invalidInput.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.label_invalidInput.AutoSize = True
        Me.label_invalidInput.ForeColor = System.Drawing.Color.Red
        Me.label_invalidInput.Location = New System.Drawing.Point(197, 272)
        Me.label_invalidInput.Name = "label_invalidInput"
        Me.label_invalidInput.Size = New System.Drawing.Size(101, 17)
        Me.label_invalidInput.TabIndex = 4
        Me.label_invalidInput.Text = "*errormessage"
        '
        'form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(432, 503)
        Me.Controls.Add(Me.label_invalidInput)
        Me.Controls.Add(Me.label_title)
        Me.Controls.Add(Me.label_empID)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_empID)
        Me.MaximumSize = New System.Drawing.Size(450, 550)
        Me.Name = "form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_empID As System.Windows.Forms.TextBox
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents label_empID As System.Windows.Forms.Label
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents label_invalidInput As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
