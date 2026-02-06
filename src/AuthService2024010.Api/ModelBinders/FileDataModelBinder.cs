using AuthService2024010.Api.Models;
using AuthService2024010.Application.Interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AuthService2024010.Api.ModelBinders;

public class FileDataModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ArgumentNullException.ThrowIfNull(bindingContext);  

        if(!typeof(IFileData).IsAssignableFrom(bindingContext.ModelType))
        {
            return Task.CompletedTask;
        }

        var request = bindingContext.HttpContext.Request;

        var file = request.Form.Files.GetFile(bindingContext.FieldName);
        return Task.CompletedTask;
    }
}

public class FileDataModelBinderProvider : IModelBinderProvider
{
    public IModelBinder? GetBinder(ModelBinderProviderContext context)
    {
        if (typeof(IFileData).IsAssignableFrom(context.Metadata.ModelType))
        {
            return new FileDataModelBinder();
        }

        return null;
    }
}