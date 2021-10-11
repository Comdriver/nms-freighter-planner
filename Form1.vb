Public Class MainForm

    Dim Level As Integer

    Function Cell(x As Integer, y As Integer) As String
        Return "Cell-" & x.ToString("D2") & "-" & y.ToString("D2")
    End Function

    Function LevelSet(Lev As Integer) As Boolean
        Level = Lev
        CurrentLevel.Text = Lev.ToString("D2")
        Return True
    End Function

    Private Sub CreateNewShip()
        'this should fill arrays with default freighter data ("default.freighter" file)
    End Sub

    Private Sub RedrawCells()
        'this should redraw all cells using current level
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CName As String

        LevelSet(1)

        'data grid creation
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
        CreateNewShip()
    End Sub
End Class
