Imports System.IO

Module globalVars
    Public totalChange As Single
    Public SalesRevenue As Single
    Public ChangeRevenue As Single
    Public forfeitChange As Boolean
    Public AmountRemoved As Single

    'Drink Capacity
    Public CapDrink1, CapDrink2, CapDrink3, CapDrink4, CapDrink5, CapDrink6,
        CapDrink7, CapDrink8, CapDrink9, CapDrink10, CapDrink11, CapDrink12 As Short

    'Coin Capacity
    Public Cap5cent, Cap10cent, Cap20cent, Cap50cent, Cap1euro, Cap2euro As Short

    'Change per Coin
    Public Change5cent, Change10cent, Change20cent, Change50cent, Change1euro, Change2euro As Short

    'Drink Prices
    Public Drink1Price, Drink2Price, Drink3Price, Drink4Price, Drink5Price, Drink6Price,
        Drink7Price, Drink8Price, Drink9Price, Drink10Price, Drink11Price, Drink12Price As Single

    'Drinks Sold
    Public Drink1Sold, Drink2Sold, Drink3Sold, Drink4Sold, Drink5Sold, Drink6Sold,
        Drink7Sold, Drink8Sold, Drink9Sold, Drink10Sold, Drink11Sold, Drink12Sold As Short


End Module
