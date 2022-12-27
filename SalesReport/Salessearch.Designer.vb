<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salessearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salessearch))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBITMCAT = New System.Windows.Forms.ComboBox()
        Me.CMD_OK = New System.Windows.Forms.Button()
        Me.CMD_Exit = New System.Windows.Forms.Button()
        Me.CBCuscat = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtfrmcus = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btfind = New System.Windows.Forms.Button()
        Me.Txttocus = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bffind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Gbpar = New System.Windows.Forms.GroupBox()
        Me.Grpcurr = New System.Windows.Forms.GroupBox()
        Me.rbfun = New System.Windows.Forms.RadioButton()
        Me.Rbsrc = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Gbpar.SuspendLayout()
        Me.Grpcurr.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 73
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBITMCAT)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 45)
        Me.GroupBox3.TabIndex = 70
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Item Category"
        '
        'CBITMCAT
        '
        Me.CBITMCAT.FormattingEnabled = True
        Me.CBITMCAT.Location = New System.Drawing.Point(9, 18)
        Me.CBITMCAT.Name = "CBITMCAT"
        Me.CBITMCAT.Size = New System.Drawing.Size(262, 21)
        Me.CBITMCAT.TabIndex = 0
        '
        'CMD_OK
        '
        Me.CMD_OK.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_OK.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMD_OK.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMD_OK.Location = New System.Drawing.Point(26, 338)
        Me.CMD_OK.Name = "CMD_OK"
        Me.CMD_OK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMD_OK.Size = New System.Drawing.Size(81, 25)
        Me.CMD_OK.TabIndex = 71
        Me.CMD_OK.Text = "OK"
        Me.CMD_OK.UseVisualStyleBackColor = False
        '
        'CMD_Exit
        '
        Me.CMD_Exit.BackColor = System.Drawing.SystemColors.Control
        Me.CMD_Exit.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMD_Exit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMD_Exit.Location = New System.Drawing.Point(194, 340)
        Me.CMD_Exit.Name = "CMD_Exit"
        Me.CMD_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMD_Exit.Size = New System.Drawing.Size(81, 25)
        Me.CMD_Exit.TabIndex = 72
        Me.CMD_Exit.Text = "Exit"
        Me.CMD_Exit.UseVisualStyleBackColor = False
        '
        'CBCuscat
        '
        Me.CBCuscat.FormattingEnabled = True
        Me.CBCuscat.Location = New System.Drawing.Point(9, 18)
        Me.CBCuscat.Name = "CBCuscat"
        Me.CBCuscat.Size = New System.Drawing.Size(262, 21)
        Me.CBCuscat.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBCuscat)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 45)
        Me.GroupBox2.TabIndex = 69
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer category"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(65, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 62
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 28)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 61
        '
        'txtfrmcus
        '
        Me.txtfrmcus.Location = New System.Drawing.Point(65, 29)
        Me.txtfrmcus.Name = "txtfrmcus"
        Me.txtfrmcus.Size = New System.Drawing.Size(220, 20)
        Me.txtfrmcus.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "To"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "From"
        '
        'btfind
        '
        Me.btfind.BackColor = System.Drawing.SystemColors.Control
        Me.btfind.Cursor = System.Windows.Forms.Cursors.Default
        Me.btfind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btfind.Image = CType(resources.GetObject("btfind.Image"), System.Drawing.Image)
        Me.btfind.Location = New System.Drawing.Point(269, 55)
        Me.btfind.Name = "btfind"
        Me.btfind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btfind.Size = New System.Drawing.Size(17, 20)
        Me.btfind.TabIndex = 26
        Me.btfind.TabStop = False
        Me.btfind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btfind.UseVisualStyleBackColor = False
        '
        'Txttocus
        '
        Me.Txttocus.Location = New System.Drawing.Point(64, 56)
        Me.Txttocus.Name = "Txttocus"
        Me.Txttocus.Size = New System.Drawing.Size(220, 20)
        Me.Txttocus.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "To"
        '
        'bffind
        '
        Me.bffind.BackColor = System.Drawing.SystemColors.Control
        Me.bffind.Cursor = System.Windows.Forms.Cursors.Default
        Me.bffind.ForeColor = System.Drawing.SystemColors.ControlText
        Me.bffind.Image = CType(resources.GetObject("bffind.Image"), System.Drawing.Image)
        Me.bffind.Location = New System.Drawing.Point(269, 28)
        Me.bffind.Name = "bffind"
        Me.bffind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bffind.Size = New System.Drawing.Size(17, 20)
        Me.bffind.TabIndex = 23
        Me.bffind.TabStop = False
        Me.bffind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bffind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 100)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 83)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
        '
        'Gbpar
        '
        Me.Gbpar.Controls.Add(Me.btfind)
        Me.Gbpar.Controls.Add(Me.Txttocus)
        Me.Gbpar.Controls.Add(Me.Label2)
        Me.Gbpar.Controls.Add(Me.bffind)
        Me.Gbpar.Controls.Add(Me.Label1)
        Me.Gbpar.Controls.Add(Me.txtfrmcus)
        Me.Gbpar.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Gbpar.Location = New System.Drawing.Point(13, 9)
        Me.Gbpar.Name = "Gbpar"
        Me.Gbpar.Size = New System.Drawing.Size(290, 83)
        Me.Gbpar.TabIndex = 67
        Me.Gbpar.TabStop = False
        Me.Gbpar.Text = "Customer"
        '
        'Grpcurr
        '
        Me.Grpcurr.Controls.Add(Me.Rbsrc)
        Me.Grpcurr.Controls.Add(Me.rbfun)
        Me.Grpcurr.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Grpcurr.Location = New System.Drawing.Point(13, 292)
        Me.Grpcurr.Name = "Grpcurr"
        Me.Grpcurr.Size = New System.Drawing.Size(290, 45)
        Me.Grpcurr.TabIndex = 71
        Me.Grpcurr.TabStop = False
        Me.Grpcurr.Text = "Currency"
        '
        'rbfun
        '
        Me.rbfun.AutoSize = True
        Me.rbfun.Location = New System.Drawing.Point(13, 20)
        Me.rbfun.Name = "rbfun"
        Me.rbfun.Size = New System.Drawing.Size(83, 17)
        Me.rbfun.TabIndex = 0
        Me.rbfun.TabStop = True
        Me.rbfun.Text = "Functional"
        Me.rbfun.UseVisualStyleBackColor = True
        '
        'Rbsrc
        '
        Me.Rbsrc.AutoSize = True
        Me.Rbsrc.Location = New System.Drawing.Point(202, 19)
        Me.Rbsrc.Name = "Rbsrc"
        Me.Rbsrc.Size = New System.Drawing.Size(64, 17)
        Me.Rbsrc.TabIndex = 1
        Me.Rbsrc.TabStop = True
        Me.Rbsrc.Text = "Source"
        Me.Rbsrc.UseVisualStyleBackColor = True
        '
        'Salessearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(315, 365)
        Me.Controls.Add(Me.Grpcurr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CMD_OK)
        Me.Controls.Add(Me.CMD_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Gbpar)
        Me.Name = "Salessearch"
        Me.Text = "Sales Report"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Gbpar.ResumeLayout(False)
        Me.Gbpar.PerformLayout()
        Me.Grpcurr.ResumeLayout(False)
        Me.Grpcurr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CBITMCAT As System.Windows.Forms.ComboBox
    Public WithEvents CMD_OK As System.Windows.Forms.Button
    Public WithEvents CMD_Exit As System.Windows.Forms.Button
    Friend WithEvents CBCuscat As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfrmcus As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents btfind As System.Windows.Forms.Button
    Friend WithEvents Txttocus As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents bffind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Gbpar As System.Windows.Forms.GroupBox
    Friend WithEvents Grpcurr As System.Windows.Forms.GroupBox
    Friend WithEvents Rbsrc As System.Windows.Forms.RadioButton
    Friend WithEvents rbfun As System.Windows.Forms.RadioButton

End Class
