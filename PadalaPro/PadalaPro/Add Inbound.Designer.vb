<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class t
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
        Me.save_ib_btn = New System.Windows.Forms.Button()
        Me.shiment_id = New System.Windows.Forms.TextBox()
        Me.arrival_date = New System.Windows.Forms.TextBox()
        Me.qty = New System.Windows.Forms.TextBox()
        Me.receiver_name = New System.Windows.Forms.TextBox()
        Me.receiver_addr = New System.Windows.Forms.TextBox()
        Me.r_clerk_id = New System.Windows.Forms.TextBox()
        Me.driver_id = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.item = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'save_ib_btn
        '
        Me.save_ib_btn.Location = New System.Drawing.Point(560, 491)
        Me.save_ib_btn.Name = "save_ib_btn"
        Me.save_ib_btn.Size = New System.Drawing.Size(139, 41)
        Me.save_ib_btn.TabIndex = 0
        Me.save_ib_btn.Text = "Save Inbound"
        Me.save_ib_btn.UseVisualStyleBackColor = True
        '
        'shiment_id
        '
        Me.shiment_id.Location = New System.Drawing.Point(194, 42)
        Me.shiment_id.Name = "shiment_id"
        Me.shiment_id.Size = New System.Drawing.Size(229, 22)
        Me.shiment_id.TabIndex = 1
        '
        'arrival_date
        '
        Me.arrival_date.Location = New System.Drawing.Point(194, 78)
        Me.arrival_date.Name = "arrival_date"
        Me.arrival_date.Size = New System.Drawing.Size(229, 22)
        Me.arrival_date.TabIndex = 2
        '
        'qty
        '
        Me.qty.Location = New System.Drawing.Point(194, 115)
        Me.qty.Name = "qty"
        Me.qty.Size = New System.Drawing.Size(229, 22)
        Me.qty.TabIndex = 3
        '
        'receiver_name
        '
        Me.receiver_name.Location = New System.Drawing.Point(194, 155)
        Me.receiver_name.Name = "receiver_name"
        Me.receiver_name.Size = New System.Drawing.Size(229, 22)
        Me.receiver_name.TabIndex = 4
        '
        'receiver_addr
        '
        Me.receiver_addr.Location = New System.Drawing.Point(194, 191)
        Me.receiver_addr.Name = "receiver_addr"
        Me.receiver_addr.Size = New System.Drawing.Size(229, 22)
        Me.receiver_addr.TabIndex = 5
        '
        'r_clerk_id
        '
        Me.r_clerk_id.Location = New System.Drawing.Point(194, 231)
        Me.r_clerk_id.Name = "r_clerk_id"
        Me.r_clerk_id.Size = New System.Drawing.Size(229, 22)
        Me.r_clerk_id.TabIndex = 6
        '
        'driver_id
        '
        Me.driver_id.Location = New System.Drawing.Point(194, 274)
        Me.driver_id.Name = "driver_id"
        Me.driver_id.Size = New System.Drawing.Size(229, 22)
        Me.driver_id.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Shipment ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Arrival Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Quantity :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Receiver Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Receiver Address :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(128, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cerk ID:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Driver ID:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(148, 318)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Item:"
        '
        'item
        '
        Me.item.Location = New System.Drawing.Point(194, 315)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(229, 22)
        Me.item.TabIndex = 16
        '
        't
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 567)
        Me.Controls.Add(Me.item)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.driver_id)
        Me.Controls.Add(Me.r_clerk_id)
        Me.Controls.Add(Me.receiver_addr)
        Me.Controls.Add(Me.receiver_name)
        Me.Controls.Add(Me.qty)
        Me.Controls.Add(Me.arrival_date)
        Me.Controls.Add(Me.shiment_id)
        Me.Controls.Add(Me.save_ib_btn)
        Me.Name = "t"
        Me.Text = "Save Inbound"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents save_ib_btn As System.Windows.Forms.Button
    Friend WithEvents shiment_id As System.Windows.Forms.TextBox
    Friend WithEvents arrival_date As System.Windows.Forms.TextBox
    Friend WithEvents qty As System.Windows.Forms.TextBox
    Friend WithEvents receiver_name As System.Windows.Forms.TextBox
    Friend WithEvents receiver_addr As System.Windows.Forms.TextBox
    Friend WithEvents r_clerk_id As System.Windows.Forms.TextBox
    Friend WithEvents driver_id As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents item As System.Windows.Forms.TextBox
End Class
