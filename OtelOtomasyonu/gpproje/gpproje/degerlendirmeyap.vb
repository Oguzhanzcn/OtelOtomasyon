Imports MySql.Data.MySqlClient

Public Class degerlendirmeyap
    Dim vbConn As MySqlConnection
    Dim vbCommand As MySqlCommand

    Private Sub musterigeributton_Click(sender As Object, e As EventArgs) Handles musterigeributton.Click
        Me.Close()
    End Sub

    Private Sub degerlendirmebutton_Click(sender As Object, e As EventArgs) Handles degerlendirmebutton.Click ' DEĞERLENDİRME YAP
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim yildizsayi As Integer = checkYildiz()
        Dim tarih As String = Date.Today.ToString("yyyyMMdd")
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Lütfen önce bir müşteri seçin!", MsgBoxStyle.Exclamation, "Hata!")
        Else
            Dim musterismi As String = ListBox1.GetItemText(ListBox1.SelectedItem)
            Try
                vbConn.Open()
                Dim Query As String
                Query = "insert into degerlendirme(musteriisim,degerlendirme,yildizsayi,degerlendirmetarihi) values ('" & musterismi & "','" & TextBox1.Text & "','" & yildizsayi & "','" & tarih & "')"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                vbConn.Close()
                MsgBox("Değerlendirmeniz yapılmıştır.", MsgBoxStyle.Information, "Başarılı!")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                vbConn.Dispose()
                degerlendirmeler.loadDegerlendirmeler(degerlendirmeler.ListBox1)
                Me.Close()
            End Try
        End If
    End Sub

    Private Sub degerlendirmeyap_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'DEĞERLENDİRME PENCERESİ AÇILIRKEN
        loadMusteriler(ListBox1)
        DateTimePicker1.Value = Date.Now()
    End Sub

    Function checkYildiz() ' RADIO BUTTON -> YILDIZ SAYISI
        Dim yildiz As Integer
        If RadioButton1.Checked() Then
            yildiz = 1
        ElseIf RadioButton2.Checked() Then
            yildiz = 2
        ElseIf RadioButton3.Checked() Then
            yildiz = 3
        ElseIf RadioButton4.Checked() Then
            yildiz = 4
        ElseIf RadioButton5.Checked() Then
            yildiz = 5
        End If
        Return yildiz
    End Function

    Function loadMusteriler(ByVal X As ListBox) 'LISTBOXA MUSTERILERI YUKLE
        X.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select adsoyad from musteribilgileri where yetiskinlik=1"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                X.Items.Add(vbReader("adsoyad"))
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
        End Try
        Return 1
    End Function
End Class