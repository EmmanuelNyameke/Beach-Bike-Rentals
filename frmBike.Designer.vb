<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBike
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
        lblHeading = New Label()
        lblCost = New Label()
        lblNumberOfDays = New Label()
        lblTotalCost = New Label()
        txtNumberOfDays = New TextBox()
        lblTotal = New Label()
        btnFindCost = New Button()
        btnClear = New Button()
        btnExit = New Button()
        picImage = New PictureBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(106, -1)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(192, 23)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Beach Bike Rentals"
        ' 
        ' lblCost
        ' 
        lblCost.AutoSize = True
        lblCost.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCost.Location = New Point(134, 35)
        lblCost.Name = "lblCost"
        lblCost.Size = New Size(48, 18)
        lblCost.TabIndex = 1
        lblCost.Text = "$X.XX"
        ' 
        ' lblNumberOfDays
        ' 
        lblNumberOfDays.AutoSize = True
        lblNumberOfDays.Font = New Font("Tahoma", 12F)
        lblNumberOfDays.Location = New Point(12, 74)
        lblNumberOfDays.Name = "lblNumberOfDays"
        lblNumberOfDays.Size = New Size(179, 19)
        lblNumberOfDays.TabIndex = 2
        lblNumberOfDays.Text = "Number of Rental Days:"
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.Font = New Font("Tahoma", 12F)
        lblTotalCost.Location = New Point(12, 122)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(189, 19)
        lblTotalCost.TabIndex = 3
        lblTotalCost.Text = "Total Cost of Bike Rental:"
        ' 
        ' txtNumberOfDays
        ' 
        txtNumberOfDays.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNumberOfDays.Location = New Point(206, 74)
        txtNumberOfDays.Multiline = True
        txtNumberOfDays.Name = "txtNumberOfDays"
        txtNumberOfDays.Size = New Size(30, 23)
        txtNumberOfDays.TabIndex = 4
        txtNumberOfDays.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(200, 122)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(68, 21)
        lblTotal.TabIndex = 5
        lblTotal.Text = "$888.88"
        ' 
        ' btnFindCost
        ' 
        btnFindCost.BackColor = Color.Yellow
        btnFindCost.Font = New Font("Tahoma", 12F)
        btnFindCost.Location = New Point(25, 193)
        btnFindCost.Name = "btnFindCost"
        btnFindCost.Size = New Size(102, 31)
        btnFindCost.TabIndex = 6
        btnFindCost.Text = "Find Cost"
        btnFindCost.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Yellow
        btnClear.Font = New Font("Tahoma", 12F)
        btnClear.Location = New Point(166, 193)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(102, 31)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Yellow
        btnExit.Font = New Font("Tahoma", 12F)
        btnExit.Location = New Point(296, 193)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(102, 31)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' picImage
        ' 
        picImage.Dock = DockStyle.Bottom
        picImage.Image = My.Resources.Resources.Beach_Bike
        picImage.Location = New Point(0, 251)
        picImage.Name = "picImage"
        picImage.Size = New Size(404, 210)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 9
        picImage.TabStop = False
        ' 
        ' frmBike
        ' 
        AcceptButton = btnFindCost
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnClear
        ClientSize = New Size(404, 461)
        Controls.Add(picImage)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnFindCost)
        Controls.Add(lblTotal)
        Controls.Add(txtNumberOfDays)
        Controls.Add(lblTotalCost)
        Controls.Add(lblNumberOfDays)
        Controls.Add(lblCost)
        Controls.Add(lblHeading)
        Name = "frmBike"
        Text = "Beach Bike Rentals"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnFindCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picImage As PictureBox

End Class
