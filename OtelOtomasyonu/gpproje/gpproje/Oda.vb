Public Class Oda
    Private oda_no As Integer
    Private oda_turu As String
    Private oda_sayisi As UShort
    Private yatak_Sayisi As Byte
    Private kisi_sayisi As Byte
    Private manzara As String
    Private durum As String
    Private giris_tarihi As Integer
    Private cikis_tarihi As Integer
    Private ucret As Integer
    Public Property fiyat() As Integer
        Get
            Return ucret
        End Get
        Set(ByVal value As Integer)
            ucret = value
        End Set
    End Property

    Public Property odaNo As Integer
        Get
            Return oda_no
        End Get
        Set(value As Integer)
            oda_no = value
        End Set
    End Property
    Public Property odaTuru As String
        Get
            Return oda_turu
        End Get
        Set(value As String)
            oda_turu = value
        End Set
    End Property
    Public Property kisiSayisi As Byte
        Get
            Return kisi_sayisi
        End Get
        Set(value As Byte)
            kisi_sayisi = value
        End Set
    End Property
    Public Property manzra As String
        Get
            Return manzara
        End Get
        Set(value As String)
            manzara = value
        End Set
    End Property
    Public Property durm As String
        Get
            Return durum
        End Get
        Set(value As String)
            durum = value
        End Set
    End Property
    Public Property girisTarihi As Integer
        Get
            Return giris_tarihi
        End Get
        Set(value As Integer)
            giris_tarihi = value

        End Set
    End Property
    Public Property cikisTarihi As Integer
        Get
            Return cikis_tarihi
        End Get
        Set(value As Integer)
            cikis_tarihi = value
        End Set
    End Property
    Public Property odaSayisi As UShort
        Get
            Return oda_sayisi

        End Get
        Set(value As UShort)
            oda_sayisi = value
        End Set
    End Property
    Public Property yatakSayisi As Byte
        Get
            Return yatak_Sayisi

        End Get
        Set(value As Byte)
            yatak_Sayisi = value
        End Set
    End Property
End Class
