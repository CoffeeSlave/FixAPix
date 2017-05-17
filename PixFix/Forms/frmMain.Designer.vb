<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblColFlash = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.paramerters = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowBlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmMain = New System.Windows.Forms.Timer(Me.components)
        Me.btnMinimize = New System.Windows.Forms.Button()
        Me.tmAutoSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblColFlash
        '
        Me.lblColFlash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblColFlash.Location = New System.Drawing.Point(0, 24)
        Me.lblColFlash.Name = "lblColFlash"
        Me.lblColFlash.Size = New System.Drawing.Size(550, 430)
        Me.lblColFlash.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ScreenToolStripMenuItem, Me.ColourTestToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(550, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.StopToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.FileToolStripMenuItem.Text = "Application"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = CType(resources.GetObject("StopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Image = Global.FixAPix.My.Resources.Resources._exit
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.paramerters})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'paramerters
        '
        Me.paramerters.Image = Global.FixAPix.My.Resources.Resources.config
        Me.paramerters.Name = "paramerters"
        Me.paramerters.Size = New System.Drawing.Size(133, 22)
        Me.paramerters.Text = "Parameters"
        '
        'ScreenToolStripMenuItem
        '
        Me.ScreenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FullscreenToolStripMenuItem, Me.NormalSizeToolStripMenuItem})
        Me.ScreenToolStripMenuItem.Name = "ScreenToolStripMenuItem"
        Me.ScreenToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ScreenToolStripMenuItem.Text = "Screen"
        '
        'FullscreenToolStripMenuItem
        '
        Me.FullscreenToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.screenLarge
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'NormalSizeToolStripMenuItem
        '
        Me.NormalSizeToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.screenSmall
        Me.NormalSizeToolStripMenuItem.Name = "NormalSizeToolStripMenuItem"
        Me.NormalSizeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NormalSizeToolStripMenuItem.Text = "Normal Size"
        '
        'ColourTestToolStripMenuItem
        '
        Me.ColourTestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowBlackToolStripMenuItem, Me.WhiteToolStripMenuItem, Me.RegToolStripMenuItem, Me.GreenToolStripMenuItem, Me.BlueToolStripMenuItem})
        Me.ColourTestToolStripMenuItem.Name = "ColourTestToolStripMenuItem"
        Me.ColourTestToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ColourTestToolStripMenuItem.Text = "Colour Test"
        '
        'ShowBlackToolStripMenuItem
        '
        Me.ShowBlackToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.Black
        Me.ShowBlackToolStripMenuItem.Name = "ShowBlackToolStripMenuItem"
        Me.ShowBlackToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.ShowBlackToolStripMenuItem.Text = "Black"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.White
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'RegToolStripMenuItem
        '
        Me.RegToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.Red
        Me.RegToolStripMenuItem.Name = "RegToolStripMenuItem"
        Me.RegToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.RegToolStripMenuItem.Text = "Red"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.Green
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Image = Global.FixAPix.My.Resources.Resources.Blue
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'tmMain
        '
        Me.tmMain.Enabled = True
        '
        'btnMinimize
        '
        Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnMinimize.Location = New System.Drawing.Point(12, 419)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(75, 23)
        Me.btnMinimize.TabIndex = 2
        Me.btnMinimize.Text = "Minimize"
        Me.btnMinimize.UseVisualStyleBackColor = True
        Me.btnMinimize.Visible = False
        '
        'tmAutoSpeed
        '
        Me.tmAutoSpeed.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnMinimize
        Me.ClientSize = New System.Drawing.Size(550, 454)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.lblColFlash)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FixAPix"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblColFlash As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents paramerters As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmMain As System.Windows.Forms.Timer
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColourTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowBlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnMinimize As System.Windows.Forms.Button
    Friend WithEvents tmAutoSpeed As System.Windows.Forms.Timer

End Class
