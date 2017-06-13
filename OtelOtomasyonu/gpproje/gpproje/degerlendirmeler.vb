Imports MySql.Data.MySqlClient

Public Class degerlendirmeler
    Dim vbConn As MySqlConnection
    Dim vbCommand As MySqlCommand

    Private Sub musterigeributton_Click(sender As Object, e As EventArgs) Handles musterigeributton.Click
        Anamenu.Show()
        Me.Close()
    End Sub

    Private Sub degerlendirmelerkapat() Handles MyBase.FormClosed
        Anamenu.Show()
        degerlendirmeyap.Close()
    End Sub

    Private Sub odabilgiyenilebutton_Click(sender As Object, e As EventArgs) Handles odabilgiyenilebutton.Click
        degerlendirmeyap.Show()
    End Sub

    Private Sub degerlendirmeler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDegerlendirmeler(ListBox1)
    End Sub

    Function loadDegerlendirmeler(ByVal X As ListBox)
        X.Items.Clear()
        vbConn = New MySqlConnection
        vbConn.ConnectionString = Anamenu.cnstr
        Dim vbReader As MySqlDataReader
        Dim girdistring As String
        Try
            vbConn.Open()
            Dim Query As String
            Query = "select degerlendirmetarihi,degerlendirmeid from degerlendirme"
            vbCommand = New MySqlCommand(Query, vbConn)
            vbReader = vbCommand.ExecuteReader()
            While vbReader.Read()
                girdistring = "" & vbReader("degerlendirmetarihi") & " | " & vbReader("degerlendirmeid") & ""
                X.Items.Add(girdistring)
            End While
            vbConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            vbConn.Dispose()
            Label7.Text = "-"
            Label3.Text = "-"
            Label5.Text = "-"
            TextBox1.Text = "-"
        End Try
        Return 1
    End Function

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = ListBox1.GetItemText(ListBox1.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select * from degerlendirme where degerlendirmeid = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    Label7.Text = vbReader("musteriisim")
                    Label3.Text = Convert.ToString(vbReader("yildizsayi"))
                    If Convert.ToString(vbReader("yildizsayi")) = "1" Then
                        PictureBox1.BackgroundImage = My.Resources.yildiz1
                    ElseIf Convert.ToString(vbReader("yildizsayi")) = "2" Then
                        PictureBox1.BackgroundImage = My.Resources.yildiz2
                    ElseIf Convert.ToString(vbReader("yildizsayi")) = 3 Then
                        PictureBox1.BackgroundImage = My.Resources.yildiz3
                    ElseIf Convert.ToString(vbReader("yildizsayi")) = 4 Then
                        PictureBox1.BackgroundImage = My.Resources.yildiz4
                    ElseIf Convert.ToString(vbReader("yildizsayi")) = 5 Then
                        PictureBox1.BackgroundImage = My.Resources.yildiz5
                    End If
                    Label5.Text = Convert.ToString(vbReader("degerlendirmetarihi").Date)
                    TextBox1.Text = vbReader("degerlendirme")
                End While
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Lütfen önce silinecek bir değerlendirme seçin!", MsgBoxStyle.Exclamation, "Hata!")
        Else
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim secilidegerlendirme As String = ListBox1.GetItemText(ListBox1.SelectedItem)
            Dim aranandegerlendirme As String = secilidegerlendirme.Substring(secilidegerlendirme.IndexOf("|") + 1)
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "delete from degerlendirme where degerlendirmeid = " & Convert.ToInt32(aranandegerlendirme) & ""
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                MsgBox("Değerlendirme silinmiştir.", MsgBoxStyle.Information, "Hata!")
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
                loadDegerlendirmeler(ListBox1)
            End Try
        End If
    End Sub
End Class