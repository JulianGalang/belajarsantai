<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jurusan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btambah = New System.Windows.Forms.Button()
        Me.bsimpan = New System.Windows.Forms.Button()
        Me.bubah = New System.Windows.Forms.Button()
        Me.bhapus = New System.Windows.Forms.Button()
        Me.bbatal = New System.Windows.Forms.Button()
        Me.btutup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbid = New System.Windows.Forms.TextBox()
        Me.tbkode = New System.Windows.Forms.TextBox()
        Me.tbnamajurusan = New System.Windows.Forms.TextBox()
        Me.cbcari = New System.Windows.Forms.ComboBox()
        Me.bcari = New System.Windows.Forms.Button()
        Me.dgvjurusan = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvjurusan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel1.Controls.Add(Me.btutup)
        Me.Panel1.Controls.Add(Me.bbatal)
        Me.Panel1.Controls.Add(Me.bhapus)
        Me.Panel1.Controls.Add(Me.bubah)
        Me.Panel1.Controls.Add(Me.bsimpan)
        Me.Panel1.Controls.Add(Me.btambah)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(138, 364)
        Me.Panel1.TabIndex = 0
        '
        'btambah
        '
        Me.btambah.FlatAppearance.BorderSize = 0
        Me.btambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btambah.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btambah.Location = New System.Drawing.Point(30, 45)
        Me.btambah.Name = "btambah"
        Me.btambah.Size = New System.Drawing.Size(75, 23)
        Me.btambah.TabIndex = 0
        Me.btambah.Text = "TAMBAH"
        Me.btambah.UseVisualStyleBackColor = True
        '
        'bsimpan
        '
        Me.bsimpan.FlatAppearance.BorderSize = 0
        Me.bsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bsimpan.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsimpan.Location = New System.Drawing.Point(30, 85)
        Me.bsimpan.Name = "bsimpan"
        Me.bsimpan.Size = New System.Drawing.Size(75, 23)
        Me.bsimpan.TabIndex = 1
        Me.bsimpan.Text = "SIMPAN"
        Me.bsimpan.UseVisualStyleBackColor = True
        '
        'bubah
        '
        Me.bubah.FlatAppearance.BorderSize = 0
        Me.bubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bubah.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bubah.Location = New System.Drawing.Point(30, 130)
        Me.bubah.Name = "bubah"
        Me.bubah.Size = New System.Drawing.Size(75, 23)
        Me.bubah.TabIndex = 2
        Me.bubah.Text = "UBAH"
        Me.bubah.UseVisualStyleBackColor = True
        '
        'bhapus
        '
        Me.bhapus.FlatAppearance.BorderSize = 0
        Me.bhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bhapus.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bhapus.Location = New System.Drawing.Point(30, 175)
        Me.bhapus.Name = "bhapus"
        Me.bhapus.Size = New System.Drawing.Size(75, 23)
        Me.bhapus.TabIndex = 3
        Me.bhapus.Text = "HAPUS"
        Me.bhapus.UseVisualStyleBackColor = True
        '
        'bbatal
        '
        Me.bbatal.FlatAppearance.BorderSize = 0
        Me.bbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bbatal.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbatal.Location = New System.Drawing.Point(30, 220)
        Me.bbatal.Name = "bbatal"
        Me.bbatal.Size = New System.Drawing.Size(75, 23)
        Me.bbatal.TabIndex = 4
        Me.bbatal.Text = "BATAL"
        Me.bbatal.UseVisualStyleBackColor = True
        '
        'btutup
        '
        Me.btutup.FlatAppearance.BorderSize = 0
        Me.btutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btutup.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btutup.Location = New System.Drawing.Point(30, 265)
        Me.btutup.Name = "btutup"
        Me.btutup.Size = New System.Drawing.Size(75, 23)
        Me.btutup.TabIndex = 5
        Me.btutup.Text = "TUTUP"
        Me.btutup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(312, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "JURUSAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(167, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Jurusan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(167, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Kode Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(167, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Jurusan"
        '
        'tbid
        '
        Me.tbid.Location = New System.Drawing.Point(303, 45)
        Me.tbid.Name = "tbid"
        Me.tbid.Size = New System.Drawing.Size(115, 20)
        Me.tbid.TabIndex = 2
        '
        'tbkode
        '
        Me.tbkode.Location = New System.Drawing.Point(303, 84)
        Me.tbkode.Name = "tbkode"
        Me.tbkode.Size = New System.Drawing.Size(115, 20)
        Me.tbkode.TabIndex = 2
        '
        'tbnamajurusan
        '
        Me.tbnamajurusan.Location = New System.Drawing.Point(303, 119)
        Me.tbnamajurusan.Name = "tbnamajurusan"
        Me.tbnamajurusan.Size = New System.Drawing.Size(198, 20)
        Me.tbnamajurusan.TabIndex = 2
        '
        'cbcari
        '
        Me.cbcari.FormattingEnabled = True
        Me.cbcari.Location = New System.Drawing.Point(424, 45)
        Me.cbcari.Name = "cbcari"
        Me.cbcari.Size = New System.Drawing.Size(66, 21)
        Me.cbcari.TabIndex = 3
        '
        'bcari
        '
        Me.bcari.Location = New System.Drawing.Point(496, 42)
        Me.bcari.Name = "bcari"
        Me.bcari.Size = New System.Drawing.Size(75, 23)
        Me.bcari.TabIndex = 4
        Me.bcari.Text = "Cari"
        Me.bcari.UseVisualStyleBackColor = True
        '
        'dgvjurusan
        '
        Me.dgvjurusan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvjurusan.Location = New System.Drawing.Point(171, 175)
        Me.dgvjurusan.Name = "dgvjurusan"
        Me.dgvjurusan.ReadOnly = True
        Me.dgvjurusan.Size = New System.Drawing.Size(386, 150)
        Me.dgvjurusan.TabIndex = 5
        '
        'jurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(587, 361)
        Me.Controls.Add(Me.dgvjurusan)
        Me.Controls.Add(Me.bcari)
        Me.Controls.Add(Me.cbcari)
        Me.Controls.Add(Me.tbnamajurusan)
        Me.Controls.Add(Me.tbkode)
        Me.Controls.Add(Me.tbid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "jurusan"
        Me.Text = "jurusan"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvjurusan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btutup As System.Windows.Forms.Button
    Friend WithEvents bbatal As System.Windows.Forms.Button
    Friend WithEvents bhapus As System.Windows.Forms.Button
    Friend WithEvents bubah As System.Windows.Forms.Button
    Friend WithEvents bsimpan As System.Windows.Forms.Button
    Friend WithEvents btambah As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbid As System.Windows.Forms.TextBox
    Friend WithEvents tbkode As System.Windows.Forms.TextBox
    Friend WithEvents tbnamajurusan As System.Windows.Forms.TextBox
    Friend WithEvents cbcari As System.Windows.Forms.ComboBox
    Friend WithEvents bcari As System.Windows.Forms.Button
    Friend WithEvents dgvjurusan As System.Windows.Forms.DataGridView
End Class
