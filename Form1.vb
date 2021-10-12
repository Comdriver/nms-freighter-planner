Public Class MainForm

    Dim Level As Integer    'keeps current selected level

    Function Cell(x As Integer, y As Integer) As String
        'this turns coords into cell name
        Return "Cell-" & x.ToString("D2") & "-" & y.ToString("D2")
    End Function

    Function LevelSet(Lev As Integer) As Boolean
        'just something weird
        Level = Lev
        CurrentLevel.Text = Lev.ToString("D2")
        Return True
    End Function

    Private Sub CreateNewShip()
        'this should fill arrays with default freighter data ("default.freighter" file)

        'and when arrays are filled, we should do this
        RedrawCells()
    End Sub

    Private Sub RedrawCells()
        'this should redraw all cells using current level
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CName As String

        'here should be created array for 21x21x14 cells, will add later
        'possibly should add rotation as another array item?
        'and anothr one for placed items

        'starting at command bridge level
        LevelSet(1)

        'image data grid creation

        For x = 1 To Ship.RowCount
            For y = 1 To Ship.ColumnCount
                CName = Cell(x, y)
                Dim pb As New PictureBox With
                {
                .Name = CName,
                .BackgroundImage = My.Resources.empty,
                .Margin = New Padding(0, 0, 0, 0),
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .BackgroundImageLayout = ImageLayout.Stretch
                }
                Ship.Controls.Add(pb)
                'this is tool tip test line, remove later
                ToolTip.SetToolTip(Ship.Controls(CName), CName)
            Next
        Next
        CreateNewShip()
    End Sub

    Private Sub PrintShipBtn_Click(sender As Object, e As EventArgs) Handles PrintShipBtn.Click
        'no idea how to do this for now
    End Sub

    Private Sub LevelUpBtn_Click(sender As Object, e As EventArgs) Handles LevelUpBtn.Click
        'total 14 levels from 01 to 14
        If Level < 14 Then
            LevelSet(Level + 1)
            RedrawCells()
        End If
    End Sub

    Private Sub LevelDownBtn_Click(sender As Object, e As EventArgs) Handles LevelDownBtn.Click
        'total 14 levels from 01 to 14
        If Level > 1 Then
            LevelSet(Level - 1)
            RedrawCells()
        End If
    End Sub

    Private Sub RedrawBtn_Click(sender As Object, e As EventArgs) Handles RedrawBtn.Click
        RedrawCells()
    End Sub
End Class
