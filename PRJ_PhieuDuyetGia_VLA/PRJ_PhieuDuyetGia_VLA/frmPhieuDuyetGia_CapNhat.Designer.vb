<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPhieuDuyetGia_CapNhat
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
        Me.Bar1 = New DevExpress.XtraBars.Bar
        Me.btnGhiVaDong = New DevExpress.XtraBars.BarButtonItem
        Me.btnGhiVaIn = New DevExpress.XtraBars.BarButtonItem
        Me.btnDong = New DevExpress.XtraBars.BarButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.panPhieuDuyetGia = New DevExpress.XtraEditors.PanelControl
        Me.txtNguoiTao = New DevExpress.XtraEditors.TextEdit
        Me.lbNguoiTao = New DevExpress.XtraEditors.LabelControl
        Me.mmeGhiChu = New DevExpress.XtraEditors.MemoEdit
        Me.txtTenPhieu = New DevExpress.XtraEditors.TextEdit
        Me.txtNgayTao = New DevExpress.XtraEditors.TextEdit
        Me.txtSoPhieu = New DevExpress.XtraEditors.TextEdit
        Me.lbGhiChu = New DevExpress.XtraEditors.LabelControl
        Me.lbNgayTao = New DevExpress.XtraEditors.LabelControl
        Me.lbTenPhieu = New DevExpress.XtraEditors.LabelControl
        Me.lbSoPhieu = New DevExpress.XtraEditors.LabelControl
        Me.grpDanhSachDonHang = New DevExpress.XtraEditors.GroupControl
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
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panPhieuDuyetGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panPhieuDuyetGia.SuspendLayout()
        CType(Me.txtNguoiTao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mmeGhiChu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTenPhieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNgayTao.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSoPhieu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grpDanhSachDonHang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpDanhSachDonHang.SuspendLayout()
        CType(Me.grdThongTinChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvThongTinChiTiet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnGhiVaDong, Me.btnGhiVaIn, Me.btnDong})
        Me.BarManager1.MaxItemId = 3
        '
        'Bar1
        '
        Me.Bar1.BarName = "Tools"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnGhiVaDong), New DevExpress.XtraBars.LinkPersistInfo(Me.btnGhiVaIn), New DevExpress.XtraBars.LinkPersistInfo(Me.btnDong)})
        Me.Bar1.OptionsBar.AllowQuickCustomization = False
        Me.Bar1.OptionsBar.DrawDragBorder = False
        Me.Bar1.OptionsBar.UseWholeRow = True
        Me.Bar1.Text = "Tools"
        '
        'btnGhiVaDong
        '
        Me.btnGhiVaDong.Caption = "Ghi và đóng"
        Me.btnGhiVaDong.Id = 0
        Me.btnGhiVaDong.Name = "btnGhiVaDong"
        '
        'btnGhiVaIn
        '
        Me.btnGhiVaIn.Caption = "Ghi và in"
        Me.btnGhiVaIn.Id = 1
        Me.btnGhiVaIn.Name = "btnGhiVaIn"
        '
        'btnDong
        '
        Me.btnDong.Caption = "Đóng"
        Me.btnDong.Id = 2
        Me.btnDong.Name = "btnDong"
        '
        'panPhieuDuyetGia
        '
        Me.panPhieuDuyetGia.Controls.Add(Me.txtNguoiTao)
        Me.panPhieuDuyetGia.Controls.Add(Me.lbNguoiTao)
        Me.panPhieuDuyetGia.Controls.Add(Me.mmeGhiChu)
        Me.panPhieuDuyetGia.Controls.Add(Me.txtTenPhieu)
        Me.panPhieuDuyetGia.Controls.Add(Me.txtNgayTao)
        Me.panPhieuDuyetGia.Controls.Add(Me.txtSoPhieu)
        Me.panPhieuDuyetGia.Controls.Add(Me.lbGhiChu)
        Me.panPhieuDuyetGia.Controls.Add(Me.lbNgayTao)
        Me.panPhieuDuyetGia.Controls.Add(Me.lbTenPhieu)
        Me.panPhieuDuyetGia.Controls.Add(Me.lbSoPhieu)
        Me.panPhieuDuyetGia.Dock = System.Windows.Forms.DockStyle.Top
        Me.panPhieuDuyetGia.Location = New System.Drawing.Point(0, 24)
        Me.panPhieuDuyetGia.Name = "panPhieuDuyetGia"
        Me.panPhieuDuyetGia.Size = New System.Drawing.Size(969, 137)
        Me.panPhieuDuyetGia.TabIndex = 0
        '
        'txtNguoiTao
        '
        Me.txtNguoiTao.Location = New System.Drawing.Point(499, 12)
        Me.txtNguoiTao.MenuManager = Me.BarManager1
        Me.txtNguoiTao.Name = "txtNguoiTao"
        Me.txtNguoiTao.Properties.ReadOnly = True
        Me.txtNguoiTao.Size = New System.Drawing.Size(210, 20)
        Me.txtNguoiTao.TabIndex = 5
        '
        'lbNguoiTao
        '
        Me.lbNguoiTao.Location = New System.Drawing.Point(419, 15)
        Me.lbNguoiTao.Name = "lbNguoiTao"
        Me.lbNguoiTao.Size = New System.Drawing.Size(74, 13)
        Me.lbNguoiTao.TabIndex = 4
        Me.lbNguoiTao.Text = "Người lập phiếu"
        '
        'mmeGhiChu
        '
        Me.mmeGhiChu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mmeGhiChu.Location = New System.Drawing.Point(84, 67)
        Me.mmeGhiChu.MenuManager = Me.BarManager1
        Me.mmeGhiChu.Name = "mmeGhiChu"
        Me.mmeGhiChu.Size = New System.Drawing.Size(873, 57)
        Me.mmeGhiChu.TabIndex = 9
        '
        'txtTenPhieu
        '
        Me.txtTenPhieu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTenPhieu.Location = New System.Drawing.Point(84, 41)
        Me.txtTenPhieu.MenuManager = Me.BarManager1
        Me.txtTenPhieu.Name = "txtTenPhieu"
        Me.txtTenPhieu.Size = New System.Drawing.Size(873, 20)
        Me.txtTenPhieu.TabIndex = 7
        '
        'txtNgayTao
        '
        Me.txtNgayTao.Location = New System.Drawing.Point(288, 12)
        Me.txtNgayTao.MenuManager = Me.BarManager1
        Me.txtNgayTao.Name = "txtNgayTao"
        Me.txtNgayTao.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayTao.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.txtNgayTao.Properties.EditFormat.FormatString = "dd/MM/yyyy"
        Me.txtNgayTao.Properties.ReadOnly = True
        Me.txtNgayTao.Size = New System.Drawing.Size(107, 20)
        Me.txtNgayTao.TabIndex = 3
        '
        'txtSoPhieu
        '
        Me.txtSoPhieu.Location = New System.Drawing.Point(84, 12)
        Me.txtSoPhieu.MenuManager = Me.BarManager1
        Me.txtSoPhieu.Name = "txtSoPhieu"
        Me.txtSoPhieu.Size = New System.Drawing.Size(107, 20)
        Me.txtSoPhieu.TabIndex = 1
        '
        'lbGhiChu
        '
        Me.lbGhiChu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbGhiChu.Location = New System.Drawing.Point(13, 75)
        Me.lbGhiChu.Name = "lbGhiChu"
        Me.lbGhiChu.Size = New System.Drawing.Size(35, 13)
        Me.lbGhiChu.TabIndex = 8
        Me.lbGhiChu.Text = "Ghi chú"
        '
        'lbNgayTao
        '
        Me.lbNgayTao.Location = New System.Drawing.Point(211, 15)
        Me.lbNgayTao.Name = "lbNgayTao"
        Me.lbNgayTao.Size = New System.Drawing.Size(71, 13)
        Me.lbNgayTao.TabIndex = 2
        Me.lbNgayTao.Text = "Ngày lập phiếu"
        '
        'lbTenPhieu
        '
        Me.lbTenPhieu.AllowHtmlString = True
        Me.lbTenPhieu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbTenPhieu.Location = New System.Drawing.Point(13, 44)
        Me.lbTenPhieu.Name = "lbTenPhieu"
        Me.lbTenPhieu.Size = New System.Drawing.Size(148, 14)
        Me.lbTenPhieu.TabIndex = 6
        Me.lbTenPhieu.Text = "Tên phiếu <color=red>*</color>"
        '
        'lbSoPhieu
        '
        Me.lbSoPhieu.AllowHtmlString = True
        Me.lbSoPhieu.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
        Me.lbSoPhieu.Location = New System.Drawing.Point(13, 15)
        Me.lbSoPhieu.Name = "lbSoPhieu"
        Me.lbSoPhieu.Size = New System.Drawing.Size(148, 14)
        Me.lbSoPhieu.TabIndex = 0
        Me.lbSoPhieu.Text = "Số phiếu <color=red>*</color>"
        '
        'grpDanhSachDonHang
        '
        Me.grpDanhSachDonHang.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDanhSachDonHang.AppearanceCaption.Options.UseFont = True
        Me.grpDanhSachDonHang.Controls.Add(Me.grdThongTinChiTiet)
        Me.grpDanhSachDonHang.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDanhSachDonHang.Location = New System.Drawing.Point(0, 161)
        Me.grpDanhSachDonHang.Name = "grpDanhSachDonHang"
        Me.grpDanhSachDonHang.Size = New System.Drawing.Size(969, 406)
        Me.grpDanhSachDonHang.TabIndex = 1
        Me.grpDanhSachDonHang.Text = "Danh sách đơn hàng"
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
        Me.grdThongTinChiTiet.Size = New System.Drawing.Size(965, 382)
        Me.grdThongTinChiTiet.TabIndex = 0
        Me.grdThongTinChiTiet.UseEmbeddedNavigator = True
        Me.grdThongTinChiTiet.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grvThongTinChiTiet})
        '
        'grvThongTinChiTiet
        '
        Me.grvThongTinChiTiet.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.grdColSoDonHang, Me.grdColTenDonVi, Me.grdColTenSanPham, Me.grdColSoLuong, Me.grdColQuyCachSanPham, Me.grdColGiayRuot, Me.grdColGiayBia, Me.grdColLaiDinhMuc, Me.grdColDonGiaTinh})
        Me.grvThongTinChiTiet.GridControl = Me.grdThongTinChiTiet
        Me.grvThongTinChiTiet.Name = "grvThongTinChiTiet"
        Me.grvThongTinChiTiet.NewItemRowText = "Nhấn vào đây để thêm đơn hàng"
        Me.grvThongTinChiTiet.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.grvThongTinChiTiet.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.grvThongTinChiTiet.OptionsNavigation.AutoFocusNewRow = True
        Me.grvThongTinChiTiet.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.grvThongTinChiTiet.OptionsView.ShowGroupPanel = False
        '
        'grdColSoDonHang
        '
        Me.grdColSoDonHang.AppearanceHeader.Options.UseTextOptions = True
        Me.grdColSoDonHang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grdColSoDonHang.Caption = "Số đơn hàng"
        Me.grdColSoDonHang.Name = "grdColSoDonHang"
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
        'frmPhieuDuyetGia_CapNhat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 567)
        Me.Controls.Add(Me.grpDanhSachDonHang)
        Me.Controls.Add(Me.panPhieuDuyetGia)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmPhieuDuyetGia_CapNhat"
        Me.Text = "SX. Cập nhật thông tin Phiếu duyệt giá"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panPhieuDuyetGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panPhieuDuyetGia.ResumeLayout(False)
        Me.panPhieuDuyetGia.PerformLayout()
        CType(Me.txtNguoiTao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mmeGhiChu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTenPhieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNgayTao.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSoPhieu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grpDanhSachDonHang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpDanhSachDonHang.ResumeLayout(False)
        CType(Me.grdThongTinChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvThongTinChiTiet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents btnGhiVaDong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents btnGhiVaIn As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnDong As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents panPhieuDuyetGia As DevExpress.XtraEditors.PanelControl
    Friend WithEvents grpDanhSachDonHang As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents lbSoPhieu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtNguoiTao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbNguoiTao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents mmeGhiChu As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txtTenPhieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNgayTao As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtSoPhieu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbGhiChu As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbNgayTao As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbTenPhieu As DevExpress.XtraEditors.LabelControl
End Class
