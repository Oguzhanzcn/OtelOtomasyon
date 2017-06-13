Imports MySql.Data.MySqlClient
Public Class odaayarlari
    Dim odaNesne As New Oda
    Dim kontrol As Kontrol
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2, vbCommand3 As MySqlCommand
    Dim OdaNolari(100) As String

    Private Sub musterigeributton_Click(sender As Object, e As EventArgs) Handles musterigeributton.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        Me.Close()
        Anamenu.Show()
    End Sub

    Function loadOdaayarlari(ByVal X As ListBox)
        X.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Dim sayac As Integer
        sayac = 0
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select odano from odabilgileri"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                OdaNolari(sayac) = vbReader("odano")
                girdistring = vbReader("odano")
                X.Items.Add(girdistring)
                sayac += 1
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()

        End Try
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim degisiklik As Boolean = False
        If ListBox2.SelectedIndex <> -1 Then
            For i = 0 To OdaNolari.Length - 1
                If TextBox2.Text = OdaNolari(i) Then
                    degisiklik = True
                    Select Case MsgBox("Odayı güncellemek istediğinize emin misiniz?", MsgBoxStyle.YesNo, "Uyarı")
                        Case vbYes
                            Dim secilidegerlendirme As String = ListBox2.GetItemText(ListBox2.SelectedItem)
                            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
                            vbConn = New MySqlConnection
                            vbConn.ConnectionString = Anamenu.cnstr
                            Dim vbReader As MySqlDataReader
                            Try ' ODA VARSA MEVCUT ODAYI GUNCELLE
                                odaNesne.odaTuru = ComboBox1.SelectedItem
                                odaNesne.fiyat = TextBox1.Text
                                odaNesne.odaNo = TextBox2.Text
                                odaNesne.manzra = ComboBox2.SelectedItem
                                vbConn.Open()
                                Dim Query As String
                                Query = "UPDATE odabilgileri set odafiyati = '" & odaNesne.fiyat & "', odatur = '" & odaNesne.odaTuru & "', " & "odamanzarasi = '" & odaNesne.manzra & "', odano = '" & odaNesne.odaNo & "' where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                                vbCommand = New MySqlCommand(Query, vbConn)
                                vbReader = vbCommand.ExecuteReader()
                                vbConn.Close()
                                MsgBox("Oda Güncellenmiştir.", MsgBoxStyle.Information, "Başarılı")
                            Catch ex As Exception
                                MsgBox(ex.Message)
                            Finally
                                vbConn.Dispose()
                                TextBox1.Clear()
                                TextBox2.Clear()
                                ComboBox1.SelectedIndex = -1
                                ComboBox2.SelectedIndex = -1
                                loadOdaayarlari(ListBox2)
                            End Try
                        Case vbNo
                    End Select
                    Exit For
                End If
            Next
        End If
        If degisiklik = False Then
            If TextBox1.Text IsNot "" And TextBox2.Text IsNot "" And ComboBox1.SelectedIndex <> -1 And ComboBox2.SelectedIndex <> -1 Then
                vbConn = New MySqlConnection
                vbConn.ConnectionString = Anamenu.cnstr
                Dim vbReader As MySqlDataReader
                Try ' ODA YOKSA ODAYI OLUSTUR
                    odaNesne.odaTuru = ComboBox1.SelectedItem
                    odaNesne.fiyat = TextBox1.Text
                    odaNesne.odaNo = TextBox2.Text
                    odaNesne.manzra = ComboBox2.SelectedItem
                    vbConn.Open()
                    Dim Query As String
                    Query = "insert into odabilgileri(odatur,odano,odafiyati,odamanzarasi,odastatu,kisisayisi) values ('" & odaNesne.odaTuru & "','" & odaNesne.odaNo & "','" & odaNesne.fiyat & "','" & odaNesne.manzra & "','bos',0)"
                    vbCommand = New MySqlCommand(Query, vbConn)
                    vbReader = vbCommand.ExecuteReader()
                    vbConn.Close()
                    MsgBox("Oda eklenmiştir.", MsgBoxStyle.Information, "Başarılı")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    vbConn.Dispose()
                    TextBox1.Clear()
                    TextBox2.Clear()
                    ComboBox1.SelectedIndex = -1
                    ComboBox2.SelectedIndex = -1
                    loadOdaayarlari(ListBox2)
                End Try
            Else
                MsgBox("Bilgi alanları boş olmamalıdır.", MsgBoxStyle.Exclamation, "Hata!")
            End If
        End If
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        If ListBox2.SelectedIndex <> -1 Then
            ComboBox1.ResetText()

            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim aranandegerlendirme As String = ListBox2.GetItemText(ListBox2.SelectedItem)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select * from odabilgileri where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    ComboBox1.Text = vbReader("odatur")
                    TextBox1.Text = vbReader("odafiyati")
                    TextBox2.Text = vbReader("odano")
                    ComboBox2.Text = vbReader("odamanzarasi")
                End While
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            odaNesne.odaTuru = ComboBox1.SelectedItem
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If Not TextBox2.Text = "" Then
            For i = 0 To OdaNolari.Length - 1
                If TextBox2.Text = OdaNolari(i) Then
                    MsgBox("Bu oda adı mevcuttur. Lütfen başka oda no giriniz", MsgBoxStyle.Exclamation, "Uyarı")
                    sender.Text = ""
                    Exit For
                End If
            Next

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click ' ODA SILME
        If ListBox2.SelectedIndex = -1 Then
            MsgBox("Lütfen önce Silinecek bir oda seçiniz!", MsgBoxStyle.Exclamation, "Hata")
        Else
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim aranandegerlendirme As String = ListBox2.GetItemText(ListBox2.SelectedItem)
            Dim vbReader As MySqlDataReader
            Dim yetiskin1, yetiskin2, yetiskin3, yetiskin4 As String
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select yetiskin1,yetiskin2,yetiskin3,yetiskin4 from odabilgileri where odano = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    If Not IsDBNull(vbReader("yetiskin1")) Then
                        yetiskin1 = vbReader("yetiskin1")
                    End If
                    If Not IsDBNull(vbReader("yetiskin2")) Then
                        yetiskin2 = vbReader("yetiskin2")
                    End If
                    If Not IsDBNull(vbReader("yetiskin3")) Then
                        yetiskin3 = vbReader("yetiskin3")
                    End If
                    If Not IsDBNull(vbReader("yetiskin4")) Then
                        yetiskin4 = vbReader("yetiskin4")
                    End If
                End While
                musteriBilgileriGuncelle(yetiskin1, yetiskin2, yetiskin3, yetiskin4, aranandegerlendirme)
                For i As Integer = 0 To OdaNolari.Length - 1
                    If ListBox2.GetItemText(ListBox2.SelectedItem) = OdaNolari(i) Then
                        OdaNolari(i) = vbNull
                    End If
                Next

                MsgBox("Seçili oda silinmiştir.", MsgBoxStyle.Information, "Başarılı")
                loadOdaayarlari(ListBox2)
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
                vbConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub odabilgiyenilebutton_Click(sender As Object, e As EventArgs) Handles odabilgiyenilebutton.Click
        loadOdaayarlari(ListBox2)
    End Sub

    Function musteriBilgileriGuncelle(ByVal X As String, ByVal Y As String, ByVal Z As String, ByVal T As String, ByVal Oda As String)
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        vbConn.Open()
        Dim Query As String
        vbCommand = New MySqlCommand(Query, vbConn)
        If Not IsDBNull(X) Then
            vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = NULL where tckno = '" & X & "'"
            vbCommand.ExecuteNonQuery()
        End If
        If Not IsDBNull(Y) Then
            vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = NULL where tckno = '" & Y & "'"
            vbCommand.ExecuteNonQuery()
        End If
        If Not IsDBNull(Z) Then
            vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = NULL where tckno = '" & Z & "'"
            vbCommand.ExecuteNonQuery()
        End If
        If Not IsDBNull(T) Then
            vbCommand.CommandText = "UPDATE musteribilgileri set kaldigioda = NULL where tckno = '" & T & "'"
            vbCommand.ExecuteNonQuery()
        End If
        Query = "delete from odabilgileri where odano = " & Oda & ""
        vbCommand.CommandText = Query
        vbCommand.ExecuteNonQuery()
        vbConn.Close()
        vbConn.Dispose()
        Return 1
    End Function

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress
        e.Handled = kontrol.SayiKontrolu(15, sender, e)
    End Sub

    Private Sub odaayarlari_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadOdaayarlari(ListBox2)
    End Sub
End Class
