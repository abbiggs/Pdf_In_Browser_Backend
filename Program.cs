using System;
using System.IO;
using PDFiumSharp;



namespace PDF_In_Brower_Backend
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfDocument document = new PdfDocument("pdf's/CS 369 REGISTRATION.pdf");
            PdfPageCollection pageCollection = document.Pages;
            PdfPage page = pageCollection[0];
            PDFiumBitmap bitmap = new PDFiumBitmap(300, 300, true);
            //From my understanding, this renders the PdfPage to the bitmap. The bitmap is simply the target.
            page.Render(bitmap);
            
            
            Stream stream = new MemoryStream();
            document.Save(stream);
            
            
            
            
            
            
            
            
            /*try{
                PdfDocument document = PdfDocument.Load("pdf's/CS 369 REGISTRATION.pdf");
                var bitMapImg = document.Render(1, 300, 300, true);
                bitMapImg.Save("pdf's", ImageFormat.Png);
            }catch(FileNotFoundException ex){
                Console.WriteLine("File Not Found");

            }catch(System.BadImageFormatException ex1){
                Console.WriteLine("Incorrect Image Format");
            }*/

        }
    }
}
