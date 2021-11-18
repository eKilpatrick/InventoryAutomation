Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As Form = New Primary
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.ControlBox = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True
        PanelMain.Controls.Add(frm)
    End Sub

    Private Sub btnLblPrinting_Click(sender As Object, e As EventArgs) Handles btnLblPrinting.Click
        PanelMain.Controls.Clear()
        btnScanning.BackColor = Color.Teal
        btnRFIDPrinting.BackColor = Color.Teal
        btnLblPrinting.BackColor = Color.FromName("DarkSlateGray")
        Dim frm As Form = New LabelPrinting
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.ControlBox = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True
        PanelMain.Controls.Add(frm)
    End Sub

    Private Sub btnScanning_Click(sender As Object, e As EventArgs) Handles btnScanning.Click
        PanelMain.Controls.Clear()
        btnScanning.BackColor = Color.FromName("DarkSlateGray")
        btnRFIDPrinting.BackColor = Color.Teal
        btnLblPrinting.BackColor = Color.Teal
        Dim frm As Form = New LabelScanning
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.ControlBox = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True
        PanelMain.Controls.Add(frm)
    End Sub

    Private Sub btnRFIDPrinting_Click(sender As Object, e As EventArgs) Handles btnRFIDPrinting.Click
        PanelMain.Controls.Clear()
        btnScanning.BackColor = Color.Teal
        btnRFIDPrinting.BackColor = Color.FromName("DarkSlateGray")
        btnLblPrinting.BackColor = Color.Teal
        Dim frm As Form = New RFIDPrinting
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.ControlBox = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True
        PanelMain.Controls.Add(frm)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelMain.Controls.Clear()
        btnScanning.BackColor = Color.Teal
        btnRFIDPrinting.BackColor = Color.Teal
        btnLblPrinting.BackColor = Color.Teal
        Dim frm As Form = New Primary
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        frm.ControlBox = False
        frm.FormBorderStyle = FormBorderStyle.None
        frm.Visible = True
        PanelMain.Controls.Add(frm)
    End Sub
End Class
