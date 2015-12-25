Option Strict On
Public Class Form1

    Private Sub btnCheckEntry_Click(sender As Object, e As EventArgs) Handles btnCheckEntry.Click

        'user should type a number
        Dim intAge As Integer
        If Integer.TryParse(txtInput.Text, intAge) Then
            MsgBox("you entered: " + intAge.ToString)
        Else
            MsgBox("please enter a valid number!!!")
        End If

        'enter a number
        If intAge < 18 Or
            rbDenim.Checked = True Or
            rbThongs.Checked = True Or
            rbTShirt.Checked = True Then
            MsgBox("No-one under 18 is permitted. No-one wearing denim, thongs or 'T' Shirts are permitted.")
            Me.BackColor = Color.Red
        Else
            MsgBox("Come In")
            Me.BackColor = Color.Green

        End If


    End Sub

End Class
