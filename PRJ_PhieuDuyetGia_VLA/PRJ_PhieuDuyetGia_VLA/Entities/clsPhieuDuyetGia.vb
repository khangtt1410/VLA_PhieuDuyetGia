Public Class clsPhieuDuyetGia
    Public _ID As String
    Public _SoPhieu As String
    Public _TenPhieu As String
    Public _InUsed As Boolean
    Public _CreatedOn As Date
    Public _CreatedName As String
    Public _CreatedBy As Integer
    Public _EditedOn As Date
    Public _EditedName As String
    Public _EditedBy As Integer
    Public _KyNhay As Boolean
    Public _TrangThaiDuyet As Boolean
    Public _GhiChu As String

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
    Public Property SoPhieu() As String
        Get
            Return _SoPhieu
        End Get
        Set(ByVal value As String)
            _SoPhieu = value
        End Set
    End Property
    Public Property TenPhieu() As String
        Get
            Return _TenPhieu
        End Get
        Set(ByVal value As String)
            _TenPhieu = value
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
    Public Property CreatedOn() As Date
        Get
            Return _CreatedOn
        End Get
        Set(ByVal value As Date)
            _CreatedOn = value
        End Set
    End Property
    Public Property CreatedBy() As Integer
        Get
            Return _CreatedBy
        End Get
        Set(ByVal value As Integer)
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
    Public Property EditedOn() As Date
        Get
            Return _EditedOn
        End Get
        Set(ByVal value As Date)
            _EditedOn = value
        End Set
    End Property
    Public Property EditedBy() As Integer
        Get
            Return _EditedBy
        End Get
        Set(ByVal value As Integer)
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
    Public Property KyNhay() As Boolean
        Get
            Return _KyNhay
        End Get
        Set(ByVal value As Boolean)
            _KyNhay = value
        End Set
    End Property
    Public Property TrangThaiDuyet() As Boolean
        Get
            Return _TrangThaiDuyet
        End Get
        Set(ByVal value As Boolean)
            _TrangThaiDuyet = value
        End Set
    End Property
    Public Property GhiChu() As String
        Get
            Return _GhiChu
        End Get
        Set(ByVal value As String)
            If _GhiChu = Value Then
                Return
            End If
            _GhiChu = Value
        End Set
    End Property
End Class
