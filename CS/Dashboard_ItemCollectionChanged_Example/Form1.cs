using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dashboard_ItemCollectionChanged_Example
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            dashboardDesigner1.CreateRibbon();
            dashboardDesigner1.DashboardLoaded += DashboardDesigner1_DashboardLoaded;
            dashboardDesigner1.CustomizeDashboardTitle += DashboardDesigner1_CustomizeDashboardTitle;
            dashboardDesigner1.Dashboard = new Dashboard();
        }

        private void DashboardDesigner1_DashboardLoaded(object sender, DevExpress.DashboardWin.DashboardLoadedEventArgs e)
        {
            e.Dashboard.ItemCollectionChanged += Dashboard_ItemCollectionChanged;
        }

        private void Dashboard_ItemCollectionChanged(object sender, NotifyingCollectionChangedEventArgs<DashboardItem> e)
        {
            Dashboard dBoard = sender as Dashboard;
            if (e.AddedItems.Count > 0)
            {
                if (e.AddedItems.Count == 1 && dBoard.Items.Count(i => i.Name == e.AddedItems[0].Name) > 1)
                    AddToLog("Duplicated", e.AddedItems);
                else
                    AddToLog("Added", e.AddedItems);
            }
            if (e.RemovedItems.Count > 0)
            {
                AddToLog("Removed", e.RemovedItems);
            }
        }
        private void AddToLog(string actionLabel, IList<DashboardItem> items)
        {
            var strItems = items.Select(i => String.Format("{0} ComponentName= {1}, Name= {2}", actionLabel, i.ComponentName, i.Name));
            memoEdit1.Text += String.Format("{0}\r\n", String.Join("; ", strItems));
            memoEdit1.SelectionStart = memoEdit1.Text.Length - 1;
            memoEdit1.ScrollToCaret();
        }
        private void DashboardDesigner1_CustomizeDashboardTitle(object sender, CustomizeDashboardTitleEventArgs e)
        {
            e.Items.Add(new DashboardToolbarItem("Clear Log", new Action<DashboardToolbarItemClickEventArgs>((args) =>
            {
                memoEdit1.Text = string.Empty;
            }
            )));
            e.Items.Add(new DashboardToolbarItem("Add a new Grid item", new Action<DashboardToolbarItemClickEventArgs>((args) =>
            {
                DashboardDesigner dControl = sender as DashboardDesigner;
                dControl.Dashboard.Items.AddRange(new GridDashboardItem(), new ChartDashboardItem());
            }
            )));
        }
    }
}
