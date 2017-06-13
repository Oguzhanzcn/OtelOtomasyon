Imports MySql.Data.MySqlClient
Public Class admingiris
    Dim vbConn As MySqlConnection
    Dim vbCommand As MySqlCommand
    Private adminkullanici As String
    Private adminpass As String

    Private Sub admingirisconfirmbutton_Click(sender As Object, e As EventArgs) Handles admingirisconfirmbutton.Click
        If adminkadiTB.Text = "" And adminsifreTB.Text = "" Then
            MsgBox("Boş alan bırakmayınız!", MsgBoxStyle.Exclamation, "Uyarı!")
        Else
            vbConn = New MySqlConnection
            vbConn.ConnectionString = Anamenu.cnstr
            Dim vbReader As MySqlDataReader
            Try
                vbConn.Open()
                Dim Query As String
                Query = "select * from admingiris"
                vbCommand = New MySqlCommand(Query, vbConn)
                vbReader = vbCommand.ExecuteReader()
                While vbReader.Read()
                    adminkullanici = vbReader("kullaniciAd")
                    adminpass = vbReader("sifre")
                    If (adminkadiTB.Text = adminkullanici) And (adminsifreTB.Text = adminpass) Then
                        MessageBox.Show("Başarılı giriş!", "Başarılı")
                        Anamenu.adminYetkilendir("admin")
                        Me.Close()
                        'adminkadiTB.Clear()  ' Bunlar anamenude admin cikis butonunda tanımlandı nesne ile
                        'adminsifreTB.Clear()
                        Exit While
                    End If
                End While
                If (adminkadiTB.Text <> adminkullanici) And (adminsifreTB.Text <> adminpass) Then
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Başarısız")
                    adminkadiTB.Clear()
                    adminsifreTB.Clear()
                End If
                vbConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                vbConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub admingirisbackbutton_Click(sender As Object, e As EventArgs) Handles admingirisbackbutton.Click
        adminkadiTB.Text = ""
        adminsifreTB.Text = ""
        Me.Close()
    End Sub


    Private Sub admingiris_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        adminkadiTB.Focus()
    End Sub
End Class