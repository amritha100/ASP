Public Class _Resume
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Label11.Text = "Fill in the required details"
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'output

        Label13.Text = "NAME: " + TextBox1.Text
        Label14.Text = "DOB: " + TextBox2.Text
        Label15.Text = "AGE: " + TextBox3.Text
        Label17.Text = "ADDRESS: " + TextBox4.Text
        Label18.Text = "CONTACT NO:  " + TextBox5.Text
        Label19.Text = "MAIL-ID: " + TextBox6.Text
    End Sub


    Protected Sub Male_CheckedChanged(sender As Object, e As EventArgs) Handles Male.CheckedChanged
        If (Male.Checked = True) Then
            Label16.Text = ("GENDER: " + Male.Text)
        End If
    End Sub
    Protected Sub Female_CheckedChanged(sender As Object, e As EventArgs) Handles Female.CheckedChanged
        If (Female.Checked = True) Then
            Label16.Text = ("GENDER: " + Female.Text)
        End If
    End Sub

    Protected Sub Other_CheckedChanged(sender As Object, e As EventArgs) Handles Other.CheckedChanged
        If (Other.Checked = True) Then
            Label16.Text = ("GENDER: " + Other.Text)
        End If
    End Sub


    'DropdownList
    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        If (DropDownList1.SelectedValue = "-1") Then
            Label20.Text = ("Please select your education")
        Else
            Label20.Text = ("EDUCATION: " + DropDownList1.SelectedItem.Text + " ")
        End If
    End Sub
    'ListBox1
    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If (ListBox1.SelectedValue = "-1") Then
            Label21.Text = ("Please select your Hobby")
        Else
            Label21.Text = ("HOBBIES: " + ListBox1.SelectedItem.Text + " ")
        End If
    End Sub

    'checkbox
    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles YES.CheckedChanged

        If YES.Checked = True Then

            Label22.Text = "DO YOU HAVE ANY EXPERIENCE: " + YES.Text
        End If
    End Sub

    Protected Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles NO.CheckedChanged
        If (NO.Checked = True) Then
            Label22.Text = "DO YOU HAVE ANY EXPERIENCE: " + NO.Text
        End If
    End Sub


End Class
