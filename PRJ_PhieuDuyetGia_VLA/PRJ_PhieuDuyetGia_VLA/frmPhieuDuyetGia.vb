Public Class frmPhieuDuyetGia
#Region "Khai báo tham số"
    Dim db As New DBContextDataContext
    Dim donViSuDung As Integer
#End Region
    ''' <summary>
    ''' Chuyển trang thêm mới/ sửa đổi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnThemMoi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemMoi.ItemClick
        frmPhieuDuyetGia_CapNhat.Show()
    End Sub
    ''' <summary>
    ''' Lấy danh sách phiếu duyệt giá từ db
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Sub LoadData_PhieuDuyetGia()
        'Lấy danh sách phiếu duyệt giá từ bảng SX_PhieuDuyetGia
        Dim lstPhieuDuyetGia As New List(Of clsPhieuDuyetGia)
        lstPhieuDuyetGia = (From ds In db.SX_PhieuDuyetGias _
                           Where ds.TrangThai = True And ds.DonViSuDung = donViSuDung _
                           Order By ds.CreatedOn Descending, ds.SoPhieu Ascending _
                           Select New clsPhieuDuyetGia With { _
                           .ID = ds.ID, _
                           .SoPhieu = ds.SoPhieu, _
                           .TenPhieu = ds.TenPhieu, _
                           .CreatedOn = ds.CreatedOn, _
                           .CreatedBy = ds.CreatedBy, _
                           .KyNhay = If((ds.TrangThaiDuyet = 1), True, False), _
                           .TrangThaiDuyetBln = If((ds.TrangThaiDuyet = 2), True, False)} _
                           ).ToList
        'Đổ dữ liệu vào grid
        binSource.DataSource = lstPhieuDuyetGia
        grdPhieuDuyetGia.DataSource = binSource
        'Focus hàng đầu tiên
        grvPhieuDuyetGia.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
    End Sub
    ''' <summary>
    ''' Hàm thực hiện load trang. Hiển thị danh sách phiếu duyệt giá lên grid
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuDuyetGia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData_PhieuDuyetGia()
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
        Dim objCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        If objCurrent IsNot Nothing Then
            idPhieu = objCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            lstDonHang = (From ds In db.SX_PhieuDuyetGia_ChiTiets _
                         Where ds.IDPhieuDuyetGia = idPhieu And ds.TrangThai = True And ds.DonViSuDung = 0 _
                         Select ds Order By ds.CreatedOn Descending, ds.SoDonHang Ascending).ToList
            'Đổ dữ liệu vào grid
            binSource_Detail.DataSource = lstDonHang
            grdThongTinChiTiet.DataSource = binSource_Detail
        End If
    End Sub
    ''' <summary>
    ''' Hàm xử lý sự kiện ký nháy của phòng tài chính kế toán
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub repCheckKyNhay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCheckKyNhay.CheckedChanged
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim objPhieu As SX_PhieuDuyetGia

        'Lấy thông tin id từ hàng đang focus
        Dim idCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        If idCurrent IsNot Nothing Then
            idPhieu = idCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            objPhieu = (From ds In db.SX_PhieuDuyetGias _
                         Where ds.ID = idPhieu And ds.TrangThai = True And ds.DonViSuDung = 0 _
                         Select ds).FirstOrDefault
            If objPhieu IsNot Nothing AndAlso MessageBox.Show("Bạn có thực sự muốn ký nháy đối với bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                objPhieu.TrangThaiDuyet = 1
                db.SubmitChanges()
                MessageBox.Show("Ký nháy phiếu duyệt giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
                LoadData_PhieuDuyetGia()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Hàm xử lý sự kiện F5: làm mới trang
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnNapLai_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNapLai.ItemClick
        LoadData_PhieuDuyetGia()
    End Sub
    ''' <summary>
    ''' Hàm xử lý sự kiện xóa dữ liệu
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnXoa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Try
            'Khởi tạo tham số chưa id phiếu duyệt giá
            Dim idPhieu As String

            'Lấy thông tin id từ hàng đang focus
            Dim objCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
            If objCurrent IsNot Nothing Then
                idPhieu = objCurrent.ToString
                If MessageBox.Show("Bạn có thực sự muốn xóa bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim objDel As SX_PhieuDuyetGia = (From ds In db.SX_PhieuDuyetGias Where ds.ID = idPhieu And ds.TrangThai = True And ds.DonViSuDung = 0).FirstOrDefault
                    If objDel IsNot Nothing Then
                        objDel.TrangThai = False
                        db.SubmitChanges()
                        MessageBox.Show("Xóa phiếu duyệt giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
                        LoadData_PhieuDuyetGia()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
        End Try
    End Sub
    ''' <summary>
    ''' Sự kiện giám đốc phê duyệt giá sau khi bên tài chính kế toán đã ký nháy
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub repCheckTrangThaiDuyet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCheckTrangThaiDuyet.CheckedChanged
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim objPhieu As SX_PhieuDuyetGia

        'Lấy thông tin id từ hàng đang focus
        Dim idCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        If idCurrent IsNot Nothing Then
            idPhieu = idCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            objPhieu = (From ds In db.SX_PhieuDuyetGias _
                         Where ds.ID = idPhieu And ds.TrangThai = True And ds.DonViSuDung = 0 _
                         Select ds).FirstOrDefault
            If objPhieu IsNot Nothing AndAlso MessageBox.Show("Bạn có thực sự muốn phê duyệt giá đối với bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                objPhieu.TrangThaiDuyet = 2
                db.SubmitChanges()
                MessageBox.Show("Phê duyệt giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
                LoadData_PhieuDuyetGia()
            End If
        End If
    End Sub
End Class