namespace FirstProgram._17._Generic.Generic_Record_Struct;

public readonly record struct Result<T>(
    T Value,
    bool IsSuccess
);