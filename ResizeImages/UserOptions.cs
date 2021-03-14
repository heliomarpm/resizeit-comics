using ResizeImages.Core;
using System.IO;

namespace ResizeImages
{

    public struct UserOptions
    {
        private const string DIR_ORIGEM = "%DIR_ORIGEM%";

        public bool InputDirExists => Directory.Exists(this.InputFullPath);
        public bool InputFileExists => File.Exists(this.InputFullPath);

        public bool SeekRecursively { get; set; }
        public string SeekImageExtensions { get; set; }

        public string InputFullPath { get; set; }

        public string InputDirectory => this.InputDirExists ? Path.GetDirectoryName(this.InputFullPath) : string.Empty;

        public string InputFileName => this.InputFileExists ? Path.GetFileNameWithoutExtension(this.InputFullPath) : string.Empty;

        public string InputExtension => this.InputFileExists ? Path.GetExtension(this.InputFullPath) : string.Empty;

        public string OutputFullPath => Path.Combine(this.OutputDirectory, this.OutputFileName);

        public bool CustomOutputDirectory { get; set; }

        private string _outDirectory;
        public string OutputDirectory
        {
            get => this.OutputType switch
            {
                GenerateImages.EOutputType.Copy => this.CustomOutputDirectory ? OutputDirName : $@"{DIR_ORIGEM}\__output\",
                GenerateImages.EOutputType.Cbz => this.CustomOutputDirectory ? $@"{OutputDirName}" : $@"{DIR_ORIGEM}\",
                GenerateImages.EOutputType.Pdf => this.CustomOutputDirectory ? $@"{OutputDirName}" : $@"{DIR_ORIGEM}\",
                GenerateImages.EOutputType.Replace or
                GenerateImages.EOutputType.ReplaceWithBackup => this.CustomOutputDirectory ? OutputDirName : $@"{DIR_ORIGEM}\",
                _ => _outDirectory,
            };
            set
            {
                _outDirectory = value;
            }
        }

        private string OutputDirName => (string.IsNullOrEmpty(Path.GetDirectoryName(_outDirectory)) ? DIR_ORIGEM : Path.GetDirectoryName(_outDirectory)) + @"\";

        public string OutputFileName => this.InputFileExists ? this.InputFileName + this.OutputFileExtension : string.Empty;

        public GenerateImages.EOutputType OutputType { get; set; }

        public string OutputFileExtension => this.OutputType switch
        {
            GenerateImages.EOutputType.Cbz => ".cbz",
            GenerateImages.EOutputType.Pdf => ".pdf",
            _ => this.InputExtension,
        };
    }

}
