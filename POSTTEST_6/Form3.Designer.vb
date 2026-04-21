<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    ' ================= DISPOSE =================
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

    ' ================= COMPONENT =================
    Private components As System.ComponentModel.IContainer

    Friend WithEvents panelHeader As Panel
    Friend WithEvents lblTitle As Label

    Friend WithEvents panelInput As Panel
    Friend WithEvents lblNovel As Label
    Friend WithEvents cmbNovel As ComboBox

    Friend WithEvents lblHarga As Label
    Friend WithEvents txtHarga As TextBox

    Friend WithEvents lblJumlah As Label
    Friend WithEvents txtJumlah As TextBox

    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox

    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnHapus As Button

    Friend WithEvents dgvPenjualan As DataGridView
    Friend WithEvents lblGrandTotal As Label

	' ================= INITIALIZE =================
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		panelHeader = New Panel()
		lblTitle = New Label()
		panelInput = New Panel()
		lblNovel = New Label()
		cmbNovel = New ComboBox()
		lblHarga = New Label()
		txtHarga = New TextBox()
		lblJumlah = New Label()
		txtJumlah = New TextBox()
		lblTotal = New Label()
		txtTotal = New TextBox()
		btnSimpan = New Button()
		btnHapus = New Button()
		dgvPenjualan = New DataGridView()
		lblGrandTotal = New Label()
		panelHeader.SuspendLayout()
		panelInput.SuspendLayout()
		CType(dgvPenjualan, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' panelHeader
		' 
		panelHeader.BackColor = Color.FromArgb(CByte(210), CByte(200), CByte(255))
		panelHeader.Controls.Add(lblTitle)
		panelHeader.Dock = DockStyle.Top
		panelHeader.Location = New Point(0, 0)
		panelHeader.Name = "panelHeader"
		panelHeader.Size = New Size(800, 80)
		panelHeader.TabIndex = 0
		' 
		' lblTitle
		' 
		lblTitle.Dock = DockStyle.Fill
		lblTitle.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
		lblTitle.ForeColor = Color.FromArgb(CByte(80), CByte(60), CByte(120))
		lblTitle.Location = New Point(0, 0)
		lblTitle.Name = "lblTitle"
		lblTitle.Size = New Size(800, 80)
		lblTitle.TabIndex = 0
		lblTitle.Text = ChrW(55357) & ChrW(57042) & " Cute Cashier - Novel Magic ✨"
		lblTitle.TextAlign = ContentAlignment.MiddleCenter
		' 
		' panelInput
		' 
		panelInput.BackColor = Color.White
		panelInput.Controls.Add(lblNovel)
		panelInput.Controls.Add(cmbNovel)
		panelInput.Controls.Add(lblHarga)
		panelInput.Controls.Add(txtHarga)
		panelInput.Controls.Add(lblJumlah)
		panelInput.Controls.Add(txtJumlah)
		panelInput.Controls.Add(lblTotal)
		panelInput.Controls.Add(txtTotal)
		panelInput.Location = New Point(20, 100)
		panelInput.Name = "panelInput"
		panelInput.Size = New Size(350, 260)
		panelInput.TabIndex = 1
		' 
		' lblNovel
		' 
		lblNovel.Location = New Point(20, 15)
		lblNovel.Name = "lblNovel"
		lblNovel.Size = New Size(100, 23)
		lblNovel.TabIndex = 0
		lblNovel.Text = "📚 Pilih Novel"
		' 
		' cmbNovel
		' 
		cmbNovel.Location = New Point(20, 40)
		cmbNovel.Name = "cmbNovel"
		cmbNovel.Size = New Size(300, 28)
		cmbNovel.TabIndex = 1
		' 
		' lblHarga
		' 
		lblHarga.Location = New Point(20, 70)
		lblHarga.Name = "lblHarga"
		lblHarga.Size = New Size(100, 23)
		lblHarga.TabIndex = 2
		lblHarga.Text = "💵 Harga"
		' 
		' txtHarga
		' 
		txtHarga.Location = New Point(20, 95)
		txtHarga.Name = "txtHarga"
		txtHarga.ReadOnly = True
		txtHarga.Size = New Size(300, 27)
		txtHarga.TabIndex = 3
		' 
		' lblJumlah
		' 
		lblJumlah.Location = New Point(20, 125)
		lblJumlah.Name = "lblJumlah"
		lblJumlah.Size = New Size(100, 23)
		lblJumlah.TabIndex = 4
		lblJumlah.Text = "🔢 Jumlah"
		' 
		' txtJumlah
		' 
		txtJumlah.Location = New Point(20, 150)
		txtJumlah.Name = "txtJumlah"
		txtJumlah.Size = New Size(300, 27)
		txtJumlah.TabIndex = 5
		' 
		' lblTotal
		' 
		lblTotal.Location = New Point(20, 180)
		lblTotal.Name = "lblTotal"
		lblTotal.Size = New Size(100, 23)
		lblTotal.TabIndex = 6
		lblTotal.Text = "💰 Total"
		' 
		' txtTotal
		' 
		txtTotal.Location = New Point(20, 205)
		txtTotal.Name = "txtTotal"
		txtTotal.ReadOnly = True
		txtTotal.Size = New Size(300, 27)
		txtTotal.TabIndex = 7
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.FromArgb(CByte(180), CByte(240), CByte(200))
		btnSimpan.FlatStyle = FlatStyle.Flat
		btnSimpan.Location = New Point(400, 110)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(160, 45)
		btnSimpan.TabIndex = 2
		btnSimpan.Text = "💾 Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.FromArgb(CByte(255), CByte(200), CByte(200))
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.Location = New Point(580, 110)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(160, 45)
		btnHapus.TabIndex = 3
		btnHapus.Text = "🗑️ Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' dgvPenjualan
		' 
		dgvPenjualan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
		dgvPenjualan.BackgroundColor = Color.DarkGray
		dgvPenjualan.BorderStyle = BorderStyle.None
		dgvPenjualan.ColumnHeadersHeight = 29
		dgvPenjualan.Location = New Point(20, 370)
		dgvPenjualan.Name = "dgvPenjualan"
		dgvPenjualan.RowHeadersWidth = 51
		dgvPenjualan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPenjualan.Size = New Size(750, 170)
		dgvPenjualan.TabIndex = 4
		' 
		' lblGrandTotal
		' 
		lblGrandTotal.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
		lblGrandTotal.ForeColor = Color.FromArgb(CByte(90), CByte(70), CByte(150))
		lblGrandTotal.Location = New Point(500, 550)
		lblGrandTotal.Name = "lblGrandTotal"
		lblGrandTotal.Size = New Size(280, 25)
		lblGrandTotal.TabIndex = 5
		lblGrandTotal.Text = "💰 Total Semua: Rp 0"
		' 
		' Form3
		' 
		BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(255))
		ClientSize = New Size(800, 600)
		Controls.Add(panelHeader)
		Controls.Add(panelInput)
		Controls.Add(btnSimpan)
		Controls.Add(btnHapus)
		Controls.Add(dgvPenjualan)
		Controls.Add(lblGrandTotal)
		FormBorderStyle = FormBorderStyle.FixedSingle
		Name = "Form3"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form3 - Penjualan"
		panelHeader.ResumeLayout(False)
		panelInput.ResumeLayout(False)
		panelInput.PerformLayout()
		CType(dgvPenjualan, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)

	End Sub

End Class