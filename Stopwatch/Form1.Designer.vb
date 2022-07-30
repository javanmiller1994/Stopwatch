Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.label_Time = New System.Windows.Forms.Label()
        Me.timer_StopwatchMonitor = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.but_StartStop = New Stopwatch.MyPictureBox()
        Me.but_Reset = New Stopwatch.MyPictureBox()
        Me.cb_OnTop = New Stopwatch.MyCheckBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.but_StartStop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Reset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_OnTop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label_Time
        '
        Me.label_Time.AutoSize = True
        Me.label_Time.Dock = System.Windows.Forms.DockStyle.Top
        Me.label_Time.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_Time.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.label_Time.Location = New System.Drawing.Point(0, 0)
        Me.label_Time.MinimumSize = New System.Drawing.Size(250, 0)
        Me.label_Time.Name = "label_Time"
        Me.label_Time.Size = New System.Drawing.Size(250, 54)
        Me.label_Time.TabIndex = 1
        Me.label_Time.Text = "00:00.00"
        Me.label_Time.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'timer_StopwatchMonitor
        '
        Me.timer_StopwatchMonitor.Enabled = True
        Me.timer_StopwatchMonitor.Interval = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.but_StartStop, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.but_Reset, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 59)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(224, 71)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'but_StartStop
        '
        Me.but_StartStop.BackColor = System.Drawing.Color.Transparent
        Me.but_StartStop.BackgroundImage = Global.Stopwatch.My.Resources.Resources.icons8_play_pause
        Me.but_StartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_StartStop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.but_StartStop.Location = New System.Drawing.Point(25, 3)
        Me.but_StartStop.Name = "but_StartStop"
        Me.but_StartStop.Size = New System.Drawing.Size(83, 65)
        Me.but_StartStop.TabIndex = 3
        Me.but_StartStop.TabStop = False
        '
        'but_Reset
        '
        Me.but_Reset.BackColor = System.Drawing.Color.Transparent
        Me.but_Reset.BackgroundImage = Global.Stopwatch.My.Resources.Resources.icons8_replay_96_1
        Me.but_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Reset.Dock = System.Windows.Forms.DockStyle.Fill
        Me.but_Reset.Location = New System.Drawing.Point(114, 3)
        Me.but_Reset.Name = "but_Reset"
        Me.but_Reset.Size = New System.Drawing.Size(83, 65)
        Me.but_Reset.TabIndex = 4
        Me.but_Reset.TabStop = False
        '
        'cb_OnTop
        '
        Me.cb_OnTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_OnTop.Location = New System.Drawing.Point(0, 136)
        Me.cb_OnTop.Name = "cb_OnTop"
        Me.cb_OnTop.Properties.AllowFocused = False
        Me.cb_OnTop.Properties.Caption = "Keep On Top"
        Me.cb_OnTop.Size = New System.Drawing.Size(87, 20)
        Me.cb_OnTop.TabIndex = 4
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 156)
        Me.Controls.Add(Me.cb_OnTop)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.label_Time)
        Me.IconOptions.Image = Global.Stopwatch.My.Resources.Resources.icons8_stopwatch_96
        Me.Name = "Form1"
        Me.Text = "Stopwatch"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.but_StartStop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Reset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_OnTop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents label_Time As Label
    Friend WithEvents timer_StopwatchMonitor As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents but_StartStop As MyPictureBox
    Friend WithEvents but_Reset As MyPictureBox
    Friend WithEvents cb_OnTop As MyCheckBox

#End Region

End Class
