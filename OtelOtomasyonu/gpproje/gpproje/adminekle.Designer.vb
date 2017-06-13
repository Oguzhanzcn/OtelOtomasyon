<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminekle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminekle))
        Me.adminkadilabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adminEkleAd = New System.Windows.Forms.TextBox()
        Me.adminEkleSifre = New System.Windows.Forms.TextBox()
        Me.adminekleconfirmbutton = New System.Windows.Forms.Button()
        Me.admineklebackbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'adminkadilabel
        '
        Me.adminkadilabel.AutoSize = True
        Me.adminkadilabel.BackColor = System.Drawing.Color.Transparent
        Me.adminkadilabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminkadilabel.ForeColor = System.Drawing.Color.Gold
        Me.adminkadilabel.Location = New System.Drawing.Point(11, 18)
        Me.adminkadilabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.adminkadilabel.Name = "adminkadilabel"
        Me.adminkadilabel.Size = New System.Drawing.Size(139, 17)
        Me.adminkadilabel.TabIndex = 9
        Me.adminkadilabel.Text = "Yeni Kullanıcı Adı:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(11, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Şifre:"
        '
        'adminEkleAd
        '
        Me.adminEkleAd.Location = New System.Drawing.Point(11, 50)
        Me.adminEkleAd.Margin = New System.Windows.Forms.Padding(2)
        Me.adminEkleAd.Name = "adminEkleAd"
        Me.adminEkleAd.Size = New System.Drawing.Size(240, 20)
        Me.adminEkleAd.TabIndex = 1
        '
        'adminEkleSifre
        '
        Me.adminEkleSifre.Location = New System.Drawing.Point(11, 119)
        Me.adminEkleSifre.Margin = New System.Windows.Forms.Padding(2)
        Me.adminEkleSifre.Name = "adminEkleSifre"
        Me.adminEkleSifre.Size = New System.Drawing.Size(240, 20)
        Me.adminEkleSifre.TabIndex = 2
        '
        'adminekleconfirmbutton
        '
        Me.adminekleconfirmbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.adminekleconfirmbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.adminekleconfirmbutton.FlatAppearance.BorderSize = 3
        Me.adminekleconfirmbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminekleconfirmbutton.Location = New System.Drawing.Point(11, 155)
        Me.adminekleconfirmbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.adminekleconfirmbutton.Name = "adminekleconfirmbutton"
        Me.adminekleconfirmbutton.Size = New System.Drawing.Size(104, 28)
        Me.adminekleconfirmbutton.TabIndex = 3
        Me.adminekleconfirmbutton.Text = "Ekle"
        Me.adminekleconfirmbutton.UseVisualStyleBackColor = True
        '
        'admineklebackbutton
        '
        Me.admineklebackbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.buttonyellow
        Me.admineklebackbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admineklebackbutton.Location = New System.Drawing.Point(137, 155)
        Me.admineklebackbutton.Margin = New System.Windows.Forms.Padding(2)
        Me.admineklebackbutton.Name = "admineklebackbutton"
        Me.admineklebackbutton.Size = New System.Drawing.Size(116, 28)
        Me.admineklebackbutton.TabIndex = 4
        Me.admineklebackbutton.Text = "Kapat"
        Me.admineklebackbutton.UseVisualStyleBackColor = True
        '
        'adminekle
        '
        Me.AcceptButton = Me.adminekleconfirmbutton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpproje.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(265, 193)
        Me.Controls.Add(Me.adminekleconfirmbutton)
        Me.Controls.Add(Me.admineklebackbutton)
        Me.Controls.Add(Me.adminEkleSifre)
        Me.Controls.Add(Me.adminEkleAd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adminkadilabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "adminekle"
        Me.Text = "Admin Ekle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents adminkadilabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents adminEkleAd As System.Windows.Forms.TextBox
    Friend WithEvents adminEkleSifre As System.Windows.Forms.TextBox
    Friend WithEvents adminekleconfirmbutton As System.Windows.Forms.Button
    Friend WithEvents admineklebackbutton As System.Windows.Forms.Button
End Class
