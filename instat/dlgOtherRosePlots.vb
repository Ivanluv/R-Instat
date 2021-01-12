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
        Dim dctStatisticPolarFreq As New Dictionary(Of String, String)
        Dim dctMethod As New Dictionary(Of String, String)
        Dim dctType As New Dictionary(Of String, String)
        Dim dctColor As New Dictionary(Of String, String)
        Dim dctColorPCluster As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3


        ucrPnlOptions.AddRadioButton(rdoPercentileRose)
        ucrPnlOptions.AddRadioButton(rdoPolarCluster)
        ucrPnlOptions.AddRadioButton(rdoPolarFrequency)
        ucrPnlOptions.AddRadioButton(rdoPolarPlot)
        ucrPnlOptions.AddRadioButton(rdoPolarAnnulus)

        'ucrPnlOptions.AddFunctionNamesCondition({rdoPercentileRose, rdoPolarAnnulus, rdoPolarCluster, rdoPolarFrequency, rdoPolarPlot}, "other_rose_plots")
        ucrPnlOptions.AddParameterValuesCondition(rdoPercentileRose, "mymethod", Chr(34) & "percentile_rose" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarCluster, "mymethod", Chr(34) & "polar_cluster" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarFrequency, "mymethod", Chr(34) & "polar_frequency" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarPlot, "mymethod", Chr(34) & "polar_plot" & Chr(34))
        ucrPnlOptions.AddParameterValuesCondition(rdoPolarAnnulus, "mymethod", Chr(34) & "polar_annulus" & Chr(34))

        ucrSelectorOtherRosePlots.SetParameter(New RParameter("mydata", 0))
        ucrSelectorOtherRosePlots.SetParameterIsrfunction()

        UcrReceiverDate.Selector = ucrSelectorOtherRosePlots
        UcrReceiverDate.SetParameter(New RParameter("date_name", 1))
        UcrReceiverDate.SetParameterIsString()
        'UcrReceiverDate.SetIncludedDataTypes({"Date"})
        'UcrReceiverDate.SetClimaticType("date")
        'UcrReceiverDate.bAutoFill = True


        ucrReceiverWindDirection.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindDirection.SetParameter(New RParameter("wd_name", 2))
        ucrReceiverWindDirection.SetParameterIsString()
        'ucrReceiverWindDirection.SetClimaticType("wind_direction")
        'ucrReceiverWindDirection.bAutoFill = True


        ucrReceiverWindSpeed.SetParameter(New RParameter("ws_name", 3))
        ucrReceiverWindSpeed.Selector = ucrSelectorOtherRosePlots
        ucrReceiverWindSpeed.SetParameterIsString()
        'ucrReceiverWindSpeed.SetClimaticType("wind_speed")
        'ucrReceiverWindSpeed.bAutoFill = True

        ucrReceiverX.SetParameter(New RParameter("x", 4))
        ucrReceiverX.Selector = ucrSelectorOtherRosePlots
        ucrReceiverX.SetParameterIsString()

        ucrReceiverSinglePollutantPPlotandPAnnulus.SetParameter(New RParameter("pollutant", 5))
        ucrReceiverSinglePollutantPPlotandPAnnulus.Selector = ucrSelectorOtherRosePlots
        ucrReceiverSinglePollutantPPlotandPAnnulus.SetParameterIsString()

        ucrReceiverSinglePollutantPolarFreq.SetParameter(New RParameter("pollutant", 6))
        ucrReceiverSinglePollutantPolarFreq.Selector = ucrSelectorOtherRosePlots
        ucrReceiverSinglePollutantPolarFreq.SetParameterIsString()

        UcrReceiverSinglePollutantPClusterandPRose.SetParameter(New RParameter("pollutant", 7))
        UcrReceiverSinglePollutantPClusterandPRose.Selector = ucrSelectorOtherRosePlots
        UcrReceiverSinglePollutantPClusterandPRose.SetParameterIsString()

        ucrReceiverMultiplePollutants.SetParameter(New RParameter("pollutant", 8))
        ucrReceiverMultiplePollutants.Selector = ucrSelectorOtherRosePlots
        ucrReceiverMultiplePollutants.SetParameterIsString()

        ucrPnlOptions.AddToLinkedControls({UcrReceiverDate, ucrReceiverWindDirection, ucrReceiverWindSpeed}, {rdoPercentileRose, rdoPolarFrequency, rdoPolarAnnulus, rdoPolarCluster, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputColor, {rdoPercentileRose, rdoPolarFrequency, rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSinglePollutantPPlotandPAnnulus}, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSinglePollutantPolarFreq}, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(UcrReceiverSinglePollutantPClusterandPRose, {rdoPolarCluster, rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkMultiplePollutants, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrReceiverX, {rdoPolarCluster, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputType, {rdoPercentileRose, rdoPolarAnnulus, rdoPolarFrequency, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="year")
        ucrPnlOptions.AddToLinkedControls(ucrInputStatistic, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="mean")
        ucrPnlOptions.AddToLinkedControls(ucrInputStatisticPolarFreq, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="frequency")
        ucrPnlOptions.AddToLinkedControls(ucrChkForcePositive, {rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrchkExcludeMissing, ucrChkPadDate}, {rdoPolarAnnulus}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkMultiplePollutants, ucrChkNormalise}, {rdoPolarAnnulus, rdoPolarPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkIncludePollutant, ucrChkTransform}, {rdoPolarFrequency}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrChkSmooth, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrNudPercentile, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputMethod, {rdoPercentileRose}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="default")
        ucrPnlOptions.AddToLinkedControls(ucrInputColorPCluster, {rdoPolarCluster}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Paired")
        ucrPnlOptions.AddToLinkedControls(ucrNudNmberOfClusters, {rdoPolarCluster}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrReceiverSinglePollutantPPlotandPAnnulus.SetLinkedDisplayControl(lblSinglePollutantPPlotandPAnnulus)
        ucrReceiverSinglePollutantPolarFreq.SetLinkedDisplayControl(lblPollutantPolarFreq)
        UcrReceiverSinglePollutantPClusterandPRose.SetLinkedDisplayControl(lblPollutantPClusterandPRose)
        ucrReceiverMultiplePollutants.SetLinkedDisplayControl(lblMultiplePollutants)
        ucrReceiverWindDirection.SetLinkedDisplayControl(lblWindDirection)
        ucrReceiverWindSpeed.SetLinkedDisplayControl(lblWindSpeed)
        ucrReceiverX.SetLinkedDisplayControl(lblVariableToPlotAgainstCluster)
        ucrInputColor.SetLinkedDisplayControl(lblColor)
        ucrInputColorPCluster.SetLinkedDisplayControl(lblColorPCluster)
        ucrInputType.SetLinkedDisplayControl(lblType)
        ucrInputStatistic.SetLinkedDisplayControl(lblStatistic)
        ucrInputStatisticPolarFreq.SetLinkedDisplayControl(lblStatisticPolarFreq)
        ucrNudPercentile.SetLinkedDisplayControl(lblPercentile)
        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrNudNmberOfClusters.SetLinkedDisplayControl(lblNoOfClusters)

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 9))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputType.SetParameter(New RParameter("type", 10))
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

        ucrInputStatistic.SetParameter(New RParameter("statistic", 11))
        dctStatistic.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatistic.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatistic.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatistic.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatistic.Add("Stdev", Chr(34) & "stdev" & Chr(34))
        dctStatistic.Add("Weighted mean", Chr(34) & "weighted.mean" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("cols", 12))
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

        ucrNudNmberOfClusters.SetParameter(New RParameter("n.clusters", 13))
        ucrNudNmberOfClusters.Minimum = 2
        ucrNudNmberOfClusters.SetRDefault(6)

        ucrchkExcludeMissing.SetText("Exclude Missing")
        ucrchkExcludeMissing.SetParameter(New RParameter("exclude.missing", 14))
        ucrchkExcludeMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkPadDate.SetText("Pad Date")
        ucrChkPadDate.SetParameter(New RParameter("date.pad", 15))
        ucrChkPadDate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkNormalise.SetText("Normalise")
        ucrChkNormalise.SetParameter(New RParameter("normalise", 16))

        ucrChkMultiplePollutants.SetText("Multiple Pollutants")
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverMultiplePollutants, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultiplePollutants.SetLinkedDisplayControl(lblMultiplePollutants)
        ucrChkMultiplePollutants.AddToLinkedControls(ucrReceiverSinglePollutantPPlotandPAnnulus, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverSinglePollutantPPlotandPAnnulus.SetLinkedDisplayControl(lblSinglePollutantPPlotandPAnnulus)
        ucrChkMultiplePollutants.AddToLinkedControls(ucrChkNormalise, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkForcePositive.SetText("Force positive")
        ucrChkForcePositive.SetParameter(New RParameter("force.positive", 17))
        ucrChkForcePositive.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputMethod.SetParameter(New RParameter("method", 18))
        dctMethod.Add("Default", Chr(34) & "default" & Chr(34))
        dctMethod.Add("CPF", Chr(34) & "cpf" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetDropDownStyleAsNonEditable()

        ucrChkForcePositive.SetText("Smooth")
        ucrChkForcePositive.SetParameter(New RParameter("smooth", 19))
        ucrChkForcePositive.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrNudPercentile.SetParameter(New RParameter("percentile", 21))
        ucrNudPercentile.Minimum = 2
        ucrNudPercentile.SetRDefault(90)

        ucrInputStatisticPolarFreq.SetParameter(New RParameter("statistic", 22))
        dctStatisticPolarFreq.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatisticPolarFreq.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatisticPolarFreq.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatisticPolarFreq.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatisticPolarFreq.Add("Stdev", Chr(34) & "stdev" & Chr(34))
        dctStatisticPolarFreq.Add("Weighted mean", Chr(34) & "weighted.mean" & Chr(34))
        ucrInputStatisticPolarFreq.SetItems(dctStatisticPolarFreq)
        ucrInputStatisticPolarFreq.SetDropDownStyleAsNonEditable()

        ucrInputColorPCluster.SetParameter(New RParameter("cols", 23))
        dctColorPCluster.Add("Paired", Chr(34) & "Paired" & Chr(34))
        dctColorPCluster.Add("Accent", Chr(34) & "Accent" & Chr(34))
        dctColorPCluster.Add("Dark2", Chr(34) & "Dark2" & Chr(34))
        dctColorPCluster.Add("Pastel1", Chr(34) & "Pastel1" & Chr(34))
        dctColorPCluster.Add("Pastel2", Chr(34) & "Pastel2" & Chr(34))
        dctColorPCluster.Add("Set1", Chr(34) & "Set1" & Chr(34))
        dctColorPCluster.Add("Set2", Chr(34) & "Set2" & Chr(34))
        dctColorPCluster.Add("Set3", Chr(34) & "Set3" & Chr(34))
        ucrInputColorPCluster.SetItems(dctColorPCluster)
        ucrInputColorPCluster.SetDropDownStyleAsNonEditable()

        ucrSaveGraph.SetPrefix("OtherRosePlots")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorOtherRosePlots.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsOtherRosePlots = New RFunction

        ucrSelectorOtherRosePlots.Reset()
        UcrReceiverDate.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        clsOtherRosePlots.SetRCommand("other_rose_plots")

        'clsOtherRosePlots.AddParameter("type", Chr(34) & "default" & Chr(34), iPosition:=10)
        clsOtherRosePlots.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=12)
        clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_frequency" & Chr(34), iPosition:=20)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsOtherRosePlots)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not UcrReceiverDate.IsEmpty AndAlso Not ucrReceiverWindDirection.IsEmpty AndAlso Not ucrReceiverWindSpeed.IsEmpty Then
            If rdoPolarPlot.Checked Then
                If (Not ucrReceiverMultiplePollutants.IsEmpty AndAlso ucrChkMultiplePollutants.Checked) OrElse (Not ucrReceiverSinglePollutantPPlotandPAnnulus.IsEmpty AndAlso Not ucrChkMultiplePollutants.Checked) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
            If rdoPolarFrequency.Checked Then
                If (ucrChkIncludePollutant.Checked AndAlso Not ucrReceiverSinglePollutantPolarFreq.IsEmpty) OrElse Not ucrChkIncludePollutant.Checked Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If

            If rdoPolarAnnulus.Checked Then
                If (Not ucrReceiverMultiplePollutants.IsEmpty AndAlso ucrChkMultiplePollutants.Checked) OrElse (Not ucrReceiverSinglePollutantPPlotandPAnnulus.IsEmpty AndAlso Not ucrChkMultiplePollutants.Checked) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If

            If rdoPolarCluster.Checked Then
                If Not UcrReceiverSinglePollutantPClusterandPRose.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If

            If rdoPercentileRose.Checked Then
                If Not UcrReceiverSinglePollutantPClusterandPRose.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        SetDialogOptions()
    End Sub

    Private Sub SetDialogOptions()
        If rdoPolarAnnulus.Checked Then
            clsOtherRosePlots.AddParameter("exclude.missing", "FALSE", iPosition:=14)
            clsOtherRosePlots.AddParameter("date.pad", "FALSE", iPosition:=15)
            clsOtherRosePlots.AddParameter("normalise", "FALSE", iPosition:=16)
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_annulus" & Chr(34), iPosition:=20)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Annulus")
            End If
        ElseIf rdoPolarCluster.Checked Then
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_cluster" & Chr(34), iPosition:=20)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Cluster")
            End If
        ElseIf rdoPolarFrequency.Checked Then
            clsOtherRosePlots.AddParameter("trans", "TRUE", iPosition:=9)
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_frequency" & Chr(34), iPosition:=20)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Frequency")
            End If
        ElseIf rdoPolarPlot.Checked Then
            clsOtherRosePlots.AddParameter("force.positive", "TRUE", iPosition:=17)
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "polar_plot" & Chr(34), iPosition:=20)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Polar_Plot")
            End If
        ElseIf rdoPercentileRose.Checked Then
            clsOtherRosePlots.AddParameter("smooth", "FALSE", iPosition:=19)
            clsOtherRosePlots.AddParameter("mymethod", Chr(34) & "percentile_rose" & Chr(34), iPosition:=20)

            If Not ucrSaveGraph.bUserTyped Then
                ucrSaveGraph.SetPrefix("Percentile_Rose")
            End If
        End If
    End Sub


    Private Sub UcrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles UcrReceiverDate.ControlContentsChanged, ucrReceiverWindSpeed.ControlContentsChanged, ucrReceiverWindDirection.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, UcrReceiverSinglePollutantPClusterandPRose.ControlContentsChanged, ucrChkIncludePollutant.ControlContentsChanged, ucrReceiverSinglePollutantPolarFreq.ControlContentsChanged, UcrReceiverSinglePollutantPClusterandPRose.ControlContentsChanged, ucrReceiverMultiplePollutants.ControlContentsChanged, ucrChkMultiplePollutants.ControlContentsChanged, ucrReceiverSinglePollutantPPlotandPAnnulus.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        SetDialogOptions()
    End Sub
End Class