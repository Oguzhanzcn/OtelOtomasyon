Imports MySql.Data.MySqlClient
Public Class odabilgileri
    Dim nesneOda As New Oda
    Dim vbConn As MySqlConnection
    Dim vbCommand, vbCommand2, vbCommand3 As MySqlCommand
    Private Sub odabilgigeributton_Click(sender As Object, e As EventArgs) Handles odabilgigeributton.Click
        Me.Close()
        Anamenu.Show()
    End Sub

    Private Sub odabilgileri_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadOdabilgileri(odabilgiodalarLB)
    End Sub

    Function loadOdabilgileri(ByVal X As ListBox)
        X.Items.Clear()
        ListBox1.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select odano from odabilgileri"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                girdistring = vbReader("odano")
                X.Items.Add(girdistring)
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            Label10.Text = "-"
            Label9.Text = "-"
            Label5.Text = "-"
            odabilgiodanolabel.Text = "-"
            odabilgistatulabel.Text = "-"
            odabilgicocuksayisilabel.Text = "-"
        End Try
        Return 1
    End Function

    Private Sub odabilgiodalarLB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles odabilgiodalarLB.SelectedIndexChanged
        If odabilgiodalarLB.SelectedIndex <> -1 Then
            ListBox1.Items.Clear()
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim aranandegerlendirme As String = odabilgiodalarLB.GetItemText(odabilgiodalarLB.SelectedItem)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select * from odabilgileri where odano = '" & aranandegerlendirme & "'"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    nesneOda.odaTuru = Convert.ToString(vbReader("odatur"))
                    nesneOda.fiyat = Convert.ToString(vbReader("odafiyati"))
                    nesneOda.manzra = Convert.ToString(vbReader("odamanzarasi"))
                    nesneOda.odaNo = Convert.ToString(vbReader("odano"))
                    nesneOda.durm = Convert.ToString(vbReader("odastatu"))
                    odabilgicocuksayisilabel.Text = Convert.ToString(vbReader("kisisayisi"))
                    If Convert.ToString(vbReader("kisisayisi")) = "1" Then
                        ListBox1.Items.Add(vbReader("yetiskin1"))
                    ElseIf Convert.ToString(vbReader("kisisayisi")) = "2" Then
                        ListBox1.Items.Add(vbReader("yetiskin1"))
                        ListBox1.Items.Add(vbReader("yetiskin2"))
                    ElseIf Convert.ToString(vbReader("kisisayisi")) = "3" Then
                        ListBox1.Items.Add(vbReader("yetiskin1"))
                        ListBox1.Items.Add(vbReader("yetiskin2"))
                        ListBox1.Items.Add(vbReader("yetiskin3"))
                    ElseIf Convert.ToString(vbReader("kisisayisi")) = "4" Then
                        ListBox1.Items.Add(vbReader("yetiskin1"))
                        ListBox1.Items.Add(vbReader("yetiskin2"))
                        ListBox1.Items.Add(vbReader("yetiskin3"))
                        ListBox1.Items.Add(vbReader("yetiskin4"))
                    End If
                End While
                Label10.Text = nesneOda.odaTuru
                Label9.Text = nesneOda.fiyat
                Label5.Text = nesneOda.manzra
                odabilgiodanolabel.Text = nesneOda.odaNo
                odabilgistatulabel.Text = nesneOda.durm
                vbReader.Close()
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                Dim sayac As Integer = 0
                For i As Integer = 0 To (ListBox1.Items.Count() - 1)
                    tcknodanmusteri(ListBox1.GetItemText(ListBox1.Items(i)))
                    sayac += 1
                Next
                For j As Integer = 0 To sayac - 1
                    ListBox1.Items.Remove(ListBox1.Items(0))
                Next
            End Try
        End If
    End Sub

    Function tcknodanmusteri(ByVal X As String)
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select * from musteribilgileri where tckno = " & X & ""
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                ListBox1.Items.Add(vbReader("adsoyad"))
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
        End Try
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'ODAYI BOŞALT
        If odabilgiodalarLB.SelectedIndex = -1 Then
            MsgBox("Lütfen önce boşaltılacak oda seçiniz!", MsgBoxStyle.Exclamation, "Hata!")
        Else
            If odabilgicocuksayisilabel.Text <> "0" Then
                vbConn = New MySqlConnection
                vbConn.ConnectionString = Anamenu.cnstr
                Dim aranandegerlendirme As String = odabilgiodalarLB.GetItemText(odabilgiodalarLB.SelectedItem)
                Dim vbReader As MySqlDataReader
                Try
                    vbConn.Open()
                    Dim Query As String
                    Query = "update odabilgileri set yetiskin1 = NULL, yetiskin2 = NULL, yetiskin3 = NULL, yetiskin4 = NULL, odastatu = 'bos',kisisayisi = 0 where odano = " & aranandegerlendirme & ""
                    vbCommand = New MySqlCommand(Query, vbConn)
                    vbReader = vbCommand.ExecuteReader()
                    loadOdabilgileri(odabilgiodalarLB)
                    vbConn.Close()
                    vbConn.Open()
                    Dim Query2 As String
                    Query2 = "update musteribilgileri set kaldigioda=NULL where kaldigioda = " & aranandegerlendirme & ""
                    vbCommand3 = New MySqlCommand(Query2, vbConn)
                    vbReader = vbCommand3.ExecuteReader
                    vbConn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    vbConn.Dispose()
                    loadOdabilgileri(odabilgiodalarLB)
                    MsgBox("Oda başarılı bir şekilde boşaltıldı.", MsgBoxStyle.Information, "Başarılı!")
                End Try
            Else
                MsgBox("Oda zaten boş!", MsgBoxStyle.Exclamation, "Hata!")
            End If
        End If
    End Sub

    Private Sub odabilgiyenilebutton_Click(sender As Object, e As EventArgs) Handles odabilgiyenilebutton.Click
        loadOdabilgileri(odabilgiodalarLB)
    End Sub
End Class