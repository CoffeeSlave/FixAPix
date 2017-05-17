<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreferences
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
        Me.chkRed = New System.Windows.Forms.CheckBox()
        Me.chkBlue = New System.Windows.Forms.CheckBox()
        Me.chkGreen = New System.Windows.Forms.CheckBox()
        Me.chkBlack = New System.Windows.Forms.CheckBox()
        Me.chkWhite = New System.Windows.Forms.CheckBox()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dTimeSpan = New System.Windows.Forms.DomainUpDown()
        Me.dHighSpeed = New System.Windows.Forms.DomainUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dMinSpeed = New System.Windows.Forms.DomainUpDown()
        Me.chkAutoSpeed = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbShutDownHours = New System.Windows.Forms.ComboBox()
        Me.chkAutoShutdown = New System.Windows.Forms.CheckBox()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkRed
        '
        Me.chkRed.AutoSize = True
        Me.chkRed.Location = New System.Drawing.Point(6, 14)
        Me.chkRed.Name = "chkRed"
        Me.chkRed.Size = New System.Drawing.Size(76, 17)
        Me.chkRed.TabIndex = 0
        Me.chkRed.Text = "Show Red"
        Me.chkRed.UseVisualStyleBackColor = True
        '
        'chkBlue
        '
        Me.chkBlue.AutoSize = True
        Me.chkBlue.Location = New System.Drawing.Point(98, 14)
        Me.chkBlue.Name = "chkBlue"
        Me.chkBlue.Size = New System.Drawing.Size(77, 17)
        Me.chkBlue.TabIndex = 1
        Me.chkBlue.Text = "Show Blue"
        Me.chkBlue.UseVisualStyleBackColor = True
        '
        'chkGreen
        '
        Me.chkGreen.AutoSize = True
        Me.chkGreen.Location = New System.Drawing.Point(191, 14)
        Me.chkGreen.Name = "chkGreen"
        Me.chkGreen.Size = New System.Drawing.Size(85, 17)
        Me.chkGreen.TabIndex = 2
        Me.chkGreen.Text = "Show Green"
        Me.chkGreen.UseVisualStyleBackColor = True
        '
        'chkBlack
        '
        Me.chkBlack.AutoSize = True
        Me.chkBlack.Location = New System.Drawing.Point(6, 37)
        Me.chkBlack.Name = "chkBlack"
        Me.chkBlack.Size = New System.Drawing.Size(83, 17)
        Me.chkBlack.TabIndex = 3
        Me.chkBlack.Text = "Show Black"
        Me.chkBlack.UseVisualStyleBackColor = True
        '
        'chkWhite
        '
        Me.chkWhite.AutoSize = True
        Me.chkWhite.Location = New System.Drawing.Point(98, 37)
        Me.chkWhite.Name = "chkWhite"
        Me.chkWhite.Size = New System.Drawing.Size(84, 17)
        Me.chkWhite.TabIndex = 4
        Me.chkWhite.Text = "Show White"
        Me.chkWhite.UseVisualStyleBackColor = True
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(207, 220)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(89, 23)
        Me.btnApply.TabIndex = 5
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = True
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(6, 19)
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(270, 45)
        Me.tbSpeed.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.chkWhite)
        Me.GroupBox1.Controls.Add(Me.chkRed)
        Me.GroupBox1.Controls.Add(Me.chkBlue)
        Me.GroupBox1.Controls.Add(Me.chkGreen)
        Me.GroupBox1.Controls.Add(Me.chkBlack)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 66)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Colours"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(191, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Default"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.lblSpeed)
        Me.GroupBox2.Controls.Add(Me.tbSpeed)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(285, 77)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Refresh Speed"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(191, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Default"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblSpeed
        '
        Me.lblSpeed.Location = New System.Drawing.Point(6, 51)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(270, 13)
        Me.lblSpeed.TabIndex = 7
        Me.lblSpeed.Text = "100"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.dTimeSpan)
        Me.GroupBox3.Controls.Add(Me.dHighSpeed)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.chkAutoSpeed)
        Me.GroupBox3.Controls.Add(Me.dMinSpeed)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 346)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 90)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(115, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TimeSpan in minutes"
        '
        'dTimeSpan
        '
        Me.dTimeSpan.Items.Add("1")
        Me.dTimeSpan.Items.Add("2")
        Me.dTimeSpan.Items.Add("3")
        Me.dTimeSpan.Items.Add("4")
        Me.dTimeSpan.Items.Add("5")
        Me.dTimeSpan.Location = New System.Drawing.Point(226, 60)
        Me.dTimeSpan.Name = "dTimeSpan"
        Me.dTimeSpan.Size = New System.Drawing.Size(48, 20)
        Me.dTimeSpan.TabIndex = 5
        Me.dTimeSpan.Text = "5"
        '
        'dHighSpeed
        '
        Me.dHighSpeed.Items.Add("1")
        Me.dHighSpeed.Items.Add("2")
        Me.dHighSpeed.Items.Add("3")
        Me.dHighSpeed.Items.Add("4")
        Me.dHighSpeed.Items.Add("5")
        Me.dHighSpeed.Location = New System.Drawing.Point(84, 23)
        Me.dHighSpeed.Name = "dHighSpeed"
        Me.dHighSpeed.Size = New System.Drawing.Size(48, 20)
        Me.dHighSpeed.TabIndex = 4
        Me.dHighSpeed.Text = "350"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Highest Speed"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Lowest Speed"
        '
        'dMinSpeed
        '
        Me.dMinSpeed.Items.Add("1")
        Me.dMinSpeed.Items.Add("2")
        Me.dMinSpeed.Items.Add("3")
        Me.dMinSpeed.Items.Add("4")
        Me.dMinSpeed.Items.Add("5")
        Me.dMinSpeed.Location = New System.Drawing.Point(226, 23)
        Me.dMinSpeed.Name = "dMinSpeed"
        Me.dMinSpeed.Size = New System.Drawing.Size(48, 20)
        Me.dMinSpeed.TabIndex = 1
        Me.dMinSpeed.Text = "250"
        '
        'chkAutoSpeed
        '
        Me.chkAutoSpeed.AutoSize = True
        Me.chkAutoSpeed.Location = New System.Drawing.Point(6, 0)
        Me.chkAutoSpeed.Name = "chkAutoSpeed"
        Me.chkAutoSpeed.Size = New System.Drawing.Size(118, 17)
        Me.chkAutoSpeed.TabIndex = 0
        Me.chkAutoSpeed.Text = "Enable Auto Speed"
        Me.chkAutoSpeed.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.cmbShutDownHours)
        Me.GroupBox4.Controls.Add(Me.chkAutoShutdown)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 164)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(285, 50)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "00:00:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Shutdown in"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hours"
        '
        'cmbShutDownHours
        '
        Me.cmbShutDownHours.FormattingEnabled = True
        Me.cmbShutDownHours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbShutDownHours.Location = New System.Drawing.Point(78, 19)
        Me.cmbShutDownHours.Name = "cmbShutDownHours"
        Me.cmbShutDownHours.Size = New System.Drawing.Size(36, 21)
        Me.cmbShutDownHours.TabIndex = 1
        Me.cmbShutDownHours.Text = "1"
        '
        'chkAutoShutdown
        '
        Me.chkAutoShutdown.AutoSize = True
        Me.chkAutoShutdown.Location = New System.Drawing.Point(7, 0)
        Me.chkAutoShutdown.Name = "chkAutoShutdown"
        Me.chkAutoShutdown.Size = New System.Drawing.Size(99, 17)
        Me.chkAutoShutdown.TabIndex = 0
        Me.chkAutoShutdown.Text = "Auto Shutdown"
        Me.chkAutoShutdown.UseVisualStyleBackColor = True
        '
        'frmPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 250)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPreferences"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preferences"
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkRed As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlue As System.Windows.Forms.CheckBox
    Friend WithEvents chkGreen As System.Windows.Forms.CheckBox
    Friend WithEvents chkBlack As System.Windows.Forms.CheckBox
    Friend WithEvents chkWhite As System.Windows.Forms.CheckBox
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAutoSpeed As System.Windows.Forms.CheckBox
    Friend WithEvents dMinSpeed As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dTimeSpan As System.Windows.Forms.DomainUpDown
    Friend WithEvents dHighSpeed As System.Windows.Forms.DomainUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkAutoShutdown As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbShutDownHours As System.Windows.Forms.ComboBox
End Class
