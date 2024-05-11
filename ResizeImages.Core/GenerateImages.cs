using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ResizeImages.Core
{
    public struct ResizeScale
    {
        public ResizeScale(float width, float height, bool isPercentage = false, bool preserveOrientation = true, bool preserveAspectRatio = true)
        {
            this.Width = width;
            this.Height = height;
            this.IsPercentage = isPercentage;
            this.PreserveOrientation = preserveOrientation;
            this.PreserveAspectRatio = preserveAspectRatio;
        }

        public float Width { get; set; }
        public float Height { get; set; }

        public bool IsPercentage { get; private set; }
        public bool PreserveOrientation { get; private set; }
        public bool PreserveAspectRatio { get; private set; }
    }

    public class GenerateImages
    {
        public enum EOutputType
        {
            None,
            Cbz,
            Pdf,
            Copy,
            Replace,
            ReplaceWithBackup
        }

        public GenerateImages()
        {
            this.Outputs = new List<string>();
            this.Output = new Dictionary<string, Dictionary<string, List<string>>>();
        }

        public List<string> Outputs { get; private set; }

        /// <summary>
        /// Dir. Origem / Dir. Destino / Arquivos
        /// </summary>
        public Dictionary<string, Dictionary<string, List<string>>> Output { get; private set; }

        private void SaveBackup(string pathFile, string backFolder)
        {
            if (!Directory.Exists(backFolder))
                Directory.CreateDirectory(backFolder);

            File.Copy(pathFile, Path.Combine(backFolder, Path.GetFileName(pathFile)), true);
        }

        private ResizeScale ResetScale(ResizeScale scale, int widthImgOriginal, int heightImgOriginal)
        {
            bool retrato = widthImgOriginal <= heightImgOriginal;

            if (scale.Width < 1) scale.Width = widthImgOriginal;
            if (scale.Height < 1) scale.Height = heightImgOriginal;

            //Redimensiona o tamanho da imagem
            float width = scale.Width;
            float height = scale.Height;

            // Se é pra manter a orientação, inverte a largura e a altura se a orientação deve ser preservada
            if (scale.PreserveOrientation && (width <= height && !retrato))
            {
                (width, height) = (height, width);
            }

            if (scale.IsPercentage)
            {
                width = widthImgOriginal * (width / 100);
                height = heightImgOriginal * (height / 100);
            }
            else if (scale.PreserveAspectRatio)
            {
                if (width > 0)
                {
                    //if (width == widthImgOriginal)
                    //{
                    //    height = heightImgOriginal; //mantem original
                    //}
                    //else
                    //{
                    //float percetual = (float)width / widthImgOriginal;
                    height = width == widthImgOriginal
                            ? heightImgOriginal
                            : heightImgOriginal * (width / widthImgOriginal);
                    //}
                }
                else if (height > 0)
                {
                    //if (height == heightImgOriginal)
                    //{
                    //    width = widthImgOriginal; //mantem original
                    //}
                    //else
                    //{
                    //float percetual = (float)height / heightImgOriginal;
                    width = height == heightImgOriginal
                        ? widthImgOriginal
                        : widthImgOriginal * (height / heightImgOriginal);
                    //}
                }
            }

            //if (width == 0 || height == 0)
            //{
            //    width = widthImgOriginal;
            //    height = heightImgOriginal;
            //}
            // Garante que width e height sejam valores válidos
            if (width <= 0) width = widthImgOriginal;
            if (height <= 0) height = heightImgOriginal;

            scale.Width = width;
            scale.Height = height;
            return scale;
        }

        private static ImageCodecInfo GetEncoderInfo(ImageFormat imageFormat)
        {
            string mimeType = $"image/{imageFormat.ToString().ToLower()}";

            // Get image codecs for all image formats
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();

            // Find the correct image codec
            for (int i = 0; i < codecs.Length; i++)
                if (codecs[i].MimeType.ToLower() == mimeType)
                    return codecs[i];

            return null;
        }

        public string Save(string inputFile, ResizeScale scale, string outputFile = null, string pathBackup = null)
        {
            if (string.IsNullOrEmpty(outputFile))
                outputFile = inputFile;

            string inPath = Path.GetDirectoryName(inputFile);
            string outPath = Path.GetDirectoryName(outputFile);
            string outFile = Path.GetFileName(outputFile);

            if (string.IsNullOrEmpty(outFile))
                outFile = Path.GetFileName(inputFile);

            outputFile = Path.Combine(outPath, outFile);

            #region "SE SOLICITADO, SALVA BACKUP ANTES DE ALTERAR."

            if (!string.IsNullOrEmpty(pathBackup))
            {
                pathBackup = Path.GetDirectoryName(pathBackup); // normaliza o valor

                if (inPath != pathBackup)
                {
                    if (outputFile == Path.Combine(pathBackup, Path.GetFileName(inputFile)))
                        throw new ArgumentException("Local de Backup não pode ser o mesmo do local de destino");

                    this.SaveBackup(inputFile, pathBackup);
                }
            }

            #endregion

            #region "CRIA IMAGEM COM NOVAS DIMENSOES"

            // cria o diretorio de output se necessario
            if (!Directory.Exists(outPath))
                Directory.CreateDirectory(outPath);

            //outPath = $@"{outPath}\{Path.GetFileName(inputFile)}";

            Bitmap imgOutput;
            ImageCodecInfo imgCodec;

            using (var img = Image.FromFile(inputFile))
            {
                imgCodec = GetEncoderInfo(img.RawFormat);
                scale = ResetScale(scale, img.Width, img.Height);
                imgOutput = new Bitmap(img, (int)scale.Width, (int)scale.Height);
            }

            // Para evitar o erro de GDI+ quando o caminho é muito longo
            using (MemoryStream ms = new())
            {
                imgOutput.Save(ms, imgCodec, null);
                imgOutput.Dispose();

                // Se arquivo estiver bloqueado cria um nome aleatorio
                //if (!Utils.DeleteFile(outputFile))
                //{
                //    outputFile = $@"{Path.GetFileNameWithoutExtension(outputFile)}_{Guid.NewGuid().ToString().Substring(0, 8)}{Path.GetExtension(outputFile)}";
                //    outputFile = Path.Combine(outPath, outputFile);
                //}

                File.WriteAllBytes(outputFile, ms.ToArray());
            }

            #endregion

            #region "GUARDA LISTA DOS ARQUIVOS PROCESSADOS"

            if (!this.Output.ContainsKey(inPath))
                this.Output.Add(inPath, new Dictionary<string, List<string>>());

            if (!this.Output[inPath].ContainsKey(outPath))
                this.Output[inPath].Add(outPath, new List<string>());

            this.Output[inPath][outPath].Add(outputFile);

            this.Outputs.Add(outputFile);

            #endregion

            return outputFile;
        }
    }
}
