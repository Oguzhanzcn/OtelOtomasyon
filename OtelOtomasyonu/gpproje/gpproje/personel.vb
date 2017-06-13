Public Class Personel
    Private calisan_AdSoyad As String
    Private calisan_yas As Byte
    Private _Alan As String
    Private TCk_no As String
    Private oz_gecmis As String

    Public Property calisanAdSoyad As String
        Get
            Return calisan_AdSoyad
        End Get
        Set(value As String)
            calisan_AdSoyad = value
        End Set
    End Property
    Public Property calisanYas As Byte
        Get
            Return calisan_yas
        End Get
        Set(value As Byte)
            calisan_yas = value
        End Set
    End Property
    Public Property Alan As String
        Get
            Return _Alan
        End Get
        Set(value As String)
            _Alan = value
        End Set
    End Property
    Public Property TCKno As String
        Get
            Return TCk_no
        End Get
        Set(value As String)
            TCk_no = value
        End Set
    End Property
    Public Property ozGecmis As String
        Get
            Return oz_gecmis
        End Get
        Set(value As String)
            oz_gecmis = value
        End Set
    End Property

End Class
