using RpgEngine.Core.Results;

namespace RpgEngine.Core.Tests.Results;

public sealed class ResultTests
{
    [Fact]
    public void Success_ShouldReturnSuccessResult()
    {
        // Act
        var result = Result.Success();

        // Assert
        Assert.True(result.IsSuccess);
        Assert.False(result.IsFailure);
        Assert.Null(result.ErrorMessage);
    }

    [Fact]
    public void Failure_ShouldReturnFailureResult()
    {
        const string errorMessage = "Error occurred";
        // Act
        var result = Result.Failure(errorMessage);

        // Assert
        Assert.False(result.IsSuccess);
        Assert.True(result.IsFailure);
        Assert.Equal(errorMessage, result.ErrorMessage);
    }

    [Fact]
    public void Failure_WithEmptyError_ShouldThrowArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => Result.Failure(string.Empty));
    }

    [Fact]
    public void Failure_WithWhitespaceError_ShouldThrowArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => Result.Failure("   "));
    }

    [Fact]
    public void Failure_WithNullError_ShouldThrowArgumentNullException()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Result.Failure(null!));
    }
}