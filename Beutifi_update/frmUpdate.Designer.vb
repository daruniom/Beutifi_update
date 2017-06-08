<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCopy = New System.Windows.Forms.Label()
        Me.dtpCopy = New System.Windows.Forms.DateTimePicker()
        Me.dtpReplication = New System.Windows.Forms.DateTimePicker()
        Me.lblReplication = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblConnected = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblCopy
        '
        Me.lblCopy.AutoSize = True
        Me.lblCopy.Location = New System.Drawing.Point(329, 70)
        Me.lblCopy.Name = "lblCopy"
        Me.lblCopy.Size = New System.Drawing.Size(58, 13)
        Me.lblCopy.TabIndex = 0
        Me.lblCopy.Text = "Copy date:"
        Me.lblCopy.Visible = False
        '
        'dtpCopy
        '
        Me.dtpCopy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCopy.Location = New System.Drawing.Point(436, 67)
        Me.dtpCopy.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtpCopy.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.dtpCopy.Name = "dtpCopy"
        Me.dtpCopy.Size = New System.Drawing.Size(97, 20)
        Me.dtpCopy.TabIndex = 1
        Me.dtpCopy.Visible = False
        '
        'dtpReplication
        '
        Me.dtpReplication.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpReplication.Location = New System.Drawing.Point(436, 107)
        Me.dtpReplication.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dtpReplication.MinDate = New Date(2016, 1, 1, 0, 0, 0, 0)
        Me.dtpReplication.Name = "dtpReplication"
        Me.dtpReplication.Size = New System.Drawing.Size(97, 20)
        Me.dtpReplication.TabIndex = 3
        Me.dtpReplication.Visible = False
        '
        'lblReplication
        '
        Me.lblReplication.AutoSize = True
        Me.lblReplication.Location = New System.Drawing.Point(329, 110)
        Me.lblReplication.Name = "lblReplication"
        Me.lblReplication.Size = New System.Drawing.Size(87, 13)
        Me.lblReplication.TabIndex = 2
        Me.lblReplication.Text = "Replication date:"
        Me.lblReplication.Visible = False
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(397, 147)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 4
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        Me.btnUpdate.Visible = False
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(122, 190)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 5
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(30, 30)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(38, 13)
        Me.lblServer.TabIndex = 6
        Me.lblServer.Text = "Server"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(106, 27)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(173, 20)
        Me.txtServer.TabIndex = 7
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(106, 67)
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(173, 20)
        Me.txtDatabase.TabIndex = 9
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(30, 70)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(56, 13)
        Me.lblDatabase.TabIndex = 8
        Me.lblDatabase.Text = "Database:"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(106, 107)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(173, 20)
        Me.txtUser.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(106, 147)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(173, 20)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(30, 150)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 12
        Me.lblPassword.Text = "Password:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(30, 110)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(61, 13)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "User name:"
        '
        'lblConnected
        '
        Me.lblConnected.AutoSize = True
        Me.lblConnected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnected.Location = New System.Drawing.Point(386, 27)
        Me.lblConnected.Name = "lblConnected"
        Me.lblConnected.Size = New System.Drawing.Size(96, 20)
        Me.lblConnected.TabIndex = 14
        Me.lblConnected.Text = "Connected"
        Me.lblConnected.Visible = False
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 233)
        Me.Controls.Add(Me.lblConnected)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtDatabase)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.txtServer)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtpReplication)
        Me.Controls.Add(Me.lblReplication)
        Me.Controls.Add(Me.dtpCopy)
        Me.Controls.Add(Me.lblCopy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update availability"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCopy As Label
    Friend WithEvents dtpCopy As DateTimePicker
    Friend WithEvents dtpReplication As DateTimePicker
    Friend WithEvents lblReplication As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblServer As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents lblDatabase As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblConnected As Label
End Class
