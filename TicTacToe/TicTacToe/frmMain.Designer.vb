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
        Me.btnPLay = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPLay
        '
        Me.btnPLay.Location = New System.Drawing.Point(63, 130)
        Me.btnPLay.Name = "btnPLay"
        Me.btnPLay.Size = New System.Drawing.Size(160, 40)
        Me.btnPLay.TabIndex = 0
        Me.btnPLay.Text = "New Game"
        Me.btnPLay.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.Transparent
        Me.lblWelcome.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblWelcome.Location = New System.Drawing.Point(25, 29)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(233, 86)
        Me.lblWelcome.TabIndex = 1
        Me.lblWelcome.Text = "Label1"
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 211)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.btnPLay)
        Me.Name = "frmMain"
        Me.Text = "Tic Tac Toe"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPLay As System.Windows.Forms.Button
    Friend WithEvents lblWelcome As System.Windows.Forms.Label

End Class
