using System.IO;

namespace BlazorPDFReport
{
    public class GeneratePDF
    {
        private string url { get; set; } = default!;

        public GeneratePDF(string url)
        {
            this.url = url;
        }

        public byte[] GetPDF()
        {
            var switches = $"-q {url} -";

            string rotativaPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/rotativa", "wkhtmltopdf.exe");

            using (var proc=new Process())
            {
                try
                {
                    proc.StartInfo = new ProcessStartInfo()
                    {
                        FileName = rotativaPath,
                        Arguments = switches,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        CreateNoWindow = true
                    };
                    proc.Start();
                } catch (Exception ex) { throw ex; };

                using (var ms = new MemoryStream())
                {
                    proc.StandardOutput.BaseStream.CopyTo(ms);
                    return ms.ToArray();
                }
            }

        }

    }
}
