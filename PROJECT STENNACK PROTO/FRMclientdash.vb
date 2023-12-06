Public Class clientdash
    Public Shared GlobalweddLC As Integer

    Private Sub btnviewdetails_Click(sender As Object, e As EventArgs) Handles btnviewdetails.Click
        Dim dbweddingid, inputid, rowcount, loopcount As Integer    'sets up variables needed for linear search
        Dim idfound As Boolean
        idfound = False
        inputid = txtweddid.Text    'gets the data from the text box
        rowcount = Me.DS.TBLbooking.Rows.Count - 1 'finds the size of the table 
        loopcount = 0

        Do While (loopcount < rowcount) And (idfound = False)
            dbweddingid = Me.DS.TBLbooking.Rows(loopcount)(0)    'sets the value of the database id 
            If inputid = dbweddingid Then   'compares the two ids 
                idfound = True  'flags that its true 
            Else
                loopcount = loopcount + 1 'increases loop by one 
            End If

        Loop
        If Not idfound Then
            MsgBox("ID cannot be found", Title:="error")    'ifnroms user that id is incorrect 
        Else
            'MsgBox("foundinit")
            GlobalweddLC = loopcount
            Me.Hide()
            FRMdetails.ShowDialog()

        End If
    End Sub

    Private Sub clientdash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.TBLbooking' table. You can move, or remove it, as needed.
        Me.TBLbookingTableAdapter.Fill(Me.DS.TBLbooking)

    End Sub
End Class