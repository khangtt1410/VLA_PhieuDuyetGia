Public Class frmPhieuDuyetGia
    Dim db As New DBContextDataContext
    Dim donViSuDung As Integer
    Private Sub btnThemMoi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemMoi.ItemClick
        frmPhieuDuyetGia_CapNhat.Show()
    End Sub

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
End Class