﻿' R- Instat
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
Public Class dlgGeneralANOVA
    Public bFirstLoad As Boolean = True
    Private Sub dlgGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 161
    End Sub

End Class