Public Class frmMain

    Private Sub btnPLay_Click(sender As Object, e As EventArgs) Handles btnPLay.Click

        Dim z As New frmPlay
        z.ShowDialog()

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = My.Resources.abstract
        lblWelcome.Text = "Welcome to Tic-Tac-Toe"

    End Sub
End Class
