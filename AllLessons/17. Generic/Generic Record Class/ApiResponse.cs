namespace FirstProgram._17._Generic.Generic_Record_Class;

public record ApiResponse<T>(
    bool Success,
    string Message,
    T? Data
);