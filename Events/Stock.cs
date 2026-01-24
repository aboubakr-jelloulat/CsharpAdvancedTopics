
public class Stock // Publisher
{
    public delegate void StockPriceChangeHandler(Stock stock, decimal OldPrice);
    public event StockPriceChangeHandler OnPriceChanged;


    private string _name;

    private decimal _price;

    public string Name {get;}

    public decimal Price {get; set; }

    public Stock(string stockname)
    {
        this._name = stockname;
    }

    public void ChangeStockPriceBy(decimal percent)
    {
        decimal oldPrice = this.Price;

        this.Price += Math.Round(this.Price * percent, 2);

        if (OnPriceChanged is not null) // make sure there is subscriber ** Listen
        {
            OnPriceChanged(this, oldPrice); // firing the event

        }
    }
}

