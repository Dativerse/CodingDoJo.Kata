namespace BestTimeToBuySellStockTests;

public class BestTimeToBuySellStockTest
{
    [Test]
    public void max_profit_when_have_value_input_correct_value_1()
    {
        int[] input = [7, 1, 5, 3, 6, 4];
        const int expected = 5;

        var result = MaxProfit(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }
    
    [Test]
    public void max_profit_when_have_value_input_correct_value_2()
    {
        int[] input = [2, 4, 1];
        const int expected = 2;

        var result = MaxProfit(input);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    private int MaxProfit(int[] prices)
    {
        var startPoint = prices[0];
        var maxProfit = 0;

        foreach (var price in prices)
        {
            var profit = price - startPoint;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
            
            if (price < startPoint)
            {
                startPoint = price;
            }
        }

        return maxProfit;
    }
}