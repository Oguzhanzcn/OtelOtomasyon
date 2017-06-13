Imports MySql.Data.MySqlClient
Public Class musteribilgileri
    Dim musteriNesne As New Musteri
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2, vbCommand3 As MySqlCommand
    Private Sub musterigeributton_Click(sender As Object, e As EventArgs) Handles musterigeributton.Click
        Me.Close()
        Anamenu.Show()
    End Sub

    Function loadmusteribilgileri(ByVal X As ListBox)
        X.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select adsoyad,tckno from musteribilgileri"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                girdistring = "" & vbReader("adsoyad") & " | " & vbReader("tckno") & ""
                X.Items.Add(girdistring)
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            musteriadsoyadlabel.Text = "-"
            musteritcklabel.Text = "-"
            musteriyaslabel.Text = "-"
            musteriyetiskincocuklabel.Text = "-"
            musteriodalabel.Text = "-"
            GirisLabel.Text = "-"
            CikisLabel.Text = "-"
        End Try
        Return 1
    End Function
    Private Sub musteribilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadmusteribilgileri(musteribilgiLB)
    End Sub

    Private Sub musteribilgiLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles musteribilgiLB.SelectedIndexChanged
        If musteribilgiLB.SelectedIndex <> -1 Then
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = musteribilgiLB.GetItemText(musteribilgiLB.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select * from musteribilgileri where tckno = " & Convert.ToInt64(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    musteriNesne.musteriAdSoyad = vbReader("adsoyad")
                    musteriNesne.musteriTc = Convert.ToString(vbReader("tckno"))
                    musteriNesne.yasi = vbReader("yas")
                    If Not IsDBNull(vbReader("kaldigioda")) Then
                        musteriNesne.kalinanOda = vbReader("kaldigioda")
                    Else
                        musteriNesne.kalinanOda = "YOK"
                    End If
                    musteriNesne.girisTarihi = vbReader("giristarihi").date
                    musteriNesne.cikisTarihi = vbReader("cikistarihi").date
                End While
                musteriadsoyadlabel.Text = musteriNesne.musteriAdSoyad
                musteritcklabel.Text = musteriNesne.musteriTc
                musteriyaslabel.Text = musteriNesne.yasi
                musteriodalabel.Text = musteriNesne.kalinanOda
                If musteriNesne.kalinanOda = "YOK" Then
                    GirisLabel.Text = "-"
                    CikisLabel.Text = "-"
                Else
                    GirisLabel.Text = musteriNesne.girisTarihi
                    CikisLabel.Text = musteriNesne.cikisTarihi
                End If
                If musteriNesne.yasi >= 18 Then
                    musteriyetiskincocuklabel.Text = "Yetişkin"
                Else
                    musteriyetiskincocuklabel.Text = "Çocuk"
                End If
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
            End Try
        End If
    End Sub
End Class