Public Class Musteri
    Private kaldigiOda As String
    Private musteri_No As UShort
    Private musteri_Tc As String
    Private musteri_AdSoyad As String
    Private musteri_yas As Byte
    Private giris As Date
    Private cikis As Date

    Public Property girisTarihi As Date
        Get
            Return giris
        End Get
        Set(value As Date)
            giris = value
        End Set
    End Property
    Public Property cikisTarihi As Date
        Get
            Return cikis
        End Get
        Set(value As Date)
            cikis = value
        End Set
    End Property

    Public Property kalinanOda As String
        Get
            Return kaldigiOda
        End Get
        Set(value As String)
            kaldigiOda = value
        End Set
    End Property
    Public Property yasi As Byte
        Get
            Return musteri_yas
        End Get
        Set(value As Byte)
            musteri_yas = value

        End Set
    End Property
    Public Property musteriNo As UShort
        Get
            Return musteri_No
        End Get
        Set(value As UShort)
            musteri_No = value
        End Set
    End Property
    Public Property musteriTc As String
        Get
            Return musteri_Tc
        End Get
        Set(value As String)
            musteri_Tc = value
        End Set
    End Property
    Public Property musteriAdSoyad As String
        Get
            Return musteri_AdSoyad

        End Get
        Set(value As String)
            musteri_AdSoyad = value

        End Set
    End Property

End Class
