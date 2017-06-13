Imports MySql.Data.MySqlClient

Public Class adminekle
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2 As MySqlCommand
    Private Sub admineklebackbutton_Click(sender As Object, e As EventArgs) Handles admineklebackbutton.Click
        adminEkleSifre.Text = ""
        adminEkleAd.Text = ""
        Me.Close()
    End Sub

    Private Sub adminekleconfirmbutton_Click(sender As Object, e As EventArgs) Handles adminekleconfirmbutton.Click
        If adminEkleAd.Text <> "" And adminEkleSifre.Text <> "" Then
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim Query1, Query As String
            Dim vbReader As MySqlDataReader
            Dim kullaniciAdi, kullaniciSifre As String
            Try
                vbConn.Open()
                Query = "select * from admingiris "
                vbCommand2 = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand2.ExecuteReader()
                While vbReader.Read()
                    kullaniciAdi = vbReader("kullaniciAd")
                    kullaniciSifre = vbReader("sifre")
                    If kullaniciAdi = adminEkleAd.Text Then 'And kullaniciSifre = adminEkleSifre.Text Then
                        MsgBox("Birden fazla aynı admin olamaz!", MsgBoxStyle.Exclamation, "HATA!")
                        vbConn.Close()
                        GoTo yeniden
                    End If
                End While
                vbConn.Dispose()
                vbConn.Open()
                Query1 = "insert into admingiris(kullaniciAd,sifre) values ('" & adminEkleAd.Text & "','" & adminEkleSifre.Text & "')"
                vbCommand = New MySqlCommand(Query1, vbConn)
                vbCommand.ExecuteNonQuery()
                MsgBox("Yeni bir admin başarıyla eklenmiştir.", MsgBoxStyle.Information, "Başarılı!")
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                adminEkleAd.Clear()
                adminEkleSifre.Clear()
                Me.Hide()
                'basvurulisteLB.Items.Clear()
            End Try
yeniden:
        Else
            MsgBox("Lütfen boş alan bırakmayınız!", MsgBoxStyle.Exclamation, "Hata!")
        End If
    End Sub
End Class