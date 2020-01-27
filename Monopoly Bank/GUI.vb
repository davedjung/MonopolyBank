Public Class GUI
    Dim balance1, balance2, balance3, balance4 As Double
    Dim giver, receiver As Integer
    Dim selectFrom, selectTo As Boolean

    Private Sub btnTo_Click(sender As Object, e As EventArgs) Handles btnTo.Click
        selectTo = True
    End Sub

    Private Sub pbxPlayer1_Click(sender As Object, e As EventArgs) Handles pbxPlayer1.Click
        If selectFrom = True Then
            giver = 1
            selectFrom = False
            txtFrom.Text = txtName1.Text
        ElseIf selectTo = True Then
            receiver = 1
            selectTo = False
            txtTo.Text = txtName1.Text
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If giver > 0 Then
            Select Case giver
                Case 1
                    If balance1 < CDbl(txtAmount.Text) Then
                        MessageBox.Show("Not enough balance")
                    Else
                        balance1 = balance1 - CDbl(txtAmount.Text)
                    End If
                Case 2
                    If balance2 < CDbl(txtAmount.Text) Then
                        MessageBox.Show("Not enough balance")
                    Else
                        balance2 = balance2 - CDbl(txtAmount.Text)
                    End If
                Case 3
                    If balance3 < CDbl(txtAmount.Text) Then
                        MessageBox.Show("Not enough balance")
                    Else
                        balance3 = balance3 - CDbl(txtAmount.Text)
                    End If
                Case 4
                    If balance4 < CDbl(txtAmount.Text) Then
                        MessageBox.Show("Not enough balance")
                    Else
                        balance4 = balance4 - CDbl(txtAmount.Text)
                    End If
            End Select
        End If

        If receiver > 0 Then
            Select Case receiver
                Case 1
                    balance1 = balance1 + CDbl(txtAmount.Text)
                Case 2
                    balance2 = balance2 + CDbl(txtAmount.Text)
                Case 3
                    balance3 = balance3 + CDbl(txtAmount.Text)
                Case 4
                    balance4 = balance4 + CDbl(txtAmount.Text)
            End Select
        End If

        lblBalance1.Text = CStr(balance1) + "M"
        lblBalance2.Text = CStr(balance2) + "M"
        lblBalance3.Text = CStr(balance3) + "M"
        lblBalance4.Text = CStr(balance4) + "M"

        selectFrom = False
        selectTo = False
        giver = 0
        receiver = 0

        txtFrom.Text = ""
        txtTo.Text = ""
        txtAmount.Text = ""

        btnFrom.Select()

    End Sub

    Private Sub pbxPlayer2_Click(sender As Object, e As EventArgs) Handles pbxPlayer2.Click
        If selectFrom = True Then
            giver = 2
            selectFrom = False
            txtFrom.Text = txtName2.Text
        ElseIf selectTo = True Then
            receiver = 2
            selectTo = False
            txtTo.Text = txtName2.Text
        End If
    End Sub

    Private Sub pbxPlayer3_Click(sender As Object, e As EventArgs) Handles pbxPlayer3.Click
        If selectFrom = True Then
            giver = 3
            selectFrom = False
            txtFrom.Text = txtName3.Text
        ElseIf selectTo = True Then
            receiver = 3
            selectTo = False
            txtTo.Text = txtName3.Text
        End If
    End Sub

    Private Sub pbxPlayer4_Click(sender As Object, e As EventArgs) Handles pbxPlayer4.Click
        If selectFrom = True Then
            giver = 4
            selectFrom = False
            txtFrom.Text = txtName4.Text
        ElseIf selectTo = True Then
            receiver = 4
            selectTo = False
            txtTo.Text = txtName4.Text
        End If
    End Sub


    Private Sub btnFrom_Click(sender As Object, e As EventArgs) Handles btnFrom.Click
        selectFrom = True
    End Sub

    Private Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        balance1 = 15
        balance2 = 15
        balance3 = 15
        balance4 = 15

        selectFrom = False
        selectTo = False

        giver = 0
        receiver = 0

        pbxPlayer1.BackColor = Color.Red
        pbxPlayer2.BackColor = Color.RoyalBlue
        pbxPlayer3.BackColor = Color.SkyBlue
        pbxPlayer4.BackColor = Color.Coral

    End Sub

    Private Sub btnFrom_KeyDown(sender As Object, e As KeyEventArgs) Handles btnFrom.KeyDown
        If selectFrom = True Then
            If e.KeyCode = Keys.D1 Then
                txtFrom.Text = txtName1.Text
                giver = 1
            End If
            If e.KeyCode = Keys.D2 Then
                txtFrom.Text = txtName2.Text
                giver = 2
            End If
            If e.KeyCode = Keys.D3 Then
                txtFrom.Text = txtName3.Text
                giver = 3
            End If
            If e.KeyCode = Keys.D4 Then
                txtFrom.Text = txtName4.Text
                giver = 4
            End If

            selectFrom = False
            btnTo.Select()
        End If

    End Sub

    Private Sub btnTo_KeyDown(sender As Object, e As KeyEventArgs) Handles btnTo.KeyDown
        If selectTo = True Then
            If e.KeyCode = Keys.D1 Then
                txtTo.Text = txtName1.Text
                receiver = 1
            End If
            If e.KeyCode = Keys.D2 Then
                txtTo.Text = txtName2.Text
                receiver = 2
            End If
            If e.KeyCode = Keys.D3 Then
                txtTo.Text = txtName3.Text
                receiver = 3
            End If
            If e.KeyCode = Keys.D4 Then
                txtTo.Text = txtName4.Text
                receiver = 4
            End If

            selectTo = False
            txtAmount.Select()
        End If

    End Sub
End Class