<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgOtherRosePlots
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
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorOtherRosePlots = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindDirection = New instat.ucrReceiverSingle()
        Me.UcrReceiverDate = New instat.ucrReceiverSingle()
        Me.ucrReceiverWindSpeed = New instat.ucrReceiverSingle()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblSinglePollutantPPlotandPAnnulus = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.ucrInputColor = New instat.ucrInputComboBox()
        Me.ucrInputStatistic = New instat.ucrInputComboBox()
        Me.ucrInputType = New instat.ucrInputComboBox()
        Me.rdoPolarAnnulus = New System.Windows.Forms.RadioButton()
        Me.rdoPolarPlot = New System.Windows.Forms.RadioButton()
        Me.rdoPolarCluster = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.rdoPolarFrequency = New System.Windows.Forms.RadioButton()
        Me.rdoPercentileRose = New System.Windows.Forms.RadioButton()
        Me.ucrSaveGraph = New instat.ucrSave()
        Me.ucrChkTransform = New instat.ucrCheck()
        Me.ucrChkIncludePollutant = New instat.ucrCheck()
        Me.ucrReceiverX = New instat.ucrReceiverSingle()
        Me.lblVariableToPlotAgainstCluster = New System.Windows.Forms.Label()
        Me.ucrReceiverMultiplePollutants = New instat.ucrReceiverMultiple()
        Me.ucrChkMultiplePollutants = New instat.ucrCheck()
        Me.ucrChkNormalise = New instat.ucrCheck()
        Me.ucrNudNmberOfClusters = New instat.ucrNud()
        Me.lblNoOfClusters = New System.Windows.Forms.Label()
        Me.ucrChkForcePositive = New instat.ucrCheck()
        Me.ucrChkPadDate = New instat.ucrCheck()
        Me.ucrchkExcludeMissing = New instat.ucrCheck()
        Me.lblMultiplePollutants = New System.Windows.Forms.Label()
        Me.lblStatistic = New System.Windows.Forms.Label()
        Me.ucrReceiverSinglePollutantPolarFreq = New instat.ucrReceiverSingle()
        Me.lblPollutantPolarFreq = New System.Windows.Forms.Label()
        Me.ucrInputStatisticPolarFreq = New instat.ucrInputComboBox()
        Me.lblStatisticPolarFreq = New System.Windows.Forms.Label()
        Me.UcrReceiverSinglePollutantPClusterandPRose = New instat.ucrReceiverSingle()
        Me.lblPollutantPClusterandPRose = New System.Windows.Forms.Label()
        Me.ucrInputColorPCluster = New instat.ucrInputComboBox()
        Me.lblColorPCluster = New System.Windows.Forms.Label()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.lblMethod = New System.Windows.Forms.Label()
        Me.lblPercentile = New System.Windows.Forms.Label()
        Me.ucrChkSmooth = New instat.ucrCheck()
        Me.ucrNudPercentile = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 454)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 36
        '
        'ucrSelectorOtherRosePlots
        '
        Me.ucrSelectorOtherRosePlots.bDropUnusedFilterLevels = False
        Me.ucrSelectorOtherRosePlots.bShowHiddenColumns = False
        Me.ucrSelectorOtherRosePlots.bUseCurrentFilter = True
        Me.ucrSelectorOtherRosePlots.Location = New System.Drawing.Point(10, 72)
        Me.ucrSelectorOtherRosePlots.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOtherRosePlots.Name = "ucrSelectorOtherRosePlots"
        Me.ucrSelectorOtherRosePlots.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOtherRosePlots.TabIndex = 0
        '
        'ucrReceiverSinglePollutantPPlotandPAnnulus
        '
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.frmParent = Me
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.Location = New System.Drawing.Point(280, 294)
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.Name = "ucrReceiverSinglePollutantPPlotandPAnnulus"
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.Selector = Nothing
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.strNcFilePath = ""
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.TabIndex = 10
        Me.ucrReceiverSinglePollutantPPlotandPAnnulus.ucrSelector = Nothing
        '
        'ucrReceiverWindDirection
        '
        Me.ucrReceiverWindDirection.frmParent = Me
        Me.ucrReceiverWindDirection.Location = New System.Drawing.Point(282, 141)
        Me.ucrReceiverWindDirection.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindDirection.Name = "ucrReceiverWindDirection"
        Me.ucrReceiverWindDirection.Selector = Nothing
        Me.ucrReceiverWindDirection.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindDirection.strNcFilePath = ""
        Me.ucrReceiverWindDirection.TabIndex = 4
        Me.ucrReceiverWindDirection.ucrSelector = Nothing
        '
        'UcrReceiverDate
        '
        Me.UcrReceiverDate.frmParent = Me
        Me.UcrReceiverDate.Location = New System.Drawing.Point(282, 95)
        Me.UcrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverDate.Name = "UcrReceiverDate"
        Me.UcrReceiverDate.Selector = Nothing
        Me.UcrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverDate.strNcFilePath = ""
        Me.UcrReceiverDate.TabIndex = 2
        Me.UcrReceiverDate.ucrSelector = Nothing
        '
        'ucrReceiverWindSpeed
        '
        Me.ucrReceiverWindSpeed.frmParent = Me
        Me.ucrReceiverWindSpeed.Location = New System.Drawing.Point(281, 184)
        Me.ucrReceiverWindSpeed.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWindSpeed.Name = "ucrReceiverWindSpeed"
        Me.ucrReceiverWindSpeed.Selector = Nothing
        Me.ucrReceiverWindSpeed.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWindSpeed.strNcFilePath = ""
        Me.ucrReceiverWindSpeed.TabIndex = 6
        Me.ucrReceiverWindSpeed.ucrSelector = Nothing
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(278, 167)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 5
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(279, 78)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(278, 122)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 3
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblSinglePollutantPPlotandPAnnulus
        '
        Me.lblSinglePollutantPPlotandPAnnulus.AutoSize = True
        Me.lblSinglePollutantPPlotandPAnnulus.Location = New System.Drawing.Point(279, 275)
        Me.lblSinglePollutantPPlotandPAnnulus.Name = "lblSinglePollutantPPlotandPAnnulus"
        Me.lblSinglePollutantPPlotandPAnnulus.Size = New System.Drawing.Size(51, 13)
        Me.lblSinglePollutantPPlotandPAnnulus.TabIndex = 15
        Me.lblSinglePollutantPPlotandPAnnulus.Text = "Pollutant:"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(23, 306)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(34, 13)
        Me.lblColor.TabIndex = 19
        Me.lblColor.Text = "Color:"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(23, 333)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(34, 13)
        Me.lblType.TabIndex = 20
        Me.lblType.Text = "Type:"
        '
        'ucrInputColor
        '
        Me.ucrInputColor.AddQuotesIfUnrecognised = True
        Me.ucrInputColor.GetSetSelectedIndex = -1
        Me.ucrInputColor.IsReadOnly = False
        Me.ucrInputColor.Location = New System.Drawing.Point(83, 302)
        Me.ucrInputColor.Name = "ucrInputColor"
        Me.ucrInputColor.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputColor.TabIndex = 23
        '
        'ucrInputStatistic
        '
        Me.ucrInputStatistic.AddQuotesIfUnrecognised = True
        Me.ucrInputStatistic.GetSetSelectedIndex = -1
        Me.ucrInputStatistic.IsReadOnly = False
        Me.ucrInputStatistic.Location = New System.Drawing.Point(82, 271)
        Me.ucrInputStatistic.Name = "ucrInputStatistic"
        Me.ucrInputStatistic.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputStatistic.TabIndex = 21
        '
        'ucrInputType
        '
        Me.ucrInputType.AddQuotesIfUnrecognised = True
        Me.ucrInputType.GetSetSelectedIndex = -1
        Me.ucrInputType.IsReadOnly = False
        Me.ucrInputType.Location = New System.Drawing.Point(83, 328)
        Me.ucrInputType.Name = "ucrInputType"
        Me.ucrInputType.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputType.TabIndex = 24
        '
        'rdoPolarAnnulus
        '
        Me.rdoPolarAnnulus.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarAnnulus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarAnnulus.FlatAppearance.BorderSize = 2
        Me.rdoPolarAnnulus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarAnnulus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarAnnulus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarAnnulus.Location = New System.Drawing.Point(212, 43)
        Me.rdoPolarAnnulus.Name = "rdoPolarAnnulus"
        Me.rdoPolarAnnulus.Size = New System.Drawing.Size(95, 28)
        Me.rdoPolarAnnulus.TabIndex = 32
        Me.rdoPolarAnnulus.TabStop = True
        Me.rdoPolarAnnulus.Tag = ""
        Me.rdoPolarAnnulus.Text = "Polar Annulus"
        Me.rdoPolarAnnulus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarAnnulus.UseVisualStyleBackColor = True
        '
        'rdoPolarPlot
        '
        Me.rdoPolarPlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarPlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarPlot.FlatAppearance.BorderSize = 2
        Me.rdoPolarPlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarPlot.Location = New System.Drawing.Point(261, 17)
        Me.rdoPolarPlot.Name = "rdoPolarPlot"
        Me.rdoPolarPlot.Size = New System.Drawing.Size(96, 28)
        Me.rdoPolarPlot.TabIndex = 33
        Me.rdoPolarPlot.TabStop = True
        Me.rdoPolarPlot.Tag = ""
        Me.rdoPolarPlot.Text = "Polar Plot"
        Me.rdoPolarPlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarPlot.UseVisualStyleBackColor = True
        '
        'rdoPolarCluster
        '
        Me.rdoPolarCluster.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarCluster.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarCluster.FlatAppearance.BorderSize = 2
        Me.rdoPolarCluster.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarCluster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarCluster.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarCluster.Location = New System.Drawing.Point(110, 43)
        Me.rdoPolarCluster.Name = "rdoPolarCluster"
        Me.rdoPolarCluster.Size = New System.Drawing.Size(104, 28)
        Me.rdoPolarCluster.TabIndex = 30
        Me.rdoPolarCluster.TabStop = True
        Me.rdoPolarCluster.Tag = ""
        Me.rdoPolarCluster.Text = "Polar Cluster"
        Me.rdoPolarCluster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarCluster.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(44, 13)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(335, 61)
        Me.ucrPnlOptions.TabIndex = 28
        '
        'rdoPolarFrequency
        '
        Me.rdoPolarFrequency.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPolarFrequency.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarFrequency.FlatAppearance.BorderSize = 2
        Me.rdoPolarFrequency.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPolarFrequency.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPolarFrequency.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPolarFrequency.Location = New System.Drawing.Point(165, 17)
        Me.rdoPolarFrequency.Name = "rdoPolarFrequency"
        Me.rdoPolarFrequency.Size = New System.Drawing.Size(98, 28)
        Me.rdoPolarFrequency.TabIndex = 31
        Me.rdoPolarFrequency.TabStop = True
        Me.rdoPolarFrequency.Tag = ""
        Me.rdoPolarFrequency.Text = "Polar frequency"
        Me.rdoPolarFrequency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPolarFrequency.UseVisualStyleBackColor = True
        '
        'rdoPercentileRose
        '
        Me.rdoPercentileRose.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPercentileRose.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPercentileRose.FlatAppearance.BorderSize = 2
        Me.rdoPercentileRose.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPercentileRose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPercentileRose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoPercentileRose.Location = New System.Drawing.Point(71, 17)
        Me.rdoPercentileRose.Name = "rdoPercentileRose"
        Me.rdoPercentileRose.Size = New System.Drawing.Size(96, 28)
        Me.rdoPercentileRose.TabIndex = 29
        Me.rdoPercentileRose.TabStop = True
        Me.rdoPercentileRose.Tag = ""
        Me.rdoPercentileRose.Text = "Percentile Rose"
        Me.rdoPercentileRose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPercentileRose.UseVisualStyleBackColor = True
        '
        'ucrSaveGraph
        '
        Me.ucrSaveGraph.Location = New System.Drawing.Point(10, 418)
        Me.ucrSaveGraph.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveGraph.Name = "ucrSaveGraph"
        Me.ucrSaveGraph.Size = New System.Drawing.Size(391, 34)
        Me.ucrSaveGraph.TabIndex = 34
        '
        'ucrChkTransform
        '
        Me.ucrChkTransform.Checked = False
        Me.ucrChkTransform.Location = New System.Drawing.Point(26, 362)
        Me.ucrChkTransform.Name = "ucrChkTransform"
        Me.ucrChkTransform.Size = New System.Drawing.Size(154, 20)
        Me.ucrChkTransform.TabIndex = 29
        '
        'ucrChkIncludePollutant
        '
        Me.ucrChkIncludePollutant.Checked = False
        Me.ucrChkIncludePollutant.Location = New System.Drawing.Point(282, 220)
        Me.ucrChkIncludePollutant.Name = "ucrChkIncludePollutant"
        Me.ucrChkIncludePollutant.Size = New System.Drawing.Size(121, 20)
        Me.ucrChkIncludePollutant.TabIndex = 17
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(281, 221)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 8
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'lblVariableToPlotAgainstCluster
        '
        Me.lblVariableToPlotAgainstCluster.AutoSize = True
        Me.lblVariableToPlotAgainstCluster.Location = New System.Drawing.Point(279, 204)
        Me.lblVariableToPlotAgainstCluster.Name = "lblVariableToPlotAgainstCluster"
        Me.lblVariableToPlotAgainstCluster.Size = New System.Drawing.Size(66, 13)
        Me.lblVariableToPlotAgainstCluster.TabIndex = 7
        Me.lblVariableToPlotAgainstCluster.Text = "Plot Against:"
        '
        'ucrReceiverMultiplePollutants
        '
        Me.ucrReceiverMultiplePollutants.frmParent = Me
        Me.ucrReceiverMultiplePollutants.Location = New System.Drawing.Point(280, 294)
        Me.ucrReceiverMultiplePollutants.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverMultiplePollutants.Name = "ucrReceiverMultiplePollutants"
        Me.ucrReceiverMultiplePollutants.Selector = Nothing
        Me.ucrReceiverMultiplePollutants.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverMultiplePollutants.strNcFilePath = ""
        Me.ucrReceiverMultiplePollutants.TabIndex = 12
        Me.ucrReceiverMultiplePollutants.ucrSelector = Nothing
        '
        'ucrChkMultiplePollutants
        '
        Me.ucrChkMultiplePollutants.Checked = False
        Me.ucrChkMultiplePollutants.Location = New System.Drawing.Point(281, 249)
        Me.ucrChkMultiplePollutants.Name = "ucrChkMultiplePollutants"
        Me.ucrChkMultiplePollutants.Size = New System.Drawing.Size(120, 20)
        Me.ucrChkMultiplePollutants.TabIndex = 16
        '
        'ucrChkNormalise
        '
        Me.ucrChkNormalise.Checked = False
        Me.ucrChkNormalise.Location = New System.Drawing.Point(24, 356)
        Me.ucrChkNormalise.Name = "ucrChkNormalise"
        Me.ucrChkNormalise.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkNormalise.TabIndex = 26
        '
        'ucrNudNmberOfClusters
        '
        Me.ucrNudNmberOfClusters.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Location = New System.Drawing.Point(130, 272)
        Me.ucrNudNmberOfClusters.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudNmberOfClusters.Name = "ucrNudNmberOfClusters"
        Me.ucrNudNmberOfClusters.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudNmberOfClusters.TabIndex = 22
        Me.ucrNudNmberOfClusters.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNoOfClusters
        '
        Me.lblNoOfClusters.AutoSize = True
        Me.lblNoOfClusters.Location = New System.Drawing.Point(23, 276)
        Me.lblNoOfClusters.Name = "lblNoOfClusters"
        Me.lblNoOfClusters.Size = New System.Drawing.Size(78, 13)
        Me.lblNoOfClusters.TabIndex = 35
        Me.lblNoOfClusters.Text = "No Of Clusters:"
        '
        'ucrChkForcePositive
        '
        Me.ucrChkForcePositive.Checked = False
        Me.ucrChkForcePositive.Location = New System.Drawing.Point(24, 388)
        Me.ucrChkForcePositive.Name = "ucrChkForcePositive"
        Me.ucrChkForcePositive.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkForcePositive.TabIndex = 42
        '
        'ucrChkPadDate
        '
        Me.ucrChkPadDate.Checked = False
        Me.ucrChkPadDate.Location = New System.Drawing.Point(141, 390)
        Me.ucrChkPadDate.Name = "ucrChkPadDate"
        Me.ucrChkPadDate.Size = New System.Drawing.Size(107, 20)
        Me.ucrChkPadDate.TabIndex = 25
        '
        'ucrchkExcludeMissing
        '
        Me.ucrchkExcludeMissing.Checked = False
        Me.ucrchkExcludeMissing.Location = New System.Drawing.Point(23, 388)
        Me.ucrchkExcludeMissing.Name = "ucrchkExcludeMissing"
        Me.ucrchkExcludeMissing.Size = New System.Drawing.Size(144, 20)
        Me.ucrchkExcludeMissing.TabIndex = 27
        '
        'lblMultiplePollutants
        '
        Me.lblMultiplePollutants.AutoSize = True
        Me.lblMultiplePollutants.Location = New System.Drawing.Point(279, 275)
        Me.lblMultiplePollutants.Name = "lblMultiplePollutants"
        Me.lblMultiplePollutants.Size = New System.Drawing.Size(51, 13)
        Me.lblMultiplePollutants.TabIndex = 45
        Me.lblMultiplePollutants.Text = "Pollutant:"
        '
        'lblStatistic
        '
        Me.lblStatistic.AutoSize = True
        Me.lblStatistic.Location = New System.Drawing.Point(23, 276)
        Me.lblStatistic.Name = "lblStatistic"
        Me.lblStatistic.Size = New System.Drawing.Size(47, 13)
        Me.lblStatistic.TabIndex = 46
        Me.lblStatistic.Text = "Statistic:"
        '
        'ucrReceiverSinglePollutantPolarFreq
        '
        Me.ucrReceiverSinglePollutantPolarFreq.frmParent = Me
        Me.ucrReceiverSinglePollutantPolarFreq.Location = New System.Drawing.Point(280, 294)
        Me.ucrReceiverSinglePollutantPolarFreq.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSinglePollutantPolarFreq.Name = "ucrReceiverSinglePollutantPolarFreq"
        Me.ucrReceiverSinglePollutantPolarFreq.Selector = Nothing
        Me.ucrReceiverSinglePollutantPolarFreq.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSinglePollutantPolarFreq.strNcFilePath = ""
        Me.ucrReceiverSinglePollutantPolarFreq.TabIndex = 9
        Me.ucrReceiverSinglePollutantPolarFreq.ucrSelector = Nothing
        '
        'lblPollutantPolarFreq
        '
        Me.lblPollutantPolarFreq.AutoSize = True
        Me.lblPollutantPolarFreq.Location = New System.Drawing.Point(277, 275)
        Me.lblPollutantPolarFreq.Name = "lblPollutantPolarFreq"
        Me.lblPollutantPolarFreq.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutantPolarFreq.TabIndex = 14
        Me.lblPollutantPolarFreq.Text = "Pollutant:"
        '
        'ucrInputStatisticPolarFreq
        '
        Me.ucrInputStatisticPolarFreq.AddQuotesIfUnrecognised = True
        Me.ucrInputStatisticPolarFreq.GetSetSelectedIndex = -1
        Me.ucrInputStatisticPolarFreq.IsReadOnly = False
        Me.ucrInputStatisticPolarFreq.Location = New System.Drawing.Point(83, 271)
        Me.ucrInputStatisticPolarFreq.Name = "ucrInputStatisticPolarFreq"
        Me.ucrInputStatisticPolarFreq.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputStatisticPolarFreq.TabIndex = 49
        '
        'lblStatisticPolarFreq
        '
        Me.lblStatisticPolarFreq.AutoSize = True
        Me.lblStatisticPolarFreq.Location = New System.Drawing.Point(23, 277)
        Me.lblStatisticPolarFreq.Name = "lblStatisticPolarFreq"
        Me.lblStatisticPolarFreq.Size = New System.Drawing.Size(47, 13)
        Me.lblStatisticPolarFreq.TabIndex = 18
        Me.lblStatisticPolarFreq.Text = "Statistic:"
        '
        'UcrReceiverSinglePollutantPClusterandPRose
        '
        Me.UcrReceiverSinglePollutantPClusterandPRose.frmParent = Me
        Me.UcrReceiverSinglePollutantPClusterandPRose.Location = New System.Drawing.Point(280, 294)
        Me.UcrReceiverSinglePollutantPClusterandPRose.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSinglePollutantPClusterandPRose.Name = "UcrReceiverSinglePollutantPClusterandPRose"
        Me.UcrReceiverSinglePollutantPClusterandPRose.Selector = Nothing
        Me.UcrReceiverSinglePollutantPClusterandPRose.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSinglePollutantPClusterandPRose.strNcFilePath = ""
        Me.UcrReceiverSinglePollutantPClusterandPRose.TabIndex = 11
        Me.UcrReceiverSinglePollutantPClusterandPRose.ucrSelector = Nothing
        '
        'lblPollutantPClusterandPRose
        '
        Me.lblPollutantPClusterandPRose.AutoSize = True
        Me.lblPollutantPClusterandPRose.Location = New System.Drawing.Point(279, 275)
        Me.lblPollutantPClusterandPRose.Name = "lblPollutantPClusterandPRose"
        Me.lblPollutantPClusterandPRose.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutantPClusterandPRose.TabIndex = 13
        Me.lblPollutantPClusterandPRose.Text = "Pollutant:"
        '
        'ucrInputColorPCluster
        '
        Me.ucrInputColorPCluster.AddQuotesIfUnrecognised = True
        Me.ucrInputColorPCluster.GetSetSelectedIndex = -1
        Me.ucrInputColorPCluster.IsReadOnly = False
        Me.ucrInputColorPCluster.Location = New System.Drawing.Point(83, 302)
        Me.ucrInputColorPCluster.Name = "ucrInputColorPCluster"
        Me.ucrInputColorPCluster.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputColorPCluster.TabIndex = 50
        '
        'lblColorPCluster
        '
        Me.lblColorPCluster.AutoSize = True
        Me.lblColorPCluster.Location = New System.Drawing.Point(25, 306)
        Me.lblColorPCluster.Name = "lblColorPCluster"
        Me.lblColorPCluster.Size = New System.Drawing.Size(34, 13)
        Me.lblColorPCluster.TabIndex = 51
        Me.lblColorPCluster.Text = "Color:"
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(82, 271)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(97, 21)
        Me.ucrInputMethod.TabIndex = 52
        '
        'lblMethod
        '
        Me.lblMethod.AutoSize = True
        Me.lblMethod.Location = New System.Drawing.Point(23, 277)
        Me.lblMethod.Name = "lblMethod"
        Me.lblMethod.Size = New System.Drawing.Size(46, 13)
        Me.lblMethod.TabIndex = 53
        Me.lblMethod.Text = "Method:"
        '
        'lblPercentile
        '
        Me.lblPercentile.AutoSize = True
        Me.lblPercentile.Location = New System.Drawing.Point(23, 359)
        Me.lblPercentile.Name = "lblPercentile"
        Me.lblPercentile.Size = New System.Drawing.Size(57, 13)
        Me.lblPercentile.TabIndex = 55
        Me.lblPercentile.Text = "Percentile:"
        '
        'ucrChkSmooth
        '
        Me.ucrChkSmooth.Checked = False
        Me.ucrChkSmooth.Location = New System.Drawing.Point(23, 388)
        Me.ucrChkSmooth.Name = "ucrChkSmooth"
        Me.ucrChkSmooth.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkSmooth.TabIndex = 56
        '
        'ucrNudPercentile
        '
        Me.ucrNudPercentile.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPercentile.Location = New System.Drawing.Point(124, 357)
        Me.ucrNudPercentile.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPercentile.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPercentile.Name = "ucrNudPercentile"
        Me.ucrNudPercentile.Size = New System.Drawing.Size(56, 20)
        Me.ucrNudPercentile.TabIndex = 57
        Me.ucrNudPercentile.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgOtherRosePlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 511)
        Me.Controls.Add(Me.ucrNudPercentile)
        Me.Controls.Add(Me.lblPercentile)
        Me.Controls.Add(Me.lblMethod)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.lblColorPCluster)
        Me.Controls.Add(Me.ucrInputColorPCluster)
        Me.Controls.Add(Me.lblPollutantPClusterandPRose)
        Me.Controls.Add(Me.ucrchkExcludeMissing)
        Me.Controls.Add(Me.ucrChkPadDate)
        Me.Controls.Add(Me.ucrChkForcePositive)
        Me.Controls.Add(Me.lblNoOfClusters)
        Me.Controls.Add(Me.ucrNudNmberOfClusters)
        Me.Controls.Add(Me.ucrChkNormalise)
        Me.Controls.Add(Me.ucrChkMultiplePollutants)
        Me.Controls.Add(Me.lblVariableToPlotAgainstCluster)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrChkIncludePollutant)
        Me.Controls.Add(Me.ucrChkTransform)
        Me.Controls.Add(Me.ucrSaveGraph)
        Me.Controls.Add(Me.rdoPercentileRose)
        Me.Controls.Add(Me.rdoPolarFrequency)
        Me.Controls.Add(Me.rdoPolarAnnulus)
        Me.Controls.Add(Me.rdoPolarPlot)
        Me.Controls.Add(Me.rdoPolarCluster)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.ucrInputType)
        Me.Controls.Add(Me.ucrInputStatistic)
        Me.Controls.Add(Me.ucrInputColor)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblSinglePollutantPPlotandPAnnulus)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.ucrReceiverWindSpeed)
        Me.Controls.Add(Me.UcrReceiverDate)
        Me.Controls.Add(Me.ucrReceiverWindDirection)
        Me.Controls.Add(Me.ucrSelectorOtherRosePlots)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.lblStatisticPolarFreq)
        Me.Controls.Add(Me.lblStatistic)
        Me.Controls.Add(Me.ucrInputStatisticPolarFreq)
        Me.Controls.Add(Me.ucrReceiverSinglePollutantPolarFreq)
        Me.Controls.Add(Me.lblPollutantPolarFreq)
        Me.Controls.Add(Me.lblMultiplePollutants)
        Me.Controls.Add(Me.UcrReceiverSinglePollutantPClusterandPRose)
        Me.Controls.Add(Me.ucrReceiverSinglePollutantPPlotandPAnnulus)
        Me.Controls.Add(Me.ucrReceiverMultiplePollutants)
        Me.Controls.Add(Me.ucrChkSmooth)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgOtherRosePlots"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Other Rose Plots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrSelectorOtherRosePlots As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverSinglePollutantPPlotandPAnnulus As ucrReceiverSingle
    Friend WithEvents ucrInputType As ucrInputComboBox
    Friend WithEvents ucrInputStatistic As ucrInputComboBox
    Friend WithEvents ucrInputColor As ucrInputComboBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblSinglePollutantPPlotandPAnnulus As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents ucrReceiverWindSpeed As ucrReceiverSingle
    Friend WithEvents UcrReceiverDate As ucrReceiverSingle
    Friend WithEvents ucrReceiverWindDirection As ucrReceiverSingle
    Friend WithEvents rdoPercentileRose As RadioButton
    Friend WithEvents rdoPolarFrequency As RadioButton
    Friend WithEvents rdoPolarAnnulus As RadioButton
    Friend WithEvents rdoPolarPlot As RadioButton
    Friend WithEvents rdoPolarCluster As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
    Friend WithEvents ucrSaveGraph As ucrSave
    Friend WithEvents ucrChkTransform As ucrCheck
    Friend WithEvents ucrChkIncludePollutant As ucrCheck
    Friend WithEvents lblVariableToPlotAgainstCluster As Label
    Friend WithEvents ucrReceiverX As ucrReceiverSingle
    Friend WithEvents ucrReceiverMultiplePollutants As ucrReceiverMultiple
    Friend WithEvents ucrChkMultiplePollutants As ucrCheck
    Friend WithEvents ucrChkNormalise As ucrCheck
    Friend WithEvents lblNoOfClusters As Label
    Friend WithEvents ucrNudNmberOfClusters As ucrNud
    Friend WithEvents ucrchkExcludeMissing As ucrCheck
    Friend WithEvents ucrChkPadDate As ucrCheck
    Friend WithEvents ucrChkForcePositive As ucrCheck
    Friend WithEvents lblMultiplePollutants As Label
    Friend WithEvents lblStatistic As Label
    Friend WithEvents lblPollutantPolarFreq As Label
    Friend WithEvents ucrReceiverSinglePollutantPolarFreq As ucrReceiverSingle
    Friend WithEvents lblStatisticPolarFreq As Label
    Friend WithEvents ucrInputStatisticPolarFreq As ucrInputComboBox
    Friend WithEvents lblPollutantPClusterandPRose As Label
    Friend WithEvents UcrReceiverSinglePollutantPClusterandPRose As ucrReceiverSingle
    Friend WithEvents lblColorPCluster As Label
    Friend WithEvents ucrInputColorPCluster As ucrInputComboBox
    Friend WithEvents lblMethod As Label
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrChkSmooth As ucrCheck
    Friend WithEvents lblPercentile As Label
    Friend WithEvents ucrNudPercentile As ucrNud
End Class
