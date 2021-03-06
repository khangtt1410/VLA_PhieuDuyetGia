Imports PRJ_PhieuDuyetGia_VLA.Publics
Public Class frmPhieuDuyetGia_CapNhat
    'Khởi tạo tham số
    Public phieuDuyetGia As New SX_PhieuDuyetGia()
    Public lstSource As New List(Of clsPhieuDuyetGia_ChiTiet)
    Public lstSource_Del As New List(Of String)
    Public frmAction As Integer
    Private db As New DBContextDataContext()

    ''' <summary>
    ''' Hàm xử lý sự kiện load trang cập nhật
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuDuyetGia_CapNhat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmAction = addAction Then
            txtSoPhieu.Tag = 0
            dteNgayTao.EditValue = Date.Now
            txtNguoiTao.Text = UserName
        ElseIf frmAction = editAction Then
            txtSoPhieu.Tag = phieuDuyetGia.ID
            txtSoPhieu.Text = phieuDuyetGia.SoPhieu
            txtTenPhieu.Text = phieuDuyetGia.TenPhieu
            txtNguoiTao.Text = phieuDuyetGia.CreatedName
            dteNgayTao.EditValue = phieuDuyetGia.CreatedOn
            mmeGhiChu.Text = phieuDuyetGia.GhiChu
        Else
            txtSoPhieu.Tag = 0
            dteNgayTao.EditValue = Date.Now
            txtNguoiTao.Text = UserName
            txtSoPhieu.Text = phieuDuyetGia.SoPhieu
            txtTenPhieu.Text = phieuDuyetGia.TenPhieu
            mmeGhiChu.Text = phieuDuyetGia.GhiChu
        End If
        binSource_CapNhat.DataSource = lstSource
        grdThongTinChiTiet.DataSource = binSource_CapNhat

    End Sub

    ''' <summary>
    ''' Hàm xử lý sự kiện đóng
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDong_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnDong.ItemClick
        CloseForm()
    End Sub

    ''' <summary>
    ''' Hàm xử lý khi hàng có lỗi xảy ra, người dùng k thể chuyển xuống dòng khác
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvThongTinChiTiet_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles grvThongTinChiTiet.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    ''' <summary>
    ''' Hàm xử lý sự kiện kiểm tra tính hợp lệ của hàng
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvThongTinChiTiet_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles grvThongTinChiTiet.ValidateRow
        Dim errMess As String = ""
        Dim valid As Boolean = True

        Dim idDonHangCT As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColIDDonHangCT.FieldName)
        Dim soDonHangCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColSoDonHang.FieldName)
        Dim tenDonViCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColTenDonVi.FieldName)
        Dim tenSanPhamCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColTenSanPham.FieldName)
        Dim soLuongCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColSoLuong.FieldName)
        Dim quyCachCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColQuyCachSanPham.FieldName)
        Dim giayBiaCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColGiayBia.FieldName)
        Dim giayRuotCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColGiayRuot.FieldName)
        Dim laiDinhMucCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColLaiDinhMuc.FieldName)
        Dim donGiaTinhCol As String = grvThongTinChiTiet.GetRowCellValue(e.RowHandle, grdColDonGiaTinh.FieldName)
        If idDonHangCT IsNot Nothing Then
            If (soDonHangCol IsNot Nothing AndAlso soDonHangCol.ToString() = "") Or soDonHangCol Is Nothing Then
                valid = False
                errMess = "Số đơn hàng không được để trống!"
            End If
            If (giayRuotCol IsNot Nothing AndAlso giayRuotCol.ToString() = "") Or giayRuotCol Is Nothing Then
                valid = False
                errMess = "Giấy ruột không được để trống!"
            End If
            If (giayBiaCol IsNot Nothing AndAlso giayBiaCol.ToString() = "") Or giayBiaCol Is Nothing Then
                valid = False
                errMess = "Giấy bìa không được để trống!"
            End If
            If (laiDinhMucCol IsNot Nothing AndAlso laiDinhMucCol.ToString() = "") Or laiDinhMucCol Is Nothing Then
                valid = False
                errMess = "Lãi định mức không được để trống!"
            End If
            If (donGiaTinhCol IsNot Nothing AndAlso donGiaTinhCol.ToString() = "") Or donGiaTinhCol Is Nothing Then
                valid = False
                errMess = "Đơn giá tính không được để trống!"
            End If

            If valid = False Then
                e.Valid = valid
                MessageBox.Show(errMess, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            Dim objDelete = (From ds In lstSource Where ds.IDDonHangChiTiet Is Nothing).FirstOrDefault()
            lstSource.Remove(objDelete)
            binSource_CapNhat.DataSource = lstSource
            grdThongTinChiTiet.DataSource = binSource_CapNhat
            'Refresh binsource
            grdThongTinChiTiet.RefreshDataSource()
            e.Valid = True
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý xóa hàng trong gridview
    ''' Chỉ được phép xóa những hàng chưa được duyệt giá
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grdThongTinChiTiet_ProcessGridKey(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdThongTinChiTiet.ProcessGridKey
        If e.KeyCode = Keys.Delete AndAlso grvThongTinChiTiet.State <> DevExpress.XtraGrid.Views.Grid.GridState.Editing Then
            Dim stateDuyet = grvThongTinChiTiet.GetRowCellValue(grvThongTinChiTiet.FocusedRowHandle, grdColDuyet.FieldName)
            If stateDuyet = False AndAlso MessageBox.Show("Bạn có muốn xóa bản ghi đã chọn hay không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'Kiểm tra xem row này có id hay không, nếu có thì thêm vào lstSource để thực hiện xóa
                Dim idCol = grvThongTinChiTiet.GetRowCellValue(grvThongTinChiTiet.FocusedRowHandle, grdcolIDCT.FieldName)
                If idCol IsNot Nothing Then
                    lstSource_Del.Add(idCol.ToString())
                    grvThongTinChiTiet.DeleteRow(grvThongTinChiTiet.FocusedRowHandle)
                Else
                    MessageBox.Show("Vui lòng chọn sản phẩm trước khi xóa", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Không thể xóa sản phẩm đã được duyệt giá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý nút ghi và đóng
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGhiVaDong_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGhiVaDong.ItemClick
        Dim dictResult As Dictionary(Of String, String) = SaveData()
        Dim status As String = dictResult("Status")
        Dim message As String = dictResult("Message")
        If status = "1" Then
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
            'Vì đây là sự kiện ghi và đóng lên sẽ không hỏi có muốn đóng hay không mà thực hiện đóng luôn nếu lưu thành công
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        ElseIf status = "0" Then
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý lưu dữ liệu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function SaveData() As Dictionary(Of String, String)
        Dim dictResult As New Dictionary(Of String, String)
        grvThongTinChiTiet.FocusedRowHandle = DevExpress.XtraGrid.GridControl.AutoFilterRowHandle
        Dim status As Boolean = CheckValid()
        If frmAction <> editAction AndAlso status = True Then
            Try
                'Thêm thông tin phiếu duyệt giá
                Dim objNew As New SX_PhieuDuyetGia()
                objNew.ID = Guid.NewGuid().ToString()
                objNew.SoPhieu = txtSoPhieu.Text
                objNew.TenPhieu = txtTenPhieu.Text
                objNew.GhiChu = mmeGhiChu.Text
                objNew.CreatedBy = IDNguoiDung
                objNew.CreatedName = UserName
                objNew.CreatedOn = Date.Now
                objNew.InUsed = True
                objNew.TrangThaiDuyet = False
                objNew.TrangThaiKyNhay = False

                db.SX_PhieuDuyetGias.InsertOnSubmit(objNew)
                db.SubmitChanges()

                'Thêm thông tin danh sách đơn hàng trong phiếu duyệt giá
                For Each item As clsPhieuDuyetGia_ChiTiet In lstSource
                    Dim objCTNew As New SX_PhieuDuyetGia_ChiTiet()
                    objCTNew.ID = Guid.NewGuid().ToString()
                    objCTNew.IDPhieuDuyetGia = objNew.ID
                    objCTNew.IDDonHangChiTiet = item.IDDonHangChiTiet
                    objCTNew.SoDonHang = item.SoDonHang
                    objCTNew.TenDonVi = item.TenDonVi
                    objCTNew.TenSanPham = item.TenSanPham
                    objCTNew.SoLuong = item.SoLuong
                    objCTNew.QuyCachSanPham = item.QuyCachSanPham
                    objCTNew.GiayRuot = item.GiayRuot
                    objCTNew.GiayBia = item.GiayBia
                    objCTNew.LaiDinhMuc = item.LaiDinhMuc
                    objCTNew.DonGiaTinh = item.DonGiaTinh
                    objCTNew.CreatedBy = IDNguoiDung
                    objCTNew.CreatedOn = Date.Now
                    objCTNew.CreatedName = UserName
                    objCTNew.TrangThaiIn = item.TrangThaiIn
                    objCTNew.TrangThaiDuyet = False
                    objCTNew.InUsed = True
                    db.SX_PhieuDuyetGia_ChiTiets.InsertOnSubmit(objCTNew)
                Next
                db.SubmitChanges()
                dictResult("Status") = "1"
                dictResult("Message") = "Thêm mới thành công phiếu duyệt giá"
            Catch ex As Exception
                dictResult("Status") = "0"
                dictResult("Message") = ex.Message()
            End Try
        ElseIf frmAction = editAction AndAlso status = True Then
            Try
                Dim objEdit As New SX_PhieuDuyetGia()
                objEdit = (From ds In db.SX_PhieuDuyetGias Where ds.InUsed = True And ds.ID = txtSoPhieu.Tag.ToString()).FirstOrDefault()
                'Sửa thông tin phiếu duyệt giá
                objEdit.SoPhieu = txtSoPhieu.Text
                objEdit.TenPhieu = txtTenPhieu.Text
                objEdit.GhiChu = mmeGhiChu.Text
                objEdit.EditedBy = IDNguoiDung
                objEdit.EditedOn = Date.Now
                objEdit.EditedName = UserName
                db.SubmitChanges()

                'Xóa danh sách đơn hàng
                For Each itemDel As String In lstSource_Del
                    Dim objDel = (From ds In db.SX_PhieuDuyetGia_ChiTiets Where ds.ID = itemDel).FirstOrDefault()
                    objDel.InUsed = False
                    objDel.EditedBy = IDNguoiDung
                    objDel.EditedOn = Date.Now
                    db.SubmitChanges()
                Next
                'Thêm mới và sửa đổi danh sách đơn hàng
                For Each item As clsPhieuDuyetGia_ChiTiet In lstSource
                    If item.ID Is Nothing Then
                        Dim objCTNew As New SX_PhieuDuyetGia_ChiTiet()
                        objCTNew.ID = Guid.NewGuid().ToString()
                        objCTNew.IDPhieuDuyetGia = objEdit.ID
                        objCTNew.IDDonHangChiTiet = item.IDDonHangChiTiet
                        objCTNew.SoDonHang = item.SoDonHang
                        objCTNew.TenDonVi = item.TenDonVi
                        objCTNew.TenSanPham = item.TenSanPham
                        objCTNew.SoLuong = item.SoLuong
                        objCTNew.QuyCachSanPham = item.QuyCachSanPham
                        objCTNew.GiayRuot = item.GiayRuot
                        objCTNew.GiayBia = item.GiayBia
                        objCTNew.LaiDinhMuc = item.LaiDinhMuc
                        objCTNew.DonGiaTinh = item.DonGiaTinh
                        objCTNew.CreatedBy = IDNguoiDung
                        objCTNew.CreatedOn = Date.Now
                        objCTNew.CreatedName = UserName
                        objCTNew.TrangThaiDuyet = False
                        objCTNew.TrangThaiIn = item.TrangThaiIn
                        objCTNew.InUsed = True
                        db.SX_PhieuDuyetGia_ChiTiets.InsertOnSubmit(objCTNew)
                    Else
                        Dim objEditCT As New SX_PhieuDuyetGia_ChiTiet()
                        objEditCT = (From ds In db.SX_PhieuDuyetGia_ChiTiets Where ds.ID = item.ID).FirstOrDefault()
                        objEditCT.SoDonHang = item.SoDonHang
                        objEditCT.IDDonHangChiTiet = item.IDDonHangChiTiet
                        objEditCT.TenDonVi = item.TenDonVi
                        objEditCT.TenSanPham = item.TenSanPham
                        objEditCT.SoLuong = item.SoLuong
                        objEditCT.QuyCachSanPham = item.QuyCachSanPham
                        objEditCT.GiayRuot = item.GiayRuot
                        objEditCT.GiayBia = item.GiayBia
                        objEditCT.LaiDinhMuc = item.LaiDinhMuc
                        objEditCT.DonGiaTinh = item.DonGiaTinh
                        objEditCT.TrangThaiIn = item.TrangThaiIn
                        objEditCT.EditedBy = IDNguoiDung
                        objEditCT.EditedName = UserName
                        objEdit.EditedOn = Date.Now
                    End If
                    db.SubmitChanges()
                Next
                db.SubmitChanges()
                dictResult("Status") = "1"
                dictResult("Message") = "Sửa đổi thành công phiếu duyệt giá"
            Catch ex As Exception
                dictResult("Status") = "0"
                dictResult("Message") = ex.Message()
            End Try
        Else
            dictResult("Status") = "2"
            dictResult("Message") = ""
        End If
        Return dictResult
    End Function

    ''' <summary>
    ''' Hàm xử lý đóng form
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CloseForm()
        Dim dlRes = MessageBox.Show("Bạn có muốn lưu dữ liệu trước khi thoát khỏi chức năng này không?", "Xác nhận", MessageBoxButtons.YesNo)
        If dlRes = Windows.Forms.DialogResult.Yes Then
            Dim dictResult As Dictionary(Of String, String) = SaveData()
            Dim status As String = dictResult("Status")
            Dim message As String = dictResult("Message")
            If status = "1" Then
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
                Me.DialogResult = Windows.Forms.DialogResult.Yes
                Me.Close()
            ElseIf status = "0" Then
                MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý sự kiện nút ghi và tiếp tục
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnGhiVaIn_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnGhiVaTiepTuc.ItemClick
        Dim dictResult As Dictionary(Of String, String) = SaveData()
        Dim status As String = dictResult("Status")
        Dim message As String = dictResult("Message")
        If status = "1" Then
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None)
            'Reset thông tin cũ
            txtSoPhieu.Text = ""
            dteNgayTao.EditValue = Date.Now
            txtTenPhieu.Text = ""
            mmeGhiChu.Text = ""
            lstSource.Clear()
        ElseIf status = "0" Then
            MessageBox.Show(message, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý sự kiện của các phím tắt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub frmPhieuDuyetGia_CapNhat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            CloseForm()
        ElseIf e.KeyCode = Keys.F7 Then
            btnGhiVaDong_ItemClick(Nothing, Nothing)
        ElseIf e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.P Then
            btnGhiVaIn_ItemClick(Nothing, Nothing)
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý kiểm tra tính hợp lệ của trường số phiếu
    ''' Không cho để trống và sự tồn tại của số phiếu trong db, 
    ''' độ dài đã cài đặt ở properties nên k cần set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtSoPhieu_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoPhieu.Leave
        Dim objCheck As New SX_PhieuDuyetGia()
        objCheck = (From ds In db.SX_PhieuDuyetGias Where ds.InUsed = True And ds.SoPhieu = txtSoPhieu.Text And ds.ID <> txtSoPhieu.Tag.ToString()).FirstOrDefault()
        If objCheck IsNot Nothing Then
            Dim mess As String = String.Format("Số phiếu {0} đã tồn tại trong hệ thống. Vui lòng kiểm tra lại!", txtSoPhieu.Text)
            MessageBox.Show(mess, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSoPhieu.Focus()
        ElseIf txtSoPhieu.Text = "" Then
            MessageBox.Show("Số phiếu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSoPhieu.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý ngoại lệ cho tên phiếu
    ''' Không được để trống, độ dài đã cài đặt ở properties nên k cần set
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtTenPhieu_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTenPhieu.Leave
        If txtTenPhieu.Text = "" Then
            MessageBox.Show("Tên phiếu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTenPhieu.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý ngoại lệ cho ngày lập phiếu
    ''' Không được để trống
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dteNgayTao_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dteNgayTao.Leave
        If dteNgayTao.EditValue Is Nothing Then
            MessageBox.Show("Ngày lập phiếu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dteNgayTao.Focus()
        End If
    End Sub

    ''' <summary>
    ''' Hàm xử lý validate trước khi lưu
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function CheckValid() As Boolean
        Dim objCheck As New SX_PhieuDuyetGia()
        objCheck = (From ds In db.SX_PhieuDuyetGias Where ds.InUsed = True And ds.SoPhieu = txtSoPhieu.Text And ds.ID <> txtSoPhieu.Tag.ToString().ToString()).FirstOrDefault()
        If objCheck IsNot Nothing Then
            Dim mess As String = String.Format("Số phiếu {0} đã tồn tại trong hệ thống. Vui lòng kiểm tra lại!", txtSoPhieu.Text)
            MessageBox.Show(mess, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSoPhieu.Focus()
            Return False
        End If
        If txtSoPhieu.Text = "" Then
            MessageBox.Show("Số phiếu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSoPhieu.Focus()
            Return False
        End If
        If txtTenPhieu.Text = "" Then
            MessageBox.Show("Tên phiếu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtTenPhieu.Focus()
            Return False
        End If
        If dteNgayTao.EditValue Is Nothing Then
            MessageBox.Show("Ngày lập phiếu không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dteNgayTao.Focus()
            Return False
        End If
        Return True
    End Function

    ''' <summary>
    ''' Hàm xử lý chọn sản phẩm từ đơn đặt hàng
    ''' Chỉ cho phép chọn từng sản phẩm một
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rptxtSoDonHang_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptxtSoDonHang.Leave
        Dim soDonHang As String = grvThongTinChiTiet.GetFocusedRowCellValue(grdColSoDonHang.FieldName)
        Dim IDDonHangCT As String = grvThongTinChiTiet.GetFocusedRowCellValue(grdColIDDonHangCT.FieldName)
        Dim objChoose As New clsPhieuDuyetGia_ChiTiet()
        If soDonHang Is Nothing Or (soDonHang IsNot Nothing AndAlso soDonHang = "*") Then
            'Gọi đến form chọn đơn hàng
            Dim frmDonHang As New frmChooseDonHang_PhieuDuyetGia()
            frmDonHang.lstIDChecked = (From ds In lstSource Select ds.IDDonHangChiTiet).ToList()
            Dim dlgResult As DialogResult = frmDonHang.ShowDialog()
            If dlgResult = Windows.Forms.DialogResult.Yes Then
                objChoose = frmDonHang.objChoose
            End If
        Else
            Dim objDonHang As SX_DonDatHang = (From ds In db.SX_DonDatHangs Where ds.SoDonHang = soDonHang And ds.InUsed = True).FirstOrDefault()
            If objDonHang IsNot Nothing Then
                'Lấy thông tin danh sách sản phẩm của đơn hàng theo mã đã nhập
                Dim lstSanPham As New List(Of clsPhieuDuyetGia_ChiTiet)
                lstSanPham = (From dhct In db.SX_DonDatHang_ChiTiets _
                          Join dh In db.SX_DonDatHangs On dh.ID Equals dhct.IDDonDatHang _
                          Group Join y In db.SX_PhieuTinhGias On y.IDDonDatHangChiTiet Equals dhct.ID Into Group _
                          From ptg In Group.DefaultIfEmpty() _
                          Where dhct.InUsed = True And dh.InUsed = True And ptg.InUsed = True _
                          And (From ds In lstSource Select ds.IDDonHangChiTiet).ToList().Contains(dhct.ID) = False _
                          And (From pgdCT In db.SX_PhieuDuyetGia_ChiTiets Where pgdCT.IDDonHangChiTiet = dhct.ID And (pgdCT.TrangThaiDuyet = True AndAlso pgdCT.TrangThaiIn = True) Select pgdCT).Count = 0 _
                          Select New clsPhieuDuyetGia_ChiTiet With { _
                          .IDDonHangChiTiet = dhct.ID, _
                          .SoDonHang = dh.SoDonHang, _
                          .TenDonVi = dh.TenKH, _
                          .TenSanPham = dhct.TenSanPham, _
                          .SoLuong = dhct.SoLuong, _
                          .QuyCachSanPham = dhct.TenQuyCach, _
                          .GiayRuot = ptg.DonGiaRuot, _
                          .GiayBia = ptg.DonGiaGiayBia, _
                          .LaiDinhMuc = ptg.TienLaiDinhMuc, _
                          .DonGiaTinh = ptg.DonGiaDaCoVAT, _
                          .IsChoose = False}).ToList()
                If lstSanPham.Count > 1 Then
                    'Gọi đến form chọn đơn hàng
                    Dim frmDonHang As New frmChooseDonHang_PhieuDuyetGia()
                    frmDonHang.lstIDChecked = (From ds In lstSource Select ds.IDDonHangChiTiet).ToList()
                    Dim dlgResult As DialogResult = frmDonHang.ShowDialog()
                    If dlgResult = Windows.Forms.DialogResult.Yes Then
                        objChoose = frmDonHang.objChoose
                    End If
                Else
                    objChoose = lstSanPham.FirstOrDefault()
                End If
            Else
                'Gọi đến form chọn đơn hàng
                Dim frmDonHang As New frmChooseDonHang_PhieuDuyetGia()
                frmDonHang.lstIDChecked = (From ds In lstSource Select ds.IDDonHangChiTiet).ToList()
                frmDonHang.strSearch = soDonHang
                Dim dlgResult As DialogResult = frmDonHang.ShowDialog()
                If dlgResult = Windows.Forms.DialogResult.Yes Then
                    objChoose = frmDonHang.objChoose
                End If
            End If

        End If
        If objChoose IsNot Nothing AndAlso objChoose.IDDonHangChiTiet IsNot Nothing Then
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColIDDonHangCT.FieldName, objChoose.IDDonHangChiTiet)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColSoDonHang.FieldName, objChoose.SoDonHang)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColTenDonVi.FieldName, objChoose.TenDonVi)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColTenSanPham.FieldName, objChoose.TenSanPham)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColSoLuong.FieldName, objChoose.SoLuong)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColQuyCachSanPham.FieldName, objChoose.QuyCachSanPham)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColGiayBia.FieldName, objChoose.GiayBia)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColGiayRuot.FieldName, objChoose.GiayRuot)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColLaiDinhMuc.FieldName, objChoose.LaiDinhMuc)
            grvThongTinChiTiet.SetFocusedRowCellValue(grdColDonGiaTinh.FieldName, objChoose.DonGiaTinh)

            binSource_CapNhat.DataSource = lstSource
            grdThongTinChiTiet.DataSource = binSource_CapNhat
            'Refresh binsource
            grdThongTinChiTiet.RefreshDataSource()
        End If
    End Sub

    ''' <summary>
    ''' Hàm kiểm tra trạng thái duyệt trước khi sửa đổi thông tin. Nếu đã duyệt rồi thì không cho sửa
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub grvThongTinChiTiet_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles grvThongTinChiTiet.ShowingEditor
        Dim stateDuyet As Boolean = grvThongTinChiTiet.GetFocusedRowCellValue(grdColDuyet.FieldName)
        Dim columnName As String = grvThongTinChiTiet.FocusedColumn().FieldName
        If stateDuyet = True AndAlso columnName <> grdColKhongIn.FieldName Then
            e.Cancel = True
        End If
    End Sub
End Class