Imports MySql.Data.MySqlClient
Public Class calisanlistesi
    Dim calisanNesne As New Personel
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2, vbCommand3 As MySqlCommand

    Private Sub calisanlistegeributton_Click(sender As Object, e As EventArgs) Handles calisanlistegeributton.Click ' GERI TUSU
        Me.Close()
        Anamenu.Show()
    End Sub

    Private Sub calisanlistekovbutton_Click(sender As Object, e As EventArgs) Handles calisanlistekovbutton.Click ' ISTEN ATMAK
        If calisanlisteLB.SelectedIndex = -1 Then
            MsgBox("Lütfen önce işten çıkarılacak bir eleman seçin!")
        Else
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilicalisan As String = calisanlisteLB.GetItemText(calisanlisteLB.SelectedItem)
            Dim aranancalisan As String = secilicalisan.Substring(secilicalisan.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "delete from calisanbilgileri where calisanid = " & Convert.ToInt32(aranancalisan) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                MsgBox("Çalışan silinmiştir.")
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                loadcalisanlistesi(calisanlisteLB)
            End Try
        End If
    End Sub



    Private Sub calisanlisteLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles calisanlisteLB.SelectedIndexChanged ' CALISAN SECIMI
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim secilicalisan As String = calisanlisteLB.GetItemText(calisanlisteLB.SelectedItem)
        Dim aranancalisan As String = secilicalisan.Substring(secilicalisan.IndexOf("|") + 1)
        Dim vbReader As MySqlDataReader
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select * from calisanbilgileri where calisanid = " & Convert.ToInt32(aranancalisan) & ""
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                calisanNesne.calisanAdSoyad = vbReader("adsoyad")
                calisanNesne.Alan = vbReader("calistigialan")
                calisanNesne.TCKno = (vbReader("tckno"))
                calisanNesne.calisanYas = Convert.ToString(vbReader("yas"))
                calisanNesne.ozGecmis = vbReader("ozgecmis")
            End While
            calisanlisteadsoyadlabel.Text = calisanNesne.calisanAdSoyad
            calisanlistealanlabel.Text = calisanNesne.Alan
            calisanlistetcklabel.Text = calisanNesne.TCKno
            calisanlisteyaslabel.Text = calisanNesne.calisanYas
            calisanlisteozgecmisTB.Text = calisanNesne.ozGecmis
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
        End Try
    End Sub
    Private Sub calisanlistesi_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' FORM YUKLENIRKEN
        loadcalisanlistesi(calisanlisteLB)
    End Sub

    Function loadcalisanlistesi(ByVal X As ListBox) ' CALISAN LISTESINI YUKLE
        X.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select adsoyad,calisanid,calistigialan from calisanbilgileri"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                girdistring = "" & vbReader("adsoyad") & "/" & vbReader("calistigialan") & " | " & vbReader("calisanid") & ""
                X.Items.Add(girdistring)
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            calisanlisteadsoyadlabel.Text = "-"
            calisanlistealanlabel.Text = "-"
            calisanlistetcklabel.Text = "-"
            calisanlisteyaslabel.Text = "-"
            calisanlisteozgecmisTB.Text = "-"
        End Try
        Return 1
    End Function

    Private Sub calisanlisteyenilebutton_Click(sender As Object, e As EventArgs) Handles calisanlisteyenilebutton.Click ' CALISAN LISTESI GUNCELLE
        calisanlisteLB.Refresh()
    End Sub
End Class