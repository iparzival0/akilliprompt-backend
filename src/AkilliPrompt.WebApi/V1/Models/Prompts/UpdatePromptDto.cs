namespace AkilliPrompt.WebApi.V1.Models.Prompts;

public sealed record UpdatePromptDto(
    long Id,
    string Title,
    string Description,
    string Content,
    string? ImageUrl,
    bool IsActive,
    ICollection<long> CategoryIds,
    ICollection<string> PlaceholderNames); 