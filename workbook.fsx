let sum a b = a + b

let sumD a (b: double) = a + b

let add2 = sum 2

let divide nr dr = 
  if (dr = 0) then Error("Cannot divide by 0.")
  else Ok(nr / dr)