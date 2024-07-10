<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublished = New TextBox()
        txtGenre = New TextBox()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        dgvBooks = New DataGridView()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(17, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 25)
        Label1.TabIndex = 0
        Label1.Text = "Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.Location = New Point(15, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 25)
        Label2.TabIndex = 1
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label3.Location = New Point(15, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 2
        Label3.Text = "Year Published"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(17, 236)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 25)
        Label4.TabIndex = 3
        Label4.Text = "Genre"
        ' 
        ' txtTitle
        ' 
        txtTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTitle.Location = New Point(173, 41)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(100, 33)
        txtTitle.TabIndex = 4
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        txtAuthor.Location = New Point(173, 107)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(100, 33)
        txtAuthor.TabIndex = 5
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        txtYearPublished.Location = New Point(173, 174)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(100, 33)
        txtYearPublished.TabIndex = 6
        ' 
        ' txtGenre
        ' 
        txtGenre.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        txtGenre.Location = New Point(173, 236)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(100, 33)
        txtGenre.TabIndex = 7
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnAdd.Location = New Point(27, 223)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(89, 40)
        btnAdd.TabIndex = 8
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnUpdate.Location = New Point(233, 284)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(110, 42)
        btnUpdate.TabIndex = 9
        btnUpdate.Text = "UPDATE"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnDelete.Location = New Point(233, 223)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(110, 40)
        btnDelete.TabIndex = 10
        btnDelete.Text = "DELETE"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold)
        btnClear.Location = New Point(27, 284)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(89, 42)
        btnClear.TabIndex = 11
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' dgvBooks
        ' 
        dgvBooks.AllowUserToAddRows = False
        dgvBooks.AllowUserToDeleteRows = False
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(3, 3)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.ReadOnly = True
        dgvBooks.Size = New Size(432, 183)
        dgvBooks.TabIndex = 12
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(794, 70)
        Panel1.TabIndex = 13
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(9, 8)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(776, 59)
        Panel2.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(98, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(602, 50)
        Label5.TabIndex = 0
        Label5.Text = "LIBRARY MANAGEMENT SYSTEM"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ActiveCaption
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(7, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(334, 358)
        Panel3.TabIndex = 14
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ControlLight
        Panel4.Controls.Add(txtAuthor)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label2)
        Panel4.Controls.Add(txtGenre)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtTitle)
        Panel4.Controls.Add(txtYearPublished)
        Panel4.Controls.Add(Label1)
        Panel4.Location = New Point(16, 19)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(306, 307)
        Panel4.TabIndex = 14
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveCaption
        Panel5.Controls.Add(btnClear)
        Panel5.Controls.Add(btnUpdate)
        Panel5.Controls.Add(btnDelete)
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(btnAdd)
        Panel5.Location = New Point(347, 80)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(447, 358)
        Panel5.TabIndex = 15
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlLight
        Panel6.Controls.Add(dgvBooks)
        Panel6.Location = New Point(3, 3)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(438, 199)
        Panel6.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel5)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label

End Class
