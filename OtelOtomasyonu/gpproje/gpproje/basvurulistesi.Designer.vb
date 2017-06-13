<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basvurulistesi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(basvurulistesi))
        Me.basvurulisteLB = New System.Windows.Forms.ListBox()
        Me.basvurulisteyenilebutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.basvurulisteozgecmisTB = New System.Windows.Forms.TextBox()
        Me.basvurulistekabuletbutton = New System.Windows.Forms.Button()
        Me.basvurulistereddetbutton = New System.Windows.Forms.Button()
        Me.basvurulistegeributton = New System.Windows.Forms.Button()
        Me.basvurulisteadsoyadlabel = New System.Windows.Forms.Label()
        Me.basvurulistealanlabel = New System.Windows.Forms.Label()
        Me.basvurulistetcklabel = New System.Windows.Forms.Label()
        Me.basvurulisteyaslabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'basvurulisteLB
        '
        Me.basvurulisteLB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.basvurulisteLB.FormattingEnabled = True
        Me.basvurulisteLB.ItemHeight = 16
        Me.basvurulisteLB.Location = New System.Drawing.Point(12, 12)
        Me.basvurulisteLB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulisteLB.Name = "basvurulisteLB"
        Me.basvurulisteLB.Size = New System.Drawing.Size(237, 436)
        Me.basvurulisteLB.TabIndex = 0
        '
        'basvurulisteyenilebutton
        '
        Me.basvurulisteyenilebutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulisteyenilebutton.Image = Global.gpproje.My.Resources.Resources.button
        Me.basvurulisteyenilebutton.Location = New System.Drawing.Point(12, 454)
        Me.basvurulisteyenilebutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulisteyenilebutton.Name = "basvurulisteyenilebutton"
        Me.basvurulisteyenilebutton.Size = New System.Drawing.Size(233, 36)
        Me.basvurulisteyenilebutton.TabIndex = 1
        Me.basvurulisteyenilebutton.Text = "Yenile"
        Me.basvurulisteyenilebutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(268, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ad Soyad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(268, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Başvurduğu Alan:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(268, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "TCK No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(268, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Yaş:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(268, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Özgeçmiş"
        '
        'basvurulisteozgecmisTB
        '
        Me.basvurulisteozgecmisTB.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.basvurulisteozgecmisTB.Location = New System.Drawing.Point(276, 242)
        Me.basvurulisteozgecmisTB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulisteozgecmisTB.Multiline = True
        Me.basvurulisteozgecmisTB.Name = "basvurulisteozgecmisTB"
        Me.basvurulisteozgecmisTB.ReadOnly = True
        Me.basvurulisteozgecmisTB.Size = New System.Drawing.Size(391, 205)
        Me.basvurulisteozgecmisTB.TabIndex = 7
        Me.basvurulisteozgecmisTB.Text = "5"
        '
        'basvurulistekabuletbutton
        '
        Me.basvurulistekabuletbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulistekabuletbutton.Image = Global.gpproje.My.Resources.Resources.button
        Me.basvurulistekabuletbutton.Location = New System.Drawing.Point(276, 454)
        Me.basvurulistekabuletbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulistekabuletbutton.Name = "basvurulistekabuletbutton"
        Me.basvurulistekabuletbutton.Size = New System.Drawing.Size(139, 36)
        Me.basvurulistekabuletbutton.TabIndex = 8
        Me.basvurulistekabuletbutton.Text = "Kabul Et"
        Me.basvurulistekabuletbutton.UseVisualStyleBackColor = True
        '
        'basvurulistereddetbutton
        '
        Me.basvurulistereddetbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulistereddetbutton.Image = Global.gpproje.My.Resources.Resources.buttonred
        Me.basvurulistereddetbutton.Location = New System.Drawing.Point(436, 454)
        Me.basvurulistereddetbutton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulistereddetbutton.Name = "basvurulistereddetbutton"
        Me.basvurulistereddetbutton.Size = New System.Drawing.Size(139, 36)
        Me.basvurulistereddetbutton.TabIndex = 9
        Me.basvurulistereddetbutton.Text = "Reddet"
        Me.basvurulistereddetbutton.UseVisualStyleBackColor = True
        '
        'basvurulistegeributton
        '
        Me.basvurulistegeributton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulistegeributton.Image = Global.gpproje.My.Resources.Resources.buttonyellow
        Me.basvurulistegeributton.Location = New System.Drawing.Point(589, 454)
        Me.basvurulistegeributton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.basvurulistegeributton.Name = "basvurulistegeributton"
        Me.basvurulistegeributton.Size = New System.Drawing.Size(77, 36)
        Me.basvurulistegeributton.TabIndex = 10
        Me.basvurulistegeributton.Text = "Geri"
        Me.basvurulistegeributton.UseVisualStyleBackColor = True
        '
        'basvurulisteadsoyadlabel
        '
        Me.basvurulisteadsoyadlabel.AutoSize = True
        Me.basvurulisteadsoyadlabel.BackColor = System.Drawing.Color.Transparent
        Me.basvurulisteadsoyadlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulisteadsoyadlabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.basvurulisteadsoyadlabel.Location = New System.Drawing.Point(388, 12)
        Me.basvurulisteadsoyadlabel.Name = "basvurulisteadsoyadlabel"
        Me.basvurulisteadsoyadlabel.Size = New System.Drawing.Size(67, 25)
        Me.basvurulisteadsoyadlabel.TabIndex = 11
        Me.basvurulisteadsoyadlabel.Text = "kkkkk"
        '
        'basvurulistealanlabel
        '
        Me.basvurulistealanlabel.AutoSize = True
        Me.basvurulistealanlabel.BackColor = System.Drawing.Color.Transparent
        Me.basvurulistealanlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulistealanlabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.basvurulistealanlabel.Location = New System.Drawing.Point(459, 57)
        Me.basvurulistealanlabel.Name = "basvurulistealanlabel"
        Me.basvurulistealanlabel.Size = New System.Drawing.Size(67, 25)
        Me.basvurulistealanlabel.TabIndex = 12
        Me.basvurulistealanlabel.Text = "kkkkk"
        '
        'basvurulistetcklabel
        '
        Me.basvurulistetcklabel.AutoSize = True
        Me.basvurulistetcklabel.BackColor = System.Drawing.Color.Transparent
        Me.basvurulistetcklabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulistetcklabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.basvurulistetcklabel.Location = New System.Drawing.Point(363, 107)
        Me.basvurulistetcklabel.Name = "basvurulistetcklabel"
        Me.basvurulistetcklabel.Size = New System.Drawing.Size(67, 25)
        Me.basvurulistetcklabel.TabIndex = 13
        Me.basvurulistetcklabel.Text = "kkkkk"
        '
        'basvurulisteyaslabel
        '
        Me.basvurulisteyaslabel.AutoSize = True
        Me.basvurulisteyaslabel.BackColor = System.Drawing.Color.Transparent
        Me.basvurulisteyaslabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basvurulisteyaslabel.ForeColor = System.Drawing.Color.DarkKhaki
        Me.basvurulisteyaslabel.Location = New System.Drawing.Point(331, 155)
        Me.basvurulisteyaslabel.Name = "basvurulisteyaslabel"
        Me.basvurulisteyaslabel.Size = New System.Drawing.Size(67, 25)
        Me.basvurulisteyaslabel.TabIndex = 14
        Me.basvurulisteyaslabel.Text = "kkkkk"
        '
        'basvurulistesi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gpproje.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(669, 494)
        Me.Controls.Add(Me.basvurulisteyaslabel)
        Me.Controls.Add(Me.basvurulistetcklabel)
        Me.Controls.Add(Me.basvurulistealanlabel)
        Me.Controls.Add(Me.basvurulisteadsoyadlabel)
        Me.Controls.Add(Me.basvurulistegeributton)
        Me.Controls.Add(Me.basvurulistereddetbutton)
        Me.Controls.Add(Me.basvurulistekabuletbutton)
        Me.Controls.Add(Me.basvurulisteozgecmisTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.basvurulisteyenilebutton)
        Me.Controls.Add(Me.basvurulisteLB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "basvurulistesi"
        Me.Text = "İş Başvuruları"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents basvurulisteLB As System.Windows.Forms.ListBox
    Friend WithEvents basvurulisteyenilebutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents basvurulisteozgecmisTB As System.Windows.Forms.TextBox
    Friend WithEvents basvurulistekabuletbutton As System.Windows.Forms.Button
    Friend WithEvents basvurulistereddetbutton As System.Windows.Forms.Button
    Friend WithEvents basvurulistegeributton As System.Windows.Forms.Button
    Friend WithEvents basvurulisteadsoyadlabel As System.Windows.Forms.Label
    Friend WithEvents basvurulistealanlabel As System.Windows.Forms.Label
    Friend WithEvents basvurulistetcklabel As System.Windows.Forms.Label
    Friend WithEvents basvurulisteyaslabel As System.Windows.Forms.Label
End Class
