<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class musteribilgileri
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(musteribilgileri))
        Me.musteribilgiLB = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.musterigeributton = New System.Windows.Forms.Button()
        Me.musteriadsoyadlabel = New System.Windows.Forms.Label()
        Me.musteritcklabel = New System.Windows.Forms.Label()
        Me.musteriyaslabel = New System.Windows.Forms.Label()
        Me.musteriyetiskincocuklabel = New System.Windows.Forms.Label()
        Me.musteriodalabel = New System.Windows.Forms.Label()
        Me.girisTarih = New System.Windows.Forms.Label()
        Me.cikisTarih = New System.Windows.Forms.Label()
        Me.GirisLabel = New System.Windows.Forms.Label()
        Me.CikisLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'musteribilgiLB
        '
        Me.musteribilgiLB.FormattingEnabled = True
        Me.musteribilgiLB.Location = New System.Drawing.Point(9, 10)
        Me.musteribilgiLB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.musteribilgiLB.Name = "musteribilgiLB"
        Me.musteribilgiLB.Size = New System.Drawing.Size(205, 342)
        Me.musteribilgiLB.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(218, 10)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Ad Soyad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(218, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "TCK No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(218, 90)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Yaş:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(218, 135)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Yetişkin/Çocuk:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(218, 186)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Kaldığı Oda:"
        '
        'musterigeributton
        '
        Me.musterigeributton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.musterigeributton.Image = Global.gpproje.My.Resources.Resources.buttonyellow
        Me.musterigeributton.Location = New System.Drawing.Point(368, 328)
        Me.musterigeributton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.musterigeributton.Name = "musterigeributton"
        Me.musterigeributton.Size = New System.Drawing.Size(106, 29)
        Me.musterigeributton.TabIndex = 19
        Me.musterigeributton.Text = "Geri"
        Me.musterigeributton.UseVisualStyleBackColor = True
        '
        'musteriadsoyadlabel
        '
        Me.musteriadsoyadlabel.AutoSize = True
        Me.musteriadsoyadlabel.BackColor = System.Drawing.Color.Transparent
        Me.musteriadsoyadlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.musteriadsoyadlabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.musteriadsoyadlabel.Location = New System.Drawing.Point(308, 10)
        Me.musteriadsoyadlabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.musteriadsoyadlabel.Name = "musteriadsoyadlabel"
        Me.musteriadsoyadlabel.Size = New System.Drawing.Size(63, 20)
        Me.musteriadsoyadlabel.TabIndex = 36
        Me.musteriadsoyadlabel.Text = "kkkkkk"
        '
        'musteritcklabel
        '
        Me.musteritcklabel.AutoSize = True
        Me.musteritcklabel.BackColor = System.Drawing.Color.Transparent
        Me.musteritcklabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.musteritcklabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.musteritcklabel.Location = New System.Drawing.Point(295, 50)
        Me.musteritcklabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.musteritcklabel.Name = "musteritcklabel"
        Me.musteritcklabel.Size = New System.Drawing.Size(63, 20)
        Me.musteritcklabel.TabIndex = 37
        Me.musteritcklabel.Text = "kkkkkk"
        '
        'musteriyaslabel
        '
        Me.musteriyaslabel.AutoSize = True
        Me.musteriyaslabel.BackColor = System.Drawing.Color.Transparent
        Me.musteriyaslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.musteriyaslabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.musteriyaslabel.Location = New System.Drawing.Point(264, 90)
        Me.musteriyaslabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.musteriyaslabel.Name = "musteriyaslabel"
        Me.musteriyaslabel.Size = New System.Drawing.Size(63, 20)
        Me.musteriyaslabel.TabIndex = 38
        Me.musteriyaslabel.Text = "kkkkkk"
        '
        'musteriyetiskincocuklabel
        '
        Me.musteriyetiskincocuklabel.AutoSize = True
        Me.musteriyetiskincocuklabel.BackColor = System.Drawing.Color.Transparent
        Me.musteriyetiskincocuklabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.musteriyetiskincocuklabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.musteriyetiskincocuklabel.Location = New System.Drawing.Point(345, 135)
        Me.musteriyetiskincocuklabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.musteriyetiskincocuklabel.Name = "musteriyetiskincocuklabel"
        Me.musteriyetiskincocuklabel.Size = New System.Drawing.Size(63, 20)
        Me.musteriyetiskincocuklabel.TabIndex = 39
        Me.musteriyetiskincocuklabel.Text = "kkkkkk"
        '
        'musteriodalabel
        '
        Me.musteriodalabel.AutoSize = True
        Me.musteriodalabel.BackColor = System.Drawing.Color.Transparent
        Me.musteriodalabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.musteriodalabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.musteriodalabel.Location = New System.Drawing.Point(321, 186)
        Me.musteriodalabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.musteriodalabel.Name = "musteriodalabel"
        Me.musteriodalabel.Size = New System.Drawing.Size(63, 20)
        Me.musteriodalabel.TabIndex = 40
        Me.musteriodalabel.Text = "kkkkkk"
        '
        'girisTarih
        '
        Me.girisTarih.AutoSize = True
        Me.girisTarih.BackColor = System.Drawing.Color.Transparent
        Me.girisTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.girisTarih.ForeColor = System.Drawing.Color.Orange
        Me.girisTarih.Location = New System.Drawing.Point(218, 231)
        Me.girisTarih.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.girisTarih.Name = "girisTarih"
        Me.girisTarih.Size = New System.Drawing.Size(100, 20)
        Me.girisTarih.TabIndex = 41
        Me.girisTarih.Text = "Giriş Tarihi:"
        '
        'cikisTarih
        '
        Me.cikisTarih.AutoSize = True
        Me.cikisTarih.BackColor = System.Drawing.Color.Transparent
        Me.cikisTarih.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cikisTarih.ForeColor = System.Drawing.Color.Orange
        Me.cikisTarih.Location = New System.Drawing.Point(216, 279)
        Me.cikisTarih.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.cikisTarih.Name = "cikisTarih"
        Me.cikisTarih.Size = New System.Drawing.Size(101, 20)
        Me.cikisTarih.TabIndex = 42
        Me.cikisTarih.Text = "Çıkış Tarihi:"
        '
        'GirisLabel
        '
        Me.GirisLabel.AutoSize = True
        Me.GirisLabel.BackColor = System.Drawing.Color.Transparent
        Me.GirisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GirisLabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.GirisLabel.Location = New System.Drawing.Point(321, 231)
        Me.GirisLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GirisLabel.Name = "GirisLabel"
        Me.GirisLabel.Size = New System.Drawing.Size(63, 20)
        Me.GirisLabel.TabIndex = 43
        Me.GirisLabel.Text = "kkkkkk"
        '
        'CikisLabel
        '
        Me.CikisLabel.AutoSize = True
        Me.CikisLabel.BackColor = System.Drawing.Color.Transparent
        Me.CikisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CikisLabel.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.CikisLabel.Location = New System.Drawing.Point(321, 279)
        Me.CikisLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CikisLabel.Name = "CikisLabel"
        Me.CikisLabel.Size = New System.Drawing.Size(63, 20)
        Me.CikisLabel.TabIndex = 44
        Me.CikisLabel.Text = "kkkkkk"
        '
        'musteribilgileri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpproje.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(508, 369)
        Me.Controls.Add(Me.CikisLabel)
        Me.Controls.Add(Me.GirisLabel)
        Me.Controls.Add(Me.cikisTarih)
        Me.Controls.Add(Me.girisTarih)
        Me.Controls.Add(Me.musteriodalabel)
        Me.Controls.Add(Me.musteriyetiskincocuklabel)
        Me.Controls.Add(Me.musteriyaslabel)
        Me.Controls.Add(Me.musteritcklabel)
        Me.Controls.Add(Me.musteriadsoyadlabel)
        Me.Controls.Add(Me.musterigeributton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.musteribilgiLB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "musteribilgileri"
        Me.Text = "Müşteri Bilgileri"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents musteribilgiLB As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents musterigeributton As System.Windows.Forms.Button
    Friend WithEvents musteriadsoyadlabel As System.Windows.Forms.Label
    Friend WithEvents musteritcklabel As System.Windows.Forms.Label
    Friend WithEvents musteriyaslabel As System.Windows.Forms.Label
    Friend WithEvents musteriyetiskincocuklabel As System.Windows.Forms.Label
    Friend WithEvents musteriodalabel As System.Windows.Forms.Label
    Friend WithEvents girisTarih As System.Windows.Forms.Label
    Friend WithEvents cikisTarih As System.Windows.Forms.Label
    Friend WithEvents GirisLabel As System.Windows.Forms.Label
    Friend WithEvents CikisLabel As System.Windows.Forms.Label
End Class
