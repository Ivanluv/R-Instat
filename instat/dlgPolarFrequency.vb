﻿'R-Instat
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
Public Class dlgPolarFrequency
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    'Functions 
    Private clsPolarFrequencyFunction As RFunction

    Private Sub dlgPolarFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctPosition As New Dictionary(Of String, String)
        Dim dctColor As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3

        ucrSelectorPolarFrequency.SetParameter(New RParameter("mydata", 0))
        ucrSelectorPolarFrequency.SetParameterIsrfunction()

        ucrReceiverPollutant.SetParameter(New RParameter("pollutant", 1))
        ucrReceiverPollutant.Selector = ucrSelectorPolarFrequency
        ucrReceiverPollutant.SetParameterIsString()

        ucrReceiverWindDirection.SetParameter(New RParameter("wd_name", 2))
        ucrReceiverWindDirection.Selector = ucrSelectorPolarFrequency
        ucrReceiverWindDirection.SetParameterIsString()

        ucrReceiverWindSpeed.SetParameter(New RParameter("ws_name", 3))
        ucrReceiverWindSpeed.Selector = ucrSelectorPolarFrequency
        ucrReceiverWindSpeed.SetParameterIsString()

        ucrChkTransform.SetText("Transform")
        ucrChkTransform.SetParameter(New RParameter("trans", 4))
        ucrChkTransform.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputType.SetParameter(New RParameter("type", 5))
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

        ucrNudMinimumBins.SetParameter(New RParameter("min.bin", 6))
        ucrNudMinimumBins.Minimum = 1

        ucrInputPosition.SetParameter(New RParameter("key.position", 7))
        dctPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctPosition.Add("Left", Chr(34) & "left" & Chr(34))
        ucrInputPosition.SetItems(dctPosition)
        ucrInputPosition.SetDropDownStyleAsNonEditable()

        ucrInputStatistic.SetParameter(New RParameter("statistic", 8))
        dctStatistic.Add("Frequency", Chr(34) & "frequency" & Chr(34))
        dctStatistic.Add("Mean", Chr(34) & "mean" & Chr(34))
        dctStatistic.Add("Median", Chr(34) & "median" & Chr(34))
        dctStatistic.Add("Max", Chr(34) & "max" & Chr(34))
        dctStatistic.Add("Stdev", Chr(34) & "stdev" & Chr(34))
        dctStatistic.Add("Weighted mean", Chr(34) & "weighted.mean" & Chr(34))
        ucrInputStatistic.SetItems(dctStatistic)
        ucrInputStatistic.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("cols", 9))
        dctColor.Add("Default", Chr(34) & "default" & Chr(34))
        dctColor.Add("Increment", Chr(34) & "increment" & Chr(34))
        dctColor.Add("Heat", Chr(34) & "heat" & Chr(34))
        dctColor.Add("Jet", Chr(34) & "jet" & Chr(34))
        ucrInputColor.SetItems(dctColor)
        ucrInputColor.SetDropDownStyleAsNonEditable()
    End Sub

    Private Sub SetDefaults()
        clsPolarFrequencyFunction = New RFunction
        clsPolarFrequencyFunction.AddParameter("statistic", Chr(34) & "frequency" & Chr(34), iPosition:=8)
        clsPolarFrequencyFunction.AddParameter("type", Chr(34) & "default" & Chr(34), iPosition:=5)
        clsPolarFrequencyFunction.AddParameter("key.position", Chr(34) & "right" & Chr(34), iPosition:=7)
        clsPolarFrequencyFunction.AddParameter("cols", Chr(34) & "default" & Chr(34), iPosition:=9)
        clsPolarFrequencyFunction.AddParameter("trans", "TRUE", iPosition:=4)

        ucrSelectorPolarFrequency.Reset()
        ucrReceiverPollutant.SetMeAsReceiver()

        clsPolarFrequencyFunction.SetRCommand("polar_frequency")

        ucrBase.clsRsyntax.SetBaseRFunction(clsPolarFrequencyFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorPolarFrequency.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "" Then
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

    Private Sub ucrSelectorPolarFrequency_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPolarFrequency.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class