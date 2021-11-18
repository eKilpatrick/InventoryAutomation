Public Class RFIDPrinting
    Dim printer As String = ""
    Dim labelSize = ""
    Private Sub RFIDPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RFIDPrinting.ActiveForm.BackColor = Color.DarkSlateGray
        btnChangePrinter_Click(sender, e)
    End Sub

    Private Sub btn4x2_Click(sender As Object, e As EventArgs) Handles btn4x2.Click
        btn4x2.BackColor = Color.DarkSlateBlue
        btn4x3.BackColor = Color.SlateBlue
        labelSize = "4x2"
    End Sub

    Private Sub btn4x3_Click(sender As Object, e As EventArgs) Handles btn4x3.Click
        btn4x2.BackColor = Color.SlateBlue
        btn4x3.BackColor = Color.DarkSlateBlue
        labelSize = "4x3"
    End Sub

    Private Sub btnChangePrinter_Click(sender As Object, e As EventArgs) Handles btnChangePrinter.Click
        Dim dialog As New PrintDialog
        dialog.ShowDialog()
        printer = dialog.PrinterSettings.PrinterName
        lblPrinter.Text = "Active Printer: " & printer
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        While printer Is Nothing
            MsgBox("You must choose a printer")
            btnChangePrinter_Click(sender, e)
        End While
        If labelSize Is Nothing Then
            MsgBox("You must choose a label size")
            Exit Sub
        End If
        Dim partNum = txtPN.Text
        Dim description = txtDescription.Text
        Dim quantity = txtQty.Text
        Dim EPC = "00" & DateTime.Now.ToString("yyyyMMddHHmmssffff") & "000000010001"
        lblEPC.Text = "EPC: " & EPC

        Dim zplCmd = ""
        If labelSize = "4x3" Then
            zplCmd &= "^XA^MD-2^FO300,50^A0N,65^FD" & description & "^FS^FO200,150^A0N,75^FDPart Number:^FS"
            zplCmd &= "^FO45,225^A0N,100^FD" + partNum & "^FS"
            zplCmd &= "^FO115,325^BY3^BCn,100,y,n,n^FD" & partNum + "^FS"
            zplCmd &= "^FO25,25^BQn,2,5^FDQA," & partNum & ";" & EPC & "^FS"
            zplCmd &= "^RFw,h,0,16,A^FD" + EPC + "^FS"
            zplCmd &= "^RFw,a,0,10,3^FD" & partNum & "^FS^XZ"
        ElseIf labelSize = "4x2" Then
            zplCmd &= "^XA^FO300,50^A0N,65^FD" & description & "^FS^FO45,150^A0N,75^FD" & partNum & "^FS"
            zplCmd &= "^FO300,225^A0N,65^FDQty: " & quantity & "^FS"
            zplCmd &= "^RFw,h,0,16,A^FD" + EPC + "^FS"
            zplCmd &= "^RFw,a,0,10,3^FD" & partNum & "^FS^XZ"
        End If

        RawPrinterHelper.RawPrinterHelper.SendStringToPrinter(printer, zplCmd)
        Dim dal As New DALControl
        Dim query As String = "INSERT INTO SFM_RCH.ZPL_PRINTTAGS (STATE, PARTNUM, EPC) VALUES ('1', '" & partNum & "', '" & EPC & "')"
        dal.RunQuery(query)
    End Sub
End Class