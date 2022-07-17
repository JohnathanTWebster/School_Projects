public class Stock {

    //properties

    private char   _symbol;
    private String _stockName;
    private double _previousClosePrice;
    private double _currentPrice;
    private double _percentageChange;

    //constructors

    Stock(){}

    Stock(char symbol, String name, double previousClosePrice){
        this._symbol = symbol;
        this._stockName = name;
        this._previousClosePrice = previousClosePrice;
    }

    // function and calc

    public double PercentageChange(double previousprice, double currentprice){

        double increase = currentprice - previousprice;
        return this._percentageChange = (increase / previousprice) * 100;
    }

    //getters & setters

    public void SetCurrentClosePrice(double input){
        this._currentPrice = input;
    } 
    public double GetPreviousPrice(){
        return this._previousClosePrice;
    }
    public double GetCurrentPrice(){
        return this._currentPrice;
    }
}
