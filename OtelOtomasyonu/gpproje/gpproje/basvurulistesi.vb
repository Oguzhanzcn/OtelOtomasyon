Imports MySql.Data.MySqlClient

Public Class basvurulistesi
    Dim personelNesne As New Personel
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2, vbCommand3 As MySqlCommand

    Private Sub basvurulistegeributton_Click(sender As Object, e As EventArgs) Handles basvurulistegeributton.Click
        Me.Close()
        Anamenu.Show()
    End Sub

    Private Sub basvurulistekabuletbutton_Click(sender As Object, e As EventArgs) Handles basvurulistekabuletbutton.Click
        If basvurulisteLB.SelectedIndex = -1 Then
            MsgBox("Lütfen önce kabul edilecek bir iş başvurusu seçin!", MsgBoxStyle.Exclamation, "Hata!")
        Else
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = basvurulisteLB.GetItemText(basvurulisteLB.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Dim Query2, Query3 As String
            Try
                vbConn.Open()
                Query3 = "select adsoyad,yas,tckno,basvurdugualan,ozgecmis from isbasvurulari where basvuruid = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query3, vbConn)
                vbReader = vbCommand.ExecuteReader()
                vbReader.Read()
                'Dim a1, a3, a4, a5 As String
                'Dim a2 As Int16
                personelNesne.calisanAdSoyad = vbReader("adsoyad")
                personelNesne.calisanYas = vbReader("yas")
                personelNesne.TCKno = vbReader("tckno")
                personelNesne.Alan = vbReader("basvurdugualan")
                personelNesne.ozGecmis = vbReader("ozgecmis")
                vbReader.Dispose()
                Query2 = "insert into calisanbilgileri(adsoyad,yas,tckno,calistigialan,ozgecmis) values ('" & personelNesne.calisanAdSoyad & "','" & personelNesne.calisanYas & "','" & personelNesne.TCKno & "','" & personelNesne.Alan & "','" & personelNesne.ozGecmis & "')"
                vbCommand2 = New MySqlCommand(Query2, vbConn)
                vbCommand2.ExecuteNonQuery()
                MsgBox("Başvuru başarıyla kabul edilmiş ve çalışanlar listesine eklenmiştir", MsgBoxStyle.Information, "Başarılı!")
                vbConn.Close()
                vbConn.Open()
                Dim query4 As String
                query4 = "delete from isbasvurulari where basvuruid = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand3 = New MySqlCommand(query4, vbConn)
                vbReader = vbCommand3.ExecuteReader
                vbConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                loadIsBasvurulari(basvurulisteLB)
                'basvurulisteLB.Items.Clear()
            End Try
        End If
    End Sub

    Private Sub basvurulistesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadIsBasvurulari(basvurulisteLB)
    End Sub

    Function loadIsBasvurulari(ByVal X As ListBox)
        X.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select adsoyad,basvurdugualan,basvuruid from isbasvurulari"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                girdistring = "" & vbReader("adsoyad") & "/" & vbReader("basvurdugualan") & " | " & vbReader("basvuruid") & ""
                X.Items.Add(girdistring)
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            basvurulisteadsoyadlabel.Text = "-"
            basvurulistealanlabel.Text = "-"
            basvurulistetcklabel.Text = "-"
            basvurulisteozgecmisTB.Text = "-"
            basvurulisteyaslabel.Text = "-"
        End Try
        Return 1
    End Function

    Private Sub basvurulisteLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles basvurulisteLB.SelectedIndexChanged
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim secilidegerlendirme As String = basvurulisteLB.GetItemText(basvurulisteLB.SelectedItem)
        Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
        Dim vbReader As MySqlDataReader
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select * from isbasvurulari where basvuruid = " & Convert.ToInt32(aranandegerlendirme) & ""
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                personelNesne.calisanAdSoyad = vbReader("adsoyad")
                personelNesne.Alan = vbReader("basvurdugualan")
                personelNesne.TCKno = vbReader("tckno")
                personelNesne.ozGecmis = vbReader("ozgecmis")
                personelNesne.calisanYas = vbReader("yas")
            End While
            basvurulisteadsoyadlabel.Text = personelNesne.calisanAdSoyad
            basvurulistealanlabel.Text = personelNesne.Alan
            basvurulistetcklabel.Text = personelNesne.TCKno
            basvurulisteozgecmisTB.Text = personelNesne.ozGecmis
            basvurulisteyaslabel.Text = personelNesne.calisanYas
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
        End Try
    End Sub

    Private Sub basvurulistereddetbutton_Click(sender As Object, e As EventArgs) Handles basvurulistereddetbutton.Click
        If basvurulisteLB.SelectedIndex = -1 Then
            MsgBox("Lütfen önce reddedilecek bir iş başvurusu seçin!", MsgBoxStyle.Exclamation, "Hata!")
        Else
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = basvurulisteLB.GetItemText(basvurulisteLB.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "delete from isbasvurulari where basvuruid = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                MsgBox("Seçili başvuru reddedilmiştir.", MsgBoxStyle.Exclamation, "Hata!")
                loadIsBasvurulari(basvurulisteLB)
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub basvurulisteyenilebutton_Click(sender As Object, e As EventArgs) Handles basvurulisteyenilebutton.Click
        basvurulisteLB.Refresh()
    End Sub
End Class