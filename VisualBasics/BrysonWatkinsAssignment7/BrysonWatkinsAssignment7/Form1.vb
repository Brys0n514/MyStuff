Public Class Form1

    Private TotalNumberCharters As Integer
    Private TotalRvenueDecimal As Decimal
    Private TotalHoursDec As Decimal
    Private YachtSizeRate As Decimal


    Private Sub PrintSummaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintSummaryToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Programmed by: Bryson Watkins", "About", MessageBoxButtons.OK)
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        'Print Summary
        PrintSummaryControl.Print()

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        'Print Summary Preview
        PrintPreviewSummary.Document = PrintSummaryControl
        PrintPreviewSummary.ShowDialog()

    End Sub

    Private Sub PrintToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        'Print Yacht Types
        PrintYachtsControl.Print()


    End Sub

    Private Sub PrintPreviewToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles PrintPreviewToolStripMenuItem1.Click
        'Print Yacht Preview
        PrintPreviewYacht.Document = PrintYachtsControl
        PrintPreviewYacht.ShowDialog()
    End Sub

    Private Sub YachtsComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles YachtsComboBox1.SelectedIndexChanged








    End Sub

    Private Sub PrintSummaryControl_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintSummaryControl.PrintPage
        Dim xposSingle As Single = e.MarginBounds.Left
        Dim yposSingle As Single = e.MarginBounds.Top
        Dim HeadingFont As New Font("Arial", 14, FontStyle.Bold)
        Dim PrintingFont As New Font("Arial", 12)
        Dim lineHeightSingle As Single = PrintingFont.GetHeight + 2
        Dim PrintLineString As String
        Dim PrintNameString As String
        Dim avgHoursCharteredDec As Decimal
        Dim StringSize As New SizeF()
        Dim startpos As Single 'Start of the number column
        Dim endpos As Single = 500.0F 'end of the number column
        Dim FormattedNumString As String

        'Calculations
        'avgHoursCharteredDec = TotalHoursDec / TotalNumberCharters



        PrintLineString = "Summary Report"
        e.Graphics.DrawString(PrintLineString, HeadingFont, Brushes.Black, xposSingle, yposSingle)

        yposSingle += lineHeightSingle
        PrintNameString = "Bryson Watkins"
        e.Graphics.DrawString(PrintNameString, HeadingFont, Brushes.Black, xposSingle, yposSingle)
        yposSingle += lineHeightSingle * 2


        PrintLineString = "Number of Charters"
        e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, xposSingle, yposSingle)
        'print the number value
        FormattedNumString = TotalNumberCharters.ToString("N0")

        'calc start position
        StringSize = e.Graphics.MeasureString(FormattedNumString, PrintingFont)
        TotalNumberCharters = 1
        startpos = endpos - StringSize.Width
        e.Graphics.DrawString(FormattedNumString, PrintingFont, Brushes.Black, startpos, yposSingle)

        yposSingle += lineHeightSingle 'line break

        PrintLineString = "Total Revenue"
        e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, xposSingle, yposSingle)

        yposSingle += lineHeightSingle 'line break

        PrintLineString = "Average Hours Charted"
        e.Graphics.DrawString(PrintLineString, PrintingFont, Brushes.Black, xposSingle, yposSingle)



    End Sub

    Private Sub CalcButton_Click(sender As System.Object, e As System.EventArgs) Handles CalcButton.Click
        Dim goodDataBoolean As Boolean
        Dim hourschartered As Decimal



        'Validate Inputs

        If YachtsComboBox1.Text = "" Then
            MessageBox.Show("Please enter a yacht type", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            YachtsComboBox1.Focus()
            YachtsComboBox1.SelectAll()
            goodDataBoolean = False

        ElseIf yachtSizeListBox1.SelectedIndex <= 0 Or yachtSizeListBox1.SelectedIndex > 7 Then
            MessageBox.Show("Please select a valid yacht length.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            yachtSizeListBox1.Focus()
            goodDataBoolean = False


        ElseIf HoursTextBox1.Text = "" Then
            MessageBox.Show("Please enter a positive whole number.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


            Try
                hourschartered = Decimal.Parse(HoursTextBox1.Text)
                If hourschartered <= 0 Then
                    MessageBox.Show("Please enter a positive whole number of hours.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    HoursTextBox1.Focus()
                    HoursTextBox1.SelectAll()
                    goodDataBoolean = False
                End If

            Catch quantityErr As FormatException
                MessageBox.Show("Quantity must be a positive whole number.", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try



        End If



        'Calculate good data (find hourly rate, multiply hourly rate by hours chartered)


        'display Calculations


        'Accumulate totals


    End Sub

    Private Sub yachtLabel_Click(sender As System.Object, e As System.EventArgs) Handles yachtLabel.Click

    End Sub

    Private Sub AddYachtButton1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ItemFoundBoolean As Boolean
        Dim itemIndexInt As Integer

        With YachtsComboBox1
            If .Text = "" Then
                MessageBox.Show("Please enter a yacht type.", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Do Until ItemFoundBoolean Or itemIndexInt = .Items.Count
                    'find for duplicates
                    If .Text = .Items(itemIndexInt.ToString.ToUpper) Then
                        ItemFoundBoolean = True
                        Exit Do
                    Else
                        itemIndexInt += 1
                    End If
                Loop
                If ItemFoundBoolean Then
                    MessageBox.Show("Can't enter duplicate items", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    .Items.Add(.Text)
                End If

            End If
        End With


    End Sub

    Private Sub HoursTextBox1_TextChanged(sender As System.Object, e As System.EventArgs)
        TotalHoursDec += Decimal.Parse(HoursTextBox1.Text)

    End Sub

    Private Sub yachtSizeListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles yachtSizeListBox1.SelectedIndexChanged
        Dim itemSelectedindexint As Integer
        Dim itemCountint As Integer


        itemSelectedindexint = yachtSizeListBox1.SelectedIndex + 1
        itemCountint = yachtSizeListBox1.Items.Count

        If itemSelectedindexint = 1 Then
            YachtSizeRate = 95.0
        ElseIf itemSelectedindexint = 2 Then
            YachtSizeRate = 137.0
        ElseIf itemSelectedindexint = 3 Then
            YachtSizeRate = 160.0
        ElseIf itemSelectedindexint = 4 Then
            YachtSizeRate = 192.0
        ElseIf itemSelectedindexint = 5 Then
            YachtSizeRate = 250.0
        ElseIf itemSelectedindexint = 6 Then
            YachtSizeRate = 400.0
        ElseIf itemSelectedindexint = 7 Then
            YachtSizeRate = 550.0
        End If


    End Sub
End Class
