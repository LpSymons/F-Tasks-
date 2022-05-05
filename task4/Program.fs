// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.Threading

let myLock = ref 1

type Ticket = {seat:int; customer:string}

let mutable ticket = [for n in 1..10 -> {Ticket.seat = n; Ticket.customer = ""}]

let DisplayTickets (x : Ticket list) =
    for n in x do 
        printfn "%d -> %s" n.seat n.customer


DisplayTickets ticket

let BookSeat _ =
    lock(myLock)(fun()->
                        Console.WriteLine("Please enter seat number")
                        let seat = Console.ReadLine() |> int
                        Console.WriteLine("Please enter your name")
                        let name = Console.ReadLine()
                        let newticket = {seat=seat; customer=name}
                        //list.map help!!!
                        printfn "%s" "seat does not exist")


ThreadPool.QueueUserWorkItem(new WaitCallback(BookSeat)) |> ignore

ThreadPool.QueueUserWorkItem(new WaitCallback(BookSeat)) |> ignore

Thread.Sleep(10000)

DisplayTickets ticket

(*
for n in ticket do 
    if n.seat = seat then ticket.[seat] = newticket |>ignore 
    else printfn "%s" "seat does not exist" ) *)