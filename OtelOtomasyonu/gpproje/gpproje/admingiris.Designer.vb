<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admingiris
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admingiris))
        Me.admingirisbackbutton = New System.Windows.Forms.Button()
        Me.admingirisconfirmbutton = New System.Windows.Forms.Button()
        Me.adminkadilabel = New System.Windows.Forms.Label()
        Me.adminkadiTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminsifreTB = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'admingirisbackbutton
        '
        Me.admingirisbackbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.buttonyellow
        Me.admingirisbackbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admingirisbackbutton.Location = New System.Drawing.Point(135, 129)
        Me.admingirisbackbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.admingirisbackbutton.Name = "admingirisbackbutton"
        Me.admingirisbackbutton.Size = New System.Drawing.Size(116, 28)
        Me.admingirisbackbutton.TabIndex = 7
        Me.admingirisbackbutton.Text = "Kapat"
        Me.admingirisbackbutton.UseVisualStyleBackColor = True
        '
        'admingirisconfirmbutton
        '
        Me.admingirisconfirmbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.admingirisconfirmbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.admingirisconfirmbutton.FlatAppearance.BorderSize = 3
        Me.admingirisconfirmbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admingirisconfirmbutton.Location = New System.Drawing.Point(9, 129)
        Me.admingirisconfirmbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.admingirisconfirmbutton.Name = "admingirisconfirmbutton"
        Me.admingirisconfirmbutton.Size = New System.Drawing.Size(104, 28)
        Me.admingirisconfirmbutton.TabIndex = 6
        Me.admingirisconfirmbutton.Text = "Giriş"
        Me.admingirisconfirmbutton.UseVisualStyleBackColor = True
        '
        'adminkadilabel
        '
        Me.adminkadilabel.AutoSize = True
        Me.adminkadilabel.BackColor = System.Drawing.Color.Transparent
        Me.adminkadilabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminkadilabel.ForeColor = System.Drawing.Color.Gold
        Me.adminkadilabel.Location = New System.Drawing.Point(9, 16)
        Me.adminkadilabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.adminkadilabel.Name = "adminkadilabel"
        Me.adminkadilabel.Size = New System.Drawing.Size(102, 17)
        Me.adminkadilabel.TabIndex = 8
        Me.adminkadilabel.Text = "Kullanıcı Adı:"
        '
        'adminkadiTB
        '
        Me.adminkadiTB.Location = New System.Drawing.Point(9, 42)
        Me.adminkadiTB.Margin = New System.Windows.Forms.Padding(2)
        Me.adminkadiTB.Name = "adminkadiTB"
        Me.adminkadiTB.Size = New System.Drawing.Size(240, 20)
        Me.adminkadiTB.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(9, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Şifre:"
        '
        'adminsifreTB
        '
        Me.adminsifreTB.Location = New System.Drawing.Point(9, 98)
        Me.adminsifreTB.Margin = New System.Windows.Forms.Padding(2)
        Me.adminsifreTB.Name = "adminsifreTB"
        Me.adminsifreTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.adminsifreTB.Size = New System.Drawing.Size(240, 20)
        Me.adminsifreTB.TabIndex = 5
        Me.adminsifreTB.UseSystemPasswordChar = True
        '
        'admingiris
        '
        Me.AcceptButton = Me.admingirisconfirmbutton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.gpproje.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(257, 167)
        Me.Controls.Add(Me.adminsifreTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adminkadiTB)
        Me.Controls.Add(Me.adminkadilabel)
        Me.Controls.Add(Me.admingirisconfirmbutton)
        Me.Controls.Add(Me.admingirisbackbutton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "admingiris"
        Me.Text = "Admin Giriş"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents admingirisbackbutton As System.Windows.Forms.Button
    Friend WithEvents admingirisconfirmbutton As System.Windows.Forms.Button
    Friend WithEvents adminkadilabel As System.Windows.Forms.Label
    Friend WithEvents adminkadiTB As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents adminsifreTB As System.Windows.Forms.MaskedTextBox
End Class
