Public Class MainForm

    Function Cell(x As Integer, y As Integer) As String
        Return "Cell-" & x.ToString("D2") & "-" & y.ToString("D2")
    End Function

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CName As String

        For x = 1 To Ship.RowCount
            For y = 1 To Ship.ColumnCount
                CName = Cell(x, y)
                Dim pb As New PictureBox With
                {
                .Name = CName,
                .Image = My.Resources.empty,
                .Margin = New Padding(0, 0, 0, 0)
                }
                Ship.Controls.Add(pb)
                ToolTip.SetToolTip(Ship.Controls(CName), CName)
            Next
        Next

    End Sub
End Class
