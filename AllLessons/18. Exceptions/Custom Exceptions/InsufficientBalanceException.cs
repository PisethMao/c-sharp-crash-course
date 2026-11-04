namespace FirstProgram._18._Exceptions.Custom_Exceptions;

public sealed class InsufficientBalanceException(string message) : Exception(message);