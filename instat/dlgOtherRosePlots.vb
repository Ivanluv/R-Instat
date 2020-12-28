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

        ucrInputMethod.SetItems({"Mean", "Mean Above", "Mean Below", "Prop Above", "Prop Below", "Std.dev"})
        ucrInputMethod.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetItems({"Mean", "Mean Above", "Mean Below", "Prop Above", "Prop Below", "Std.dev"})
        ucrInputColor.SetDropDownStyleAsNonEditable()

        ucrInputFacet.SetItems({"Mean", "Mean Above", "Mean Below", "Prop Above", "Prop Below", "Std.dev"})
        ucrInputFacet.SetDropDownStyleAsNonEditable()

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
End Class