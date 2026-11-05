namespace FirstProgram._20._C__New_Features.C__8.Default_Interface_Members.Default_Properties;

public interface IEmployee
{
    decimal MonthlySalary { get; }

    decimal AnnualSalary => MonthlySalary * 12;
}