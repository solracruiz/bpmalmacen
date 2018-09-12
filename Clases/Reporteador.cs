using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace bpmalmacen.Clases
{
    class Reporteador
    {
        conexion conn = new conexion();
        DataSet myData = new DataSet();
        //ReportDocument myReport = new ReportDocument();
        public void crear_reporte(string sql,  string nombrereporte, string titulo)
        {
            conn.AbrirBD();
         
            try
            {
                CRAXDRT.Application crxApp = new CRAXDRT.Application();
                conn.GetTable2(sql);
                conn.PropertyAdaptador.Fill(myData);
                string ruta = @"c:\\bpmalmacen\reportes\" + nombrereporte;
                myData.WriteXml(@ruta + ".xml", XmlWriteMode.WriteSchema);
                CRAXDRT.Report crxRpt = crxApp.OpenReport(@ruta + ".rpt", 1);
                ExportReportToPDF(crxRpt, @ruta + ".pdf", titulo);
                Process.Start(@ruta + ".pdf");
                conn.cerrarBd();
               
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Report could not be created",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ExportReportToPDF(CRAXDRT.Report ReportObject, String FileName, String ReportTitle)
        {
            CRAXDRT.ExportOptions objExportOptions;
            ReportObject.ReportTitle = ReportTitle;
            ReportObject.EnableParameterPrompting = false;
            ReportObject.MorePrintEngineErrorMessages = true;
            objExportOptions = ReportObject.ExportOptions;
            objExportOptions.DestinationType = CRAXDRT.CRExportDestinationType.crEDTDiskFile;
            objExportOptions.DiskFileName = FileName;
            objExportOptions.FormatType = CRAXDRT.CRExportFormatType.crEFTPortableDocFormat;
            objExportOptions.PDFExportAllPages = true;
            ReportObject.Export(false);

        }
    }
}
