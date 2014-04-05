<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.fwCountTrackBar = New System.Windows.Forms.TrackBar()
        Me.lblFireworkCount = New System.Windows.Forms.Label()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.chkUltra = New System.Windows.Forms.CheckBox()
        Me.btnAuto = New System.Windows.Forms.Button()
        CType(Me.fwCountTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Location = New System.Drawing.Point(667, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPause.Location = New System.Drawing.Point(586, 2)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(75, 23)
        Me.btnPause.TabIndex = 1
        Me.btnPause.Text = "Pause"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'fwCountTrackBar
        '
        Me.fwCountTrackBar.Location = New System.Drawing.Point(12, 12)
        Me.fwCountTrackBar.Maximum = 100
        Me.fwCountTrackBar.Minimum = 1
        Me.fwCountTrackBar.Name = "fwCountTrackBar"
        Me.fwCountTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fwCountTrackBar.Size = New System.Drawing.Size(107, 45)
        Me.fwCountTrackBar.TabIndex = 2
        Me.fwCountTrackBar.TickFrequency = 5
        Me.fwCountTrackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.fwCountTrackBar.Value = 1
        '
        'lblFireworkCount
        '
        Me.lblFireworkCount.AutoSize = True
        Me.lblFireworkCount.Location = New System.Drawing.Point(106, 12)
        Me.lblFireworkCount.Name = "lblFireworkCount"
        Me.lblFireworkCount.Size = New System.Drawing.Size(13, 13)
        Me.lblFireworkCount.TabIndex = 3
        Me.lblFireworkCount.Text = "1"
        '
        'btnFire
        '
        Me.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnFire.Location = New System.Drawing.Point(424, 2)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(75, 23)
        Me.btnFire.TabIndex = 4
        Me.btnFire.Text = "Fire!"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'chkUltra
        '
        Me.chkUltra.AutoSize = True
        Me.chkUltra.Location = New System.Drawing.Point(3, 8)
        Me.chkUltra.Name = "chkUltra"
        Me.chkUltra.Size = New System.Drawing.Size(15, 14)
        Me.chkUltra.TabIndex = 5
        Me.chkUltra.UseVisualStyleBackColor = True
        '
        'btnAuto
        '
        Me.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAuto.Location = New System.Drawing.Point(505, 2)
        Me.btnAuto.Name = "btnAuto"
        Me.btnAuto.Size = New System.Drawing.Size(75, 23)
        Me.btnAuto.TabIndex = 6
        Me.btnAuto.Text = "Auto On"
        Me.btnAuto.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(744, 662)
        Me.Controls.Add(Me.btnAuto)
        Me.Controls.Add(Me.chkUltra)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.lblFireworkCount)
        Me.Controls.Add(Me.fwCountTrackBar)
        Me.Controls.Add(Me.btnPause)
        Me.Controls.Add(Me.btnReset)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.fwCountTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnPause As System.Windows.Forms.Button
    Friend WithEvents fwCountTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents lblFireworkCount As System.Windows.Forms.Label
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents chkUltra As System.Windows.Forms.CheckBox
    Friend WithEvents btnAuto As System.Windows.Forms.Button

End Class
