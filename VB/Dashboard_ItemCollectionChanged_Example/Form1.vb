Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.DataAccess
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace Dashboard_ItemCollectionChanged_Example
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
            dashboardDesigner1.CreateRibbon()
            AddHandler dashboardDesigner1.DashboardLoaded, AddressOf DashboardDesigner1_DashboardLoaded
            AddHandler dashboardDesigner1.CustomizeDashboardTitle, AddressOf DashboardDesigner1_CustomizeDashboardTitle
            dashboardDesigner1.Dashboard = New Dashboard()
        End Sub

        Private Sub DashboardDesigner1_DashboardLoaded(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.DashboardLoadedEventArgs)
            AddHandler e.Dashboard.ItemCollectionChanged, AddressOf Dashboard_ItemCollectionChanged
        End Sub

        Private Sub Dashboard_ItemCollectionChanged(ByVal sender As Object, ByVal e As NotifyingCollectionChangedEventArgs(Of DashboardItem))
            Dim dBoard As Dashboard = TryCast(sender, Dashboard)
            If e.AddedItems.Count > 0 Then
                If e.AddedItems.Count = 1 AndAlso dBoard.Items.Count(Function(i) i.Name = e.AddedItems(0).Name) > 1 Then
                    AddToLog("Duplicated", e.AddedItems)
                Else
                    AddToLog("Added", e.AddedItems)
                End If
            End If
            If e.RemovedItems.Count > 0 Then
                AddToLog("Removed", e.RemovedItems)
            End If
        End Sub
        Private Sub AddToLog(ByVal actionLabel As String, ByVal items As IList(Of DashboardItem))
            Dim strItems = items.Select(Function(i) String.Format("{0} ComponentName= {1}, Name= {2}", actionLabel, i.ComponentName, i.Name))
            memoEdit1.Text += String.Format("{0}" & ControlChars.CrLf, String.Join("; ", strItems))
            memoEdit1.SelectionStart = memoEdit1.Text.Length - 1
            memoEdit1.ScrollToCaret()
        End Sub
        Private Sub DashboardDesigner1_CustomizeDashboardTitle(ByVal sender As Object, ByVal e As CustomizeDashboardTitleEventArgs)
            e.Items.Add(New DashboardToolbarItem("Clear Log", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
                memoEdit1.Text = String.Empty
            End Sub)))
            e.Items.Add(New DashboardToolbarItem("Add a new Grid item", New Action(Of DashboardToolbarItemClickEventArgs)(Sub(args)
                Dim dControl As DashboardDesigner = TryCast(sender, DashboardDesigner)
                dControl.Dashboard.Items.AddRange(New GridDashboardItem(), New ChartDashboardItem())
            End Sub)))
        End Sub
    End Class
End Namespace
