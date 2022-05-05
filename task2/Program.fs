// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

//Record storage of types 
type Accounts = {AccountNumber:int; Balance: float;}

//Record storage thats stores users of type account
type User = 
    | User of Accounts

//Method that prints a users account number and balance and prints appropriate message
let checkAccount account =
    match account with 
    | User {AccountNumber=n;Balance=b;} -> if b < 10.00 then
                                                printfn $"Account Number:{n} Balance: {b}" 
                                                Console.WriteLine("Balance is Low")
                                            elif b >= 10.00 && b < 100.00 then
                                                printfn $"Account Number:{n} Balance: {b}"
                                                Console.WriteLine("Balance is Ok")
                                            elif b >= 100.00 then
                                                printfn $"Account Number:{n} Balance: {b}"
                                                Console.WriteLine("Balance is High")

 //Users added to record and then passed to checkAccount method
User {AccountNumber=0102; Balance=5.00}
|> checkAccount
 //Users added to record and then passed to checkAccount method
User {AccountNumber=0103; Balance=10.00}
|> checkAccount
 //Users added to record and then passed to checkAccount method
User {AccountNumber=0104; Balance=51.00}
|> checkAccount
 //Users added to record and then passed to checkAccount method
User {AccountNumber=0105; Balance=100.00}
|> checkAccount
 //Users added to record and then passed to checkAccount method
User {AccountNumber=0106; Balance=150.00}
|> checkAccount
 //Users added to record and then passed to checkAccount method
User {AccountNumber=0107; Balance=75.00}
|> checkAccount

