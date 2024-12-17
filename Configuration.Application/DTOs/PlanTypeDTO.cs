namespace Configuration.Application.DTOs;

public class PlanTypeDTO
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    //public ConsumerDTO? ConsumerSingle { get; set; }
}
