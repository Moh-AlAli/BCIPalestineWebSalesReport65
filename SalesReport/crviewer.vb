Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports CrystalDecisions.Windows.Forms


Public Class crviewer

    Private rdoc As New ReportDocument
    Private conrpt As New ConnectionInfo()
    Private server As String = ""
    Private uid As String = ""
    Private pass As String = ""
    Private odbc As String = ""

    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function
    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function
    Friend Function Readconnectionstring() As String

        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\bcicon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()
        odbc = sr.ReadLine()

        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)
        odbc = Decryption(odbc, secretkey)

        Dim cons As String = "" ' = "Data Source =" & server & "; DataBase =" & Agescreen.compid & "; User Id =" & uid & "; Password =" & pass & ";"

        Return cons
    End Function
    Private Sub crviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            Dim cwvr As New CrystalReportViewer
            cwvr.Dock = DockStyle.Fill
            cwvr.BorderStyle = BorderStyle.None
            Me.Controls.Add(cwvr)


            rdoc.Load("reports\salesreport.rpt")


            Dim tabs As Tables = rdoc.Database.Tables
            Dim parv As New ParameterValues
            Dim dis As New ParameterDiscreteValue


            Dim fmonthnew As String = 0

            If Salessearch.DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & Salessearch.DateTimePicker1.Value.Month
            Else
                fmonthnew = Salessearch.DateTimePicker1.Value.Month
            End If

            Dim tmonthnew As String = 0

            If Salessearch.DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & Salessearch.DateTimePicker2.Value.Month
            Else
                tmonthnew = Salessearch.DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0

            If Salessearch.DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & Salessearch.DateTimePicker1.Value.Day
            Else
                fdaynew = Salessearch.DateTimePicker1.Value.Day
            End If

            Dim tdaynew As String = 0

            If Salessearch.DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & Salessearch.DateTimePicker2.Value.Day
            Else
                tdaynew = Salessearch.DateTimePicker2.Value.Day
            End If


            Dim fdate As String = Salessearch.DateTimePicker1.Value.Year & "-" & fmonthnew & "-" & fdaynew

            Dim tdate As String = Salessearch.DateTimePicker2.Value.Year & "-" & tmonthnew & "-" & tdaynew
            Dim optcut As String = ""
            If Salessearch.CBCuscat.SelectedValue = "0" Then
                optcut = "'%%'"
            Else
                optcut = "'" & Salessearch.CBCuscat.SelectedValue & "'"
            End If

            Dim optitem As String = ""

            If Salessearch.CBITMCAT.SelectedValue = "0" Then
                optitem = "'%%'"
            Else
                optitem = "'" & Salessearch.CBITMCAT.SelectedValue & "'"
            End If



            Readconnectionstring()


   For Each TAB As CrystalDecisions.CrystalReports.Engine.Table In tabs
                Dim tablog As TableLogOnInfo = TAB.LogOnInfo
                conrpt.ServerName = "ACCPAC" 'odbc '
                conrpt.DatabaseName = OPCompany.compid
                conrpt.UserID = "sa" ' uid '
                conrpt.Password = "admin@123" ' pass ' 
                tablog.ConnectionInfo = conrpt
                TAB.ApplyLogOnInfo(tablog)
            Next

            Dim type As String = ""
            If Salessearch.rbfun.Checked = True Then
                type = "F"
            ElseIf Salessearch.Rbsrc.Checked = True Then
                type = "S"
            End If

            rdoc.SetParameterValue("cfdate", "'" & fdate & "'")
            rdoc.SetParameterValue("dtdate", "'" & tdate & "'")
            rdoc.SetParameterValue("afcust", "'" & Salessearch.txtfrmcus.Text & "'")
            rdoc.SetParameterValue("btcust", "'" & Salessearch.Txttocus.Text & "'")
            rdoc.SetParameterValue("eoptcust", optcut)
            rdoc.SetParameterValue("foptitem", optitem)
            rdoc.SetParameterValue("Type", type)


            cwvr.ReportSource = rdoc


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If rdoc Is Nothing Then
                rdoc.Close()
                rdoc.Dispose()
            End If
        End Try
    End Sub
End Class




