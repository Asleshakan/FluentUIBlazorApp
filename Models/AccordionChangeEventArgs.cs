using System.Text.Json.Serialization;

public class AccordionChangeEventArgs
{
    public AccordionChangeEventArgs()
    {
        SomeProperty = string.Empty; // Initialize with a default value
    }

    [JsonConstructor]
    public AccordionChangeEventArgs(string someProperty)
    {
        SomeProperty = someProperty;
    }

    public string SomeProperty { get; set; }
}
