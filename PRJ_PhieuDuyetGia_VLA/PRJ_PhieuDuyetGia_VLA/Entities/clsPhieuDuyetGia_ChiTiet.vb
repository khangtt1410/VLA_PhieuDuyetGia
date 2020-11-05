Public Class clsPhieuDuyetGia_ChiTiet
    Public _ID As String
    Public _IDPhieuDuyetGia As String
    Public _SoDonHang As String
    Public _TenDonVi As String
    Public _TenSanPham As String
    Public _QuyCachSanPham As String
    Public _SoLuong As Integer
    Public _GiayRuot As Double
    Public _GiayBia As Double
    Public _LaiDinhMuc As Double
    Public _DonGiaTinh As Double
    Public _CreatedOn As Date?
    Public _CreatedBy As Integer?
    Public _CreatedName As String
    Public _EditedOn As Date?
    Public _EditedBy As Integer?
    Public _EditedName As String
    Public _InUsed As Boolean
    Public _TrangThaiDuyet As Boolean
    Public _TrangThaiIn As Boolean
    Public _IsChoose As Boolean
    Public _IDDonHangChiTiet As String
    Public _DonGiaChiDao As Double
    Public _DoKhoTaiLieu As Integer

    Public Sub New()
        MyBase.New()
    End Sub

    Public Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property
    Public Property IDPhieuDuyetGia() As String
        Get
            Return _IDPhieuDuyetGia
        End Get
        Set(ByVal value As String)
            _IDPhieuDuyetGia = value
        End Set
    End Property
    Public Property SoDonHang() As String
        Get
            Return _SoDonHang
        End Get
        Set(ByVal value As String)
            _SoDonHang = value
        End Set
    End Property
    Public Property TenDonVi() As String
        Get
            Return _TenDonVi
        End Get
        Set(ByVal value As String)
            _TenDonVi = value
        End Set
    End Property
    Public Property TenSanPham() As String
        Get
            Return _TenSanPham
        End Get
        Set(ByVal value As String)
            _TenSanPham = value
        End Set
    End Property
    Public Property QuyCachSanPham() As String
        Get
            Return _QuyCachSanPham
        End Get
        Set(ByVal value As String)
            _QuyCachSanPham = value
        End Set
    End Property
    Public Property SoLuong() As String
        Get
            Return _SoLuong
        End Get
        Set(ByVal value As String)
            _SoLuong = value
        End Set
    End Property
    Public Property GiayRuot() As Double
        Get
            Return _GiayRuot
        End Get
        Set(ByVal value As Double)
            _GiayRuot = value
        End Set
    End Property
    Public Property GiayBia() As Double
        Get
            Return _GiayBia
        End Get
        Set(ByVal value As Double)
            _GiayBia = value
        End Set
    End Property
    Public Property LaiDinhMuc() As String
        Get
            Return _LaiDinhMuc
        End Get
        Set(ByVal value As String)
            _LaiDinhMuc = value
        End Set
    End Property
    Public Property DonGiaTinh() As String
        Get
            Return _DonGiaTinh
        End Get
        Set(ByVal value As String)
            _DonGiaTinh = value
        End Set
    End Property
    Public Property InUsed() As Boolean
        Get
            Return _InUsed
        End Get
        Set(ByVal value As Boolean)
            _InUsed = value
        End Set
    End Property
    Public Property CreatedOn() As Date?
        Get
            Return _CreatedOn
        End Get
        Set(ByVal value As Date?)
            _CreatedOn = value
        End Set
    End Property
    Public Property CreatedBy() As Integer?
        Get
            Return _CreatedBy
        End Get
        Set(ByVal value As Integer?)
            _CreatedBy = value
        End Set
    End Property
    Public Property CreatedName() As String
        Get
            Return _CreatedName
        End Get
        Set(ByVal value As String)
            _CreatedName = value
        End Set
    End Property
    Public Property EditedOn() As Date?
        Get
            Return _EditedOn
        End Get
        Set(ByVal value As Date?)
            _EditedOn = value
        End Set
    End Property
    Public Property EditedBy() As Integer?
        Get
            Return _EditedBy
        End Get
        Set(ByVal value As Integer?)
            _EditedBy = value
        End Set
    End Property
    Public Property EditedName() As String
        Get
            Return _EditedName
        End Get
        Set(ByVal value As String)
            _EditedName = value
        End Set
    End Property
    Public Property TrangThaiIn() As Boolean
        Get
            Return _TrangThaiIn
        End Get
        Set(ByVal value As Boolean)
            If _TrangThaiIn = Value Then
                Return
            End If
            _TrangThaiIn = Value
        End Set
    End Property
    Public Property TrangThaiDuyet() As Boolean
        Get
            Return _TrangThaiDuyet
        End Get
        Set(ByVal value As Boolean)
            If _TrangThaiDuyet = Value Then
                Return
            End If
            _TrangThaiDuyet = Value
        End Set
    End Property
    Public Property IsChoose() As Boolean
        Get
            Return _IsChoose
        End Get
        Set(ByVal value As Boolean)
            If _IsChoose = Value Then
                Return
            End If
            _IsChoose = Value
        End Set
    End Property
    Public Property IDDonHangChiTiet() As String
        Get
            Return _IDDonHangChiTiet
        End Get
        Set(ByVal value As String)
            If _IDDonHangChiTiet = Value Then
                Return
            End If
            _IDDonHangChiTiet = Value
        End Set
    End Property
    Public Property DonGiaChiDao() As Double
        Get
            Return _DonGiaChiDao
        End Get
        Set(ByVal value As Double)
            If _DonGiaChiDao = Value Then
                Return
            End If
            _DonGiaChiDao = Value
        End Set
    End Property
    Public Property DoKhoTaiLieu() As Integer
        Get
            Return _DoKhoTaiLieu
        End Get
        Set(ByVal value As Integer)
            If _DoKhoTaiLieu = Value Then
                Return
            End If
            _DoKhoTaiLieu = Value
        End Set
    End Property
End Class
