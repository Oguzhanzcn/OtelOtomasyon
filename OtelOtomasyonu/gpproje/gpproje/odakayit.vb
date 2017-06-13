Imports MySql.Data.MySqlClient

Public Class odakayit
    Dim kontrol As New Kontrol
    Dim odaNesne As New Oda
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2, vbCommand3 As MySqlCommand
    Dim Odalar(100) As String
    Friend Property musteri1 = False
    Friend Property musteri2 = False
    Friend Property musteri3 = False
    Friend Property musteri4 = False
    Friend Property seciliolan As Integer = 0

    Private Sub musterigeributton_Click(sender As Object, e As EventArgs) Handles musterigeributton.Click ' GERI TUSU
        textboxTemizle()
        Me.Close()
        Anamenu.Show()
    End Sub

    Private Sub odakayit_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' FORM ACILIRKEN DUZENLEMELER
        ComboBox2.Text = "Tüm Odalar"
        loadOdaRezervasyonFiltre("*")
        odakayitMusteriSayisi("0")
    End Sub

    Function loadOdaRezervasyonFiltre(ByVal X As String) ' LISTBOXU DOLDURUYOR
        ListBox2.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Dim sayac As Integer
        sayac = 0
        Try
            vbConn.Open()
            Dim Query As String
            If X = "*" Then
                Query = "select odano,odatur from odabilgileri where odastatu = 'bos'"
            Else
                Query = "select odano,odatur from odabilgileri where odastatu = 'bos' and odatur = '" & X & "'"
            End If
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                Odalar(sayac) = vbReader("odano")
                girdistring = "" & vbReader("odatur") & " | " & vbReader("odano") & ""
                ListBox2.Items.Add(girdistring)
                sayac += 1
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            musteriadsoyadlabel.Text = "-"
            Label7.Text = "-"
            Label8.Text = "-"
            Label9.Text = "-"
            Label10.Text = "-"
            Label10.ForeColor = Color.AntiqueWhite
            ComboBox1.Text = "1"
            DateTimePicker1.Value = Date.Today
            DateTimePicker2.Value = Date.Today
            odakayitMusteriSayisi("1")
        End Try
        Return 1
    End Function

    Function odakayitMusteriSayisi(ByVal X As String) ' MUSTERI SAYISINA GORE AYARLARI GOSTERIYOR/KAPATIYOR
        Button3.Hide()
        Button5.Hide()
        Button7.Hide()
        Button9.Hide()
        If X = "0" Then
            Me.Width = 600
            ComboBox1.Text = "0"

            ComboBox1.Enabled = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            Button1.Hide()

            Label13.Visible = False
            Label24.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            Button4.Hide()

        ElseIf X = "1" Then
            Me.Width = 600
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Button1.Show()

            Label13.Visible = False
            Label24.Visible = False
            Label22.Visible = False
            Label23.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox6.Visible = False
            Button4.Hide()
        ElseIf X = "2" Then
            Me.Width = 600
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Button1.Show()

            Label13.Visible = True
            Label24.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            Button4.Show()
        ElseIf X = "3" Then
            Me.Width = 1000
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Button1.Show()

            Label13.Visible = True
            Label24.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            Button4.Show()

            Label12.Visible = True
            Label16.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            Button6.Show()

            Label14.Visible = False
            Label25.Visible = False
            Label26.Visible = False
            Label27.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False
            TextBox12.Visible = False
            Button8.Hide()
        ElseIf X = "4" Then
            Me.Width = 1000
            TextBox1.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Button1.Show()

            Label13.Visible = True
            Label24.Visible = True
            Label22.Visible = True
            Label23.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox6.Visible = True
            Button4.Show()

            Label12.Visible = True
            Label16.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            Button6.Show()

            Label14.Visible = True
            Label25.Visible = True
            Label26.Visible = True
            Label27.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
            TextBox12.Visible = True
            Button8.Show()
        End If
        Return 1
    End Function

    Function odaTipiKalacakSayisi(ByVal X As String) ' ODA TIPINA GORE KALACAK SAYILARI(TEK KISILIK ODA TEK KISI VS)
        If X = "Tek Kisilik" Then
            ComboBox1.Text = "1"
            ComboBox1.Enabled = False
            odakayitMusteriSayisi("1")
        ElseIf X = "Cift Kisilik" Then
            ComboBox1.Text = "2"
            ComboBox1.Enabled = False
            odakayitMusteriSayisi("2")
        ElseIf X = "Kral Dairesi" Then
            odakayitMusteriSayisi("1")
            ComboBox1.Text = "1"
            ComboBox1.Enabled = True
        ElseIf X = "Suit" Then
            odakayitMusteriSayisi("1")
            ComboBox1.Text = "1"
            ComboBox1.Enabled = True
        End If
        Return 1
    End Function

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged ' ODA SECIMLERI
        If ListBox2.SelectedIndex <> -1 Then
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = ListBox2.GetItemText(ListBox2.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select * from odabilgileri where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    musteriadsoyadlabel.Text = vbReader("odano")
                    Label7.Text = vbReader("odatur")
                    Label8.Text = vbReader("odafiyati")
                    If vbReader("odamanzarasi") = "evet" Then
                        Label9.Text = "Evet"
                    Else
                        Label9.Text = "Hayır"
                    End If
                    If vbReader("odastatu") = "bos" Then
                        Label10.Text = "Boş"
                        Label10.ForeColor = Color.ForestGreen
                    Else
                        Label10.Text = "Dolu"
                        Label10.ForeColor = Color.IndianRed
                    End If
                    textboxTemizle()
                    odaTipiKalacakSayisi(vbReader("odatur"))
                    DateTimePicker1.Value = Date.Today
                    DateTimePicker2.Value = Date.Today
                End While
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                toplamFiyatGoster()
            End Try
        End If
    End Sub

    Private Sub odabilgiyenilebutton_Click(sender As Object, e As EventArgs) Handles odabilgiyenilebutton.Click ' ODA YENILE TUSU
        If ComboBox2.Text <> "Tüm Odalar" Then
            loadOdaRezervasyonFiltre(ComboBox2.Text)
        Else
            loadOdaRezervasyonFiltre("*")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged ' ODADA KALACAK KISI SAYISI DEGISTIR
        odakayitMusteriSayisi(ComboBox1.Text)
        If ListBox2.SelectedIndex = -1 Then
            ComboBox1.Enabled = False
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged 'ODA FILTIRE
        If ComboBox2.Text <> "Tüm Odalar" Then
            loadOdaRezervasyonFiltre(ComboBox2.Text)
        Else
            loadOdaRezervasyonFiltre("*")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'ODA REZERVASYON YAP
        If ListBox2.SelectedIndex <> -1 Then
            If musteriBilgileriCheck(ComboBox1.Text) Then
                If CDate(DateTimePicker1.Value.Date) <= CDate(DateTimePicker2.Value.Date) Then
                    If ComboBox1.Text = "1" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then
                        GoTo islem
                    ElseIf ComboBox1.Text = "2" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" Then
                        GoTo islem
                    ElseIf ComboBox1.Text = "3" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" Then
                        GoTo islem
                    ElseIf ComboBox1.Text = "4" And TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox10.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" Then
                        GoTo islem
                    Else
                        MsgBox("Bilgi alanları boş olamaz!", MsgBoxStyle.Exclamation, "UYARI!")
                        GoTo breakme
                    End If
                Else
                    MsgBox("Giriş ve çıkış tarihleri uyumsuz olamaz!", MsgBoxStyle.Exclamation, "UYARI!")
                    GoTo breakme
                End If
            Else
                MsgBox("Müşteriler aynı olamaz!", MsgBoxStyle.Exclamation, "UYARI!")
                GoTo breakme
            End If
            textboxTemizle()
            GoTo breakme

islem:      'HERE WE GO
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = ListBox2.GetItemText(ListBox2.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Try
                vbConn.Open()
                Dim Query As String
                If ComboBox1.Text = "1" Then
                    Query = "UPDATE odabilgileri set odastatu = 'DOLU', kisisayisi = '1', yetiskin1 = '" & TextBox3.Text & "' where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                    vbCommand = New MySqlCommand(Query, vbConn)
                ElseIf ComboBox1.Text = "2" Then
                    Query = "UPDATE odabilgileri set odastatu = 'DOLU', kisisayisi = '2', yetiskin1 = '" & TextBox3.Text & "', yetiskin2 = '" & TextBox6.Text & "' where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                    vbCommand = New MySqlCommand(Query, vbConn)
                ElseIf ComboBox1.Text = "3" Then
                    Query = "UPDATE odabilgileri set odastatu = 'DOLU', kisisayisi = '3', yetiskin1 = '" & TextBox3.Text & "', yetiskin2 = '" & TextBox6.Text & "', yetiskin3 = '" & TextBox9.Text & "' where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                    vbCommand = New MySqlCommand(Query, vbConn)
                ElseIf ComboBox1.Text = "4" Then
                    Query = "UPDATE odabilgileri set odastatu = 'DOLU', kisisayisi = '4', yetiskin1 = '" & TextBox3.Text & "', yetiskin2 = '" & TextBox6.Text & "', yetiskin3 = '" & TextBox9.Text & "', yetiskin4 = '" & TextBox12.Text & "' where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                    vbCommand = New MySqlCommand(Query, vbConn)
                End If
                vbCommand.ExecuteReader()
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                If ComboBox1.Text = "1" Then
                    musteriEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, aranandegerlendirme, DateTimePicker1.Value.Date.ToString("yyyyMMdd"), DateTimePicker2.Value.Date.ToString("yyyyMMdd"))
                ElseIf ComboBox1.Text = "2" Then
                    musteriEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, aranandegerlendirme, DateTimePicker1.Value.Date.ToString("yyyyMMdd"), DateTimePicker2.Value.Date.ToString("yyyyMMdd"))
                ElseIf ComboBox1.Text = "3" Then
                    musteriEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, aranandegerlendirme, DateTimePicker1.Value.Date.ToString("yyyyMMdd"), DateTimePicker2.Value.Date.ToString("yyyyMMdd"))
                ElseIf ComboBox1.Text = "4" Then
                    musteriEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text, TextBox12.Text, aranandegerlendirme, DateTimePicker1.Value.Date.ToString("yyyyMMdd"), DateTimePicker2.Value.Date.ToString("yyyyMMdd"))
                End If
            End Try
        Else
            MsgBox("Lütfen bir oda seçin!", MsgBoxStyle.Exclamation, "UYARI!")
        End If
breakme:  'BREAK ME
    End Sub

    Function textboxTemizle() 'MUSTERI TEXTBOXLARINI TEMIZLEME FONKSIYONU
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        Return 1
    End Function

    Function musteriBilgileriCheck(ByVal X As String) ' AYNI MUSTERILER MI 
        If X = "0" Then
            Return 0
        ElseIf X = "1" Then
            Return 1
        ElseIf X = "2" Then
            If TextBox1.Text <> TextBox4.Text Then
                If TextBox2.Text <> TextBox5.Text Then
                    If TextBox3.Text <> TextBox6.Text Then
                        Return 1
                    Else
                        Return 0
                    End If
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        ElseIf X = "3" Then
            If TextBox1.Text <> TextBox4.Text And TextBox1.Text <> TextBox7.Text And TextBox4.Text <> TextBox7.Text Then
                If TextBox2.Text <> TextBox5.Text And TextBox2.Text <> TextBox8.Text And TextBox5.Text <> TextBox8.Text Then
                    If TextBox3.Text <> TextBox6.Text And TextBox3.Text <> TextBox9.Text And TextBox9.Text <> TextBox6.Text Then
                        Return 1
                    Else
                        Return 0
                    End If
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        ElseIf X = "4" Then
            If TextBox1.Text <> TextBox4.Text And TextBox1.Text <> TextBox7.Text And TextBox1.Text <> TextBox10.Text And TextBox4.Text <> TextBox7.Text And TextBox4.Text <> TextBox10.Text And TextBox7.Text <> TextBox10.Text Then
                If TextBox2.Text <> TextBox5.Text And TextBox2.Text <> TextBox8.Text And TextBox2.Text <> TextBox11.Text And TextBox5.Text <> TextBox8.Text And TextBox5.Text <> TextBox11.Text And TextBox8.Text <> TextBox11.Text Then
                    If TextBox3.Text <> TextBox6.Text And TextBox3.Text <> TextBox9.Text And TextBox3.Text <> TextBox12.Text And TextBox6.Text <> TextBox9.Text And TextBox6.Text <> TextBox12.Text And TextBox9.Text <> TextBox12.Text Then
                        Return 1
                    Else
                        Return 0
                    End If
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End If
    End Function

    ' BU FONKSIYON OVERLOAD
    ' v v v v v v v v v v v
    Function musteriEkle(ByVal X1 As String, X2 As String, X3 As String, oda As String, grstrh As String, ckstrh As String) ' MUSTERILERI SQLE KAYDET
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim yetiskinlik As Integer
        If X2 > 17 Then
            yetiskinlik = 1
        Else
            yetiskinlik = 0
        End If
        Try
            vbConn.Open()
            Dim Query As String
            If musteri1 = False Then
                Query = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & X1 & "','" & X2 & "','" & X3 & "','" & yetiskinlik & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            Else
                Query = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & X3 & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            loadOdaRezervasyonFiltre(ComboBox2.Text)
            MsgBox("Oda ve müşteri bilgileri başarılı bir şekilde eklendi.", MsgBoxStyle.Information, "Başarılı!")

        End Try
        Return 1
    End Function
    ' OVERLOAD 2
    Function musteriEkle(ByVal X1 As String, X2 As String, X3 As String, ByVal Y1 As String, Y2 As String, Y3 As String, oda As String, grstrh As String, ckstrh As String)
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim yetiskinlik, yetiskinlik2 As Integer
        If X2 > 17 Then
            yetiskinlik = 1
        Else
            yetiskinlik = 0
        End If
        If Y2 > 17 Then
            yetiskinlik2 = 1
        Else
            yetiskinlik2 = 0
        End If
        Try
            vbConn.Open()
            Dim Query As String
            If musteri1 = False Then
                Query = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & X1 & "','" & X2 & "','" & X3 & "','" & yetiskinlik & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            Else
                Query = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & X3 & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            End If
            If musteri2 = False Then
                vbCommand.CommandText = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & Y1 & "','" & Y2 & "','" & Y3 & "','" & yetiskinlik2 & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand.ExecuteNonQuery()
            Else
                vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & Y3 & ""
                vbCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            loadOdaRezervasyonFiltre(ComboBox2.Text)
            MsgBox("Oda ve müşteri bilgileri başarılı bir şekilde eklendi.", MsgBoxStyle.Information, "Başarılı!")
        End Try
        Return 1
    End Function
    ' OVERLOAD 3
    Function musteriEkle(ByVal X1 As String, X2 As String, X3 As String, ByVal Y1 As String, Y2 As String, Y3 As String, ByVal Z1 As String, Z2 As String, Z3 As String, oda As String, grstrh As String, ckstrh As String)
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim yetiskinlik, yetiskinlik2, yetiskinlik3 As Integer
        If X2 > 17 Then
            yetiskinlik = 1
        Else
            yetiskinlik = 0
        End If
        If Y2 > 17 Then
            yetiskinlik2 = 1
        Else
            yetiskinlik2 = 0
        End If
        If Z2 > 17 Then
            yetiskinlik3 = 1
        Else
            yetiskinlik3 = 0
        End If
        Try
            vbConn.Open()
            Dim Query As String
            If musteri1 = False Then
                Query = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & X1 & "','" & X2 & "','" & X3 & "','" & yetiskinlik & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            Else
                Query = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & X3 & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            End If
            If musteri2 = False Then
                vbCommand.CommandText = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & Y1 & "','" & Y2 & "','" & Y3 & "','" & yetiskinlik2 & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand.ExecuteNonQuery()
            Else
                vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & Y3 & ""
                vbCommand.ExecuteNonQuery()
            End If
            If musteri3 = False Then
                vbCommand.CommandText = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & Z1 & "','" & Z2 & "','" & Z3 & "','" & yetiskinlik3 & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand.ExecuteNonQuery()
            Else
                vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & Z3 & ""
                vbCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            loadOdaRezervasyonFiltre(ComboBox2.Text)
            MsgBox("Oda ve müşteri bilgileri başarılı bir şekilde eklendi.", MsgBoxStyle.Information, "Başarılı!")
        End Try
        Return 1
    End Function
    ' OVERLOAD 4
    Function musteriEkle(ByVal X1 As String, X2 As String, X3 As String, ByVal Y1 As String, Y2 As String, Y3 As String, ByVal Z1 As String, Z2 As String, Z3 As String, ByVal T1 As String, T2 As String, T3 As String, oda As String, grstrh As String, ckstrh As String)
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim yetiskinlik, yetiskinlik2, yetiskinlik3, yetiskinlik4 As Integer
        If X2 > 17 Then
            yetiskinlik = 1
        Else
            yetiskinlik = 0
        End If
        If Y2 > 17 Then
            yetiskinlik2 = 1
        Else
            yetiskinlik2 = 0
        End If
        If Z2 > 17 Then
            yetiskinlik3 = 1
        Else
            yetiskinlik3 = 0
        End If
        If T2 > 17 Then
            yetiskinlik4 = 1
        Else
            yetiskinlik4 = 0
        End If
        Try
            vbConn.Open()
            Dim Query As String
            If musteri1 = False Then
                Query = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & X1 & "','" & X2 & "','" & X3 & "','" & yetiskinlik & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            Else
                Query = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & X3 & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbCommand.ExecuteNonQuery()
            End If
            If musteri2 = False Then
                vbCommand.CommandText = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & Y1 & "','" & Y2 & "','" & Y3 & "','" & yetiskinlik2 & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand.ExecuteNonQuery()
            Else
                vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & Y3 & ""
                vbCommand.ExecuteNonQuery()
            End If
            If musteri3 = False Then
                vbCommand.CommandText = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & Z1 & "','" & Z2 & "','" & Z3 & "','" & yetiskinlik3 & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand.ExecuteNonQuery()
            Else
                vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & Z3 & ""
                vbCommand.ExecuteNonQuery()
            End If
            If musteri4 = False Then
                vbCommand.CommandText = "insert into musteribilgileri(adsoyad,yas,tckno,yetiskinlik,kaldigioda,giristarihi,cikistarihi) values ('" & T1 & "','" & T2 & "','" & T3 & "','" & yetiskinlik4 & "','" & oda & "','" & grstrh & "','" & ckstrh & "')"
                vbCommand.ExecuteNonQuery()
            Else
                vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = '" & oda & "', giristarihi = '" & grstrh & "', " & "cikistarihi = '" & ckstrh & "' where tckno = " & T3 & ""
                vbCommand.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            loadOdaRezervasyonFiltre(ComboBox2.Text)
            textboxTemizle()
            Button5.Visible = False
            MsgBox("Oda ve müşteri bilgileri başarılı bir şekilde eklendi.", MsgBoxStyle.Information, "Başarılı!")

        End Try
        Return 1
    End Function
    ' MUSTERI SECME/SILME SUBLARI
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Enabled = False
        musterisec.Show()
        musterisec.Left = 300
        musterisec.Top = 300

        seciliolan = 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Enabled = False
        musterisec.Show()
        seciliolan = 2
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Enabled = False
        musterisec.Show()
        seciliolan = 3
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Enabled = False
        musterisec.Show()
        seciliolan = 4
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Show()
        TextBox1.Enabled = True
        TextBox1.Text = ""
        TextBox2.Enabled = True
        TextBox2.Text = ""
        TextBox3.Enabled = True
        TextBox3.Text = ""
        Button3.Hide()
        musteri1 = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button4.Show()
        TextBox4.Enabled = True
        TextBox4.Text = ""
        TextBox5.Enabled = True
        TextBox5.Text = ""
        TextBox6.Enabled = True
        TextBox6.Text = ""
        Button5.Hide()
        musteri2 = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6.Show()
        TextBox7.Enabled = True
        TextBox7.Text = ""
        TextBox8.Enabled = True
        TextBox8.Text = ""
        TextBox9.Enabled = True
        TextBox9.Text = ""
        Button7.Hide()
        musteri3 = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Button8.Show()
        TextBox10.Enabled = True
        TextBox10.Text = ""
        TextBox11.Enabled = True
        TextBox11.Text = ""
        TextBox12.Enabled = True
        TextBox12.Text = ""
        Button9.Hide()
        musteri4 = False
    End Sub

    'TextBox Filtre
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox8.KeyPress, TextBox11.KeyPress, TextBox5.KeyPress
        e.Handled = kontrol.SayiKontrolu(2, sender, e)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox7.KeyPress, TextBox10.KeyPress, TextBox4.KeyPress
        e.Handled = kontrol.HarfKontrolu(e)
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress, TextBox9.KeyPress, TextBox12.KeyPress, TextBox6.KeyPress
        e.Handled = kontrol.SayiKontrolu(11, sender, e)
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        Try
            If Not TextBox3.Text = "" Then
                If TextBox3.Text <= 10000000000 Then
                    MsgBox("Lütfen geçerli bir TC No giriniz!", MsgBoxStyle.Exclamation, "Uyarı!")
                    TextBox3.Clear()
                End If
            End If
        Catch sorun As Exception
            MsgBox(sorun.Message, MsgBoxStyle.Exclamation, "HATA!")
        End Try
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        Try
            If Not TextBox6.Text = "" Then
                If TextBox6.Text <= 10000000000 Then
                    MsgBox("Lütfen geçerli bir TC No giriniz!", MsgBoxStyle.Exclamation, "Uyarı!")
                    TextBox6.Clear()
                End If
            End If
        Catch sorun As Exception
            MsgBox(sorun.Message, MsgBoxStyle.Exclamation, "HATA!")
        End Try
    End Sub

    Private Sub TextBox9_Leave(sender As Object, e As EventArgs) Handles TextBox9.Leave
        Try
            If Not TextBox9.Text = "" Then
                If TextBox9.Text <= 10000000000 Then
                    MsgBox("Lütfen geçerli bir TC No giriniz!", MsgBoxStyle.Exclamation, "Uyarı!")
                    TextBox9.Clear()
                End If
            End If
        Catch sorun As Exception
            MsgBox(sorun.Message, MsgBoxStyle.Exclamation, "HATA!")
        End Try
    End Sub

    Private Sub TextBox12_Leave(sender As Object, e As EventArgs) Handles TextBox12.Leave
        Try
            If Not TextBox12.Text = "" Then
                If TextBox12.Text <= 10000000000 Then
                    MsgBox("Lütfen geçerli bir TC No giriniz!", MsgBoxStyle.Exclamation, "Uyarı!")
                    TextBox12.Clear()
                End If
            End If
        Catch sorun As Exception
            MsgBox(sorun.Message, MsgBoxStyle.Exclamation, "HATA!")
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        toplamFiyatGoster()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        toplamFiyatGoster()
    End Sub

    Function toplamFiyatGoster()
        If Label8.Text <> "-" And CDate(DateTimePicker1.Value.Date) <= CDate(DateTimePicker2.Value.Date) Then
            Label30.Text = (Convert.ToInt32(Label8.Text) * (DateDiff(DateInterval.Day, DateTimePicker1.Value, DateTimePicker2.Value) + 1)).ToString("N0")
        Else
            Label30.Text = "-"
        End If
        Return 1
    End Function
End Class