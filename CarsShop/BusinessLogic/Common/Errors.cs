namespace CarsShop.BusinessLogic.Common;

public class Errors(string message)
    : Exception (message)
{

}
