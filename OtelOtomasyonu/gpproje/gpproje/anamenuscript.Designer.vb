<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anamenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anamenu))
        Me.hosgeldinlb = New System.Windows.Forms.Label()
        Me.yetkidurumlb = New System.Windows.Forms.Label()
        Me.yetkilb = New System.Windows.Forms.Label()
        Me.admingirisbutton = New System.Windows.Forms.Button()
        Me.admincikisbutton = New System.Windows.Forms.Button()
        Me.odabilgibutton = New System.Windows.Forms.Button()
        Me.isbasvurubutton = New System.Windows.Forms.Button()
        Me.calisanbilgibutton = New System.Windows.Forms.Button()
        Me.hakkimizdabutton = New System.Windows.Forms.Button()
        Me.musteribilgibutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.basvurulistebutton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.odakayitbutton = New System.Windows.Forms.Button()
        Me.degerlendirmelerbutton = New System.Windows.Forms.Button()
        Me.odaayarlaributton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'hosgeldinlb
        '
        Me.hosgeldinlb.AutoSize = True
        Me.hosgeldinlb.BackColor = System.Drawing.Color.Transparent
        Me.hosgeldinlb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hosgeldinlb.Font = New System.Drawing.Font("MS Reference Sans Serif", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hosgeldinlb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.hosgeldinlb.Location = New System.Drawing.Point(213, 18)
        Me.hosgeldinlb.Name = "hosgeldinlb"
        Me.hosgeldinlb.Size = New System.Drawing.Size(396, 74)
        Me.hosgeldinlb.TabIndex = 0
        Me.hosgeldinlb.Text = "Hoşgeldiniz!"
        '
        'yetkidurumlb
        '
        Me.yetkidurumlb.AutoSize = True
        Me.yetkidurumlb.BackColor = System.Drawing.Color.Transparent
        Me.yetkidurumlb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yetkidurumlb.ForeColor = System.Drawing.Color.Black
        Me.yetkidurumlb.Location = New System.Drawing.Point(609, 386)
        Me.yetkidurumlb.Name = "yetkidurumlb"
        Me.yetkidurumlb.Size = New System.Drawing.Size(110, 17)
        Me.yetkidurumlb.TabIndex = 1
        Me.yetkidurumlb.Text = "Yetki Durumu:"
        '
        'yetkilb
        '
        Me.yetkilb.AutoSize = True
        Me.yetkilb.BackColor = System.Drawing.Color.Transparent
        Me.yetkilb.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yetkilb.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.yetkilb.Location = New System.Drawing.Point(725, 386)
        Me.yetkilb.Name = "yetkilb"
        Me.yetkilb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.yetkilb.Size = New System.Drawing.Size(56, 17)
        Me.yetkilb.TabIndex = 2
        Me.yetkilb.Text = "Misafir"
        '
        'admingirisbutton
        '
        Me.admingirisbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.admingirisbutton.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.admingirisbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admingirisbutton.Location = New System.Drawing.Point(603, 418)
        Me.admingirisbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.admingirisbutton.Name = "admingirisbutton"
        Me.admingirisbutton.Size = New System.Drawing.Size(141, 26)
        Me.admingirisbutton.TabIndex = 3
        Me.admingirisbutton.Text = "Admin Giriş"
        Me.admingirisbutton.UseVisualStyleBackColor = True
        '
        'admincikisbutton
        '
        Me.admincikisbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.buttonred
        Me.admincikisbutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.admincikisbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.admincikisbutton.Location = New System.Drawing.Point(751, 418)
        Me.admincikisbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.admincikisbutton.Name = "admincikisbutton"
        Me.admincikisbutton.Size = New System.Drawing.Size(63, 26)
        Me.admincikisbutton.TabIndex = 4
        Me.admincikisbutton.Text = "Çıkış"
        Me.admincikisbutton.UseVisualStyleBackColor = True
        Me.admincikisbutton.Visible = False
        '
        'odabilgibutton
        '
        Me.odabilgibutton.BackColor = System.Drawing.Color.White
        Me.odabilgibutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.odabilgibutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.odabilgibutton.FlatAppearance.BorderSize = 3
        Me.odabilgibutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.odabilgibutton.Location = New System.Drawing.Point(327, 162)
        Me.odabilgibutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.odabilgibutton.Name = "odabilgibutton"
        Me.odabilgibutton.Size = New System.Drawing.Size(185, 44)
        Me.odabilgibutton.TabIndex = 0
        Me.odabilgibutton.Text = "Oda Durumu"
        Me.odabilgibutton.UseVisualStyleBackColor = False
        '
        'isbasvurubutton
        '
        Me.isbasvurubutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.isbasvurubutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.isbasvurubutton.FlatAppearance.BorderSize = 3
        Me.isbasvurubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.isbasvurubutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.isbasvurubutton.ForeColor = System.Drawing.Color.Black
        Me.isbasvurubutton.Location = New System.Drawing.Point(581, 226)
        Me.isbasvurubutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.isbasvurubutton.Name = "isbasvurubutton"
        Me.isbasvurubutton.Size = New System.Drawing.Size(185, 44)
        Me.isbasvurubutton.TabIndex = 8
        Me.isbasvurubutton.Text = "İş Başvurusu"
        Me.isbasvurubutton.UseVisualStyleBackColor = True
        '
        'calisanbilgibutton
        '
        Me.calisanbilgibutton.BackColor = System.Drawing.Color.White
        Me.calisanbilgibutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.calisanbilgibutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.calisanbilgibutton.FlatAppearance.BorderSize = 3
        Me.calisanbilgibutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.calisanbilgibutton.Location = New System.Drawing.Point(327, 286)
        Me.calisanbilgibutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calisanbilgibutton.Name = "calisanbilgibutton"
        Me.calisanbilgibutton.Size = New System.Drawing.Size(185, 44)
        Me.calisanbilgibutton.TabIndex = 0
        Me.calisanbilgibutton.Text = "Çalışan Bilgileri"
        Me.calisanbilgibutton.UseVisualStyleBackColor = False
        '
        'hakkimizdabutton
        '
        Me.hakkimizdabutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.hakkimizdabutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.hakkimizdabutton.FlatAppearance.BorderSize = 3
        Me.hakkimizdabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.hakkimizdabutton.Location = New System.Drawing.Point(581, 162)
        Me.hakkimizdabutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.hakkimizdabutton.Name = "hakkimizdabutton"
        Me.hakkimizdabutton.Size = New System.Drawing.Size(185, 44)
        Me.hakkimizdabutton.TabIndex = 10
        Me.hakkimizdabutton.Text = "Hakkımızda"
        Me.hakkimizdabutton.UseVisualStyleBackColor = True
        '
        'musteribilgibutton
        '
        Me.musteribilgibutton.BackColor = System.Drawing.Color.White
        Me.musteribilgibutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.musteribilgibutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.musteribilgibutton.FlatAppearance.BorderSize = 3
        Me.musteribilgibutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.musteribilgibutton.Location = New System.Drawing.Point(327, 226)
        Me.musteribilgibutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.musteribilgibutton.Name = "musteribilgibutton"
        Me.musteribilgibutton.Size = New System.Drawing.Size(185, 44)
        Me.musteribilgibutton.TabIndex = 0
        Me.musteribilgibutton.Text = "Müşteri Bilgileri"
        Me.musteribilgibutton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(627, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 34)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Otel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(357, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 34)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Listeler"
        '
        'basvurulistebutton
        '
        Me.basvurulistebutton.BackColor = System.Drawing.Color.White
        Me.basvurulistebutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.basvurulistebutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.basvurulistebutton.FlatAppearance.BorderSize = 3
        Me.basvurulistebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.basvurulistebutton.Location = New System.Drawing.Point(327, 346)
        Me.basvurulistebutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulistebutton.Name = "basvurulistebutton"
        Me.basvurulistebutton.Size = New System.Drawing.Size(185, 44)
        Me.basvurulistebutton.TabIndex = 14
        Me.basvurulistebutton.Text = "Başvuru Listesi"
        Me.basvurulistebutton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Lucida Bright", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(48, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(214, 34)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Oda İşlemleri"
        '
        'odakayitbutton
        '
        Me.odakayitbutton.BackColor = System.Drawing.Color.White
        Me.odakayitbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.odakayitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.odakayitbutton.FlatAppearance.BorderSize = 3
        Me.odakayitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.odakayitbutton.Location = New System.Drawing.Point(65, 162)
        Me.odakayitbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.odakayitbutton.Name = "odakayitbutton"
        Me.odakayitbutton.Size = New System.Drawing.Size(185, 44)
        Me.odakayitbutton.TabIndex = 0
        Me.odakayitbutton.Text = "Oda Kayıt"
        Me.odakayitbutton.UseVisualStyleBackColor = False
        '
        'degerlendirmelerbutton
        '
        Me.degerlendirmelerbutton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.degerlendirmelerbutton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.degerlendirmelerbutton.FlatAppearance.BorderSize = 3
        Me.degerlendirmelerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.degerlendirmelerbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.degerlendirmelerbutton.ForeColor = System.Drawing.Color.Black
        Me.degerlendirmelerbutton.Location = New System.Drawing.Point(581, 286)
        Me.degerlendirmelerbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.degerlendirmelerbutton.Name = "degerlendirmelerbutton"
        Me.degerlendirmelerbutton.Size = New System.Drawing.Size(185, 44)
        Me.degerlendirmelerbutton.TabIndex = 17
        Me.degerlendirmelerbutton.Text = "Değerlendirmeler"
        Me.degerlendirmelerbutton.UseVisualStyleBackColor = True
        '
        'odaayarlaributton
        '
        Me.odaayarlaributton.BackColor = System.Drawing.Color.White
        Me.odaayarlaributton.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.odaayarlaributton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.odaayarlaributton.FlatAppearance.BorderSize = 3
        Me.odaayarlaributton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.odaayarlaributton.Location = New System.Drawing.Point(65, 226)
        Me.odaayarlaributton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.odaayarlaributton.Name = "odaayarlaributton"
        Me.odaayarlaributton.Size = New System.Drawing.Size(185, 44)
        Me.odaayarlaributton.TabIndex = 0
        Me.odaayarlaributton.Text = "Oda Ayarları"
        Me.odaayarlaributton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.gpproje.My.Resources.Resources.button
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(15, 418)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 26)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Admin Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Anamenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.gpproje.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(839, 468)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.odaayarlaributton)
        Me.Controls.Add(Me.degerlendirmelerbutton)
        Me.Controls.Add(Me.odakayitbutton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.basvurulistebutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.musteribilgibutton)
        Me.Controls.Add(Me.hakkimizdabutton)
        Me.Controls.Add(Me.calisanbilgibutton)
        Me.Controls.Add(Me.isbasvurubutton)
        Me.Controls.Add(Me.odabilgibutton)
        Me.Controls.Add(Me.admincikisbutton)
        Me.Controls.Add(Me.admingirisbutton)
        Me.Controls.Add(Me.yetkilb)
        Me.Controls.Add(Me.yetkidurumlb)
        Me.Controls.Add(Me.hosgeldinlb)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Anamenu"
        Me.Text = "Otel Otomasyonu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hosgeldinlb As System.Windows.Forms.Label
    Friend WithEvents yetkidurumlb As System.Windows.Forms.Label
    Friend WithEvents yetkilb As System.Windows.Forms.Label
    Friend WithEvents admingirisbutton As System.Windows.Forms.Button
    Friend WithEvents admincikisbutton As System.Windows.Forms.Button
    Friend WithEvents odabilgibutton As System.Windows.Forms.Button
    Friend WithEvents isbasvurubutton As System.Windows.Forms.Button
    Friend WithEvents calisanbilgibutton As System.Windows.Forms.Button
    Friend WithEvents hakkimizdabutton As System.Windows.Forms.Button
    Friend WithEvents musteribilgibutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents basvurulistebutton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents odakayitbutton As System.Windows.Forms.Button
    Friend WithEvents degerlendirmelerbutton As System.Windows.Forms.Button
    Friend WithEvents odaayarlaributton As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
