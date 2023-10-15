
//using Ionic.Zip;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.IO.Compression;

namespace ResizeImages.Core
{
    public class GenPackageFile
    {
        public enum ETypeFile
        {
            CbzFile = 1,
            PdfFile = 2
        }

        public string Save(string pathImages, ETypeFile saveType)
        {
            if (string.IsNullOrEmpty(pathImages))
            {
                throw new ArgumentException($"'{nameof(pathImages)}' não pode ser nulo ou vazio", nameof(pathImages));
            }

            var singleFile = File.Exists(pathImages);
            var fileName = Path.GetFileNameWithoutExtension(pathImages);

            if (!singleFile)
            {
                pathImages += @"\"; // para garantiar que irá pegar a pasta temporaria
                fileName = new DirectoryInfo(Directory.GetParent(pathImages).Parent.FullName).Name;
            }

            var extFile = saveType == ETypeFile.CbzFile ? ".cbz" : ".pdf";
            var tempDir = Directory.GetParent(pathImages).FullName;
            var saveFile = Path.Combine(Directory.GetParent(tempDir).Parent.FullName, $"{fileName}{extFile}");

            if (saveType == ETypeFile.CbzFile)
            {
                SaveCbz(tempDir, saveFile);
            }
            else
            {
                SavePdf(pathImages, saveFile);
            }

            Utils.DeleteDir(tempDir);

            return saveFile;
        }

        private void SaveCbz(string inputPath, string pathSaveFile)
        {
            Utils.DeleteFile(pathSaveFile);
            ZipFile.CreateFromDirectory(inputPath, pathSaveFile);
        }

        private void SavePdf(string inputPath, string pathSaveFile)
        {
            // Create a new PDF document
            var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            var fs = new FileStream(pathSaveFile, FileMode.Create);
            var wPdf = PdfWriter.GetInstance(doc, fs);

            doc.Open();

            if (File.Exists(inputPath))
            {
                //se arquivo unico                
                var img = iTextSharp.text.Image.GetInstance(inputPath);

                doc.SetPageSize(new iTextSharp.text.Rectangle(img.Width, img.Height));
                doc.NewPage();

                img.SetAbsolutePosition(0, 0);
                wPdf.DirectContent.AddImage(img);
            }
            else
            {
                var imageFiles = Directory.GetFiles(inputPath, "*.*"); //.Where(f => fileExtensions.Contains(Path.GetExtension(f).ToLower()));
                //Array.Sort(imageFiles.ToArray(), new AlphanumComparatorFast());

                //importing the images in the pdf
                foreach (string imageFile in imageFiles)
                {
                    //checking file extension
                    //string ext = Path.GetExtension(imageFile).ToLower();
                    //if ((string.Compare(ext, ".jpg") == 0) || (string.Compare(ext, ".jpeg") == 0) || (string.Compare(ext, ".png") == 0) || (string.Compare(ext, ".bmp") == 0) || (string.Compare(ext, ".new") == 0))
                    //{                                                 
                    var img = iTextSharp.text.Image.GetInstance(imageFile);

                    doc.SetPageSize(new iTextSharp.text.Rectangle(img.Width, img.Height));
                    doc.NewPage();

                    img.SetAbsolutePosition(0, 0);
                    wPdf.DirectContent.AddImage(img);
                    //}
                }
            }

            //save file
            doc.Close();
            doc.Dispose();

            fs.Close();
            fs.Dispose();

            wPdf.Close();
            wPdf.Dispose();
        }

        /*
        public void CreateCbz(string pathImages, string fileExtensions = "*.jpg;*.jpeg;*.png")
        {
            if (string.IsNullOrEmpty(pathImages))
            {
                throw new ArgumentException($"'{nameof(pathImages)}' não pode ser nulo ou vazio", nameof(pathImages));
            }

            //var cbzName = Path.Combine(pathImages, new DirectoryInfo(pathImages).Name + ".cbz");
            //System.IO.Compression.ZipFile.CreateFromDirectory(pathImages, pathImages + ".cbz");

            var tempDir = Path.Combine(pathImages, Guid.NewGuid().ToString().Substring(0, 8));

            if (!Directory.Exists(tempDir))
                Directory.CreateDirectory(tempDir);

            var imageFiles = Directory.GetFiles(pathImages, "*.*").Where(f => fileExtensions.Contains(Path.GetExtension(f).ToLower()));

            int count = 0;
            string copyFileName;
            foreach (var file in imageFiles)
            {
                copyFileName = count.ToString().PadLeft(imageFiles.Count()) + Path.GetExtension(file);
                File.Copy(file, Path.Combine(tempDir, copyFileName), true);
                count++;
            }

            var cbzName = Path.Combine(pathImages, new DirectoryInfo(pathImages).Name + ".cbz");

            Utils.DeleteFile(cbzName);
            ZipFile.CreateFromDirectory(tempDir, cbzName);
            Utils.DeleteDir(tempDir);

            //using (ZipFile zip = new ZipFile())
            //{
            //    //	zip.CompressionLevel = Ionic.Zlib.CompressionLevel.BestSpeed;
            //    //zip.CompressionMethod = CompressionMethod.None;
            //    zip.AddDirectory(tempCbz);
            //    // zip.Comment = "This zip was created at " + System.DateTime.Now.ToString("G");
            //    zip.Save(tempCbz);
            //}
        }
        */
        /*
        public void CreatePdf(string pathImages, string fileExtensions = "*.jpg;*.jpeg;*.png")
        {
            if (string.IsNullOrEmpty(pathImages))
            {
                throw new ArgumentException($"'{nameof(pathImages)}' não pode ser nulo ou vazio", nameof(pathImages));
            }


            string fileName = Path.Combine(pathImages, new DirectoryInfo(pathImages).Name + ".pdf");

            // Create a new PDF document
            var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
            //using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
            //{
            var fs = new FileStream(fileName, FileMode.Create);

            var wPdf = PdfWriter.GetInstance(doc, fs);
            //using (var wPdf = PdfWriter.GetInstance(doc, fs))
            //{
            doc.Open();

            if (File.Exists(pathImages))
            {
                //se arquivo unico                
                var img = iTextSharp.text.Image.GetInstance(pathImages);

                doc.SetPageSize(new iTextSharp.text.Rectangle(img.Width, img.Height));
                doc.NewPage();

                img.SetAbsolutePosition(0, 0);
                wPdf.DirectContent.AddImage(img);
            }
            else
            {
                var imageFiles = Directory.GetFiles(pathImages, "*.*").Where(f => fileExtensions.Contains(Path.GetExtension(f).ToLower()));
                //Array.Sort(imageFiles.ToArray(), new AlphanumComparatorFast());

                //importing the images in the pdf
                foreach (string imageFile in imageFiles)
                {
                    //checking file extension
                    //string ext = Path.GetExtension(imageFile).ToLower();
                    //if ((string.Compare(ext, ".jpg") == 0) || (string.Compare(ext, ".jpeg") == 0) || (string.Compare(ext, ".png") == 0) || (string.Compare(ext, ".bmp") == 0) || (string.Compare(ext, ".new") == 0))
                    //{                                                 
                    var img = iTextSharp.text.Image.GetInstance(imageFile);

                    doc.SetPageSize(new iTextSharp.text.Rectangle(img.Width, img.Height));
                    doc.NewPage();

                    img.SetAbsolutePosition(0, 0);
                    wPdf.DirectContent.AddImage(img);
                    //}
                }
            }
            //}


            //save file
            doc.Close();
            doc.Dispose();


            fs.Close();
            fs.Dispose();

            wPdf.Close();
            wPdf.Dispose();
            //}

        }
        */
    }
}
