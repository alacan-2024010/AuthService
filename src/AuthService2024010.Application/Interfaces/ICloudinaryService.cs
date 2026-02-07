using AuthService2024010.Domain.Interfaces;
 
namespace AuthService2024010.Application.Interfaces;
 
public interface ICloudinaryService
{
    Task<string> UploadImageAsync(IFileData imageFile, string filename);
    Task<bool> DeleteImageAsync(string publicId);
    string GetDefaultAvatarUrl();
    string GetFullImageUrl(string imagePath);
}
 