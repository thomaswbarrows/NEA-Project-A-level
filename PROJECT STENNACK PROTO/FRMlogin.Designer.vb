<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMlogin
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
        Me.Pctbxloginlogo = New System.Windows.Forms.PictureBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnguest = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.BSlogin = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS = New PROJECT_STENNACK_PROTO.DS()
        Me.TBLusersTableAdapter = New PROJECT_STENNACK_PROTO.DSTableAdapters.TBLusersTableAdapter()
        CType(Me.Pctbxloginlogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pctbxloginlogo
        '
        Me.Pctbxloginlogo.Image = Global.PROJECT_STENNACK_PROTO.My.Resources.Resources.stennacklogo
        Me.Pctbxloginlogo.Location = New System.Drawing.Point(826, 12)
        Me.Pctbxloginlogo.Name = "Pctbxloginlogo"
        Me.Pctbxloginlogo.Size = New System.Drawing.Size(203, 200)
        Me.Pctbxloginlogo.TabIndex = 0
        Me.Pctbxloginlogo.TabStop = False
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblusername.Location = New System.Drawing.Point(788, 258)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(56, 13)
        Me.lblusername.TabIndex = 1
        Me.lblusername.Text = "username:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.lblpassword.Location = New System.Drawing.Point(788, 306)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(55, 13)
        Me.lblpassword.TabIndex = 2
        Me.lblpassword.Text = "password:"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(791, 348)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(252, 83)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Log in "
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btnguest
        '
        Me.btnguest.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnguest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnguest.Location = New System.Drawing.Point(843, 428)
        Me.btnguest.Name = "btnguest"
        Me.btnguest.Size = New System.Drawing.Size(161, 43)
        Me.btnguest.TabIndex = 4
        Me.btnguest.Text = "guest"
        Me.btnguest.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtpassword.Location = New System.Drawing.Point(791, 322)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(265, 20)
        Me.txtpassword.TabIndex = 5
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtusername.Location = New System.Drawing.Point(791, 274)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(265, 20)
        Me.txtusername.TabIndex = 6
        '
        'BSlogin
        '
        Me.BSlogin.DataMember = "TBLusers"
        Me.BSlogin.DataSource = Me.DS
        '
        'DS
        '
        Me.DS.DataSetName = "DS"
        Me.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLusersTableAdapter
        '
        Me.TBLusersTableAdapter.ClearBeforeFill = True
        '
        'FRMlogin
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Ivory
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1920, 1080)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.btnguest)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblpassword)
        Me.Controls.Add(Me.lblusername)
        Me.Controls.Add(Me.Pctbxloginlogo)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMlogin"
        Me.Text = "Login"
        CType(Me.Pctbxloginlogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSlogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pctbxloginlogo As PictureBox
    Friend WithEvents lblusername As Label
    Friend WithEvents lblpassword As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnguest As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents BSlogin As BindingSource
    Friend WithEvents DS As DS
    Friend WithEvents TBLusersTableAdapter As DSTableAdapters.TBLusersTableAdapter
End Class
