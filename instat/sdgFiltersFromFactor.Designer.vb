﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgFiltersFromFactor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgFiltersFromFactor))
        Me.ucrBase = New instat.ucrButtonsSubdialogue()
        Me.ucrFactorSelctor = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        resources.ApplyResources(Me.ucrBase, "ucrBase")
        Me.ucrBase.Name = "ucrBase"
        '
        'ucrFactorSelctor
        '
        Me.ucrFactorSelctor.bDropUnusedFilterLevels = False
        Me.ucrFactorSelctor.bShowHiddenColumns = False
        Me.ucrFactorSelctor.bUseCurrentFilter = True
        resources.ApplyResources(Me.ucrFactorSelctor, "ucrFactorSelctor")
        Me.ucrFactorSelctor.Name = "ucrFactorSelctor"
        '
        'ucrFactorReceiver
        '
        Me.ucrFactorReceiver.frmParent = Me
        resources.ApplyResources(Me.ucrFactorReceiver, "ucrFactorReceiver")
        Me.ucrFactorReceiver.Name = "ucrFactorReceiver"
        Me.ucrFactorReceiver.Selector = Nothing
        Me.ucrFactorReceiver.strNcFilePath = ""
        Me.ucrFactorReceiver.ucrSelector = Nothing
        '
        'lblFactor
        '
        resources.ApplyResources(Me.lblFactor, "lblFactor")
        Me.lblFactor.Name = "lblFactor"
        '
        'sdgFiltersFromFactor
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.ucrFactorReceiver)
        Me.Controls.Add(Me.ucrFactorSelctor)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFiltersFromFactor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtonsSubdialogue
    Friend WithEvents ucrFactorSelctor As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFactor As Label
End Class
