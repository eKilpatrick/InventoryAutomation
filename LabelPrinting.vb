Imports System.Drawing.Printing
Public Class LabelPrinting
    Dim printer As String = ""
    Private Sub LabelPrinting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnChangePrinter_Click(sender, e)

    End Sub

    Private Sub btnChangePrinter_Click(sender As Object, e As EventArgs) Handles btnChangePrinter.Click
        Dim dialog As New PrintDialog()
        dialog.ShowDialog()
        printer = dialog.PrinterSettings.PrinterName
        PrintDialog1.PrinterSettings.PrinterName = printer
        lblPrinter.Text = "Active Printer: " & printer
    End Sub

    Private Sub btn4x6_Click(sender As Object, e As EventArgs) Handles btn4x6.Click
        btn4x6.BackColor = Color.DarkSlateBlue
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim serialNum = "PI" & DateTime.Now.ToString("yyMMddHHmmss")
        lblSN.Text = "Serial Number: " & serialNum
        PrintPreviewDialog1.Document = PrintDocument1
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        PrintDialog1.PrinterSettings.PrinterName = printer
        PrintDocument1.DefaultPageSettings.PaperSize = New System.Drawing.Printing.PaperSize("custom", 400, 620)
        Dim Margins1 As Margins = New Margins(10, 10, 5, 5)
        PrintDocument1.DefaultPageSettings.Margins = Margins1
        PrintDocument1.Print()
        Dim dal As New DALControl
        Dim query As String = "INSERT INTO SFM_RCH.Y_BUNDLE_PRINTING (SERIALNUMBER, PARTNUMBER, BUNDLE, DATE_FINISHED, DESCRIPTION) VALUES ('" & serialNum & "', '" & txtPN.Text & "', '" & txtQty.Text & "', 'Printed','" & txtDescription.Text & "')"
        dal.RunQuery(query)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Try
            Dim Space As Integer = 15
            Dim BASE As Integer = 190
            Dim ReportFont1 As Font = New Drawing.Font("Arial", 20, FontStyle.Bold)
            Dim ReportFont2 As Font = New Drawing.Font("Arial", 20, FontStyle.Regular)
            Dim ReportFont3 As Font = New Drawing.Font("Arial", 15, FontStyle.Regular)
            Dim ReportFont4 As Font = New Drawing.Font("Arial", 12, FontStyle.Bold)
            Dim ReportFontBar As Font = New Drawing.Font("IDAutomationHC39M", 15, FontStyle.Regular)

            'Titles
            e.Graphics.DrawString(txtDescription.Text, ReportFont1, Brushes.Black, 5, 10)
            e.Graphics.DrawString("Part:", ReportFont1, Brushes.Black, 5, 40)
            e.Graphics.DrawString("Qty:", ReportFont1, Brushes.Black, 5, BASE + 4 * Space)

            'Content
            e.Graphics.DrawString(txtPN.Text, ReportFont3, Brushes.Black, 75, 43)
            e.Graphics.DrawString("*" & lblSN.Text.Substring(15) & "*", ReportFontBar, Brushes.Black, 5, 80)
            Try
                e.Graphics.DrawString(txtDescription.Text, ReportFont4, Brushes.Black, 5, BASE) '***********Description goes here***********
            Catch ex As Exception
                e.Graphics.DrawString("", ReportFont2, Brushes.Black, 5, BASE)
            End Try
            e.Graphics.DrawString(txtQty.Text, ReportFont2, Brushes.Black, 75, BASE + 4 * Space)
        Catch ex As Exception
            MsgBox("An error occurred when printing the page")
        End Try
    End Sub
End Class