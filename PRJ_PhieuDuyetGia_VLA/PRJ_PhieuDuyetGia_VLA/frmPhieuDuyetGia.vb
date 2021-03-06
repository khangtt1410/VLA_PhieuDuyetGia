Imports PRJ_PhieuDuyetGia_VLA.Publics
Public Class frmPhieuDuyetGia
#Region "Khai báo tham số"
    'Khai báo database
    Dim db As New DBContextDataContext
    'Khai báo quyền truy cập
    Dim addRole As Boolean = True
    Dim editRole As Boolean = True
    Dim deleteRole As Boolean = True
    Dim kyNhayRole As Boolean = False
#End Region
#Region "Xử lý thêm mới/ sửa đổi/ sao chép phiếu duyệt giá"
    ''' <summary>
    ''' Chuyển trang thêm mới/ sửa đổi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnThemMoi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnThemMoi.ItemClick
        'Lấy vị trí hàng cần sửa đổi trong grv
        Dim rowCurrent As Integer = grvPhieuDuyetGia.GetFocusedDataSourceRowIndex
        'Khởi tạo form thêm mới
        Dim frmAdd As New frmPhieuDuyetGia_CapNhat()
        frmAdd.frmAction = addAction
        'Hiển thị form thêm mới
        If frmAdd.ShowDialog() = Windows.Forms.DialogResult.Yes Then
            'Load lại trang
            LoadData_PhieuDuyetGia()
            'Focus vào hàng vừa sửa đổi
            grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
        End If
    End Sub

    ''' <summary>
    ''' Sửa đổi phiếu duyệt giá
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSuaDoi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSuaDoi.ItemClick
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim objPhieu As SX_PhieuDuyetGia
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim lstDonHang As List(Of clsPhieuDuyetGia_ChiTiet)
        'Lấy vị trí hàng cần sửa đổi trong grv
        Dim rowCurrent As Integer = grvPhieuDuyetGia.GetFocusedDataSourceRowIndex

        'Lấy thông tin id từ hàng đang focus
        Dim objCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        If objCurrent IsNot Nothing Then
            idPhieu = objCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            objPhieu = (From ds In db.SX_PhieuDuyetGias _
                         Where ds.ID = idPhieu And ds.InUsed = True _
                         Select ds).FirstOrDefault
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            lstDonHang = (From ds In db.SX_PhieuDuyetGia_ChiTiets _
                         Where ds.IDPhieuDuyetGia = idPhieu And ds.InUsed = True _
                         Order By ds.CreatedOn Descending, ds.SoDonHang Ascending _
                          Select New clsPhieuDuyetGia_ChiTiet With { _
                          .ID = ds.ID, _
                          .IDPhieuDuyetGia = ds.IDPhieuDuyetGia, _
                          .IDDonHangChiTiet = ds.IDDonHangChiTiet, _
                          .SoDonHang = ds.SoDonHang, _
                          .TenDonVi = ds.TenDonVi, _
                          .TenSanPham = ds.TenSanPham, _
                          .SoLuong = ds.SoLuong, _
                          .QuyCachSanPham = ds.QuyCachSanPham, _
                          .GiayRuot = ds.GiayRuot, _
                          .GiayBia = ds.GiayBia, _
                          .LaiDinhMuc = ds.LaiDinhMuc, _
                          .DonGiaTinh = ds.DonGiaTinh, _
                          .TrangThaiDuyet = ds.TrangThaiDuyet, _
                          .TrangThaiIn = ds.TrangThaiIn}).ToList
            'Gọi form cập nhật
            Dim frmEdit As New frmPhieuDuyetGia_CapNhat()
            frmEdit.frmAction = editAction
            frmEdit.phieuDuyetGia = objPhieu
            frmEdit.lstSource = lstDonHang
            If frmEdit.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                'Load lại trang
                LoadData_PhieuDuyetGia()
                'Focus vào hàng vừa sửa đổi
                grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
            End If
        Else
            MessageBox.Show("Vui lòng chọn bản ghi trước khi sửa đổi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Sao chép phiếu duyệt giá
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSaoChep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSaoChep.ItemClick
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim objPhieu As SX_PhieuDuyetGia
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim lstDonHang As List(Of clsPhieuDuyetGia_ChiTiet)
        'Lấy vị trí hàng cần sửa đổi trong grv
        Dim rowCurrent As Integer = grvPhieuDuyetGia.GetFocusedDataSourceRowIndex

        'Lấy thông tin id từ hàng đang focus
        Dim objCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        If objCurrent IsNot Nothing Then
            idPhieu = objCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            objPhieu = (From ds In db.SX_PhieuDuyetGias _
                         Where ds.ID = idPhieu And ds.InUsed = True _
                         Select ds).FirstOrDefault
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            lstDonHang = (From ds In db.SX_PhieuDuyetGia_ChiTiets _
                        Where ds.IDPhieuDuyetGia = idPhieu And ds.InUsed = True _
                        Order By ds.CreatedOn Descending, ds.SoDonHang Ascending _
                         Select New clsPhieuDuyetGia_ChiTiet With { _
                         .ID = ds.ID, _
                         .IDPhieuDuyetGia = ds.IDPhieuDuyetGia, _
                         .IDDonHangChiTiet = ds.IDDonHangChiTiet, _
                         .SoDonHang = ds.SoDonHang, _
                         .TenDonVi = ds.TenDonVi, _
                         .TenSanPham = ds.TenSanPham, _
                         .SoLuong = ds.SoLuong, _
                         .QuyCachSanPham = ds.QuyCachSanPham, _
                         .GiayRuot = ds.GiayRuot, _
                         .GiayBia = ds.GiayBia, _
                         .LaiDinhMuc = ds.LaiDinhMuc, _
                         .DonGiaTinh = ds.DonGiaTinh, _
                          .TrangThaiDuyet = ds.TrangThaiDuyet, _
                          .TrangThaiIn = ds.TrangThaiIn}).ToList
            'Gọi form cập nhật
            Dim frmEdit As New frmPhieuDuyetGia_CapNhat()
            frmEdit.frmAction = copyAction
            frmEdit.phieuDuyetGia = objPhieu
            frmEdit.lstSource = lstDonHang
            If frmEdit.ShowDialog() = Windows.Forms.DialogResult.Yes Then
                'Load lại trang
                LoadData_PhieuDuyetGia()
                'Focus vào hàng vừa sửa đổi
                grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
            End If
        Else
            MessageBox.Show("Vui lòng chọn bản ghi trước khi sao chép!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
#End Region
#Region "Xử lý load trang"
    ''' <summary>
    ''' Lấy danh sách phiếu duyệt giá từ db
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Sub LoadData_PhieuDuyetGia()
        Dim lstPhieuDuyetGia As New List(Of clsPhieuDuyetGia)
        lstPhieuDuyetGia = (From ds In db.SX_PhieuDuyetGias _
                           Where ds.InUsed = True _
                           Order By ds.CreatedOn Descending, ds.SoPhieu Ascending _
                           Select New clsPhieuDuyetGia With { _
                           .ID = ds.ID, _
                           .SoPhieu = ds.SoPhieu, _
                           .TenPhieu = ds.TenPhieu, _
                           .CreatedOn = ds.CreatedOn, _
                           .CreatedBy = ds.CreatedBy, _
                           .CreatedName = ds.CreatedName, _
                           .GhiChu = ds.GhiChu, _
                           .KyNhay = ds.TrangThaiKyNhay, _
                           .TrangThaiDuyet = ds.TrangThaiDuyet} _
                           ).ToList
        'Lấy danh sách phiếu duyệt giá từ bảng SX_PhieuDuyetGia. 
        'Hệ thống sẽ kiểm tra quyền, nếu người dùng có quyền ký nháy, sẽ chỉ hiển thị những phiếu có trạng thái duyệt là 0
        'hoặc là 1 và chưa được duyệt giá
        If kyNhayRole = True Then
            lstPhieuDuyetGia = (From ds In lstPhieuDuyetGia Where ds.KyNhay = False Or (ds.KyNhay = True AndAlso ds.TrangThaiDuyet = False)).ToList()
        End If
        'Đổ dữ liệu vào grid
        binSource.DataSource = lstPhieuDuyetGia
        grdPhieuDuyetGia.DataSource = binSource
        'Focus hàng đầu tiên
        grvPhieuDuyetGia.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
    End Sub

    ''' <summary>
    ''' Hàm thực hiện load trang. Hiển thị danh sách phiếu duyệt giá lên grid
    ''' Cột trạng thái phiếu duyệt giá được cho là true khi đã có ít nhất một sản phẩm trong phiếu được duyệt
    ''' Trạng thái này khi thực hiện duyệt trên mobile sẽ thay đổi
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuDuyetGia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Kiểm tra quyền truy cập
        If addRole = True Then
            btnThemMoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
            btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        Else
            btnThemMoi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
            btnSaoChep.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        End If
        btnSuaDoi.Visibility = If((editRole = True), DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
        btnXoa.Visibility = If((deleteRole = True), DevExpress.XtraBars.BarItemVisibility.Always, DevExpress.XtraBars.BarItemVisibility.Never)
        grdColKyNhay.OptionsColumn.ReadOnly = kyNhayRole
        grdColTrangThaiDuyet.OptionsColumn.ReadOnly = True
        LoadData_PhieuDuyetGia()
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
    ''' Hàm hiển thị chi tiết danh sách đơn hàng trong phiếu duyệt giá
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvPhieuDuyetGia_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvPhieuDuyetGia.FocusedRowChanged
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim lstDonHang As List(Of clsPhieuDuyetGia_ChiTiet)

        'Lấy thông tin id từ hàng đang focus
        Dim objCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        If objCurrent IsNot Nothing Then
            idPhieu = objCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            lstDonHang = (From ds In db.SX_PhieuDuyetGia_ChiTiets _
                         Where ds.IDPhieuDuyetGia = idPhieu And ds.InUsed = True _
                         Order By ds.CreatedOn Descending, ds.SoDonHang Ascending _
                          Select New clsPhieuDuyetGia_ChiTiet With { _
                          .ID = ds.ID, _
                          .IDPhieuDuyetGia = ds.IDPhieuDuyetGia, _
                          .IDDonHangChiTiet = ds.IDDonHangChiTiet, _
                          .SoDonHang = ds.SoDonHang, _
                          .TenDonVi = ds.TenDonVi, _
                          .TenSanPham = ds.TenSanPham, _
                          .SoLuong = ds.SoLuong, _
                          .QuyCachSanPham = ds.QuyCachSanPham, _
                          .GiayRuot = ds.GiayRuot, _
                          .GiayBia = ds.GiayBia, _
                          .LaiDinhMuc = ds.LaiDinhMuc, _
                          .DonGiaTinh = ds.DonGiaTinh, _
                          .TrangThaiDuyet = ds.TrangThaiDuyet, _
                          .TrangThaiIn = ds.TrangThaiIn}).ToList
            'Đổ dữ liệu vào grid
            binSource_Detail.DataSource = lstDonHang
            grdThongTinChiTiet.DataSource = binSource_Detail
        End If
    End Sub
#End Region
#Region "Xử lý ký nháy và duyệt"
    ''' <summary>
    ''' Hàm xử lý sự kiện ký nháy của phòng tài chính kế toán
    ''' Ký nháy sẽ được thực hiện ngay giao diện ngoài, không cần phải vào xem bên trong
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub repCheckKyNhay_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCheckKyNhay.CheckedChanged
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim objPhieu As SX_PhieuDuyetGia
        'Lấy vị trí hàng cần sửa đổi trong grv
        Dim rowCurrent As Integer = grvPhieuDuyetGia.GetFocusedDataSourceRowIndex
        'Lấy thông tin id từ hàng đang focus
        Dim idCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        'Lấy trạng thái ký nháy của phiếu duyệt giá
        Dim stateKyNhay As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdColKyNhay.FieldName)
        'Lấy trạng thái duyệt giá của phiếu duyệt giá
        Dim stateDuyetGia As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdColTrangThaiDuyet.FieldName)

        If idCurrent IsNot Nothing Then
            idPhieu = idCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            objPhieu = (From ds In db.SX_PhieuDuyetGias _
                         Where ds.ID = idPhieu And ds.InUsed = True _
                         Select ds).FirstOrDefault

            If objPhieu IsNot Nothing AndAlso stateDuyetGia = False AndAlso stateKyNhay = False AndAlso MessageBox.Show("Bạn có thực sự muốn ký nháy đối với bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                objPhieu.TrangThaiKyNhay = 1
                db.SubmitChanges()
                LoadData_PhieuDuyetGia()
                grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
            ElseIf objPhieu IsNot Nothing AndAlso stateDuyetGia = False AndAlso stateKyNhay = True AndAlso MessageBox.Show("Bạn có thực sự muốn hủy việc ký nháy đối với bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                objPhieu.TrangThaiKyNhay = 0
                db.SubmitChanges()
                LoadData_PhieuDuyetGia()
                grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
            ElseIf objPhieu IsNot Nothing AndAlso stateDuyetGia = True AndAlso stateKyNhay = True Then
                MessageBox.Show("Không thể hủy ký nháy khi phiếu đã được phê duyệt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                grvPhieuDuyetGia.SetRowCellValue(grvPhieuDuyetGia.GetFocusedDataSourceRowIndex, grdColKyNhay.FieldName, stateKyNhay)
            Else
                MessageBox.Show("Ký nháy thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                grvPhieuDuyetGia.SetRowCellValue(grvPhieuDuyetGia.GetFocusedDataSourceRowIndex, grdColKyNhay.FieldName, stateKyNhay)
            End If
        End If
    End Sub

    ''' <summary>
    ''' CHỨC NĂNG NÀY HIỆN CHỈ CÓ TRÊN MOBILE - Sự kiện giám đốc phê duyệt giá sau khi bên tài chính kế toán đã ký nháy
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub repCheckTrangThaiDuyet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles repCheckTrangThaiDuyet.CheckedChanged
        'Khởi tạo tham số chưa id phiếu duyệt giá
        Dim idPhieu As String
        'Khởi tạo tham số chứa danh sách đơn hàng
        Dim objPhieu As SX_PhieuDuyetGia
        'Lấy vị trí hàng cần sửa đổi trong grv
        Dim rowCurrent As Integer = grvPhieuDuyetGia.GetFocusedDataSourceRowIndex
        'Lấy thông tin id từ hàng đang focus
        Dim idCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
        'Lấy trạng thái ký nháy của phiếu duyệt giá
        Dim stateKyNhay As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdColKyNhay.FieldName)
        'Lấy trạng thái duyệt giá của phiếu duyệt giá
        Dim stateDuyetGia As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdColTrangThaiDuyet.FieldName)

        If idCurrent IsNot Nothing AndAlso stateKyNhay = True Then
            idPhieu = idCurrent.ToString
            'Lấy thông tin danh sách đơn hàng trong phiếu duyệt giá
            objPhieu = (From ds In db.SX_PhieuDuyetGias _
                         Where ds.ID = idPhieu And ds.InUsed = True _
                         Select ds).FirstOrDefault
            If objPhieu IsNot Nothing AndAlso stateDuyetGia = False AndAlso MessageBox.Show("Bạn có thực sự muốn phê duyệt giá đối với bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                objPhieu.TrangThaiDuyet = 2
                db.SubmitChanges()
                LoadData_PhieuDuyetGia()
                grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
            ElseIf objPhieu IsNot Nothing AndAlso stateDuyetGia = True AndAlso MessageBox.Show("Bạn có thực sự muốn hủy duyệt giá đối với bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                objPhieu.TrangThaiDuyet = 1
                db.SubmitChanges()
                LoadData_PhieuDuyetGia()
                grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
            Else
                MessageBox.Show("Duyệt giá thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                grvPhieuDuyetGia.SetRowCellValue(grvPhieuDuyetGia.GetFocusedDataSourceRowIndex, grdColTrangThaiDuyet.FieldName, stateDuyetGia)
            End If
        ElseIf idCurrent IsNot Nothing AndAlso stateKyNhay = False Then
            MessageBox.Show("Phiếu duyệt giá chưa được ký nháy. Vui lòng kiểm tra lại! ", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            grvPhieuDuyetGia.SetRowCellValue(grvPhieuDuyetGia.GetFocusedDataSourceRowIndex, grdColTrangThaiDuyet.FieldName, stateDuyetGia)
        End If
    End Sub
#End Region
#Region "Xóa, In phiếu, Xuất dữ liệu excel"
    ''' <summary>
    ''' Hàm xử lý sự kiện xóa dữ liệu
    ''' Không cho phép xóa các phiếu có trạng thái duyệt là true
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnXoa_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXoa.ItemClick
        Try
            'Khởi tạo tham số chưa id phiếu duyệt giá
            Dim idPhieu As String
            'Lấy vị trí hàng cần sửa đổi trong grv
            Dim rowCurrent As Integer = grvPhieuDuyetGia.GetFocusedDataSourceRowIndex
            'Lấy thông tin id từ hàng đang focus
            Dim objCurrent As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdcolID.FieldName)
            'Lấy trạng thái duyệt của phiếu duyệt giá
            Dim stateDuyetGia As Object = grvPhieuDuyetGia.GetFocusedRowCellValue(grdColTrangThaiDuyet.FieldName)

            If objCurrent IsNot Nothing AndAlso stateDuyetGia = False Then
                idPhieu = objCurrent.ToString
                If MessageBox.Show("Bạn có thực sự muốn xóa bản ghi đã chọn hay không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim objDel As SX_PhieuDuyetGia = (From ds In db.SX_PhieuDuyetGias Where ds.ID = idPhieu And ds.InUsed = True).FirstOrDefault
                    If objDel IsNot Nothing Then
                        objDel.InUsed = False
                        db.SubmitChanges()
                        MessageBox.Show("Xóa phiếu duyệt giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
                        LoadData_PhieuDuyetGia()
                        If grvPhieuDuyetGia.RowCount > 0 Then
                            grvPhieuDuyetGia.FocusedRowHandle = rowCurrent
                        End If
                    End If
                End If
            ElseIf objCurrent IsNot Nothing AndAlso stateDuyetGia = True Then
                MessageBox.Show("Không thể thực hiện xóa đối với phiếu đã được duyệt giá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Vui lòng chọn bản ghi trước khi xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
        End Try
    End Sub

    ''' <summary>
    ''' Xuất dữ liệu phiếu duyệt giá
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnXuatPhieuDuyetGia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXuatPhieuDuyetGia.ItemClick
        Dim path As String = ""
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Chọn vị trí lưu file"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            path = dialog.SelectedPath + "\PhieuDuyetGia.xlsx"
        End If
        grdPhieuDuyetGia.ExportToXlsx(path)
        ' Mở file excel sau khi tải về
        Process.Start(path)
    End Sub

    ''' <summary>
    ''' Xuất dữ liệu phiếu duyệt giá chi tiết
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnXuatPhieuDuyetGiaCT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnXuatPhieuDuyetGiaCT.ItemClick
        Dim path As String = ""
        Dim dialog As New FolderBrowserDialog()
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.SelectedPath = "C:\"
        dialog.Description = "Chọn vị trí lưu file"
        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            path = dialog.SelectedPath + "\PhieuDuyetGia_ChiTiet.xlsx"
        End If
        grdThongTinChiTiet.ExportToXlsx(path)
        ' Mở file excel sau khi tải về
        Process.Start(path)
    End Sub
#End Region
#Region "Phím tắt/ Đóng form"
    ''' <summary>
    ''' Xử lý phím tắt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuDuyetGia_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F2 Then
            btnThemMoi_ItemClick(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnSaoChep_ItemClick(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F4 Then
            btnSuaDoi_ItemClick(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F5 Then
            btnNapLai_ItemClick(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Escape Then
            btnDong_ItemClick(Nothing, Nothing)
        ElseIf e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.Delete Then
            btnXoa_ItemClick(Nothing, Nothing)
        End If
    End Sub

    ''' <summary>
    ''' Đóng form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDong_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDong.ItemClick
        Me.Close()
    End Sub
#End Region
End Class