<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pbxPlayer1 = New System.Windows.Forms.PictureBox()
        Me.pbxPlayer2 = New System.Windows.Forms.PictureBox()
        Me.pbxPlayer3 = New System.Windows.Forms.PictureBox()
        Me.pbxPlayer4 = New System.Windows.Forms.PictureBox()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtName4 = New System.Windows.Forms.TextBox()
        Me.lblBalance1 = New System.Windows.Forms.Label()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.lblBalance2 = New System.Windows.Forms.Label()
        Me.lblBalance3 = New System.Windows.Forms.Label()
        Me.lblBalance4 = New System.Windows.Forms.Label()
        Me.btnFrom = New System.Windows.Forms.Button()
        Me.btnTo = New System.Windows.Forms.Button()
        CType(Me.pbxPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(159, 9)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(330, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Monopoly Bank version 0.1"
        '
        'pbxPlayer1
        '
        Me.pbxPlayer1.Location = New System.Drawing.Point(12, 56)
        Me.pbxPlayer1.Name = "pbxPlayer1"
        Me.pbxPlayer1.Size = New System.Drawing.Size(150, 150)
        Me.pbxPlayer1.TabIndex = 1
        Me.pbxPlayer1.TabStop = False
        '
        'pbxPlayer2
        '
        Me.pbxPlayer2.Location = New System.Drawing.Point(168, 56)
        Me.pbxPlayer2.Name = "pbxPlayer2"
        Me.pbxPlayer2.Size = New System.Drawing.Size(150, 150)
        Me.pbxPlayer2.TabIndex = 2
        Me.pbxPlayer2.TabStop = False
        '
        'pbxPlayer3
        '
        Me.pbxPlayer3.Location = New System.Drawing.Point(324, 56)
        Me.pbxPlayer3.Name = "pbxPlayer3"
        Me.pbxPlayer3.Size = New System.Drawing.Size(150, 150)
        Me.pbxPlayer3.TabIndex = 3
        Me.pbxPlayer3.TabStop = False
        '
        'pbxPlayer4
        '
        Me.pbxPlayer4.Location = New System.Drawing.Point(480, 56)
        Me.pbxPlayer4.Name = "pbxPlayer4"
        Me.pbxPlayer4.Size = New System.Drawing.Size(150, 150)
        Me.pbxPlayer4.TabIndex = 4
        Me.pbxPlayer4.TabStop = False
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(12, 212)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(150, 41)
        Me.txtName1.TabIndex = 0
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(168, 212)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(150, 41)
        Me.txtName2.TabIndex = 1
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(324, 212)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(150, 41)
        Me.txtName3.TabIndex = 2
        '
        'txtName4
        '
        Me.txtName4.Location = New System.Drawing.Point(480, 212)
        Me.txtName4.Name = "txtName4"
        Me.txtName4.Size = New System.Drawing.Size(150, 41)
        Me.txtName4.TabIndex = 3
        '
        'lblBalance1
        '
        Me.lblBalance1.AutoSize = True
        Me.lblBalance1.Location = New System.Drawing.Point(29, 256)
        Me.lblBalance1.Name = "lblBalance1"
        Me.lblBalance1.Size = New System.Drawing.Size(118, 33)
        Me.lblBalance1.TabIndex = 9
        Me.lblBalance1.Text = "15.000M"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(168, 324)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(150, 41)
        Me.txtFrom.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(480, 324)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(150, 41)
        Me.txtTo.TabIndex = 7
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(6, 374)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(107, 33)
        Me.lblAmount.TabIndex = 17
        Me.lblAmount.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(168, 371)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(150, 41)
        Me.txtAmount.TabIndex = 8
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(324, 371)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(306, 41)
        Me.btnConfirm.TabIndex = 9
        Me.btnConfirm.Text = "&Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'lblBalance2
        '
        Me.lblBalance2.AutoSize = True
        Me.lblBalance2.Location = New System.Drawing.Point(184, 256)
        Me.lblBalance2.Name = "lblBalance2"
        Me.lblBalance2.Size = New System.Drawing.Size(118, 33)
        Me.lblBalance2.TabIndex = 20
        Me.lblBalance2.Text = "15.000M"
        '
        'lblBalance3
        '
        Me.lblBalance3.AutoSize = True
        Me.lblBalance3.Location = New System.Drawing.Point(342, 256)
        Me.lblBalance3.Name = "lblBalance3"
        Me.lblBalance3.Size = New System.Drawing.Size(118, 33)
        Me.lblBalance3.TabIndex = 21
        Me.lblBalance3.Text = "15.000M"
        '
        'lblBalance4
        '
        Me.lblBalance4.AutoSize = True
        Me.lblBalance4.Location = New System.Drawing.Point(497, 256)
        Me.lblBalance4.Name = "lblBalance4"
        Me.lblBalance4.Size = New System.Drawing.Size(118, 33)
        Me.lblBalance4.TabIndex = 22
        Me.lblBalance4.Text = "15.000M"
        '
        'btnFrom
        '
        Me.btnFrom.Location = New System.Drawing.Point(12, 324)
        Me.btnFrom.Name = "btnFrom"
        Me.btnFrom.Size = New System.Drawing.Size(150, 41)
        Me.btnFrom.TabIndex = 4
        Me.btnFrom.Text = "&From"
        Me.btnFrom.UseVisualStyleBackColor = True
        '
        'btnTo
        '
        Me.btnTo.Location = New System.Drawing.Point(324, 323)
        Me.btnTo.Name = "btnTo"
        Me.btnTo.Size = New System.Drawing.Size(150, 41)
        Me.btnTo.TabIndex = 6
        Me.btnTo.Text = "&To"
        Me.btnTo.UseVisualStyleBackColor = True
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 33.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 427)
        Me.Controls.Add(Me.btnTo)
        Me.Controls.Add(Me.btnFrom)
        Me.Controls.Add(Me.lblBalance4)
        Me.Controls.Add(Me.lblBalance3)
        Me.Controls.Add(Me.lblBalance2)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.lblBalance1)
        Me.Controls.Add(Me.txtName4)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.pbxPlayer4)
        Me.Controls.Add(Me.pbxPlayer3)
        Me.Controls.Add(Me.pbxPlayer2)
        Me.Controls.Add(Me.pbxPlayer1)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.Name = "GUI"
        Me.Text = "Monopoly Bank"
        CType(Me.pbxPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents pbxPlayer1 As PictureBox
    Friend WithEvents pbxPlayer2 As PictureBox
    Friend WithEvents pbxPlayer3 As PictureBox
    Friend WithEvents pbxPlayer4 As PictureBox
    Friend WithEvents txtName1 As TextBox
    Friend WithEvents txtName2 As TextBox
    Friend WithEvents txtName3 As TextBox
    Friend WithEvents txtName4 As TextBox
    Friend WithEvents lblBalance1 As Label
    Friend WithEvents txtFrom As TextBox
    Friend WithEvents txtTo As TextBox
    Friend WithEvents lblAmount As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents lblBalance2 As Label
    Friend WithEvents lblBalance3 As Label
    Friend WithEvents lblBalance4 As Label
    Friend WithEvents btnFrom As Button
    Friend WithEvents btnTo As Button
End Class
