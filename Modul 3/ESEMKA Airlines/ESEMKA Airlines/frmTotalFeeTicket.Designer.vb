<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTotalFeeTicket
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
        Me.cbAirplane = New System.Windows.Forms.ComboBox()
        Me.cbTrip = New System.Windows.Forms.ComboBox()
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBoarding = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtOrigin = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbAirplane
        '
        Me.cbAirplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAirplane.FormattingEnabled = True
        Me.cbAirplane.Location = New System.Drawing.Point(165, 215)
        Me.cbAirplane.Name = "cbAirplane"
        Me.cbAirplane.Size = New System.Drawing.Size(227, 21)
        Me.cbAirplane.TabIndex = 60
        '
        'cbTrip
        '
        Me.cbTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTrip.FormattingEnabled = True
        Me.cbTrip.Location = New System.Drawing.Point(165, 247)
        Me.cbTrip.Name = "cbTrip"
        Me.cbTrip.Size = New System.Drawing.Size(227, 21)
        Me.cbTrip.TabIndex = 59
        '
        'dtpArrival
        '
        Me.dtpArrival.CustomFormat = "dd/mm/yyyy hh:mm"
        Me.dtpArrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpArrival.Location = New System.Drawing.Point(165, 180)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(227, 20)
        Me.dtpArrival.TabIndex = 58
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Checked = False
        Me.dtpDeparture.CustomFormat = "dd/mm/yyyy hh:mm"
        Me.dtpDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDeparture.Location = New System.Drawing.Point(165, 148)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(227, 20)
        Me.dtpDeparture.TabIndex = 57
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(317, 353)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 35)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(218, 353)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 35)
        Me.btnOK.TabIndex = 56
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Lime
        Me.Label3.Font = New System.Drawing.Font("Copperplate Gothic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(144, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 24)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Ticket"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 314)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Boarding Room"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Flight Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 250)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Trip Point"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Airplane Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Arrival Schedule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Departure Schedule"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Flight Destination"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "flight number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "tiket number"
        '
        'txtBoarding
        '
        Me.txtBoarding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBoarding.Location = New System.Drawing.Point(165, 312)
        Me.txtBoarding.Name = "txtBoarding"
        Me.txtBoarding.Size = New System.Drawing.Size(227, 20)
        Me.txtBoarding.TabIndex = 42
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(165, 280)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(227, 20)
        Me.txtPrice.TabIndex = 41
        '
        'txtDestination
        '
        Me.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestination.Location = New System.Drawing.Point(165, 120)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(227, 20)
        Me.txtDestination.TabIndex = 40
        '
        'txtOrigin
        '
        Me.txtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigin.Location = New System.Drawing.Point(165, 88)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(227, 20)
        Me.txtOrigin.TabIndex = 43
        '
        'txtNumber
        '
        Me.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumber.Location = New System.Drawing.Point(165, 56)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(227, 20)
        Me.txtNumber.TabIndex = 44
        '
        'frmTotalFeeTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 407)
        Me.Controls.Add(Me.cbAirplane)
        Me.Controls.Add(Me.cbTrip)
        Me.Controls.Add(Me.dtpArrival)
        Me.Controls.Add(Me.dtpDeparture)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBoarding)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtOrigin)
        Me.Controls.Add(Me.txtNumber)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTotalFeeTicket"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Total Fee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAirplane As System.Windows.Forms.ComboBox
    Friend WithEvents cbTrip As System.Windows.Forms.ComboBox
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBoarding As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigin As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox

End Class
