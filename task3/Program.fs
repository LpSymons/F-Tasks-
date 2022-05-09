// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

//Comment----- 
type Account = {AccountNumber:int; Balance: float;}

//Comment
let account1 = {AccountNumber=0102; Balance=5.00}
let account2 = {AccountNumber=0103; Balance=10.00}
let account3 = {AccountNumber=0104; Balance=51.00}
let account4 = {AccountNumber=0105; Balance=100.00}
let account5 = {AccountNumber=0106; Balance=150.00}
let account6 = {AccountNumber=0107; Balance=75.00}

//Comment
let accounts = [account1; account2; account3; account4; account5; account6;]

//Comment
let sequence1 = seq {for n in accounts do if (n.Balance >= 00.00 && n.Balance < 50.00) then n} 

//Comment
let sequence2 = seq {for n in accounts do if (n.Balance > 50.00) then n} 
    
//Comment
let f (x : seq<Account>) =
    for n in x do 
        let header = if (n.Balance >= 00.00 && n.Balance < 50.00) then "Sequence 1 : " else "Sequence 2 : "
        printfn "%s%d" header n.AccountNumber    

f sequence1 
f sequence2