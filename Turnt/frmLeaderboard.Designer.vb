<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLeaderboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLeaderboard))
        Me.picLeaderboard = New System.Windows.Forms.PictureBox()
        Me.picMainMenu = New System.Windows.Forms.PictureBox()
        Me.lboxLeaderboard = New System.Windows.Forms.ListBox()
        CType(Me.picLeaderboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLeaderboard
        '
        Me.picLeaderboard.Image = CType(resources.GetObject("picLeaderboard.Image"), System.Drawing.Image)
        Me.picLeaderboard.Location = New System.Drawing.Point(9, 12)
        Me.picLeaderboard.Name = "picLeaderboard"
        Me.picLeaderboard.Size = New System.Drawing.Size(866, 138)
        Me.picLeaderboard.TabIndex = 1
        Me.picLeaderboard.TabStop = False
        '
        'picMainMenu
        '
        Me.picMainMenu.Image = CType(resources.GetObject("picMainMenu.Image"), System.Drawing.Image)
        Me.picMainMenu.Location = New System.Drawing.Point(229, 667)
        Me.picMainMenu.Name = "picMainMenu"
        Me.picMainMenu.Size = New System.Drawing.Size(426, 82)
        Me.picMainMenu.TabIndex = 2
        Me.picMainMenu.TabStop = False
        '
        'lboxLeaderboard
        '
        Me.lboxLeaderboard.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lboxLeaderboard.ForeColor = System.Drawing.Color.DarkRed
        Me.lboxLeaderboard.FormattingEnabled = True
        Me.lboxLeaderboard.ItemHeight = 34
        Me.lboxLeaderboard.Location = New System.Drawing.Point(243, 176)
        Me.lboxLeaderboard.Name = "lboxLeaderboard"
        Me.lboxLeaderboard.Size = New System.Drawing.Size(398, 412)
        Me.lboxLeaderboard.TabIndex = 3
        '
        'frmLeaderboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(884, 761)
        Me.Controls.Add(Me.lboxLeaderboard)
        Me.Controls.Add(Me.picMainMenu)
        Me.Controls.Add(Me.picLeaderboard)
        Me.Name = "frmLeaderboard"
        Me.Text = "Leaderboard"
        CType(Me.picLeaderboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picLeaderboard As PictureBox
    Friend WithEvents picMainMenu As PictureBox
    Friend WithEvents lboxLeaderboard As ListBox
End Class
