using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using GestionDe_Incidentes_de_Bomberos.modelo;
using System.Diagnostics;

namespace GestionDe_Incidentes_de_Bomberos.informes
{

    class Accidente
    {
        public void crearInforme(int Tipo, DateTime fechaInicio, DateTime fechaFinal)
        {
            List<ElementoMaternidad> elementoMaternidad = new List<ElementoMaternidad>();
            for (int i = 0; i < 10; i++)
            {
                ElementoMaternidad elemento = new ElementoMaternidad();
                elemento.fecha = "01/01/18";
                elemento.hora = "15:40";
                elemento.lugar = "San Pedro Sac. San Marcos ";
                elemento.cantidad = "1";
                elemento.atencionDeParto = "X";
                elemento.edad = "19";
                elemento.aborto = "";
                elemento.hospitalDeTraslado = "Hospital de San Marcos";
                elemento.fallecido = "";
                elemento.vivo = "x";
               
                elementoMaternidad.Add(elemento);
            }
            Bombero director = new Bombero();
            director.nombre = "Rene Anselmo";
            director.apellido = "Perez Perez";

            Bombero secretario = new Bombero();
            secretario.nombre = "Juan Luis";
            secretario.apellido = "Paz Paz";
            string path = Directory.GetCurrentDirectory();
            string ubicacion = path + "/prueba.pdf";

            crearPDFMaternidad("Maternidad", fechaInicio, fechaFinal, elementoMaternidad, director,secretario, ubicacion);
            Process.Start(ubicacion);
        }



        public void crearPDF(string evento, DateTime fechaInicio, DateTime fechaFinal, List<ElementoInforme> elementosInforme, Bombero director, Bombero secretario, String ubicacion)
        {
            int centrado = iTextSharp.text.Image.ALIGN_CENTER;
            //creacion del documento
            Document doc = new Document();

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@ubicacion, FileMode.Create));
            doc.AddTitle("Informe");
            doc.SetPageSize(iTextSharp.text.PageSize.LETTER.Rotate());
            doc.Open();
            iTextSharp.text.Font _contenidoTabla = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font _tituloTabla = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            //titulo 
            Paragraph parafo1 = new Paragraph("Benemerito Comite de Bomberos Voluntarios", _titulo);
            parafo1.Alignment = centrado;
            doc.Add(parafo1);
            Paragraph parafo2 = new Paragraph("19a. Compañia de Bomberos Voluntarios", _titulo);
            parafo2.Alignment = centrado;
            doc.Add(parafo2);
            Paragraph parafo3 = new Paragraph("Estadisticas de "+evento+" Mensuales ", _titulo);
            parafo3.Alignment = centrado;
            doc.Add(parafo3);
            Paragraph parafo4 = new Paragraph("Correspondiente del " + fechaInicio.ToShortDateString() +" al " + fechaFinal.ToShortDateString(), _titulo);
            parafo4.Alignment = centrado;
            doc.Add(parafo4);
            doc.Add(Chunk.NEWLINE);



            //tabla de informe 
            PdfPTable tblIncidente = new PdfPTable(9);
            tblIncidente.WidthPercentage = 100;

            //celdas
            //Titulo de las Celdas
            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", _tituloTabla));
            clFecha.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clFecha);
            PdfPCell clHora = new PdfPCell(new Phrase("Hora", _tituloTabla));
            clHora.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clHora);
            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _tituloTabla));
            clCantidad.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clCantidad);
            PdfPCell clLugar = new PdfPCell(new Phrase("Lugar", _tituloTabla));
            clLugar.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clLugar);
            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _tituloTabla));
            clNombre.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clNombre);
            PdfPCell clEdad = new PdfPCell(new Phrase("Edad", _tituloTabla));
            clEdad.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clEdad);
            PdfPCell clSexo = new PdfPCell(new Phrase("Sexo", _tituloTabla));
            clSexo.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clSexo);
            PdfPCell clVivo = new PdfPCell(new Phrase("Vivo", _tituloTabla));
            clVivo.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clVivo);
            PdfPCell clFallecido = new PdfPCell(new Phrase("Fallecido", _tituloTabla));
            clFallecido.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clFallecido);

            foreach(ElementoInforme elemento in elementosInforme)
            {
                clFecha = new PdfPCell(new Phrase(elemento.fecha, _contenidoTabla));
                clFecha.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clFecha);
                clHora = new PdfPCell(new Phrase(elemento.hora, _contenidoTabla));
                clHora.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clHora);
                clCantidad = new PdfPCell(new Phrase(elemento.cantidad, _contenidoTabla));
                clCantidad.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clCantidad);
                clLugar = new PdfPCell(new Phrase(elemento.lugar, _contenidoTabla));
                clLugar.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clLugar);
                clNombre = new PdfPCell(new Phrase(elemento.nombre, _contenidoTabla));
                clNombre.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clNombre);
                clEdad = new PdfPCell(new Phrase(elemento.edad, _contenidoTabla));
                clEdad.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clEdad);
                clSexo = new PdfPCell(new Phrase(elemento.sexo, _contenidoTabla));
                clSexo.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clSexo);
                clVivo = new PdfPCell(new Phrase(elemento.vivo, _contenidoTabla));
                clVivo.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clVivo);
                clFallecido = new PdfPCell(new Phrase(elemento.fallecido, _contenidoTabla));
                clFallecido.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clFallecido);
            }

            doc.Add(tblIncidente);

            doc.Add(Chunk.NEWLINE);

            //Firmas
            PdfPTable tblFirmas = new PdfPTable(2);
            tblIncidente.WidthPercentage = 100;
            PdfPCell clDirecto = new PdfPCell(new Phrase(director.nombre+" "+director.apellido, _tituloTabla));
            clDirecto.HorizontalAlignment = centrado;
            clDirecto.Border = 0;
            tblFirmas.AddCell(clDirecto);
            PdfPCell clSecretario = new PdfPCell(new Phrase(secretario.nombre+" "+secretario.apellido, _tituloTabla));
            clSecretario.HorizontalAlignment = centrado;
            clSecretario.Border = 0;
            tblFirmas.AddCell(clSecretario);
             clDirecto = new PdfPCell(new Phrase("Directo", _tituloTabla));
            clDirecto.HorizontalAlignment = centrado;
            clDirecto.Border = 0;
            tblFirmas.AddCell(clDirecto);
            clSecretario = new PdfPCell(new Phrase("Secretario", _tituloTabla));
            clSecretario.HorizontalAlignment = centrado;
            clSecretario.Border = 0;
            tblFirmas.AddCell(clSecretario);
            //cerrar pdf 
            doc.Add(tblFirmas);
            doc.Close();
            writer.Close();

        }
        public void crearPDFIncendios(string evento, DateTime fechaInicio, DateTime fechaFinal, List<ElementoIncendio> elementosInforme, Bombero director, Bombero secretario, String ubicacion)
        {
            int centrado = iTextSharp.text.Image.ALIGN_CENTER;

            //creacion del documento
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@ubicacion, FileMode.Create));
            doc.AddTitle("Informe");
            doc.SetPageSize(iTextSharp.text.PageSize.LETTER.Rotate());
            doc.Open();
            iTextSharp.text.Font _contenidoTabla = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font _tituloTabla = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            //titulo 
            Paragraph parafo1 = new Paragraph("Benemerito Comite de Bomberos Voluntarios", _titulo);
            parafo1.Alignment = centrado;
            doc.Add(parafo1);
            Paragraph parafo2 = new Paragraph("19a. Compañia de Bomberos Voluntarios", _titulo);
            parafo2.Alignment = centrado;
            doc.Add(parafo2);
            Paragraph parafo3 = new Paragraph("Estadisticas de " + evento + " Mensuales ", _titulo);
            parafo3.Alignment = centrado;
            doc.Add(parafo3);
            Paragraph parafo4 = new Paragraph("Correspondiente del " + fechaInicio.ToShortDateString() + " al " + fechaFinal.ToShortDateString(), _titulo);
            parafo4.Alignment = centrado;
            doc.Add(parafo4);
            doc.Add(Chunk.NEWLINE);



            //tabla de informe 
            PdfPTable tblIncidente = new PdfPTable(8);
            tblIncidente.WidthPercentage = 100;

            //celdas
            //Titulo de las Celdas
            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", _tituloTabla));
            clFecha.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clFecha);
            PdfPCell clHora = new PdfPCell(new Phrase("Hora", _tituloTabla));
            clHora.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clHora);
            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _tituloTabla));
            clCantidad.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clCantidad);
            PdfPCell clLugar = new PdfPCell(new Phrase("Lugar", _tituloTabla));
            clLugar.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clLugar);
            PdfPCell clPropietario = new PdfPCell(new Phrase("Propietario", _tituloTabla));
            clPropietario.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clPropietario);
            PdfPCell clCausa = new PdfPCell(new Phrase("causa", _tituloTabla));
            clCausa.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clCausa);
            PdfPCell clPerdidas = new PdfPCell(new Phrase("perdidas", _tituloTabla));
            clPerdidas.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clPerdidas);
            PdfPCell clAguaUtilizada = new PdfPCell(new Phrase("agua Utilizada", _tituloTabla));
            clAguaUtilizada.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clAguaUtilizada);

            foreach (ElementoIncendio elemento in elementosInforme)
            {
                clFecha = new PdfPCell(new Phrase(elemento.fecha, _contenidoTabla));
                clFecha.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clFecha);
                clHora = new PdfPCell(new Phrase(elemento.hora, _contenidoTabla));
                clHora.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clHora);
                clCantidad = new PdfPCell(new Phrase(elemento.cantidad, _contenidoTabla));
                clCantidad.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clCantidad);
                clLugar = new PdfPCell(new Phrase(elemento.lugar, _contenidoTabla));
                clLugar.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clLugar);
                clPropietario = new PdfPCell(new Phrase(elemento.propietario, _contenidoTabla));
                clPropietario.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clPropietario);
                clCausa = new PdfPCell(new Phrase(elemento.causa, _contenidoTabla));
                clCausa.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clCausa);
                clPerdidas = new PdfPCell(new Phrase(elemento.perdidas, _contenidoTabla));
                clPerdidas.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clPerdidas);
                clAguaUtilizada = new PdfPCell(new Phrase(elemento.aguaUtilizada, _contenidoTabla));
                clAguaUtilizada.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clAguaUtilizada);
            }

            doc.Add(tblIncidente);

            doc.Add(Chunk.NEWLINE);

            //Firmas
            PdfPTable tblFirmas = new PdfPTable(2);
            tblIncidente.WidthPercentage = 100;
            PdfPCell clDirecto = new PdfPCell(new Phrase(director.nombre + " " + director.apellido, _tituloTabla));
            clDirecto.HorizontalAlignment = centrado;
            clDirecto.Border = 0;
            tblFirmas.AddCell(clDirecto);
            PdfPCell clSecretario = new PdfPCell(new Phrase(secretario.nombre + " " + secretario.apellido, _tituloTabla));
            clSecretario.HorizontalAlignment = centrado;
            clSecretario.Border = 0;
            tblFirmas.AddCell(clSecretario);
            clDirecto = new PdfPCell(new Phrase("Directo", _tituloTabla));
            clDirecto.HorizontalAlignment = centrado;
            clDirecto.Border = 0;
            tblFirmas.AddCell(clDirecto);
            clSecretario = new PdfPCell(new Phrase("Secretario", _tituloTabla));
            clSecretario.HorizontalAlignment = centrado;
            clSecretario.Border = 0;
            tblFirmas.AddCell(clSecretario);
            //cerrar pdf 
            doc.Add(tblFirmas);
            doc.Close();
            writer.Close();

        }

        public void crearPDFMaternidad(string evento, DateTime fechaInicio, DateTime fechaFinal, List<ElementoMaternidad> elementosInforme, Bombero director, Bombero secretario,String ubicacion)
        {
            int centrado = iTextSharp.text.Image.ALIGN_CENTER;

            //creacion del documento
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@ubicacion, FileMode.Create));
            doc.AddTitle("Informe");
            doc.SetPageSize(iTextSharp.text.PageSize.LETTER.Rotate());
            doc.Open();
            iTextSharp.text.Font _contenidoTabla = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font _titulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font _tituloTabla = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            //titulo 
            Paragraph parafo1 = new Paragraph("Benemerito Comite de Bomberos Voluntarios", _titulo);
            parafo1.Alignment = centrado;
            doc.Add(parafo1);
            Paragraph parafo2 = new Paragraph("19a. Compañia de Bomberos Voluntarios", _titulo);
            parafo2.Alignment = centrado;
            doc.Add(parafo2);
            Paragraph parafo3 = new Paragraph("Estadisticas de " + evento + " Mensuales ", _titulo);
            parafo3.Alignment = centrado;
            doc.Add(parafo3);
            Paragraph parafo4 = new Paragraph("Correspondiente del " + fechaInicio.ToShortDateString() + " al " + fechaFinal.ToShortDateString(), _titulo);
            parafo4.Alignment = centrado;
            doc.Add(parafo4);
            doc.Add(Chunk.NEWLINE);



            //tabla de informe 
            PdfPTable tblIncidente = new PdfPTable(10);
            tblIncidente.WidthPercentage = 100;

            //celdas
            //Titulo de las Celdas
            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", _tituloTabla));
            clFecha.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clFecha);
            PdfPCell clHora = new PdfPCell(new Phrase("Hora", _tituloTabla));
            clHora.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clHora);
            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _tituloTabla));
            clCantidad.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clCantidad);
            PdfPCell clLugar = new PdfPCell(new Phrase("Lugar", _tituloTabla));
            clLugar.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clLugar);
            PdfPCell clEdad = new PdfPCell(new Phrase("Edad", _tituloTabla));
            clEdad.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clEdad);
            PdfPCell clAborto = new PdfPCell(new Phrase("Aborto", _tituloTabla));
            clAborto.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clAborto);
            PdfPCell clParto = new PdfPCell(new Phrase("Parto", _tituloTabla));
            clParto.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clParto);
            PdfPCell clHospital = new PdfPCell(new Phrase("Hospital de traslado", _tituloTabla));
            clHospital.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clHospital);
            PdfPCell clFallecido = new PdfPCell(new Phrase("Fallecido", _tituloTabla));
            clFallecido.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clFallecido);
            PdfPCell clVivo = new PdfPCell(new Phrase("Vivo", _tituloTabla));
            clVivo.HorizontalAlignment = centrado;
            tblIncidente.AddCell(clVivo);

            foreach (ElementoMaternidad elemento in elementosInforme)
            {
                clFecha = new PdfPCell(new Phrase(elemento.fecha, _contenidoTabla));
                clFecha.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clFecha);
                clHora = new PdfPCell(new Phrase(elemento.hora, _contenidoTabla));
                clHora.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clHora);
                clCantidad = new PdfPCell(new Phrase(elemento.cantidad, _contenidoTabla));
                clCantidad.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clCantidad);
                clLugar = new PdfPCell(new Phrase(elemento.lugar, _contenidoTabla));
                clLugar.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clLugar);
                clEdad = new PdfPCell(new Phrase(elemento.edad, _contenidoTabla));
                clEdad.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clEdad);
                clAborto = new PdfPCell(new Phrase(elemento.aborto, _contenidoTabla));
                clAborto.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clAborto);
                clParto = new PdfPCell(new Phrase(elemento.atencionDeParto, _contenidoTabla));
                clParto.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clParto);
                clHospital = new PdfPCell(new Phrase(elemento.hospitalDeTraslado, _contenidoTabla));
                clHospital.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clHospital);
                 clFallecido = new PdfPCell(new Phrase(elemento.fallecido, _tituloTabla));
                clFallecido.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clFallecido);
                 clVivo = new PdfPCell(new Phrase(elemento.vivo, _tituloTabla));
                clVivo.HorizontalAlignment = centrado;
                tblIncidente.AddCell(clVivo);

            }

            doc.Add(tblIncidente);

            doc.Add(Chunk.NEWLINE);

            //Firmas
            PdfPTable tblFirmas = new PdfPTable(2);
            tblIncidente.WidthPercentage = 100;
            PdfPCell clDirecto = new PdfPCell(new Phrase(director.nombre + " " + director.apellido, _tituloTabla));
            clDirecto.HorizontalAlignment = centrado;
            clDirecto.Border = 0;
            tblFirmas.AddCell(clDirecto);
            PdfPCell clSecretario = new PdfPCell(new Phrase(secretario.nombre + " " + secretario.apellido, _tituloTabla));
            clSecretario.HorizontalAlignment = centrado;
            clSecretario.Border = 0;
            tblFirmas.AddCell(clSecretario);
            clDirecto = new PdfPCell(new Phrase("Directo", _tituloTabla));
            clDirecto.HorizontalAlignment = centrado;
            clDirecto.Border = 0;
            tblFirmas.AddCell(clDirecto);
            clSecretario = new PdfPCell(new Phrase("Secretario", _tituloTabla));
            clSecretario.HorizontalAlignment = centrado;
            clSecretario.Border = 0;
            tblFirmas.AddCell(clSecretario);
            //cerrar pdf 
            doc.Add(tblFirmas);
            doc.Close();
            writer.Close();

        }
    }
}
