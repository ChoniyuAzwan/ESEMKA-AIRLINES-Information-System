﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditFlightSchedulling
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.cbAirplaneType = New System.Windows.Forms.ComboBox()
        Me.dtpDeparture = New System.Windows.Forms.DateTimePicker()
        Me.dtpArrival = New System.Windows.Forms.DateTimePicker()
        Me.txtOrigin = New System.Windows.Forms.TextBox()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFlightNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBoarding = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbTrip = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(384, 374)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 30)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnOk
        '
        Me.btnOk.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnOk.FlatAppearance.BorderSize = 0
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Location = New System.Drawing.Point(284, 374)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 30)
        Me.btnOk.TabIndex = 8
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = False
        '
        'cbAirplaneType
        '
        Me.cbAirplaneType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbAirplaneType.FormattingEnabled = True
        Me.cbAirplaneType.Location = New System.Drawing.Point(153, 293)
        Me.cbAirplaneType.Name = "cbAirplaneType"
        Me.cbAirplaneType.Size = New System.Drawing.Size(306, 27)
        Me.cbAirplaneType.TabIndex = 54
        '
        'dtpDeparture
        '
        Me.dtpDeparture.Location = New System.Drawing.Point(153, 167)
        Me.dtpDeparture.Name = "dtpDeparture"
        Me.dtpDeparture.Size = New System.Drawing.Size(306, 26)
        Me.dtpDeparture.TabIndex = 46
        '
        'dtpArrival
        '
        Me.dtpArrival.Location = New System.Drawing.Point(153, 199)
        Me.dtpArrival.Name = "dtpArrival"
        Me.dtpArrival.Size = New System.Drawing.Size(306, 26)
        Me.dtpArrival.TabIndex = 47
        '
        'txtOrigin
        '
        Me.txtOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigin.Location = New System.Drawing.Point(153, 101)
        Me.txtOrigin.Name = "txtOrigin"
        Me.txtOrigin.Size = New System.Drawing.Size(306, 26)
        Me.txtOrigin.TabIndex = 43
        '
        'txtDestination
        '
        Me.txtDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDestination.Location = New System.Drawing.Point(153, 133)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(306, 26)
        Me.txtDestination.TabIndex = 45
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(153, 261)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(306, 26)
        Me.txtPrice.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 19)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Origin of Flight"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 57
        Me.Label8.Text = "Destination of Flight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 19)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Departure Schedule"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 19)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Ariival Schedule"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 19)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Airplane Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 19)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Trip Point"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Flight Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Flight Number"
        '
        'txtFlightNumber
        '
        Me.txtFlightNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFlightNumber.Location = New System.Drawing.Point(153, 69)
        Me.txtFlightNumber.Name = "txtFlightNumber"
        Me.txtFlightNumber.Size = New System.Drawing.Size(306, 26)
        Me.txtFlightNumber.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Copperplate Gothic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Edit Flight Schedulling"
        '
        'cbBoarding
        '
        Me.cbBoarding.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBoarding.FormattingEnabled = True
        Me.cbBoarding.Location = New System.Drawing.Point(153, 326)
        Me.cbBoarding.Name = "cbBoarding"
        Me.cbBoarding.Size = New System.Drawing.Size(306, 27)
        Me.cbBoarding.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 19)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Boarding Room"
        '
        'cbTrip
        '
        Me.cbTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTrip.FormattingEnabled = True
        Me.cbTrip.Location = New System.Drawing.Point(153, 228)
        Me.cbTrip.Name = "cbTrip"
        Me.cbTrip.Size = New System.Drawing.Size(306, 27)
        Me.cbTrip.TabIndex = 62
        '
        'frmEditFlightSchedulling
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(476, 416)
        Me.Controls.Add(Me.cbTrip)
        Me.Controls.Add(Me.cbBoarding)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbAirplaneType)
        Me.Controls.Add(Me.dtpDeparture)
        Me.Controls.Add(Me.dtpArrival)
        Me.Controls.Add(Me.txtOrigin)
        Me.Controls.Add(Me.txtDestination)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFlightNumber)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditFlightSchedulling"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Edit Flight Schedulling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents cbAirplaneType As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDeparture As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpArrival As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtOrigin As System.Windows.Forms.TextBox
    Friend WithEvents txtDestination As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFlightNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbBoarding As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbTrip As System.Windows.Forms.ComboBox

End Class
