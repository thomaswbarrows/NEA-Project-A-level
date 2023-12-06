<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMadmindash
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
        Me.lbladminheading = New System.Windows.Forms.Label()
        Me.pctbxadminpurple = New System.Windows.Forms.PictureBox()
        Me.pctbxadminlogo = New System.Windows.Forms.PictureBox()
        CType(Me.pctbxadminpurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxadminlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbladminheading
        '
        Me.lbladminheading.AutoSize = True
        Me.lbladminheading.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbladminheading.Font = New System.Drawing.Font("Britannic Bold", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladminheading.Location = New System.Drawing.Point(26, 89)
        Me.lbladminheading.Name = "lbladminheading"
        Me.lbladminheading.Size = New System.Drawing.Size(308, 106)
        Me.lbladminheading.TabIndex = 6
        Me.lbladminheading.Text = "admin"
        '
        'pctbxadminpurple
        '
        Me.pctbxadminpurple.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pctbxadminpurple.Location = New System.Drawing.Point(12, 8)
        Me.pctbxadminpurple.Name = "pctbxadminpurple"
        Me.pctbxadminpurple.Size = New System.Drawing.Size(322, 503)
        Me.pctbxadminpurple.TabIndex = 5
        Me.pctbxadminpurple.TabStop = False
        '
        'pctbxadminlogo
        '
        Me.pctbxadminlogo.Image = Global.PROJECT_STENNACK_PROTO.My.Resources.Resources.stennacklogosize2
        Me.pctbxadminlogo.Location = New System.Drawing.Point(754, 8)
        Me.pctbxadminlogo.Name = "pctbxadminlogo"
        Me.pctbxadminlogo.Size = New System.Drawing.Size(126, 118)
        Me.pctbxadminlogo.TabIndex = 7
        Me.pctbxadminlogo.TabStop = False
        '
        'FRMadmindash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(892, 523)
        Me.Controls.Add(Me.pctbxadminlogo)
        Me.Controls.Add(Me.lbladminheading)
        Me.Controls.Add(Me.pctbxadminpurple)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMadmindash"
        Me.Text = "FRMadmindash"
        CType(Me.pctbxadminpurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxadminlogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctbxadminpurple As PictureBox
    Friend WithEvents lbladminheading As Label
    Friend WithEvents pctbxadminlogo As PictureBox
End Class
