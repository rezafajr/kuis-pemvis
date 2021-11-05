
Public Class Form1
    Dim makan, minum, jumlah_makan, jumlah_minum, hitung, kembalian As Integer
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox4.Text) < hitung Then
            MessageBox.Show("Uang anda kurang!" & vbNewLine & "Silahkan inputkan jumlah uang yang sesuai / lebih" & vbNewLine &
                            "Dengan jumlah harga yang telah anda pesan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox4.Text = ""
        ElseIf Val(TextBox4.Text) >= hitung Then
            TextBox5.Visible = True
            Label6.Visible = True
            kembalian = Val(TextBox4.Text) - hitung
            TextBox5.Text = "Rp." & kembalian
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            ComboBox2.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            TextBox2.Visible = True
        Else
            ComboBox2.Visible = False
            Label2.Visible = False
            Label4.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Nasi Goreng" Then
            Label1.Text = "Rp.15000"
            makan = 15000
        ElseIf ComboBox1.Text = "Nasi Campur" Then
            Label1.Text = "Rp.12000"
            makan = 12000
        ElseIf ComboBox1.Text = "Nasi Kuning" Then
            Label1.Text = "Rp.10000"
            makan = 10000
        ElseIf ComboBox1.Text = "Nasi Rames" Then
            Label1.Text = "Rp.13000"
            makan = 13000
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "Es Tejus" Then
            Label2.Text = "Rp.3000"
            minum = 3000
        ElseIf ComboBox2.Text = "Es Susu" Then
            Label2.Text = "Rp.5000"
            minum = 5000
        ElseIf ComboBox2.Text = "Es Kelapa" Then
            Label2.Text = "Rp.7000"
            minum = 10000
        ElseIf ComboBox2.Text = "Es Doger" Then
            Label2.Text = "Rp.8000"
            minum = 8000
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        jumlah_makan = Val(TextBox1.Text) * makan
        jumlah_minum = Val(TextBox2.Text) * minum
        hitung = jumlah_makan + jumlah_minum

        Label5.Text = "Rp." & hitung

        Label5.Visible = True
        GroupBox2.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox3.Text = "Rp." & hitung

    End Sub
End Class
