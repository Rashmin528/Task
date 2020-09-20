Imports System.IO

Public Class Form1
    Private openfile As OpenFileDialog
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            openfile = New OpenFileDialog
            openfile.Filter = "  All folder | *.xlsm |  Excel file | *.*"
            openfile.Title = "Select files."
            openfile.CheckFileExists = True
            openfile.Multiselect = True
            openfile.RestoreDirectory = False

            If openfile.ShowDialog = Windows.Forms.DialogResult.OK Then
                openfile.SafeFileNames.Count()
                For i As Integer = 0 To openfile.SafeFileNames.Count() - 1
                    lstfilenames.Items.Add(openfile.SafeFileNames(i))
                    lstfilepaths.Items.Add(openfile.FileNames(i))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
