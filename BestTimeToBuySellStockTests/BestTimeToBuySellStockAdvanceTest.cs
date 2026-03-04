namespace BestTimeToBuySellStockTests;

public class BestTimeToBuySellStockAdvanceTest
{
    [Test]
    public void max_profit_when_first_is_smaller_than_others()
    {
        int[] input = [2, 4, 1];
        const int expected = 2;

        var result = MaxProfit(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void max_profit_when_no_profit()
    {
        int[] input = [7,6,4,3,1];
        const int expected = 0;

        var result = MaxProfit(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void max_profit_when_normal()
    {
        int[] input = [1,2,3,4,5];
        const int expected = 4;

        var result = MaxProfit(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void max_profit_when_fist_bigger_than_others()
    {
        int[] input = [7, 1, 5, 3, 6, 4];
        const int expected = 7;

        var result = MaxProfit(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    private int MaxProfit(int[] prices)
    {
        var startPoint = prices[0];
        var totalProfit = 0;

        foreach (var price in prices)
        {
            var profit = price - startPoint;
            switch (profit)
            {
                case > 0:
                    totalProfit += profit;
                    startPoint = price;
                    break;
                case < 0:
                    startPoint = price;
                    break;
            }
        }

        return totalProfit;
    }
}