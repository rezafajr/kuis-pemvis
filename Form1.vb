Public Class Form1
    Dim hrg_nasi, hrg_minum, porsi_makan, porsi_minum, total, bayar As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Controls.Clear()
        Me.InitializeComponent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Val(TextBox3.Text) < total Then
            MessageBox.Show("Uang Anda Kurang" & vbNewLine &
                            "Silahkan input jumlah uang yang sesuai / lebih" & vbNewLine &
                            "Dengan Jumlah Yang Telah Anda Pesan",
                            "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ElseIf Val(TextBox3.Text) >= total Then
            bayar = Val(TextBox3.Text) - total
            TextBox5.Text = "Rp. " & bayar.ToString

            Label6.Visible = True
            TextBox5.Visible = True
            Button3.Visible = True
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Goreng"
                Label1.Text = "Rp. 13000"
                hrg_nasi = 13000
            Case "Nasi Lengko"
                Label1.Text = "Rp. 8000"
                hrg_nasi = 8000
            Case "Nasi Uduk"
                Label1.Text = "Rp. 10000"
                hrg_nasi = 10000
            Case "Nasi Kocheng"
                Label1.Text = "Rp. 9000"
                hrg_nasi = 9000
        End Select

        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        porsi_makan = hrg_nasi * Val(TextBox1.Text)
        porsi_minum = hrg_minum * Val(TextBox2.Text)
        total = porsi_makan + porsi_minum
        Label5.Text = "Rp. " & total.ToString
        TextBox4.Text = "Rp. " & total.ToString
        TextBox3.Focus()

        GroupBox2.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        Button2.Visible = True

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            ComboBox2.Visible = False
            Label2.Visible = False
            Label4.Visible = False
            TextBox2.Visible = False

        ElseIf CheckBox1.Checked = True Then
            ComboBox2.Visible = True
            Label2.Visible = True
            Label4.Visible = True
            TextBox2.Visible = True
        End If
        TextBox2.Focus()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "TeaJus"
                Label2.Text = "Rp. 2000"
                hrg_minum = 2000
            Case "Nutrisari"
                Label2.Text = "Rp. 5000"
                hrg_minum = 5000
            Case "Susu"
                Label2.Text = "Rp. 5000"
                hrg_minum = 5000
            Case "Air Putih"
                Label2.Text = "Rp. 3000"
                hrg_minum = 3000
        End Select
    End Sub
End Class
