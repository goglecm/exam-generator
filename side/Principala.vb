Public Class Principala
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Computer.FileSystem.DirectoryExists(System.IO.Directory.GetCurrentDirectory + "\data") Then
            Teste.Show()
            Me.Close()
        Else
            MsgBox("Folderul cu resurse nu a fost gasit!")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Teorie.Show()
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Probleme.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Verificare.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
    Private Sub Principala_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Size.Width > GroupBox1.Size.Width Then
            GroupBox1.Location = New Point(Int(Me.Size.Width / 2) - Int(GroupBox1.Size.Width / 2), GroupBox1.Location.Y)
            GroupBox2.Location = New Point(Int(Me.Size.Width / 2) - Int(GroupBox2.Size.Width / 2), GroupBox2.Location.Y)
            Button5.Location = New Point(Int(Me.Size.Width / 2) - Int(Button5.Size.Width / 2), Button5.Location.Y)
            Label7.Location = New Point(Int(Me.Size.Width / 2) - Int(Label7.Size.Width / 2), Label7.Location.Y)
        Else
            GroupBox1.Location = New Point(10, GroupBox1.Location.Y)
            GroupBox2.Location = New Point(10, GroupBox2.Location.Y)
            Button5.Location = New Point(10, Button5.Location.Y)
            Label7.Location = New Point(10, Label7.Location.Y)
        End If
		 If Me.Size.Height > GroupBox1.Size.Height Then
            GroupBox1.Location = New Point(GroupBox1.Location.X, Int(Me.Size.Height / 2) - Int(GroupBox1.Size.Height / 2))
            GroupBox2.Location = New Point(GroupBox2.Location.X, Int(Me.Size.Height / 2) - Int(GroupBox2.Size.Height / 2))
            Button5.Location = New Point(Button5.Location.X, Int(Me.Size.Height / 2) - Int(Button5.Size.Height / 2))
            Label7.Location = New Point(Label7.Location.X, Int(Me.Size.Height / 2) - Int(Label7.Size.Height / 2))
        Else
            GroupBox1.Location = New Point(GroupBox1.Location.X, 10)
            GroupBox2.Location = New Point(GroupBox2.Location.X, 10)
            Button5.Location = New Point(Button5.Location.X, 10)
            Label7.Location = New Point(Label7.Location.X, 10)
        End If
    End Sub
End Class
