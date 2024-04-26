using iTextSharp.text;
using iTextSharp.text.pdf;
using Sigesoft.Node.WinClient.BE;
using Sigesoft.Node.WinClient.BE.Custom;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace NetPdf
{
    public class InformeLaboratoriocCasta
    {
        private static void RunFile(string filePdf)
        {
            Process proceso = Process.Start(filePdf);
            proceso.WaitForExit();
            proceso.Close();
        }

        public static void CreateExamen_InformeLaboratoriocCasta(PacientList filiationData,
            List<ServiceComponentList> serviceComponent,
           organizationDto infoEmpresa,
            PacientList datosPac,
           string filePDF, UsuarioGrabo DatosGrabo)
        {
            Document document = new Document(PageSize.A4, 40f, 40f, 60f, 50f);

            document.SetPageSize(iTextSharp.text.PageSize.A4);

            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePDF, FileMode.Create));
            pdfPage page = new pdfPage();
            writer.PageEvent = page;
            document.Open();


            #region Declaration Tables
            var subTitleBackGroundColor = new BaseColor(System.Drawing.Color.Gray);
            string include = string.Empty;
            List<PdfPCell> cells = null;
            List<PdfPCell> cells1 = null;
            float[] columnWidths = null;
            string[] columnValues = null;
            string[] columnHeaders = null;
            PdfPTable header2 = new PdfPTable(6);
            header2.HorizontalAlignment = Element.ALIGN_CENTER;
            header2.WidthPercentage = 100;
            float[] widths1 = new float[] { 16.6f, 18.6f, 16.6f, 16.6f, 16.6f, 16.6f };
            header2.SetWidths(widths1);
            PdfPTable companyData = new PdfPTable(6);
            companyData.HorizontalAlignment = Element.ALIGN_CENTER;
            companyData.WidthPercentage = 100;
            float[] widthscolumnsCompanyData = new float[] { 16.6f, 16.6f, 16.6f, 16.6f, 16.6f, 16.6f };
            companyData.SetWidths(widthscolumnsCompanyData);
            PdfPTable filiationWorker = new PdfPTable(4);
            PdfPTable table = null;
            PdfPCell cell = null;
            //document.Add(new Paragraph("\r\n"));
            #endregion

            #region Fonts
            Font fontTitle1 = FontFactory.GetFont("Calibri", 10, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            Font fontTitle2 = FontFactory.GetFont("Calibri", 7, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
            Font fontTitleTable = FontFactory.GetFont("Calibri", 6, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            Font fontTitleTableNegro = FontFactory.GetFont("Calibri", 6, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            Font fontSubTitle = FontFactory.GetFont("Calibri", 6, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.White));
            Font fontSubTitleNegroNegrita = FontFactory.GetFont("Calibri", 6, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));

            Font fontColumnValue = FontFactory.GetFont("Calibri", 8, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));
            Font fontColumnValue_PREOPERATORIO = FontFactory.GetFont("Calibri", 7, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));

            Font fontColumnValue_SANGRIA = FontFactory.GetFont("Calibri", 10, iTextSharp.text.Font.NORMAL, new BaseColor(System.Drawing.Color.Black));

            Font fontColumnValueBold = FontFactory.GetFont("Calibri", 9, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            Font fontColumnValueBold_PREOPERATORIO = FontFactory.GetFont("Calibri", 8, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));

            Font fontColumnValueBold2 = FontFactory.GetFont("Calibri", 8, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            Font fontColumnValueBold2_SANGRIA = FontFactory.GetFont("Calibri", 11, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));

            Font fontColumnValueBold1 = FontFactory.GetFont("Calibri", 12, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));
            Font fontColumnValueApendice = FontFactory.GetFont("Calibri", 5, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.Black));

            Font fontColumnValueBold2blanco = FontFactory.GetFont("Calibri", 8, iTextSharp.text.Font.BOLD, new BaseColor(System.Drawing.Color.White));

            #endregion

            document.NewPage();
            var tamaño_celda = 13f;

            var tamaño_celda_1 = 16f;
            #region TÍTULO

            cells = new List<PdfPCell>();

            var cellsTit = new List<PdfPCell>()
                { 
                    new PdfPCell(new Phrase("", fontColumnValue)) {HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 20f, UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.BLACK, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE},
                    new PdfPCell(new Phrase("", fontTitle1)) {HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 20f},
                    new PdfPCell(new Phrase("", fontColumnValue)) {HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 20f, UseVariableBorders = true, BorderColorLeft = BaseColor.BLACK, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE},
                
                };
            columnWidths = new float[] { 30f, 40f, 30f, };
            table = HandlingItextSharp.GenerateTableFromCells(cellsTit, columnWidths, PdfPCell.NO_BORDER, null, fontTitleTable);
            document.Add(table);
            #endregion

            #region DATOS GENERALES
            
            string sexo = "";
            if (datosPac.Genero == "MASCULINO") sexo = "M";
            else if (datosPac.Genero == "FEMENINO") sexo = "F";
            string[] servicio = datosPac.FechaServicio.ToString().Split(' ');
            ServiceComponentList laboratorioCasta = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.INFORME_LABORATORIO_ID_CASTA);
            var INFORME_LABORATORIO_CASTA_ATENCION = laboratorioCasta.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INFORME_LABORATORIO_CASTA_ATENCION) == null ? "-" : laboratorioCasta.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INFORME_LABORATORIO_CASTA_ATENCION).v_Value1;
            var INFORME_LABORATORIO_CASTA_SERVICIO = laboratorioCasta.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INFORME_LABORATORIO_CASTA_SERVICIO) == null ? "-" : laboratorioCasta.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INFORME_LABORATORIO_CASTA_SERVICIO).v_Value1;

           
            var colorPlantilla = new BaseColor(10, 105, 153);
            cells = new List<PdfPCell>()
            {
                new PdfPCell(new Phrase("RESULTADO DE ANALISIS DE LABORATORIO CLINICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },    

                new PdfPCell(new Phrase("Datos del Paciente: ", fontColumnValueBold2blanco)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.BLACK, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE, BackgroundColor =colorPlantilla},    
                new PdfPCell(new Phrase("", fontColumnValueBold2)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.BLACK, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("Datos Orden: ", fontColumnValueBold2blanco)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.BLACK, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE, BackgroundColor = colorPlantilla },    
                new PdfPCell(new Phrase("", fontColumnValueBold2)) { Colspan = 4, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.BLACK, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                
                new PdfPCell(new Phrase("Paciente : " + datosPac.v_FirstLastName + " " + datosPac.v_SecondLastName + " " + datosPac.v_FirstName, fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = BaseColor.WHITE, BorderColorTop = colorPlantilla },    
                new PdfPCell(new Phrase("", fontColumnValueBold2)) { Colspan = 1, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("Atencion  : "  + INFORME_LABORATORIO_CASTA_ATENCION, fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = BaseColor.WHITE, BorderColorTop = colorPlantilla},    

                new PdfPCell(new Phrase("Edad  : " + datosPac.Edad.ToString() + " Años", fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("", fontColumnValueBold2)) { Colspan = 1, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("Servicio  : " + INFORME_LABORATORIO_CASTA_SERVICIO, fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    

                new PdfPCell(new Phrase("Sexo  : " + sexo, fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight =colorPlantilla, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("", fontColumnValueBold2)) { Colspan = 1, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("Fecha  : " + servicio[0], fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    

                new PdfPCell(new Phrase("DNI : " + datosPac.v_DocNumber, fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("", fontColumnValueBold2)) { Colspan = 1, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE },    
                new PdfPCell(new Phrase("H.C.  : " + datosPac.HistoriaClinica , fontColumnValueBold2)) { Colspan = 9, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = BaseColor.WHITE },    

                new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 8f, Border = PdfPCell.NO_BORDER},    

                new PdfPCell(new Phrase("Examenes Realizados", fontColumnValueBold2blanco)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla, BackgroundColor =colorPlantilla},    
                new PdfPCell(new Phrase("Resultados", fontColumnValueBold2blanco)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla, BackgroundColor = colorPlantilla },    
                new PdfPCell(new Phrase("Valores de referencia", fontColumnValueBold2blanco)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla, BackgroundColor = colorPlantilla },    
                new PdfPCell(new Phrase("Unidades", fontColumnValueBold2blanco)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla, BackgroundColor = colorPlantilla },    

                new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 8f, Border = PdfPCell.NO_BORDER},    

                //new PdfPCell(new Phrase("GRUPO", fontColumnValueBold2)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },    

               
            };

            columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
            table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
            document.Add(table);
            #endregion

            #region BIOQUIMICA
            ServiceComponentList glucosa_basal = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.GLUCOSA_BASAL_ID);
            ServiceComponentList glucosa_colesterol_triglice = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.GLUCOSA_COLES_TRIG_ID);

            ServiceComponentList perfil_hepatico = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PERFIL_HEPATICO_ID_LC);
            ServiceComponentList perfil_lipidico = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PERFIL_LIPIDICO_ID);
            ServiceComponentList perfil_renal = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PERFIL_RENAL_ID);
            ServiceComponentList gamma_glutamil = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.GGTP_ID_ASIST);
            ServiceComponentList amilasa = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.AMILASA_ID);
            ServiceComponentList hierro = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.HIERRO_ID);
            ServiceComponentList colesterol = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.COLESTEROL_TOTAL_ID);
            ServiceComponentList trigliceridos = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_ID);
            ServiceComponentList insulina_basal = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.INSULINA_BASAL_LC_ID);
            ServiceComponentList insulina_postpandrial = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_ID);

            ServiceComponentList lipasa = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.LIPASA_ID);
            ServiceComponentList calcioSerico = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.CALCIO_SERICO_ID);
            ServiceComponentList electrolitos = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.ELECTROLITOS_ID);


            if (glucosa_basal != null || glucosa_colesterol_triglice!= null || perfil_hepatico != null || perfil_lipidico != null || perfil_renal != null
                || gamma_glutamil != null || amilasa != null || hierro != null || colesterol  != null || trigliceridos != null
                || insulina_basal != null || insulina_postpandrial != null || lipasa != null || calcioSerico != null || electrolitos != null)
            {
                cells = new List<PdfPCell>()
                {
                    new PdfPCell(new Phrase("BIOQUIMICA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                    
                    new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 5f, Border = PdfPCell.NO_BORDER},    

                };

                columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                document.Add(table);

                if (glucosa_basal != null)
                {

                    var GLUCOSA_BASAL_VALOR = glucosa_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_BASAL_VALOR) == null ? "-" : glucosa_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_BASAL_VALOR).v_Value1;
                    var GLUCOSA_BASAL_VALOR_UNIDAD = glucosa_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_BASAL_VALOR) == null ? "-" : glucosa_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_BASAL_VALOR).v_MeasurementUnitName;
                    var GLUCOSA_BASAL_VALOR_DESEABLE = glucosa_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_BASAL_VALOR_DESEABLE) == null ? "-" : glucosa_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_BASAL_VALOR_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("GLUCOSA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Glucosa", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_BASAL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_BASAL_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_BASAL_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (glucosa_colesterol_triglice != null)
                {

                    var GLUCOSA_VALOR = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR).v_Value1;
                    var GLUCOSA_VALOR_UNIDAD = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR).v_MeasurementUnitName;
                    var GLUCOSA_VALOR_DESEABLE = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR_DESEABLE) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR_DESEABLE).v_Value1;

                    var COLEST_BASAL_VALOR = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLEST_BASAL_VALOR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLEST_BASAL_VALOR).v_Value1;
                    var COLEST_BASAL_VALOR_UNIDAD = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLEST_BASAL_VALOR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLEST_BASAL_VALOR).v_MeasurementUnitName;
                    var COLEST_BASAL_VALOR_DESEABLE = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLEST_BASAL_VALOR_DESEABLE) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLEST_BASAL_VALOR_DESEABLE).v_Value1;

                    var TRIGL_VALOR = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGL_VALOR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGL_VALOR).v_Value1;
                    var TRIGL_VALOR_UNIDAD = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGL_VALOR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGL_VALOR).v_MeasurementUnitName;
                    var TRIGL_VALOR_DESEABLE = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGL_VALOR_DESEABLE) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGL_VALOR_DESEABLE).v_Value1;

                    var OBSERVACIONES_GLUC_COL_TR = glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.OBSERVACIONES_GLUC_COL_TR) == null ? "-" : glucosa_colesterol_triglice.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.OBSERVACIONES_GLUC_COL_TR).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("GLUCOSA - COLESTEROL - TRIGLICERIDOS", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Glucosa", fontColumnValueBold)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                        new PdfPCell(new Phrase("   Colesterol total", fontColumnValueBold)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COLEST_BASAL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COLEST_BASAL_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COLEST_BASAL_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Trigliceridos", fontColumnValueBold)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TRIGL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TRIGL_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TRIGL_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Observaciones", fontColumnValueBold)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(OBSERVACIONES_GLUC_COL_TR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    


                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (gamma_glutamil != null)
                {

                    var GGTP_VALOR = gamma_glutamil.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GGTP_VALOR) == null ? "-" : gamma_glutamil.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GGTP_VALOR).v_Value1;
                    var GGTP_VALOR_UNIDAD = gamma_glutamil.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GGTP_VALOR) == null ? "-" : gamma_glutamil.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GGTP_VALOR).v_MeasurementUnitName;
                    var GGTP_DESEABLE = gamma_glutamil.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GGTP_DESEABLE) == null ? "-" : gamma_glutamil.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GGTP_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("GAMMA GLUTAMIL TRANSPEPTIDASA (GGTP)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Gamma Glutamil Transpeptidasa (GGTP)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GGTP_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GGTP_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GGTP_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (amilasa != null)
                {

                    var AMILASA_VALOR = amilasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AMILASA_VALOR) == null ? "-" : amilasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AMILASA_VALOR).v_Value1;
                    var AMILASA_VALOR_UNIDAD = amilasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AMILASA_VALOR) == null ? "-" : amilasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AMILASA_VALOR).v_MeasurementUnitName;
                    var AMILASA_DESEABLE = amilasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AMILASA_DESEABLE) == null ? "-" : amilasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AMILASA_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("AMILASA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Amilasa", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AMILASA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AMILASA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AMILASA_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (hierro != null)
                {

                    var HIERRO_VALOR = hierro.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIERRO_VALOR) == null ? "-" : hierro.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIERRO_VALOR).v_Value1;
                    var HIERRO_VALOR_UNIDAD = hierro.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIERRO_VALOR) == null ? "-" : hierro.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIERRO_VALOR).v_MeasurementUnitName;
                    var HIERRO_DESEABLE = hierro.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIERRO_DESEABLE) == null ? "-" : hierro.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIERRO_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("HIERRO SERICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   HIERRO SERICO \n   (Método: Colorimetrico)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HIERRO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HIERRO_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HIERRO_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (calcioSerico != null)
                {

                    var CALCIO_SERICO_VALOR = calcioSerico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CALCIO_SERICO_VALOR) == null ? "-" : calcioSerico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CALCIO_SERICO_VALOR).v_Value1;
                    var CALCIO_SERICO_VALOR_UNIDAD = calcioSerico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CALCIO_SERICO_VALOR) == null ? "-" : calcioSerico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CALCIO_SERICO_VALOR).v_MeasurementUnitName;
                    var CALCIO_SERICO_DESEABLE = calcioSerico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CALCIO_SERICO_DESEABLE) == null ? "-" : calcioSerico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CALCIO_SERICO_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("CALCIO SERICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Calcio serico  \n   (Método: Enzimatica-colorimetrica (NM_BAPTA))", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CALCIO_SERICO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CALCIO_SERICO_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CALCIO_SERICO_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (electrolitos != null)
                {

                    var SODIO_VALOR = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SODIO_VALOR) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SODIO_VALOR).v_Value1;
                    var SODIO_VALOR_UNIDAD = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SODIO_VALOR) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SODIO_VALOR).v_MeasurementUnitName;
                    var SODIO_DESEABLE = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SODIO_DESEABLE) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SODIO_DESEABLE).v_Value1;

                    var POTASIO_VALOR = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.POTASIO_VALOR) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.POTASIO_VALOR).v_Value1;
                    var POTASIO_VALOR_UNIDAD = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.POTASIO_VALOR) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.POTASIO_VALOR).v_MeasurementUnitName;
                    var POTASIO_DESEABLE = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.POTASIO_DESEABLE) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.POTASIO_DESEABLE).v_Value1;

                    var CLORO_VALOR = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CLORO_VALOR) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CLORO_VALOR).v_Value1;
                    var CLORO_VALOR_UNIDAD = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CLORO_VALOR) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CLORO_VALOR).v_MeasurementUnitName;
                    var CLORO_DESEABLE = electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CLORO_DESEABLE) == null ? "-" : electrolitos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CLORO_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("ELECTROLITOS SERICOS ", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Sodio (Na)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(SODIO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(SODIO_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(SODIO_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                        new PdfPCell(new Phrase("   Potasio (K)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(POTASIO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(POTASIO_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(POTASIO_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Cloro (Cl)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CLORO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CLORO_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CLORO_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("Método: ISE", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER , VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (colesterol != null)
                {

                    var COLESTEROL_VALOR = colesterol.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLESTEROL_VALOR) == null ? "-" : colesterol.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLESTEROL_VALOR).v_Value1;
                    var COLESTEROL_VALOR_UNIDAD = colesterol.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLESTEROL_VALOR) == null ? "-" : colesterol.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLESTEROL_VALOR).v_MeasurementUnitName;
                    var COLESTEROL_DESEABLE = colesterol.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLESTEROL_DESEABLE) == null ? "-" : colesterol.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COLESTEROL_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("COLESTEROL TOTAL", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("  Colesterol Total", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COLESTEROL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COLESTEROL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COLESTEROL_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (trigliceridos != null)
                {

                    var TRIGLICERIDOS_VALOR = trigliceridos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_VALOR) == null ? "-" : trigliceridos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_VALOR).v_Value1;
                    var TRIGLICERIDOS_VALOR_UNIDAD = trigliceridos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_VALOR) == null ? "-" : trigliceridos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_VALOR).v_MeasurementUnitName;
                    var TRIGLICERIDOS_DESEABLE = trigliceridos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_DESEABLE) == null ? "-" : trigliceridos.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TRIGLICERIDOS_LC_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("TRIGLICERIDOS", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("  Trigliceridos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TRIGLICERIDOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TRIGLICERIDOS_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TRIGLICERIDOS_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (perfil_lipidico != null)
                {
                    var PL_COLESTEROL_TOTAL = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_TOTAL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_TOTAL).v_Value1;
                    var PL_COLESTEROL_TOTAL_unidad = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_TOTAL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_TOTAL).v_MeasurementUnitName;
                    var PL_colesterol_total_valor_deseado = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_TOTAL_DESEABLE) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_TOTAL_DESEABLE).v_Value1;

                    var PL_COLESTEROL_HDL = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_HDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_HDL).v_Value1;
                    var PL_COLESTEROL_HDL_unidad = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_HDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_HDL).v_MeasurementUnitName;
                    var PL_COLESTEROL_HDL_DESEABLE = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_HDL_DESEABLE) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_HDL_DESEABLE).v_Value1;

                    var PL_REL_COLESTEROL_HDL = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_REL_COLESTEROL_HDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_REL_COLESTEROL_HDL).v_Value1;
                    var PL_REL_COLESTEROL_HDL_unidad = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_REL_COLESTEROL_HDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_REL_COLESTEROL_HDL).v_MeasurementUnitName;
                    var PL_REL_COLESTEROL_HDL_DESEABLE = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_REL_COLESTEROL_HDL_DESEABLE) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_REL_COLESTEROL_HDL_DESEABLE).v_Value1;

                    var PL_COLESTEROL_LDL = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_LDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_LDL).v_Value1;
                    var PL_COLESTEROL_LDL_unidad = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_LDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_LDL).v_MeasurementUnitName;
                    var PL_COLESTEROL_LDL_DESEABLE = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_LDL_DESEABLE) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_LDL_DESEABLE).v_Value1;

                    var PL_COLESTEROL_VLDL = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_VLDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_VLDL).v_Value1;
                    var PL_COLESTEROL_VLDL_unidad = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_VLDL) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_VLDL).v_MeasurementUnitName;
                    var PL_COLESTEROL_VLDL_DESEABLE = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_VLDL_DESEABLE) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_COLESTEROL_VLDL_DESEABLE).v_Value1;

                    var PL_TRIGLICERIDOS = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_TRIGLICERIDOS) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_TRIGLICERIDOS).v_Value1;
                    var PL_TRIGLICERIDOS_unidad = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_TRIGLICERIDOS) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_TRIGLICERIDOS).v_MeasurementUnitName;
                    var PL_TRIGLICERIDOS_DESEABLE = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_TRIGLICERIDOS_DESEABLE) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_TRIGLICERIDOS_DESEABLE).v_Value1;
                    
                    var PL_observaciones = perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_observaciones) == null ? "-" : perfil_lipidico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PL_observaciones).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PERFIL LIPIDICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Colesterol Total", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_TOTAL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_colesterol_total_valor_deseado, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_TOTAL_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Colesterol HDL", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_HDL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_HDL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_HDL_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Relación Col. Total/Col. HDL", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_REL_COLESTEROL_HDL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_REL_COLESTEROL_HDL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_REL_COLESTEROL_HDL_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Colesterol LDL", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_LDL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_LDL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_LDL_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Colesterol VLDL", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_VLDL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_VLDL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_COLESTEROL_VLDL_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Trigliceridos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_TRIGLICERIDOS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_TRIGLICERIDOS_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_TRIGLICERIDOS_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    


                        new PdfPCell(new Phrase("   Observaciones", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PL_observaciones, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (insulina_basal != null)
                {

                    var INSULINA_BASAL_VALOR = insulina_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_BASAL_VALOR) == null ? "-" : insulina_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_BASAL_VALOR).v_Value1;
                    var INSULINA_BASAL_VALOR_UNIDAD = insulina_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_BASAL_VALOR) == null ? "-" : insulina_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_BASAL_VALOR).v_MeasurementUnitName;
                    var INSULINA_BASAL_DESEABLE = insulina_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_BASAL_DESEABLE) == null ? "-" : insulina_basal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_BASAL_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("INSULINA BASAL", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("  INSULINA BASAL \n  Metodo: ECLIA", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_BASAL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_BASAL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_BASAL_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (insulina_postpandrial != null)
                {

                    var INSULINA_POSTPANDRIAL_VALOR = insulina_postpandrial.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_VALOR) == null ? "-" : insulina_postpandrial.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_VALOR).v_Value1;
                    var INSULINA_POSTPANDRIAL_VALOR_UNIDAD = insulina_postpandrial.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_VALOR) == null ? "-" : insulina_postpandrial.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_VALOR).v_MeasurementUnitName;
                    var INSULINA_POSTPANDRIAL_DESEABLE = insulina_postpandrial.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_DESEABLE) == null ? "-" : insulina_postpandrial.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.INSULINA_POSTPANDRIAL_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("INSULINA POST PANDRIAL", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("  INSULINA POST PANDRIAL \n  Metodo: A-E-ECLIA", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_POSTPANDRIAL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_POSTPANDRIAL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_POSTPANDRIAL_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (lipasa != null)
                {

                    var LIPASA_VALOR = lipasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.LIPASA_VALOR) == null ? "-" : lipasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.LIPASA_VALOR).v_Value1;
                    var LIPASA_VALOR_UNIDAD = lipasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.LIPASA_VALOR) == null ? "-" : lipasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.LIPASA_VALOR).v_MeasurementUnitName;
                    var INSULINA_POSTPANDRIAL_DESEABLE = lipasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.LIPASA_DESEABLE) == null ? "-" : lipasa.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.LIPASA_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("LIPASA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("  Lipasa serica ", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(LIPASA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(INSULINA_POSTPANDRIAL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(LIPASA_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (perfil_hepatico != null)
                {
                    var PH_FOSFATASA_ALCALINA_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_FOSFATASA_ALCALINA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_FOSFATASA_ALCALINA_VALOR).v_Value1;
                    var PH_FOSFATASA_ALCALINA_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_FOSFATASA_ALCALINA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_FOSFATASA_ALCALINA_VALOR).v_MeasurementUnitName;
                    var PH_FOSFATASA_ALCALINA_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_FOSFATASA_ALCALINA_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_FOSFATASA_ALCALINA_DESEABLE).v_Value1;

                    var PH_TGO_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGO_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGO_VALOR).v_Value1;
                    var PH_TGO_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGO_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGO_VALOR).v_MeasurementUnitName;
                    var PH_TGO_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGO_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGO_DESEABLE).v_Value1;

                    var PH_TGP_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGP_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGP_VALOR).v_Value1;
                    var PH_TGP_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGP_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGP_VALOR).v_MeasurementUnitName;
                    var PH_TGP_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGP_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_TGP_DESEABLE).v_Value1;

                    var PH_BILIRRUBINA_TOTAL_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_TOTAL_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_TOTAL_VALOR).v_Value1;
                    var PH_BILIRRUBINA_TOTAL_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_TOTAL_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_TOTAL_VALOR).v_MeasurementUnitName;
                    var PH_BILIRRUBINA_TOTAL_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_TOTAL_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_TOTAL_DESEABLE).v_Value1;

                    var PH_BILIRRUBINA_DIRECTA_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_DIRECTA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_DIRECTA_VALOR).v_Value1;
                    var PH_BILIRRUBINA_DIRECTA_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_DIRECTA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_DIRECTA_VALOR).v_MeasurementUnitName;
                    var PH_BILIRRUBINA_DIRECTA_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_DIRECTA_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_DIRECTA_DESEABLE).v_Value1;

                    var PH_BILIRRUBINA_INDIRECTA_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_INDIRECTA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_INDIRECTA_VALOR).v_Value1;
                    var PH_BILIRRUBINA_INDIRECTA_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_INDIRECTA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_INDIRECTA_VALOR).v_MeasurementUnitName;
                    var PH_BILIRRUBINA_INDIRECTA_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_INDIRECTA_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_BILIRRUBINA_INDIRECTA_DESEABLE).v_Value1;
                    //

                    var PH_PROTEINAS_TOTALES_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_PROTEINAS_TOTALES_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_PROTEINAS_TOTALES_VALOR).v_Value1;
                    var PH_PROTEINAS_TOTALES_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_PROTEINAS_TOTALES_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_PROTEINAS_TOTALES_VALOR).v_MeasurementUnitName;
                    var PH_PROTEINAS_TOTALES_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_PROTEINAS_TOTALES_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_PROTEINAS_TOTALES_DESEABLE).v_Value1;

                    var PH_ALBUMINA_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_ALBUMINA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_ALBUMINA_VALOR).v_Value1;
                    var PH_ALBUMINA_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_ALBUMINA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_ALBUMINA_VALOR).v_MeasurementUnitName;
                    var PH_ALBUMINA_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_ALBUMINA_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_ALBUMINA_DESEABLE).v_Value1;

                    var PH_GLOBULINA_VALOR = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_GLOBULINA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_GLOBULINA_VALOR).v_Value1;
                    var PH_GLOBULINA_VALOR_unidad = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_GLOBULINA_VALOR) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_GLOBULINA_VALOR).v_MeasurementUnitName;
                    var PH_GLOBULINA_DESEABLE = perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_GLOBULINA_DESEABLE) == null ? "-" : perfil_hepatico.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PH_GLOBULINA_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PERFIL HEPATICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Fosfatasa alcalina", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_FOSFATASA_ALCALINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_FOSFATASA_ALCALINA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_FOSFATASA_ALCALINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase("   Transaminasa oxalacetica TGO/ AST", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_TGO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_TGO_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_TGO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Transaminasa piruvica TGP/ ALT", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_TGP_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_TGP_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_TGP_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase(" Bilirrubina total y fraccionada:", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Bilirrubina Total", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_TOTAL_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_TOTAL_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_TOTAL_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase("   Bilirrubina Directa", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_DIRECTA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_DIRECTA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_DIRECTA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Bilirrubina Indirecta", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_INDIRECTA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_INDIRECTA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_BILIRRUBINA_INDIRECTA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase(" Proteina total y fraccionada:", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Bilirrubina Total", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_PROTEINAS_TOTALES_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_PROTEINAS_TOTALES_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_PROTEINAS_TOTALES_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase("   Bilirrubina Directa", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_ALBUMINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_ALBUMINA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_ALBUMINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Bilirrubina Indirecta", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_GLOBULINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_GLOBULINA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PH_GLOBULINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        

                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (perfil_renal != null)
                {
                    var PR_UREA = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_UREA) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_UREA).v_Value1;
                    var PR_UREA_unidad = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_UREA) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_UREA).v_MeasurementUnitName;
                    var PR_UREA_DESEABLE = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_UREA_DESEABLE) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_UREA_DESEABLE).v_Value1;
                    
                    var PR_CREATININA = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_CREATININA) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_CREATININA).v_Value1;
                    var PR_CREATININA_unidad = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_CREATININA) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_CREATININA).v_MeasurementUnitName;
                    var PR_CREATININA_DESEABLE = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_CREATININA_DESEABLE) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_CREATININA_DESEABLE).v_Value1;


                    var PR_observaciones = perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_observaciones) == null ? "-" : perfil_renal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PR_observaciones).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PERFIL RENAL ", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Urea", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_UREA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_UREA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_UREA_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Creatinina", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_CREATININA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_CREATININA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_CREATININA_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Observaciones", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PR_observaciones, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }
            }
            #endregion



            #region HEMATOLOGIA
            ServiceComponentList hemoglobina_hematocrito = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.HEMOGLOBINA_HEMATOCRITO_ID);
            ServiceComponentList hemograma = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.HEMOGRAMAA_ID);

            ServiceComponentList grupo_factor = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.GRUPO_SANGUINEO_Y_FACTOR_RH_ID);
            ServiceComponentList prueba_Cruzada = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PRUEBA_CRUZADA_ID);

            ServiceComponentList perfil_neonatal = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PERFIL_NEONATAL_ID);
            ServiceComponentList tiempo_coagulacion_sangria = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.TIEMPO_DE_COAGULACION_Y_YSANGRIA_ID);
            ServiceComponentList recuento_plaquetas = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS_ID);

            ServiceComponentList tiempo_protombina = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_ID);
            ServiceComponentList tiempo_tromboplastina = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_ID);
            ServiceComponentList fibrinogeno = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.FIBRINOGENO_ID);



            if (hemograma != null || hemoglobina_hematocrito != null || grupo_factor != null || prueba_Cruzada != null
                || perfil_neonatal != null || tiempo_coagulacion_sangria != null || recuento_plaquetas != null || tiempo_protombina != null
                || tiempo_tromboplastina != null || fibrinogeno != null)
            {
                cells = new List<PdfPCell>()
                {
                    new PdfPCell(new Phrase("INMUNOHEMATOLOGIA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                    
                    new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 5f, Border = PdfPCell.NO_BORDER},    

                };

                columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                document.Add(table);

                if (grupo_factor != null)
                {
                    var GRUPO_SANGUINEO_VALOR = grupo_factor.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GRUPO_SANGUINEO_VALOR) == null ? "- - -" : grupo_factor.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GRUPO_SANGUINEO_VALOR).v_Value1Name;
                    var FACTOR_RH_VALOR = grupo_factor.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FACTOR_RH_VALOR) == null ? "- - -" : grupo_factor.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FACTOR_RH_VALOR).v_Value1Name;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("GRUPO SANGUINEO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Grupo sanguineo:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GRUPO_SANGUINEO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase("   Factor Rh:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(FACTOR_RH_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    


                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (prueba_Cruzada != null)
                {
                    var GRUPO_SANGUINEO_VALOR_PC = prueba_Cruzada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GRUPO_SANGUINEO_VALOR_PC) == null ? "-" : prueba_Cruzada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GRUPO_SANGUINEO_VALOR_PC).v_Value1Name;
                    var FACTOR_RH_VALOR_PC = prueba_Cruzada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FACTOR_RH_VALOR_PC) == null ? "-" : prueba_Cruzada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FACTOR_RH_VALOR_PC).v_Value1Name;
                    var COMPATIBILIDAD_VALOR_PC = prueba_Cruzada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COMPATIBILIDAD_VALOR_PC) == null ? "-" : prueba_Cruzada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.COMPATIBILIDAD_VALOR_PC).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("Prueba de compatibilidad", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Grupo sanguineo:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GRUPO_SANGUINEO_VALOR_PC, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase("   Factor Rh:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(FACTOR_RH_VALOR_PC, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Compatible con unidad:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(COMPATIBILIDAD_VALOR_PC, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                      
                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }



                if (hemoglobina_hematocrito != null)
                {
                    var HH_HEMOGLOBINA_VALOR = hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMOGLOBINA_VALOR) == null ? "- - -" : hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMOGLOBINA_VALOR).v_Value1;
                    var HH_HEMOGLOBINA_VALOR_unidad = hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMOGLOBINA_VALOR) == null ? "- - -" : hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMOGLOBINA_VALOR).v_MeasurementUnitName;
                    var HH_HEMOGLOBINA_VALOR_DESEABLE = hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMOGLOBINA_VALOR_DESEABLE) == null ? "- - -" : hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMOGLOBINA_VALOR_DESEABLE).v_Value1;

                    var HH_HEMATOCRITO_VALOR = hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMATOCRITO_VALOR) == null ? "- - -" : hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMATOCRITO_VALOR).v_Value1;
                    var HH_HEMATOCRITO_VALOR_unidad = hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMATOCRITO_VALOR) == null ? "- - -" : hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMATOCRITO_VALOR).v_MeasurementUnitName;
                    var HH_HEMATOCRITO_VALOR_DESEABLE = hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMATOCRITO_VALOR_DESEABLE) == null ? "- - -" : hemoglobina_hematocrito.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HH_HEMATOCRITO_VALOR_DESEABLE).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("HEMATOCRITO - HEMOGLOBINA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   HEMOGLOBINA", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HH_HEMOGLOBINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HH_HEMOGLOBINA_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HH_HEMOGLOBINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   HEMATOCRITO", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HH_HEMATOCRITO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HH_HEMATOCRITO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HH_HEMATOCRITO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (perfil_neonatal != null)
                {
                    var GLUCOSA_PN = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_PN).v_Value1;
                    var GLUCOSA_PN_UNIDAD = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_PN).v_MeasurementUnitName;
                    var GLUCOSA_VALOR_PN = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GLUCOSA_VALOR_PN).v_Value1;

                    var HEMOGLOBINA_PN = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_PN).v_Value1;
                    var HEMOGLOBINA_PN_UNIDAD = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_PN).v_MeasurementUnitName;
                    var HEMOGLOBINA_VALOR_PN = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_VALOR_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_VALOR_PN).v_Value1;

                
                    var GRUPO_S_PN = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GRUPO_S_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.GRUPO_S_PN).v_Value1Name;
                    var FACTOR_RH_PN = perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FACTOR_RH_PN) == null ? "- - -" : perfil_neonatal.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FACTOR_RH_PN).v_Value1Name;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PERFIL NEO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   HEMOGLOBINA:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEMOGLOBINA_PN, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEMOGLOBINA_VALOR_PN, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEMOGLOBINA_PN_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   GLUCOSA:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_PN, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_VALOR_PN, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GLUCOSA_PN_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    


                        new PdfPCell(new Phrase("   Grupo sanguineo:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(GRUPO_S_PN, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase("   Factor Rh:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(FACTOR_RH_PN, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (hemograma != null)
                {
                    var HA_LEUCOCITOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LEUCOCITOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LEUCOCITOS_VALOR).v_Value1;
                    var HA_LEUCOCITOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LEUCOCITOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LEUCOCITOS_VALOR).v_MeasurementUnitName;
                    var HA_LEUCOCITOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LEUCOCITOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LEUCOCITOS_VALOR_DESEABLE).v_Value1;
                    
                    //
                    var HA_LINFOCITOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR).v_Value1;
                    var HA_LINFOCITOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR).v_MeasurementUnitName;
                    var HA_LINFOCITOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_DESEABLE).v_Value1;

                    var HA_MONOCITOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR).v_Value1;
                    var HA_MONOCITOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR).v_MeasurementUnitName;
                    var HA_MONOCITOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_DESEABLE).v_Value1;

                    var HA_ABASTONADOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR).v_Value1;
                    var HA_ABASTONADOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR).v_MeasurementUnitName;
                    var HA_ABASTONADOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_DESEABLE).v_Value1;

                    var HA_SEGMENTADOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR).v_Value1;
                    var HA_SEGMENTADOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR).v_MeasurementUnitName;
                    var HA_SEGMENTADOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_DESEABLE).v_Value1;

                    var HA_EOSINOFILOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR).v_Value1;
                    var HA_EOSINOFILOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR).v_MeasurementUnitName;
                    var HA_EOSINOFILOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_DESEABLE).v_Value1;

                    var HA_BASOFILOS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR).v_Value1;
                    var HA_BASOFILOS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR).v_MeasurementUnitName;
                    var HA_BASOFILOS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_DESEABLE).v_Value1;

                    //
                    var HA_LINFOCITOS_VALOR_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_3).v_Value1;
                    var HA_LINFOCITOS_VALOR_unidad_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_3).v_MeasurementUnitName;
                    var HA_LINFOCITOS_VALOR_DESEABLE_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_DESEABLE_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_LINFOCITOS_VALOR_DESEABLE_3).v_Value1;

                    var HA_MONOCITOS_VALOR_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_3).v_Value1;
                    var HA_MONOCITOS_VALOR_unidad_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_3).v_MeasurementUnitName;
                    var HA_MONOCITOS_VALOR_DESEABLE_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_DESEABLE_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_MONOCITOS_VALOR_DESEABLE_3).v_Value1;

                    var HA_ABASTONADOS_VALOR_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_3).v_Value1;
                    var HA_ABASTONADOS_VALOR_unidad_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_3).v_MeasurementUnitName;
                    var HA_ABASTONADOS_VALOR_DESEABLE_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_DESEABLE_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ABASTONADOS_VALOR_DESEABLE_3).v_Value1;

                    var HA_SEGMENTADOS_VALOR_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_3).v_Value1;
                    var HA_SEGMENTADOS_VALOR_unidad_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_3).v_MeasurementUnitName;
                    var HA_SEGMENTADOS_VALOR_DESEABLE_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_DESEABLE_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_SEGMENTADOS_VALOR_DESEABLE_3).v_Value1;

                    var HA_EOSINOFILOS_VALOR_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_3).v_Value1;
                    var HA_EOSINOFILOS_VALOR_unidad_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_3).v_MeasurementUnitName;
                    var HA_EOSINOFILOS_VALOR_DESEABLE_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_DESEABLE_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_EOSINOFILOS_VALOR_DESEABLE_3).v_Value1;

                    var HA_BASOFILOS_VALOR_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_3).v_Value1;
                    var HA_BASOFILOS_VALOR_unidad_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_3).v_MeasurementUnitName;
                    var HA_BASOFILOS_VALOR_DESEABLE_3 = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_DESEABLE_3) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_BASOFILOS_VALOR_DESEABLE_3).v_Value1;


                    //
                    var HA_HEMATIES_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATIES_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATIES_VALOR).v_Value1;
                    var HA_HEMATIES_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATIES_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATIES_VALOR).v_MeasurementUnitName;
                    var HA_HEMATIES_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATIES_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATIES_VALOR_DESEABLE).v_Value1;

                    var HA_HEMOGLOBINA_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMOGLOBINA_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMOGLOBINA_VALOR).v_Value1;
                    var HA_HEMOGLOBINA_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMOGLOBINA_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMOGLOBINA_VALOR).v_MeasurementUnitName;
                    var HA_HEMOGLOBINA_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMOGLOBINA_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMOGLOBINA_VALOR_DESEABLE).v_Value1;

                    var HA_HEMATOCRITO_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATOCRITO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATOCRITO_VALOR).v_Value1;
                    var HA_HEMATOCRITO_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATOCRITO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATOCRITO_VALOR).v_MeasurementUnitName;
                    var HA_HEMATOCRITO_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATOCRITO_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HEMATOCRITO_VALOR_DESEABLE).v_Value1;


                    //
                    var HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR).v_Value1;
                    var HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR).v_MeasurementUnitName;
                    var HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_DESEABLE).v_Value1;

                    var HA_HB_CORPUSCULAR_MEDIO_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HB_CORPUSCULAR_MEDIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HB_CORPUSCULAR_MEDIO_VALOR).v_Value1;
                    var HA_HB_CORPUSCULAR_MEDIO_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HB_CORPUSCULAR_MEDIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HB_CORPUSCULAR_MEDIO_VALOR).v_MeasurementUnitName;
                    var HA_HB_CORPUSCULAR_MEDIO_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HB_CORPUSCULAR_MEDIO_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_HB_CORPUSCULAR_MEDIO_VALOR_DESEABLE).v_Value1;

                    var HA_CONCENTRACION_HB_CORPUSCULAR_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_CONCENTRACION_HB_CORPUSCULAR_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_CONCENTRACION_HB_CORPUSCULAR_VALOR).v_Value1;
                    var HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_CONCENTRACION_HB_CORPUSCULAR_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_CONCENTRACION_HB_CORPUSCULAR_VALOR).v_MeasurementUnitName;
                    var HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_DESEABLE).v_Value1;

                    var HA_RDW_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RDW_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RDW_VALOR).v_Value1;
                    var HA_RDW_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RDW_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RDW_VALOR).v_MeasurementUnitName;
                    var HA_RDW_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RDW_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RDW_VALOR_DESEABLE).v_Value1;


                    //

                    var HA_RECUENTO_PLAQUETAS_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RECUENTO_PLAQUETAS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RECUENTO_PLAQUETAS_VALOR).v_Value1;
                    var HA_RECUENTO_PLAQUETAS_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RECUENTO_PLAQUETAS_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RECUENTO_PLAQUETAS_VALOR).v_MeasurementUnitName;
                    var HA_RECUENTO_PLAQUETAS_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RECUENTO_PLAQUETAS_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_RECUENTO_PLAQUETAS_VALOR_DESEABLE).v_Value1;

                    var HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR).v_Value1;
                    var HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR).v_MeasurementUnitName;
                    var HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_DESEABLE).v_Value1;

                    var HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR).v_Value1;
                    var HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR).v_MeasurementUnitName;
                    var HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_DESEABLE).v_Value1;

                    var HA_PLAQUETOCRITO_VALOR = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_PLAQUETOCRITO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_PLAQUETOCRITO_VALOR).v_Value1;
                    var HA_PLAQUETOCRITO_VALOR_unidad = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_PLAQUETOCRITO_VALOR) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_PLAQUETOCRITO_VALOR).v_MeasurementUnitName;
                    var HA_PLAQUETOCRITO_VALOR_DESEABLE = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_PLAQUETOCRITO_VALOR_DESEABLE) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_PLAQUETOCRITO_VALOR_DESEABLE).v_Value1;

                    var HA_OTROS = hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_OTROS) == null ? "-" : hemograma.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HA_OTROS).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                    
                        new PdfPCell(new Phrase("HEMOGRAMA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   Leucocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LEUCOCITOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LEUCOCITOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LEUCOCITOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        new PdfPCell(new Phrase(" Diferencial procentual:", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Linfocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LINFOCITOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LINFOCITOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LINFOCITOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Monocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_MONOCITOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_MONOCITOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_MONOCITOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Abastonados", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ABASTONADOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ABASTONADOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ABASTONADOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Segmentados", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_SEGMENTADOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_SEGMENTADOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_SEGMENTADOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Eosinófilos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_EOSINOFILOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_EOSINOFILOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_EOSINOFILOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Basófilos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_BASOFILOS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_BASOFILOS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_BASOFILOS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" Diferencial absoluto:", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Linfocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LINFOCITOS_VALOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LINFOCITOS_VALOR_DESEABLE_3, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_LINFOCITOS_VALOR_unidad_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Monocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_MONOCITOS_VALOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_MONOCITOS_VALOR_DESEABLE_3, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_MONOCITOS_VALOR_unidad_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Abastonados", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ABASTONADOS_VALOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ABASTONADOS_VALOR_DESEABLE_3, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ABASTONADOS_VALOR_unidad_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Segmentados", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_SEGMENTADOS_VALOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_SEGMENTADOS_VALOR_DESEABLE_3, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_SEGMENTADOS_VALOR_unidad_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Eosinófilos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_EOSINOFILOS_VALOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_EOSINOFILOS_VALOR_DESEABLE_3, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_EOSINOFILOS_VALOR_unidad_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Basófilos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_BASOFILOS_VALOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_BASOFILOS_VALOR_DESEABLE_3, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_BASOFILOS_VALOR_unidad_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" Serie Roja:", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   HEMATIES", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMATIES_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMATIES_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMATIES_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   HEMOGLOBINA", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMOGLOBINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMOGLOBINA_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMOGLOBINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   HEMATOCRITO", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMATOCRITO_VALOR, fontColumnValueBold)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMATOCRITO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HEMATOCRITO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" Constantes corpusculares:", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   VOLUMEN CORPUSCULAR MEDIO (VCM)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_VOLUMEN_CORPUSCULAR_MEDIO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   HEMOGLOBINA CORPUSCULAR MEDIO (HCM)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HB_CORPUSCULAR_MEDIO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HB_CORPUSCULAR_MEDIO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_HB_CORPUSCULAR_MEDIO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   CONCENTRACION DE LA HEMOGLOBINA CORPUSCULAR (CHCM)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_CONCENTRACION_HB_CORPUSCULAR_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_CONCENTRACION_HB_CORPUSCULAR_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   R.D.W (indice de anisocitosis)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_RDW_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_RDW_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_RDW_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("-", fontColumnValue)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 8f, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   PLAQUETAS RECUENTO", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_RECUENTO_PLAQUETAS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_RECUENTO_PLAQUETAS_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_RECUENTO_PLAQUETAS_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   VOLUMEN PLAQUETARIO MEDIO", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_VOLUMEN_PLAQUETARIO_MEDIO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   ANCHO DE DISTRIBUCIÓN PLAQUETARIA", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_ANCHO_DISTRIBUCION_PLAQUETARIO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   PLAQUETOCRITO", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_PLAQUETOCRITO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_PLAQUETOCRITO_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_PLAQUETOCRITO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                      

                        new PdfPCell(new Phrase("OTROS:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HA_OTROS, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (tiempo_coagulacion_sangria != null)
                {
                    var tiempo_sangria_valor = tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__YSANGRIA_VALOR) == null ? "-" : tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__YSANGRIA_VALOR).v_Value1;
                    var tiempo_sangria_valor_unidad = tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__YSANGRIA_VALOR) == null ? "-" : tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__YSANGRIA_VALOR).v_MeasurementUnitName;
                    var tiempo_sangria_valor_deseable = tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__YSANGRIA_VALOR_DESEABLE) == null ? "-" : tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__YSANGRIA_VALOR_DESEABLE).v_Value1;

                    var tiempo_coagulacion_valor = tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__COAGULACION_VALOR) == null ? "-" : tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__COAGULACION_VALOR).v_Value1;
                    var tiempo_coagulacion_valor_unidad = tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__COAGULACION_VALOR) == null ? "-" : tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__COAGULACION_VALOR).v_MeasurementUnitName;
                    var tiempo_coagulacion_valor_deseable = tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__COAGULACION_VALOR_DESEABLE) == null ? "-" : tiempo_coagulacion_sangria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE__COAGULACION_VALOR_DESEABLE).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("TIEMPO DE SANGRIA, TIEMPO DE COAGULACION", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Tiempo de sangria:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(tiempo_sangria_valor, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(tiempo_sangria_valor_deseable, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(tiempo_sangria_valor_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Tiempo de coagulacion :", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(tiempo_coagulacion_valor, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(tiempo_coagulacion_valor_deseable, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(tiempo_coagulacion_valor_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (tiempo_protombina != null)
                {
                    var TIEMPO_DE_PROTOMBINA_VALOR = tiempo_protombina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_VALOR) == null ? "-" : tiempo_protombina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_VALOR).v_Value1;
                    var TIEMPO_DE_PROTOMBINA_VALOR_unidad = tiempo_protombina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_VALOR) == null ? "-" : tiempo_protombina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_VALOR).v_MeasurementUnitName;
                    var TIEMPO_DE_PROTOMBINA_DESEADO = tiempo_protombina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_DESEADO) == null ? "-" : tiempo_protombina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_PROTOMBINA_DESEADO).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("Tiempo de protrombina\nINR", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Tiempo de protrombina\n   INR:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TIEMPO_DE_PROTOMBINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TIEMPO_DE_PROTOMBINA_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TIEMPO_DE_PROTOMBINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (tiempo_tromboplastina != null)
                {
                    var TIEMPO_DE_TROMBOPLASTINA_VALOR = tiempo_tromboplastina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_VALOR) == null ? "-" : tiempo_tromboplastina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_VALOR).v_Value1;
                    var TIEMPO_DE_TROMBOPLASTINA_VALOR_unidad = tiempo_tromboplastina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_VALOR) == null ? "-" : tiempo_tromboplastina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_VALOR).v_MeasurementUnitName;
                    var TIEMPO_DE_TROMBOPLASTINA_DESEADO = tiempo_tromboplastina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_DESEADO) == null ? "-" : tiempo_tromboplastina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TIEMPO_DE_TROMBOPLASTINA_DESEADO).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("Tiempo parcial de tromboplastina activada", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Tiempo parcial de tromboplastina activada:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TIEMPO_DE_TROMBOPLASTINA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TIEMPO_DE_TROMBOPLASTINA_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TIEMPO_DE_TROMBOPLASTINA_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (fibrinogeno != null)
                {
                    var FIBRINOGENO_VALOR = fibrinogeno.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FIBRINOGENO_VALOR) == null ? "-" : fibrinogeno.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FIBRINOGENO_VALOR).v_Value1;
                    var FIBRINOGENO_VALOR_unidad = fibrinogeno.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FIBRINOGENO_VALOR) == null ? "-" : fibrinogeno.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FIBRINOGENO_VALOR).v_MeasurementUnitName;
                    var FIBRINOGENO_DESEADO = fibrinogeno.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FIBRINOGENO_DESEADO) == null ? "-" : fibrinogeno.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.FIBRINOGENO_DESEADO).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("Tiempo parcial de tromboplastina activada", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Tiempo parcial de tromboplastina activada:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(FIBRINOGENO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(FIBRINOGENO_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(FIBRINOGENO_VALOR_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (recuento_plaquetas != null)
                {
                    var RECUENTO_DE_PLAQUETAS = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS).v_Value1;
                    var RECUENTO_DE_PLAQUETAS_unidad = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS).v_MeasurementUnitName;
                    var RECUENTO_DE_PLAQUETAS_VALOR = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS_VALOR) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RECUENTO_DE_PLAQUETAS_VALOR).v_Value1;

                    var VOLUMEN_PLAQUETARIO = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VOLUMEN_PLAQUETARIO) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VOLUMEN_PLAQUETARIO).v_Value1;
                    var VOLUMEN_PLAQUETARIO_unidad = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VOLUMEN_PLAQUETARIO) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VOLUMEN_PLAQUETARIO).v_MeasurementUnitName;
                    var VOLUMEN_PLAQUETARIO_VALOR = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VOLUMEN_PLAQUETARIO_VALOR) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VOLUMEN_PLAQUETARIO_VALOR).v_Value1;

                    var ANCHO_DIST_PLAQUETARIA = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ANCHO_DIST_PLAQUETARIA) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ANCHO_DIST_PLAQUETARIA).v_Value1;
                    var ANCHO_DIST_PLAQUETARIA_unidad = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ANCHO_DIST_PLAQUETARIA) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ANCHO_DIST_PLAQUETARIA).v_MeasurementUnitName;
                    var ANCHO_DIST_PLAQUETARIA_VALOR = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ANCHO_DIST_PLAQUETARIA_VALOR) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ANCHO_DIST_PLAQUETARIA_VALOR).v_Value1;

                    var PLAQUETOCRITO = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PLAQUETOCRITO) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PLAQUETOCRITO).v_Value1;
                    var PLAQUETOCRITO_unidad = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PLAQUETOCRITO) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PLAQUETOCRITO).v_MeasurementUnitName;
                    var PLAQUETOCRITO_VALOR = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PLAQUETOCRITO_VALOR) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PLAQUETOCRITO_VALOR).v_Value1;

                    var DESCR_REC_PLAQ = recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.DESCR_REC_PLAQ) == null ? "-" : recuento_plaquetas.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.DESCR_REC_PLAQ).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("RECUENTO DE PLAQUETAS", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   PLAQUETAS RECUENTO:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RECUENTO_DE_PLAQUETAS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RECUENTO_DE_PLAQUETAS_VALOR, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RECUENTO_DE_PLAQUETAS_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   VOLUMEN PLAQUETARIO MEDIO :", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(VOLUMEN_PLAQUETARIO, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ANCHO_DIST_PLAQUETARIA_VALOR, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ANCHO_DIST_PLAQUETARIA_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   PLAQUETAS RECUENTO:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ANCHO_DIST_PLAQUETARIA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ANCHO_DIST_PLAQUETARIA_VALOR, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ANCHO_DIST_PLAQUETARIA_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   VOLUMEN PLAQUETARIO MEDIO :", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PLAQUETOCRITO, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PLAQUETOCRITO_VALOR, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PLAQUETOCRITO_unidad, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Observacion:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(DESCR_REC_PLAQ, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }
            }


            #endregion

            #region UROANALISIS


            ServiceComponentList examen_completo_orina = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.EXAMEN_ORINA_COMPLETO_ID);

            if (examen_completo_orina != null)
            {

                cells = new List<PdfPCell>()
                {
                    new PdfPCell(new Phrase("URIANALISIS", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                    
                    new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 5f, Border = PdfPCell.NO_BORDER},    

                };

                columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                document.Add(table);

                if (examen_completo_orina != null)
                {
                    var ECO_COLOR_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_COLOR_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_COLOR_CL).v_Value1Name;
                    var ECO_ASPECTO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_ASPECTO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_ASPECTO_CL).v_Value1Name;

                    var ECO_DENSIDAD_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_DENSIDAD_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_DENSIDAD_CL).v_Value1;
                    var ECO_DENSIDAD_DESEABLE_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_DENSIDAD_DESEABLE_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_DENSIDAD_DESEABLE_CL).v_Value1;

                    var ECO_REACCION_PH_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_REACCION_PH_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_REACCION_PH_CL).v_Value1;


                    var ECO_PROTEINAS_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_PROTEINAS_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_PROTEINAS_CL).v_Value1Name;
                    var ECO_GLUCOSA_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_GLUCOSA_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_GLUCOSA_CL).v_Value1Name;
                    var ECO_CETONAS_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CETONAS_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CETONAS_CL).v_Value1Name;
                    var ECO_BILIRRUBINAS_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_BILIRRUBINAS_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_BILIRRUBINAS_CL).v_Value1;
                    var ECO_UROBILINOGENO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_UROBILINOGENO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_UROBILINOGENO_CL).v_Value1Name;
                    var ECO_SANGRE_ORINA_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_SANGRE_ORINA_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_SANGRE_ORINA_CL).v_Value1Name;
                    var ECO_NITRITOS_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_NITRITOS_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_NITRITOS_CL).v_Value1Name;
                    var ECO_LEUCOCITOS_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_LEUCOCITOS_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_LEUCOCITOS_CL).v_Value1;
                    var ECO_ACIDO_ASCORBICO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_ACIDO_ASCORBICO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_ACIDO_ASCORBICO_CL).v_Value1Name;

                    var ECO_CELULAS_EPITELIALES_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CELULAS_EPITELIALES_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CELULAS_EPITELIALES_CL).v_Value1;
                    var ECO_CELULAS_EPITELIALES_DESEADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CELULAS_EPITELIALES_DESEADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CELULAS_EPITELIALES_DESEADO_CL).v_Value1;
                    var ECO_LEUCOCITOS_2_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_LEUCOCITOS_2_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_LEUCOCITOS_2_CL).v_Value1;
                    var ECO_LEUCOCITOS_DESEADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_LEUCOCITOS_DESEADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_LEUCOCITOS_DESEADO_CL).v_Value1;
                    var ECO_HEMATIES_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_HEMATIES_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_HEMATIES_CL).v_Value1;
                    var ECO_HEMATIES_DESEADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_HEMATIES_DESEADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_HEMATIES_DESEADO_CL).v_Value1;
                    var ECO_GERMENES_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_GERMENES_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_GERMENES_CL).v_Value1;
                    var ECO_GERMENES_DESEADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_GERMENES_DESEADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_GERMENES_DESEADO_CL).v_Value1;
                    var ECO_CILINDROS_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CILINDROS_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CILINDROS_CL).v_Value1;
                    var ECO_CILINDROS_DESEADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CILINDROS_DESEADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CILINDROS_DESEADO_CL).v_Value1;
                    var ECO_CRISTALES_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CRISTALES_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CRISTALES_CL).v_Value1;
                    var ECO_CRISTALES_DESEADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CRISTALES_DESEADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_CRISTALES_DESEADO_CL).v_Value1;
                    var ECO_FILAMENTOS_MUCOIDES_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_FILAMENTOS_MUCOIDES_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_FILAMENTOS_MUCOIDES_CL).v_Value1;

                    var ECO_RESULTADO_CL = examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_RESULTADO_CL) == null ? "- - -" : examen_completo_orina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.ECO_RESULTADO_CL).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("EXAMEN COMPLETO DE ORINA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase(" EXAMEN MACROSCOPICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   COLOR", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_COLOR_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Aspecto", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_ASPECTO_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Densidad", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_DENSIDAD_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_DENSIDAD_DESEABLE_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   pH", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_REACCION_PH_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" EXAMEN MACROSCOPICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Proteinas", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_PROTEINAS_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Glucosa", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_GLUCOSA_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Cetonas", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CETONAS_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Bilirrubina", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_BILIRRUBINAS_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Urobilinogeno", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_UROBILINOGENO_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Sangre", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_SANGRE_ORINA_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Nitritos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_NITRITOS_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Leucocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_LEUCOCITOS_2_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Acido ascorbico", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_ACIDO_ASCORBICO_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" EXAMEN MICROSCOPICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Celulas epiteliales", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CELULAS_EPITELIALES_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CELULAS_EPITELIALES_DESEADO_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Leucocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_LEUCOCITOS_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_LEUCOCITOS_DESEADO_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Hematies", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_HEMATIES_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_HEMATIES_DESEADO_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Germenes", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_GERMENES_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_GERMENES_DESEADO_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Cilindros", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CILINDROS_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CILINDROS_DESEADO_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Cristales", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CRISTALES_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_CRISTALES_DESEADO_CL, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Filamento mucoide", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_FILAMENTOS_MUCOIDES_CL, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    



                        new PdfPCell(new Phrase("Otros:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(ECO_RESULTADO_CL, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        

                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }
            }
            #endregion

            #region MICROBIOLOGIA


            ServiceComponentList parasitologico_seriado = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PARASITOLOGICO_SERIADO_LC);
            ServiceComponentList parasitologico_simple = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PARASITOLOGICO_SIMPLE_LC);

            ServiceComponentList thevenon_simple = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.THEVENON_SIMPLE_ID);
            ServiceComponentList reaccion_inflamatoria = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.REACCION_INFLAMATORIA_ID_);
            ServiceComponentList koh = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.KOH_ID);
            ServiceComponentList test_graham = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.TEST_GRAHAM_ID);
            ServiceComponentList coprofuncional = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.COPROFUNCIONAL_ID);


            if (parasitologico_seriado != null || parasitologico_simple  != null || thevenon_simple != null || reaccion_inflamatoria != null
                || koh != null || test_graham != null || coprofuncional != null)
            {

                cells = new List<PdfPCell>()
                {
                    new PdfPCell(new Phrase("MICROBIOLOGIA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                    
                    new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 5f, Border = PdfPCell.NO_BORDER},    

                };

                columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                document.Add(table);

                if (parasitologico_seriado != null)
                {

                    var PSER_COLOR_1 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_COLOR_1) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_COLOR_1).v_Value1Name;
                    var PSER_ASPECTO_1 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_ASPECTO_1) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_ASPECTO_1).v_Value1;
                    var PSER_CONSISTENCIA_1 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_CONSISTENCIA_1) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_CONSISTENCIA_1).v_Value1Name;
                    var PSER_RESULTADO_1 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_RESULTADO_1) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_RESULTADO_1).v_Value1;

                    var PSER_COLOR_2 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_COLOR_2) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_COLOR_2).v_Value1Name;
                    var PSER_ASPECTO_2 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_ASPECTO_2) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_ASPECTO_2).v_Value1;
                    var PSER_CONSISTENCIA_2 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_CONSISTENCIA_2) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_CONSISTENCIA_2).v_Value1Name;
                    var PSER_RESULTADO_2 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_RESULTADO_2) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_RESULTADO_2).v_Value1;

                    var PSER_COLOR_3 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_COLOR_3) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_COLOR_3).v_Value1Name;
                    var PSER_ASPECTO_3 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_ASPECTO_3) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_ASPECTO_3).v_Value1;
                    var PSER_CONSISTENCIA_3 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_CONSISTENCIA_3) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_CONSISTENCIA_3).v_Value1Name;
                    var PSER_RESULTADO_3 = parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_RESULTADO_3) == null ? "-" : parasitologico_seriado.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSER_RESULTADO_3).v_Value1;



                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("PARASITOLOGICO SERIADO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase(" Primera muestra", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Color", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_COLOR_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Aspecto", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_ASPECTO_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Consistencia", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_CONSISTENCIA_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Resultado", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_RESULTADO_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    


                        new PdfPCell(new Phrase(" Segunda muestra", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Color", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_COLOR_2, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Aspecto", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_ASPECTO_2, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Consistencia", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_CONSISTENCIA_2, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Resultado", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_RESULTADO_2, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" Tercera muestra", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Color", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_COLOR_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Aspecto", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_ASPECTO_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Consistencia", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_CONSISTENCIA_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Resultado", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSER_RESULTADO_3, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (parasitologico_simple != null)
                {

                    var PSIM_COLOR_1 = parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_COLOR_1) == null ? "-" : parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_COLOR_1).v_Value1;
                    var PSIM_ASPECTO_1 = parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_ASPECTO_1) == null ? "-" : parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_ASPECTO_1).v_Value1;
                    var PSIM_CONSISTENCIA_1 = parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_CONSISTENCIA_1) == null ? "-" : parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_CONSISTENCIA_1).v_Value1;
                    var PSIM_RESULTADO_1 = parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_RESULTADO_1) == null ? "-" : parasitologico_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSIM_RESULTADO_1).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("PARASITOLOGICO SIMPLE", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   Color", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSIM_COLOR_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Aspecto", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSIM_ASPECTO_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Consistencia", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSIM_CONSISTENCIA_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Resultado", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSIM_RESULTADO_1, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    


                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (thevenon_simple != null)
                {

                    var T_SIMPLE = thevenon_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.T_SIMPLE) == null ? "-" : thevenon_simple.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.T_SIMPLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("SANGRE OCULTA DE HECES", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   Thevenon (Sangre oculta en heces)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(T_SIMPLE, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("    ***Método: Inmunocromatografía", fontColumnValue)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (reaccion_inflamatoria != null)
                {
                    var RIN_COLOR = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_COLOR) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_COLOR).v_Value1;
                    var RIN_CONSISTENCIA = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_CONSISTENCIA) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_CONSISTENCIA).v_Value1;
                    var RIN_MOCO = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_MOCO) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_MOCO).v_Value1;
                    var RIN_SANGRE = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_SANGRE) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_SANGRE).v_Value1;

                    var RIN_HEMATIES = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_HEMATIES) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_HEMATIES).v_Value1;
                    var RIN_HEMATIES_VD = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_HEMATIES_VD) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_HEMATIES_VD).v_Value1;

                    var RIN_LEUCOCITOS = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_LEUCOCITOS) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_LEUCOCITOS).v_Value1;
                    var RIN_LEUCOCITOS_VD = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_LEUCOCITOS_VD) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_LEUCOCITOS_VD).v_Value1;

                    var RIN_MONONUCLEARES = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_MONONUCLEARES) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_MONONUCLEARES).v_Value1;
                    var RIN_POLIMORFONUCLEAR = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_POLIMORFONUCLEAR) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_POLIMORFONUCLEAR).v_Value1;

                    var RIN_OBSERVACIONES = reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_OBSERVACIONES) == null ? "- - -" : reaccion_inflamatoria.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.RIN_OBSERVACIONES).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("REACCION INFLAMATORIA (RIA)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase(" EXAMEN MACROSCOPICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Color", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_COLOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Consistencia", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_CONSISTENCIA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Moco", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_MOCO, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Sangre", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_SANGRE, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_HEMATIES_VD, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" EXAMEN MACROSCOPICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Hematies", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_HEMATIES, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Leucocitos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_LEUCOCITOS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_LEUCOCITOS_VD, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   * Monocucleares", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_MONONUCLEARES, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   * Polimorfonuclear", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_POLIMORFONUCLEAR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Observaciones", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(RIN_OBSERVACIONES, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                       

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (koh != null)
                {

                    var KOH_VALOR = koh.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.KOH_VALOR) == null ? "-" : koh.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.KOH_VALOR).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("EXAMEN DIRECTO DE HONGO (KOH)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   EXAMEN DIRECTO DE HONGO KOH \n  (Hidroxido de potasio 10%)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(KOH_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
            
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (test_graham != null)
                {
                    var TEST_GRAHAM_RESULTADO = test_graham.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TEST_GRAHAM_RESULTADO) == null ? "-" : test_graham.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TEST_GRAHAM_RESULTADO).v_Value1;
                    var TEST_GRAHAM_OBS = test_graham.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TEST_GRAHAM_OBS) == null ? "-" : test_graham.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.TEST_GRAHAM_OBS).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("TEST DE GRAHAM", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   TEST DE GRAHAM \n  (Descarte de oxiuros)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TEST_GRAHAM_RESULTADO, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
            
                        new PdfPCell(new Phrase("   Observaciones:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(TEST_GRAHAM_OBS, fontColumnValue)) { Colspan = 11, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (coprofuncional != null)
                {

                    var CP_COLOR = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_COLOR) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_COLOR).v_Value1;
                    var CP_ASPECTO = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_ASPECTO) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_ASPECTO).v_Value1;
                    var CP_CONSISTENCIA = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_CONSISTENCIA) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_CONSISTENCIA).v_Value1;
                    var CP_PRESENCIA_SANGRE = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PRESENCIA_SANGRE) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PRESENCIA_SANGRE).v_Value1;
                    var CP_PRESENCIA_MOCO = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PRESENCIA_MOCO) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PRESENCIA_MOCO).v_Value1;

                    var CP_PH = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PH) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PH).v_Value1;
                    var CP_PH_DESEABLE = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PH_DESEABLE) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_PH_DESEABLE).v_Value1;
                    var CP_SUSTANCIAS_REDUCTORAS = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SUSTANCIAS_REDUCTORAS) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SUSTANCIAS_REDUCTORAS).v_Value1;
                    var CP_SUSTANCIAS_REDUCTORAS_DESEABLE = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SUSTANCIAS_REDUCTORAS_DESEABLE) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SUSTANCIAS_REDUCTORAS_DESEABLE).v_Value1;
                    var CP_SANGRE_OCULTA = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SANGRE_OCULTA) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SANGRE_OCULTA).v_Value1;
                    var CP_SANGRE_OCULTA_DESEABLE = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SANGRE_OCULTA_DESEABLE) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_SANGRE_OCULTA_DESEABLE).v_Value1;

                    var CP_CELULAR_INFLAMATORIAS = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_CELULAR_INFLAMATORIAS) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_CELULAR_INFLAMATORIAS).v_Value1;
                    var CP_HEMATIES = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_HEMATIES) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_HEMATIES).v_Value1;
                    var CP_GRASAS = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_GRASAS) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_GRASAS).v_Value1;
                    var CP_FIBRAS_MUSCULARES = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_FIBRAS_MUSCULARES) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_FIBRAS_MUSCULARES).v_Value1;
                    var CP_RESTOS_ALIMENTICIOS = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_RESTOS_ALIMENTICIOS) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_RESTOS_ALIMENTICIOS).v_Value1;
                    var CP_BACTERIAS = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_BACTERIAS) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_BACTERIAS).v_Value1;
                    var CP_HONGOS = coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_HONGOS) == null ? "-" : coprofuncional.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.CP_HONGOS).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("COPROFUNCIONAL", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase(" MACROSCOPIA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Color", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_COLOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Aspecto", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_ASPECTO, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Consistencia", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_CONSISTENCIA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Presencia de sangre", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_PRESENCIA_SANGRE, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Presencia de moco", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_PRESENCIA_MOCO, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" MACROSCOPIA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   ph", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_PH, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_PH_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Sustancias Reductoras", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_SUSTANCIAS_REDUCTORAS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_SUSTANCIAS_REDUCTORAS_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Sangre oculta", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_SANGRE_OCULTA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_SANGRE_OCULTA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase(" MICROSCOPICO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Celulas inflamatorias (Leucocitos)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_CELULAR_INFLAMATORIAS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Hematíes", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_HEMATIES, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Grasas (Lípidos)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_GRASAS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Fibras musculares", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_FIBRAS_MUSCULARES, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Restos alimenticios", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_RESTOS_ALIMENTICIOS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Bacterias", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_BACTERIAS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   Hongos", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(CP_HONGOS, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

               

            }
            #endregion
            
            #region INMUNOLOGIA

            ServiceComponentList hemoglobina_glicosilada = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA_ID_LC);

            ServiceComponentList bhcg_cualitativo = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.BHCG_CUALITATIVO_ID);

            ServiceComponentList bhcg_cuantitativo = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_ID);


            ServiceComponentList aglutinaciones_lamina = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_LC);

            ServiceComponentList vdrl = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.VDRL_LC);

            ServiceComponentList PCR_PROTEINA_C_REACTIVA_CUALITATIVA = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUALITATIVA_ID);
            ServiceComponentList PCR_PROTEINA_C_REACTIVA_CUANTITATIVA = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_ID);

            ServiceComponentList psa_total = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PSA_ID);

            ServiceComponentList sars_cov_2 = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.SARS_COV_2_ID);

            ServiceComponentList sifilis = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.SIFILIS_ID);

            ServiceComponentList perfil_tiroideo_total = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PERFIL_TIROIDEO_T_ID);
            ServiceComponentList perfil_tiroideo_libre = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.PERFIL_TIROIDEO_L_ID);
            ServiceComponentList hiv_4_gen = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.HIV_4_GEN_ID);

            ServiceComponentList hepatitisB = serviceComponent.Find(p => p.v_ComponentId == Sigesoft.Common.Constants.HEPATITIS_B_ID);

            if (bhcg_cualitativo != null || bhcg_cuantitativo  != null|| hemoglobina_glicosilada != null || aglutinaciones_lamina != null || vdrl != null
                || PCR_PROTEINA_C_REACTIVA_CUALITATIVA != null || PCR_PROTEINA_C_REACTIVA_CUANTITATIVA  != null|| psa_total != null || sars_cov_2 != null || sifilis != null || perfil_tiroideo_total != null
                || perfil_tiroideo_libre != null || hiv_4_gen != null || hepatitisB != null)
            {

                cells = new List<PdfPCell>()
                {
                    new PdfPCell(new Phrase("INMUNOLOGIA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                    
                    new PdfPCell(new Phrase("", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = 5f, Border = PdfPCell.NO_BORDER},    

                };

                columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                document.Add(table);


                if (vdrl != null)
                {
                    var VDRL_VALOR_LC = vdrl.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VDRL_VALOR_LC) == null ? "- - -" : vdrl.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.VDRL_VALOR_LC).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("VDRL (CUALITATIVO)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   VDRL:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(VDRL_VALOR_LC, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (hiv_4_gen != null)
                {

                    var HIV_4_GEN_VALOR = hiv_4_gen.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIV_4_GEN_VALOR) == null ? "-" : hiv_4_gen.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HIV_4_GEN_VALOR).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("HIV", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   HIV  4TA GENERACION", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HIV_4_GEN_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (bhcg_cualitativo != null)
                {

                    var BHCG_CUALITATIVO_VALOR = bhcg_cualitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUALITATIVO_VALOR) == null ? "-" : bhcg_cualitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUALITATIVO_VALOR).v_Value1Name;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("PRUEBA DE EMBARAZO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   Beta HCG - cualitativo", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(BHCG_CUALITATIVO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (bhcg_cuantitativo != null)
                {

                    var BHCG_CUANTITATIVO_VALOR = bhcg_cuantitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_VALOR) == null ? "-" : bhcg_cuantitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_VALOR).v_Value1;
                    var BHCG_CUANTITATIVO_VALOR_UNIDAD = bhcg_cuantitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_VALOR) == null ? "-" : bhcg_cuantitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_VALOR).v_MeasurementUnitName;
                    var BHCG_CUANTITATIVO_DESEADO = bhcg_cuantitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_DESEADO) == null ? "-" : bhcg_cuantitativo.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.BHCG_CUANTITATIVO_DESEADO).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("PRUEBA DE EMBARAZO", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Beta HCG - cuantitativo", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(BHCG_CUANTITATIVO_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(BHCG_CUANTITATIVO_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(BHCG_CUANTITATIVO_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (hepatitisB != null)
                {

                    var HEPATITIS_B_VALOR = hepatitisB.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEPATITIS_B_VALOR) == null ? "-" : hepatitisB.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEPATITIS_B_VALOR).v_Value1;
                    
                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("HEPATITIS B", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   ANTIGENO AUSTRALIANO -HEPATITIS B", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEPATITIS_B_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (hemoglobina_glicosilada != null)
                {

                    var HEMOGLOBINA_GLICOSILADA_V = hemoglobina_glicosilada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA_V) == null ? "-" : hemoglobina_glicosilada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA_V).v_Value1;
                    var HEMOGLOBINA_GLICOSILADA_V_UNIDAD = hemoglobina_glicosilada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA_V) == null ? "-" : hemoglobina_glicosilada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA_V).v_Value1;
 
                    var HEMOGLOBINA_GLICOSILADA__VALOR_DESEABLE = hemoglobina_glicosilada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA__VALOR_DESEABLE) == null ? "-" : hemoglobina_glicosilada.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.HEMOGLOBINA_GLICOSILADA__VALOR_DESEABLE).v_Value1;


                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("HEMOGLOBINA GLICOSILADA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 


                        new PdfPCell(new Phrase("   HEMOGLOBINA GLICOSILADA (HBA1c)", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEMOGLOBINA_GLICOSILADA_V, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEMOGLOBINA_GLICOSILADA__VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(HEMOGLOBINA_GLICOSILADA_V_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (aglutinaciones_lamina != null)
                {

                    var AGLUTINACIONES_LAMINA_O = aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_O) == null ? "-" : aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_O).v_Value1;
                    var AGLUTINACIONES_LAMINA_H = aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_H) == null ? "-" : aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_H).v_Value1;
                    var AGLUTINACIONES_LAMINA_A = aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_A) == null ? "-" : aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_A).v_Value1;
                    var AGLUTINACIONES_LAMINA_B = aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_B) == null ? "-" : aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_B).v_Value1;

                    var AGLUTINACIONES_LAMINA_BRUCELLA = aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_BRUCELLA) == null ? "-" : aglutinaciones_lamina.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.AGLUTINACIONES_LAMINA_BRUCELLA).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        
                        new PdfPCell(new Phrase("AGLUTINACIONES FEBRILES EN LAMINA (T, PT, Br)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 

                        new PdfPCell(new Phrase("   TIFICO O", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AGLUTINACIONES_LAMINA_O, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   TIFICO H", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AGLUTINACIONES_LAMINA_H, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   PARATIFICO A", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AGLUTINACIONES_LAMINA_A, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   PARATIFICO B", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AGLUTINACIONES_LAMINA_B, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   BRUCELLA ABORTUS", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(AGLUTINACIONES_LAMINA_BRUCELLA, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }





                if (PCR_PROTEINA_C_REACTIVA_CUALITATIVA != null)
                {
                    var PCR_PROTEINA_C_REACTIVA_CUALITATIVA_VALOR = PCR_PROTEINA_C_REACTIVA_CUALITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUALITATIVA_VALOR) == null ? "- - -" : PCR_PROTEINA_C_REACTIVA_CUALITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUALITATIVA_VALOR).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PROTEINA C REACTIVA", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   PROTEINA C REACTIVA \n   (CUALITATIVO):", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PCR_PROTEINA_C_REACTIVA_CUALITATIVA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("Negativo", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (PCR_PROTEINA_C_REACTIVA_CUANTITATIVA != null)
                {
                    var PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR = PCR_PROTEINA_C_REACTIVA_CUANTITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR) == null ? "-" : PCR_PROTEINA_C_REACTIVA_CUANTITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR).v_Value1;
                    var PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR_UNIDAD = PCR_PROTEINA_C_REACTIVA_CUANTITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR) == null ? "-" : PCR_PROTEINA_C_REACTIVA_CUANTITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR).v_MeasurementUnitName;
                    var PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_DESEABLE = PCR_PROTEINA_C_REACTIVA_CUANTITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_DESEABLE) == null ? "-" : PCR_PROTEINA_C_REACTIVA_CUANTITATIVA.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_DESEABLE).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PROTEINA C REACTIVA (CUANTITATIVO)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   PROTEINA C REACTIVA:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PCR_PROTEINA_C_REACTIVA_CUANTITATIVA_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                if (psa_total != null)
                {
                    var PSA_VALOR = psa_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSA_VALOR) == null ? "-" : psa_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSA_VALOR).v_Value1;
                    var PSA_VALOR_UNIDAD = psa_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSA_VALOR) == null ? "-" : psa_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSA_VALOR).v_MeasurementUnitName;
                    var PSA_VALOR_DESEABLE = psa_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSA_VALOR_DESEABLE) == null ? "-" : psa_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PSA_VALOR_DESEABLE).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PSA (ANTIGENO PROSTATICO ESPECIFICO)", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   PSA TOTAL \n   (Método: Quimioluminiscencia):", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSA_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSA_VALOR_DESEABLE, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PSA_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (sars_cov_2 != null)
                {
                    var SARS_COV_2_VALOR = sars_cov_2.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SARS_COV_2_VALOR) == null ? "-" : sars_cov_2.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SARS_COV_2_VALOR).v_Value1;
                    
                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("COVID-19", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Prueba rápida de antígeno SARS-CoV-2 \n   Método: Inmunocromatografía:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(SARS_COV_2_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (sifilis != null)
                {
                    var SIFILIS_VALOR = sifilis.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SIFILIS_VALOR) == null ? "-" : sifilis.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SIFILIS_VALOR).v_Value1Name;
                    var SIFILIS_DESEADO = sifilis.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SIFILIS_DESEADO) == null ? "-" : sifilis.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.SIFILIS_DESEADO).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("Prueba de Sífilis", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   Sífilis (IgG, IgM, IgA)\n   Método: Inmunocromatografía:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(SIFILIS_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(SIFILIS_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase("", fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                     };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (perfil_tiroideo_total != null)
                {
                    var PTT_T3_VALOR = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T3_VALOR) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T3_VALOR).v_Value1;
                    var PTT_T3_VALOR_UNIDAD = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T3_VALOR) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T3_VALOR).v_MeasurementUnitName;
                    var PTT_T3_VALOR_DESEADO = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T3_VALOR_DESEADO) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T3_VALOR_DESEADO).v_Value1;

                    var PTT_T4_VALOR = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T4_VALOR) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T4_VALOR).v_Value1;
                    var PTT_T4_VALOR_UNIDAD = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T4_VALOR) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T4_VALOR).v_MeasurementUnitName;
                    var PTT_T4_VALOR_DESEADO = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T4_VALOR_DESEADO) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_T4_VALOR_DESEADO).v_Value1;

                    var PTT_TSH_VALOR = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_TSH_VALOR) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_TSH_VALOR).v_Value1;
                    var PTT_TSH_VALOR_UNIDAD = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_TSH_VALOR) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_TSH_VALOR).v_MeasurementUnitName;
                    var PTT_TSH_VALOR_DESEADO = perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_TSH_VALOR_DESEADO) == null ? "-" : perfil_tiroideo_total.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTT_TSH_VALOR_DESEADO).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PERFIL TIROIDEO TOTAL", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   TSH ultrasensible:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_TSH_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_TSH_VALOR_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_TSH_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   T3 total:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_T3_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_T3_VALOR_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_T3_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   T4 total:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_T4_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_T4_VALOR_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTT_T4_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }

                if (perfil_tiroideo_libre != null)
                {
                    var PTL_T3_VALOR = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T3_VALOR) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T3_VALOR).v_Value1;
                    var PTL_T3_VALOR_UNIDAD = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T3_VALOR) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T3_VALOR).v_MeasurementUnitName;
                    var PTL_T3_VALOR_DESEADO = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T3_VALOR_DESEADO) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T3_VALOR_DESEADO).v_Value1;

                    var PTL_T4_VALOR = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T4_VALOR) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T4_VALOR).v_Value1;
                    var PTL_T4_VALOR_UNIDAD = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T4_VALOR) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T4_VALOR).v_MeasurementUnitName;
                    var PTL_T4_VALOR_DESEADO = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T4_VALOR_DESEADO) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_T4_VALOR_DESEADO).v_Value1;

                    var PTL_TSH_VALOR = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_TSH_VALOR) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_TSH_VALOR).v_Value1;
                    var PTL_TSH_VALOR_UNIDAD = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_TSH_VALOR) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_TSH_VALOR).v_MeasurementUnitName;
                    var PTL_TSH_VALOR_DESEADO = perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_TSH_VALOR_DESEADO) == null ? "-" : perfil_tiroideo_libre.ServiceComponentFields.Find(p => p.v_ComponentFieldsId == Sigesoft.Common.Constants.PTL_TSH_VALOR_DESEADO).v_Value1;

                    cells = new List<PdfPCell>()
                    {
                        new PdfPCell(new Phrase("PERFIL TIROIDEO LIBRE", fontColumnValueBold)) { Colspan = 19, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda,  UseVariableBorders = true, BorderColorLeft = colorPlantilla, BorderColorRight = colorPlantilla, BorderColorBottom = colorPlantilla, BorderColorTop = colorPlantilla },                 
                        
                        new PdfPCell(new Phrase("   TSH ultrasensible:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_TSH_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_TSH_VALOR_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_TSH_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   T3 total:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_T3_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_T3_VALOR_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_T3_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                        new PdfPCell(new Phrase("   T4 total:", fontColumnValue)) { Colspan = 8, HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_T4_VALOR, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_T4_VALOR_DESEADO, fontColumnValue)) { Colspan = 5, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    
                        new PdfPCell(new Phrase(PTL_T4_VALOR_UNIDAD, fontColumnValue)) { Colspan = 3, HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, MinimumHeight = tamaño_celda_1, Border = PdfPCell.NO_BORDER},    

                    };

                    columnWidths = new float[] { 9f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 3f, 8f, 5f, 5f, 5f, 5f, 5f, 5f, 5f, 5f };
                    table = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);
                    document.Add(table);
                }


                
            }

            #endregion

            #region Firma y sello Médico

            table = new PdfPTable(2);
            table.HorizontalAlignment = Element.ALIGN_RIGHT;
            table.WidthPercentage = 40;

            columnWidths = new float[] { 15f, 40f };
            table.SetWidths(columnWidths);

            PdfPCell cellFirma = null;

            if (DatosGrabo != null)
            {
                cellFirma = new PdfPCell(HandlingItextSharp.GetImage(DatosGrabo.Firma, null, null, 160, 80)) { HorizontalAlignment = PdfPCell.ALIGN_CENTER };
            }
            else
            {
                cellFirma = new PdfPCell();
            }
            cellFirma.HorizontalAlignment = Element.ALIGN_RIGHT;
            cellFirma.VerticalAlignment = Element.ALIGN_MIDDLE;
            cellFirma.MinimumHeight = 50f;

            cells = new List<PdfPCell>()
                {
                    new PdfPCell(new Phrase("", fontColumnValueBold)) {HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, FixedHeight = 3f,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE},    
                    new PdfPCell(cellFirma){MinimumHeight = 60f, HorizontalAlignment = PdfPCell.ALIGN_RIGHT,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.WHITE},
                    //new PdfPCell(new Phrase("Huella", fontColumnValueBold)) {HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER, VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE, FixedHeight = 12f,  UseVariableBorders = true, BorderColorLeft = BaseColor.WHITE, BorderColorRight = BaseColor.WHITE, BorderColorBottom = BaseColor.WHITE, BorderColorTop = BaseColor.BLACK},    
                 };
            columnWidths = new float[] { 100F };

            filiationWorker = HandlingItextSharp.GenerateTableFromCells(cells, columnWidths, null, fontTitleTable);

            document.Add(filiationWorker);

            #endregion
            document.Close();
            writer.Close();
            writer.Dispose();
        }
    }
}
