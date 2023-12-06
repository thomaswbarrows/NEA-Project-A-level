Public Class FRMlogin
    Public dbusername, dbpassword As String 'establashes password and username variables 
    Public dblocation As Integer 'means that user can be located even if loop count changes 
    Private Sub FRMlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DBset.TBLusers' table. You can move, or remove it, as needed.
        Me.TBLusersTableAdapter.Fill(Me.DS.TBLusers)

    End Sub

    Private Sub btnguest_Click(sender As Object, e As EventArgs) Handles btnguest.Click
        txtusername.Text = "Guest"
        txtpassword.Text = "Guest1"
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim loopcount, rowcount, level, dblevel As Integer
        Dim username, password As String             'sets up all the variqbles needed for a login system 
        Dim userfound As Boolean

        username = txtusername.Text     'sets the content of the text boxes as a variable 
        password = txtpassword.Text
        rowcount = Me.DS.TBLusers.Rows.Count - 1 'finds how many rows are in the database
        loopcount = 0  'sets  the loop count to 0 
        userfound = False  'no user has been found as we havent started the search yet 

        Do While (loopcount <= rowcount) And (userfound = False)    'starts a while loop for when the whole data base has not been searched
            dbusername = Me.DS.TBLusers.Rows(loopcount)(1).ToString() 'looks at each line inrementally to compare the username of each user 
            If username = dbusername Then 'checks to see if inputted username matches the username of the name on the row of the data base that is being inspected 
                userfound = True
            Else
                loopcount = loopcount + 1 'searches next line
            End If
        Loop
        dblocation = loopcount 'sets up a locator so loopcount can be changed
        If Not userfound Then
            MsgBox("user not found", Title:="error") 'if username cannot be found then error message appears 
        Else
            dbpassword = Me.DS.TBLusers.Rows(dblocation)(2).ToString()  'finds the password from the data base 
            If password <> dbpassword Then 'checks to see if the two passwords are not equal 
                MsgBox("password does not match", Title:="error") 'if the passwords dont match an error box appears 
            Else
                dblevel = Me.DS.TBLusers.Rows(dblocation)(3)  'finds the user level from the database 
                level = dblevel
                txtpassword.Text = ""       'clears the text boxes 
                txtusername.Text = ""
                Me.Hide()
                Select Case level    'takes different users with different levels to their respective pages. 
                    Case 1
                        FRMadmindash.ShowDialog()
                    Case 2
                        FRMstaffdash.ShowDialog()
                    Case 3
                        clientdash.ShowDialog()
                    Case 4
                        clientdash.ShowDialog()

                End Select







            End If

        End If


    End Sub
End Class
