using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DarkNetCoursePlatform.Application.Commands.Prices.GetPrices
{
    public class GetPricesCommand
    {
    }
    
    public record PriceResponse(
        Guid Id,
        string Name,
        decimal CurrentPrice,
        decimal PromotionalPrice
    );
}