// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System

let mutable balance = 0


Console.WriteLine("Welcome please Enter your account number")
let accountNumber = string(Console.ReadLine())
Console.WriteLine("Welcome  ")
Console.WriteLine(accountNumber)

//Print method to show the menu
let printMenu () = 
    printfn "Please select one of the folllwing options"
    printfn "1. Deposit Money"
    printfn "2. Show Balance"
let getInput () = Int32.TryParse (Console.ReadLine())

//Method to deposit money into the balance
let depositMoney () = 
    printfn "Deposit Money"
    printfn "Please Enter amount you wish to add (Numbers Only)"
    let a = int(Console.ReadLine())
    let b = 0
    let c = a + b
    balance <- c + balance
    printfn "%i" balance
    
//Method to show then balance of account 
let showBalance (int) = 
    Console.WriteLine("Balance : ")
    printfn "%i" balance   
    
//Menu Selection method
let rec menu ()=
    printMenu()
    match getInput() with 
    | true, 1 ->
        depositMoney()
        menu()
    |true, 2 ->
        showBalance()
        menu()


menu()






