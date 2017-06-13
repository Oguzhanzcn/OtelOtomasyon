Imports System
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Anamenu
    Dim admingiris As New admingiris

    Dim vbConn As MySqlConnection
    Dim vbCommand As MySqlCommand

    Friend Property adminyetki = False
    Friend Property cnstr = "server=localhost;userid=root;database=oteloto"

    Private Sub admingirisbutton_Click(sender As Object, e As EventArgs) Handles admingirisbutton.Click
        admingiris.ShowDialog()
    End Sub

    Private Sub admincikisbutton_Click(sender As Object, e As EventArgs) Handles admincikisbutton.Click
        adminYetkilendir("misafir")
        admingiris.adminkadiTB.Clear()
        admingiris.adminsifreTB.Clear()
    End Sub

    Private Sub Anamenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adminYetkilendir("misafir")
    End Sub

    Private Sub isbasvurubutton_Click(sender As Object, e As EventArgs) Handles isbasvurubutton.Click
        Me.Hide()
        Dim basvurular As New isbasvurulari
        isbasvurulari.ShowDialog()
        Me.Show()
    End Sub

    Private Sub basvurulistebutton_Click(sender As Object, e As EventArgs) Handles basvurulistebutton.Click
        Me.Hide()
        Dim basvurular As New basvurulistesi
        basvurular.ShowDialog()
        Me.Show()
    End Sub

    Private Sub calisanbilgibutton_Click(sender As Object, e As EventArgs) Handles calisanbilgibutton.Click
        Me.Hide()
        Dim calisanlar As New calisanlistesi
        calisanlar.ShowDialog()
        Me.Show()
    End Sub

    Private Sub odabilgibutton_Click(sender As Object, e As EventArgs) Handles odabilgibutton.Click
        Me.Hide()
        Dim odabilgisi As New odabilgileri
        odabilgisi.ShowDialog()
        Me.Show()
    End Sub

    Private Sub musteribilgibutton_Click(sender As Object, e As EventArgs) Handles musteribilgibutton.Click
        Me.Hide()
        Dim musteribilgisi As New musteribilgileri
        musteribilgisi.ShowDialog()
        Me.Show()
    End Sub

    Function adminYetkilendir(ByRef yetki As String)
        If yetki = "misafir" Then
            adminyetki = False
            admingirisbutton.Show()
            yetkilb.Text = "Misafir"
            yetkilb.ForeColor = Color.Red
            admincikisbutton.Hide()
            basvurulistebutton.Visible = False
            musteribilgibutton.Visible = False
            calisanbilgibutton.Visible = False
            odabilgibutton.Visible = False
            odakayitbutton.Visible = False
            odaayarlaributton.Visible = False
            Label3.Visible = False
            Label2.Visible = False
            Label1.Location = New Point(268, 87)
            hakkimizdabutton.Location = New Point(245, 132)
            isbasvurubutton.Location = New Point(245, 184)
            degerlendirmelerbutton.Location = New Point(245, 232)
            degerlendirmeler.Button1.Visible = False
            Button1.Visible = False

        ElseIf yetki = "admin" Then
            adminyetki = True
            admingirisbutton.Hide()
            yetkilb.Text = "Admin"
            yetkilb.ForeColor = Color.Gold
            admincikisbutton.Show()
            basvurulistebutton.Visible = True
            musteribilgibutton.Visible = True
            calisanbilgibutton.Visible = True
            odabilgibutton.Visible = True
            odakayitbutton.Visible = True
            odaayarlaributton.Visible = True
            Label3.Visible = True
            Label2.Visible = True
            Label1.Location = New Point(470, 87)
            hakkimizdabutton.Location = New Point(436, 132)
            isbasvurubutton.Location = New Point(436, 184)
            degerlendirmelerbutton.Location = New Point(436, 232)
            degerlendirmeler.Button1.Visible = True
            Button1.Visible = True
        End If
        Return 0
    End Function

    Private Sub odakayitbutton_Click(sender As Object, e As EventArgs) Handles odakayitbutton.Click
        Me.Hide()
        odakayit.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles degerlendirmelerbutton.Click
        Me.Hide()
        degerlendirmeler.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles odaayarlaributton.Click
        Me.Hide()
        Dim odaayarları As New odaayarlari
        odaayarlari.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        adminekle.ShowDialog()
        Me.Show()
    End Sub

    Private Sub hakkimizdabutton_Click(sender As Object, e As EventArgs) Handles hakkimizdabutton.Click
        Me.Hide()
        Hakkimizda.ShowDialog()
    End Sub
End Class
