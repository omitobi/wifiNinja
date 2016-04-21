<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.netNameBox = New System.Windows.Forms.TextBox()
        Me.netname = New System.Windows.Forms.Label()
        Me.creatNetBut = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.stopNet = New System.Windows.Forms.RadioButton()
        Me.startNet = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.goNetStart = New System.Windows.Forms.Button()
        Me.helpstrip = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTo = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.notifyContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.showContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.startStopContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.startStopMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.startContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.stopContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.aboutContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitContext = New System.Windows.Forms.ToolStripMenuItem()
        Me.defaultCheckBox = New System.Windows.Forms.CheckBox()
        Me.warnTxt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResults = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.helpstrip.SuspendLayout()
        Me.notifyContext.SuspendLayout()
        Me.startStopMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'netNameBox
        '
        Me.netNameBox.Location = New System.Drawing.Point(111, 37)
        Me.netNameBox.Name = "netNameBox"
        Me.netNameBox.Size = New System.Drawing.Size(132, 20)
        Me.netNameBox.TabIndex = 0
        '
        'netname
        '
        Me.netname.AutoSize = True
        Me.netname.Location = New System.Drawing.Point(44, 44)
        Me.netname.Name = "netname"
        Me.netname.Size = New System.Drawing.Size(43, 13)
        Me.netname.TabIndex = 2
        Me.netname.Text = "Name:"
        '
        'creatNetBut
        '
        Me.creatNetBut.Location = New System.Drawing.Point(156, 137)
        Me.creatNetBut.Name = "creatNetBut"
        Me.creatNetBut.Size = New System.Drawing.Size(87, 23)
        Me.creatNetBut.TabIndex = 4
        Me.creatNetBut.Text = "Create"
        Me.creatNetBut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "(Only letters, undersore and numbers allowed without space)"
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(111, 102)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.Size = New System.Drawing.Size(132, 20)
        Me.passwordbox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(35, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(47, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'stopNet
        '
        Me.stopNet.AutoSize = True
        Me.stopNet.Location = New System.Drawing.Point(57, 8)
        Me.stopNet.Name = "stopNet"
        Me.stopNet.Size = New System.Drawing.Size(51, 17)
        Me.stopNet.TabIndex = 11
        Me.stopNet.TabStop = True
        Me.stopNet.Text = "Stop"
        Me.stopNet.UseVisualStyleBackColor = True
        '
        'startNet
        '
        Me.startNet.AutoSize = True
        Me.startNet.Location = New System.Drawing.Point(6, 8)
        Me.startNet.Name = "startNet"
        Me.startNet.Size = New System.Drawing.Size(52, 17)
        Me.startNet.TabIndex = 12
        Me.startNet.TabStop = True
        Me.startNet.Text = "Start"
        Me.startNet.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.stopNet)
        Me.GroupBox1.Controls.Add(Me.startNet)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 209)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 31)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'goNetStart
        '
        Me.goNetStart.Location = New System.Drawing.Point(237, 217)
        Me.goNetStart.Name = "goNetStart"
        Me.goNetStart.Size = New System.Drawing.Size(39, 23)
        Me.goNetStart.TabIndex = 14
        Me.goNetStart.Text = "GO!"
        Me.goNetStart.UseVisualStyleBackColor = True
        '
        'helpstrip
        '
        Me.helpstrip.BackColor = System.Drawing.Color.Gray
        Me.helpstrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.AboutTo})
        Me.helpstrip.Location = New System.Drawing.Point(0, 0)
        Me.helpstrip.Name = "helpstrip"
        Me.helpstrip.Size = New System.Drawing.Size(295, 24)
        Me.helpstrip.TabIndex = 15
        Me.helpstrip.Text = "helpstrip"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowTo})
        Me.HelpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowTo
        '
        Me.HowTo.Name = "HowTo"
        Me.HowTo.Size = New System.Drawing.Size(121, 22)
        Me.HowTo.Text = "How To?"
        '
        'AboutTo
        '
        Me.AboutTo.Name = "AboutTo"
        Me.AboutTo.Size = New System.Drawing.Size(52, 20)
        Me.AboutTo.Text = "About"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "(Password Must be up to 8 characters)"
        '
        'ToolNotify
        '
        Me.ToolNotify.ContextMenuStrip = Me.notifyContext
        Me.ToolNotify.Icon = CType(resources.GetObject("ToolNotify.Icon"), System.Drawing.Icon)
        Me.ToolNotify.Text = "ToolNotifyIcon"
        Me.ToolNotify.Visible = True
        '
        'notifyContext
        '
        Me.notifyContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.showContext, Me.startStopContext, Me.aboutContext, Me.helpContext, Me.exitContext})
        Me.notifyContext.Name = "notifyContext"
        Me.notifyContext.Size = New System.Drawing.Size(128, 114)
        '
        'showContext
        '
        Me.showContext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.showContext.Name = "showContext"
        Me.showContext.Size = New System.Drawing.Size(127, 22)
        Me.showContext.Text = "Show"
        Me.showContext.ToolTipText = "Unhide the Hotspot Creator"
        '
        'startStopContext
        '
        Me.startStopContext.DropDown = Me.startStopMenu
        Me.startStopContext.Name = "startStopContext"
        Me.startStopContext.Size = New System.Drawing.Size(127, 22)
        Me.startStopContext.Text = "Start/Stop"
        '
        'startStopMenu
        '
        Me.startStopMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.startContext, Me.stopContext})
        Me.startStopMenu.Name = "startStopMenu"
        Me.startStopMenu.OwnerItem = Me.startStopContext
        Me.startStopMenu.Size = New System.Drawing.Size(170, 48)
        '
        'startContext
        '
        Me.startContext.Name = "startContext"
        Me.startContext.Size = New System.Drawing.Size(169, 22)
        Me.startContext.Text = "Start Wifi HotSpot"
        '
        'stopContext
        '
        Me.stopContext.Name = "stopContext"
        Me.stopContext.Size = New System.Drawing.Size(169, 22)
        Me.stopContext.Text = "Stop Wifi Hotspot"
        '
        'aboutContext
        '
        Me.aboutContext.Name = "aboutContext"
        Me.aboutContext.Size = New System.Drawing.Size(127, 22)
        Me.aboutContext.Text = "About"
        '
        'helpContext
        '
        Me.helpContext.Name = "helpContext"
        Me.helpContext.Size = New System.Drawing.Size(127, 22)
        Me.helpContext.Text = "Help"
        '
        'exitContext
        '
        Me.exitContext.Name = "exitContext"
        Me.exitContext.Size = New System.Drawing.Size(127, 22)
        Me.exitContext.Text = "Exit"
        '
        'defaultCheckBox
        '
        Me.defaultCheckBox.AutoSize = True
        Me.defaultCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.defaultCheckBox.Location = New System.Drawing.Point(113, 61)
        Me.defaultCheckBox.Name = "defaultCheckBox"
        Me.defaultCheckBox.Size = New System.Drawing.Size(127, 17)
        Me.defaultCheckBox.TabIndex = 18
        Me.defaultCheckBox.Text = "Use Default Name"
        Me.defaultCheckBox.UseVisualStyleBackColor = True
        '
        'warnTxt
        '
        Me.warnTxt.AutoSize = True
        Me.warnTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warnTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.warnTxt.Location = New System.Drawing.Point(38, 21)
        Me.warnTxt.Name = "warnTxt"
        Me.warnTxt.Size = New System.Drawing.Size(0, 13)
        Me.warnTxt.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Hotspot:"
        '
        'txtResults
        '
        Me.txtResults.Location = New System.Drawing.Point(113, 175)
        Me.txtResults.Multiline = True
        Me.txtResults.Name = "txtResults"
        Me.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResults.Size = New System.Drawing.Size(130, 36)
        Me.txtResults.TabIndex = 21
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(295, 252)
        Me.Controls.Add(Me.txtResults)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.warnTxt)
        Me.Controls.Add(Me.defaultCheckBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.goNetStart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passwordbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.creatNetBut)
        Me.Controls.Add(Me.netname)
        Me.Controls.Add(Me.netNameBox)
        Me.Controls.Add(Me.helpstrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.helpstrip
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotspot Maker"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.helpstrip.ResumeLayout(False)
        Me.helpstrip.PerformLayout()
        Me.notifyContext.ResumeLayout(False)
        Me.startStopMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    ' Private WithEvents AxWebBrowser1 As AxXtremeSuiteControls.AxWebBrowser
    'Private WithEvents AxResizer1 As AxXtremeSuiteControls.AxResizer
    Friend WithEvents netNameBox As System.Windows.Forms.TextBox
    Friend WithEvents netname As System.Windows.Forms.Label
    Friend WithEvents creatNetBut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passwordbox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents stopNet As System.Windows.Forms.RadioButton
    Friend WithEvents startNet As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents goNetStart As System.Windows.Forms.Button
    Friend WithEvents helpstrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AboutTo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolNotify As System.Windows.Forms.NotifyIcon
    Friend WithEvents notifyContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents showContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents startStopContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents startStopMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents startContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents stopContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aboutContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents helpContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitContext As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents defaultCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents warnTxt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResults As System.Windows.Forms.TextBox

End Class
