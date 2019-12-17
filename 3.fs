module Problem3
(*
  The prime factors of 13195 are 5, 7, 13 and 29.

  What is the largest prime factor of the number 600851475143 ?
*)

let n = 600851475143L

let isqrt v = v |> float |> sqrt |> int64

let rec keepDividingBy2 (v: int64) = 
  if v % 2L = 0L
  then keepDividingBy2 (v / 2L)
  else v

let testPrimeFactor acc i =
  if (fst acc) % i = 0L
  then (fst acc / i, i)
  else acc

let searchForFactors n = 
  [3L .. 2L .. isqrt n]
  |> List.fold testPrimeFactor (n, 1L)
  |> snd 

n
|> keepDividingBy2
|> searchForFactors
|> printfn "%A" 