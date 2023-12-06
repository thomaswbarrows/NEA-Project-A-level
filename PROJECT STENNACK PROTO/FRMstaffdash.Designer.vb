<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMstaffdash
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
        Me.pctbxstafflogo = New System.Windows.Forms.PictureBox()
        Me.pctbxstaffpurple = New System.Windows.Forms.PictureBox()
        Me.lblstaffheading = New System.Windows.Forms.Label()
        Me.lblstaffheading2 = New System.Windows.Forms.Label()
        Me.txthoursworked = New System.Windows.Forms.TextBox()
        Me.lblstaffheading3 = New System.Windows.Forms.Label()
        Me.btnsendhours = New System.Windows.Forms.Button()
        Me.btnviewrota = New System.Windows.Forms.Button()
        Me.btnviewshifts = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnabsence = New System.Windows.Forms.Button()
        CType(Me.pctbxstafflogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxstaffpurple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctbxstafflogo
        '
        Me.pctbxstafflogo.Image = Global.PROJECT_STENNACK_PROTO.My.Resources.Resources.stennacklogosize2
        Me.pctbxstafflogo.Location = New System.Drawing.Point(761, 12)
        Me.pctbxstafflogo.Name = "pctbxstafflogo"
        Me.pctbxstafflogo.Size = New System.Drawing.Size(126, 118)
        Me.pctbxstafflogo.TabIndex = 3
        Me.pctbxstafflogo.TabStop = False
        '
        'pctbxstaffpurple
        '
        Me.pctbxstaffpurple.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pctbxstaffpurple.Location = New System.Drawing.Point(12, 33)
        Me.pctbxstaffpurple.Name = "pctbxstaffpurple"
        Me.pctbxstaffpurple.Size = New System.Drawing.Size(322, 503)
        Me.pctbxstaffpurple.TabIndex = 4
        Me.pctbxstaffpurple.TabStop = False
        '
        'lblstaffheading
        '
        Me.lblstaffheading.AutoSize = True
        Me.lblstaffheading.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblstaffheading.Font = New System.Drawing.Font("Britannic Bold", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffheading.Location = New System.Drawing.Point(50, 152)
        Me.lblstaffheading.Name = "lblstaffheading"
        Me.lblstaffheading.Size = New System.Drawing.Size(240, 106)
        Me.lblstaffheading.TabIndex = 5
        Me.lblstaffheading.Text = "Staff"
        '
        'lblstaffheading2
        '
        Me.lblstaffheading2.AutoSize = True
        Me.lblstaffheading2.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblstaffheading2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffheading2.Location = New System.Drawing.Point(88, 482)
        Me.lblstaffheading2.Name = "lblstaffheading2"
        Me.lblstaffheading2.Size = New System.Drawing.Size(68, 24)
        Me.lblstaffheading2.TabIndex = 6
        Me.lblstaffheading2.Text = "Month:"
        '
        'txthoursworked
        '
        Me.txthoursworked.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txthoursworked.Location = New System.Drawing.Point(377, 94)
        Me.txthoursworked.Name = "txthoursworked"
        Me.txthoursworked.Size = New System.Drawing.Size(250, 20)
        Me.txthoursworked.TabIndex = 8
        '
        'lblstaffheading3
        '
        Me.lblstaffheading3.AutoSize = True
        Me.lblstaffheading3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstaffheading3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblstaffheading3.Location = New System.Drawing.Point(373, 70)
        Me.lblstaffheading3.Name = "lblstaffheading3"
        Me.lblstaffheading3.Size = New System.Drawing.Size(188, 21)
        Me.lblstaffheading3.TabIndex = 9
        Me.lblstaffheading3.Text = "hours worked this month:"
        '
        'btnsendhours
        '
        Me.btnsendhours.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnsendhours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsendhours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsendhours.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnsendhours.Location = New System.Drawing.Point(375, 120)
        Me.btnsendhours.Name = "btnsendhours"
        Me.btnsendhours.Size = New System.Drawing.Size(252, 69)
        Me.btnsendhours.TabIndex = 10
        Me.btnsendhours.Text = "send hours"
        Me.btnsendhours.UseVisualStyleBackColor = False
        '
        'btnviewrota
        '
        Me.btnviewrota.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnviewrota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewrota.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewrota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnviewrota.Location = New System.Drawing.Point(375, 198)
        Me.btnviewrota.Name = "btnviewrota"
        Me.btnviewrota.Size = New System.Drawing.Size(252, 69)
        Me.btnviewrota.TabIndex = 11
        Me.btnviewrota.Text = "view rota for this month"
        Me.btnviewrota.UseVisualStyleBackColor = False
        '
        'btnviewshifts
        '
        Me.btnviewshifts.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnviewshifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewshifts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewshifts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnviewshifts.Location = New System.Drawing.Point(375, 273)
        Me.btnviewshifts.Name = "btnviewshifts"
        Me.btnviewshifts.Size = New System.Drawing.Size(252, 69)
        Me.btnviewshifts.TabIndex = 12
        Me.btnviewshifts.Text = "view available shifts for next month"
        Me.btnviewshifts.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(375, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(252, 69)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "view available shifts for next month"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnabsence
        '
        Me.btnabsence.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnabsence.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnabsence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabsence.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnabsence.Location = New System.Drawing.Point(375, 423)
        Me.btnabsence.Name = "btnabsence"
        Me.btnabsence.Size = New System.Drawing.Size(252, 69)
        Me.btnabsence.TabIndex = 14
        Me.btnabsence.Text = "absence alert "
        Me.btnabsence.UseVisualStyleBackColor = False
        '
        'FRMstaffdash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(908, 562)
        Me.Controls.Add(Me.btnabsence)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnviewshifts)
        Me.Controls.Add(Me.btnviewrota)
        Me.Controls.Add(Me.btnsendhours)
        Me.Controls.Add(Me.lblstaffheading3)
        Me.Controls.Add(Me.txthoursworked)
        Me.Controls.Add(Me.lblstaffheading2)
        Me.Controls.Add(Me.lblstaffheading)
        Me.Controls.Add(Me.pctbxstaffpurple)
        Me.Controls.Add(Me.pctbxstafflogo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMstaffdash"
        Me.Text = "FRMstaffdash"
        CType(Me.pctbxstafflogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxstaffpurple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctbxstafflogo As PictureBox
    Friend WithEvents pctbxstaffpurple As PictureBox
    Friend WithEvents lblstaffheading As Label
    Friend WithEvents lblstaffheading2 As Label
    Friend WithEvents txthoursworked As TextBox
    Friend WithEvents lblstaffheading3 As Label
    Friend WithEvents btnsendhours As Button
    Friend WithEvents btnviewrota As Button
    Friend WithEvents btnviewshifts As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnabsence As Button
End Class
