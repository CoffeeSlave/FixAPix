<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDropDown
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgffd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullscreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.ScreenToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(162, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.StopToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dgffd, Me.ParametersToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'dgffd
        '
        Me.dgffd.Name = "dgffd"
        Me.dgffd.Size = New System.Drawing.Size(133, 22)
        Me.dgffd.Text = "Parameters"
        '
        'ParametersToolStripMenuItem
        '
        Me.ParametersToolStripMenuItem.Name = "ParametersToolStripMenuItem"
        Me.ParametersToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ParametersToolStripMenuItem.Text = "Speed"
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
        Me.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem"
        Me.FullscreenToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.FullscreenToolStripMenuItem.Text = "Fullscreen"
        '
        'NormalSizeToolStripMenuItem
        '
        Me.NormalSizeToolStripMenuItem.Name = "NormalSizeToolStripMenuItem"
        Me.NormalSizeToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.NormalSizeToolStripMenuItem.Text = "Normal Size"
        '
        'frmDropDown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(162, 24)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDropDown"
        Me.Text = "frmDropDown"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgffd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParametersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullscreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
