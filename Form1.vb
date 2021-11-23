Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list.GridLines = True
        list.View = View.Details
        list.Columns.Add("NIM")
        list.Columns.Add("NAMA", 115)
        list.Columns.Add("PRODI", 110)
        textNim.Text = 1
        textNama.Focus()
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim Arr(2) As String
        Arr(0) = textNim.Text
        Arr(1) = textNama.Text
        Arr(2) = textProdi.Text

        Dim listItem As ListViewItem
        listItem = New ListViewItem
        listItem = list.Items.Add(Arr(0))
        listItem.SubItems.Add(Arr(1))
        listItem.SubItems.Add(Arr(2))

        textNim.Text = textNim.Text + 1
        textNama.Text = ""
        textProdi.Text = ""
        textNama.Focus()
    End Sub
End Class
