namespace builder.src.interfaces
{
    public interface IMealBuilderProtocol
    {
        IMealBuilderProtocol MakeMeal();
        IMealBuilderProtocol MakeBeverage();
        IMealBuilderProtocol MakeDessert();
    }
}