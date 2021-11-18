Public Class Primary
    Private Sub Primary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Start()

            Dim dal As New DALControl
            Dim query As String = "SELECT TASK, CHECKED FROM SFM_RCH.Y_PI_COOP_CHECKLIST"
            dal.RunQuery(query)
            Dim checkListTable = dal.SQLDataset01.Tables(0)
            Dim checkListRows = checkListTable.Rows
            For i = 0 To (checkListRows.Count - 1)
                checkList.Items.Add(checkListRows(i).Item(0))
                If checkListRows(i).Item(1) = "Checked" Then
                    checkList.SetItemChecked(i, True)
                Else
                    checkList.SetItemChecked(i, False)
                End If
            Next
            InternetStatus()
            ProgressBarStatus()
        Catch ex As Exception
            Console.WriteLine("Error loading form: " & ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime1.Text = DateTime.Now.ToString("dd/MM/yyyy") & System.Environment.NewLine & DateTime.Now.ToString("HH:mm:ss")
        InternetStatus()
    End Sub

    Private Sub addList_Click(sender As Object, e As EventArgs) Handles addList.Click
        Try
            Dim item As String = InputBox("What would you like to add?", "New Item")
            checkList.Items.Add(item)
            Dim dal As New DALControl
            Dim query As String = "INSERT INTO SFM_RCH.Y_PI_COOP_CHECKLIST (TASK, CHECKED) VALUES ('" & item & "', 'Unchecked')"
            dal.RunQuery(query)
            ProgressBarStatus()
        Catch ex As Exception
            Console.WriteLine("Error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub checkList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles checkList.SelectedIndexChanged
        Try
            Dim item = checkList.SelectedItem.ToString()
            Dim index = checkList.SelectedIndex
            Dim checkedStatus = checkList.GetItemCheckState(index)
            Dim dal As New DALControl
            Dim query As String = "UPDATE SFM_RCH.Y_PI_COOP_CHECKLIST SET CHECKED = '" & checkedStatus.ToString() & "' WHERE TASK = '" & item & "'"
            dal.RunQuery(query)
            ProgressBarStatus()
        Catch ex As Exception
            Console.WriteLine("Exception occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDeleteList_Click(sender As Object, e As EventArgs) Handles btnDeleteList.Click
        Try
            Dim item = InputBox("Which item would you like to delete?", "Delete Item")
            For Each listItem In checkList.Items
                If item = listItem Then
                    checkList.Items.Remove(listItem)
                    Dim dal As New DALControl
                    Dim query As String = "DELETE FROM SFM_RCH.Y_PI_COOP_CHECKLIST WHERE TASK = '" & item.ToString() & "'"
                    dal.RunQuery(query)
                    Exit For
                End If
            Next
            ProgressBarStatus()
        Catch ex As Exception
            Console.WriteLine("Exception occurred: " & ex.Message)
        End Try

    End Sub

    Public Sub InternetStatus()
        Try
            Dim internetStatus = My.Computer.Network.IsAvailable
            If internetStatus Then
                lblInternetStatus.Text = "Internet: Connected"
                lblInternetStatus.ForeColor = Color.Green
            Else
                lblInternetStatus.Text = "Internet: Disconnected"
                lblInternetStatus.ForeColor = Color.Red
            End If
        Catch ex As Exception
            Console.WriteLine("Exception occurred: " & ex.Message)
        End Try
    End Sub

    Public Sub ProgressBarStatus()
        Dim total = checkList.Items.Count
        Dim checked = checkList.CheckedItems.Count
        progressBar.Maximum = total
        progressBar.Value = checked
        Dim percentage = (100 * checked / total).ToString
        lblPercentage.Text = percentage & "%"

    End Sub
End Class