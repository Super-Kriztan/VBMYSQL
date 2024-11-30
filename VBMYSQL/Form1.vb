Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password='';database=vbmysql"
        }

        Try

            conn.Open()
            MessageBox.Show("Connection Successful")
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally

            conn.Close()
        End Try
    End Sub


    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles UnTextBox1.MaskInputRejected

        PassTextBox2.Text = UnTextBox1.Text
    End Sub

    Private Sub PassTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PassTextBox2.MaskInputRejected

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrWhiteSpace(UnTextBox1.Text) Or String.IsNullOrWhiteSpace(PassTextBox2.Text) Then
            MessageBox.Show("Please enter both Username and Password.")
            Return
        End If

        Try

            conn.Open()
            Dim query As String = "SELECT * FROM Users WHERE Username = @Username AND Password = @Password"
            command = New MySqlCommand(query, conn)


            command.Parameters.AddWithValue("@Username", UnTextBox1.Text)
            command.Parameters.AddWithValue("@Password", PassTextBox2.Text)

            reader = command.ExecuteReader()

            Dim count As Integer = 0

            While reader.Read()
                count += 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                Form2.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are Duplicate")

            Else
                MessageBox.Show("Username and Password are not correct")
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally

            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection With {
           .ConnectionString = "server=localhost;userid=root;password='';database=vbmysql"
       }

        Try

            conn.Open()
            MessageBox.Show("Connection Successful")
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally

            conn.Close()
        End Try
    End Sub
End Class
