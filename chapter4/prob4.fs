\ Define a word called SIGN.TEST that will test a number on the stack and print out 
\ one of three messages: POSITIVE or NEGATIVE or ZERO

: SIGN.TEST ( n -- ) 
    dup 0> if ." POSITIVE" else 0< if ." NEGATIVE" else ." ZERO" then then ;