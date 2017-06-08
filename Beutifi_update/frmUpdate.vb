Imports System.Data.SqlClient

Public Class frmUpdate

    Dim stringConnection As String  'Variable to store the connection string with all de parameters typed by the user

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If btnCheck.Text = "Check" Then     'Form fill-up check
            If txtServer.Text = String.Empty Then
                EmptyNotice()
                txtServer.Focus()
            ElseIf txtDatabase.Text = String.Empty Then
                EmptyNotice()
                txtDatabase.Focus()
            ElseIf txtUser.Text = String.Empty Then
                EmptyNotice()
                txtUser.Focus()
            ElseIf txtPassword.Text = String.Empty Then
                EmptyNotice()
                txtPassword.Focus()
            Else    'Performs connection data check by trying to create and open a connection

                'Remote connection string: 
                stringConnection = "Data Source=" & txtServer.Text & ";Initial Catalog=" & txtDatabase.Text &
                   ";User ID=" & txtUser.Text & ";Password=" & txtPassword.Text & ";Connection Timeout=50;"

                Try
                    Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection(stringConnection)
                    sqlConnection1.Open()
                    sqlConnection1.Close()
                    DisableConnection()
                    'User basic guidelines
                    MsgBox("Copy date is a date with a correct availability." & vbCrLf &
                   "Replication date is the date from when availability will be filled." & vbCrLf &
                   "Both dates should be the same day of the week.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Connection established")
                    ShowUpdate()
                Catch ex As Exception
                    MsgBox("Connection error. Review data and try again." & vbCrLf & vbCrLf & ex.Message,
                                    MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                End Try
            End If
        Else    'Allows change connection data
            HideUpdate()
            UpdateReset()
            EnableConnection()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If Not dtpCopy.Value.DayOfWeek = dtpReplication.Value.DayOfWeek Then    'Same day of week check
            MsgBox("Different day of week selected in both date fields", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning!")
        Else
            'Operation variables
            Dim Interval As Integer = DateDiff(DateInterval.Day, dtpCopy.Value, dtpReplication.Value)
            Dim week As Date = DateAdd(DateInterval.Day, 6, dtpCopy.Value)

            Dim stringSelect As String = "SELECT StaffID, StartDate, EndDate FROM Schedule WHERE StartDate BETWEEN '" _
                & dtpCopy.Value.ToString("yyyy/MM/dd") & "' AND '" & week.ToString("yyyy/MM/dd") & "' ORDER BY StartDate"
            Dim stringInsert As String

            'Execution variables
            Dim command As SqlCommand
            Dim da As SqlDataAdapter
            Dim ds As New DataSet
            Dim dsCheck As New DataSet

            Try
                Dim connection As New SqlClient.SqlConnection
                connection.ConnectionString = stringConnection
                command = New SqlCommand(stringSelect, connection)
                command.CommandTimeout = 3000
                da = New SqlDataAdapter(command)
                da.Fill(ds, "Schedule")     'Fetching original data to replicate into a data set
                Dim rowNumber As Integer = ds.Tables("Schedule").Rows.Count
                If rowNumber > 0 Then
                    Dim fila As DataRow
                    'Remote server autogenerates primary key, but local testing copy doesn't, so we needed PK variable in development environment
                    'Dim PK As Integer = 2000000

                    'Variables to use in the insert string
                    Dim staff As Integer
                    Dim startAvailability As Date
                    Dim endAvailability As Date

                    Dim count As Integer = 0    'counter to save the rows added during the update

                    For i = 0 To rowNumber - 1      'Rows start at 0
                        fila = ds.Tables("Schedule").Rows(i)
                        For j = 0 To 13     'Replicates data 14 weeks
                            staff = fila("StaffID")

                            'Variables used to preserve the original timetable
                            startAvailability = DateAdd(DateInterval.Day, Interval + (7 * j), fila("StartDate"))
                            endAvailability = DateAdd(DateInterval.Day, Interval + (7 * j), fila("EndDate"))

                            stringInsert = "INSERT Schedule (ScheduleID, StaffID, StartDate, EndDate, CreatedOn, UpdatedOn) VALUES (" _
                                & staff & ", '" & startAvailability & "', '" & endAvailability & "', '" & Today & "', '" & Today & "')"

                            Try
                                Dim sqlConnection1 As New System.Data.SqlClient.SqlConnection(stringConnection)
                                Dim cmd = New System.Data.SqlClient.SqlCommand
                                cmd.CommandType = System.Data.CommandType.Text
                                cmd.CommandText = stringInsert
                                cmd.Connection = sqlConnection1

                                sqlConnection1.Open()
                                cmd.ExecuteNonQuery()
                                count += 1
                                sqlConnection1.Close()

                            Catch ex As Exception
                                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
                            End Try
                            'PK += 1
                        Next
                    Next
                    MsgBox(count & " rows added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Update finished")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub

    Private Sub EmptyNotice()
        MsgBox("All fields must be filled", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning!")
    End Sub

    Private Sub HideUpdate()    'Hides update section
        lblConnected.Visible = False
        lblCopy.Visible = False
        dtpCopy.Visible = False
        lblReplication.Visible = False
        dtpReplication.Visible = False
        btnUpdate.Visible = False
    End Sub

    Private Sub ShowUpdate()    'Shows update section
        lblConnected.Visible = True
        lblCopy.Visible = True
        dtpCopy.Visible = True
        lblReplication.Visible = True
        dtpReplication.Visible = True
        btnUpdate.Visible = True
    End Sub

    Private Sub DisableConnection()     'Blocks connection data controls to avoid changing values during 
        txtServer.Enabled = False       'update setting or execution and changes button text property
        txtDatabase.Enabled = False
        txtUser.Enabled = False
        txtPassword.Enabled = False
        btnCheck.Text = "Back"
    End Sub

    Private Sub EnableConnection()      'Enables connection data controls and changes button text property
        txtServer.Enabled = True
        txtDatabase.Enabled = True
        txtUser.Enabled = True
        txtPassword.Enabled = True
        btnCheck.Text = "Check"
    End Sub

    Private Sub UpdateReset()       'Restarts data field values
        dtpCopy.ResetText()
        dtpReplication.ResetText()
    End Sub
End Class