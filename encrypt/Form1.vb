Public Class Form1
    Public Function decod(ByVal s As String) As String
        Dim n1, n2 As Integer
        Dim n4 As String
        n1 = Int("0" + s.Chars(3)) * 10 + Int("0" + s.Chars(1))
        n2 = Int("0" + s.Chars(0)) * 10 + Int("0" + s.Chars(2))
        n4 = ""
        For i As Integer = 4 + n1 To s.Length - n2 - 3 Step 3
            n4 = n4 + Chr(Int("0" + s.Chars(i)) * 100 + Int("0" + s.Chars(i + 1)) * 10 + Int("0" + s.Chars(i + 2)))
        Next
        decod = n4
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ptr1 As System.IO.StreamReader
        Dim ptr2 As System.IO.StreamWriter
        ptr1 = My.Computer.FileSystem.OpenTextFileReader(System.IO.Directory.GetCurrentDirectory + "\fisier.txt")
        ptr2 = New System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory + "\fisier_out.txt")
        While ptr1.EndOfStream = False
            ptr2.WriteLine(decod(ptr1.ReadLine))
        End While
        ptr1.Close()
        ptr2.Close()
    End Sub
End Class
