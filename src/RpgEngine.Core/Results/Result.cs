namespace RpgEngine.Core.Results;

public sealed class Result
{
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public string? ErrorMessage { get; }

    private Result(bool isSuccess, string? error)
    {
        IsSuccess = isSuccess;
        ErrorMessage = error;
    }

    public static Result Success() => new(true, null);

    public static Result Failure(string errorMessage)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(errorMessage, nameof(errorMessage));

        return new Result(false, errorMessage);
    }
}