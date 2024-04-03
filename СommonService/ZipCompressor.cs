using System.IO.Compression;

namespace SpecialComponentInstaller
{
    /// <summary>
    /// Копмрессор сжимает и раcсжимает файлы.
    /// </summary>
    public static class ZipCompressor 
    {
        /// <summary>
        /// Разархивирует Файлы 
        /// </summary>
        /// <param name="compressedFile">Путь к сжатому файлу</param>
        /// <param name="targetFile">Путь разархивции</param>
        /// <returns></returns>
        public static void DecompressAsync(string compressedFile, string targetFile)
        {
            try
            {
                ZipFile.ExtractToDirectory(compressedFile, targetFile);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        /// <summary>
        /// Архивирует файл
        /// </summary>
        /// <param name="sourceFile">Путь к файлу</param>
        /// <param name="compressedFile">Путь где расположить сжатый файл</param>
        /// <returns></returns>
        public static void CompressAsync(string sourceFile, string compressedFile)
        {
           ZipFile.CreateFromDirectory(sourceFile, compressedFile);
        }

    }
}
