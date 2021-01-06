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

        ucrPnlOptions.AddRadioButton(rdoPercentileRose)
        ucrPnlOptions.AddRadioButton(rdoPolarCluster)
        ucrPnlOptions.AddRadioButton(rdoPolarFrequency)
        ucrPnlOptions.AddRadioButton(rdoPolarPlot)
        ucrPnlOptions.AddRadioButton(rdoPolarAnnulus)

        'ucrPnlOptions.AddFunctionNamesCondition(rdoPercentileRose, "other_rose_plots")
        'ucrPnlOptions.AddFunctionNamesCondition(rdoPolarCluster, "other_rose_plots")
        'ucrPnlOptions.AddFunctionNamesCondition(rdoPolarFrequency, "other_rose_plots")
        'ucrPnlOptions.AddFunctionNamesCondition(rdoPolarPlot, "other_rose_plots")
        'ucrPnlOptions.AddFunctionNamesCondition(rdoPolarAnnulus, "other_rose_plots")

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

        ucrReceiverX.SetParameter(New RParameter("x", 3))
        ucrReceiverX.Selector = ucrSelectorOtherRosePlots
        ucrReceiverX.SetParameterIsString()
        'ucrReceiverXCluster.SetClimaticType("wind_speed")
        'ucrReceiverXCluster.bAutoFill = True

        ucrReceiverSinglePollutant.SetParameter(New RParameter("pollutant", 4))
        ucrReceiverSinglePollutant.Selector = ucrSelectorOtherRosePlots
        ucrReceiverSinglePollutant.SetParameterIsString()

        ucrReceiverMultiplePollutants.SetParameter(New RParameter("pollutant", 4))
        ucrReceiverMultiplePollutants.Selector = ucrSelectorOtherRosePlots
        ucrReceiverMultiplePollutants.SetParameterIsString()

        ucrReceiverSinglePollutantPolarFreq.SetParameter(New RParameter("pollutant", 4))
        ucrReceiverSinglePollutantPolarFreq.Selector = ucrSelectorOtherRosePlots
        ucrReceiverSinglePollutantPolarFreq.SetParameterIsString()

        ucrPnlOptions.AddToLinkedControls({UcrReceiverDate, ucrReceiverWindDirection, ucrReceiverWindSpeed}, {rdoPercentileRose, rdoPolarFrequency, rdoPolarAnnulus, rdoPolarCluster, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSinglePollutant}, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarCluster, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSinglePollutantPolarFreq}, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkMultiplePollutants, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlOptions.AddToLinkedControls(ucrReceiverWindDirection, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarCluster, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlOptions.AddToLinkedControls(ucrReceiverWindSpeed, {rdoPercentileRose, rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverX, {rdoPolarCluster, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputColor, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarCluster, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputType, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputStatistic, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputStatisticPolarFreq, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkForcePositive, {rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrchkExcludeMissing, ucrChkPadDate}, {rdoPolarAnnulus}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkMultiplePollutants, ucrChkNormalise}, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkIncludePollutant, ucrChkTransform}, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrNudPercentile, ucrInputMethod, ucrInputSmooth}, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrNumberOfClusters, {rdoPolarCluster}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrReceiverSinglePollutant.SetLinkedDisplayControl(lblSinglePollutant)
        ucrReceiverSinglePollutantPolarFreq.SetLinkedDisplayControl(lblPollutantPolarFreq)
        ucrReceiverMultiplePollutants.SetLinkedDisplayControl(lblMultiplePollutants)
        ucrReceiverWindDirection.SetLinkedDisplayControl(lblWindDirection)
        ucrReceiverWindSpeed.SetLinkedDisplayControl(lblWindSpeed)
        ucrReceiverX.SetLinkedDisplayControl(lblVariableToPlotAgainstCluster)
        ucrInputColor.SetLinkedDisplayControl(lblColor)
        ucrInputType.SetLinkedDisplayControl(lblType)
        ucrInputStatistic.SetLinkedDisplayControl(lblStatistic)
        ucrInputStatisticPolarFreq.SetLinkedDisplayControl(lblStatisticPolarFreq)
        ucrNudPercentile.SetLinkedDisplayControl(lblPercentile)
        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrInputSmooth.SetLinkedDisplayControl(lblSmooth)
        ucrNumberOfClusters.SetLinkedDisplayControl(lblNoOfClusters)

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 5))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

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

        ucrInputStatistic.SetParameter(New RParameter("statistic", 7))
        dctStatistic.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatistic.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatistic.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatistic.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatistic.Add("Stdev", Chr(34) & "stdev" & Chr(34))
        dctStatistic.Add("Weighted mean", Chr(34) & "weighted.mean" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("cols", 8))
        dctColor.Add("Default", Chr(34) & "default" & Chr(34))
        dctColor.Add("Increment", Chr(34) & "increment" & Chr(34))
        dctColor.Add("Heat", Chr(34) & "heat" & Chr(34))
        dctColor.Add("Jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrChkIncludePollutant.AddParameterPresentCondition("True", "statistic", "True")
        ucrChkIncludePollutant.SetText("Include Pollutant")
        ucrChkIncludePollutant.AddToLinkedControls(ucrReceiverSinglePollutantPolarFreq, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverSinglePollutantPolarFreq.SetLinkedDisplayControl(lblPollutantPolarFreq)
        ucrChkIncludePollutant.AddToLinkedControls(ucrInputStatisticPolarFreq, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="frequency")
        ucrInputStatisticPolarFreq.SetLinkedDisplayControl(lblStatisticPolarFreq)

        ucrNumberOfClusters.SetParameter(New RParameter("n.clusters", 9))
        ucrNumberOfClusters.Minimum = 1

        ucrchkExcludeMissing.SetText("Exclude Missing")
        ucrchkExcludeMissing.SetParameter(New RParameter("exclude.missing", 10))
        ucrchkExcludeMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkPadDate.SetText("Pad Date")
        ucrChkPadDate.SetParameter(New RParameter("date.pad", 11))
        ucrChkPadDate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkNormalise.SetText("Normalise")
        ucrChkNormalise.SetParameter(New RParameter("normalise", 12))

        ucrChkMultiplePollutants.SetText("Multiple Pollutants")
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverMultiplePollutants, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultiplePollutants.SetLinkedDisplayControl(lblMultiplePollutants)
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverSinglePollutant, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverSinglePollutant.SetLinkedDisplayControl(lblSinglePollutant)
        ucrChkMultiplePollutants.AddToLinkedControls(ucrChkNormalise, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkForcePositive.SetText("Force positive")
        ucrChkForcePositive.SetParameter(New RParameter("force.positive", 13))
        ucrChkForcePositive.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrSaveGraph.SetPrefix("OtherRosePlots")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOtherRosePlots.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsOtherRosePlots = New RFunction

        clsOtherRosePlots.AddParameter("type", Chr(34) & "default" & Chr(34), iPosition:=6)
        clsOtherRosePlots.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=8)

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

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetDialogOptions()
        If rdoPolarAnnulus.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_annulus" & Chr(34), iPosition:=16)
            'clsOtherRosePlots.AddParameter("normalise", "FALSE", iPosition:=12)
            clsOtherRosePlots.AddParameter("date.pad", "FALSE", iPosition:=12)
            clsOtherRosePlots.AddParameter("statistic", Chr(34) & "mean" & Chr(34), iPosition:=7)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Annulus")
            End If
        ElseIf rdoPolarCluster.Checked Then
            clsOtherRosePlots.AddParameter("normalise", "TRUE", iPosition:=12)
            clsOtherRosePlots.AddParameter("force.positive", "TRUE", iPosition:=13)
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_cluster" & Chr(34), iPosition:=16)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Cluster")
            End If
        ElseIf rdoPolarFrequency.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_frequency" & Chr(34), iPosition:=16)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Frequency")
            End If
        ElseIf rdoPolarPlot.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_plot" & Chr(34), iPosition:=16)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Plot")
            End If
        ElseIf rdoPercentileRose.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "percentile_rose" & Chr(34), iPosition:=16)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Percentile_Rose")
            End If
        End If
    End Sub

    Private Sub ucrPnlOptions_Control() Handles ucrPnlOptions.ControlValueChanged
        SetDialogOptions()
    End Sub

    Private Sub UcrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles UcrReceiverDate.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub rdoPercentileRose_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoPercentileRose.KeyPress
        If e.KeyChar = vbCr Then
            rdoPercentileRose.Checked = True
        End If
    End Sub

    Private Sub rdoPolarAnnulus_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoPolarAnnulus.KeyPress
        If e.KeyChar = vbCr Then
            rdoPolarAnnulus.Checked = True
        End If
    End Sub

    Private Sub rdoPolarCluster_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoPolarCluster.KeyPress
        If e.KeyChar = vbCr Then
            rdoPolarCluster.Checked = True
        End If
    End Sub

    Private Sub rdoPolarFrequency_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoPolarFrequency.KeyPress
        If e.KeyChar = vbCr Then
            rdoPolarFrequency.Checked = True
        End If
    End Sub

    Private Sub rdoPolarPlot_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoPolarPlot.KeyPress
        If e.KeyChar = vbCr Then
            rdoPolarPlot.Checked = True
        End If
    End Sub
End Class