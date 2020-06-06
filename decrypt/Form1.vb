Public Class Form1

    Public Function codif(ByVal s As String) As String
        Dim n As String = ""
        Dim n1, n2 As Integer
        Randomize()
        n1 = CInt(Math.Floor(78 * Rnd())) + 20
        n2 = CInt(Math.Floor(78 * Rnd())) + 20
        n = n + n2.ToString.Chars(0) + n1.ToString.Chars(1) + n2.ToString.Chars(1) + n1.ToString.Chars(0)
        For i As Integer = 1 To n1
            n = n + (CInt(Math.Floor((9) * Rnd())) + 1).ToString
        Next
        For i As Integer = 0 To s.Length - 1
            If Asc(s.Chars(i)).ToString.Length = 1 Then
                n = n + "00" + Asc(s.Chars(i)).ToString
            ElseIf Asc(s.Chars(i)).ToString.Length = 2 Then
                n = n + "0" + Asc(s.Chars(i)).ToString
            ElseIf Asc(s.Chars(i)).ToString.Length = 3 Then
                n = n + Asc(s.Chars(i)).ToString
            End If
        Next
        For i As Integer = 1 To n2
            n = n + (CInt(Math.Floor(9 * Rnd())) + 1).ToString
        Next
        codif = n
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ptr1 As System.IO.StreamReader
        Dim ptr2 As System.IO.StreamWriter
        ptr1 = My.Computer.FileSystem.OpenTextFileReader(System.IO.Directory.GetCurrentDirectory + "\fisier.txt")
        ptr2 = New System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory + "\fisier_out.txt")
        While ptr1.EndOfStream = False
            ptr2.WriteLine(codif(ptr1.ReadLine))
        End While
        ptr2.Close()
        ptr1.Close()
    End Sub
End Class
