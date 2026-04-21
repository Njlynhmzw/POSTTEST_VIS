<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelInput As Panel
    Friend WithEvents lblKode As Label
    Friend WithEvents txtKodeNovel As TextBox
    Friend WithEvents lblJudul As Label
    Friend WithEvents txtJudul As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents panelSearch As Panel
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvNovel As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnPenjualan As Button

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        panelHeader = New Panel()
        lblTitle = New Label()
        panelInput = New Panel()
        lblKode = New Label()
        txtKodeNovel = New TextBox()
        lblJudul = New Label()
        txtJudul = New TextBox()
        lblHarga = New Label()
        txtHarga = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        panelSearch = New Panel()
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvNovel = New DataGridView()
        btnPenjualan = New Button()
        ErrorProvider1 = New ErrorProvider(components)

        CType(dgvNovel, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()

        ' FORM
        Me.Text = "Novel Collection - Pastel Edition"
        Me.ClientSize = New Size(850, 620)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.BackColor = Color.FromArgb(250, 251, 252)
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

        ' ================= HEADER =================
        panelHeader.BackColor = Color.FromArgb(190, 190, 230)
        panelHeader.Dock = DockStyle.Top
        panelHeader.Size = New Size(850, 80)

        lblTitle.Text = "˚ʚ Novel Magic ɞ˚"
        lblTitle.Font = New Font("Segoe UI Semibold", 20)
        lblTitle.ForeColor = Color.FromArgb(64, 64, 80)
        lblTitle.Dock = DockStyle.Fill
        lblTitle.TextAlign = ContentAlignment.MiddleCenter

        panelHeader.Controls.Add(lblTitle)

        ' ================= PANEL INPUT =================
        panelInput.BackColor = Color.White
        panelInput.Location = New Point(25, 105)
        panelInput.Size = New Size(420, 230)

        lblKode.Text = "KODE NOVEL"
        lblKode.Location = New Point(25, 20)

        txtKodeNovel.Location = New Point(25, 42)
        txtKodeNovel.Size = New Size(370, 27)

        lblJudul.Text = "JUDUL NOVEL"
        lblJudul.Location = New Point(25, 85)

        txtJudul.Location = New Point(25, 107)
        txtJudul.Size = New Size(370, 27)

        lblHarga.Text = "HARGA BUKU"
        lblHarga.Location = New Point(25, 150)

        txtHarga.Location = New Point(25, 172)
        txtHarga.Size = New Size(370, 27)

        panelInput.Controls.AddRange({lblKode, txtKodeNovel, lblJudul, txtJudul, lblHarga, txtHarga})

        ' ================= BUTTON =================
        btnSimpan.Text = "Simpan"
        btnSimpan.BackColor = Color.FromArgb(180, 230, 180)
        btnSimpan.Location = New Point(465, 195)
        btnSimpan.Size = New Size(170, 45)

        btnUbah.Text = "Edit"
        btnUbah.BackColor = Color.FromArgb(255, 235, 170)
        btnUbah.Location = New Point(645, 195)
        btnUbah.Size = New Size(170, 45)

        btnHapus.Text = "Hapus"
        btnHapus.BackColor = Color.FromArgb(255, 190, 190)
        btnHapus.Location = New Point(465, 250)
        btnHapus.Size = New Size(170, 45)

        btnBatal.Text = "Cancel"
        btnBatal.BackColor = Color.FromArgb(220, 225, 230)
        btnBatal.Location = New Point(645, 250)
        btnBatal.Size = New Size(170, 45)

        ' ================= BUTTON PENJUALAN =================
        btnPenjualan.Text = "Transaksi Penjualan"
        btnPenjualan.BackColor = Color.FromArgb(200, 210, 255)
        btnPenjualan.Location = New Point(555, 310)
        btnPenjualan.Size = New Size(200, 40)

        ' ================= SEARCH =================
        panelSearch.BackColor = Color.White
        panelSearch.Location = New Point(465, 105)
        panelSearch.Size = New Size(350, 75)

        lblSearch.Text = "Cari Novel"
        lblSearch.Location = New Point(15, 10)

        txtSearch.Location = New Point(15, 35)
        txtSearch.Size = New Size(320, 27)

        panelSearch.Controls.AddRange({lblSearch, txtSearch})

        ' ================= DATAGRID =================
        dgvNovel.Location = New Point(25, 360)
        dgvNovel.Size = New Size(795, 220)
        dgvNovel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' ================= ADD =================
        Me.Controls.Add(panelHeader)
        Me.Controls.Add(panelInput)
        Me.Controls.Add(panelSearch)
        Me.Controls.Add(btnSimpan)
        Me.Controls.Add(btnUbah)
        Me.Controls.Add(btnHapus)
        Me.Controls.Add(btnBatal)
        Me.Controls.Add(btnPenjualan)
        Me.Controls.Add(dgvNovel)

        ErrorProvider1.ContainerControl = Me

        CType(dgvNovel, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()

    End Sub

End Class