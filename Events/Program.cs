

var stock = new Stock("Mazikx");

stock.Price = 100;

stock.OnPriceChanged += foo.Stock_OnPriceChanged;


stock.ChangeStockPriceBy(0.5m);
stock.ChangeStockPriceBy(-0.2m);
stock.ChangeStockPriceBy(0.0m);

stock.OnPriceChanged -= foo.Stock_OnPriceChanged;

Console.WriteLine("\nAfter unsubscribe\n");

stock.ChangeStockPriceBy(0.5m);
stock.ChangeStockPriceBy(-0.2m);
stock.ChangeStockPriceBy(0.0m);
