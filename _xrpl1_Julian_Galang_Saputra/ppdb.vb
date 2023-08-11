Imports System.Data.Odbc
Public Class ppdb
    Sub anjay()

    End Sub
    Sub uwu()
        cmd = New OdbcCommand("select * from siswa", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cbcariid.Items.Add(dr.GetString(0))
        Loop
    End Sub
    Sub uwau()
        cmd = New OdbcCommand("select * from jurusan", conn)
        dr = cmd.ExecuteReader
        Do While dr.Read
            cbcarikd.Items.Add(dr.GetString(0))
        Loop
    End Sub
    Sub bawaan()
        btambah.Enabled = True
        bcariid.Enabled = True
        bcarikd.Enabled = True
        bsimpan.Enabled = False
        bubah.Enabled = False
        bhapus.Enabled = False
        bbatal.Enabled = False
        btutup.Enabled = True
        cbcarikd.Enabled = False

        tbid.Enabled = False
        tbnik.Enabled = False
        tbnama.Enabled = False
        cbjenis.Enabled = False
        dtp.Enabled = False
        tbjurusan.Enabled = False
        tbumur.Enabled = False
        cbcariid.Enabled = True
        cbcarikd.Enabled = False
        cbjenis.Text = " "
        tbid.Text = " "
        tbnik.Text = " "
        tbnama.Text = " "
        tbjurusan.Text = " "
        tbumur.Text = " "
        cbcariid.Text = " "
        cbcarikd.Text = " "
    End Sub
    Sub adadata()
        koneksi()
        da = New OdbcDataAdapter("select * from siswa", conn)
        ds = New DataSet
        da.Fill(ds, "siswa")
        dgv.DataSource = (ds.Tables("siswa"))
    End Sub
    Sub aturdgv()

    End Sub
    Private Sub ppdb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        bawaan()
        adadata()
        dtp.Text = Format(Now, "dd-MM-yyyy")
        uwu()
        uwau()
    End Sub

    Private Sub btambah_Click(sender As Object, e As EventArgs) Handles btambah.Click
        btambah.Enabled = False
        bcariid.Enabled = False
        bcarikd.Enabled = True
        bsimpan.Enabled = True
        bbatal.Enabled = True
        tbid.Enabled = True
        tbnik.Enabled = True
        tbnama.Enabled = True
        cbjenis.Enabled = True
        dtp.Enabled = True
        tbjurusan.Enabled = True
        tbumur.Enabled = True
        cbcariid.Enabled = False
        cbcarikd.Enabled = True
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        Dim simpan As String
        If tbnama.Text = " " Or tbnik.Text = " " Or cbjenis.Text = " " Or tbjurusan.Text = " " Or tbumur.Text = " " Then
            MsgBox("Pastikan Semua Kolom Terisi Semua")
        Else
            simpan = "insert into siswa value ('" & tbid.Text & "','" & tbnik.Text & "','" & tbnama.Text & "','" & cbjenis.Text & "','" & Format(dtp.Value, "yyyy-MM-dd") & "','" & tbjurusan.Text & "','" & tbumur.Text & "')"
            cmd = New OdbcCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Berhasil Menyimpan Data")
            bawaan()
            adadata()
        End If

    End Sub

    Private Sub bubah_Click(sender As Object, e As EventArgs) Handles bubah.Click
        Dim ubah As String

        ubah = "update siswa set nama='" & tbnama.Text & "',nik='" & tbnik.Text & "',jk='" & cbjenis.Text & "',tanggal_lhr='" & Format(dtp.Value, "yyyy-MM-dd") & "',jurusan='" & tbjurusan.Text & "',umur='" & tbumur.Text & "'where id ='" & tbid.Text & "'"
        cmd = New OdbcCommand(ubah, conn)
        cmd.ExecuteNonQuery()
        bawaan()
        adadata()
        MsgBox("Berhasil Mengubah")
    End Sub

    Private Sub bcariid_Click(sender As Object, e As EventArgs) Handles bcariid.Click
        btambah.Enabled = False
        bsimpan.Enabled = False
        bubah.Enabled = True
        bhapus.Enabled = True
        bbatal.Enabled = True
        bcarikd.Enabled = True
        cbcarikd.Enabled = True
        tbid.Enabled = False
        tbnik.Enabled = True
        tbnama.Enabled = True
        cbjenis.Enabled = True
        dtp.Enabled = True
        tbjurusan.Enabled = True
        tbumur.Enabled = True
        koneksi()
        cmd = New OdbcCommand("select * from siswa where id='" & cbcariid.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tbid.Text = dr.GetString(0)
            tbnik.Text = dr.GetString(1)
            tbnama.Text = dr.GetString(2)
            cbjenis.Text = dr.GetString(3)
            tbjurusan.Text = dr.GetString(5)
            tbumur.Text = dr.GetString(6)
        End If
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        Dim hapus As String
        hapus = "delete from siswa where id='" & tbid.Text & "'"
        cmd = New OdbcCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Hapus Berhasil")
        adadata()
        bawaan()
    End Sub

    Private Sub bbatal_Click(sender As Object, e As EventArgs) Handles bbatal.Click
        bawaan()
    End Sub

    Private Sub bcarikd_Click(sender As Object, e As EventArgs) Handles bcarikd.Click
        koneksi()
        cmd = New OdbcCommand("select * from jurusan where id='" & cbcarikd.Text & "'", conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            tbjurusan.Text = dr.GetString(2)
        End If
    End Sub

    Private Sub cbcarikd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbcarikd.SelectedIndexChanged

    End Sub

    Private Sub btutup_Click(sender As Object, e As EventArgs) Handles btutup.Click
        Me.Close()
    End Sub
End Class
