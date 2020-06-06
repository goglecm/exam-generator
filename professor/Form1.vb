Public Class Form1

    Const IntDATA = "DATA.dym"

    Public Structure I2P1
        Dim Nume As String
        Dim Corect As Byte
    End Structure

    Public Structure I4P1
        Dim Nume As String
        Dim NumarRand As Integer
        Dim Rand As String
    End Structure

    Public Structure I1
        Dim Tema As Integer
        Dim Grad As Byte
        Dim Nume As String
        Dim Corect As Byte
    End Structure

    Public Structure I2
        Dim Tema As Integer
        Dim Grad As Byte
        Dim Nume As String
        Dim Raspuns() As I2P1
    End Structure

    Public Structure I3
        Dim Tema As Integer
        Dim Grad As Byte
        Dim Nume As String
        Dim Raspuns() As String
    End Structure

    Public Structure I4
        Dim Tema As Integer
        Dim Grad As Byte
        Dim NumarRandProblema As Integer
        Dim RandProblema As String
        Dim NumarIntrebare As Integer
        Dim Intrebare() As I4P1
    End Structure

    Public Structure DATA
        Dim NumarTeme As Integer
        Dim Teme() As String
        Dim NumarItem1, NumarItem2, NumarItem3, NumarItem4 As Integer
        Dim Item1() As I1
        Dim Item2() As I2
        Dim Item3() As I3
        Dim Item4() As I4
    End Structure

    Public a As DATA

    Public Function CitireDATA(ByRef a As DATA)
        Dim f As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\\testfile.txt")

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form6.Show()
    End Sub
End Class