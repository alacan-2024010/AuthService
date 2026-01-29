namespace AuthService2024010.Application.DTOs;

public class EmailResponseDto
{
    public bool Success{get;set;} = false;
    public string Message{get;set;} = string.Empty;
    public object? Data{get;set;}
}