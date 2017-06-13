Public Class Kontrol
    Public Shared Function SayiKontrolu(UstSninir As Integer, obj As Object, karakter As KeyPressEventArgs) As Boolean
        Dim txt As New TextBox
        Dim mstxt As New MaskedTextBox
        If TypeOf obj Is TextBox Then
            txt = obj
            If (txt.Text.Count <= UstSninir) Then
                If (Asc(karakter.KeyChar) < 48 OrElse Asc(karakter.KeyChar) > 57) AndAlso Asc(karakter.KeyChar) <> 8 Then : Return True
                Else : Return False
                End If
            ElseIf Asc(karakter.KeyChar) = 8 Then
                Return False
            End If
        ElseIf TypeOf obj Is MaskedTextBox Then
            mstxt = obj
            If (Asc(karakter.KeyChar) < 48 OrElse Asc(karakter.KeyChar) > 57) AndAlso Asc(karakter.KeyChar) <> 8 Then : Return True
            Else : Return False
            End If
            Return True
        End If
        Return True
    End Function
    Public Shared Function HarfKontrolu(karakter As KeyPressEventArgs) As Boolean
        If (Asc(karakter.KeyChar) >= 48 AndAlso Asc(karakter.KeyChar) <= 57) Then Return True Else Return False
    End Function
End Class
