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

        UcrReceiverDate.SetParameter(New RParameter("x", 0))
        UcrReceiverDate.Selector = ucrSelectorOtherRosePlots
        UcrReceiverDate.SetParameterIsString()
        UcrReceiverDate.bWithQuotes = False
        UcrReceiverDate.SetDataType("date")
    End Sub

    Private Sub SetDefaults()
        Throw New NotImplementedException()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        Throw New NotImplementedException()
    End Sub

    Private Sub TestOkEnabled()
        Throw New NotImplementedException()
    End Sub
End Class