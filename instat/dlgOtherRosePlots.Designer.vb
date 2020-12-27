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
        Me.UcrReceiverSingle2 = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle5 = New instat.ucrReceiverSingle()
        Me.UcrReceiverDate = New instat.ucrReceiverSingle()
        Me.UcrReceiverSingle7 = New instat.ucrReceiverSingle()
        Me.lblWindSpeed = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblWindDirection = New System.Windows.Forms.Label()
        Me.lblPollutant = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UcrInputComboBox1 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox2 = New instat.ucrInputComboBox()
        Me.UcrInputComboBox3 = New instat.ucrInputComboBox()
        Me.rdoFrequencyPolygon = New System.Windows.Forms.RadioButton()
        Me.rdoDensity = New System.Windows.Forms.RadioButton()
        Me.rdoHistogram = New System.Windows.Forms.RadioButton()
        Me.ucrPnlOptions = New instat.UcrPanel()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(10, 377)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 0
        '
        'ucrSelectorOtherRosePlots
        '
        Me.ucrSelectorOtherRosePlots.bDropUnusedFilterLevels = False
        Me.ucrSelectorOtherRosePlots.bShowHiddenColumns = False
        Me.ucrSelectorOtherRosePlots.bUseCurrentFilter = True
        Me.ucrSelectorOtherRosePlots.Location = New System.Drawing.Point(10, 70)
        Me.ucrSelectorOtherRosePlots.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorOtherRosePlots.Name = "ucrSelectorOtherRosePlots"
        Me.ucrSelectorOtherRosePlots.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorOtherRosePlots.TabIndex = 1
        '
        'UcrReceiverSingle2
        '
        Me.UcrReceiverSingle2.frmParent = Me
        Me.UcrReceiverSingle2.Location = New System.Drawing.Point(282, 228)
        Me.UcrReceiverSingle2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle2.Name = "UcrReceiverSingle2"
        Me.UcrReceiverSingle2.Selector = Nothing
        Me.UcrReceiverSingle2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle2.strNcFilePath = ""
        Me.UcrReceiverSingle2.TabIndex = 3
        Me.UcrReceiverSingle2.ucrSelector = Nothing
        '
        'UcrReceiverSingle5
        '
        Me.UcrReceiverSingle5.frmParent = Me
        Me.UcrReceiverSingle5.Location = New System.Drawing.Point(282, 143)
        Me.UcrReceiverSingle5.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle5.Name = "UcrReceiverSingle5"
        Me.UcrReceiverSingle5.Selector = Nothing
        Me.UcrReceiverSingle5.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle5.strNcFilePath = ""
        Me.UcrReceiverSingle5.TabIndex = 6
        Me.UcrReceiverSingle5.ucrSelector = Nothing
        '
        'UcrReceiverDate
        '
        Me.UcrReceiverDate.frmParent = Me
        Me.UcrReceiverDate.Location = New System.Drawing.Point(282, 98)
        Me.UcrReceiverDate.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverDate.Name = "UcrReceiverDate"
        Me.UcrReceiverDate.Selector = Nothing
        Me.UcrReceiverDate.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverDate.strNcFilePath = ""
        Me.UcrReceiverDate.TabIndex = 7
        Me.UcrReceiverDate.ucrSelector = Nothing
        '
        'UcrReceiverSingle7
        '
        Me.UcrReceiverSingle7.frmParent = Me
        Me.UcrReceiverSingle7.Location = New System.Drawing.Point(281, 186)
        Me.UcrReceiverSingle7.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverSingle7.Name = "UcrReceiverSingle7"
        Me.UcrReceiverSingle7.Selector = Nothing
        Me.UcrReceiverSingle7.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverSingle7.strNcFilePath = ""
        Me.UcrReceiverSingle7.TabIndex = 8
        Me.UcrReceiverSingle7.ucrSelector = Nothing
        '
        'lblWindSpeed
        '
        Me.lblWindSpeed.AutoSize = True
        Me.lblWindSpeed.Location = New System.Drawing.Point(278, 170)
        Me.lblWindSpeed.Name = "lblWindSpeed"
        Me.lblWindSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblWindSpeed.TabIndex = 9
        Me.lblWindSpeed.Text = "Wind Speed:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(279, 82)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 11
        Me.lblDate.Text = "Date:"
        '
        'lblWindDirection
        '
        Me.lblWindDirection.AutoSize = True
        Me.lblWindDirection.Location = New System.Drawing.Point(278, 127)
        Me.lblWindDirection.Name = "lblWindDirection"
        Me.lblWindDirection.Size = New System.Drawing.Size(80, 13)
        Me.lblWindDirection.TabIndex = 12
        Me.lblWindDirection.Text = "Wind Direction:"
        '
        'lblPollutant
        '
        Me.lblPollutant.AutoSize = True
        Me.lblPollutant.Location = New System.Drawing.Point(278, 211)
        Me.lblPollutant.Name = "lblPollutant"
        Me.lblPollutant.Size = New System.Drawing.Size(51, 13)
        Me.lblPollutant.TabIndex = 13
        Me.lblPollutant.Text = "Pollutant:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Method:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Color:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Facet:"
        '
        'UcrInputComboBox1
        '
        Me.UcrInputComboBox1.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox1.GetSetSelectedIndex = -1
        Me.UcrInputComboBox1.IsReadOnly = False
        Me.UcrInputComboBox1.Location = New System.Drawing.Point(83, 302)
        Me.UcrInputComboBox1.Name = "UcrInputComboBox1"
        Me.UcrInputComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.UcrInputComboBox1.TabIndex = 17
        '
        'UcrInputComboBox2
        '
        Me.UcrInputComboBox2.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox2.GetSetSelectedIndex = -1
        Me.UcrInputComboBox2.IsReadOnly = False
        Me.UcrInputComboBox2.Location = New System.Drawing.Point(83, 271)
        Me.UcrInputComboBox2.Name = "UcrInputComboBox2"
        Me.UcrInputComboBox2.Size = New System.Drawing.Size(97, 21)
        Me.UcrInputComboBox2.TabIndex = 18
        '
        'UcrInputComboBox3
        '
        Me.UcrInputComboBox3.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox3.GetSetSelectedIndex = -1
        Me.UcrInputComboBox3.IsReadOnly = False
        Me.UcrInputComboBox3.Location = New System.Drawing.Point(83, 329)
        Me.UcrInputComboBox3.Name = "UcrInputComboBox3"
        Me.UcrInputComboBox3.Size = New System.Drawing.Size(97, 21)
        Me.UcrInputComboBox3.TabIndex = 19
        '
        'rdoFrequencyPolygon
        '
        Me.rdoFrequencyPolygon.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFrequencyPolygon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyPolygon.FlatAppearance.BorderSize = 2
        Me.rdoFrequencyPolygon.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoFrequencyPolygon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFrequencyPolygon.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoFrequencyPolygon.Location = New System.Drawing.Point(212, 43)
        Me.rdoFrequencyPolygon.Name = "rdoFrequencyPolygon"
        Me.rdoFrequencyPolygon.Size = New System.Drawing.Size(95, 28)
        Me.rdoFrequencyPolygon.TabIndex = 23
        Me.rdoFrequencyPolygon.TabStop = True
        Me.rdoFrequencyPolygon.Tag = "Frequency_Polygon"
        Me.rdoFrequencyPolygon.Text = "Polar Annulus"
        Me.rdoFrequencyPolygon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoFrequencyPolygon.UseVisualStyleBackColor = True
        '
        'rdoDensity
        '
        Me.rdoDensity.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDensity.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity.FlatAppearance.BorderSize = 2
        Me.rdoDensity.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDensity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDensity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDensity.Location = New System.Drawing.Point(261, 17)
        Me.rdoDensity.Name = "rdoDensity"
        Me.rdoDensity.Size = New System.Drawing.Size(96, 28)
        Me.rdoDensity.TabIndex = 22
        Me.rdoDensity.TabStop = True
        Me.rdoDensity.Tag = "Density"
        Me.rdoDensity.Text = "Polar Plot"
        Me.rdoDensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDensity.UseVisualStyleBackColor = True
        '
        'rdoHistogram
        '
        Me.rdoHistogram.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHistogram.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHistogram.FlatAppearance.BorderSize = 2
        Me.rdoHistogram.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHistogram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHistogram.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoHistogram.Location = New System.Drawing.Point(110, 43)
        Me.rdoHistogram.Name = "rdoHistogram"
        Me.rdoHistogram.Size = New System.Drawing.Size(104, 28)
        Me.rdoHistogram.TabIndex = 21
        Me.rdoHistogram.TabStop = True
        Me.rdoHistogram.Tag = "Histogram"
        Me.rdoHistogram.Text = "Polar Cluster"
        Me.rdoHistogram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHistogram.UseVisualStyleBackColor = True
        '
        'ucrPnlOptions
        '
        Me.ucrPnlOptions.Location = New System.Drawing.Point(44, 13)
        Me.ucrPnlOptions.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlOptions.Name = "ucrPnlOptions"
        Me.ucrPnlOptions.Size = New System.Drawing.Size(335, 61)
        Me.ucrPnlOptions.TabIndex = 20
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatAppearance.BorderSize = 2
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton2.Location = New System.Drawing.Point(165, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(98, 28)
        Me.RadioButton2.TabIndex = 25
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Tag = "Histogram"
        Me.RadioButton2.Text = "Polar frequency"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton3.FlatAppearance.BorderSize = 2
        Me.RadioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton3.Location = New System.Drawing.Point(71, 17)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(96, 28)
        Me.RadioButton3.TabIndex = 26
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Tag = "Histogram"
        Me.RadioButton3.Text = "Percentile Rose"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'dlgOtherRosePlots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 456)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.rdoFrequencyPolygon)
        Me.Controls.Add(Me.rdoDensity)
        Me.Controls.Add(Me.rdoHistogram)
        Me.Controls.Add(Me.ucrPnlOptions)
        Me.Controls.Add(Me.UcrInputComboBox3)
        Me.Controls.Add(Me.UcrInputComboBox2)
        Me.Controls.Add(Me.UcrInputComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPollutant)
        Me.Controls.Add(Me.lblWindDirection)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblWindSpeed)
        Me.Controls.Add(Me.UcrReceiverSingle7)
        Me.Controls.Add(Me.UcrReceiverDate)
        Me.Controls.Add(Me.UcrReceiverSingle5)
        Me.Controls.Add(Me.UcrReceiverSingle2)
        Me.Controls.Add(Me.ucrSelectorOtherRosePlots)
        Me.Controls.Add(Me.ucrBase)
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
    Friend WithEvents UcrReceiverSingle2 As ucrReceiverSingle
    Friend WithEvents UcrInputComboBox3 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox2 As ucrInputComboBox
    Friend WithEvents UcrInputComboBox1 As ucrInputComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPollutant As Label
    Friend WithEvents lblWindDirection As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblWindSpeed As Label
    Friend WithEvents UcrReceiverSingle7 As ucrReceiverSingle
    Friend WithEvents UcrReceiverDate As ucrReceiverSingle
    Friend WithEvents UcrReceiverSingle5 As ucrReceiverSingle
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rdoFrequencyPolygon As RadioButton
    Friend WithEvents rdoDensity As RadioButton
    Friend WithEvents rdoHistogram As RadioButton
    Friend WithEvents ucrPnlOptions As UcrPanel
End Class
