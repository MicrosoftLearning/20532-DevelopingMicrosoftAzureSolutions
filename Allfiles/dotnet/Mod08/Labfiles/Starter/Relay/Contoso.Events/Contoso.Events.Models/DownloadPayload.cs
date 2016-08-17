using System.IO;

namespace Contoso.Events.Models
{
    public class DownloadPayload
    {
        public Stream Stream { get; set; }

        public string ContentType { get; set; }
    }
}