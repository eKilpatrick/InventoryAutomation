<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Primary
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTime1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInternetStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnDeleteList = New System.Windows.Forms.Button()
        Me.addList = New System.Windows.Forms.Button()
        Me.checkList = New System.Windows.Forms.CheckedListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.progressBar = New System.Windows.Forms.ProgressBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTime1
        '
        Me.lblTime1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.lblTime1.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime1.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblTime1.Location = New System.Drawing.Point(-1, 2)
        Me.lblTime1.Name = "lblTime1"
        Me.lblTime1.Size = New System.Drawing.Size(496, 94)
        Me.lblTime1.TabIndex = 0
        Me.lblTime1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblInternetStatus)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(875, 100)
        Me.Panel1.TabIndex = 1
        '
        'lblInternetStatus
        '
        Me.lblInternetStatus.AutoSize = True
        Me.lblInternetStatus.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblInternetStatus.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInternetStatus.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblInternetStatus.Location = New System.Drawing.Point(875, 0)
        Me.lblInternetStatus.Name = "lblInternetStatus"
        Me.lblInternetStatus.Size = New System.Drawing.Size(0, 18)
        Me.lblInternetStatus.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(875, 100)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inventory Countdown Checklist"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnDeleteList)
        Me.Panel2.Controls.Add(Me.addList)
        Me.Panel2.Controls.Add(Me.checkList)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 50, 3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(375, 414)
        Me.Panel2.TabIndex = 2
        '
        'btnDeleteList
        '
        Me.btnDeleteList.BackColor = System.Drawing.Color.SlateBlue
        Me.btnDeleteList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDeleteList.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteList.ForeColor = System.Drawing.Color.GhostWhite
        Me.btnDeleteList.Location = New System.Drawing.Point(0, 358)
        Me.btnDeleteList.Margin = New System.Windows.Forms.Padding(25)
        Me.btnDeleteList.Name = "btnDeleteList"
        Me.btnDeleteList.Size = New System.Drawing.Size(373, 27)
        Me.btnDeleteList.TabIndex = 2
        Me.btnDeleteList.Text = "Delete Item From List"
        Me.btnDeleteList.UseVisualStyleBackColor = False
        '
        'addList
        '
        Me.addList.BackColor = System.Drawing.Color.SlateBlue
        Me.addList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.addList.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addList.ForeColor = System.Drawing.Color.GhostWhite
        Me.addList.Location = New System.Drawing.Point(0, 385)
        Me.addList.Margin = New System.Windows.Forms.Padding(25)
        Me.addList.Name = "addList"
        Me.addList.Size = New System.Drawing.Size(373, 27)
        Me.addList.TabIndex = 1
        Me.addList.Text = "Add Item To List"
        Me.addList.UseVisualStyleBackColor = False
        '
        'checkList
        '
        Me.checkList.BackColor = System.Drawing.Color.Teal
        Me.checkList.CheckOnClick = True
        Me.checkList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.checkList.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkList.ForeColor = System.Drawing.Color.GhostWhite
        Me.checkList.FormattingEnabled = True
        Me.checkList.Location = New System.Drawing.Point(0, 0)
        Me.checkList.Name = "checkList"
        Me.checkList.Size = New System.Drawing.Size(373, 412)
        Me.checkList.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblTime1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(375, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 100)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.progressBar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(375, 200)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(500, 51)
        Me.Panel4.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(241, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'progressBar
        '
        Me.progressBar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.progressBar.Location = New System.Drawing.Point(0, 0)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(500, 51)
        Me.progressBar.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblPercentage)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(375, 251)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(500, 263)
        Me.Panel5.TabIndex = 5
        '
        'lblPercentage
        '
        Me.lblPercentage.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPercentage.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentage.ForeColor = System.Drawing.Color.GhostWhite
        Me.lblPercentage.Location = New System.Drawing.Point(0, 0)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(500, 21)
        Me.lblPercentage.TabIndex = 0
        Me.lblPercentage.Text = "Label3"
        Me.lblPercentage.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Primary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(875, 514)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Primary"
        Me.Text = "Primary"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTime1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents checkList As CheckedListBox
    Friend WithEvents addList As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents progressBar As ProgressBar
    Friend WithEvents btnDeleteList As Button
    Friend WithEvents lblInternetStatus As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblPercentage As Label
End Class
