using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using iText.Layout.Borders;
using PDFtoImage;
using SkiaSharp;




namespace ResizeImages.Core
{
    public class LoadPdf
    {
        public static List<string> LoadFilePdfSavePics(string pdfFilePath, string outputFolderPath)
        {
            List<string> strings = new List<string>();
           

            int page = 0;

            foreach (var image in PDFtoImage.Conversion.ToImages(File.ReadAllBytes(pdfFilePath), options: new(Dpi: 72)))
            {
               
                using var outputStream = new FileStream(
                        outputFolderPath+"\\"+Path.GetFileNameWithoutExtension(pdfFilePath) +(page + 1).ToString("D3")+".jpg",
                        FileMode.CreateNew,
                        FileAccess.ReadWrite,
                        FileShare.None,
                        4096,
                        FileOptions.SequentialScan);
                image.Encode(outputStream, SKEncodedImageFormat.Jpeg, 80);

                strings.Add(outputFolderPath + "\\" + Path.GetFileNameWithoutExtension(pdfFilePath) + (page + 1).ToString("D3") + ".jpg");

                 page++;
            }
            return strings;
        }
            
    }
}
