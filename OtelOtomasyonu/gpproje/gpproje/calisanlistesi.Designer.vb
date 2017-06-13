<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calisanlistesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calisanlistesi))
        Me.calisanlisteLB = New System.Windows.Forms.ListBox()
        Me.calisanlisteyenilebutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.calisanlisteozgecmisTB = New System.Windows.Forms.TextBox()
        Me.calisanlistekovbutton = New System.Windows.Forms.Button()
        Me.calisanlistegeributton = New System.Windows.Forms.Button()
        Me.calisanlisteadsoyadlabel = New System.Windows.Forms.Label()
        Me.calisanlistealanlabel = New System.Windows.Forms.Label()
        Me.calisanlistetcklabel = New System.Windows.Forms.Label()
        Me.calisanlisteyaslabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calisanlisteLB
        '
        Me.calisanlisteLB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.calisanlisteLB.FormattingEnabled = True
        Me.calisanlisteLB.ItemHeight = 16
        Me.calisanlisteLB.Location = New System.Drawing.Point(12, 12)
        Me.calisanlisteLB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calisanlisteLB.Name = "calisanlisteLB"
        Me.calisanlisteLB.Size = New System.Drawing.Size(237, 436)
        Me.calisanlisteLB.TabIndex = 1
        '
        'calisanlisteyenilebutton
        '
        Me.calisanlisteyenilebutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlisteyenilebutton.Image = Global.gpproje.My.Resources.Resources.button
        Me.calisanlisteyenilebutton.Location = New System.Drawing.Point(12, 462)
        Me.calisanlisteyenilebutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calisanlisteyenilebutton.Name = "calisanlisteyenilebutton"
        Me.calisanlisteyenilebutton.Size = New System.Drawing.Size(237, 36)
        Me.calisanlisteyenilebutton.TabIndex = 2
        Me.calisanlisteyenilebutton.Text = "Yenile"
        Me.calisanlisteyenilebutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(264, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ad Soyad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(264, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Çalıştığı Alan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(264, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TCK No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(264, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Yaş:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(269, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Özgeçmiş"
        '
        'calisanlisteozgecmisTB
        '
        Me.calisanlisteozgecmisTB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.calisanlisteozgecmisTB.Location = New System.Drawing.Point(269, 231)
        Me.calisanlisteozgecmisTB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calisanlisteozgecmisTB.Multiline = True
        Me.calisanlisteozgecmisTB.Name = "calisanlisteozgecmisTB"
        Me.calisanlisteozgecmisTB.ReadOnly = True
        Me.calisanlisteozgecmisTB.Size = New System.Drawing.Size(391, 217)
        Me.calisanlisteozgecmisTB.TabIndex = 8
        '
        'calisanlistekovbutton
        '
        Me.calisanlistekovbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlistekovbutton.Image = Global.gpproje.My.Resources.Resources.buttonred
        Me.calisanlistekovbutton.Location = New System.Drawing.Point(269, 462)
        Me.calisanlistekovbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calisanlistekovbutton.Name = "calisanlistekovbutton"
        Me.calisanlistekovbutton.Size = New System.Drawing.Size(179, 36)
        Me.calisanlistekovbutton.TabIndex = 10
        Me.calisanlistekovbutton.Text = "İşten Çıkar"
        Me.calisanlistekovbutton.UseVisualStyleBackColor = True
        '
        'calisanlistegeributton
        '
        Me.calisanlistegeributton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlistegeributton.Image = Global.gpproje.My.Resources.Resources.buttonyellow
        Me.calisanlistegeributton.Location = New System.Drawing.Point(485, 462)
        Me.calisanlistegeributton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.calisanlistegeributton.Name = "calisanlistegeributton"
        Me.calisanlistegeributton.Size = New System.Drawing.Size(175, 36)
        Me.calisanlistegeributton.TabIndex = 11
        Me.calisanlistegeributton.Text = "Geri"
        Me.calisanlistegeributton.UseVisualStyleBackColor = True
        '
        'calisanlisteadsoyadlabel
        '
        Me.calisanlisteadsoyadlabel.AutoSize = True
        Me.calisanlisteadsoyadlabel.BackColor = System.Drawing.Color.Transparent
        Me.calisanlisteadsoyadlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlisteadsoyadlabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.calisanlisteadsoyadlabel.Location = New System.Drawing.Point(381, 12)
        Me.calisanlisteadsoyadlabel.Name = "calisanlisteadsoyadlabel"
        Me.calisanlisteadsoyadlabel.Size = New System.Drawing.Size(67, 25)
        Me.calisanlisteadsoyadlabel.TabIndex = 12
        Me.calisanlisteadsoyadlabel.Text = "kkkkk"
        '
        'calisanlistealanlabel
        '
        Me.calisanlistealanlabel.AutoSize = True
        Me.calisanlistealanlabel.BackColor = System.Drawing.Color.Transparent
        Me.calisanlistealanlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlistealanlabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.calisanlistealanlabel.Location = New System.Drawing.Point(427, 52)
        Me.calisanlistealanlabel.Name = "calisanlistealanlabel"
        Me.calisanlistealanlabel.Size = New System.Drawing.Size(67, 25)
        Me.calisanlistealanlabel.TabIndex = 13
        Me.calisanlistealanlabel.Text = "kkkkk"
        '
        'calisanlistetcklabel
        '
        Me.calisanlistetcklabel.AutoSize = True
        Me.calisanlistetcklabel.BackColor = System.Drawing.Color.Transparent
        Me.calisanlistetcklabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlistetcklabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.calisanlistetcklabel.Location = New System.Drawing.Point(367, 94)
        Me.calisanlistetcklabel.Name = "calisanlistetcklabel"
        Me.calisanlistetcklabel.Size = New System.Drawing.Size(67, 25)
        Me.calisanlistetcklabel.TabIndex = 14
        Me.calisanlistetcklabel.Text = "kkkkk"
        '
        'calisanlisteyaslabel
        '
        Me.calisanlisteyaslabel.AutoSize = True
        Me.calisanlisteyaslabel.BackColor = System.Drawing.Color.Transparent
        Me.calisanlisteyaslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calisanlisteyaslabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.calisanlisteyaslabel.Location = New System.Drawing.Point(325, 142)
        Me.calisanlisteyaslabel.Name = "calisanlisteyaslabel"
        Me.calisanlisteyaslabel.Size = New System.Drawing.Size(67, 25)
        Me.calisanlisteyaslabel.TabIndex = 15
        Me.calisanlisteyaslabel.Text = "kkkkk"
        '
        'calisanlistesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpproje.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(669, 510)
        Me.Controls.Add(Me.calisanlisteyaslabel)
        Me.Controls.Add(Me.calisanlistetcklabel)
        Me.Controls.Add(Me.calisanlistealanlabel)
        Me.Controls.Add(Me.calisanlisteadsoyadlabel)
        Me.Controls.Add(Me.calisanlistegeributton)
        Me.Controls.Add(Me.calisanlistekovbutton)
        Me.Controls.Add(Me.calisanlisteozgecmisTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calisanlisteyenilebutton)
        Me.Controls.Add(Me.calisanlisteLB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "calisanlistesi"
        Me.Text = "Çalışan Listesi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calisanlisteLB As System.Windows.Forms.ListBox
    Friend WithEvents calisanlisteyenilebutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents calisanlisteozgecmisTB As System.Windows.Forms.TextBox
    Friend WithEvents calisanlistekovbutton As System.Windows.Forms.Button
    Friend WithEvents calisanlistegeributton As System.Windows.Forms.Button
    Friend WithEvents calisanlisteadsoyadlabel As System.Windows.Forms.Label
    Friend WithEvents calisanlistealanlabel As System.Windows.Forms.Label
    Friend WithEvents calisanlistetcklabel As System.Windows.Forms.Label
    Friend WithEvents calisanlisteyaslabel As System.Windows.Forms.Label
End Class
