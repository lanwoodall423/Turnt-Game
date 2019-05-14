<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTurnt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTurnt))
        Me.lblAccuracyText = New System.Windows.Forms.Label()
        Me.lblHitsText = New System.Windows.Forms.Label()
        Me.lblAvgDelayText = New System.Windows.Forms.Label()
        Me.lblAccuracyValue = New System.Windows.Forms.Label()
        Me.lblHitsValue = New System.Windows.Forms.Label()
        Me.lblAvgDelayValue = New System.Windows.Forms.Label()
        Me.picMainMenu = New System.Windows.Forms.PictureBox()
        Me.lblLastHit = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.picMiss = New System.Windows.Forms.PictureBox()
        Me.lblTargetSizeText = New System.Windows.Forms.Label()
        Me.lblSpeedText = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lblTargetSize = New System.Windows.Forms.Label()
        Me.picSaveToLeaderboard = New System.Windows.Forms.PictureBox()
        Me.tboxName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.picClickHereToBegin = New System.Windows.Forms.PictureBox()
        Me.picTarget = New System.Windows.Forms.PictureBox()
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMiss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSaveToLeaderboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClickHereToBegin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAccuracyText
        '
        Me.lblAccuracyText.AutoSize = True
        Me.lblAccuracyText.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccuracyText.Location = New System.Drawing.Point(12, 11)
        Me.lblAccuracyText.Name = "lblAccuracyText"
        Me.lblAccuracyText.Size = New System.Drawing.Size(78, 23)
        Me.lblAccuracyText.TabIndex = 0
        Me.lblAccuracyText.Text = "Accuracy:"
        '
        'lblHitsText
        '
        Me.lblHitsText.AutoSize = True
        Me.lblHitsText.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHitsText.Location = New System.Drawing.Point(12, 34)
        Me.lblHitsText.Name = "lblHitsText"
        Me.lblHitsText.Size = New System.Drawing.Size(39, 23)
        Me.lblHitsText.TabIndex = 1
        Me.lblHitsText.Text = "Hits:"
        '
        'lblAvgDelayText
        '
        Me.lblAvgDelayText.AutoSize = True
        Me.lblAvgDelayText.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgDelayText.Location = New System.Drawing.Point(12, 57)
        Me.lblAvgDelayText.Name = "lblAvgDelayText"
        Me.lblAvgDelayText.Size = New System.Drawing.Size(87, 23)
        Me.lblAvgDelayText.TabIndex = 2
        Me.lblAvgDelayText.Text = "Avg. Delay:"
        '
        'lblAccuracyValue
        '
        Me.lblAccuracyValue.AutoSize = True
        Me.lblAccuracyValue.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccuracyValue.Location = New System.Drawing.Point(108, 11)
        Me.lblAccuracyValue.Name = "lblAccuracyValue"
        Me.lblAccuracyValue.Size = New System.Drawing.Size(49, 23)
        Me.lblAccuracyValue.TabIndex = 3
        Me.lblAccuracyValue.Text = "100%"
        '
        'lblHitsValue
        '
        Me.lblHitsValue.AutoSize = True
        Me.lblHitsValue.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHitsValue.Location = New System.Drawing.Point(108, 34)
        Me.lblHitsValue.Name = "lblHitsValue"
        Me.lblHitsValue.Size = New System.Drawing.Size(32, 23)
        Me.lblHitsValue.TabIndex = 4
        Me.lblHitsValue.Text = "0/0"
        '
        'lblAvgDelayValue
        '
        Me.lblAvgDelayValue.AutoSize = True
        Me.lblAvgDelayValue.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgDelayValue.Location = New System.Drawing.Point(108, 57)
        Me.lblAvgDelayValue.Name = "lblAvgDelayValue"
        Me.lblAvgDelayValue.Size = New System.Drawing.Size(40, 23)
        Me.lblAvgDelayValue.TabIndex = 5
        Me.lblAvgDelayValue.Text = "0ms"
        '
        'picMainMenu
        '
        Me.picMainMenu.Image = CType(resources.GetObject("picMainMenu.Image"), System.Drawing.Image)
        Me.picMainMenu.Location = New System.Drawing.Point(360, 907)
        Me.picMainMenu.Name = "picMainMenu"
        Me.picMainMenu.Size = New System.Drawing.Size(265, 55)
        Me.picMainMenu.TabIndex = 8
        Me.picMainMenu.TabStop = False
        '
        'lblLastHit
        '
        Me.lblLastHit.Font = New System.Drawing.Font("Arial Narrow", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastHit.Location = New System.Drawing.Point(422, 94)
        Me.lblLastHit.Name = "lblLastHit"
        Me.lblLastHit.Size = New System.Drawing.Size(140, 50)
        Me.lblLastHit.TabIndex = 9
        Me.lblLastHit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picMiss
        '
        Me.picMiss.Enabled = False
        Me.picMiss.Location = New System.Drawing.Point(55, 111)
        Me.picMiss.Name = "picMiss"
        Me.picMiss.Size = New System.Drawing.Size(874, 739)
        Me.picMiss.TabIndex = 10
        Me.picMiss.TabStop = False
        '
        'lblTargetSizeText
        '
        Me.lblTargetSizeText.AutoSize = True
        Me.lblTargetSizeText.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetSizeText.Location = New System.Drawing.Point(793, 16)
        Me.lblTargetSizeText.Name = "lblTargetSizeText"
        Me.lblTargetSizeText.Size = New System.Drawing.Size(92, 23)
        Me.lblTargetSizeText.TabIndex = 11
        Me.lblTargetSizeText.Text = "Target Size:"
        '
        'lblSpeedText
        '
        Me.lblSpeedText.AutoSize = True
        Me.lblSpeedText.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeedText.Location = New System.Drawing.Point(793, 39)
        Me.lblSpeedText.Name = "lblSpeedText"
        Me.lblSpeedText.Size = New System.Drawing.Size(60, 23)
        Me.lblSpeedText.TabIndex = 12
        Me.lblSpeedText.Text = "Speed:"
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.Location = New System.Drawing.Point(903, 39)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(19, 23)
        Me.lblSpeed.TabIndex = 13
        Me.lblSpeed.Text = "0"
        '
        'lblTargetSize
        '
        Me.lblTargetSize.AutoSize = True
        Me.lblTargetSize.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTargetSize.Location = New System.Drawing.Point(903, 16)
        Me.lblTargetSize.Name = "lblTargetSize"
        Me.lblTargetSize.Size = New System.Drawing.Size(19, 23)
        Me.lblTargetSize.TabIndex = 14
        Me.lblTargetSize.Text = "0"
        '
        'picSaveToLeaderboard
        '
        Me.picSaveToLeaderboard.Image = CType(resources.GetObject("picSaveToLeaderboard.Image"), System.Drawing.Image)
        Me.picSaveToLeaderboard.Location = New System.Drawing.Point(314, 11)
        Me.picSaveToLeaderboard.Name = "picSaveToLeaderboard"
        Me.picSaveToLeaderboard.Size = New System.Drawing.Size(356, 46)
        Me.picSaveToLeaderboard.TabIndex = 15
        Me.picSaveToLeaderboard.TabStop = False
        '
        'tboxName
        '
        Me.tboxName.Font = New System.Drawing.Font("Impact", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tboxName.Location = New System.Drawing.Point(427, 64)
        Me.tboxName.Name = "tboxName"
        Me.tboxName.Size = New System.Drawing.Size(100, 27)
        Me.tboxName.TabIndex = 16
        Me.tboxName.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(368, 64)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(56, 23)
        Me.lblName.TabIndex = 17
        Me.lblName.Text = "Name:"
        Me.lblName.Visible = False
        '
        'picSave
        '
        Me.picSave.Image = CType(resources.GetObject("picSave.Image"), System.Drawing.Image)
        Me.picSave.Location = New System.Drawing.Point(533, 54)
        Me.picSave.Name = "picSave"
        Me.picSave.Size = New System.Drawing.Size(83, 37)
        Me.picSave.TabIndex = 18
        Me.picSave.TabStop = False
        Me.picSave.Visible = False
        '
        'picClickHereToBegin
        '
        Me.picClickHereToBegin.Image = CType(resources.GetObject("picClickHereToBegin.Image"), System.Drawing.Image)
        Me.picClickHereToBegin.Location = New System.Drawing.Point(111, 443)
        Me.picClickHereToBegin.Name = "picClickHereToBegin"
        Me.picClickHereToBegin.Size = New System.Drawing.Size(762, 75)
        Me.picClickHereToBegin.TabIndex = 19
        Me.picClickHereToBegin.TabStop = False
        '
        'picTarget
        '
        Me.picTarget.Image = CType(resources.GetObject("picTarget.Image"), System.Drawing.Image)
        Me.picTarget.Location = New System.Drawing.Point(418, 389)
        Me.picTarget.Name = "picTarget"
        Me.picTarget.Size = New System.Drawing.Size(100, 100)
        Me.picTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTarget.TabIndex = 20
        Me.picTarget.TabStop = False
        '
        'frmTurnt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(984, 961)
        Me.Controls.Add(Me.picClickHereToBegin)
        Me.Controls.Add(Me.picTarget)
        Me.Controls.Add(Me.picSave)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.tboxName)
        Me.Controls.Add(Me.picSaveToLeaderboard)
        Me.Controls.Add(Me.lblTargetSize)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblSpeedText)
        Me.Controls.Add(Me.lblTargetSizeText)
        Me.Controls.Add(Me.lblLastHit)
        Me.Controls.Add(Me.picMainMenu)
        Me.Controls.Add(Me.lblAvgDelayValue)
        Me.Controls.Add(Me.lblHitsValue)
        Me.Controls.Add(Me.lblAccuracyValue)
        Me.Controls.Add(Me.lblAvgDelayText)
        Me.Controls.Add(Me.lblHitsText)
        Me.Controls.Add(Me.lblAccuracyText)
        Me.Controls.Add(Me.picMiss)
        Me.Name = "frmTurnt"
        Me.Text = "Turnt"
        CType(Me.picMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMiss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSaveToLeaderboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClickHereToBegin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAccuracyText As Label
    Friend WithEvents lblHitsText As Label
    Friend WithEvents lblAvgDelayText As Label
    Friend WithEvents lblAccuracyValue As Label
    Friend WithEvents lblHitsValue As Label
    Friend WithEvents lblAvgDelayValue As Label
    Friend WithEvents picMainMenu As PictureBox
    Friend WithEvents lblLastHit As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents picMiss As PictureBox
    Friend WithEvents lblTargetSizeText As Label
    Friend WithEvents lblSpeedText As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lblTargetSize As Label
    Friend WithEvents picSaveToLeaderboard As PictureBox
    Friend WithEvents tboxName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents picSave As PictureBox
    Friend WithEvents picClickHereToBegin As PictureBox
    Friend WithEvents picTarget As PictureBox
End Class
