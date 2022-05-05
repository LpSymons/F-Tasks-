// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System




type Account =
    | AccountNumber of int
    | Balance of float
    | Name of string




let joe = Balance(5.00)
let mark = Balance(50.00)
let carl = Balance(150.00)






let accounts = [joe; mark; carl;]

let DisplayQualifications v =
    for a in accounts do
    match a with
    | Balance(float)->if (float < 10.00) then
                         Console.WriteLine("Balance is Low")
                      elif (float >= 10.00 && float <= 100.00) then
                         Console.WriteLine("Balance is Ok")
                      elif (float > 100.00) then 
                         Console.WriteLine("Balance is High")
                          


                     
DisplayQualifications accounts

(*
let DisplayQualifications v =
    for s in students do
    match s with
    | Degree(x,y)->Console.Write("Classification is ")
                   Console.Write(x)
                   Console.Write(":")
                   Console.WriteLine(y)
    | ShortCourse(pass)->if pass then
                             Console.WriteLine("You passed your course")
                         else
                             Console.WriteLine("You failed your course")
    | ALevel(grade)->Console.Write("Grade : ")
                     Console.WriteLine(grade)
*)

