<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuDuyetGia
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.btnThemMoi = New DevExpress.XtraBars.BarButtonItem
        Me.btnSaoChep = New DevExpress.XtraBars.BarButtonItem
        Me.btnSuaDoi = New DevExpress.XtraBars.BarButtonItem
        Me.btnXoa = New DevExpress.XtraBars.BarButtonItem
        Me.btnIn = New DevExpress.XtraBars.BarButtonItem
        Me.btnXuatDuLieu = New DevExpress.XtraBars.BarButtonItem
        Me.btnDong = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.grpPhieuDuyetGia = New DevExpress.XtraEditors.GroupControl
        Me.grdPhieuDuyetGia = New DevExpress.XtraGrid.GridControl
        Me.grvPhieuDuyetGia = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdColSoPhieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColTenPhieu = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColNgayTao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColNguoiTao = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColKyNhay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCheckKyNhay = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.grdColTrangThaiDuyet = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCheckTrangThaiDuyet = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.grpPhieuDuyetGia_ChiTiet = New DevExpress.XtraEditors.GroupControl
        Me.grdThongTinChiTiet = New DevExpress.XtraGrid.GridControl
        Me.grvThongTinChiTiet = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.grdColSoDonHang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColTenDonVi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColTenSanPham = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColSoLuong = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColQuyCachSanPham = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColGiayRuot = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColGiayBia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColLaiDinhMuc = New DevExpress.XtraGrid.Columns.GridColumn
        Me.grdColDonGiaTinh = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.binSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPhieuDuyetGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPhieuDuyetGia.SuspendLayout()
        CType(Me.grdPhieuDuyetGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvPhieuDuyetGia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCheckKyNhay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCheckTrangThaiDuyet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpPhieuDuyetGia_ChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPhieuDuyetGia_ChiTiet.SuspendLayout()
        CType(Me.grdThongTinChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvThongTinChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.binSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnThemMoi, Me.btnSaoChep, Me.btnSuaDoi, Me.btnXoa, Me.btnIn, Me.btnXuatDuLieu, Me.btnDong})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 8
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnThemMoi), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSaoChep), New DevExpress.XtraBars.LinkPersistInfo(Me.btnSuaDoi), New DevExpress.XtraBars.LinkPersistInfo(Me.btnXoa), New DevExpress.XtraBars.LinkPersistInfo(Me.btnIn), New DevExpress.XtraBars.LinkPersistInfo(Me.btnXuatDuLieu), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDong)})
        Me.Bar2.OptionsBar.AllowQuickCustomization = False
        Me.Bar2.OptionsBar.DrawDragBorder = False
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'btnThemMoi
        '
        Me.btnThemMoi.Caption = "Thêm mới"
        Me.btnThemMoi.Id = 0
        Me.btnThemMoi.Name = "btnThemMoi"
        '
        'btnSaoChep
        '
        Me.btnSaoChep.Caption = "Sao chép"
        Me.btnSaoChep.Id = 1
        Me.btnSaoChep.Name = "btnSaoChep"
        '
        'btnSuaDoi
        '
        Me.btnSuaDoi.Caption = "Sửa đổi"
        Me.btnSuaDoi.Id = 2
        Me.btnSuaDoi.Name = "btnSuaDoi"
        '
        'btnXoa
        '
        Me.btnXoa.Caption = "Xóa"
        Me.btnXoa.Id = 4
        Me.btnXoa.Name = "btnXoa"
        '
        'btnIn
        '
        Me.btnIn.Caption = "In phiếu duyệt giá"
        Me.btnIn.Id = 5
        Me.btnIn.Name = "btnIn"
        '
        'btnXuatDuLieu
        '
        Me.btnXuatDuLieu.Caption = "Xuất dữ liệu"
        Me.btnXuatDuLieu.Id = 6
        Me.btnXuatDuLieu.Name = "btnXuatDuLieu"
        '
        'btnDong
        '
        Me.btnDong.Caption = "Đóng"
        Me.btnDong.Id = 7
        Me.btnDong.Name = "btnDong"
        '
        'grpPhieuDuyetGia
        '
        Me.grpPhieuDuyetGia.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPhieuDuyetGia.AppearanceCaption.Options.UseFont = True
        Me.grpPhieuDuyetGia.Controls.Add(Me.grdPhieuDuyetGia)
        Me.grpPhieuDuyetGia.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpPhieuDuyetGia.Location = New System.Drawing.Point(0, 24)
        Me.grpPhieuDuyetGia.Name = "grpPhieuDuyetGia"
        Me.grpPhieuDuyetGia.Size = New System.Drawing.Size(979, 262)
        Me.grpPhieuDuyetGia.TabIndex = 4
        Me.grpPhieuDuyetGia.Text = "Phím tắt: [F2: Thêm mới][F3: Sao chép][F4: Sửa đổi][Ctrl_Delete: Xóa][F5: Nạp lại" & _
            "][ESC: Đóng]"
        '
        'grdPhieuDuyetGia
        '
        Me.grdPhieuDuyetGia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdPhieuDuyetGia.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdPhieuDuyetGia.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdPhieuDuyetGia.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdPhieuDuyetGia.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdPhieuDuyetGia.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdPhieuDuyetGia.EmbeddedNavigator.TextStringFormat = "Bản ghi {0} của {1}"
        Me.grdPhieuDuyetGia.Location = New System.Drawing.Point(2, 22)
        Me.grdPhieuDuyetGia.MainView = Me.grvPhieuDuyetGia
        Me.grdPhieuDuyetGia.MenuManager = Me.BarManager1
        Me.grdPhieuDuyetGia.Name = "grdPhieuDuyetGia"
        Me.grdPhieuDuyetGia.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCheckKyNhay, Me.repCheckTrangThaiDuyet})
        Me.grdPhieuDuyetGia.Size = New System.Drawing.Size(975, 238)
        Me.grdPhieuDuyetGia.TabIndex = 0
        Me.grdPhieuDuyetGia.UseEmbeddedNavigator = True
        Me.grdPhieuDuyetGia.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvPhieuDuyetGia})
        '
        'grvPhieuDuyetGia
        '
        Me.grvPhieuDuyetGia.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdColSoPhieu, Me.grdColTenPhieu, Me.grdColNgayTao, Me.grdColNguoiTao, Me.grdColKyNhay, Me.grdColTrangThaiDuyet})
        Me.grvPhieuDuyetGia.GridControl = Me.grdPhieuDuyetGia
        Me.grvPhieuDuyetGia.Name = "grvPhieuDuyetGia"
        Me.grvPhieuDuyetGia.OptionsBehavior.Editable = False
        Me.grvPhieuDuyetGia.OptionsNavigation.AutoFocusNewRow = True
        Me.grvPhieuDuyetGia.OptionsView.ShowAutoFilterRow = True
        Me.grvPhieuDuyetGia.OptionsView.ShowGroupPanel = False
        '
        'grdColSoPhieu
        '
        Me.grdColSoPhieu.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColSoPhieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColSoPhieu.Caption = "Số phiếu"
        Me.grdColSoPhieu.FieldName = "SoPhieu"
        Me.grdColSoPhieu.Name = "grdColSoPhieu"
        Me.grdColSoPhieu.OptionsColumn.AllowEdit = False
        Me.grdColSoPhieu.OptionsColumn.ReadOnly = True
        Me.grdColSoPhieu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColSoPhieu.Visible = True
        Me.grdColSoPhieu.VisibleIndex = 0
        '
        'grdColTenPhieu
        '
        Me.grdColTenPhieu.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColTenPhieu.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColTenPhieu.Caption = "Tên phiếu"
        Me.grdColTenPhieu.FieldName = "TenPhieu"
        Me.grdColTenPhieu.Name = "grdColTenPhieu"
        Me.grdColTenPhieu.OptionsColumn.AllowEdit = False
        Me.grdColTenPhieu.OptionsColumn.ReadOnly = True
        Me.grdColTenPhieu.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColTenPhieu.Visible = True
        Me.grdColTenPhieu.VisibleIndex = 1
        '
        'grdColNgayTao
        '
        Me.grdColNgayTao.AppearanceCell.Options.UseTextOptions = True
        Me.grdColNgayTao.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColNgayTao.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColNgayTao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColNgayTao.Caption = "Ngày tạo"
        Me.grdColNgayTao.FieldName = "CreatedOn"
        Me.grdColNgayTao.Name = "grdColNgayTao"
        Me.grdColNgayTao.OptionsColumn.AllowEdit = False
        Me.grdColNgayTao.OptionsColumn.ReadOnly = True
        Me.grdColNgayTao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColNgayTao.Visible = True
        Me.grdColNgayTao.VisibleIndex = 2
        '
        'grdColNguoiTao
        '
        Me.grdColNguoiTao.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColNguoiTao.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColNguoiTao.Caption = "Người tạo"
        Me.grdColNguoiTao.Name = "grdColNguoiTao"
        Me.grdColNguoiTao.OptionsColumn.AllowEdit = False
        Me.grdColNguoiTao.OptionsColumn.ReadOnly = True
        Me.grdColNguoiTao.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColNguoiTao.Visible = True
        Me.grdColNguoiTao.VisibleIndex = 3
        '
        'grdColKyNhay
        '
        Me.grdColKyNhay.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColKyNhay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColKyNhay.Caption = "Ký nháy"
        Me.grdColKyNhay.ColumnEdit = Me.repCheckKyNhay
        Me.grdColKyNhay.FieldName = "grdColKyNhay"
        Me.grdColKyNhay.Name = "grdColKyNhay"
        Me.grdColKyNhay.OptionsColumn.AllowEdit = False
        Me.grdColKyNhay.OptionsColumn.ReadOnly = True
        Me.grdColKyNhay.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColKyNhay.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.grdColKyNhay.Visible = True
        Me.grdColKyNhay.VisibleIndex = 4
        '
        'repCheckKyNhay
        '
        Me.repCheckKyNhay.AutoHeight = False
        Me.repCheckKyNhay.Name = "repCheckKyNhay"
        '
        'grdColTrangThaiDuyet
        '
        Me.grdColTrangThaiDuyet.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColTrangThaiDuyet.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColTrangThaiDuyet.Caption = "Trạng thái duyệt"
        Me.grdColTrangThaiDuyet.ColumnEdit = Me.repCheckTrangThaiDuyet
        Me.grdColTrangThaiDuyet.FieldName = "grdColTrangThaiDuyet"
        Me.grdColTrangThaiDuyet.Name = "grdColTrangThaiDuyet"
        Me.grdColTrangThaiDuyet.OptionsColumn.AllowEdit = False
        Me.grdColTrangThaiDuyet.OptionsColumn.ReadOnly = True
        Me.grdColTrangThaiDuyet.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColTrangThaiDuyet.UnboundType = DevExpress.Data.UnboundColumnType.[Boolean]
        Me.grdColTrangThaiDuyet.Visible = True
        Me.grdColTrangThaiDuyet.VisibleIndex = 5
        '
        'repCheckTrangThaiDuyet
        '
        Me.repCheckTrangThaiDuyet.AutoHeight = False
        Me.repCheckTrangThaiDuyet.Name = "repCheckTrangThaiDuyet"
        '
        'grpPhieuDuyetGia_ChiTiet
        '
        Me.grpPhieuDuyetGia_ChiTiet.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPhieuDuyetGia_ChiTiet.AppearanceCaption.Options.UseFont = True
        Me.grpPhieuDuyetGia_ChiTiet.Controls.Add(Me.grdThongTinChiTiet)
        Me.grpPhieuDuyetGia_ChiTiet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpPhieuDuyetGia_ChiTiet.Location = New System.Drawing.Point(0, 286)
        Me.grpPhieuDuyetGia_ChiTiet.Name = "grpPhieuDuyetGia_ChiTiet"
        Me.grpPhieuDuyetGia_ChiTiet.Size = New System.Drawing.Size(979, 298)
        Me.grpPhieuDuyetGia_ChiTiet.TabIndex = 5
        Me.grpPhieuDuyetGia_ChiTiet.Text = "Thông tin chi tiết"
        '
        'grdThongTinChiTiet
        '
        Me.grdThongTinChiTiet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdThongTinChiTiet.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.grdThongTinChiTiet.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.grdThongTinChiTiet.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.grdThongTinChiTiet.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.grdThongTinChiTiet.EmbeddedNavigator.Buttons.Remove.Visible = False
        Me.grdThongTinChiTiet.EmbeddedNavigator.TextStringFormat = "Bản ghi {0} của {1}"
        Me.grdThongTinChiTiet.Location = New System.Drawing.Point(2, 22)
        Me.grdThongTinChiTiet.MainView = Me.grvThongTinChiTiet
        Me.grdThongTinChiTiet.MenuManager = Me.BarManager1
        Me.grdThongTinChiTiet.Name = "grdThongTinChiTiet"
        Me.grdThongTinChiTiet.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.grdThongTinChiTiet.Size = New System.Drawing.Size(975, 274)
        Me.grdThongTinChiTiet.TabIndex = 1
        Me.grdThongTinChiTiet.UseEmbeddedNavigator = True
        Me.grdThongTinChiTiet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvThongTinChiTiet})
        '
        'grvThongTinChiTiet
        '
        Me.grvThongTinChiTiet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdColSoDonHang, Me.grdColTenDonVi, Me.grdColTenSanPham, Me.grdColSoLuong, Me.grdColQuyCachSanPham, Me.grdColGiayRuot, Me.grdColGiayBia, Me.grdColLaiDinhMuc, Me.grdColDonGiaTinh})
        Me.grvThongTinChiTiet.GridControl = Me.grdThongTinChiTiet
        Me.grvThongTinChiTiet.Name = "grvThongTinChiTiet"
        Me.grvThongTinChiTiet.OptionsBehavior.Editable = False
        Me.grvThongTinChiTiet.OptionsNavigation.AutoFocusNewRow = True
        Me.grvThongTinChiTiet.OptionsView.ShowAutoFilterRow = True
        Me.grvThongTinChiTiet.OptionsView.ShowGroupPanel = False
        '
        'grdColSoDonHang
        '
        Me.grdColSoDonHang.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColSoDonHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColSoDonHang.Caption = "Số đơn hàng"
        Me.grdColSoDonHang.Name = "grdColSoDonHang"
        Me.grdColSoDonHang.OptionsColumn.AllowEdit = False
        Me.grdColSoDonHang.OptionsColumn.ReadOnly = True
        Me.grdColSoDonHang.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColSoDonHang.Visible = True
        Me.grdColSoDonHang.VisibleIndex = 0
        '
        'grdColTenDonVi
        '
        Me.grdColTenDonVi.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColTenDonVi.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColTenDonVi.Caption = "Tên đơn vị"
        Me.grdColTenDonVi.Name = "grdColTenDonVi"
        Me.grdColTenDonVi.OptionsColumn.AllowEdit = False
        Me.grdColTenDonVi.OptionsColumn.ReadOnly = True
        Me.grdColTenDonVi.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColTenDonVi.Visible = True
        Me.grdColTenDonVi.VisibleIndex = 1
        '
        'grdColTenSanPham
        '
        Me.grdColTenSanPham.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColTenSanPham.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColTenSanPham.Caption = "Tên sản phẩm"
        Me.grdColTenSanPham.Name = "grdColTenSanPham"
        Me.grdColTenSanPham.OptionsColumn.AllowEdit = False
        Me.grdColTenSanPham.OptionsColumn.ReadOnly = True
        Me.grdColTenSanPham.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColTenSanPham.Visible = True
        Me.grdColTenSanPham.VisibleIndex = 2
        '
        'grdColSoLuong
        '
        Me.grdColSoLuong.AppearanceCell.Options.UseTextOptions = True
        Me.grdColSoLuong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColSoLuong.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColSoLuong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColSoLuong.Caption = "Số lượng"
        Me.grdColSoLuong.Name = "grdColSoLuong"
        Me.grdColSoLuong.OptionsColumn.AllowEdit = False
        Me.grdColSoLuong.OptionsColumn.ReadOnly = True
        Me.grdColSoLuong.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.grdColSoLuong.Visible = True
        Me.grdColSoLuong.VisibleIndex = 3
        '
        'grdColQuyCachSanPham
        '
        Me.grdColQuyCachSanPham.Caption = "Quy cách sản phẩm"
        Me.grdColQuyCachSanPham.Name = "grdColQuyCachSanPham"
        Me.grdColQuyCachSanPham.Visible = True
        Me.grdColQuyCachSanPham.VisibleIndex = 4
        '
        'grdColGiayRuot
        '
        Me.grdColGiayRuot.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColGiayRuot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColGiayRuot.Caption = "Giấy ruột"
        Me.grdColGiayRuot.Name = "grdColGiayRuot"
        Me.grdColGiayRuot.Visible = True
        Me.grdColGiayRuot.VisibleIndex = 5
        '
        'grdColGiayBia
        '
        Me.grdColGiayBia.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColGiayBia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColGiayBia.Caption = "Giấy bìa"
        Me.grdColGiayBia.Name = "grdColGiayBia"
        Me.grdColGiayBia.Visible = True
        Me.grdColGiayBia.VisibleIndex = 6
        '
        'grdColLaiDinhMuc
        '
        Me.grdColLaiDinhMuc.AppearanceCell.Options.UseTextOptions = True
        Me.grdColLaiDinhMuc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.grdColLaiDinhMuc.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColLaiDinhMuc.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColLaiDinhMuc.Caption = "Lãi định mức"
        Me.grdColLaiDinhMuc.Name = "grdColLaiDinhMuc"
        Me.grdColLaiDinhMuc.Visible = True
        Me.grdColLaiDinhMuc.VisibleIndex = 7
        '
        'grdColDonGiaTinh
        '
        Me.grdColDonGiaTinh.AppearanceCell.Options.UseTextOptions = True
        Me.grdColDonGiaTinh.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.grdColDonGiaTinh.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColDonGiaTinh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColDonGiaTinh.Caption = "Đơn giá tính"
        Me.grdColDonGiaTinh.Name = "grdColDonGiaTinh"
        Me.grdColDonGiaTinh.Visible = True
        Me.grdColDonGiaTinh.VisibleIndex = 8
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        '
        'frmPhieuDuyetGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 584)
        Me.Controls.Add(Me.grpPhieuDuyetGia_ChiTiet)
        Me.Controls.Add(Me.grpPhieuDuyetGia)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPhieuDuyetGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SX. Phiếu duyệt giá"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPhieuDuyetGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPhieuDuyetGia.ResumeLayout(False)
        CType(Me.grdPhieuDuyetGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvPhieuDuyetGia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCheckKyNhay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCheckTrangThaiDuyet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpPhieuDuyetGia_ChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPhieuDuyetGia_ChiTiet.ResumeLayout(False)
        CType(Me.grdThongTinChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvThongTinChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.binSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnThemMoi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSaoChep As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnSuaDoi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXoa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnIn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnXuatDuLieu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents grpPhieuDuyetGia_ChiTiet As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grpPhieuDuyetGia As DevExpress.XtraEditors.GroupControl
    Friend WithEvents grdPhieuDuyetGia As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvPhieuDuyetGia As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdColSoPhieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColTenPhieu As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColNgayTao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColNguoiTao As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColKyNhay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCheckKyNhay As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents grdColTrangThaiDuyet As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCheckTrangThaiDuyet As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents grdThongTinChiTiet As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvThongTinChiTiet As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grdColSoDonHang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColTenDonVi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColTenSanPham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColSoLuong As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColQuyCachSanPham As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColGiayRuot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColGiayBia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColLaiDinhMuc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grdColDonGiaTinh As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents binSource As System.Windows.Forms.BindingSource
End Class
