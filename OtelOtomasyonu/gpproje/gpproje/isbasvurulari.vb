Imports MySql.Data.MySqlClient

Public Class isbasvurulari
    Dim kontrol As New Kontrol
    Dim vbConn As MySqlConnection
    Dim vbCommand As MySqlCommand

    Private Sub basvurugeributton_Click(sender As Object, e As EventArgs) Handles basvurugeributton.Click ' GERI TUSU
        Me.Close()
        Anamenu.Show()
    End Sub

    Private Sub basvurubasvurbutton_Click(sender As Object, e As EventArgs) Handles basvurubasvurbutton.Click ' BASVURUYU YAP
        If basvuruadTB.Text IsNot "" And basvuruyasTB.Text IsNot "" And basvurutckTB.Text IsNot "" And basvurualanTB.Text IsNot "" And basvuruozgecmisTB.Text IsNot "" Then
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "insert into isbasvurulari(adsoyad,yas,tckno,basvurdugualan,ozgecmis) values ('" & basvuruadTB.Text & "','" & basvuruyasTB.Text & "','" & basvurutckTB.Text & "','" & basvurualanTB.Text & "','" & basvuruozgecmisTB.Text & "')"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                vbConn.Close()
                MsgBox("İş başvurunuz iletilmiştir.", MsgBoxStyle.Information, "İletildi!")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                vbConn.Dispose()
                basvuruadTB.Clear()
                basvuruyasTB.Clear()
                basvurutckTB.Clear()
                basvurualanTB.Clear()
                basvuruozgecmisTB.Clear()
                Me.Close()
            End Try
        Else
            MsgBox("Bilgi alanları boş olmamalıdır.", MsgBoxStyle.Exclamation, "Uyarı!")
        End If
    End Sub

    Private Sub basvurutckTB_Leave(sender As Object, e As EventArgs) Handles basvurutckTB.Leave ' GECERSIZ TCK KONTROLU
        Try
            If Not basvurutckTB.Text = "" Then
                If basvurutckTB.Text <> "" And basvurutckTB.Text <= 10000000000 Then
                    MsgBox("Lütfen geçerli bir TC No giriniz!", MsgBoxStyle.Exclamation, "Uyarı!")
                    basvurutckTB.Clear()
                End If

            End If
        Catch sorun As Exception
            MsgBox(sorun.Message, MsgBoxStyle.Exclamation, "HATA!")
        End Try
    End Sub
    'TB FILTRELER
    Private Sub basvuruadTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles basvuruadTB.KeyPress, basvurualanTB.KeyPress
        e.Handled = kontrol.HarfKontrolu(e)
    End Sub

    Private Sub basvuruyasTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles basvuruyasTB.KeyPress
        e.Handled = kontrol.SayiKontrolu(11, sender, e)
    End Sub

    Private Sub basvurutckTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles basvurutckTB.KeyPress
        e.Handled = kontrol.SayiKontrolu(11, sender, e)
    End Sub
End Class