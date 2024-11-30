
Imports MySql.Data.MySqlClient
Public Class Form2


    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim dbDataSet As New DataTable
    Dim dt As DataTable
    Dim gender As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        conn = New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            MessageBox.Show("Connection successful!")

            Dim query = "INSERT INTO Users (ID, Name, Surname, Age, Gender, DOB) VALUES (@ID, @Name, @Surname, @Age, @Gender, @DOB)"
            command = New MySqlCommand(query, conn)

            command.Parameters.AddWithValue("@ID", IDTextBox1.Text)
            command.Parameters.AddWithValue("@Name", NameTextBox2.Text)
            command.Parameters.AddWithValue("@Surname", SurnameTextBox3.Text)
            command.Parameters.AddWithValue("@Age", AgeTextBox4.Text)
            command.Parameters.AddWithValue("@Gender", gender)
            command.Parameters.AddWithValue("@DOB", dobPicker.Text)

            Dim results = command.ExecuteNonQuery
            MessageBox.Show(If(results > 0, "Data Saved Successfully!", "Data Save Failed!"))

        Catch ex As MySqlException

            MessageBox.Show("Error: " & ex.Message & vbCrLf & "Stack Trace: " & ex.StackTrace)
        Finally

            If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

        load_table()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            MessageBox.Show("Connection successful!")

            Dim query = "UPDATE Users SET Name = @Name, Surname = @Surname, Age = @Age WHERE ID = @ID"

            command = New MySqlCommand(query, conn)

            command.Parameters.AddWithValue("@ID", IDTextBox1.Text)
            command.Parameters.AddWithValue("@Name", NameTextBox2.Text)
            command.Parameters.AddWithValue("@Surname", SurnameTextBox3.Text)
            command.Parameters.AddWithValue("@Age", AgeTextBox4.Text)

            Dim results = command.ExecuteNonQuery
            MessageBox.Show("Data Updated  Successfully!")

        Catch ex As MySqlException

            MessageBox.Show(ex.Message)
        Finally

            conn.Dispose()

        End Try
        load_table()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        conn = New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Try
            conn.Open()
            Dim query = "DELETE FROM users WHERE ID = @ID"
            command = New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@ID", IDTextBox1.Text)
            Dim results = command.ExecuteNonQuery()
            If results > 0 Then
                MessageBox.Show("Data Deleted Successfully!")
                load_table()
            Else
                MessageBox.Show("No data found with the specified ID.")
            End If
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

        Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim query = "SELECT * FROM users"
            Dim command As New MySqlCommand(query, conn)

            reader = command.ExecuteReader()

            While reader.Read()
                Dim sName As String = reader.GetString("Name")
                NameComboBox1.Items.Add(sName)

                ListBox1.Items.Add(sName)
            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            If reader IsNot Nothing Then reader.Close()
            conn.Dispose()
        End Try
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NameComboBox1.SelectedIndexChanged
        Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query = "SELECT * FROM users where name = @Name"
            Dim command As New MySqlCommand(query, conn)

            command.Parameters.AddWithValue("@Name", NameComboBox1.Text)

            reader = command.ExecuteReader()

            While reader.Read()
                IDTextBox1.Text = reader.GetInt32("ID")
                NameTextBox2.Text = reader.GetString("Name")
                SurnameTextBox3.Text = reader.GetString("Surname")
                AgeTextBox4.Text = reader.GetInt32("Age")

            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            If reader IsNot Nothing Then reader.Close()
            conn.Dispose()
        End Try
    End Sub




    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim reader As MySqlDataReader

        Try
            conn.Open()
            Dim query = "SELECT * FROM users where name = @Name"
            Dim command As New MySqlCommand(query, conn)

            command.Parameters.AddWithValue("@Name", ListBox1.Text)

            reader = command.ExecuteReader()

            While reader.Read()
                IDTextBox1.Text = reader.GetInt32("ID")
                NameTextBox2.Text = reader.GetString("Name")
                SurnameTextBox3.Text = reader.GetString("Surname")
                AgeTextBox4.Text = reader.GetInt32("Age")

            End While

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            If reader IsNot Nothing Then reader.Close()
            conn.Dispose()
        End Try
    End Sub



    Private Sub load_table()
        Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try

            dbDataSet.Clear()

            Dim query As String = "SELECT * FROM vbmysql.users"
            command = New MySqlCommand(query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim conn As New MySqlConnection("server=localhost;userid=root;password='';database=vbmysql")
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            conn.Open()
            dbDataSet.Clear()

            Dim query As String = "SELECT * FROM vbmysql.users"
            command = New MySqlCommand(query, conn)
            SDA.SelectCommand = command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Me.DataGridView1.Rows(e.RowIndex)

            IDTextBox1.Text = row.Cells("ID").Value.ToString()
            NameTextBox2.Text = row.Cells("Name").Value.ToString()
            SurnameTextBox3.Text = row.Cells("Surname").Value.ToString()
            AgeTextBox4.Text = row.Cells("Age").Value.ToString()
        End If
    End Sub


    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged

        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Name Like '%{0}%'", SearchTextBox.Text)
        DataGridView1.DataSource = DV
    End Sub



    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Female_CheckedChanged(sender As Object, e As EventArgs) Handles Female.CheckedChanged
        gender = "Female"
    End Sub

    Private Sub Male_CheckedChanged(sender As Object, e As EventArgs) Handles Male.CheckedChanged
        gender = "Male"
    End Sub
End Class 'end class'
