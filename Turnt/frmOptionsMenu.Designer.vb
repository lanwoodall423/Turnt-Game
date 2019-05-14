<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptionsMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptionsMenu))
        Me.picOptions = New System.Windows.Forms.PictureBox()
        Me.pnlTarget = New System.Windows.Forms.Panel()
        Me.lblTargetSize = New System.Windows.Forms.Label()
        Me.picTargetSize = New System.Windows.Forms.PictureBox()
        Me.trkbarTargetSize = New System.Windows.Forms.TrackBar()
        Me.picMainMenu = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pnlSpeed = New System.Windows.Forms.Panel()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.picSpeed = New System.Windows.Forms.PictureBox()
        Me.trkbarSpeed = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picChangeTarget = New System.Windows.Forms.PictureBox()
        Me.picTargetPreview = New System.Windows.Forms.PictureBox()
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTarget.SuspendLayout()
        CType(Me.picTargetSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbarTargetSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSpeed.SuspendLayout()
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkbarSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.picChangeTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTargetPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOptions
        '
        Me.picOptions.BackColor = System.Drawing.Color.Transparent
        Me.picOptions.Image = CType(resources.GetObject("picOptions.Image"), System.Drawing.Image)
        Me.picOptions.Location = New System.Drawing.Point(55, 50)
        Me.picOptions.Name = "picOptions"
        Me.picOptions.Size = New System.Drawing.Size(474, 106)
        Me.picOptions.TabIndex = 10
        Me.picOptions.TabStop = False
        '
        'pnlTarget
        '
        Me.pnlTarget.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlTarget.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTarget.Controls.Add(Me.lblTargetSize)
        Me.pnlTarget.Controls.Add(Me.picTargetSize)
        Me.pnlTarget.Controls.Add(Me.trkbarTargetSize)
        Me.pnlTarget.Location = New System.Drawing.Point(72, 162)
        Me.pnlTarget.Name = "pnlTarget"
        Me.pnlTarget.Size = New System.Drawing.Size(440, 130)
        Me.pnlTarget.TabIndex = 10
        '
        'lblTargetSize
        '
        Me.lblTargetSize.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetSize.Location = New System.Drawing.Point(173, 103)
        Me.lblTargetSize.Name = "lblTargetSize"
        Me.lblTargetSize.Size = New System.Drawing.Size(90, 23)
        Me.lblTargetSize.TabIndex = 10
        Me.lblTargetSize.Text = "1"
        Me.lblTargetSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTargetSize
        '
        Me.picTargetSize.Image = CType(resources.GetObject("picTargetSize.Image"), System.Drawing.Image)
        Me.picTargetSize.Location = New System.Drawing.Point(71, -2)
        Me.picTargetSize.Name = "picTargetSize"
        Me.picTargetSize.Size = New System.Drawing.Size(294, 51)
        Me.picTargetSize.TabIndex = 9
        Me.picTargetSize.TabStop = False
        '
        'trkbarTargetSize
        '
        Me.trkbarTargetSize.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.trkbarTargetSize.LargeChange = 1
        Me.trkbarTargetSize.Location = New System.Drawing.Point(3, 67)
        Me.trkbarTargetSize.Maximum = 4
        Me.trkbarTargetSize.Minimum = 1
        Me.trkbarTargetSize.Name = "trkbarTargetSize"
        Me.trkbarTargetSize.Size = New System.Drawing.Size(430, 45)
        Me.trkbarTargetSize.TabIndex = 7
        Me.trkbarTargetSize.Value = 1
        '
        'picMainMenu
        '
        Me.picMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.picMainMenu.Image = CType(resources.GetObject("picMainMenu.Image"), System.Drawing.Image)
        Me.picMainMenu.Location = New System.Drawing.Point(160, 694)
        Me.picMainMenu.Name = "picMainMenu"
        Me.picMainMenu.Size = New System.Drawing.Size(265, 55)
        Me.picMainMenu.TabIndex = 11
        Me.picMainMenu.TabStop = False
        '
        'pnlSpeed
        '
        Me.pnlSpeed.BackColor = System.Drawing.Color.DodgerBlue
        Me.pnlSpeed.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlSpeed.Controls.Add(Me.lblSpeed)
        Me.pnlSpeed.Controls.Add(Me.picSpeed)
        Me.pnlSpeed.Controls.Add(Me.trkbarSpeed)
        Me.pnlSpeed.Location = New System.Drawing.Point(72, 310)
        Me.pnlSpeed.Name = "pnlSpeed"
        Me.pnlSpeed.Size = New System.Drawing.Size(440, 130)
        Me.pnlSpeed.TabIndex = 11
        '
        'lblSpeed
        '
        Me.lblSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lblSpeed.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.Location = New System.Drawing.Point(179, 103)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(78, 23)
        Me.lblSpeed.TabIndex = 11
        Me.lblSpeed.Text = "1000ms"
        Me.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picSpeed
        '
        Me.picSpeed.Image = CType(resources.GetObject("picSpeed.Image"), System.Drawing.Image)
        Me.picSpeed.Location = New System.Drawing.Point(134, -2)
        Me.picSpeed.Name = "picSpeed"
        Me.picSpeed.Size = New System.Drawing.Size(168, 51)
        Me.picSpeed.TabIndex = 9
        Me.picSpeed.TabStop = False
        '
        'trkbarSpeed
        '
        Me.trkbarSpeed.Cursor = System.Windows.Forms.Cursors.VSplit
        Me.trkbarSpeed.LargeChange = 50
        Me.trkbarSpeed.Location = New System.Drawing.Point(3, 65)
        Me.trkbarSpeed.Maximum = 2000
        Me.trkbarSpeed.Name = "trkbarSpeed"
        Me.trkbarSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.trkbarSpeed.Size = New System.Drawing.Size(430, 45)
        Me.trkbarSpeed.SmallChange = 50
        Me.trkbarSpeed.TabIndex = 7
        Me.trkbarSpeed.TickFrequency = 250
        Me.trkbarSpeed.Value = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.picChangeTarget)
        Me.Panel1.Controls.Add(Me.picTargetPreview)
        Me.Panel1.Location = New System.Drawing.Point(149, 463)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 194)
        Me.Panel1.TabIndex = 12
        '
        'picChangeTarget
        '
        Me.picChangeTarget.BackColor = System.Drawing.Color.Transparent
        Me.picChangeTarget.Image = CType(resources.GetObject("picChangeTarget.Image"), System.Drawing.Image)
        Me.picChangeTarget.Location = New System.Drawing.Point(11, 136)
        Me.picChangeTarget.Name = "picChangeTarget"
        Me.picChangeTarget.Size = New System.Drawing.Size(265, 55)
        Me.picChangeTarget.TabIndex = 13
        Me.picChangeTarget.TabStop = False
        '
        'picTargetPreview
        '
        Me.picTargetPreview.Image = CType(resources.GetObject("picTargetPreview.Image"), System.Drawing.Image)
        Me.picTargetPreview.Location = New System.Drawing.Point(93, 30)
        Me.picTargetPreview.Name = "picTargetPreview"
        Me.picTargetPreview.Size = New System.Drawing.Size(100, 100)
        Me.picTargetPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTargetPreview.TabIndex = 0
        Me.picTargetPreview.TabStop = False
        '
        'frmOptionsMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 761)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSpeed)
        Me.Controls.Add(Me.picMainMenu)
        Me.Controls.Add(Me.pnlTarget)
        Me.Controls.Add(Me.picOptions)
        Me.DoubleBuffered = True
        Me.Name = "frmOptionsMenu"
        Me.Text = "Options"
        CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTarget.ResumeLayout(False)
        Me.pnlTarget.PerformLayout()
        CType(Me.picTargetSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbarTargetSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSpeed.ResumeLayout(False)
        Me.pnlSpeed.PerformLayout()
        CType(Me.picSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkbarSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.picChangeTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTargetPreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picOptions As PictureBox
    Friend WithEvents pnlTarget As Panel
    Friend WithEvents trkbarTargetSize As TrackBar
    Friend WithEvents picTargetSize As PictureBox
    Friend WithEvents picMainMenu As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pnlSpeed As Panel
    Friend WithEvents picSpeed As PictureBox
    Friend WithEvents trkbarSpeed As TrackBar
    Friend WithEvents lblTargetSize As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents picTargetPreview As PictureBox
    Friend WithEvents picChangeTarget As PictureBox
End Class
