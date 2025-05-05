<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.manageEmp_btn = New System.Windows.Forms.Button()
        Me.ib_btn = New System.Windows.Forms.Button()
        Me.vs_btn = New System.Windows.Forms.Button()
        Me.ob_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'manageEmp_btn
        '
        Me.manageEmp_btn.Location = New System.Drawing.Point(43, 367)
        Me.manageEmp_btn.Name = "manageEmp_btn"
        Me.manageEmp_btn.Size = New System.Drawing.Size(153, 58)
        Me.manageEmp_btn.TabIndex = 0
        Me.manageEmp_btn.Text = "Manage Employees"
        Me.manageEmp_btn.UseVisualStyleBackColor = True
        '
        'ib_btn
        '
        Me.ib_btn.Location = New System.Drawing.Point(43, 53)
        Me.ib_btn.Name = "ib_btn"
        Me.ib_btn.Size = New System.Drawing.Size(153, 58)
        Me.ib_btn.TabIndex = 2
        Me.ib_btn.Text = "Add Inbound"
        Me.ib_btn.UseVisualStyleBackColor = True
        '
        'vs_btn
        '
        Me.vs_btn.Location = New System.Drawing.Point(43, 259)
        Me.vs_btn.Name = "vs_btn"
        Me.vs_btn.Size = New System.Drawing.Size(153, 58)
        Me.vs_btn.TabIndex = 3
        Me.vs_btn.Text = "View Shipment"
        Me.vs_btn.UseVisualStyleBackColor = True
        '
        'ob_btn
        '
        Me.ob_btn.Location = New System.Drawing.Point(43, 159)
        Me.ob_btn.Name = "ob_btn"
        Me.ob_btn.Size = New System.Drawing.Size(153, 58)
        Me.ob_btn.TabIndex = 4
        Me.ob_btn.Text = "Add Outbound"
        Me.ob_btn.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 490)
        Me.Controls.Add(Me.ob_btn)
        Me.Controls.Add(Me.vs_btn)
        Me.Controls.Add(Me.ib_btn)
        Me.Controls.Add(Me.manageEmp_btn)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents manageEmp_btn As System.Windows.Forms.Button
    Friend WithEvents ib_btn As System.Windows.Forms.Button
    Friend WithEvents vs_btn As System.Windows.Forms.Button
    Friend WithEvents ob_btn As System.Windows.Forms.Button

End Class
