﻿using System;
using System.Data;
using System.Windows.Forms;
using Sigesoft.Node.WinClient.BLL;

namespace Sigesoft.Node.WinClient.UI.Gerencia
{
    public partial class FrmMes : Form
    {
        GerenciaMesBl oGerenciaMesBl =new GerenciaMesBl();
        public FrmMes()
        {
            InitializeComponent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ShowReport(dtpAnio.Value);
        }

        private void ShowReport(DateTime date)
        {
          var list =  oGerenciaMesBl.Filter(date);

            var rp = new Crystals.crGerenciaMes();
            var ds = new DataSet();

            var dt = Sigesoft.Node.WinClient.BLL.Utils.ConvertToDatatable(list);
            dt.TableName = "DtGerenciaMes";
            ds.Tables.Add(dt);

            rp.SetDataSource(ds);

            crvPorMes.ReportSource = rp;
            crvPorMes.Show();
        }
    }
}
