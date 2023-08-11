Imports System.Data.Odbc
Public Class jurusan
    Sub uwu()
        cmd = New OdbcCommand("select * from jurusan", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cbcari.Items.Add(dr.GetString(0))
        Loop
    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bsimpan.Enabled = False
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True
        bcari.Enabled = True

        tbid.Enabled = False
        tbkode.Enabled = False
        tbnamajurusan.Enabled = False
        cbcari.Enabled = True

        tbid.Text = " "
        tbnamajurusan.Text = " "
        tbkode.Text = " "
        cbcari.Text = " "
    End Sub
    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        btambah.Enabled = False
        bsimpan.Enabled = True
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = True
        btutup.Enabled = True
        cbcari.Enabled = False
        bcari.Enabled = False
        tbid.Enabled = True
        tbkode.Enabled = True
        tbnamajurusan.Enabled = True
    End Sub
    Sub tampil()
        koneksi()
        da = New OdbcDataAdapter("select * from jurusan", conn)
        ds = New DataSet
        da.Fill(ds, "jurusan")
        dgvjurusan.DataSource = (ds.Tables("jurusan"))
    End Sub
    Private Sub jurusan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bawaan()
        tampil()
        uwu()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        koneksi()
        Dim simpan As String
        simpan = "insert into jurusan value('" & tbid.Text & "','" & tbkode.Text & "','" & tbnamajurusan.Text & "')"
        cmd = New OdbcCommand(simpan, conn)
        cmd.ExecuteNonQuery()
        tampil()
        bawaan()
        MsgBox("Berhasil Menyimpan")
    End Sub

    Private Sub bcari_Click(sender As Object, e As EventArgs) Handles bcari.Click
        tbkode.Enabled = True
        tbnamajurusan.Enabled = True
        btambah.Enabled = False
        bubah.Enabled = True
        bhapus.Enabled = True
        bbatal.Enabled = True
        koneksi()
        cmd = New OdbcCommand("select * from jurusan where id='" & cbcari.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tbid.Text = dr.GetString(0)
            tbkode.Text = dr.GetString(1)
            tbnamajurusan.Text = dr.GetString(2)
        End If
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub bubah_Click(sender As Object, e As EventArgs) Handles bubah.Click
        Dim ubah As String
        ubah = "update jurusan set kode_jurusan='" & tbkode.Text & "',nama_jurusan='" & tbnamajurusan.Text & "'where id='" & tbid.Text & "'"
        cmd = New OdbcCommand(ubah, conn)
        cmd.ExecuteNonQuery()
        bawaan()
        tampil()
        MsgBox("Berhasil Mengubah")
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        Dim hapus As String
        hapus = "delete from jurusan where id='" & tbid.Text & "'"
        cmd = New OdbcCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        bawaan()
        tampil()
        MsgBox("Berhasil Menghapus")
    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub
End Class