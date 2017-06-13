Imports MySql.Data.MySqlClient

Public Class musterisec
    Dim vbConn As MySqlConnection
    Dim vbCommand As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        odakayit.Enabled = True
    End Sub
    Private Sub musterisecme(sender As Object, e As EventArgs) Handles Me.FormClosed
        odakayit.Enabled = True
        odakayit.Show()
    End Sub

    Private Sub musterisec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select adsoyad,tckno,yas from musteribilgileri where kaldigioda IS NULL"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                ListBox1.Items.Add("" & vbReader("adsoyad") & " | " & vbReader("tckno") & " ( yas:" & vbReader("yas") & " )")
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            Dim secilidegerlendirme As String = ListBox1.GetItemText(ListBox1.SelectedItem)
            Dim arananisim As String = secilidegerlendirme.Substring(0, secilidegerlendirme.IndexOf("|") - 1)
            Dim aranantck As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 2, secilidegerlendirme.IndexOf("(") - secilidegerlendirme.IndexOf("|") - 2)
            Dim arananyas As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf(":") + 1, secilidegerlendirme.IndexOf(")") - secilidegerlendirme.IndexOf(":") - 2)
            If odakayit.seciliolan = 1 Then
                odakayit.TextBox1.Text = arananisim
                odakayit.TextBox2.Text = arananyas
                odakayit.TextBox3.Text = aranantck
                odakayit.musteri1 = True
                odakayit.seciliolan = 0
                odakayit.TextBox1.Enabled = False
                odakayit.TextBox2.Enabled = False
                odakayit.TextBox3.Enabled = False
                odakayit.Button1.Hide()
                odakayit.Button3.Show()
            ElseIf odakayit.seciliolan = 2 Then
                odakayit.TextBox4.Text = arananisim
                odakayit.TextBox5.Text = arananyas
                odakayit.TextBox6.Text = aranantck
                odakayit.musteri2 = True
                odakayit.seciliolan = 0
                odakayit.TextBox4.Enabled = False
                odakayit.TextBox5.Enabled = False
                odakayit.TextBox6.Enabled = False
                odakayit.Button4.Hide()
                odakayit.Button5.Show()
            ElseIf odakayit.seciliolan = 3 Then
                odakayit.TextBox7.Text = arananisim
                odakayit.TextBox8.Text = arananyas
                odakayit.TextBox9.Text = aranantck
                odakayit.musteri3 = True
                odakayit.seciliolan = 0
                odakayit.TextBox7.Enabled = False
                odakayit.TextBox8.Enabled = False
                odakayit.TextBox9.Enabled = False
                odakayit.Button6.Hide()
                odakayit.Button7.Show()
            ElseIf odakayit.seciliolan = 4 Then
                odakayit.TextBox10.Text = arananisim
                odakayit.TextBox11.Text = arananyas
                odakayit.TextBox12.Text = aranantck
                odakayit.musteri4 = True
                odakayit.seciliolan = 0
                odakayit.TextBox10.Enabled = False
                odakayit.TextBox11.Enabled = False
                odakayit.TextBox12.Enabled = False
                odakayit.Button8.Hide()
                odakayit.Button9.Show()
            End If
            odakayit.Enabled = True
            Me.Close()
        Else
            MsgBox("Lütfen bir müşteri seçin!", MsgBoxStyle.Exclamation, "Hata!")
        End If
    End Sub
End Class