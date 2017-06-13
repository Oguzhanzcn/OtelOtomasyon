Imports System.Text

Public Class Hakkimizda

    Private Sub hakkimizdageributton_Click(sender As Object, e As EventArgs) Handles hakkimizdageributton.Click ' GERI TUSU
        Me.Close()
        Anamenu.Show()
    End Sub

    Private Sub hakkimizdakapat() Handles MyBase.FormClosed 'FORM KAPANIRSA
        Anamenu.Show()
    End Sub

    Private Sub Hakkimizda_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' FORM YUKLENIRKEN
        Dim utf8 As Encoding = Encoding.UTF8
        Dim unicode As Encoding = Encoding.Unicode
        Dim utfbytes As Byte() = utf8.GetBytes(My.Resources.hakkimizda)
        Dim unicodebytes As Byte() = Encoding.Convert(utf8, unicode, utfbytes)
        Dim unicodeChars(unicode.GetCharCount(unicodebytes, 0, unicodebytes.Length) - 1) As Char
        unicode.GetChars(unicodebytes, 0, unicodebytes.Length, unicodeChars, 0)
        Dim unicodeString As New String(unicodeChars)
        hakkimizdalabel.Text = unicodeString
        telefonlb.Text = My.Resources.hakkimizdatelefon
        fakslb.Text = My.Resources.hakkimizdafaks
    End Sub
End Class