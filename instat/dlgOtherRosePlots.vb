'R-Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgOtherRosePlots
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'R function
    Private clsOtherRosePlots As RFunction

    Private Sub dlgOtherRosePlots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        Dim dctStatistic As New Dictionary(Of String, String)
        Dim dctType As New Dictionary(Of String, String)
        Dim dctColor As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorOtherRosePlots.SetParameter(New RParameter("mydata", 0))
        ucrSelectorOtherRosePlots.SetParameterIsrfunction()

        UcrReceiverDate.Selector = ucrSelectorOtherRosePlots
        UcrReceiverDate.SetParameter(New RParameter("date_name", 1))
        UcrReceiverDate.SetParameterIsString()
        UcrReceiverDate.SetClimaticType("date")
        UcrReceiverDate.bAutoFill = True

        ucrReceiverWindDirection.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindDirection.SetParameter(New RParameter("wd_name", 2))
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws_name", 3))
        ucrReceiverWindSpeed.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindSpeed.SetParameterIsString()

        ucrInputStatistic.SetParameter(New RParameter("statistic", 9))
        dctStatistic.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatistic.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatistic.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatistic.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatistic.Add("Stdev", Chr(34) & "stdev" & Chr(34))
        dctStatistic.Add("Weighted mean", Chr(34) & "weighted.mean" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("cols", 10))
        dctColor.Add("Default", Chr(34) & "default" & Chr(34))
        dctColor.Add("Increment", Chr(34) & "increment" & Chr(34))
        dctColor.Add("Heat", Chr(34) & "heat" & Chr(34))
        dctColor.Add("Jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrInputType.SetParameter(New RParameter("type", 6))
        dctType.Add("Default", Chr(34) & "default" & Chr(34))
        dctType.Add("Year", Chr(34) & "year" & Chr(34))
        dctType.Add("Hour", Chr(34) & "hour" & Chr(34))
        dctType.Add("Month", Chr(34) & "month" & Chr(34))
        dctType.Add("Season", Chr(34) & "season" & Chr(34))
        dctType.Add("Weekday", Chr(34) & "weekday" & Chr(34))
        dctType.Add("Weekend", Chr(34) & "weekend" & Chr(34))
        dctType.Add("Monthyear", Chr(34) & "monthyear" & Chr(34))
        dctType.Add("Daylight", Chr(34) & "daylight" & Chr(34))
        dctType.Add("DST", Chr(34) & "dst" & Chr(34))
        ucrInputType.SetItems(dctType)
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 5))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        'ucrChkIncludePollutant.AddParameterPresentCondition("True", "statistic", "True")

        ucrChkIncludePollutant.SetText("Include Pollutant")
        ucrChkIncludePollutant.AddToLinkedControls(ucrReceiverPollutant, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverPollutant.SetLinkedDisplayControl(lblPollutant)
        'ucrChkIncludePollutant.AddToLinkedControls(ucrInputStatistic, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="frequency")
        'ucrInputStatistic.SetLinkedDisplayControl(lblStatistic)

        ucrSaveGraph.SetPrefix("OtherRosePlots")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOtherRosePlots.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsOtherRosePlots = New RFunction

        clsOtherRosePlots.AddParameter("type", Chr(34) & "year" & Chr(34), iPosition:=4)
        clsOtherRosePlots.AddParameter("Statistic", Chr(34) & "" & Chr(34), iPosition:=4)
        clsOtherRosePlots.AddParameter("Cols", Chr(34) & "heat" & Chr(34), iPosition:=4)

        ucrSelectorOtherRosePlots.Reset()
        UcrReceiverDate.SetMeAsReceiver()

        clsOtherRosePlots.SetRCommand("other_rose_plots")

        ucrBase.clsRsyntax.SetBaseRFunction(clsOtherRosePlots)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If UcrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub UcrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles UcrReceiverDate.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputFacet_Load(sender As Object, e As EventArgs) Handles ucrInputType.Load

    End Sub
End Class