Imports System.Net.Mail
Public Class FRMdetails

    Dim weddinglocationinweddtbl As Integer



    Private Sub btnupdatedetails_Click(sender As Object, e As EventArgs) Handles btnupdatedetails.Click
        Dim weddingsizeday As Integer = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(9) 'finds the info from the db 
        lblweddingsizeday.Text = $"wedding size(day):{weddingsizeday}" 'prints the info from the db 
        Dim weddingsizenight As Integer = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(10) 'finds the info from DB 
        lblweddsizenight.Text = $"wedding size (evening):{weddingsizenight}" 'puts the info into the label 
        Dim ceremonytime As String = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(4) 'gets the time from the data base 
        lblceromonytime.Text = $"ceremony time: {ceremonytime}" 'shows the time in the label 
        Dim depositpaid As Boolean = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(6)    'finds whether the deposit has been paid from the db
        lbldepositpaid.Text = $"depositpaid: {depositpaid}" 'shows wether the deposit has been paid 
        Dim arrivaldate As String = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(12) 'finds the arrival date of guests 
        lblarrival.Text = $"arrival date: {arrivaldate}"    'displays the arrival date
        Dim leavedate As String = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(13) ' finds the leave data from the database 
        lblleavedate.Text = $"leave date: {leavedate}"  'displays leave date 

    End Sub

    Private Sub FRMdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DS.TBLbooking' table. You can move, or remove it, as needed.
        Me.TBLbookingTableAdapter.Fill(Me.DS.TBLbooking)
        'TODO: This line of code loads data into the 'DS.TBLweddings' table. You can move, or remove it, as needed.
        Me.TBLweddingsTableAdapter.Fill(Me.DS.TBLweddings)
        Dim weddLC As String = clientdash.GlobalweddLC 'gives the loopcount/ location of the id in the database 
        Dim weddID As Integer = Me.DS.TBLbooking.Rows(weddLC)(0) 'finds the weddid 
        Dim rowcount, bookingid As Integer  'sets up variables needed for search
        Dim foundflag As Boolean
        foundflag = False
        rowcount = Me.DS.TBLbooking.Rows.Count - 1
        Do While (weddinglocationinweddtbl < rowcount) And (foundflag = False)  'sets the parameters of the loop 
            bookingid = Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(1) 'sets the bookid
            If bookingid = weddID Then  'checks to see both are the same
                foundflag = True 'both are the same
            Else
                weddinglocationinweddtbl = weddinglocationinweddtbl + 1 'loopcount increases
            End If
            If Not foundflag Then
                MsgBox("ID no longer exists", Title:="error")   'error message
            Else
                MsgBox("conected")  'connected (just temporary for tb) 
            End If
        Loop

    End Sub

    Private Sub btnedit1_Click(sender As Object, e As EventArgs) Handles btnedit1.Click
        Dim newsizeday As Integer = InputBox("what is the new size in the day") 'asks the user for an inout of what the new size will be 
        Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(9) = newsizeday    'updates the database with the users new input 
    End Sub

    Private Sub btnedit2_Click(sender As Object, e As EventArgs) Handles btnedit2.Click
        Dim newsizenight As Integer = InputBox("what is the new size in the evening")   'asks the user for an input for the new value 
        Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(10) = newsizenight 'updates the DB with the new input 

    End Sub

    Private Sub btnedit3_Click(sender As Object, e As EventArgs) Handles btnedit3.Click
        Dim newceremonytime As String = InputBox("what is the new ceromony time")   'asks the user for a new input for the time
        Me.DS.TBLweddings.Rows(weddinglocationinweddtbl)(4) = newceremonytime   'saves the user input into the data base 
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim whattochange As String = InputBox("what detail would  you like to change")  'asks the user what they want to change
        Dim changetowhat As String = InputBox("what do you want to change this detail to")  'asks the user for the new data

        Dim weddLC As String = clientdash.GlobalweddLC  'finds the location of the wedding in booking table 
        Dim weddate As String = Me.DS.TBLbooking.Rows(weddLC)(1)    'finds the date of the event 
        Dim bookingid As String = Me.DS.TBLbooking.Rows(weddLC)(0) 'finds the booking id 
        Dim emailaddres, password, title, emailsender, recipient, emailtext As String

        emailaddres = "tbpracticecoding340754@outlook.com"  'dims the programs email adress
        password = "@Margo13Margo"  'password for program email adress
        title = $"request for wedding details to be changed for wedd {weddate} ID {bookingid} "    'email title generated 
        emailsender = emailaddres
        recipient = "tb340754@truro-penwith.ac.uk"  'currently sends to my account but would send to admin staff 
        emailtext = $"Hi I would like to change the {whattochange} to {changetowhat} if this is doable, please make this change for me" 'sends message

        Try
            Dim Smpt_server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smpt_server.UseDefaultCredentials = False
            Smpt_server.Credentials = New Net.NetworkCredential(emailaddres, password)
            Smpt_server.Port = 587
            Smpt_server.EnableSsl = True
            Smpt_server.Host = "smtp.office365.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress(emailsender)
            e_mail.To.Add(recipient)
            e_mail.Subject = title
            e_mail.IsBodyHtml = False
            e_mail.Body = emailtext
            Smpt_server.Send(e_mail)
            MsgBox("mail sent")



        Catch error_t As Exception
            MsgBox(error_t.ToString)

        End Try
    End Sub
End Class