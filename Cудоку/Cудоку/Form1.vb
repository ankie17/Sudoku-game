Public Class Form1

   Dim na1, na2, na3, nb1, nb2, nb3, nc1, nc2, nc3 As Integer
   Dim r1, r2, r3 As Integer

   Dim random As New Random()
   Dim ran As Integer = random.Next(1, 9)


   Private Sub startButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton1.Click
      My.Computer.Audio.Play(My.Resources.music, AudioPlayMode.Background)

      noteLabel1.Text = "Будьте уважні!"

      startButton1.Enabled = False
      newButton3.Enabled = False
      checkButton2.Enabled = True

      ran = random.Next(1, 9)
      na1 = ran

      ran = random.Next(1, 9)
      na2 = ran
      If na1 = na2 Then
         Do While na1 = na2
            ran = random.Next(1, 9)
            na2 = ran
         Loop
      End If

      ran = random.Next(1, 9)
      na3 = ran
      If (na1 = na3) Or (na2 = na3) Then
         Do While (na1 = na3) Or (na2 = na3)
            ran = random.Next(1, 9)
            na3 = ran
         Loop
      End If

      ran = random.Next(1, 9)
      nb1 = ran
      If (na1 = nb1) Or (na2 = nb1) Or (na3 = nb1) Then
         Do While (na1 = nb1) Or (na2 = nb1) Or (na3 = nb1)
            ran = random.Next(1, 9)
            nb1 = ran
         Loop
      End If

      ran = random.Next(1, 9)
      nb2 = ran
      If (na1 = nb2) Or (na2 = nb2) Or (na3 = nb2) Or (nb1 = nb2) Then
         Do While (na1 = nb2) Or (na2 = nb2) Or (na3 = nb2) Or (nb1 = nb2)
            ran = random.Next(1, 9)
            nb2 = ran
         Loop
      End If

      ran = random.Next(1, 9)
      nb3 = ran
      If (na1 = nb3) Or (na2 = nb3) Or (na3 = nb3) Or (nb1 = nb3) Or (nb2 = nb3) Then
         Do While (na1 = nb3) Or (na2 = nb3) Or (na3 = nb3) Or (nb1 = nb3) Or (nb2 = nb3)
            ran = random.Next(1, 9)
            nb3 = ran
         Loop
      End If

      ran = random.Next(1, 9)
      nc1 = ran
      If (na1 = nc1) Or (na2 = nc1) Or (na3 = nc1) Or (nb1 = nc1) Or (nb2 = nc1) Or (nb3 = nc1) Then
         Do While (na1 = nc1) Or (na2 = nc1) Or (na3 = nc1) Or (nb1 = nc1) Or (nb2 = nc1) Or (nb3 = nc1)
            ran = random.Next(1, 9)
            nc1 = ran
         Loop
      End If

      ran = random.Next(1, 9)
      nc2 = ran
      If (na1 = nc2) Or (na2 = nc2) Or (na3 = nc2) Or (nb1 = nc2) Or (nb2 = nc2) Or (nb3 = nc2) Or
        (nc1 = nc2) Then
         Do While (na1 = nc2) Or (na2 = nc2) Or (na3 = nc2) Or (nb1 = nc2) Or (nb2 = nc2) Or (nb3 = nc2) Or (nc1 = nc2)
            ran = random.Next(1, 9)
            nc2 = ran
         Loop
      End If

      nc3 = 45 - na1 - na2 - na3 - nb1 - nb2 - nb3 - nc1 - nc2

      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         a1TextBox1.Text = ""
      Else
         a1TextBox1.Enabled = False
         a1TextBox1.Text = nc1
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 3) Then
         a2TextBox2.Text = ""
      Else
         a2TextBox2.Enabled = False
         a2TextBox2.Text = nb3
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         a3TextBox3.Text = ""
      Else
         a3TextBox3.Enabled = False
         a3TextBox3.Text = nc2
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         a4TextBox6.Text = ""
      Else
         a4TextBox6.Enabled = False
         a4TextBox6.Text = nb1
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         a5TextBox5.Text = ""
      Else
         a5TextBox5.Enabled = False
         a5TextBox5.Text = na3
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         a6TextBox4.Text = ""
      Else
         a6TextBox4.Enabled = False
         a6TextBox4.Text = nb2
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         a7TextBox9.Text = ""
      Else
         a7TextBox9.Enabled = False
         a7TextBox9.Text = na1
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         a8TextBox8.Text = ""
      Else
         a8TextBox8.Enabled = False
         a8TextBox8.Text = nc3
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         a9TextBox7.Text = ""
      Else
         a9TextBox7.Enabled = False
         a9TextBox7.Text = na2
      End If
      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         b1TextBox18.Text = ""
      Else
         b1TextBox18.Enabled = False
         b1TextBox18.Text = nb2
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         b2TextBox17.Text = ""
      Else
         b2TextBox17.Enabled = False
         b2TextBox17.Text = nb1
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         b3TextBox16.Text = ""
      Else
         b3TextBox16.Enabled = False
         b3TextBox16.Text = na3
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         b4TextBox15.Text = ""
      Else
         b4TextBox15.Enabled = False
         b4TextBox15.Text = na2
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         b5TextBox14.Text = ""
      Else
         b5TextBox14.Enabled = False
         b5TextBox14.Text = na1
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         b6TextBox13.Text = ""
      Else
         b6TextBox13.Enabled = False
         b6TextBox13.Text = nc3
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         b7TextBox12.Text = ""
      Else
         b7TextBox12.Enabled = False
         b7TextBox12.Text = nc2
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         b8TextBox11.Text = ""
      Else
         b8TextBox11.Enabled = False
         b8TextBox11.Text = nc1
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         b9TextBox10.Text = ""
      Else
         b9TextBox10.Enabled = False
         b9TextBox10.Text = nb3
      End If

      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         c1TextBox27.Text = ""
      Else
         c1TextBox27.Enabled = False
         c1TextBox27.Text = nc3
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         c2TextBox26.Text = ""
      Else
         c2TextBox26.Enabled = False
         c2TextBox26.Text = na1
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         c3TextBox25.Text = ""
      Else
         c3TextBox25.Enabled = False
         c3TextBox25.Text = na2
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         c4TextBox24.Text = ""
      Else
         c4TextBox24.Enabled = False
         c4TextBox24.Text = nb3
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         c5TextBox23.Text = ""
      Else
         c5TextBox23.Enabled = False
         c5TextBox23.Text = nc1
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         c6TextBox22.Text = ""
      Else
         c6TextBox22.Enabled = False
         c6TextBox22.Text = nc2
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         c7TextBox21.Text = ""
      Else
         c7TextBox21.Enabled = False
         c7TextBox21.Text = na3
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         c8TextBox20.Text = ""
      Else
         c8TextBox20.Enabled = False
         c8TextBox20.Text = nb1
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         c9TextBox19.Text = ""
      Else
         c9TextBox19.Enabled = False
         c9TextBox19.Text = nb2
      End If

      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         d1TextBox36.Text = ""
      Else
         d1TextBox36.Enabled = False
         d1TextBox36.Text = na3
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         d2TextBox35.Text = ""
      Else
         d2TextBox35.Enabled = False
         d2TextBox35.Text = na2
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         d3TextBox34.Text = ""
      Else
         d3TextBox34.Enabled = False
         d3TextBox34.Text = nb1
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         d4TextBox33.Text = ""
      Else
         d4TextBox33.Enabled = False
         d4TextBox33.Text = nc3
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         d5TextBox32.Text = ""
      Else
         d5TextBox32.Enabled = False
         d5TextBox32.Text = nc2
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         d6TextBox31.Text = ""
      Else
         d6TextBox31.Enabled = False
         d6TextBox31.Text = na1
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         d7TextBox30.Text = ""
      Else
         d7TextBox30.Enabled = False
         d7TextBox30.Text = nb3
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         d8TextBox29.Text = ""
      Else
         d8TextBox29.Enabled = False
         d8TextBox29.Text = nb2
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         d9TextBox28.Text = ""
      Else
         d9TextBox28.Enabled = False
         d9TextBox28.Text = nc1
      End If

      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         e1TextBox45.Text = ""
      Else
         e1TextBox45.Enabled = False
         e1TextBox45.Text = na1
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         e2TextBox44.Text = ""
      Else
         e2TextBox44.Enabled = False
         e2TextBox44.Text = nc3
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         e3TextBox43.Text = ""
      Else
         e3TextBox43.Enabled = False
         e3TextBox43.Text = nc2
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         e4TextBox42.Text = ""
      Else
         e4TextBox42.Enabled = False
         e4TextBox42.Text = nc1
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         e5TextBox41.Text = ""
      Else
         e5TextBox41.Enabled = False
         e5TextBox41.Text = nb3
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         e6TextBox40.Text = ""
      Else
         e6TextBox40.Enabled = False
         e6TextBox40.Text = nb2
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         e7TextBox39.Text = ""
      Else
         e7TextBox39.Enabled = False
         e7TextBox39.Text = nb1
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         e8TextBox38.Text = ""
      Else
         e8TextBox38.Enabled = False
         e8TextBox38.Text = na3
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         e9TextBox37.Text = ""
      Else
         e9TextBox37.Enabled = False
         e9TextBox37.Text = na2
      End If

      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         f1TextBox54.Text = ""
      Else
         f1TextBox54.Enabled = False
         f1TextBox54.Text = nb2
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         f2TextBox53.Text = ""
      Else
         f2TextBox53.Enabled = False
         f2TextBox53.Text = nb3
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         f3TextBox52.Text = ""
      Else
         f3TextBox52.Enabled = False
         f3TextBox52.Text = nc1
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         f4TextBox51.Text = ""
      Else
         f4TextBox51.Enabled = False
         f4TextBox51.Text = na2
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         f5TextBox50.Text = ""
      Else
         f5TextBox50.Enabled = False
         f5TextBox50.Text = na3
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         f6TextBox49.Text = ""
      Else
         f6TextBox49.Enabled = False
         f6TextBox49.Text = nb1
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         f7TextBox48.Text = ""
      Else
         f7TextBox48.Enabled = False
         f7TextBox48.Text = nc2
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         f8TextBox47.Text = ""
      Else
         f8TextBox47.Enabled = False
         f8TextBox47.Text = nc3
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         f9TextBox46.Text = ""
      Else
         f9TextBox46.Enabled = False
         f9TextBox46.Text = na1
      End If

      '________________________________________________________________________________

      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         g1TextBox63.Text = ""
      Else
         g1TextBox63.Enabled = False
         g1TextBox63.Text = nc2
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         g2TextBox62.Text = ""
      Else
         g2TextBox62.Enabled = False
         g2TextBox62.Text = nc1
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         g3TextBox61.Text = ""
      Else
         g3TextBox61.Enabled = False
         g3TextBox61.Text = nc3
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         g4TextBox60.Text = ""
      Else
         g4TextBox60.Enabled = False
         g4TextBox60.Text = nb2
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         g5TextBox59.Text = ""
      Else
         g5TextBox59.Enabled = False
         g5TextBox59.Text = nb1
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         g6TextBox58.Text = ""
      Else
         g6TextBox58.Enabled = False
         g6TextBox58.Text = nb3
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         g7TextBox57.Text = ""
      Else
         g7TextBox57.Enabled = False
         g7TextBox57.Text = na2
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         g8TextBox56.Text = ""
      Else
         g8TextBox56.Enabled = False
         g8TextBox56.Text = na1
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         g9TextBox55.Text = ""
      Else
         g9TextBox55.Enabled = False
         g9TextBox55.Text = na3
      End If

      '________________________________________________________________________________
      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         h1TextBox72.Text = ""
      Else
         h1TextBox72.Enabled = False
         h1TextBox72.Text = nb3
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         h2TextBox71.Text = ""
      Else
         h2TextBox71.Enabled = False
         h2TextBox71.Text = nb2
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         h3TextBox70.Text = ""
      Else
         h3TextBox70.Enabled = False
         h3TextBox70.Text = nb1
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         h4TextBox69.Text = ""
      Else
         h4TextBox69.Enabled = False
         h4TextBox69.Text = na3
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         h5TextBox68.Text = ""
      Else
         h5TextBox68.Enabled = False
         h5TextBox68.Text = na2
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         h6TextBox67.Text = ""
      Else
         h6TextBox67.Enabled = False
         h6TextBox67.Text = na1
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         h7TextBox66.Text = ""
      Else
         h7TextBox66.Enabled = False
         h7TextBox66.Text = nc3
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         h8TextBox65.Text = ""
      Else
         h8TextBox65.Enabled = False
         h8TextBox65.Text = nc2
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         h9TextBox64.Text = ""
      Else
         h9TextBox64.Enabled = False
         h9TextBox64.Text = nc1
      End If

      '________________________________________________________________________________
      ran = random.Next(1, 9)
      r1 = ran
      ran = random.Next(1, 9)
      r2 = ran
      ran = random.Next(1, 9)
      r3 = ran

      If (r1 = 1) Or (r2 = 1) Or (r3 = 1) Then
         i1TextBox81.Text = ""
      Else
         i1TextBox81.Enabled = False
         i1TextBox81.Text = na1
      End If
      If (r1 = 2) Or (r2 = 2) Or (r3 = 2) Then
         i2TextBox80.Text = ""
      Else
         i2TextBox80.Enabled = False
         i2TextBox80.Text = na2
      End If
      If (r1 = 3) Or (r2 = 3) Or (r3 = 3) Then
         i3TextBox79.Text = ""
      Else
         i3TextBox79.Enabled = False
         i3TextBox79.Text = na3
      End If
      If (r1 = 4) Or (r2 = 4) Or (r3 = 4) Then
         i4TextBox78.Text = ""
      Else
         i4TextBox78.Enabled = False
         i4TextBox78.Text = nc1
      End If
      If (r1 = 5) Or (r2 = 5) Or (r3 = 5) Then
         i5TextBox77.Text = ""
      Else
         i5TextBox77.Enabled = False
         i5TextBox77.Text = nc2
      End If
      If (r1 = 6) Or (r2 = 6) Or (r3 = 6) Then
         i6TextBox76.Text = ""
      Else
         i6TextBox76.Enabled = False
         i6TextBox76.Text = nc3
      End If
      If (r1 = 7) Or (r2 = 7) Or (r3 = 7) Then
         i7TextBox75.Text = ""
      Else
         i7TextBox75.Enabled = False
         i7TextBox75.Text = nb1
      End If
      If (r1 = 8) Or (r2 = 8) Or (r3 = 8) Then
         i8TextBox74.Text = ""
      Else
         i8TextBox74.Enabled = False
         i8TextBox74.Text = nb2
      End If
      If (r1 = 9) Or (r2 = 9) Or (r3 = 9) Then
         i9TextBox73.Text = ""
      Else
         i9TextBox73.Enabled = False
         i9TextBox73.Text = nb3
      End If

   End Sub

   Private Sub newButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newButton3.Click
      startButton1.Enabled = True
      checkButton2.Enabled = False
      newButton3.Enabled = False

      a1TextBox1.Text = ""
      a2TextBox2.Text = ""
      a3TextBox3.Text = ""
      a4TextBox6.Text = ""
      a5TextBox5.Text = ""
      a6TextBox4.Text = ""
      a7TextBox9.Text = ""
      a8TextBox8.Text = ""
      a9TextBox7.Text = ""

      a1TextBox1.Enabled = True
      a2TextBox2.Enabled = True
      a3TextBox3.Enabled = True
      a4TextBox6.Enabled = True
      a5TextBox5.Enabled = True
      a6TextBox4.Enabled = True
      a7TextBox9.Enabled = True
      a8TextBox8.Enabled = True
      a9TextBox7.Enabled = True

      b1TextBox18.Text = ""
      b2TextBox17.Text = ""
      b3TextBox16.Text = ""
      b4TextBox15.Text = ""
      b5TextBox14.Text = ""
      b6TextBox13.Text = ""
      b7TextBox12.Text = ""
      b8TextBox11.Text = ""
      b9TextBox10.Text = ""

      b1TextBox18.Enabled = True
      b2TextBox17.Enabled = True
      b3TextBox16.Enabled = True
      b4TextBox15.Enabled = True
      b5TextBox14.Enabled = True
      b6TextBox13.Enabled = True
      b7TextBox12.Enabled = True
      b8TextBox11.Enabled = True
      b9TextBox10.Enabled = True

      c1TextBox27.Text = ""
      c2TextBox26.Text = ""
      c3TextBox25.Text = ""
      c4TextBox24.Text = ""
      c5TextBox23.Text = ""
      c6TextBox22.Text = ""
      c7TextBox21.Text = ""
      c8TextBox20.Text = ""
      c9TextBox19.Text = ""

      c1TextBox27.Enabled = True
      c2TextBox26.Enabled = True
      c3TextBox25.Enabled = True
      c4TextBox24.Enabled = True
      c5TextBox23.Enabled = True
      c6TextBox22.Enabled = True
      c7TextBox21.Enabled = True
      c8TextBox20.Enabled = True
      c9TextBox19.Enabled = True

      d1TextBox36.Text = ""
      d2TextBox35.Text = ""
      d3TextBox34.Text = ""
      d4TextBox33.Text = ""
      d5TextBox32.Text = ""
      d6TextBox31.Text = ""
      d7TextBox30.Text = ""
      d8TextBox29.Text = ""
      d9TextBox28.Text = ""

      d1TextBox36.Enabled = True
      d2TextBox35.Enabled = True
      d3TextBox34.Enabled = True
      d4TextBox33.Enabled = True
      d5TextBox32.Enabled = True
      d6TextBox31.Enabled = True
      d7TextBox30.Enabled = True
      d8TextBox29.Enabled = True
      d9TextBox28.Enabled = True

      e1TextBox45.Text = ""
      e2TextBox44.Text = ""
      e3TextBox43.Text = ""
      e4TextBox42.Text = ""
      e5TextBox41.Text = ""
      e6TextBox40.Text = ""
      e7TextBox39.Text = ""
      e8TextBox38.Text = ""
      e9TextBox37.Text = ""

      e1TextBox45.Enabled = True
      e2TextBox44.Enabled = True
      e3TextBox43.Enabled = True
      e4TextBox42.Enabled = True
      e5TextBox41.Enabled = True
      e6TextBox40.Enabled = True
      e7TextBox39.Enabled = True
      e8TextBox38.Enabled = True
      e9TextBox37.Enabled = True

      f1TextBox54.Text = ""
      f2TextBox53.Text = ""
      f3TextBox52.Text = ""
      f4TextBox51.Text = ""
      f5TextBox50.Text = ""
      f6TextBox49.Text = ""
      f7TextBox48.Text = ""
      f8TextBox47.Text = ""
      f9TextBox46.Text = ""

      f1TextBox54.Enabled = True
      f2TextBox53.Enabled = True
      f3TextBox52.Enabled = True
      f4TextBox51.Enabled = True
      f5TextBox50.Enabled = True
      f6TextBox49.Enabled = True
      f7TextBox48.Enabled = True
      f8TextBox47.Enabled = True
      f9TextBox46.Enabled = True

      g1TextBox63.Text = ""
      g2TextBox62.Text = ""
      g3TextBox61.Text = ""
      g4TextBox60.Text = ""
      g5TextBox59.Text = ""
      g6TextBox58.Text = ""
      g7TextBox57.Text = ""
      g8TextBox56.Text = ""
      g9TextBox55.Text = ""

      g1TextBox63.Enabled = True
      g2TextBox62.Enabled = True
      g3TextBox61.Enabled = True
      g4TextBox60.Enabled = True
      g5TextBox59.Enabled = True
      g6TextBox58.Enabled = True
      g7TextBox57.Enabled = True
      g8TextBox56.Enabled = True
      g9TextBox55.Enabled = True

      h1TextBox72.Text = ""
      h2TextBox71.Text = ""
      h3TextBox70.Text = ""
      h4TextBox69.Text = ""
      h5TextBox68.Text = ""
      h6TextBox67.Text = ""
      h7TextBox66.Text = ""
      h8TextBox65.Text = ""
      h9TextBox64.Text = ""

      h1TextBox72.Enabled = True
      h2TextBox71.Enabled = True
      h3TextBox70.Enabled = True
      h4TextBox69.Enabled = True
      h5TextBox68.Enabled = True
      h6TextBox67.Enabled = True
      h7TextBox66.Enabled = True
      h8TextBox65.Enabled = True
      h9TextBox64.Enabled = True

      i1TextBox81.Text = ""
      i2TextBox80.Text = ""
      i3TextBox79.Text = ""
      i4TextBox78.Text = ""
      i5TextBox77.Text = ""
      i6TextBox76.Text = ""
      i7TextBox75.Text = ""
      i8TextBox74.Text = ""
      i9TextBox73.Text = ""

      i1TextBox81.Enabled = True
      i2TextBox80.Enabled = True
      i3TextBox79.Enabled = True
      i4TextBox78.Enabled = True
      i5TextBox77.Enabled = True
      i6TextBox76.Enabled = True
      i7TextBox75.Enabled = True
      i8TextBox74.Enabled = True
      i9TextBox73.Enabled = True
   End Sub

   Private Sub checkButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkButton2.Click
      Dim a1, a2, a3, a4, a5, a6, a7, a8, a9 As Integer
      Dim b1, b2, b3, b4, b5, b6, b7, b8, b9 As Integer
      Dim c1, c2, c3, c4, c5, c6, c7, c8, c9 As Integer
      Dim d1, d2, d3, d4, d5, d6, d7, d8, d9 As Integer
      Dim e1, e2, e3, e4, e5, e6, e7, e8, e9 As Integer
      Dim f1, f2, f3, f4, f5, f6, f7, f8, f9 As Integer
      Dim g1, g2, g3, g4, g5, g6, g7, g8, g9 As Integer
      Dim h1, h2, h3, h4, h5, h6, h7, h8, h9 As Integer
      Dim i1, i2, i3, i4, i5, i6, i7, i8, i9 As Integer

      startButton1.Enabled = False

      If a1TextBox1.Enabled = False Then
         a1 = nc1
      Else
         a1 = Val(a1TextBox1.Text)
      End If
      If a2TextBox2.Enabled = False Then
         a2 = nb3
      Else
         a2 = Val(a2TextBox2.Text)
      End If
      If a3TextBox3.Enabled = False Then
         a3 = nc2
      Else
         a3 = Val(a3TextBox3.Text)
      End If
      If a4TextBox6.Enabled = False Then
         a4 = nb1
      Else
         a4 = Val(a4TextBox6.Text)
      End If
      If a5TextBox5.Enabled = False Then
         a5 = na3
      Else
         a5 = Val(a5TextBox5.Text)
      End If
      If a6TextBox4.Enabled = False Then
         a6 = nb2
      Else
         a6 = Val(a6TextBox4.Text)
      End If
      If a7TextBox9.Enabled = False Then
         a7 = na1
      Else
         a7 = Val(a7TextBox9.Text)
      End If
      If a8TextBox8.Enabled = False Then
         a8 = nc3
      Else
         a8 = Val(a8TextBox8.Text)
      End If
      If a9TextBox7.Enabled = False Then
         a9 = na2
      Else
         a9 = Val(a9TextBox7.Text)
      End If

      '________________________________________________________________________________

      If b1TextBox18.Enabled = False Then
         b1 = nb2
      Else
         b1 = Val(b1TextBox18.Text)
      End If
      If b2TextBox17.Enabled = False Then
         b2 = nb1
      Else
         b2 = Val(b2TextBox17.Text)
      End If
      If b3TextBox16.Enabled = False Then
         b3 = na3
      Else
         b3 = Val(b3TextBox16.Text)
      End If
      If b4TextBox15.Enabled = False Then
         b4 = na2
      Else
         b4 = Val(b4TextBox15.Text)
      End If
      If b5TextBox14.Enabled = False Then
         b5 = na1
      Else
         b5 = Val(b5TextBox14.Text)
      End If
      If b6TextBox13.Enabled = False Then
         b6 = nc3
      Else
         b6 = Val(b6TextBox13.Text)
      End If
      If b7TextBox12.Enabled = False Then
         b7 = nc2
      Else
         b7 = Val(b7TextBox12.Text)
      End If
      If b8TextBox11.Enabled = False Then
         b8 = nc1
      Else
         b8 = Val(b8TextBox11.Text)
      End If
      If b9TextBox10.Enabled = False Then
         b9 = nb3
      Else
         b9 = Val(b9TextBox10.Text)
      End If

      '________________________________________________________________________________

      If c1TextBox27.Enabled = False Then
         c1 = nc3
      Else
         c1 = Val(c1TextBox27.Text)
      End If
      If c2TextBox26.Enabled = False Then
         c2 = na1
      Else
         c2 = Val(c2TextBox26.Text)
      End If
      If c3TextBox25.Enabled = False Then
         c3 = na2
      Else
         c3 = Val(c3TextBox25.Text)
      End If
      If c4TextBox24.Enabled = False Then
         c4 = nb3
      Else
         c4 = Val(c4TextBox24.Text)
      End If
      If c5TextBox23.Enabled = False Then
         c5 = nc1
      Else
         c5 = Val(c5TextBox23.Text)
      End If
      If c6TextBox22.Enabled = False Then
         c6 = nc2
      Else
         c6 = Val(c6TextBox22.Text)
      End If
      If c7TextBox21.Enabled = False Then
         c7 = na3
      Else
         c7 = Val(c7TextBox21.Text)
      End If
      If c8TextBox20.Enabled = False Then
         c8 = nb1
      Else
         c8 = Val(c8TextBox20.Text)
      End If
      If c9TextBox19.Enabled = False Then
         c9 = nb2
      Else
         c9 = Val(c9TextBox19.Text)
      End If

      '________________________________________________________________________________

      If d1TextBox36.Enabled = False Then
         d1 = na3
      Else
         d1 = Val(d1TextBox36.Text)
      End If
      If d2TextBox35.Enabled = False Then
         d2 = na2
      Else
         d2 = Val(d2TextBox35.Text)
      End If
      If d3TextBox34.Enabled = False Then
         d3 = nb1
      Else
         d3 = Val(d3TextBox34.Text)
      End If
      If d4TextBox33.Enabled = False Then
         d4 = nc3
      Else
         d4 = Val(d4TextBox33.Text)
      End If
      If d5TextBox32.Enabled = False Then
         d5 = nc2
      Else
         d5 = Val(d5TextBox32.Text)
      End If
      If d6TextBox31.Enabled = False Then
         d6 = na1
      Else
         d6 = Val(d6TextBox31.Text)
      End If
      If d7TextBox30.Enabled = False Then
         d7 = nb3
      Else
         d7 = Val(d7TextBox30.Text)
      End If
      If d8TextBox29.Enabled = False Then
         d8 = nb2
      Else
         d8 = Val(d8TextBox29.Text)
      End If
      If d9TextBox28.Enabled = False Then
         d9 = nc1
      Else
         d9 = Val(d9TextBox28.Text)
      End If

      '________________________________________________________________________________

      If e1TextBox45.Enabled = False Then
         e1 = na1
      Else
         e1 = Val(e1TextBox45.Text)
      End If
      If e2TextBox44.Enabled = False Then
         e2 = nc3
      Else
         e2 = Val(e2TextBox44.Text)
      End If
      If e3TextBox43.Enabled = False Then
         e3 = nc2
      Else
         e3 = Val(e3TextBox43.Text)
      End If
      If e4TextBox42.Enabled = False Then
         e4 = nc1
      Else
         e4 = Val(e4TextBox42.Text)
      End If
      If e5TextBox41.Enabled = False Then
         e5 = nb3
      Else
         e5 = Val(e5TextBox41.Text)
      End If
      If e6TextBox40.Enabled = False Then
         e6 = nb2
      Else
         e6 = Val(e6TextBox40.Text)
      End If
      If e7TextBox39.Enabled = False Then
         e7 = nb1
      Else
         e7 = Val(e7TextBox39.Text)
      End If
      If e8TextBox38.Enabled = False Then
         e8 = na3
      Else
         e8 = Val(e8TextBox38.Text)
      End If
      If e9TextBox37.Enabled = False Then
         e9 = na2
      Else
         e9 = Val(e9TextBox37.Text)
      End If

      '________________________________________________________________________________

      If f1TextBox54.Enabled = False Then
         f1 = nb2
      Else
         f1 = Val(f1TextBox54.Text)
      End If
      If f2TextBox53.Enabled = False Then
         f2 = nb3
      Else
         f2 = Val(f2TextBox53.Text)
      End If
      If f3TextBox52.Enabled = False Then
         f3 = nc1
      Else
         f3 = Val(f3TextBox52.Text)
      End If
      If f4TextBox51.Enabled = False Then
         f4 = na2
      Else
         f4 = Val(f4TextBox51.Text)
      End If
      If f5TextBox50.Enabled = False Then
         f5 = na3
      Else
         f5 = Val(f5TextBox50.Text)
      End If
      If f6TextBox49.Enabled = False Then
         f6 = nb1
      Else
         f6 = Val(f6TextBox49.Text)
      End If
      If f7TextBox48.Enabled = False Then
         f7 = nc2
      Else
         f7 = Val(f7TextBox48.Text)
      End If
      If f8TextBox47.Enabled = False Then
         f8 = nc3
      Else
         f8 = Val(f8TextBox47.Text)
      End If
      If f9TextBox46.Enabled = False Then
         f9 = na1
      Else
         f9 = Val(f9TextBox46.Text)
      End If

      '________________________________________________________________________________

      If g1TextBox63.Enabled = False Then
         g1 = nc2
      Else
         g1 = Val(g1TextBox63.Text)
      End If
      If g2TextBox62.Enabled = False Then
         g2 = nc1
      Else
         g2 = Val(g2TextBox62.Text)
      End If
      If g3TextBox61.Enabled = False Then
         g3 = nc3
      Else
         g3 = Val(g3TextBox61.Text)
      End If
      If g4TextBox60.Enabled = False Then
         g4 = nb2
      Else
         g4 = Val(g4TextBox60.Text)
      End If
      If g5TextBox59.Enabled = False Then
         g5 = nb1
      Else
         g5 = Val(g5TextBox59.Text)
      End If
      If g6TextBox58.Enabled = False Then
         g6 = nb3
      Else
         g6 = Val(g6TextBox58.Text)
      End If
      If g7TextBox57.Enabled = False Then
         g7 = na2
      Else
         g7 = Val(g7TextBox57.Text)
      End If
      If g8TextBox56.Enabled = False Then
         g8 = na1
      Else
         g8 = Val(g8TextBox56.Text)
      End If
      If g9TextBox55.Enabled = False Then
         g9 = na3
      Else
         g9 = Val(g9TextBox55.Text)
      End If

      '________________________________________________________________________________

      If h1TextBox72.Enabled = False Then
         h1 = nb3
      Else
         h1 = Val(h1TextBox72.Text)
      End If
      If h2TextBox71.Enabled = False Then
         h2 = nb2
      Else
         h2 = Val(h2TextBox71.Text)
      End If
      If h3TextBox70.Enabled = False Then
         h3 = nb1
      Else
         h3 = Val(h3TextBox70.Text)
      End If
      If h4TextBox69.Enabled = False Then
         h4 = na3
      Else
         h4 = Val(h4TextBox69.Text)
      End If
      If h5TextBox68.Enabled = False Then
         h5 = na2
      Else
         h5 = Val(h5TextBox68.Text)
      End If
      If h6TextBox67.Enabled = False Then
         h6 = na1
      Else
         h6 = Val(h6TextBox67.Text)
      End If
      If h7TextBox66.Enabled = False Then
         h7 = nc3
      Else
         h7 = Val(h7TextBox66.Text)
      End If
      If h8TextBox65.Enabled = False Then
         h8 = nc2
      Else
         h8 = Val(h8TextBox65.Text)
      End If
      If h9TextBox64.Enabled = False Then
         h9 = nc1
      Else
         h9 = Val(h9TextBox64.Text)
      End If

      '________________________________________________________________________________

      If i1TextBox81.Enabled = False Then
         i1 = na1
      Else
         i1 = Val(i1TextBox81.Text)
      End If
      If i2TextBox80.Enabled = False Then
         i2 = na2
      Else
         i2 = Val(i2TextBox80.Text)
      End If
      If i3TextBox79.Enabled = False Then
         i3 = na3
      Else
         i3 = Val(i3TextBox79.Text)
      End If
      If i4TextBox78.Enabled = False Then
         i4 = nc1
      Else
         i4 = Val(i4TextBox78.Text)
      End If
      If i5TextBox77.Enabled = False Then
         i5 = nc2
      Else
         i5 = Val(i5TextBox77.Text)
      End If
      If i6TextBox76.Enabled = False Then
         i6 = nc3
      Else
         i6 = Val(i6TextBox76.Text)
      End If
      If i7TextBox75.Enabled = False Then
         i7 = nb1
      Else
         i7 = Val(i7TextBox75.Text)
      End If
      If i8TextBox74.Enabled = False Then
         i8 = nb2
      Else
         i8 = Val(i8TextBox74.Text)
      End If
      If i9TextBox73.Enabled = False Then
         i9 = nb3
      Else
         i9 = Val(i9TextBox73.Text)
      End If

      '________________________________________________________________________________

      If (a7 = na1) And (b5 = na1) And (c2 = na1) And (d6 = na1) And (e1 = na1) And
         (f9 = na1) And (g8 = na1) And (h6 = na1) And (i1 = na1) And (a9 = na2) And
         (b4 = na2) And (c3 = na2) And (d2 = na2) And (e9 = na2) And (f4 = na2) And
         (g7 = na2) And (h5 = na2) And (i2 = na2) And (a5 = na3) And (b3 = na3) And
         (c7 = na3) And (d1 = na3) And (e8 = na3) And (f5 = na3) And (g9 = na3) And
         (h4 = na3) And (i3 = na3) And (a4 = nb1) And (b2 = nb1) And (c8 = nb1) And
         (d3 = nb1) And (e7 = nb1) And (f6 = nb1) And (g5 = nb1) And (h3 = nb1) And
         (i7 = nb1) And (a6 = nb2) And (b1 = nb2) And (c9 = nb2) And (d8 = nb2) And
         (e6 = nb2) And (f1 = nb2) And (g4 = nb2) And (h2 = nb2) And (i8 = nb2) And
         (a2 = nb3) And (b9 = nb3) And (c4 = nb3) And (d7 = nb3) And (e5 = nb3) And
         (f2 = nb3) And (g6 = nb3) And (h1 = nb3) And (i9 = nb3) And (a1 = nc1) And
         (b8 = nc1) And (c5 = nc1) And (d9 = nc1) And (e4 = nc1) And (f3 = nc1) And
         (g2 = nc1) And (h9 = nc1) And (i4 = nc1) And (a3 = nc2) And (b7 = nc2) And
         (c6 = nc2) And (d5 = nc2) And (e3 = nc2) And (f7 = nc2) And (g1 = nc2) And
         (h8 = nc2) And (i5 = nc2) And (a8 = nc3) And (b6 = nc3) And (c1 = nc3) And
         (d4 = nc3) And (e2 = nc3) And (f8 = nc3) And (g3 = nc3) And (h7 = nc3) And
         (i6 = nc3) Then
         noteLabel1.Text = "Вітаю! Судоку розв'язана правильно!"
         checkButton2.Enabled = False
         newButton3.Enabled = True
      Else
         noteLabel1.Text = "Є помилка! Спробуйте ще раз!"
         checkButton2.Enabled = True
         newButton3.Enabled = False
      End If


   End Sub

   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      noteLabel1.Text = "Гарної гри!"
   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      My.Computer.Audio.Stop()
   End Sub
End Class
