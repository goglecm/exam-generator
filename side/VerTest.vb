Public Class VerTest
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
    Public Structure s6
        Public c117() As String
    End Structure
    Public Structure s7
        Public c119() As String
        Public c1110 As Integer
    End Structure
    Public a1(), a31(), a9(), a10(), a12(), a13(), a16(), c113(), c115() As String
    Public a2(), a14(), a0, a3, a8, a11, a15, a20, a25, gd(), n(), t(), tn, nt, u, b0(7), v, c111(), c112(), c114(), tot, acm As Integer
    Public a4() As s1
    Public a17() As s2
    Public a21() As s3
    Public a26() As s4
    Public f As System.IO.StreamReader
    Public cf As System.IO.StreamWriter
    Public b1(7), b3(), b13, b14 As GroupBox
    Public b2() As CheckBox
    Public b17(), b15(), b141(), b12(), b9(), b4(), b8(), b10(), b11(), b131(), b16(), d1(), d2(), d3(), d4(), d5(), d6(), d7(), d8(), d9(), d10(), d11(), d12(), d13(), ttt, acc, nota, dts(3) As Label
    Public b5() As s5
    Public c116() As s6
    Public c118() As s7
    Public q As Button
    Const c1 = 5, c2 = 30, c3 = 5, c4 = 5, c5 = 15, c6 = 20, c7 = 30, c8 = 75, c9 = 80, c10 = 270, c11 = 400, c12 = 150, c13 = 300, c14 = 14, c15 = 12, c97 = 5
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
    Private Sub VerTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        f = My.Computer.FileSystem.OpenTextFileReader(Verificare.ffn)
        Dim s As String
        dts(0) = New Label
        dts(1) = New Label
        dts(2) = New Label
        dts(3) = New Label
        Me.Controls.Add(dts(0))
        Me.Controls.Add(dts(1))
        Me.Controls.Add(dts(2))
        Me.Controls.Add(dts(3))
        dts(0).AutoSize = True
        dts(1).AutoSize = True
        dts(2).AutoSize = True
        dts(3).AutoSize = True
        dts(0).Font = New Drawing.Font("Times New Roman", c14)
        dts(1).Font = New Drawing.Font("Times New Roman", c14)
        dts(2).Font = New Drawing.Font("Times New Roman", c14)
        dts(3).Font = New Drawing.Font("Times New Roman", c14)
        s = decod(f.ReadLine)
        If s = String.Empty Then dts(0).Text = "Numele nu a fost stabilit" Else dts(0).Text = "Numele " + s
        s = decod(f.ReadLine)
        If s = String.Empty Then dts(1).Text = "Prenumele nu a fost stabilit" Else dts(1).Text = "Preumele " + s
        dts(2).Text = "Clasa: " + decod(f.ReadLine)
        dts(3).Text = "Indicele clasei: " + decod(f.ReadLine)
        dts(0).Location = New Point(10, 10)
        dts(1).Location = New Point(10, dts(0).Location.Y + dts(0).Size.Height + 10)
        dts(2).Location = New Point(10, dts(1).Location.Y + dts(1).Size.Height + 10)
        dts(3).Location = New Point(10, dts(2).Location.Y + dts(2).Size.Height + 10)
        Label1.Location = New Point(10, 10 + dts(3).Location.Y)
        u = Label1.Location.Y + Label1.Size.Height + 50
        s = decod(f.ReadLine)
        If s = "1" Then
            b1(1) = New GroupBox
            Me.Controls.Add(b1(1))
            b0(1) = 1
            b1(1).Text = "Alegeti variantele corecte"
            b1(1).Font = New Drawing.Font("Times New Roman", c15)
            b1(1).Location = New Point(10, u)
            a0 = Int(decod(f.ReadLine))
            ReDim a1(a0), a2(a0), b2(a0), c111(a0), d1(a0)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a0
                d1(i) = New Label
                b1(1).Controls.Add(d1(i))
                d1(i).Location = New Point(c1, d)
                d1(i).AutoSize = True
                d1(i).Font = New Drawing.Font("Times New Roman", c14)
                b2(i) = New CheckBox
                b1(1).Controls.Add(b2(i))
                b2(i).AutoSize = True
                b2(i).Enabled = False
                b2(i).Font = New Drawing.Font("Times New Roman", c14)
                a1(i) = decod(f.ReadLine)
                b2(i).Text = a1(i)
                c111(i) = Int(decod(f.ReadLine))
                a2(i) = Int(decod(f.ReadLine))
                If c111(i) = "1" Then b2(i).Checked = True
                If c111(i) = a2(i) Then
                    d1(i).Text = "+1"
                    d1(i).ForeColor = Color.LimeGreen
                    tot = tot + 1
                    acm = acm + 1
                Else
                    d1(i).Text = "+0"
                    d1(i).ForeColor = Color.Red
                    tot = tot + 1
                End If
                b2(i).Location = New Point(d1(i).Location.X + d1(i).Size.Width + c97, d)
                If b2(i).Size.Width + b2(i).Location.X > m Then m = b2(i).Size.Width + b2(i).Location.X
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
            ReDim a31(a3), a4(a3), b3(a3), b4(a3), b5(a3), c112(a3), d2(a3)
            Dim d As Integer = c2
            Dim w As Integer
            For i As Integer = 1 To a3
                a31(i) = decod(f.ReadLine)
                c112(i) = Int(decod(f.ReadLine))
                a4(i).a7 = Int(decod(f.ReadLine))
                b3(i) = New GroupBox
                b1(2).Controls.Add(b3(i))
                b3(i).Location = New Point(c1, d)
                ReDim a4(i).a5(a4(i).a7), a4(i).a6(a4(i).a7), b5(i).b6(a4(i).a7)
                Dim d1 As Integer = c2
                Dim m As Integer
                b4(i) = New Label
                b3(i).Controls.Add(b4(i))
                b4(i).AutoSize = True
                b4(i).Text = a31(i)
                b4(i).Font = New Drawing.Font("Times New Roman", c14)
                d2(i) = New Label
                b3(i).Controls.Add(d2(i))
                d2(i).AutoSize = True
                d2(i).Location = New Point(c1, d1)
                d2(i).Font = New Drawing.Font("Times New Roman", c14)
                m = b4(i).Size.Width
                b4(i).Location = New Point(d2(i).Location.X + c97, d1)
                d1 = d1 + b4(i).Size.Height + c4
                Dim z As Integer
                For i1 As Integer = 1 To a4(i).a7
                    a4(i).a5(i1) = decod(f.ReadLine)
                    a4(i).a6(i1) = Int(decod(f.ReadLine))
                    If a4(i).a6(i1) = 1 Then z = i1
                    b5(i).b6(i1) = New RadioButton
                    b3(i).Controls.Add(b5(i).b6(i1))
                    b5(i).b6(i1).Enabled = False
                    b5(i).b6(i1).Location = New Point(c1, d1)
                    b5(i).b6(i1).AutoSize = True
                    b5(i).b6(i1).Text = a4(i).a5(i1)
                    b5(i).b6(i1).Font = New Drawing.Font("Times New Roman", c14)
                    If b5(i).b6(i1).Size.Width > m Then m = b5(i).b6(i1).Size.Width
                    d1 = d1 + b5(i).b6(i1).Size.Height + c4
                Next
                b5(i).b6(c112(i)).Checked = True
                If c112(i) = z Then
                    d2(i).Text = "+1"
                    tot = tot + 1
                    acm = acm + 1
                    d2(i).ForeColor = Color.LimeGreen
                    b5(i).b6(z).Font = New Drawing.Font("Times New Roman", c14, FontStyle.Underline)
                Else
                    d2(i).Text = "+0"
                    tot = tot + 1
                    d2(i).ForeColor = Color.Red
                    b5(i).b6(z).Font = New Drawing.Font("Times New Roman", c14, FontStyle.Underline)
                End If
                b4(i).Location = New Point(d2(i).Location.X + d2(i).Size.Width + c97, b4(i).Location.Y)
                b3(i).Size = New Point(c1 + d2(i).Size.Width + c97 + m + c3, b5(i).b6(a4(i).a7).Location.Y + b5(i).b6(a4(i).a7).Size.Height + c5)
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
            ReDim a9(a8), a10(a8), b8(a8), b9(a8), c113(a8), d3(a8), d4(a8)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a8
                a9(i) = decod(f.ReadLine)
                c113(i) = decod(f.ReadLine)
                a10(i) = decod(f.ReadLine)
                b8(i) = New Label
                b1(3).Controls.Add(b8(i))
                b8(i).AutoSize = True
                b8(i).Text = a9(i)
                b8(i).Font = New Drawing.Font("Times New Roman", c14)
                b9(i) = New Label
                b1(3).Controls.Add(b9(i))
                b9(i).AutoSize = True
                b9(i).Font = New Drawing.Font("Times New Roman", c14)
                b9(i).Text = c113(i)
                d3(i) = New Label
                b1(3).Controls.Add(d3(i))
                d3(i).AutoSize = True
                d3(i).Font = New Drawing.Font("Times New Roman", c14)
                If c113(i) = a10(i) Then
                    d3(i).ForeColor = Color.LimeGreen
                    d3(i).Text = "+1"
                    tot = tot + 1
                    acm = acm + 1
                    b9(i).ForeColor = Color.LimeGreen
                    d3(i).Location = New Point(c1, d)
                    b8(i).Location = New Point(d3(i).Location.X + d3(i).Size.Width + c97, d)
                    b9(i).Location = New Point(b8(i).Location.X + b8(i).Size.Width + c97, d)
                Else
                    d3(i).ForeColor = Color.Red
                    d3(i).Text = "+0"
                    tot = tot + 1
                    b9(i).ForeColor = Color.Red
                    d3(i).Location = New Point(c1, d)
                    b8(i).Location = New Point(d3(i).Location.X + d3(i).Size.Width + c97, d)
                    b9(i).Location = New Point(b8(i).Location.X + b8(i).Size.Width + c97, d)
                    d4(i) = New Label
                    b1(3).Controls.Add(d4(i))
                    d4(i).AutoSize = True
                    d4(i).Font = New Drawing.Font("Times New Roman", c14)
                    d4(i).Text = "(" + a10(i) + ")"
                    d4(i).ForeColor = Color.LimeGreen
                    d4(i).Location = New Point(b9(i).Location.X + b9(i).Size.Width + c97, d)
                    If d4(i).Location.X + d4(i).Size.Width > m Then m = d4(i).Location.X + d4(i).Size.Width
                End If
                If b9(i).Location.X + b9(i).Size.Width + c97 > m Then m = b9(i).Location.X + b9(i).Size.Width + c97
                d = d + b9(i).Size.Height + c4
            Next
            b1(3).Size = New Point(m + c1 + c3, b9(a8).Location.Y + b9(a8).Size.Height + c5)
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
            ReDim a12(a11), a13(a11), a14(a11), b10(a11), b11(a11), b12(a11), c114(a11), d5(a11), d12(a11)
            Dim m1, m2 As Integer
            For i As Integer = 1 To a11
                a12(i) = decod(f.ReadLine)
                b10(i) = New Label
                b13.Controls.Add(b10(i))
                b10(i).Text = a12(i)
                b10(i).AutoSize = True
                b10(i).Font = New Drawing.Font("Times New Roman", c14)
                d5(i) = New Label
                b13.Controls.Add(d5(i))
                d5(i).AutoSize = True
                d5(i).Font = New Drawing.Font("Times New Roman", c14)
            Next
            Dim d As Integer = c2
            For i As Integer = 1 To a11
                a13(i) = decod(f.ReadLine)
                b11(i) = New Label
                b14.Controls.Add(b11(i))
                b11(i).Text = a13(i)
                b11(i).AutoSize = True
                b11(i).Font = New Drawing.Font("Times New Roman", c14)
                b12(i) = New Label
                b14.Controls.Add(b12(i))
                b12(i).AutoSize = True
                b12(i).Font = New Drawing.Font("Times New Roman", c14)
            Next
            For i As Integer = 1 To a11
                c114(i) = Int(decod(f.ReadLine))
                b12(i).Text = c114(i)
            Next
            For i As Integer = 1 To a11
                a14(i) = Int(decod(f.ReadLine))
                If c114(i) = a14(i) Then
                    d5(i).Text = "+1"
                    tot = tot + 1
                    acm = acm + 1
                    d5(i).ForeColor = Color.LimeGreen
                    d5(i).Location = New Point(c1, d)
                    b10(i).Location = New Point(d5(i).Location.X + d5(i).Size.Width + c97, d)
                    b12(i).Location = New Point(c1, d)
                    b11(i).Location = New Point(b12(i).Location.X + b12(i).Size.Width + c97, d)
                    b12(i).ForeColor = Color.LimeGreen
                    If b10(i).Location.X + b10(i).Size.Width > m1 Then m1 = b10(i).Location.X + b10(i).Size.Width
                    If b11(i).Location.X + b11(i).Size.Width > m2 Then m2 = b11(i).Location.X + b11(i).Size.Width > m2
                    d = b12(i).Size.Height + d + c4
                Else
                    d5(i).Text = "+0"
                    tot = tot + 1
                    d5(i).ForeColor = Color.Red
                    d12(i) = New Label
                    b14.Controls.Add(d12(i))
                    d12(i).AutoSize = True
                    d12(i).Text = "(" + a14(i).ToString + ")"
                    d12(i).ForeColor = Color.LimeGreen
                    d12(i).Font = New Drawing.Font("Times New Roman", c14)
                    d5(i).Location = New Point(c1, d)
                    b10(i).Location = New Point(d5(i).Location.X + d5(i).Size.Width + c97, d)
                    b12(i).Location = New Point(c1, d)
                    b11(i).Location = New Point(b12(i).Location.X + b12(i).Size.Width + c97, d)
                    d12(i).Location = New Point(b11(i).Location.X + b11(i).Size.Width + c97, d)
                    b12(i).ForeColor = Color.Red
                    If b10(i).Location.X + b10(i).Size.Width > m1 Then m1 = b10(i).Location.X + b10(i).Size.Width
                    If d12(i).Location.X + d12(i).Size.Width > m2 Then m2 = d12(i).Location.X + d12(i).Size.Width
                    d = b12(i).Size.Height + d + c4
                End If
            Next
            b13.Size = New Point(m1 + c3, b10(a11).Location.Y + b10(a11).Size.Height + c5)
            b14.Size = New Point(m2 + c3, b13.Size.Height)
            b14.Location = New Point(b13.Location.X + b13.Size.Width + c3, b13.Location.Y)
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
            ReDim a16(a15), a17(a15), b131(a15), b141(a15), c115(a15), d6(a15), d7(a15)
            Dim d As Integer = c2
            Dim m As Integer = c10
            For i As Integer = 1 To a15
                a16(i) = decod(f.ReadLine)
                c115(i) = decod(f.ReadLine)
                b131(i) = New Label
                b1(5).Controls.Add(b131(i))
                b131(i).Location = New Point(c1, d)
                b131(i).AutoSize = True
                b131(i).Text = a16(i)
                b131(i).Font = New Drawing.Font("Times New Roman", c14)
                If b131(i).Size.Width > m Then m = b131(i).Size.Width
                d = d + c4 + b131(i).Size.Height
                b141(i) = New Label
                b1(5).Controls.Add(b141(i))
                b141(i).Location = New Point(c1, d)
                b141(i).AutoSize = True
                b141(i).Text = c115(i)
                b141(i).Font = New Drawing.Font("Times New Roman", c14)
                d = d + c4 + b141(i).Size.Height
                a17(i).a19 = Int(decod(f.ReadLine))
                Dim p As Boolean
                p = False
                ReDim a17(i).a18(a17(i).a19)
                For i1 As Integer = 1 To a17(i).a19
                    a17(i).a18(i1) = decod(f.ReadLine)
                    If c115(i) = a17(i).a18(i1) Then p = True
                Next
                d6(i) = New Label
                b1(5).Controls.Add(d6(i))
                d6(i).AutoSize = True
                d6(i).Font = New Drawing.Font("Times New Roman", c14)
                If p = True Then
                    b141(i).ForeColor = Color.LimeGreen
                    d6(i).Text = "+1"
                    tot = tot + 1
                    acm = acm + 1
                    d6(i).ForeColor = Color.LimeGreen
                    d6(i).Location = b131(i).Location
                    b131(i).Location = New Point(b131(i).Location.X + d6(i).Size.Width + c97, b131(i).Location.Y)
                Else
                    b141(i).ForeColor = Color.Red
                    d6(i).Text = "+0"
                    tot = tot + 1
                    d6(i).ForeColor = Color.Red
                    d6(i).Location = b131(i).Location
                    b131(i).Location = New Point(b131(i).Location.X + d6(i).Size.Width + c97, b131(i).Location.Y)
                    d7(i) = New Label
                    b1(5).Controls.Add(d7(i))
                    d7(i).AutoSize = True
                    d7(i).Font = New Drawing.Font("Times New Roman", c14)
                    d7(i).ForeColor = Color.LimeGreen
                    Randomize()
                    d7(i).Text = "(" + a17(i).a18(Int((a17(i).a19 * Rnd()) + 1)) + ")"
                    d7(i).Location = New Point(b141(i).Location.X + b141(i).Size.Width + c97, b141(i).Location.Y)
                End If
            Next
            b1(5).Size = New Point(d6(a15).Size.Width + m + c97 + c1 + c3, b141(a15).Location.Y + b141(a15).Size.Height + c5)
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
            ReDim a21(a20), b15(a20), c116(a20), d8(a20), d9(a20), d13(a20)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a20
                a21(i).a24 = Int(decod(f.ReadLine))
                b15(i) = New Label
                b1(6).Controls.Add(b15(i))
                b15(i).Font = New Drawing.Font("Times New Roman", c14)
                b15(i).AutoSize = True
                d8(i) = New Label
                b1(6).Controls.Add(d8(i))
                d8(i).AutoSize = True
                d8(i).Font = New Drawing.Font("Times New Roman", c14)
                d8(i).Location = New Point(c1, d)
                d13(i) = New Label
                b1(6).Controls.Add(d13(i))
                d13(i).AutoSize = True
                d13(i).Font = New Drawing.Font("Times New Roman", c14)
                ReDim a21(i).a22(a21(i).a24), a21(i).a23(a21(i).a24), c116(i).c117(a21(i).a24)
                For i1 As Integer = 1 To a21(i).a24
                    c116(i).c117(i1) = decod(f.ReadLine)
                    d13(i).Text = d13(i).Text + c116(i).c117(i1)
                    If i1 <> a21(i).a24 Then d13(i).Text = d13(i).Text + Environment.NewLine
                Next
                If d13(i).Size.Width > m Then m = d13(i).Size.Width
                For i1 As Integer = 1 To a21(i).a24
                    a21(i).a22(i1) = decod(f.ReadLine)
                    b15(i).Text = b15(i).Text + a21(i).a22(i1)
                    If i1 <> a21(i).a24 Then b15(i).Text = b15(i).Text + Environment.NewLine
                Next
                If b15(i).Size.Width > m Then m = b15(i).Size.Width
                Dim g As Boolean
                g = True
                For i1 As Integer = 1 To a21(i).a24
                    a21(i).a23(i1) = decod(f.ReadLine)
                    If a21(i).a23(i1) <> c116(i).c117(i1) Then g = False
                Next
                If g = True Then
                    d8(i).Text = "+2"
                    tot = tot + 2
                    acm = acm + 2
                    d8(i).ForeColor = Color.LimeGreen
                    d13(i).ForeColor = Color.LimeGreen
                    b15(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + c4 + b15(i).Size.Height
                    d13(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + c4 + d13(i).Size.Height
                Else
                    d8(i).Text = "+0"
                    tot = tot + 2
                    d8(i).ForeColor = Color.Red
                    d13(i).ForeColor = Color.Red
                    b15(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + c4 + b15(i).Size.Height
                    d13(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + c4 + d13(i).Size.Height
                    d9(i) = New Label
                    b1(6).Controls.Add(d9(i))
                    d9(i).AutoSize = True
                    d9(i).Font = New Drawing.Font("Times New Roman", c14)
                    For i1 As Integer = 1 To a21(i).a24
                        d9(i).Text = d9(i).Text + a21(i).a23(i1)
                        If i1 <> a21(i).a24 Then d9(i).Text = d9(i).Text + Environment.NewLine
                    Next
                    d9(i).ForeColor = Color.LimeGreen
                    d9(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    If d9(i).Size.Width > m Then m = d9(i).Size.Width
                    d = d + c4 + d9(i).Size.Height
                End If
                d = d + 20
            Next
            b1(6).Size = New Point(m + c3 + c1 + d8(1).Size.Width + c97, c5 + d)
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
            ReDim a26(a25), b16(a25), b17(a25), c118(a25), d10(a25), d11(a25)
            Dim d As Integer = c2
            Dim m As Integer
            For i As Integer = 1 To a25
                c118(i).c1110 = Int(decod(f.ReadLine))
                b16(i) = New Label
                b1(7).Controls.Add(b16(i))
                b16(i).AutoSize = True
                b16(i).Font = New Drawing.Font("Times New Roman", c14)
                b17(i) = New Label
                b1(7).Controls.Add(b17(i))
                b17(i).Font = New Drawing.Font("Times New Roman", c14)
                b17(i).AutoSize = True
                ReDim c118(i).c119(c118(i).c1110)
                For i1 As Integer = 1 To c118(i).c1110
                    c118(i).c119(i1) = decod(f.ReadLine)
                    b17(i).Text = b17(i).Text + c118(i).c119(i1)
                    If i1 <> c118(i).c1110 Then b17(i).Text = b17(i).Text + Environment.NewLine
                Next
                If b17(i).Size.Width > m Then m = b17(i).Size.Width
                a26(i).a27 = Int(decod(f.ReadLine))
                ReDim a26(i).a28(a26(i).a27)
                For i1 As Integer = 1 To a26(i).a27
                    a26(i).a28(i1) = decod(f.ReadLine)
                    b16(i).Text = b16(i).Text + a26(i).a28(i1)
                    If i1 <> a26(i).a27 Then b16(i).Text = b16(i).Text + Environment.NewLine
                Next
                If b16(i).Size.Width > m Then m = b16(i).Size.Width
                a26(i).a30 = Int(decod(f.ReadLine))
                ReDim a26(i).a29(a26(i).a30)
                Dim g As Boolean
                g = True
                For i1 As Integer = 1 To a26(i).a30
                    a26(i).a29(i1) = decod(f.ReadLine)
                    If a26(i).a30 = c118(i).c1110 Then
                        If c118(i).c119(i1) <> a26(i).a29(i1) Then g = False
                    Else
                        g = False
                    End If
                Next
                d8(i) = New Label
                b1(7).Controls.Add(d8(i))
                d8(i).AutoSize = True
                d8(i).Font = New Drawing.Font("Times New Roman", c14)
                d8(i).Location = New Point(c1, d)
                If g = True Then
                    d8(i).Text = "+2"
                    tot = tot + 2
                    acm = acm + 2
                    d8(i).ForeColor = Color.LimeGreen
                    b17(i).ForeColor = Color.LimeGreen
                    b16(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + b16(i).Size.Height + c4
                    b17(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + b17(i).Size.Height + c4
                Else
                    d8(i).Text = "+0"
                    tot = tot + 2
                    d8(i).ForeColor = Color.Red
                    b17(i).ForeColor = Color.Red
                    b16(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + b16(i).Size.Height + c4
                    b17(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d = d + b17(i).Size.Height + c4
                    d11(i) = New Label
                    b1(7).Controls.Add(d11(i))
                    d11(i).AutoSize = True
                    For i1 As Integer = 1 To a26(i).a30
                        d11(i).Text = d11(i).Text + a26(i).a29(i1)
                        If i1 <> a26(i).a30 Then d11(i).Text = d11(i).Text + Environment.NewLine
                    Next
                    d11(i).Location = New Point(d8(i).Location.X + d8(i).Size.Width + c97, d)
                    d11(i).ForeColor = Color.LimeGreen
                    d11(i).Font = New Drawing.Font("Times New Roman", c14)
                    d = d + d11(i).Size.Height + c4
                End If
                d = d + 20
            Next
            b1(7).Size = New Point(m + c3 + c1 + d8(1).Size.Width + c97, d)
            u = u + b1(7).Size.Height + c6
        End If
        For i As Integer = 1 To 7
            If b0(i) = 1 Then
                If Me.Size.Width > b1(i).Size.Width Then
                    b1(i).Location = New Point(Int(Me.Size.Width / 2) - Int(b1(i).Size.Width / 2), b1(i).Location.Y)
                    'b1(i).BackColor = Color.FromArgb(6, 0, 0, 0)
                Else
                    b1(i).Location = New Point(c1, b1(i).Location.Y)
                End If
            End If
        Next
        Label1.Location = New Point(Int(Me.Size.Width / 2) - Int(Label1.Size.Width / 2), Label1.Location.Y)
        ttt = New Label
        acc = New Label
        nota = New Label
        Me.Controls.Add(ttt)
        Me.Controls.Add(acc)
        Me.Controls.Add(nota)
        ttt.AutoSize = True
        acc.AutoSize = True
        nota.AutoSize = True
        ttt.Font = New Drawing.Font("Times New Roman", c14)
        acc.Font = New Drawing.Font("Times New Roman", c14)
        nota.Font = New Drawing.Font("Times New Roman", c14)
        ttt.Text = "Punctaj total: " + tot.ToString
        acc.Text = "Punctaj acumulat: " + acm.ToString
        Dim dnt As Double = (10 * acm) / tot
        nota.Text = "Nota: " + Format(dnt, "0.0000")
        If dnt >= 8 Then
            nota.ForeColor = Color.LimeGreen
            acc.ForeColor = Color.LimeGreen
        ElseIf dnt >= 5 Then
            nota.ForeColor = Color.Orange
            acc.ForeColor = Color.Orange
        Else
            nota.ForeColor = Color.Red
            acc.ForeColor = Color.Red
        End If
        ttt.Location = New Point(10, u + 50)
        u = u + ttt.Size.Height + 10
        acc.Location = New Point(10, u + 50)
        u = u + ttt.Size.Height + 10
        nota.Location = New Point(10, u + 50)
        v = 1
        f.Close()
    End Sub
    Private Sub Testul_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        For i As Integer = 1 To 7
            If b0(i) = 1 Then
                If Me.Size.Width > b1(i).Size.Width Then
                    b1(i).Location = New Point(Int(Me.Size.Width / 2) - Int(b1(i).Size.Width / 2), b1(i).Location.Y)
                Else
                    b1(i).Location = New Point(c1, b1(i).Location.Y)
                End If
            End If
        Next
        Label1.Location = New Point(Int(Me.Size.Width / 2) - Int(Label1.Size.Width / 2), Label1.Location.Y)
    End Sub
End Class