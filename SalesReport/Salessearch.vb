
Public Class Salessearch
    'Friend compid As String = ""
    'Private acsignon As New AccpacSignonManager.AccpacSignonMgr
    'Friend mSession As New AccpacCOMAPI.AccpacSession
    Friend frmcust As String
    Friend Tocust As String
    Friend fdate As String
    Friend tdate As String

    'Friend xdbcom As AccpacDBLink
    Private Sub Salessearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            rbfun.Checked = True

            'mSession.Init("", "XX", "XX0001", "65A")
            'acsignon.Signon(mSession)
            'compid = mSession.CompanyID
            'xdbcom = mSession.GetDBLink(tagDBLinkTypeEnum.DBLINK_COMPANY, tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)

            'If compid = "" Then

            '    Close()

            '  Else
            'Dim arcv As AccpacView
            'arcv = xdbcom.OpenView2("CS0012")
            'arcv.Browse("OPTFIELD =CUSCAT", True)
            'Dim arcds As DataSet = New DataSet("AR")
            'Dim cust As DataTable = arcds.Tables.Add("ARCAT")
            'Dim name As DataColumn = cust.Columns.Add("VALUE", Type.GetType("System.String"))
            'Dim id As DataColumn = cust.Columns.Add("VDESC", Type.GetType("System.String"))

            'Dim row As DataRow
            'row = cust.NewRow()
            'Do While arcv.FilterFetch(False)
            '    Dim cid As String = arcv.Fields.FieldByName("VALUE").Value.ToString()
            '    Dim cn As String = arcv.Fields.FieldByName("VDESC").Value.ToString()
            '    row("VALUE") = cid
            '    row("VDESC") = cn
            '    arcds.Tables(0).Rows.Add(row)
            '    row = cust.NewRow()
            'Loop
            Dim c As New Clsfunct
            Dim arcds As New DataSet
            arcds = c.optfield(" Where OPTFIELD ='CUSCAT'", OPCompany.compid)
            arcds.Tables(0).Rows.Add("0", "--ALL--")
            CBCuscat.DataSource = arcds.Tables(0)
            CBCuscat.DisplayMember = "VDESC"
            CBCuscat.ValueMember = "VALUE"

            'Dim icv As AccpacView
            'icv = xdbcom.OpenView2("CS0012")
            'icv.Browse("OPTFIELD =ITMCAT1", True)
            'Dim icds As DataSet = New DataSet("IC")
            'Dim item As DataTable = icds.Tables.Add("ICCAT")
            'Dim Iname As DataColumn = item.Columns.Add("VALUE", Type.GetType("System.String"))
            'Dim Iid As DataColumn = item.Columns.Add("VDESC", Type.GetType("System.String"))

            'Dim irow As DataRow
            'irow = item.NewRow()
            'Do While icv.FilterFetch(False)
            '    Dim itid As String = icv.Fields.FieldByName("VALUE").Value.ToString()
            '    Dim itn As String = icv.Fields.FieldByName("VDESC").Value.ToString()
            '    irow("VALUE") = itid
            '    irow("VDESC") = itn
            '    icds.Tables(0).Rows.Add(irow)

            '    irow = item.NewRow()
            'Loop

            Dim icds As New DataSet
            icds = c.optfield(" Where OPTFIELD ='ITMCAT1'", OPCompany.compid)
            icds.Tables(0).Rows.Add("0", "--All--")
            CBITMCAT.DataSource = icds.Tables(0)
            CBITMCAT.DisplayMember = "VDESC"
            CBITMCAT.ValueMember = "VALUE"

            Txttocus.Text = "zzzzzzzzzzzzzzzzzz"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMD_OK_Click(sender As Object, e As EventArgs) Handles CMD_OK.Click
        Try
            Dim fmonthnew As String = 0
            If DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & DateTimePicker1.Value.Month
            Else
                fmonthnew = DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & DateTimePicker2.Value.Month
            Else
                tmonthnew = DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & DateTimePicker1.Value.Day
            Else
                fdaynew = DateTimePicker1.Value.Day
            End If
            Dim tdaynew As String = 0
            If DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & DateTimePicker2.Value.Day
            Else
                tdaynew = DateTimePicker2.Value.Day
            End If

            fdate = DateTimePicker1.Value.Year & fmonthnew & fdaynew

            tdate = DateTimePicker2.Value.Year & tmonthnew & tdaynew
            If Trim(txtfrmcus.Text) <= Trim(Txttocus.Text) Then
                If fdate <= tdate Then
                    crviewer.Show()
                Else
                    MessageBox.Show("From Date  greater than To Date")
                End If
            Else
                MessageBox.Show("From Customer No greater than To Customer No")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CMD_Exit_Click(sender As Object, e As EventArgs) Handles CMD_Exit.Click
        Close()
    End Sub

    Private Sub bffind_Click(sender As Object, e As EventArgs) Handles bffind.Click
        Scrfromcust.Show()
    End Sub

    Private Sub btfind_Click(sender As Object, e As EventArgs) Handles btfind.Click
        ScrTocust.Show()
    End Sub

End Class
