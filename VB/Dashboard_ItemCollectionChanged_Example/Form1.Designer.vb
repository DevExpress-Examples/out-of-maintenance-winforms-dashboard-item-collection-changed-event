Namespace Dashboard_ItemCollectionChanged_Example
    Partial Public Class Form1
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
            Me.dashboardDesigner1 = New DevExpress.DashboardWin.DashboardDesigner()
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dashboardDesigner1
            ' 
            Me.dashboardDesigner1.AllowMaximizeAnimation = True
            Me.dashboardDesigner1.AllowMaximizeDashboardItems = True
            Me.dashboardDesigner1.AllowPrintDashboard = True
            Me.dashboardDesigner1.AllowPrintDashboardItems = True
            Me.dashboardDesigner1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.dashboardDesigner1.Location = New System.Drawing.Point(0, 149)
            Me.dashboardDesigner1.MenuManager = Me.ribbonControl1
            Me.dashboardDesigner1.Name = "dashboardDesigner1"
            Me.dashboardDesigner1.Size = New System.Drawing.Size(840, 419)
            Me.dashboardDesigner1.TabIndex = 0
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 1
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Size = New System.Drawing.Size(840, 49)
            Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
            ' 
            ' ribbonStatusBar1
            ' 
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 568)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(840, 31)
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Top
            Me.memoEdit1.Location = New System.Drawing.Point(0, 49)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
            Me.memoEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Blue
            Me.memoEdit1.Properties.Appearance.Options.UseBackColor = True
            Me.memoEdit1.Properties.Appearance.Options.UseForeColor = True
            Me.memoEdit1.Properties.ReadOnly = True
            Me.memoEdit1.Size = New System.Drawing.Size(840, 100)
            Me.memoEdit1.TabIndex = 1
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Name = "ribbonPage2"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(840, 599)
            Me.Controls.Add(Me.dashboardDesigner1)
            Me.Controls.Add(Me.memoEdit1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "Dashboard ItemCollectionChanged Example"
            CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private dashboardDesigner1 As DevExpress.DashboardWin.DashboardDesigner
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    End Class
End Namespace

