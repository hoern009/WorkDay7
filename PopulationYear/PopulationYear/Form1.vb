Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim Population As Double = 7000
        Dim numYears As Integer = 2014
        Dim stYears As String

        Do While Population > 6000
            Population = Population / 2
            numYears = numYears - 50
        Loop
        MessageBox.Show(CStr(numYears))

    End Sub
End Class
