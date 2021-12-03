Option Strict Off
Option Explicit On

Public Class Form1

    Private Sub OurEventHandler(sender As Object, e As EventArgs) Handles Button1.Click

        Dim button As Button
        button = CType(sender, Button)
        Dim holderBoots, holderNoBoots, noBoots, boots, dailyTotal As Double


        holderNoBoots = txtNoBoots.Text
        holderBoots = txtBoots.Text

        noBoots = 20.0 * holderNoBoots
        boots = 30.0 * holderBoots

        dailyTotal = noBoots + boots

        txtDaily.Text = dailyTotal

        txtFullName.Text = txtName.Text
        TextBox1.Text = txtId.Text


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        txtNoBoots.Text = "0"
        txtBoots.Text = "0"
        txtName.Text = ""
        txtId.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtFullName.Text = ""
        TextBox1.Text = ""
        txtDaily.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtFullName.Text = ""
        TextBox1.Text = ""
        txtDaily.Text = ""
        txtNoBoots.Text = "0"
        txtBoots.Text = "0"
        txtName.Text = ""
        txtId.Text = ""

    End Sub
End Class
