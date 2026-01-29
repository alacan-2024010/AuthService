namespace AuthService2024010.Domain.Interfaces;

public interface IFileData
{
    public string FileName { get; }
    public string ContentType { get; }
    public byte[] Data { get;}

    long Size { get; }
}