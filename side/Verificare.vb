Public Class Verificare
    Public ffn As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim result As DialogResult
        Dim ofd As New OpenFileDialog
        ofd.Title = "Alege testul..."
        ofd.InitialDirectory = System.IO.Directory.GetCurrentDirectory
        result = ofd.ShowDialog
        If result = Windows.Forms.DialogResult.OK And ofd.FileName <> String.Empty Then
            ffn = ofd.FileName
            Label1.Text = System.IO.Path.GetFileName(ofd.FileName)
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ffn <> String.Empty Then
            VerTest.Show()
            Me.Close()
        Else
            MsgBox("Alege testul")
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Principala.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Verificare_resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Size.Width > GroupBox1.Size.Width Then
            Label2.Location = New Point(Int(Me.Size.Width / 2) - Int(Label2.Size.Width / 2), Label2.Location.Y)
            GroupBox1.Location = New Point(Int(Me.Size.Width / 2) - Int(GroupBox1.Size.Width / 2), GroupBox1.Location.Y)
            Button3.Location = New Point(Int(Me.Size.Width / 2) - Int((Button3.Size.Width + Button4.Size.Width + 20) / 2), Button3.Location.Y)
        Else
            Label2.Location = New Point(10, Label2.Location.Y)
            GroupBox1.Location = New Point(10, GroupBox1.Location.Y)
            Button3.Location = New Point(10, Button3.Location.Y)
        End If
        Button4.Location = New Point(Button3.Size.Width + Button3.Location.X + 20, Button3.Location.Y)
    End Sub
End Class