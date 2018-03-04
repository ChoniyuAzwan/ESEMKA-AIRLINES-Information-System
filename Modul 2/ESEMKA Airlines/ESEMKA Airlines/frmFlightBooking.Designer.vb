<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlightBooking
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbDestination = New System.Windows.Forms.ComboBox()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.dtpReturn = New System.Windows.Forms.DateTimePicker()
        Me.txtCustomer = New System.Windows.Forms.TextBox()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBooking = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbOrigin = New System.Windows.Forms.ComboBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdRoundTrip = New System.Windows.Forms.RadioButton()
        Me.rdOneWay = New System.Windows.Forms.RadioButton()
        Me.dgvBooking = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(411, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 26)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Flight Booking"
        '
        'cbDestination
        '
        Me.cbDestination.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDestination.ForeColor = System.Drawing.Color.Black
        Me.cbDestination.FormattingEnabled = True
        Me.cbDestination.Location = New System.Drawing.Point(162, 62)
        Me.cbDestination.Name = "cbDestination"
        Me.cbDestination.Size = New System.Drawing.Size(306, 27)
        Me.cbDestination.TabIndex = 1
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(162, 124)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(306, 26)
        Me.dtpDeparture.TabIndex = 4
        '
        'dtpReturn
        '
        Me.dtpReturn.Location = New System.Drawing.Point(651, 30)
        Me.dtpReturn.Name = "dtpReturn"
        Me.dtpReturn.Size = New System.Drawing.Size(306, 26)
        Me.dtpReturn.TabIndex = 5
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCustomer.ForeColor = System.Drawing.Color.Black
        Me.txtCustomer.Location = New System.Drawing.Point(651, 92)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(306, 26)
        Me.txtCustomer.TabIndex = 7
        '
        'txtTicket
        '
        Me.txtTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTicket.ForeColor = System.Drawing.Color.Black
        Me.txtTicket.Location = New System.Drawing.Point(651, 60)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.Size = New System.Drawing.Size(306, 26)
        Me.txtTicket.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(21, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Origin of Flight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Destination of Flight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(21, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Departure"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(510, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Return"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(510, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 19)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Many Customer"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(510, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Many Tickets"
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(917, 241)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnBooking
        '
        Me.btnBooking.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnBooking.FlatAppearance.BorderSize = 0
        Me.btnBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBooking.ForeColor = System.Drawing.Color.White
        Me.btnBooking.Location = New System.Drawing.Point(804, 241)
        Me.btnBooking.Name = "btnBooking"
        Me.btnBooking.Size = New System.Drawing.Size(75, 30)
        Me.btnBooking.TabIndex = 10
        Me.btnBooking.Text = "Booking"
        Me.btnBooking.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Type of Flight"
        '
        'cbOrigin
        '
        Me.cbOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbOrigin.ForeColor = System.Drawing.Color.Black
        Me.cbOrigin.FormattingEnabled = True
        Me.cbOrigin.Location = New System.Drawing.Point(162, 30)
        Me.cbOrigin.Name = "cbOrigin"
        Me.cbOrigin.Size = New System.Drawing.Size(306, 27)
        Me.cbOrigin.TabIndex = 0
        '
        'btnCheck
        '
        Me.btnCheck.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCheck.FlatAppearance.BorderSize = 0
        Me.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheck.ForeColor = System.Drawing.Color.White
        Me.btnCheck.Location = New System.Drawing.Point(651, 135)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 30)
        Me.btnCheck.TabIndex = 8
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdRoundTrip)
        Me.GroupBox1.Controls.Add(Me.rdOneWay)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnCheck)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cbOrigin)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbDestination)
        Me.GroupBox1.Controls.Add(Me.txtTicket)
        Me.GroupBox1.Controls.Add(Me.dtpDeparture)
        Me.GroupBox1.Controls.Add(Me.txtCustomer)
        Me.GroupBox1.Controls.Add(Me.dtpReturn)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(980, 181)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Flight Schedule"
        '
        'rdRoundTrip
        '
        Me.rdRoundTrip.AutoSize = True
        Me.rdRoundTrip.ForeColor = System.Drawing.Color.Black
        Me.rdRoundTrip.Location = New System.Drawing.Point(302, 95)
        Me.rdRoundTrip.Name = "rdRoundTrip"
        Me.rdRoundTrip.Size = New System.Drawing.Size(95, 23)
        Me.rdRoundTrip.TabIndex = 79
        Me.rdRoundTrip.Text = "Round Trip"
        Me.rdRoundTrip.UseVisualStyleBackColor = True
        '
        'rdOneWay
        '
        Me.rdOneWay.AutoSize = True
        Me.rdOneWay.Checked = True
        Me.rdOneWay.ForeColor = System.Drawing.Color.Black
        Me.rdOneWay.Location = New System.Drawing.Point(162, 95)
        Me.rdOneWay.Name = "rdOneWay"
        Me.rdOneWay.Size = New System.Drawing.Size(85, 23)
        Me.rdOneWay.TabIndex = 78
        Me.rdOneWay.TabStop = True
        Me.rdOneWay.Text = "One Way"
        Me.rdOneWay.UseVisualStyleBackColor = True
        '
        'dgvBooking
        '
        Me.dgvBooking.AllowUserToAddRows = False
        Me.dgvBooking.AllowUserToDeleteRows = False
        Me.dgvBooking.AllowUserToResizeRows = False
        Me.dgvBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBooking.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvBooking.BackgroundColor = System.Drawing.Color.White
        Me.dgvBooking.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooking.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBooking.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooking.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvBooking.Location = New System.Drawing.Point(0, 294)
        Me.dgvBooking.Name = "dgvBooking"
        Me.dgvBooking.ReadOnly = True
        Me.dgvBooking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooking.Size = New System.Drawing.Size(1008, 268)
        Me.dgvBooking.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(308, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(377, 21)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Please select the flight schedulling of the available"
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnShow.FlatAppearance.BorderSize = 0
        Me.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShow.ForeColor = System.Drawing.Color.White
        Me.btnShow.Location = New System.Drawing.Point(12, 241)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(175, 30)
        Me.btnShow.TabIndex = 37
        Me.btnShow.Text = "Show All Flight Schedule"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'frmFlightBooking
        '
        Me.AcceptButton = Me.btnCheck
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(1008, 562)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvBooking)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnBooking)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmFlightBooking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESEMKA Airlines"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvBooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbDestination As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpReturn As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents txtTicket As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnBooking As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbOrigin As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvBooking As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents rdRoundTrip As System.Windows.Forms.RadioButton
    Friend WithEvents rdOneWay As System.Windows.Forms.RadioButton
End Class
