<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMdetails
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
        Me.lbldetailsheading = New System.Windows.Forms.Label()
        Me.pctbxdetailspurple = New System.Windows.Forms.PictureBox()
        Me.pctbxdetailslogo = New System.Windows.Forms.PictureBox()
        Me.btnupdatedetails = New System.Windows.Forms.Button()
        Me.lblweddingsizeday = New System.Windows.Forms.Label()
        Me.btnedit1 = New System.Windows.Forms.Button()
        Me.DS = New PROJECT_STENNACK_PROTO.DS()
        Me.BSdetails2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLbookingTableAdapter = New PROJECT_STENNACK_PROTO.DSTableAdapters.TBLbookingTableAdapter()
        Me.lblweddsizenight = New System.Windows.Forms.Label()
        Me.btnedit2 = New System.Windows.Forms.Button()
        Me.lblceromonytime = New System.Windows.Forms.Label()
        Me.btnedit3 = New System.Windows.Forms.Button()
        Me.BSdetails = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLweddingsTableAdapter = New PROJECT_STENNACK_PROTO.DSTableAdapters.TBLweddingsTableAdapter()
        Me.lbldepositpaid = New System.Windows.Forms.Label()
        Me.lblarrival = New System.Windows.Forms.Label()
        Me.lblleavedate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pctbxdetailspurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxdetailslogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSdetails2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSdetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldetailsheading
        '
        Me.lbldetailsheading.AutoSize = True
        Me.lbldetailsheading.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lbldetailsheading.Font = New System.Drawing.Font("Britannic Bold", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldetailsheading.Location = New System.Drawing.Point(12, 171)
        Me.lbldetailsheading.Name = "lbldetailsheading"
        Me.lbldetailsheading.Size = New System.Drawing.Size(326, 106)
        Me.lbldetailsheading.TabIndex = 2
        Me.lbldetailsheading.Text = "details"
        '
        'pctbxdetailspurple
        '
        Me.pctbxdetailspurple.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pctbxdetailspurple.Location = New System.Drawing.Point(12, 12)
        Me.pctbxdetailspurple.Name = "pctbxdetailspurple"
        Me.pctbxdetailspurple.Size = New System.Drawing.Size(326, 538)
        Me.pctbxdetailspurple.TabIndex = 1
        Me.pctbxdetailspurple.TabStop = False
        '
        'pctbxdetailslogo
        '
        Me.pctbxdetailslogo.Image = Global.PROJECT_STENNACK_PROTO.My.Resources.Resources.stennacklogosize2
        Me.pctbxdetailslogo.Location = New System.Drawing.Point(780, 2)
        Me.pctbxdetailslogo.Name = "pctbxdetailslogo"
        Me.pctbxdetailslogo.Size = New System.Drawing.Size(126, 118)
        Me.pctbxdetailslogo.TabIndex = 3
        Me.pctbxdetailslogo.TabStop = False
        '
        'btnupdatedetails
        '
        Me.btnupdatedetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnupdatedetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdatedetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdatedetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnupdatedetails.Location = New System.Drawing.Point(344, 12)
        Me.btnupdatedetails.Name = "btnupdatedetails"
        Me.btnupdatedetails.Size = New System.Drawing.Size(294, 62)
        Me.btnupdatedetails.TabIndex = 9
        Me.btnupdatedetails.Text = "update details"
        Me.btnupdatedetails.UseVisualStyleBackColor = False
        '
        'lblweddingsizeday
        '
        Me.lblweddingsizeday.AutoSize = True
        Me.lblweddingsizeday.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblweddingsizeday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblweddingsizeday.Location = New System.Drawing.Point(344, 99)
        Me.lblweddingsizeday.Name = "lblweddingsizeday"
        Me.lblweddingsizeday.Size = New System.Drawing.Size(142, 21)
        Me.lblweddingsizeday.TabIndex = 10
        Me.lblweddingsizeday.Text = "wedding size (day):"
        '
        'btnedit1
        '
        Me.btnedit1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnedit1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnedit1.Location = New System.Drawing.Point(675, 91)
        Me.btnedit1.Name = "btnedit1"
        Me.btnedit1.Size = New System.Drawing.Size(89, 29)
        Me.btnedit1.TabIndex = 11
        Me.btnedit1.Text = "Edit"
        Me.btnedit1.UseVisualStyleBackColor = False
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSdetails2
        '
        Me.BSdetails2.DataMember = "TBLbooking"
        Me.BSdetails2.DataSource = Me.DS
        '
        'TBLbookingTableAdapter
        '
        Me.TBLbookingTableAdapter.ClearBeforeFill = True
        '
        'lblweddsizenight
        '
        Me.lblweddsizenight.AutoSize = True
        Me.lblweddsizenight.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblweddsizenight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblweddsizenight.Location = New System.Drawing.Point(344, 143)
        Me.lblweddsizenight.Name = "lblweddsizenight"
        Me.lblweddsizenight.Size = New System.Drawing.Size(172, 21)
        Me.lblweddsizenight.TabIndex = 12
        Me.lblweddsizenight.Text = "wedding size (evening):"
        '
        'btnedit2
        '
        Me.btnedit2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnedit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnedit2.Location = New System.Drawing.Point(675, 135)
        Me.btnedit2.Name = "btnedit2"
        Me.btnedit2.Size = New System.Drawing.Size(89, 29)
        Me.btnedit2.TabIndex = 13
        Me.btnedit2.Text = "Edit"
        Me.btnedit2.UseVisualStyleBackColor = False
        '
        'lblceromonytime
        '
        Me.lblceromonytime.AutoSize = True
        Me.lblceromonytime.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblceromonytime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblceromonytime.Location = New System.Drawing.Point(344, 193)
        Me.lblceromonytime.Name = "lblceromonytime"
        Me.lblceromonytime.Size = New System.Drawing.Size(135, 21)
        Me.lblceromonytime.TabIndex = 14
        Me.lblceromonytime.Text = "time of ceremony:"
        '
        'btnedit3
        '
        Me.btnedit3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnedit3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnedit3.Location = New System.Drawing.Point(675, 185)
        Me.btnedit3.Name = "btnedit3"
        Me.btnedit3.Size = New System.Drawing.Size(89, 29)
        Me.btnedit3.TabIndex = 15
        Me.btnedit3.Text = "Edit"
        Me.btnedit3.UseVisualStyleBackColor = False
        '
        'BSdetails
        '
        Me.BSdetails.DataMember = "TBLweddings"
        Me.BSdetails.DataSource = Me.DS
        '
        'TBLweddingsTableAdapter
        '
        Me.TBLweddingsTableAdapter.ClearBeforeFill = True
        '
        'lbldepositpaid
        '
        Me.lbldepositpaid.AutoSize = True
        Me.lbldepositpaid.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldepositpaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lbldepositpaid.Location = New System.Drawing.Point(344, 256)
        Me.lbldepositpaid.Name = "lbldepositpaid"
        Me.lbldepositpaid.Size = New System.Drawing.Size(98, 21)
        Me.lbldepositpaid.TabIndex = 16
        Me.lbldepositpaid.Text = "deposit paid:"
        '
        'lblarrival
        '
        Me.lblarrival.AutoSize = True
        Me.lblarrival.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblarrival.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblarrival.Location = New System.Drawing.Point(344, 305)
        Me.lblarrival.Name = "lblarrival"
        Me.lblarrival.Size = New System.Drawing.Size(91, 21)
        Me.lblarrival.TabIndex = 17
        Me.lblarrival.Text = "arrival date:"
        '
        'lblleavedate
        '
        Me.lblleavedate.AutoSize = True
        Me.lblleavedate.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblleavedate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblleavedate.Location = New System.Drawing.Point(344, 361)
        Me.lblleavedate.Name = "lblleavedate"
        Me.lblleavedate.Size = New System.Drawing.Size(83, 21)
        Me.lblleavedate.TabIndex = 18
        Me.lblleavedate.Text = "leave date:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(675, 237)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 145)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Enquire change"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FRMdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(908, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblleavedate)
        Me.Controls.Add(Me.lblarrival)
        Me.Controls.Add(Me.lbldepositpaid)
        Me.Controls.Add(Me.btnedit3)
        Me.Controls.Add(Me.lblceromonytime)
        Me.Controls.Add(Me.btnedit2)
        Me.Controls.Add(Me.lblweddsizenight)
        Me.Controls.Add(Me.btnedit1)
        Me.Controls.Add(Me.lblweddingsizeday)
        Me.Controls.Add(Me.btnupdatedetails)
        Me.Controls.Add(Me.pctbxdetailslogo)
        Me.Controls.Add(Me.lbldetailsheading)
        Me.Controls.Add(Me.pctbxdetailspurple)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMdetails"
        Me.Text = "FRMdetails"
        CType(Me.pctbxdetailspurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxdetailslogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSdetails2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSdetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctbxdetailspurple As PictureBox
    Friend WithEvents lbldetailsheading As Label
    Friend WithEvents pctbxdetailslogo As PictureBox
    Friend WithEvents btnupdatedetails As Button
    Friend WithEvents lblweddingsizeday As Label
    Friend WithEvents btnedit1 As Button
    Friend WithEvents DS As DS
    Friend WithEvents BSdetails2 As BindingSource
    Friend WithEvents TBLbookingTableAdapter As DSTableAdapters.TBLbookingTableAdapter
    Friend WithEvents lblweddsizenight As Label
    Friend WithEvents btnedit2 As Button
    Friend WithEvents lblceromonytime As Label
    Friend WithEvents btnedit3 As Button
    Friend WithEvents BSdetails As BindingSource
    Friend WithEvents TBLweddingsTableAdapter As DSTableAdapters.TBLweddingsTableAdapter
    Friend WithEvents lbldepositpaid As Label
    Friend WithEvents lblarrival As Label
    Friend WithEvents lblleavedate As Label
    Friend WithEvents Button1 As Button
End Class
