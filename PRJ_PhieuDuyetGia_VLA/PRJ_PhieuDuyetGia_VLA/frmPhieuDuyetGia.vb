Public Class frmPhieuDuyetGia
    Dim db As New DBContextDataContext
    Dim donViSuDung As Integer
    Private Sub btnThemMoi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemMoi.ItemClick
        frmPhieuDuyetGia_CapNhat.Show()
    End Sub
    ''' <summary>
    ''' Hàm thực hiện load trang. Hiển thị danh sách phiếu duyệt giá lên grd
    ''' </summary>
    Private Sub frmPhieuDuyetGia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Lấy danh sách phiếu duyệt giá từ bảng SX_PhieuDuyetGia
        Dim lstPhieuDuyetGia As New List(Of clsPhieuDuyetGia)
        lstPhieuDuyetGia = (From ds In db.SX_PhieuDuyetGias _
                           Where ds.TrangThai = True And ds.DonViSuDung = donViSuDung _
                           Order By ds.CreatedOn Descending, ds.SoPhieu Ascending _
                           Select new clsPhieuDuyetGia with { _
                           .ID = ds.ID, _
                           .SoPhieu = ds.SoPhieu, _
                           .TenPhieu = ds.TenPhieu, _
                           .CreatedOn = ds.CreatedOn, _
                           .CreatedBy = ds.CreatedBy, _
                           .KyNhay = False, _
                           .TrangThaiDuyet = False} _
                           ).ToList
        binSource.DataSource = lstPhieuDuyetGia
        grdPhieuDuyetGia.DataSource = binSource
    End Sub
    ''' <summary>
    ''' Hàm hiển thị chi tiết danh sách đơn hàng trong phiếu duyệt giá
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvPhieuDuyetGia_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvPhieuDuyetGia.FocusedRowChanged
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim lstDonHang As List(Of SX_PhieuDuyetGia_ChiTiet)

        'Lấy thông tin id từ hàng đang focus
        idPhieu = grvPhieuDuyetGia.GetDataRow(e.FocusedRowHandle)["ID"].ToString();
        'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
        lstDonHang = (From ds In db.SX_PhieuDuyetGia_ChiTiets _
                     Where ds.IDPhieuDuyetGia = idPhieu And ds.TrangThai = True And ds.DonViSuDung = 0 _
                     Select ds Order By ds.CreatedOn Descending, ds.SoDonHang Ascending).ToList
        'Đổ dữ liệu vào grid
        binSource_Detail.DataSource = lstDonHang
        grdThongTinChiTiet.DataSource = binSource_Detail

    End Sub
    ''' <summary>
    ''' Hàm xử lý sự kiện ký nháy của phòng tài chính kế toán
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub repCheckKyNhay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCheckKyNhay.CheckedChanged
        Dim idPhieu As String
        idPhieu = grvPhieuDuyetGia.GetFocusedRowCellValue("ID").ToString()
    End Sub
End Class