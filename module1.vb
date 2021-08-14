Module Module1
    Friend Sub ControlBorder(ByRef form As Control, ByVal bordersize As Integer, ByVal color As Color)
        ' written by GETSCHONNIK
        Dim bordercol As Color = color
        Dim borderR As New Panel
        borderR.Location = New System.Drawing.Point(form.Width - bordersize, bordersize)
        borderR.Name = "PanelBorderR"
        borderR.Size = New System.Drawing.Size(bordersize, form.Height - bordersize)
        borderR.BackColor = color
        form.Controls.Add(borderR)
        Dim borderL As New Panel
        borderL.Location = New System.Drawing.Point(0, 0)
        borderL.Name = "PanelBorderL"
        borderL.Size = New System.Drawing.Size(bordersize, form.Height - bordersize)
        borderL.BackColor = color
        form.Controls.Add(borderL)
        Dim borderT As New Panel
        borderT.Location = New System.Drawing.Point(0, 0)
        borderT.Name = "PanelBorderL"
        borderT.Size = New System.Drawing.Size(form.Width - bordersize, bordersize)
        borderT.BackColor = color
        form.Controls.Add(borderT)
        Dim borderB As New Panel
        borderB.Location = New System.Drawing.Point(0, form.Height - bordersize)
        borderB.Name = "PanelBorderL"
        borderB.Size = New System.Drawing.Size(form.Width - bordersize, bordersize)
        borderB.BackColor = color
        form.Controls.Add(borderB)
    End Sub
End Module
