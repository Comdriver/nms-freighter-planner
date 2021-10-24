Public Class MainForm

    Class ShipCell
        Public Property Room As String = ""      'keeps room type, like corridor, stairs, etc
        Public Property Type As Integer = 0      'keeps orientation and type (1 wall, 2 walls, etc) of the room if any
        Public Property Item As String = ""      'keeps name of item placed in cell, like outfit staion, medium refiner, etc

    End Class

    Class Coords
        Public Property X As Integer
        Public Property Y As Integer
    End Class

    Public Ship(13, 20, 20) As ShipCell 'as I remember arrays have "0" as first item not "1" so all numbers are num-1
    Public CurrentCell As ShipCell      'keeps data for possible current mouse over cell
    Public Level As Integer    'keeps current selected level
    Public CurrentItemSelected As String = Nothing

    Function Cell(x As Integer, y As Integer) As String
        'this turns coords into cell name
        Return "Cell-" & x.ToString("D2") & "-" & y.ToString("D2")
    End Function

    Private Function CellNameToXY(MyCell As Object) As Coords
        Dim Name As String
        Dim Result As New Coords
        Dim x As String
        Dim y As String

        Name = MyCell.Name
        x = (Name.Split("-"c)(1))
        y = (Name.Split("-"c)(2))
        Result.X = CInt(x)
        Result.Y = CInt(y)
        Return Result
    End Function

    Function LevelSet(Lev As Integer) As Boolean
        'just something weird
        Level = Lev
        CurrentLevel.Text = Lev.ToString("D2")
        Return True
    End Function
    Private Function RedrawCell(sender As Object) As Boolean
        'this should redraw single cell
        Return True
    End Function
    Private Sub RedrawAllCells()
        'this should redraw all cells using current level

    End Sub
    Private Sub CreateNewShip()
        'this should fill arrays with default freighter data ("default.freighter" file)

        'and when arrays are filled, we should do this
        RedrawAllCells()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CName As String

        'here should be created array for 21x21x14 cells, will add later
        'possibly should add rotation as another array item?
        'and anothr one for placed items


        'starting at command bridge level
        LevelSet(1)

        'image data grid creation

        For x = 1 To ShipCells.RowCount
            For y = 1 To ShipCells.ColumnCount
                CName = Cell(x, y)
                Dim pb As New PictureBox With
                {
                .Name = CName,
                .BackgroundImage = My.Resources.empty,
                .Margin = New Padding(0, 0, 0, 0),
                .SizeMode = PictureBoxSizeMode.StretchImage,
                .BackgroundImageLayout = ImageLayout.Stretch
                }
                AddHandler pb.MouseHover, AddressOf CellMouseOver
                AddHandler pb.MouseLeave, AddressOf CellMouseOut
                AddHandler pb.Click, AddressOf CellSet
                ShipCells.Controls.Add(pb)
                'this is tool tip test line, remove later
                'ToolTip.SetToolTip(ShipCells.Controls(CName), CName)
            Next
        Next
        CreateNewShip()
    End Sub
    Private Sub CellValidate(Cor As Coords)
        'turns cell image to correct one with rotation and walls

    End Sub

    Private Sub CellMouseOver(sender As Object, e As EventArgs)
        'makes preview of room at current cell
        Dim testcoords As New Coords
        testcoords = CellNameToXY(sender)
        TestBox.Text = (testcoords.X.ToString & " " & testcoords.Y.ToString)
    End Sub

    Private Sub CellMouseOut(sender As Object, e As EventArgs)
        'resets preview back to orgin
        TestBox.Text = ""
    End Sub

    Private Sub CellMouseClick(sender As Object, e As EventArgs)
        'applies selected item to the cell

    End Sub

    Private Sub CellSet(sender As Object, e As EventArgs)
        'applyes preview room to clicked cell
    End Sub

    Private Sub PrintShipBtn_Click(sender As Object, e As EventArgs) Handles PrintShipBtn.Click
        'no idea how to do this for now
    End Sub

    Private Sub LevelUpBtn_Click(sender As Object, e As EventArgs) Handles LevelUpBtn.Click
        'total 14 levels from 01 to 14
        If Level < 14 Then
            LevelSet(Level + 1)
            RedrawAllCells()
        End If
    End Sub

    Private Sub LevelDownBtn_Click(sender As Object, e As EventArgs) Handles LevelDownBtn.Click
        'total 14 levels from 01 to 14
        If Level > 1 Then
            LevelSet(Level - 1)
            RedrawAllCells()
        End If
    End Sub

    Private Sub RedrawBtn_Click(sender As Object, e As EventArgs) Handles RedrawBtn.Click
        RedrawAllCells()
    End Sub

    Private Sub NewShipBtn_Click(sender As Object, e As EventArgs) Handles NewShipBtn.Click
        'check if ship data loaded and ask if rewrite
        CreateNewShip()
    End Sub

    Private Sub ItemSelector(sender As Object, e As EventArgs) Handles RadioButton9.Click, RadioButton8.Click, RadioButton7.Click, RadioButton6.Click, RadioButton5.Click, RadioButton4.Click, RadioButton3.Click, RadioButton20.Click, RadioButton2.Click, RadioButton19.Click, RadioButton18.Click, RadioButton17.Click, RadioButton16.Click, RadioButton15.Click, RadioButton14.Click, RadioButton13.Click, RadioButton12.Click, RadioButton11.Click, RadioButton10.Click, RadioButton1.Click
        'on click of a button sets curent item for editing - like room, stairs, etc

        If (CurrentItemSelected = sender.Name) Then
            CurrentItemPicture.Image = Nothing
            CurrentItemPicture.BackgroundImage = Nothing
            CurrentItemSelected = Nothing
            sender.Checked = False
            TestBox.Text = ""
        Else
            CurrentItemPicture.Image = sender.Image
            CurrentItemPicture.BackgroundImage = sender.BackgroundImage
            CurrentItemSelected = sender.Name
            TestBox.Text = ToolTip.GetToolTip(sender)
        End If
    End Sub
End Class
