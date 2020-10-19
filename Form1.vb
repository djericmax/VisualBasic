Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form1
    Private Sub carregaMySql()
        Using con As MySqlConnection = GetConnectionMySQL()
            Try
                con.Open()
                Dim sql As String = "select * from cliente"
                Dim cmd As MySqlCommand = New MySqlCommand(sql, con)
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvDados.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub carregaSqlServer()
        Using con As SqlConnection = GetConnectionSQLServer()
            Try
                con.Open()
                Dim sql As String = "select * from produto"
                Dim cmd As SqlCommand = New SqlCommand(sql, con)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dgvDados.DataSource = dt
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try
        End Using
    End Sub

    Private Sub mnuMysql_Click(sender As Object, e As EventArgs) Handles mnuMysql.Click
        carregaMySql()
    End Sub

    Private Sub somar()
        If (txtValor1.Text <> "" And txtValor2.Text <> "") Then
            If (txtValor2.Enabled = False) Then
                txtValor2.Enabled = True
            End If
            Dim valor1 As Double
            Dim valor2 As Double
            valor1 = txtValor1.Text
            valor2 = txtValor2.Text
            lblResult.Text = valor1 + valor2
        End If
    End Sub

    Private Sub subtrair()
        If (txtValor1.Text <> "" And txtValor2.Text <> "") Then
            If (txtValor2.Enabled = False) Then
                txtValor2.Enabled = True
            End If
            Dim valor1 As Double
            Dim valor2 As Double
            valor1 = txtValor1.Text
            valor2 = txtValor2.Text
            lblResult.Text = valor1 - valor2
        End If
    End Sub

    Private Sub multiplicar()
        If (txtValor1.Text <> "" And txtValor2.Text <> "") Then
            If (txtValor2.Enabled = False) Then
                txtValor2.Enabled = True
            End If
            Dim valor1 As Double
            Dim valor2 As Double
            valor1 = txtValor1.Text
            valor2 = txtValor2.Text
            lblResult.Text = valor1 * valor2
        End If
    End Sub

    Private Sub dividir()
        If (txtValor1.Text <> "" And txtValor2.Text <> "") Then
            If (txtValor2.Enabled = False) Then
                txtValor2.Enabled = True
            End If
            Dim valor1 As Double
            Dim valor2 As Double
            valor1 = txtValor1.Text
            valor2 = txtValor2.Text
            lblResult.Text = valor1 / valor2
        End If
    End Sub

    Private Sub elevar()
        If (txtValor1.Text <> "" And txtValor2.Text <> "") Then
            If (txtValor2.Enabled = False) Then
                txtValor2.Enabled = True
            End If
            Dim valor1 As Double
            Dim valor2 As Double
            valor1 = txtValor1.Text
            valor2 = txtValor2.Text
            lblResult.Text = valor1 ^ valor2
        End If
    End Sub

    Private Sub raiz()
        If (txtValor1.Text <> "") Then
            Dim valor1 As Double
            valor1 = txtValor1.Text
            txtValor2.Enabled = False
            lblResult.Text = Math.Sqrt(valor1)
        End If
    End Sub

    Private Sub limpar()
        If (txtValor2.Enabled = False) Then
            txtValor2.Enabled = True
        End If
        txtValor1.Text = ""
        txtValor2.Text = ""
        lblResult.Text = ""
        dgvDados.DataSource = Nothing
    End Sub

    Private Sub btnMysql_Click(sender As Object, e As EventArgs) Handles btnMysql.Click
        carregaMySql()
    End Sub

    Private Sub btnSqlServer_Click(sender As Object, e As EventArgs) Handles btnSqlServer.Click
        carregaSqlServer()
    End Sub

    Private Sub mnuSqlServer_Click(sender As Object, e As EventArgs) Handles mnuSqlServer.Click
        carregaSqlServer()
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        If (MsgBox("Deseja sair?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
            Application.Exit()
        Else

        End If
    End Sub

    Private Sub btnSoma_Click(sender As Object, e As EventArgs) Handles btnSoma.Click
        somar()
    End Sub

    Private Sub btnSubtrai_Click(sender As Object, e As EventArgs) Handles btnSubtrai.Click
        subtrair()
    End Sub

    Private Sub btnMultiplica_Click(sender As Object, e As EventArgs) Handles btnMultiplica.Click
        multiplicar()
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        dividir()
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        elevar()
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        raiz()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        limpar()
    End Sub
End Class
