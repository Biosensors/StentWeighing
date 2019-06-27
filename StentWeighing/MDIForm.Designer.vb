<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    ' <System.Diagnostics.DebuggerNonUserCode()> _
    'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing AndAlso components IsNot Nothing Then
    '        components.Dispose()
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    '<System.Diagnostics.DebuggerStepThrough()> _

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub

    'Required by the Windows Form Designer
    ' Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.TSSlblLogin = New System.Windows.Forms.ToolStripStatusLabel
        Me.TSSlbldbName = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel
        Me.TSSlblVersion = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(950, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSlblLogin, Me.TSSlbldbName, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel9, Me.TSSlblVersion})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 244)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(950, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TSSlblLogin
        '
        Me.TSSlblLogin.AutoSize = False
        Me.TSSlblLogin.Name = "TSSlblLogin"
        Me.TSSlblLogin.Size = New System.Drawing.Size(200, 17)
        Me.TSSlblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TSSlbldbName
        '
        Me.TSSlbldbName.AutoSize = False
        Me.TSSlbldbName.BorderSides = CType((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSSlbldbName.Name = "TSSlbldbName"
        Me.TSSlbldbName.Size = New System.Drawing.Size(150, 17)
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(430, 17)
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(0, 17)
        '
        'TSSlblVersion
        '
        Me.TSSlblVersion.AutoSize = False
        Me.TSSlblVersion.Name = "TSSlblVersion"
        Me.TSSlblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TSSlblVersion.Size = New System.Drawing.Size(60, 17)
        Me.TSSlblVersion.Text = "Ver:"
        '
        'MDIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(950, 266)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MDIForm"
        Me.Text = "Stent Weighing"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSlblLogin As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSlbldbName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSlblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
