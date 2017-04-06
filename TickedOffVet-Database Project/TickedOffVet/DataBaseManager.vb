Imports MySql.Data.MySqlClient

Public Class DataBaseManager
    'This class is used to establish connection to database and manipulate data using function calls which feeds sql query
    'query to the database
    Private conn As MySqlConnection

    Public Sub New(database As String)
        'create connect sub
        connect(database)
    End Sub

    Private Sub connect(database As String)
        Try
            'create the connection string
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;database=" & database & ""

            'open connection
            conn.Open()
            'MsgBox("Connection Success")
        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)

            'destroy connection
            conn = Nothing

        End Try
    End Sub

    Public Function loadcmbSpecies(table As String,
                                   Optional fields As String = "*",
                                   Optional where As String = "",
                                   Optional orderBy As String = "") As MySqlDataReader

        Dim query As String = "select " & fields & " from " & table

        'check if where condition applies
        If where <> "" Then
            query &= " where " & where
        End If

        'check if orderBy condition applies
        If orderBy <> "" Then
            query &= " order by " & orderBy
        End If

        Try
            'create the command
            Dim command = New MySqlCommand(query, conn)
            Return command.ExecuteReader

        Catch ex As MySqlException

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
        Return Nothing

    End Function

    Public Function loadStatistics(table As String,
                                  Optional fields As String = "*",
                                  Optional where As String = "",
                                  Optional orderBy As String = "") As MySqlDataReader

        Dim query As String = "select " & fields & " from " & table

        'check if where condition applies
        If where <> "" Then
            query &= " where " & where
        End If

        'check if orderBy condition applies
        If orderBy <> "" Then
            query &= " order by " & orderBy
        End If

        Try
            'create the command
            Dim command = New MySqlCommand(query, conn)
            Return command.ExecuteReader

        Catch ex As MySqlException

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
        Return Nothing

    End Function
    Public Function showStatistics(table As String,
                                    Optional fields As String = "*",
                                  Optional where As String = "",
                                  Optional orderBy As String = "") As MySqlDataReader

        Dim query As String = "select " & fields & " from " & table

        'check if where condition applies
        If where <> "" Then
            query &= " where " & where
        End If

        'check if orderBy condition applies
        If orderBy <> "" Then
            query &= " order by " & orderBy
        End If

        Try
            'create the command
            Dim command = New MySqlCommand(query, conn)
            Return command.ExecuteReader

        Catch ex As MySqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try
        Return Nothing

    End Function

    Public Sub disconnect()
        conn.Close()
        conn.Dispose()
    End Sub

End Class
