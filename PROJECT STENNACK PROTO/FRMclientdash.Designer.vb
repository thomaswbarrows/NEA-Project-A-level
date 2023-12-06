<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class clientdash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblclientheading1 = New System.Windows.Forms.Label()
        Me.lblclientheading2 = New System.Windows.Forms.Label()
        Me.txtweddid = New System.Windows.Forms.TextBox()
        Me.btnviewdetails = New System.Windows.Forms.Button()
        Me.lblclientheading3 = New System.Windows.Forms.Label()
        Me.btnviewcalendar = New System.Windows.Forms.Button()
        Me.btnclientback = New System.Windows.Forms.Button()
        Me.pctbxclientlogo = New System.Windows.Forms.PictureBox()
        Me.pctbxclientpurple = New System.Windows.Forms.PictureBox()
        Me.BSclientpage = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New PROJECT_STENNACK_PROTO.DS()
        Me.TBLbookingTableAdapter = New PROJECT_STENNACK_PROTO.DSTableAdapters.TBLbookingTableAdapter()
        CType(Me.pctbxclientlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxclientpurple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSclientpage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblclientheading1
        '
        Me.lblclientheading1.AutoSize = True
        Me.lblclientheading1.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblclientheading1.Font = New System.Drawing.Font("Britannic Bold", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientheading1.Location = New System.Drawing.Point(37, 157)
        Me.lblclientheading1.Name = "lblclientheading1"
        Me.lblclientheading1.Size = New System.Drawing.Size(289, 106)
        Me.lblclientheading1.TabIndex = 1
        Me.lblclientheading1.Text = "Client"
        '
        'lblclientheading2
        '
        Me.lblclientheading2.AutoSize = True
        Me.lblclientheading2.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientheading2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblclientheading2.Location = New System.Drawing.Point(379, 109)
        Me.lblclientheading2.Name = "lblclientheading2"
        Me.lblclientheading2.Size = New System.Drawing.Size(165, 21)
        Me.lblclientheading2.TabIndex = 3
        Me.lblclientheading2.Text = "Input your booking ID:"
        '
        'txtweddid
        '
        Me.txtweddid.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtweddid.Location = New System.Drawing.Point(383, 133)
        Me.txtweddid.Name = "txtweddid"
        Me.txtweddid.Size = New System.Drawing.Size(250, 20)
        Me.txtweddid.TabIndex = 7
        '
        'btnviewdetails
        '
        Me.btnviewdetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnviewdetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewdetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnviewdetails.Location = New System.Drawing.Point(381, 159)
        Me.btnviewdetails.Name = "btnviewdetails"
        Me.btnviewdetails.Size = New System.Drawing.Size(252, 69)
        Me.btnviewdetails.TabIndex = 8
        Me.btnviewdetails.Text = "view details"
        Me.btnviewdetails.UseVisualStyleBackColor = False
        '
        'lblclientheading3
        '
        Me.lblclientheading3.AutoSize = True
        Me.lblclientheading3.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclientheading3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblclientheading3.Location = New System.Drawing.Point(379, 258)
        Me.lblclientheading3.Name = "lblclientheading3"
        Me.lblclientheading3.Size = New System.Drawing.Size(197, 21)
        Me.lblclientheading3.TabIndex = 9
        Me.lblclientheading3.Text = "Don't have a date booked?:"
        '
        'btnviewcalendar
        '
        Me.btnviewcalendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnviewcalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnviewcalendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnviewcalendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnviewcalendar.Location = New System.Drawing.Point(381, 291)
        Me.btnviewcalendar.Name = "btnviewcalendar"
        Me.btnviewcalendar.Size = New System.Drawing.Size(252, 69)
        Me.btnviewcalendar.TabIndex = 10
        Me.btnviewcalendar.Text = "view calendar"
        Me.btnviewcalendar.UseVisualStyleBackColor = False
        '
        'btnclientback
        '
        Me.btnclientback.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnclientback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclientback.Location = New System.Drawing.Point(795, 507)
        Me.btnclientback.Name = "btnclientback"
        Me.btnclientback.Size = New System.Drawing.Size(101, 43)
        Me.btnclientback.TabIndex = 11
        Me.btnclientback.Text = "Back"
        Me.btnclientback.UseVisualStyleBackColor = False
        '
        'pctbxclientlogo
        '
        Me.pctbxclientlogo.Image = Global.PROJECT_STENNACK_PROTO.My.Resources.Resources.stennacklogosize2
        Me.pctbxclientlogo.Location = New System.Drawing.Point(770, 12)
        Me.pctbxclientlogo.Name = "pctbxclientlogo"
        Me.pctbxclientlogo.Size = New System.Drawing.Size(126, 118)
        Me.pctbxclientlogo.TabIndex = 2
        Me.pctbxclientlogo.TabStop = False
        '
        'pctbxclientpurple
        '
        Me.pctbxclientpurple.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.pctbxclientpurple.Location = New System.Drawing.Point(22, 31)
        Me.pctbxclientpurple.Name = "pctbxclientpurple"
        Me.pctbxclientpurple.Size = New System.Drawing.Size(322, 503)
        Me.pctbxclientpurple.TabIndex = 0
        Me.pctbxclientpurple.TabStop = False
        '
        'BSclientpage
        '
        Me.BSclientpage.DataMember = "TBLbooking"
        Me.BSclientpage.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLbookingTableAdapter
        '
        Me.TBLbookingTableAdapter.ClearBeforeFill = True
        '
        'clientdash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.ClientSize = New System.Drawing.Size(908, 562)
        Me.Controls.Add(Me.btnclientback)
        Me.Controls.Add(Me.btnviewcalendar)
        Me.Controls.Add(Me.lblclientheading3)
        Me.Controls.Add(Me.btnviewdetails)
        Me.Controls.Add(Me.txtweddid)
        Me.Controls.Add(Me.lblclientheading2)
        Me.Controls.Add(Me.pctbxclientlogo)
        Me.Controls.Add(Me.lblclientheading1)
        Me.Controls.Add(Me.pctbxclientpurple)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "clientdash"
        CType(Me.pctbxclientlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxclientpurple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSclientpage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctbxclientpurple As PictureBox
    Friend WithEvents lblclientheading1 As Label
    Friend WithEvents pctbxclientlogo As PictureBox
    Friend WithEvents lblclientheading2 As Label
    Friend WithEvents txtweddid As TextBox
    Friend WithEvents btnviewdetails As Button
    Friend WithEvents lblclientheading3 As Label
    Friend WithEvents btnviewcalendar As Button
    Friend WithEvents btnclientback As Button
    Friend WithEvents BSclientpage As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents TBLbookingTableAdapter As DSTableAdapters.TBLbookingTableAdapter
End Class
