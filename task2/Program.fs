// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

//Record for information about an account
//type Account = { AccountNumber: int; mutable Balance: float; Name: string;}

//let account = 
//    { AccountNumber = 0001
//      Balance = 5.00
//      Name = "Joe"}

//let account2 = 
//    { AccountNumber = 0002
//      Balance = 100.00
//      Name = "Andy"}

type Accounts = {AccountNumber:int; Balance: float;}

type User = 
    | User of Accounts


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

 


User {AccountNumber=0102; Balance=5.00 }
|> checkAccount

User {AccountNumber=0103; Balance=10.00}
|> checkAccount

User {AccountNumber=0104; Balance=51.00}
|> checkAccount

User {AccountNumber=0105; Balance=100.00}
|> checkAccount

User {AccountNumber=0106; Balance=150.00}
|> checkAccount

User {AccountNumber=0106; Balance=75.00}
|> checkAccount

//let user1 = User {Balance = 10.00; AccountNumber = 0104;}
//|> checkAccount




(*
type Account =
    | AccountNumber of int
    | Balance of float
    | Name of string

//Account holders information
let joe = Balance(5.00)
let mark = Balance(50.00)
let carl = Balance(150.00)
let mike = Balance(25.00)
let james = Balance(200.00)
let andy = Balance(8.00)

let accounts = [joe; mark; carl; mike; james; andy;]

//Method thats checks balance and displays appropriate message
let CheckAccount v =
    for a in accounts do
    match a with
    | Balance(float)->if (float < 10.00) then
                         Console.WriteLine("Balance is Low")
                      elif (float >= 10.00 && float <= 100.00) then
                         Console.WriteLine("Balance is Ok")
                      elif (float > 100.00) then 
                         Console.WriteLine("Balance is High")

CheckAccount accounts
*)