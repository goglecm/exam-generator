Public Class Teste
    Public Structure s1
        Public a5() As String
        Public a6(), a7 As Integer
    End Structure
    Public Structure s2
        Public a18() As String
        Public a19 As Integer
    End Structure
    Public Structure s3
        Public a24 As Integer
        Public a22(), a23() As String
    End Structure
    Public Structure s4
        Public a27, a30 As Integer
        Public a29(), a28() As String
    End Structure
    Public a1(), a31(), a9(), a10(), a12(), a13(), a16() As String
    Public a2(), a14(), a0, a3, a8, a11, a15, a20, a25, gd(), n(), t(), tn, nt As Integer
    Public a4() As s1
    Public a17() As s2
    Public a21() As s3
    Public a26() As s4
    Public f As System.IO.StreamReader
    Public cf As System.IO.StreamWriter
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
    Public Function inms(ByVal x As Integer) As Boolean
        Select Case x
            Case 1 To 117
                Return True
            Case Else
                Return False
        End Select
    End Function
    Public Function insc(ByVal x As Integer) As Boolean
        Return True
    End Function
    Public Function inio(ByVal x As Integer) As Boolean
        Return True
    End Function
    Public Function nm() As String
        Dim s As String
        Dim i As Integer
        s = ""
        i = 0
        While My.Computer.FileSystem.FileExists(System.IO.Directory.GetCurrentDirectory + "\teste\test_" + Replace(Str(i), " ", "") + ".txt") = True
            i = i + 1
        End While
        Return "\test_" + Replace(Str(i), " ", "") + ".txt"
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sa As Boolean = False
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) = True Then
                sa = True
                Exit For
            End If
        Next
        If sa = False Then
            MsgBox("Alegeti temele!")
            Exit Sub
        End If
        Dim df As Boolean = False
        If CheckBox9.Checked Then
            df = True
        ElseIf CheckBox9.Checked Then
            df = True
        ElseIf CheckBox10.Checked Then
            df = True
        ElseIf CheckBox12.Checked Then
            df = True
        ElseIf CheckBox11.Checked Then
            df = True
        ElseIf CheckBox15.Checked Then
            df = True
        ElseIf CheckBox14.Checked Then
            df = True
        ElseIf CheckBox13.Checked Then
            df = True
        End If
        If df = False Then
            MsgBox("Alegeti itemii!")
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        a0 = a11 = a15 = a20 = a25 = a3 = a8 = 0
        tn = CheckedListBox1.CheckedItems.Count
        nt = NumericUpDown8.Value
        ReDim gd(3)
        If RadioButton1.Checked Then
            gd(1) = 1
        ElseIf RadioButton2.Checked Then
            gd(1) = 1
            gd(2) = 1
        ElseIf RadioButton3.Checked Then
            gd(2) = 1
            gd(3) = 1
        ElseIf RadioButton4.Checked Then
            gd(3) = 1
        ElseIf RadioButton5.Checked Then
            gd(1) = 1
            gd(2) = 1
            gd(3) = 1
        End If
        ReDim t(tn)
        Dim r, k As Integer
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(i) Then
                r = r + 1
                t(r) = i + 1
            End If
        Next
        ReDim n(7)
        n(1) = NumericUpDown1.Value
        n(2) = NumericUpDown2.Value
        n(3) = NumericUpDown3.Value
        n(4) = NumericUpDown4.Value
        n(5) = NumericUpDown5.Value
        n(6) = NumericUpDown6.Value
        n(7) = NumericUpDown7.Value
        For i As Integer = 1 To tn
            If inms(t(i)) Then
                For j As Integer = 1 To 3
                    If gd(j) = 1 Then
                        Dim sd = System.IO.Directory.GetCurrentDirectory + "\data\teste\ms\" + Replace(Str(t(i)), " ", "") + Replace(Str(j), " ", "")
                        If (My.Computer.FileSystem.FileExists(sd + "1.txt")) And (CheckBox9.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "1.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a1(k + a0), a2(k + a0)
                            For q As Integer = 1 To k
                                a1(q + a0) = decod(f.ReadLine)
                                a2(q + a0) = Int(decod(f.ReadLine))
                            Next
                            a0 = a0 + k
                            f.Close()
                        End If
                        If (My.Computer.FileSystem.FileExists(sd + "2.txt")) And (CheckBox10.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "2.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a31(k + a3), a4(k + a3)
                            For q As Integer = 1 To k
                                a31(q + a3) = decod(f.ReadLine)
                                a4(q + a3).a7 = Int(decod(f.ReadLine))
                                ReDim Preserve a4(q + a3).a5(a4(q + a3).a7), a4(q + a3).a6(a4(q + a3).a7)
                                For q1 As Integer = 1 To a4(q + a3).a7
                                    a4(q + a3).a5(q1) = decod(f.ReadLine)
                                    a4(q + a3).a6(q1) = Int(decod(f.ReadLine))
                                Next
                            Next
                            a3 = a3 + k
                        End If
                        If (My.Computer.FileSystem.FileExists(sd + "3.txt")) And (CheckBox12.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "3.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a9(a8 + k), a10(a8 + k)
                            For q As Integer = 1 To k
                                a9(a8 + q) = decod(f.ReadLine)
                                a10(a8 + q) = decod(f.ReadLine)
                            Next
                            a8 = a8 + k
                        End If
                        If (My.Computer.FileSystem.FileExists(sd + "4.txt")) And (CheckBox11.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "4.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a12(a11 + k), a13(a11 + k), a14(a11 + k)
                            For q As Integer = 1 To k
                                a12(a11 + q) = decod(f.ReadLine)
                            Next
                            For q As Integer = 1 To k
                                a13(a11 + q) = decod(f.ReadLine)
                            Next
                            For q As Integer = 1 To k
                                a14(a11 + q) = Int(decod(f.ReadLine))
                                a14(a11 + q) = a14(a11 + q) + a11
                            Next
                            a11 = a11 + k
                        End If
                        If (My.Computer.FileSystem.FileExists(sd + "5.txt")) And (CheckBox15.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "5.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a16(k + a15), a17(k + a15)
                            For q As Integer = 1 To k
                                a16(q + a15) = decod(f.ReadLine)
                                a17(q + a15).a19 = Int(decod(f.ReadLine))
                                ReDim Preserve a17(q + a15).a18(a17(q + a15).a19)
                                For q1 As Integer = 1 To a17(q + a15).a19
                                    a17(q + a15).a18(q1) = decod(f.ReadLine)
                                Next
                            Next
                            a15 = a15 + k
                        End If
                        If (My.Computer.FileSystem.FileExists(sd + "6.txt")) And (CheckBox14.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "6.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a21(k + a20)
                            For q As Integer = 1 To k
                                a21(q + a20).a24 = Int(decod(f.ReadLine))
                                ReDim Preserve a21(q + a20).a22(a21(q + a20).a24), a21(q + a20).a23(a21(q + a20).a24)
                                For q1 As Integer = 1 To a21(q + a20).a24
                                    a21(q + a20).a22(q1) = decod(f.ReadLine)
                                Next
                                For q1 As Integer = 1 To a21(q + a20).a24
                                    a21(q + a20).a23(q1) = decod(f.ReadLine)
                                Next
                            Next
                            a20 = a20 + k
                        End If
                        If (My.Computer.FileSystem.FileExists(sd + "7.txt")) And (CheckBox9.Checked = True) Then
                            f = My.Computer.FileSystem.OpenTextFileReader(sd + "7.txt")
                            k = Int(decod(f.ReadLine))
                            ReDim Preserve a26(k + a25)
                            For q As Integer = 1 To k
                                a26(q + a25).a27 = Int(decod(f.ReadLine))
                                ReDim Preserve a26(q + a25).a28(a26(q + a25).a27)
                                For q1 As Integer = 1 To a26(q + a25).a27
                                    a26(q + a25).a28(q1) = decod(f.ReadLine)
                                Next
                                a26(q + a25).a30 = Int(decod(f.ReadLine))
                                ReDim Preserve a26(q + a25).a29(a26(q + a25).a30)
                                For q1 As Integer = 1 To a26(q + a25).a30
                                    a26(q + a25).a29(q1) = decod(f.ReadLine)
                                Next
                            Next
                            a25 = a25 + k
                        End If
                    End If
                Next
            End If
        Next
        Dim n1, n2 As Integer
        Randomize()
        If (My.Computer.FileSystem.DirectoryExists(System.IO.Directory.GetCurrentDirectory + "\teste")) = False Then
            My.Computer.FileSystem.CreateDirectory(System.IO.Directory.GetCurrentDirectory + "\teste")
        End If
        For z As Integer = 1 To nt
            If a0 > 1 Then
                For p As Integer = 1 To a0 * a0
                    n1 = CInt(Math.Floor((a0 - 1 + 1) * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor((a0 - 1 + 1) * Rnd())) + 1
                    End While
                    a1(0) = a1(n1)
                    a1(n1) = a1(n2)
                    a1(n2) = a1(0)
                    a2(0) = a2(n1)
                    a2(n1) = a2(n2)
                    a2(n2) = a2(0)
                Next
            End If
            If a3 > 1 Then
                For p As Integer = 1 To a3 * a3
                    n1 = CInt(Math.Floor(a3 * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor(a3 * Rnd())) + 1
                    End While
                    a31(0) = a31(n1)
                    a31(n1) = a31(n2)
                    a31(n2) = a31(0)
                    a4(0) = a4(n1)
                    a4(n1) = a4(n2)
                    a4(n2) = a4(0)
                Next
            End If
            If a8 > 1 Then
                For p As Integer = 1 To a8 * a8
                    n1 = CInt(Math.Floor(a8 * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor(a8 * Rnd())) + 1
                    End While
                    a9(0) = a9(n1)
                    a9(n1) = a9(n2)
                    a9(n2) = a9(0)
                    a10(0) = a10(n1)
                    a10(n1) = a10(n2)
                    a10(n2) = a10(0)
                Next
            End If
            If a11 > 1 Then
                For p As Integer = 1 To a11 * a11
                    n1 = CInt(Math.Floor(a11 * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor(a11 * Rnd())) + 1
                    End While
                    a12(0) = a12(n1)
                    a12(n1) = a12(n2)
                    a12(n2) = a12(0)
                    a13(0) = a13(n1)
                    a13(n1) = a13(n2)
                    a13(n2) = a13(0)
                    a14(0) = a14(n1)
                    a14(n1) = a14(n2)
                    a14(n2) = a14(0)
                Next
            End If
            If a15 > 1 Then
                For p As Integer = 1 To a15 * a15
                    n1 = CInt(Math.Floor(a15 * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor(a15 * Rnd())) + 1
                    End While
                    a16(0) = a16(n1)
                    a16(n1) = a16(n2)
                    a16(n2) = a16(0)
                    a17(0) = a17(n1)
                    a17(n1) = a17(n2)
                    a17(n2) = a17(0)
                Next
            End If
            If a20 > 1 Then
                For p As Integer = 1 To a20 * a20
                    n1 = CInt(Math.Floor(a20 * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor(a20 * Rnd())) + 1
                    End While
                    a21(0) = a21(n1)
                    a21(n1) = a21(n2)
                    a21(n2) = a21(0)
                Next
            End If
            If a25 > 1 Then
                For p As Integer = 1 To a25 * a25
                    n1 = CInt(Math.Floor(a25 * Rnd())) + 1
                    n2 = n1
                    While n2 = n1
                        n2 = CInt(Math.Floor(a25 * Rnd())) + 1
                    End While
                    a26(0) = a26(n1)
                    a26(n1) = a26(n2)
                    a26(n2) = a26(0)
                Next
            End If
            cf = New System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory + "\teste" + nm())
            Dim j As Integer
            If CheckBox9.Checked Then
                cf.WriteLine(codif("1"))
                If n(1) >= a0 Then
                    cf.WriteLine(codif(Replace(Str(a0), " ", "")))
                    For j = 1 To a0
                        cf.WriteLine(codif(a1(j)))
                        cf.WriteLine(codif(a2(j)))
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(1)), " ", "")))
                    For j = 1 To n(1)
                        cf.WriteLine(codif(a1(j)))
                        cf.WriteLine(codif(a2(j)))
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            If CheckBox10.Checked Then
                cf.WriteLine(codif("1"))
                If n(2) >= a3 Then
                    cf.WriteLine(codif(Replace(Str(a3), " ", "")))
                    For j = 1 To a3
                        cf.WriteLine(codif(a31(j)))
                        cf.WriteLine(codif(a4(j).a7))
                        For j1 As Integer = 1 To a4(j).a7
                            cf.WriteLine(codif(a4(j).a5(j1)))
                            cf.WriteLine(codif(a4(j).a6(j1)))
                        Next
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(2)), " ", "")))
                    For j = 1 To n(2)
                        cf.WriteLine(codif(a31(j)))
                        cf.WriteLine(codif(a4(j).a7))
                        For j1 As Integer = 1 To a4(j).a7
                            cf.WriteLine(codif(a4(j).a5(j1)))
                            cf.WriteLine(codif(a4(j).a6(j1)))
                        Next
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            If CheckBox12.Checked Then
                cf.WriteLine(codif("1"))
                If n(3) >= a8 Then
                    cf.WriteLine(codif(Replace(Str(a8), " ", "")))
                    For j = 1 To a8
                        cf.WriteLine(codif(a9(j)))
                        cf.WriteLine(codif(a10(j)))
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(3)), " ", "")))
                    For j = 1 To n(3)
                        cf.WriteLine(codif(a9(j)))
                        cf.WriteLine(codif(a10(j)))
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            If CheckBox11.Checked Then
                cf.WriteLine(codif("1"))
                If n(4) >= a11 Then
                    cf.WriteLine(codif(Replace(Str(a11), " ", "")))
                    For j = 1 To a11
                        cf.WriteLine(codif(a12(j)))
                    Next
                    For j = 1 To a11
                        cf.WriteLine(codif(a13(j)))
                    Next
                    For j = 1 To a11
                        cf.WriteLine(codif(a14(j)))
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(4)), " ", "")))
                    For j = 1 To n(4)
                        cf.WriteLine(codif(a12(j)))
                    Next
                    For j = 1 To n(4)
                        cf.WriteLine(codif(a13(j)))
                    Next
                    For j = 1 To n(4)
                        cf.WriteLine(codif(a14(j)))
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            If CheckBox15.Checked Then
                cf.WriteLine(codif("1"))
                If n(5) >= a15 Then
                    cf.WriteLine(codif(Replace(Str(a15), " ", "")))
                    For j = 1 To a15
                        cf.WriteLine(codif(a16(j)))
                        cf.WriteLine(codif(a17(j).a19))
                        For j1 As Integer = 1 To a17(j).a19
                            cf.WriteLine(codif(a17(j).a18(j1)))
                        Next
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(5)), " ", "")))
                    For j = 1 To n(5)
                        cf.WriteLine(codif(a16(j)))
                        cf.WriteLine(codif(a17(j).a19))
                        For j1 As Integer = 1 To a17(j).a19
                            cf.WriteLine(codif(a17(j).a18(j1)))
                        Next
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            If CheckBox14.Checked Then
                cf.WriteLine(codif("1"))
                If n(6) >= a20 Then
                    cf.WriteLine(codif(Replace(Str(a20), " ", "")))
                    For j = 1 To a20
                        cf.WriteLine(codif(a21(j).a24))
                        For j1 As Integer = 1 To a21(j).a24
                            cf.WriteLine(codif(a21(j).a22(j1)))
                        Next
                        For j1 As Integer = 1 To a21(j).a24
                            cf.WriteLine(codif(a21(j).a23(j1)))
                        Next
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(6)), " ", "")))
                    For j = 1 To n(6)
                        cf.WriteLine(codif(a21(j).a24))
                        For j1 As Integer = 1 To a21(j).a24
                            cf.WriteLine(codif(a21(j).a22(j1)))
                        Next
                        For j1 As Integer = 1 To a21(j).a24
                            cf.WriteLine(codif(a21(j).a23(j1)))
                        Next
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            If CheckBox13.Checked Then
                cf.WriteLine(codif("1"))
                If n(7) >= a25 Then
                    cf.WriteLine(codif(Replace(Str(a25), " ", "")))
                    For j = 1 To a25
                        cf.WriteLine(codif(a26(j).a27))
                        For j1 As Integer = 1 To a26(j).a27
                            cf.WriteLine(codif(a26(j).a28(j1)))
                        Next
                        cf.WriteLine(codif(a26(j).a30))
                        For j1 As Integer = 1 To a26(j).a30
                            cf.WriteLine(codif(a26(j).a29(j1)))
                        Next
                    Next
                Else
                    cf.WriteLine(codif(Replace(Str(n(7)), " ", "")))
                    For j = 1 To n(7)
                        cf.WriteLine(codif(a26(j).a27))
                        For j1 As Integer = 1 To a26(j).a27
                            cf.WriteLine(codif(a26(j).a28(j1)))
                        Next
                        cf.WriteLine(codif(a26(j).a30))
                        For j1 As Integer = 1 To a26(j).a30
                            cf.WriteLine(codif(a26(j).a29(j1)))
                        Next
                    Next
                End If
            Else
                cf.WriteLine(codif("0"))
            End If
            cf.Close()
        Next
        Me.Cursor = Cursors.Default
        MsgBox("Au fost create " + nt.ToString + " teste!")
    End Sub
    Private Sub Teste_resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.Size.Width > GroupBox3.Size.Width Then
            Label7.Location = New Point(Int(Me.Size.Width / 2) - Int(Label7.Size.Width / 2), Label7.Location.Y)
            GroupBox3.Location = New Point(Int(Me.Size.Width / 2) - Int(GroupBox3.Size.Width / 2), GroupBox3.Location.Y)
            GroupBox2.Location = New Point(Int(Me.Size.Width / 2) - Int((GroupBox2.Size.Width + GroupBox1.Size.Width + 20) / 2), GroupBox2.Location.Y)
            Button2.Location = New Point(Int(Me.Size.Width / 2) - Int((Button2.Size.Width + Button1.Size.Width + Button3.Size.Width + 100) / 2), Button2.Location.Y)
        Else
            Label7.Location = New Point(10, Label7.Location.Y)
            GroupBox3.Location = New Point(10, GroupBox3.Location.Y)
            GroupBox2.Location = New Point(10, GroupBox2.Location.Y)
            Button2.Location = New Point(10, Button2.Location.Y)
        End If
        GroupBox1.Location = New Point(GroupBox2.Location.X + GroupBox2.Size.Width + 20, GroupBox1.Location.Y)
        Button1.Location = New Point(Button2.Size.Width + Button2.Location.X + 50, Button1.Location.Y)
        Button3.Location = New Point(Button1.Size.Width + Button1.Location.X + 50, Button1.Location.Y)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Principala.Show()
        Me.Close()
    End Sub
    Private Sub Teste_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        f = My.Computer.FileSystem.OpenTextFileReader(System.IO.Directory.GetCurrentDirectory + "\data\teme.txt")
        For i As Integer = 1 To f.ReadLine
            CheckedListBox1.Items.Add(f.ReadLine)
        Next
        f.Close()
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            For i As Integer = 0 To 116
                CheckedListBox1.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 0 To 116
                CheckedListBox1.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            For i As Integer = 0 To 33
                CheckedListBox1.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 0 To 33
                CheckedListBox1.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            For i As Integer = 34 To 80
                CheckedListBox1.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 34 To 80
                CheckedListBox1.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            For i As Integer = 81 To 116
                CheckedListBox1.SetItemChecked(i, True)
            Next
        Else
            For i As Integer = 81 To 116
                CheckedListBox1.SetItemChecked(i, False)
            Next
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class