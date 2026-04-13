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

	Friend WithEvents panelHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents panelInput As System.Windows.Forms.Panel
    Friend WithEvents lblKode As System.Windows.Forms.Label
    Friend WithEvents txtKodeNovel As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblHarga As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents panelSearch As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents dgvNovel As System.Windows.Forms.DataGridView

	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		components = New ComponentModel.Container()
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
		ErrorProvider1 = New ErrorProvider(components)
		panelHeader.SuspendLayout()
		panelInput.SuspendLayout()
		panelSearch.SuspendLayout()
		CType(dgvNovel, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()

		panelHeader.BackColor = Color.FromArgb(CByte(190), CByte(190), CByte(230))
		panelHeader.Controls.Add(lblTitle)
		panelHeader.Dock = DockStyle.Top
		panelHeader.Location = New Point(0, 0)
		panelHeader.Name = "panelHeader"
		panelHeader.Size = New Size(850, 80)
		panelHeader.TabIndex = 0

		lblTitle.Dock = DockStyle.Fill
		lblTitle.Font = New Font("Segoe UI Semibold", 20F)
		lblTitle.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(80))
		lblTitle.Location = New Point(0, 0)
		lblTitle.Name = "lblTitle"
		lblTitle.Size = New Size(850, 80)
		lblTitle.TabIndex = 0
		lblTitle.Text = "Manajemen Penjualan Novel"
		lblTitle.TextAlign = ContentAlignment.MiddleCenter

		panelInput.BackColor = Color.White
		panelInput.Controls.Add(lblKode)
		panelInput.Controls.Add(txtKodeNovel)
		panelInput.Controls.Add(lblJudul)
		panelInput.Controls.Add(txtJudul)
		panelInput.Controls.Add(lblHarga)
		panelInput.Controls.Add(txtHarga)
		panelInput.Location = New Point(25, 105)
		panelInput.Name = "panelInput"
		panelInput.Size = New Size(420, 230)
		panelInput.TabIndex = 1

		lblKode.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
		lblKode.ForeColor = Color.FromArgb(CByte(120), CByte(160), CByte(210))
		lblKode.Location = New Point(25, 20)
		lblKode.Name = "lblKode"
		lblKode.Size = New Size(100, 23)
		lblKode.TabIndex = 0
		lblKode.Text = "KODE NOVEL"

		txtKodeNovel.Location = New Point(25, 42)
		txtKodeNovel.Name = "txtKodeNovel"
		txtKodeNovel.Size = New Size(370, 27)
		txtKodeNovel.TabIndex = 1

		lblJudul.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
		lblJudul.ForeColor = Color.FromArgb(CByte(240), CByte(170), CByte(170))
		lblJudul.Location = New Point(25, 85)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(100, 23)
		lblJudul.TabIndex = 2
		lblJudul.Text = "JUDUL NOVEL"

		txtJudul.Location = New Point(25, 107)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(370, 27)
		txtJudul.TabIndex = 3

		lblHarga.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
		lblHarga.ForeColor = Color.FromArgb(CByte(160), CByte(210), CByte(180))
		lblHarga.Location = New Point(25, 150)
		lblHarga.Name = "lblHarga"
		lblHarga.Size = New Size(100, 23)
		lblHarga.TabIndex = 4
		lblHarga.Text = "HARGA BUKU"

		txtHarga.Location = New Point(25, 172)
		txtHarga.Name = "txtHarga"
		txtHarga.Size = New Size(370, 27)
		txtHarga.TabIndex = 5

		btnSimpan.BackColor = Color.FromArgb(CByte(180), CByte(230), CByte(180))
		btnSimpan.FlatAppearance.BorderSize = 0
		btnSimpan.FlatStyle = FlatStyle.Flat
		btnSimpan.Font = New Font("Segoe UI Semibold", 10F)
		btnSimpan.ForeColor = Color.FromArgb(CByte(60), CByte(90), CByte(60))
		btnSimpan.Location = New Point(465, 195)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(170, 45)
		btnSimpan.TabIndex = 3
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False

		btnUbah.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(170))
		btnUbah.FlatAppearance.BorderSize = 0
		btnUbah.FlatStyle = FlatStyle.Flat
		btnUbah.Font = New Font("Segoe UI Semibold", 10F)
		btnUbah.ForeColor = Color.FromArgb(CByte(100), CByte(80), CByte(20))
		btnUbah.Location = New Point(645, 195)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(170, 45)
		btnUbah.TabIndex = 4
		btnUbah.Text = "Edit "
		btnUbah.UseVisualStyleBackColor = False

		btnHapus.BackColor = Color.FromArgb(CByte(255), CByte(190), CByte(190))
		btnHapus.FlatAppearance.BorderSize = 0
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.Font = New Font("Segoe UI Semibold", 10F)
		btnHapus.ForeColor = Color.FromArgb(CByte(120), CByte(60), CByte(60))
		btnHapus.Location = New Point(465, 250)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(170, 45)
		btnHapus.TabIndex = 5
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False

		btnBatal.BackColor = Color.FromArgb(CByte(220), CByte(225), CByte(230))
		btnBatal.FlatAppearance.BorderSize = 0
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.Font = New Font("Segoe UI Semibold", 10F)
		btnBatal.ForeColor = Color.FromArgb(CByte(80), CByte(85), CByte(90))
		btnBatal.Location = New Point(645, 250)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(170, 45)
		btnBatal.TabIndex = 6
		btnBatal.Text = "Cancel"
		btnBatal.UseVisualStyleBackColor = False

		panelSearch.BackColor = Color.White
		panelSearch.Controls.Add(lblSearch)
		panelSearch.Controls.Add(txtSearch)
		panelSearch.Location = New Point(465, 105)
		panelSearch.Name = "panelSearch"
		panelSearch.Size = New Size(350, 75)
		panelSearch.TabIndex = 2

		lblSearch.Font = New Font("Segoe UI Semibold", 9F)
		lblSearch.ForeColor = Color.FromArgb(CByte(120), CByte(150), CByte(160))
		lblSearch.Location = New Point(15, 10)
		lblSearch.Name = "lblSearch"
		lblSearch.Size = New Size(100, 23)
		lblSearch.TabIndex = 0
		lblSearch.Text = "Cari Novel"

		txtSearch.Location = New Point(15, 35)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(320, 27)
		txtSearch.TabIndex = 1

		DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(245), CByte(252), CByte(248))
		dgvNovel.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
		dgvNovel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvNovel.BackgroundColor = Color.Gainsboro
		dgvNovel.BorderStyle = BorderStyle.None
		DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(190), CByte(190), CByte(230))
		DataGridViewCellStyle2.Font = New Font("Segoe UI Semibold", 9F)
		DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(80))
		DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(190), CByte(190), CByte(230))
		dgvNovel.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
		dgvNovel.ColumnHeadersHeight = 40
		DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = SystemColors.Window
		DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
		DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
		DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(220), CByte(235), CByte(255))
		DataGridViewCellStyle3.SelectionForeColor = Color.Black
		DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
		dgvNovel.DefaultCellStyle = DataGridViewCellStyle3
		dgvNovel.EnableHeadersVisualStyles = False
		dgvNovel.Location = New Point(25, 360)
		dgvNovel.Name = "dgvNovel"
		dgvNovel.RowHeadersWidth = 51
		dgvNovel.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvNovel.Size = New Size(795, 220)
		dgvNovel.TabIndex = 7

		ErrorProvider1.ContainerControl = Me

		BackColor = Color.FromArgb(CByte(250), CByte(251), CByte(252))
		ClientSize = New Size(850, 620)
		Controls.Add(panelHeader)
		Controls.Add(panelInput)
		Controls.Add(panelSearch)
		Controls.Add(btnSimpan)
		Controls.Add(btnUbah)
		Controls.Add(btnHapus)
		Controls.Add(btnBatal)
		Controls.Add(dgvNovel)
		Font = New Font("Segoe UI", 9F)
		FormBorderStyle = FormBorderStyle.FixedSingle
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Novel Collection - Pastel Edition"
		panelHeader.ResumeLayout(False)
		panelInput.ResumeLayout(False)
		panelInput.PerformLayout()
		panelSearch.ResumeLayout(False)
		panelSearch.PerformLayout()
		CType(dgvNovel, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)

	End Sub

	Friend WithEvents ErrorProvider1 As ErrorProvider
End Class