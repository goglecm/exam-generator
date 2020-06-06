Public Class Testul
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
    Public Structure s5
        Public b6() As RadioButton
        Public b7 As Integer
    End Structure
    Public Function nm() As String
        Dim s As String
        Dim i As Integer
        s = ""
        i = 0
        While My.Computer.FileSystem.FileExists(System.IO.Directory.GetCurrentDirectory + "\testout_" + Replace(Str(i), " ", "") + ".txt") = True
            i = i + 1
        End While
        Return "\testout_" + Replace(Str(i), " ", "") + ".txt"
    End Function
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
    Public a1(), a31(), a9(), a10(), a12(), a13(), a16(), nume, prenume, clasa, indice As String
    Public a2(), a14(), a0, a3, a8, a11, a15, a20, a25, gd(), n(), t(), tn, nt, u, b0(7), v As Integer
    Public a4() As s1
    Public a17() As s2
    Public a21() As s3
    Public a26() As s4
    Public f As System.IO.StreamReader
    Public cf As System.IO.StreamWriter
    Public b1(7), b3(), b13, b14 As GroupBox
    Public b2() As CheckBox
    Public b4(), b8(), b10(), b11(), b131(), b16() As Label
    Public b9(), b141(), b15(), b17() As TextBox
    Public b12() As NumericUpDown
    Public b5() As s5
    Public q As Button
    Const c1 = 5, c2 = 30, c3 = 5, c4 = 5, c5 = 15, c6 = 20, c7 = 30, c8 = 75, c9 = 80, c10 = 270, c11 = 400, c12 = 150, c13 = 300, c14 = 14, c15 = 12
    Private Sub Testul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        f = My.Computer.FileSystem.OpenTextFileReader(Incepe.ffn)
        u = Label1.Location.Y + Label1.Size.Height + 50
        Dim s As String
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(1) = New GroupBox
            Me.Controls.Add(b1(1))
            b0(1) = 1
            b1(1).Text = "Alegeti variantele corecte"
            b1(1).Font = New Drawing.Font("Times New Roman", c15)
            b1(1).Location = New Point(10, u)
            a0 = Int(decod(f.ReadLine))
            ReDim a1(a0), a2(a0), b2(a0)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a0
                b2(i) = New CheckBox
                b1(1).Controls.Add(b2(i))
                b2(i).Location = New Point(c1, d)
                b2(i).AutoSize = True
                b2(i).Font = New Drawing.Font("Times New Roman", c14)
                a1(i) = decod(f.ReadLine)
                b2(i).Text = a1(i)
                If b2(i).Size.Width > m Then m = b2(i).Size.Width
                a2(i) = Int(decod(f.ReadLine))
                d = d + b2(i).Size.Height + c4
            Next
            b1(1).Size = New Point(m + c1 + c3, b2(a0).Location.Y + b2(a0).Size.Height + c5)
            u = u + b1(1).Size.Height + c6
        End If
        s = decod(f.ReadLine)
        If s = "1" Then
            a3 = Int(decod(f.ReadLine))
            b1(2) = New GroupBox
            Me.Controls.Add(b1(2))
            b0(2) = 1
            b1(2).Location = New Point(10, u)
            b1(2).Text = "Alegeti varianta potrivita"
            b1(2).Font = New Drawing.Font("Times New Roman", c15)
            ReDim a31(a3), a4(a3), b3(a3), b4(a3), b5(a3)
            Dim d As Integer = c2
            Dim w As Integer
            For i As Integer = 1 To a3
                a31(i) = decod(f.ReadLine)
                a4(i).a7 = Int(decod(f.ReadLine))
                b3(i) = New GroupBox
                b1(2).Controls.Add(b3(i))
                b3(i).Location = New Point(c1, d)
                ReDim a4(i).a5(a4(i).a7), a4(i).a6(a4(i).a7), b5(i).b6(a4(i).a7)
                Dim d1 As Integer = c2
                Dim m As Integer
                b4(i) = New Label
                b3(i).Controls.Add(b4(i))
                b4(i).Location = New Point(c1, d1)
                b4(i).AutoSize = True
                b4(i).Text = a31(i)
                b4(i).Font = New Drawing.Font("Times New Roman", c14)
                m = b4(i).Size.Width
                d1 = d1 + b4(i).Size.Height + c4
                a4(i).a5(1) = decod(f.ReadLine)
                a4(i).a6(1) = Int(decod(f.ReadLine))
                b5(i).b6(1) = New RadioButton
                b3(i).Controls.Add(b5(i).b6(1))
                b5(i).b6(1).Location = New Point(c1, d1)
                b5(i).b6(1).AutoSize = True
                b5(i).b6(1).Text = a4(i).a5(1)
                b5(i).b6(1).Font = New Drawing.Font("Times New Roman", c14)
                b5(i).b6(1).Checked = True
                If b5(i).b6(1).Size.Width > m Then m = b5(i).b6(1).Size.Width
                d1 = d1 + b5(i).b6(1).Size.Height + c4
                For i1 As Integer = 2 To a4(i).a7
                    a4(i).a5(i1) = decod(f.ReadLine)
                    a4(i).a6(i1) = Int(decod(f.ReadLine))
                    b5(i).b6(i1) = New RadioButton
                    b3(i).Controls.Add(b5(i).b6(i1))
                    b5(i).b6(i1).Location = New Point(c1, d1)
                    b5(i).b6(i1).AutoSize = True
                    b5(i).b6(i1).Text = a4(i).a5(i1)
                    b5(i).b6(i1).Font = New Drawing.Font("Times New Roman", c14)
                    If b5(i).b6(i1).Size.Width > m Then m = b5(i).b6(i1).Size.Width
                    d1 = d1 + b5(i).b6(i1).Size.Height + c4
                Next
                b3(i).Size = New Point(c1 + m + c3, b5(i).b6(a4(i).a7).Location.Y + b5(i).b6(a4(i).a7).Size.Height + c5)
                If b3(i).Size.Width > w Then w = b3(i).Size.Width
                d = d + b3(i).Size.Height + c6
            Next
            b1(2).Size = New Point(w + c1 + c3, b3(a3).Location.Y + b3(a3).Size.Height + c5)
            u = u + b1(2).Size.Height + c6
        End If
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(3) = New GroupBox
            Me.Controls.Add(b1(3))
            b0(3) = 1
            b1(3).Location = New Point(10, u)
            b1(3).Text = "Calculati"
            b1(3).Font = New Drawing.Font("Times New Roman", c15)
            a8 = Int(decod(f.ReadLine))
            ReDim a9(a8), a10(a8), b8(a8), b9(a8)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a8
                a9(i) = decod(f.ReadLine)
                a10(i) = decod(f.ReadLine)
                b8(i) = New Label
                b1(3).Controls.Add(b8(i))
                b8(i).AutoSize = True
                b8(i).Text = a9(i)
                b8(i).Font = New Drawing.Font("Times New Roman", c14)
                b9(i) = New TextBox
                b1(3).Controls.Add(b9(i))
                b9(i).Size = New Point(c8, c7)
                b9(i).Font = New Drawing.Font("Times New Roman", c14)
                If b8(i).Size.Width > m Then m = b8(i).Size.Width
                b9(i).Location = New Point(10, d + b9(i).Size.Height + c4)
                d = d + b9(i).Size.Height + c4
            Next
            For i As Integer = 1 To a8
                b9(i).Location = New Point(c1 + m + c4, b9(i).Location.Y)
                b8(i).Location = New Point(c1, b9(i).Location.Y + Int(b9(i).Size.Height / 4))
            Next
            b1(3).Size = New Point(b9(a8).Location.X + b9(a8).Size.Width + c3, b9(a8).Location.Y + b9(a8).Size.Height + c5)
            u = u + b1(3).Size.Height + c6
        End If
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(4) = New GroupBox
            Me.Controls.Add(b1(4))
            b0(4) = 1
            b1(4).Location = New Point(10, u)
            b1(4).Text = "Asociati A cu B"
            b1(4).Font = New Drawing.Font("Times New Roman", c15)
            b13 = New GroupBox
            b1(4).Controls.Add(b13)
            b13.Location = New Point(c1, c2)
            b13.Text = "A"
            b13.Font = New Drawing.Font("Times New Roman", c14)
            b14 = New GroupBox
            b1(4).Controls.Add(b14)
            b14.Text = "B"
            b14.Font = New Drawing.Font("Times New Roman", c14)
            a11 = Int(decod(f.ReadLine))
            ReDim a12(a11), a13(a11), a14(a11), b10(a11), b11(a11), b12(a11)
            Dim m As Integer
            For i As Integer = 1 To a11
                a12(i) = decod(f.ReadLine)
                b10(i) = New Label
                b13.Controls.Add(b10(i))
                b10(i).Text = a12(i)
                b10(i).AutoSize = True
                b10(i).Font = New Drawing.Font("Times New Roman", c14)
                If b10(i).Size.Width > m Then m = b10(i).Size.Width
            Next
            b13.Size = New Point(c1 + m + c3, 10)
            Dim d As Integer = c2
            m = 0
            For i As Integer = 1 To a11
                a13(i) = decod(f.ReadLine)
                b11(i) = New Label
                b14.Controls.Add(b11(i))
                b11(i).Text = a13(i)
                b11(i).AutoSize = True
                b11(i).Font = New Drawing.Font("Times New Roman", c14)
                b12(i) = New NumericUpDown
                b14.Controls.Add(b12(i))
                b12(i).Size = New Point(c9, c7)
                b12(i).Location = New Point(c1, d)
                b12(i).Maximum = a11
                b12(i).Font = New Drawing.Font("Times New Roman", c14)
                b12(i).Minimum = 1
                b12(i).Value = 1
                b11(i).Location = New Point(b12(i).Location.X + b12(i).Size.Width + c4, b12(i).Location.Y + Int(b12(i).Size.Height / 4))
                b10(i).Location = New Point(c1, b12(i).Location.Y + Int(b12(i).Size.Height / 4))
                If b11(i).Size.Width > m Then m = b11(i).Size.Width
                d = b12(i).Size.Height + d + c4
            Next
            b14.Location = New Point(b13.Location.X + c1 + b13.Size.Width + c4, c2)
            b14.Size = New Point(c1 + b12(a11).Size.Width + c4 + m + c3, b12(a11).Location.Y + b12(a11).Size.Height + c5)
            b13.Size = New Point(b13.Size.Width, b14.Size.Height)
            For i As Integer = 1 To a11
                a14(i) = Int(decod(f.ReadLine))
            Next
            b1(4).Size = New Point(b14.Location.X + b14.Size.Width + c3, b14.Location.Y + b14.Size.Height + c5)
            u = u + b1(4).Size.Height + c6
        End If
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(5) = New GroupBox
            Me.Controls.Add(b1(5))
            b0(5) = 1
            b1(5).Location = New Point(10, u)
            b1(5).Text = "Dati exemple"
            b1(5).Font = New Drawing.Font("Times New Roman", c15)
            a15 = Int(decod(f.ReadLine))
            ReDim a16(a15), a17(a15), b131(a15), b141(a15)
            Dim d As Integer = c2
            Dim m As Integer = c10
            For i As Integer = 1 To a15
                a16(i) = decod(f.ReadLine)
                b131(i) = New Label
                b1(5).Controls.Add(b131(i))
                b131(i).Location = New Point(c1, d)
                b131(i).AutoSize = True
                b131(i).Text = a16(i)
                b131(i).Font = New Drawing.Font("Times New Roman", c14)
                If b131(i).Size.Width > m Then m = b131(i).Size.Width
                d = d + c4 + b131(i).Size.Height
                b141(i) = New TextBox
                b1(5).Controls.Add(b141(i))
                b141(i).Location = New Point(c1, d)
                b141(i).Size = New Point(c10, c7)
                b141(i).Font = New Drawing.Font("Times New Roman", c14)
                d = d + c4 + b141(i).Size.Height
                a17(i).a19 = Int(decod(f.ReadLine))
                ReDim a17(i).a18(a17(i).a19)
                For i1 As Integer = 1 To a17(i).a19
                    a17(i).a18(i1) = decod(f.ReadLine)
                Next
            Next
            b1(5).Size = New Point(m + c1 + c3, b141(a15).Location.Y + b141(a15).Size.Height + c5)
            u = u + b1(5).Size.Height + c6
        End If
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(6) = New GroupBox
            Me.Controls.Add(b1(6))
            b0(6) = 1
            b1(6).Location = New Point(10, u)
            b1(6).Text = "Corecteaza"
            b1(6).Font = New Drawing.Font("Times New Roman", c15)
            a20 = Int(decod(f.ReadLine))
            ReDim a21(a20), b15(a20)
            Dim d As Integer = c2
            For i As Integer = 1 To a20
                a21(i).a24 = Int(decod(f.ReadLine))
                b15(i) = New TextBox
                b1(6).Controls.Add(b15(i))
                b15(i).Font = New Drawing.Font("Times New Roman", c14)
                b15(i).Multiline = True
                b15(i).Size = New Point(c11, c12)
                b15(i).Location = New Point(c1, d)
                d = d + c4 + b15(i).Size.Height
                ReDim a21(i).a22(a21(i).a24), a21(i).a23(a21(i).a24)
                For i1 As Integer = 1 To a21(i).a24
                    a21(i).a22(i1) = decod(f.ReadLine)
                    b15(i).Text = b15(i).Text + a21(i).a22(i1)
                    If i1 <> a21(i).a24 Then b15(i).Text = b15(i).Text + Environment.NewLine
                Next
                For i1 As Integer = 1 To a21(i).a24
                    a21(i).a23(i1) = decod(f.ReadLine)
                Next
                d = d + 20
            Next
            b1(6).Size = New Point(b15(a20).Size.Width + c3 + c1, b15(a20).Location.Y + c5 + b15(a20).Size.Height)
            u = u + b1(6).Size.Height + c6
        End If
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(7) = New GroupBox
            Me.Controls.Add(b1(7))
            b0(7) = 1
            b1(7).Location = New Point(10, u)
            b1(7).Text = "Ce va afisa?"
            b1(7).Font = New Drawing.Font("Times New Roman", c15)
            a25 = Int(decod(f.ReadLine))
            ReDim a26(a25), b16(a25), b17(a25)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a25
                a26(i).a27 = Int(decod(f.ReadLine))
                b16(i) = New Label
                b1(7).Controls.Add(b16(i))
                b16(i).Location = New Point(c1, d)
                b16(i).AutoSize = True
                b16(i).Font = New Drawing.Font("Times New Roman", c14)
                b17(i) = New TextBox
                b1(7).Controls.Add(b17(i))
                b17(i).Text = "Aici se scrie raspunsul..."
                b17(i).Multiline = True
                b17(i).Font = New Drawing.Font("Times New Roman", c14)
                ReDim a26(i).a28(a26(i).a27)
                For i1 As Integer = 1 To a26(i).a27
                    a26(i).a28(i1) = decod(f.ReadLine)
                    b16(i).Text = b16(i).Text + a26(i).a28(i1)
                    If i1 <> a26(i).a27 Then b16(i).Text = b16(i).Text + Environment.NewLine
                Next
                b17(i).Size = New Point(c13, b16(i).Size.Height)
                b17(i).Location = New Point(b16(i).Location.X + b16(i).Size.Width + c4, b16(i).Location.Y)
                If m < b17(i).Location.X + b17(i).Size.Width Then m = b17(i).Location.X + b17(i).Size.Width
                a26(i).a30 = Int(decod(f.ReadLine))
                d = d + b16(i).Size.Height + c4
                ReDim a26(i).a29(a26(i).a30)
                For i1 As Integer = 1 To a26(i).a30
                    a26(i).a29(i1) = decod(f.ReadLine)
                Next
                d = d + 20
            Next
            b1(7).Size = New Point(m + c3, b17(a25).Location.Y + b17(a25).Size.Height + c5)
            u = u + b1(7).Size.Height + c6
        End If
        q = New Button
        Me.Controls.Add(q)
        AddHandler q.Click, AddressOf q_Click
        q.Font = New Drawing.Font("Times New Roman", 16)
        q.Size = New Point(300, 100)
        q.Text = "Finisare"
        q.Location = New Point(10, u)
        For i As Integer = 1 To 7
            If b0(i) = 1 Then
                If Me.Size.Width > b1(i).Size.Width Then
                    b1(i).Location = New Point(Int(Me.Size.Width / 2) - Int(b1(i).Size.Width / 2), b1(i).Location.Y)
                Else
                    b1(i).Location = New Point(c1, b1(i).Location.Y)
                End If
                'b1(i).BackColor = Color.FromArgb(6, 0, 0, 0)
            End If
        Next
        Label1.Location = New Point(Int(Me.Size.Width / 2) - Int(Label1.Size.Width / 2), Label1.Location.Y)
        v = 1
        q.Location = New Point(Int(Me.Size.Width / 2) - Int(q.Size.Width / 2), q.Location.Y)
        f.Close()
    End Sub
    Private Sub Testul_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For i As Integer = 1 To 7
            If b0(i) = 1 Then b1(i).Location = New Point(Int(Me.Size.Width / 2) - Int(b1(i).Size.Width / 2), b1(i).Location.Y)
        Next
        Label1.Location = New Point(Int(Me.Size.Width / 2) - Int(Label1.Size.Width / 2), Label1.Location.Y)
        If v = 1 Then q.Location = New Point(Int(Me.Size.Width / 2) - Int(q.Size.Width / 2), q.Location.Y)
    End Sub
    Private Sub q_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If b0(6) = 1 Then
            For i As Integer = 1 To a20
                If b15(i).Lines.Count <> a21(i).a24 Then
                    MsgBox("La itemul 'Corecteaza' exemplul " + i.ToString + " nu are numarul de randuri corecte!")
                    Exit Sub
                End If
            Next
        End If
        cf = New System.IO.StreamWriter(System.IO.Directory.GetCurrentDirectory + nm())
        cf.WriteLine(codif(nume))
        cf.WriteLine(codif(prenume))
        cf.WriteLine(codif(clasa))
        cf.WriteLine(codif(indice))
        If b0(1) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a0))
            For i As Integer = 1 To a0
                cf.WriteLine(codif(a1(i)))
                If b2(i).Checked Then cf.WriteLine(codif("1")) Else cf.WriteLine(codif("0"))
                cf.WriteLine(codif(a2(i)))
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        If b0(2) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a3))
            For i As Integer = 1 To a3
                cf.WriteLine(codif(a31(i)))
                For i1 = 1 To a4(i).a7
                    If b5(i).b6(i1).Checked = True Then cf.WriteLine(codif(i1))
                Next
                cf.WriteLine(codif(a4(i).a7))
                For i1 As Integer = 1 To a4(i).a7
                    cf.WriteLine(codif(a4(i).a5(i1)))
                    cf.WriteLine(codif(a4(i).a6(i1)))
                Next
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        If b0(3) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a8))
            For i As Integer = 1 To a8
                cf.WriteLine(codif(a9(i)))
                cf.WriteLine(codif(b9(i).Text))
                cf.WriteLine(codif(a10(i)))
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        If b0(4) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a11))
            For i As Integer = 1 To a11
                cf.WriteLine(codif(a12(i)))
            Next
            For i As Integer = 1 To a11
                cf.WriteLine(codif(a13(i)))
            Next
            For i As Integer = 1 To a11
                cf.WriteLine(codif(b12(i).Value))
            Next
            For i As Integer = 1 To a11
                cf.WriteLine(codif(a14(i)))
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        If b0(5) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a15))
            For i As Integer = 1 To a15
                cf.WriteLine(codif(a16(i)))
                cf.WriteLine(codif(b141(i).Text))
                cf.WriteLine(codif(a17(i).a19))
                For i1 As Integer = 1 To a17(i).a19
                    cf.WriteLine(codif(a17(i).a18(i1)))
                Next
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        If b0(6) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a20))
            For i As Integer = 1 To a20
                cf.WriteLine(codif(a21(i).a24))
                cf.WriteLine(codif(b15(i).Text))
                For i1 As Integer = 1 To a21(i).a24
                    cf.WriteLine(codif(a21(i).a22(i1)))
                Next
                For i1 As Integer = 1 To a21(i).a24
                    cf.WriteLine(codif(a21(i).a23(i1)))
                Next
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        If b0(7) = 1 Then
            cf.WriteLine(codif("1"))
            cf.WriteLine(codif(a25))
            For i As Integer = 1 To a25
                cf.WriteLine(codif(b17(i).Lines.Count.ToString))
                cf.WriteLine(codif(b17(i).Text))
                cf.WriteLine(codif(a26(i).a27))
                For i1 As Integer = 1 To a26(i).a27
                    cf.WriteLine(codif(a26(i).a28(i1)))
                Next
                cf.WriteLine(codif(a26(i).a30))
                For i1 As Integer = 1 To a26(i).a30
                    cf.WriteLine(codif(a26(i).a29(i1)))
                Next
            Next
        Else
            cf.WriteLine(codif("0"))
        End If
        cf.Close()
        MsgBox("Testul a fost finisat cu succes!")
        End
    End Sub
End Class