using AuthService2024010.Application.Interfaces;

namespace AuthService2024010.Api.Models;

public class FormFileAdapter : IFileData
{
    private readonly IFormFile formfile;
    private byte[]? fileData;

    public FormFileAdapter(IFormFile formfile)
    {
        ArgumentNullException.ThrowIfNull(formfile);
        _formfile = formfile;
    }

    public byte[] Data
    {
        get
        {
            if(_data == null)
            {
                using var memoryStream = new MemoryStream();
                _formfile.CopyTo(memoryStream);
                _data = memoryStream.ToArray();
            }
            return Data;
        }
    }

    public string ContentType => _formfile.ContentType;
    public string FileName => _formfile.FileName;
    public long Size => _formfile.Length;
    
}