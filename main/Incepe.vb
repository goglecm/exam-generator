Public Class Incepe
    Public ffn As String
    Private Sub Incepe_resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Label1.Location = New Point(Int(Me.Size.Width / 2) - Int(Label1.Size.Width / 2), Label1.Location.Y)
        GroupBox1.Location = New Point(Int(Me.Size.Width / 2) - Int(GroupBox1.Size.Width / 2), GroupBox1.Location.Y)
        Button2.Location = New Point(Int(Me.Size.Width / 2) - Int(Button2.Size.Width / 2), Button2.Location.Y)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ffn <> String.Empty Then
            Testul.nume = TextBox1.Text
            Testul.prenume = TextBox2.Text
            Testul.clasa = NumericUpDown1.Value.ToString
            Testul.indice = DomainUpDown1.Text
            Testul.Show()
            Me.Close()
        Else
            MsgBox("Alege testul")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult
        Dim ofd As New OpenFileDialog
        ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory
        result = ofd.ShowDialog
        If result = Windows.Forms.DialogResult.OK And ofd.FileName <> String.Empty Then
            ffn = ofd.FileName
            Label6.Text = System.IO.Path.GetFileName(ofd.FileName)
        End If
    End Sub
    Private Sub Incepe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  GroupBox1.BackColor = Color.FromArgb(6, 0, 0, 0)
    End Sub
End Class